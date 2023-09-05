using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Cells;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace SBS_BarthLogistic.Classes
{
    class CLSImportExcel
    {
        const string ColumnProperties =
            "SELECT COLUMN_NAME, TABLE_NAME, IS_NULLABLE, CAST((CASE WHEN COLUMN_DEFAULT IS NULL THEN 0 ELSE 1 END) AS BIT) HasDefault, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, " +
            "COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') IsIdentity, " +
            "COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsComputed') IsComputed, " +
            "'' AS Caption, ISNULL(FKS.PK_Table, '') FTable, ISNULL(FKS.PK_Column, '') FColumn " +
            "FROM INFORMATION_SCHEMA.COLUMNS LEFT JOIN " +
            "(SELECT CU.COLUMN_NAME FK_Column, PK.TABLE_NAME PK_Table, PT.COLUMN_NAME PK_Column " +
            "FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS C INNER JOIN " +
            "INFORMATION_SCHEMA.TABLE_CONSTRAINTS FK ON C.CONSTRAINT_NAME = FK.CONSTRAINT_NAME INNER JOIN " +
            "INFORMATION_SCHEMA.TABLE_CONSTRAINTS PK ON C.UNIQUE_CONSTRAINT_NAME = PK.CONSTRAINT_NAME INNER JOIN " +
            "INFORMATION_SCHEMA.KEY_COLUMN_USAGE CU ON C.CONSTRAINT_NAME = CU.CONSTRAINT_NAME INNER JOIN " +
            "(SELECT i1.TABLE_NAME, i2.COLUMN_NAME " + "FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS i1 INNER JOIN " +
            "INFORMATION_SCHEMA.KEY_COLUMN_USAGE i2 ON i1.CONSTRAINT_NAME = i2.CONSTRAINT_NAME " +
            "WHERE i1.CONSTRAINT_TYPE = 'PRIMARY KEY') PT ON PT.TABLE_NAME = PK.TABLE_NAME " +
            "WHERE FK.TABLE_NAME = '{0}') FKS ON COLUMN_NAME = FKS.FK_Column AND FKS.PK_Table != TABLE_NAME WHERE TABLE_NAME = '{0}'";
        readonly List<ForeignValues> fkList = new List<ForeignValues>();
        readonly bool hasMaster;
        readonly string masterField;
        readonly string masterValue;
        readonly string tableName;
        public DataTable DtErrors;
        DataTable dtForUpload;
        DataTable dtOriginal;

        readonly List<string> ignoreList = new List<string>();

        public CLSImportExcel(string tableName, string masterField, string masterValue)
        {
            Fields = new CLSImportField();
            this.tableName = tableName;
            hasMaster = masterField != string.Empty;
            this.masterField = masterField;
            this.masterValue = masterValue;
            DtErrors = new DataTable("Import_Errors");
            DtErrors.Columns.Add("Status", typeof(string));
            DtErrors.Columns.Add("Row", typeof(int));
            DtErrors.Columns.Add("Message", typeof(string));
        }

        public CLSImportField Fields { get; set; }

        public void CreateExcelModelForUpdate(string tableNameArg, string fileNameArg,string masterField = "",string masterValue = "")
        {
            DataTable dtTableSchema = SQL.Select(string.Format(ColumnProperties, tableNameArg));
            Workbook workbook = new Workbook();
            workbook.Worksheets.Clear();
            Worksheet sheet = workbook.Worksheets.Add("Input");
            sheet.TabColor = Color.Green;
            List<DBColumn> cols = new List<DBColumn>();
            foreach (DataRow row in dtTableSchema.Rows)
            {
                string colName = row["COLUMN_NAME"].ToString();
//                if (Convert.ToBoolean(row["IsIdentity"]))
//                    continue;
                if (Convert.ToBoolean(row["IsComputed"]))
                    continue;
                if (hasMaster && colName == masterField)
                    continue;
                if (colName == "UN" || colName == "CD" || colName == "CD1")
                    continue;
                DBColumn dbColumn = new DBColumn(row, true);
                if (dbColumn.IsForeignKey && dbColumn.Type != typeof(string))
                {
                    Worksheet newSheet = workbook.Worksheets.Add(dbColumn.FTable);
                    AddTableToWorksheet(newSheet);
                }
                cols.Add(dbColumn);
            }

            var filter = "";
            if (!string.IsNullOrEmpty(this.masterField))
                filter = " WHERE " + this.masterField + " = N'" + masterValue + "'";
            DataTable dtTable = SQL.Select("SELECT * FROM " + tableNameArg + "View" + filter);

            for (int i = 0; i < cols.Count; i++)
            {
                DBColumn col = cols[i];
                sheet.Cells[0, i].Value = col.Caption;
                sheet.Cells[1, i].Value = col.ColumnName;
                sheet.Cells.Columns[i].ApplyStyle(cols[i].ColumnStyle, new StyleFlag { All = true });

                if (col.IsForeignKey && col.Type != typeof(string))
                {
                    ValidationCollection valCol = sheet.Validations;
                    Validation val = valCol[valCol.Add()];
                    val.Type = ValidationType.List;
                    val.Operator = OperatorType.None;
                    val.InCellDropDown = true;
                    val.Formula1 = "=" + col.FTable + "!B:B";
                    val.ShowError = false;
                    CellArea area;
                    area.StartRow = 2;
                    area.EndRow = dtTable.Rows.Count + 2;
                    area.StartColumn = i;
                    area.EndColumn = i;
                    val.AreaList.Add(area);
                    sheet.Cells[1, i].SetStyle(new Style
                    {
                        Pattern = BackgroundType.Solid,
                        ForegroundColor = Color.LightGray
                    });
                    for (int d = 0; d < dtTable.Rows.Count; d++)
                    {
                        sheet.Cells[d + 2, i].Value = dtTable.Rows[d][col.FTable];
                    }
                    continue;
                }
                else
                {
                    CellArea area;
                    ValidationCollection valCol = sheet.Validations;
                    Validation val = valCol[valCol.Add()];
                    if (cols[i].Type == typeof(string))
                    {
                        val.Type = ValidationType.TextLength;
                    }
                    else if (cols[i].Type == typeof(decimal))
                    {
                        val.Type = ValidationType.Decimal;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ ნამდვილი რიცხვები";
                    }
                    else if (cols[i].Type == typeof(int))
                    {
                        val.Type = ValidationType.WholeNumber;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ მთელი რიცხვები";
                    }
                    else if (cols[i].Type == typeof(bool))
                    {
                        val.Type = ValidationType.WholeNumber;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ 1 ან 0 მნიშვნელობა";
                    }
                    else if (cols[i].Type == typeof(DateTime))
                    {
                        val.Type = ValidationType.Date;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ თარიღი";
                    }
                    area.StartRow = 2;
                    area.EndRow = dtTable.Rows.Count + 2;
                    area.StartColumn = i;
                    area.EndColumn = i;
                    val.AreaList.Add(area);
                    for (int d = 0; d < dtTable.Rows.Count; d++)
                    {
                        sheet.Cells[d + 2, i].Value = dtTable.Rows[d][col.ColumnName];
                    }
                }
                sheet.Cells[1, i].SetStyle(cols[i].HeaderStyle);
            }

            workbook.Save(fileNameArg, SaveFormat.Auto);
            Process.Start(fileNameArg);
        }

        public void CreateExcelModel(string tableNameArg, string fileNameArg)
        {
            DataTable dtTableSchema = SQL.Select(string.Format(ColumnProperties, tableNameArg));
            Workbook workbook = new Workbook();
            workbook.Worksheets.Clear();
            Worksheet sheet = workbook.Worksheets.Add("Input");
            sheet.TabColor = Color.Green;
            List<DBColumn> cols = new List<DBColumn>();
            foreach (DataRow row in dtTableSchema.Rows)
            {
                string colName = row["COLUMN_NAME"].ToString();
                if (Convert.ToBoolean(row["IsIdentity"]) || Convert.ToBoolean(row["IsComputed"]))
                    continue;
                if (hasMaster && colName == masterField)
                    continue;
                if (colName == "UN" || colName == "CD" || colName == "CD1")
                    continue;
                DBColumn dbColumn = new DBColumn(row, true);
                if (dbColumn.IsForeignKey && dbColumn.Type != typeof(string))
                {
                    Worksheet newSheet = workbook.Worksheets.Add(dbColumn.FTable);
                    AddTableToWorksheet(newSheet);
                }
                cols.Add(dbColumn);
            }
            for (int i = 0; i < cols.Count; i++)
            {
                DBColumn col = cols[i];
                sheet.Cells[0, i].Value = col.Caption;
                sheet.Cells[1, i].Value = col.ColumnName;
                sheet.Cells.Columns[i].ApplyStyle(cols[i].ColumnStyle, new StyleFlag { All = true });
                if (col.IsForeignKey && col.Type != typeof(string))
                {
                    ValidationCollection valCol = sheet.Validations;
                    Validation val = valCol[valCol.Add()];
                    val.Type = ValidationType.List;
                    val.Operator = OperatorType.None;
                    val.InCellDropDown = true;
                    val.Formula1 = "=" + col.FTable + "!B:B";
                    val.ShowError = false;
                    CellArea area;
                    area.StartRow = 2;
                    area.EndRow = 50000;
                    area.StartColumn = i;
                    area.EndColumn = i;
                    val.AreaList.Add(area);
                    sheet.Cells[1, i].SetStyle(new Style
                    {
                        Pattern = BackgroundType.Solid,
                        ForegroundColor = Color.LightGray
                    });
                    continue;
                }
                else
                {
                    CellArea area;
                    ValidationCollection valCol = sheet.Validations;
                    Validation val = valCol[valCol.Add()];
                    if (cols[i].Type == typeof(string))
                    {
                        val.Type = ValidationType.TextLength;
                    }
                    else if (cols[i].Type == typeof(decimal))
                    {
                        val.Type = ValidationType.Decimal;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ ნამდვილი რიცხვები";
                    }
                    else if (cols[i].Type == typeof(int))
                    {
                        val.Type = ValidationType.WholeNumber;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ მთელი რიცხვები";
                    }
                    else if (cols[i].Type == typeof(bool))
                    {
                        val.Type = ValidationType.WholeNumber;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ 1 ან 0 მნიშვნელობა";
                    }
                    else if (cols[i].Type == typeof(DateTime))
                    {
                        val.Type = ValidationType.Date;
                        val.ErrorMessage = "გთხოვთ შეიტანოთ თარიღი";
                    }
                    area.StartRow = 2;
                    area.EndRow = 5000;
                    area.StartColumn = i;
                    area.EndColumn = i;
                    val.AreaList.Add(area);
                }
                sheet.Cells[1, i].SetStyle(cols[i].HeaderStyle);
            }

            workbook.Save(fileNameArg, SaveFormat.Auto);
            Process.Start(fileNameArg);
        }

        static void AddTableToWorksheet(Worksheet sheet)
        {
            DataTable dt = SQL.Select(string.Format("SELECT Id{0},{0} FROM {0}", sheet.Name));
            int i = 0;
            //            sheet.Cells[0, 0].Value = "Id" + sheet.Name;
            //            sheet.Cells[0, 1].Value = sheet.Name;
            foreach (DataRow row in dt.Rows)
            {
                sheet.Cells[i, 0].Value = row["Id" + sheet.Name];
                sheet.Cells[i, 1].Value = row[sheet.Name];
                i++;
            }
        }

        public void FillDgFromExcel(GridControl dgCnobari, string file)
        {
            Workbook wb = new Workbook(file);
            Worksheet inputSheet = wb.Worksheets["Input"];
            GridView gv = dgCnobari.MainView as GridView;
            gv?.Columns.Clear();
            dtOriginal = new DataTable();
            for (int i = 0; i <= inputSheet.Cells.MaxColumn; i++)
            {
                object caption = inputSheet.Cells[0, i].Value;
                string colName = inputSheet.Cells[1, i].Value.ToString();
                GridColumn col = new GridColumn
                {
                    Name = "col" + colName,
                    Caption = caption == null ? colName : caption.ToString(),
                    FieldName = colName,
                    Visible = true,
                    VisibleIndex = 1
                };
                col.BestFit();
                dtOriginal.Columns.Add(col.FieldName);
                gv?.Columns.Add(col);
            }
            for (int i = 2; i <= inputSheet.Cells.MaxRow; i++)
            {
                DataRow newRow = dtOriginal.NewRow();
                for (int j = 0; j < dtOriginal.Columns.Count; j++)
                {
                    if (dtOriginal.Columns[j].ColumnName.StartsWith("Id"))
                    {
                        newRow[j] = inputSheet.Cells[i, j].Value;
                    }
                    newRow[j] = inputSheet.Cells[i, j].Value;
                }
                dtOriginal.Rows.Add(newRow);
            }

            dgCnobari.DataSource = dtOriginal;
        }

        public bool ValidateInfo(bool update)
        {
            ignoreList.Clear();
            DataTable dtTableSchema = SQL.Select(string.Format(ColumnProperties, tableName));
            dtForUpload = dtOriginal.Copy();
            foreach (DataColumn dCol in dtOriginal.Columns)
            {
                DataRow[] schemaRows = dtTableSchema.Select("COLUMN_NAME = '" + dCol.ColumnName + "'");
                if (schemaRows.Length == 0)
                {
                    XtraMessageBox.Show($"ცრილის ველი '{dCol.ColumnName}' ვერ მოიძებნა ცხრილში", "ვალიდაციის შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                DataRow row = schemaRows[0];
                DBColumn col = new DBColumn(row, false);
                if (hasMaster && (col.ColumnName == masterField || col.ColumnName == masterField.TrimEnd('1')+"2")) continue;
                bool ans = CheckData(col, update);
                if (ans) continue;
                return false;
            }
            return true;
        }

        bool CheckData(DBColumn col, bool update)
        {
            bool ans = true;
            for (int i = 0; i < dtForUpload.Rows.Count; i++)
            {
                string value = dtForUpload.Rows[i][col.ColumnName].ToString();
                //bool isNull = string.IsNullOrEmpty(value);

                //Id-ს უნიკალურობის შემოწმება
                if (col.ColumnName == "Id" + tableName)
                {
                    DataTable dtPk = SQL.Select(string.Format("SELECT {0} FROM {0} WHERE Id{0} = N'{1}'",
                        tableName, value));
                    if (!update && dtPk.Rows.Count > 0)
                    {
                        CreateErrorLog($"ცხრილში კოდი '{value}' უკვე გატარებულია: '{dtPk.Rows[0][0]}'-ზე", i);
                        ignoreList.Add(value);
                        ans = true;
                    }
                    else if (update && dtPk.Rows.Count != 1)
                    {
                        CreateErrorLog($"კოდი '{value}': ვერ მოიძებნა", i);
                        ans = false;
                    }
                }

                if (col.Type == typeof(string) && col.MaxLength < value.Length)
                {
                    CreateErrorLog(
                        $"'{col.Caption}'-ის მაქსიმალური სიგრძე {col.MaxLength}. არსებული ({value.Length}) '{value}'", i);
                    ans = false;
                }

                //სხვა ცხრილებთან კავშირის გადამოწმება
                if (!col.IsForeignKey) continue;
                ForeignValues f = fkList.FirstOrDefault(a => a.TableName == col.FTable && a.Value == value);
                if (f == null)
                {
                    DataTable dtFk =
                        SQL.Select(string.Format("SELECT {0} FROM {1} WHERE {3} = N'{2}'", col.FColumn, col.FTable,
                            value, col.Type == typeof(string) ? "Id" + col.FTable : col.FTable));
                    if (dtFk.Rows.Count == 0)
                    {
                        DialogResult dialogAns = XtraMessageBox.Show(
                            $"'{col.Caption}-{col.FTable}'-ცხრილში ვერ მოიძებნა ჩანწერი '{value}'\nგსურთ ავტომატურად ცხრილის პირველი ჩანაწერი?", "ვალიდაციის შეცდომა", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        //CreateMissingCnobari fm = new CreateMissingCnobari(col.ColumnName, col.FTable, col.FColumn);
                        //DialogResult dialogAns = fm.ShowDialog();
                        if (dialogAns == DialogResult.Yes)
                        {
                            DataTable dtFkTemp =
                                SQL.Select($"SELECT TOP 1 {col.FColumn} FROM {col.FTable}");
                            if (dtFkTemp.Rows.Count == 0)
                            {
                                CreateErrorLog($"ცხრილი '{col.FTable}' ცარიელია", i);
                            }
                            else
                            {
                                ForeignValues fv = new ForeignValues(dtFkTemp.Rows[0][0].ToString(), value, col.FTable);
                                fkList.Add(fv);
                                dtForUpload.Rows[i][col.ColumnName] = fv.Id;
                            }
                        }
                        else
                            ans = false;
                    }
                    else
                    {
                        if (dtFk.Rows.Count > 1)
                        {
                            XtraMessageBox.Show(
                                $"'{col.Caption}-{col.FTable}' ცხრილიში '{dtFk.Rows[0][0]}' ჩანაწერი რამოდენიმეჯერე მეორდება, პროგრამა ავტომატურად აარჩევს პირველ ჩანაწერს", "გაფრთხილება", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        ForeignValues fv = new ForeignValues(dtFk.Rows[0][0].ToString(), value, col.FTable);
                        fkList.Add(fv);
                        dtForUpload.Rows[i][col.ColumnName] = fv.Id;
                    }
                }
                else
                {
                    dtForUpload.Rows[i][col.ColumnName] = f.Id;
                }
            }

            dtForUpload.AcceptChanges();
            return ans;
        }

        void CreateErrorLog(string message, int row)
        {
            DataRow errorRow = DtErrors.NewRow();
            errorRow["Status"] = errorRow;
            errorRow["Message"] = message;
            errorRow["Row"] = row;
            DtErrors.Rows.Add(errorRow);
        }

        /// <summary>
        ///     dtForUpload ცხრილის ჩატვირთვა ბაზაში
        /// </summary>
        /// <param name="gv"></param>
        public void Update(GridView gv)
        {
            DataTable dt = SQL.Select(string.Format(ColumnProperties, tableName));
            DataTable dtTable = SQL.Select("SELECT * FROM " + tableName + "View");
            List<DBColumn> cols = new List<DBColumn>();
            foreach (DataRow row in dt.Rows)
            {
                string colName = row["COLUMN_NAME"].ToString();
                if (Convert.ToBoolean(row["IsIdentity"]) || Convert.ToBoolean(row["IsComputed"]))
                    continue;
                if (hasMaster && colName == masterField)
                    continue;
                DBColumn dbColumn = new DBColumn(row, true);
                cols.Add(dbColumn);
            }

            for (int i = 0; i < dtForUpload.Rows.Count; i++)
            {
                StringBuilder cmd1 = new StringBuilder($"UPDATE {tableName} SET ");
                DataRow row = dtForUpload.Rows[i];
                DataRow[] rows = dtTable.Select("Id" + tableName + " = '" + row["Id" + tableName] + "'");
                if (rows.Length != 1) continue;
                foreach (DBColumn col in cols)
                {
                    if (col.ColumnName == "Id" + tableName) continue;
                    switch (col.ColumnName)
                    {
                        case "UN":
                            cmd1.Append("UN = N'" + GlobalParameters.UserName + "',");
                            continue;
                        case "CD":
                            cmd1.Append("CD = GETDATE(),");
                            continue;
                        case "CD1":
                            cmd1.Append("CD1 = GETDATE(),");
                            continue;
                    }
                    bool contains = dtForUpload.Columns.Contains(col.ColumnName);
                    object newValue = string.Empty;
                    object oldValue = rows[0][col.ColumnName];
                    bool isNull = !contains || string.IsNullOrEmpty(row[col.ColumnName].ToString());

                    if (!contains) continue;
                    if (isNull && col.Type != typeof(string))
                    {
                        if (col.HasDefault)
                        {
                            newValue = "DEFAULT";
                            isNull = false;
                        }
                        //else if (col.AllowNulls)
                        //{
                        //    value = "NULL";
                        //    isNull = false;
                        //}
                    }
                    else
                        newValue = row[col.ColumnName];
                    if (newValue.ToString() == oldValue.ToString())
                        continue;
                    cmd1.Append(col.ColumnName + " = ");

                    Type dataType = col.Type;
                    if (dataType == typeof(string))
                    {
                        cmd1.AppendFormat("N'" + (isNull ? string.Empty : newValue) + "',");
                    }
                    else if (dataType == typeof(decimal) || dataType == typeof(int))
                    {
                        cmd1.AppendFormat((isNull ? "0" : newValue) + ",");
                    }
                    else if (dataType == typeof(bool))
                    {
                        cmd1.AppendFormat((isNull ? "1" : (Convert.ToBoolean(newValue) ? "1" : "0")) + ",");
                    }
                    else if (dataType == typeof(DateTime))
                    {
                        if (isNull || newValue.ToString() == "DEFAULT")
                        {
                            cmd1.AppendFormat("GETDATE(),");
                        }
                        else
                        {
                            cmd1.AppendFormat("'{0}',",
                                Convert.ToDateTime(newValue).ToString(GlobalParameters.ServerDateTimeFormat));
                        }
                    }
                    else
                    {
                        cmd1.Append("NULL,");
                    }
                }

                string txtComm = cmd1.ToString().TrimEnd(',') + " WHERE Id" + tableName + " = N'" +
                                 row["Id" + tableName] + "'";
                try
                {
                    GlobalParameters.cn.Open();
                    new SqlCommand(txtComm, GlobalParameters.cn).ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog(txtComm);
                    if (XtraMessageBox.Show("დაფიქსირდა შეცდომა ატვირთვისას, შეწყდეს ატვირთვა?",
                        StringParameters.CaptionError, MessageBoxButtons.YesNo, MessageBoxIcon.Error) ==
                        DialogResult.Yes)
                        return;
                }
                finally
                {
                    GlobalParameters.cn.Close();
                }
            }
            XtraMessageBox.Show("იმპორტი დასრულებულია", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     dtForUpload ცხრილის ჩატვირთვა ბაზაში
        /// </summary>
        /// <param name="gv"></param>
        public void Import(GridView gv)
        {
            DataTable dt = SQL.Select(string.Format(ColumnProperties, tableName));
            List<DBColumn> cols = new List<DBColumn>();
            foreach (DataRow row in dt.Rows)
            {
                string colName = row["COLUMN_NAME"].ToString();
                if (Convert.ToBoolean(row["IsIdentity"]) || Convert.ToBoolean(row["IsComputed"]))
                    continue;
                if (hasMaster && colName == masterField)
                    continue;
                DBColumn dbColumn = new DBColumn(row, true);
                cols.Add(dbColumn);
            }

            for (int i = 0; i < dtForUpload.Rows.Count; i++)
            {
                StringBuilder cmd1 = new StringBuilder($"INSERT INTO {tableName}(");
                StringBuilder cmd2 = new StringBuilder(" VALUES(");

                if (hasMaster)
                {
                    cmd1.Append(masterField + ",");
                    cmd2.Append("N'" + masterValue + "',");
                }
                DataRow row = dtForUpload.Rows[i];
                bool breakLine = false;
                foreach (DBColumn col in cols)
                {
                    switch (col.ColumnName)
                    {
                        case "UN":
                            cmd1.Append("UN,");
                            cmd2.Append("N'" + GlobalParameters.UserName + "',");
                            continue;
                        case "CD":
                            cmd1.Append("CD,");
                            cmd2.Append("GETDATE(),");
                            continue;
                        case "CD1":
                            cmd1.Append("CD1,");
                            cmd2.Append("GETDATE(),");
                            continue;
                    }

                    if (col.ColumnName == "Id" + tableName && ignoreList.Contains(row[col.ColumnName].ToString()))
                    {
                        breakLine = true;
                        break;
                    }
                    bool contains = dtForUpload.Columns.Contains(col.ColumnName);
                    object value = string.Empty;
                    bool isNull = !contains || string.IsNullOrEmpty(row[col.ColumnName].ToString());

                    if (contains)
                    {
                        if (isNull && col.Type != typeof(string))
                        {
                            if (col.HasDefault)
                            {
                                value = "DEFAULT";
                                isNull = false;
                            }
                            //else if (col.AllowNulls)
                            //{
                            //    value = "NULL";
                            //    isNull = false;
                            //}
                        }
                        else
                            value = row[col.ColumnName];
                    }
                    else
                    {
                        if (col.HasDefault)
                        {
                            value = "DEFAULT";
                            isNull = false;
                        }
                        //else if (col.AllowNulls)
                        //{
                        //    value = "NULL";
                        //    isNull = false;
                        //}
                    }

                    cmd1.Append(col.ColumnName + ",");

                    Type dataType = col.Type;
                    if (dataType == typeof(string))
                    {
                        cmd2.AppendFormat("N'" + (isNull ? string.Empty : value) + "',");
                    }
                    else if (dataType == typeof(decimal) || dataType == typeof(int))
                    {
                        cmd2.AppendFormat((isNull ? "0" : value) + ",");
                    }
                    else if (dataType == typeof(bool))
                    {
                        cmd2.AppendFormat((isNull ? "1" : value) + ",");
                    }
                    else if (dataType == typeof(DateTime))
                    {
                        if (isNull || value.ToString() == "DEFAULT")
                        {
                            cmd2.AppendFormat("GETDATE(),");
                        }
                        else
                        {
                            cmd2.AppendFormat("'{0}',",
                                Convert.ToDateTime(value).ToString(GlobalParameters.ServerDateTimeFormat));
                        }
                    }
                    else
                    {
                        cmd2.Append("NULL,");
                    }
                }
                if (breakLine) continue;
                string txtComm = cmd1.ToString().TrimEnd(',') + ")" + cmd2.ToString().TrimEnd(',') + ")";
                try
                {
                    GlobalParameters.cn.Open();
                    new SqlCommand(txtComm, GlobalParameters.cn).ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog(txtComm);
                    if (XtraMessageBox.Show("დაფიქსირდა შეცდომა ატვირთვისას, შეწყდეს ატვირთვა?",
                        StringParameters.CaptionError, MessageBoxButtons.YesNo, MessageBoxIcon.Error) ==
                        DialogResult.Yes)
                        return;
                }
                finally
                {
                    GlobalParameters.cn.Close();
                }
            }
            XtraMessageBox.Show("იმპორტი დასრულებულია", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        class ForeignValues
        {
            public ForeignValues(string id, string value, string tableName)
            {
                Id = id;
                Value = value;
                TableName = tableName;
            }

            public string Id { get; }
            public string Value { get; }
            public string TableName { get; }
        }
    }

    class DBColumn
    {
        public DBColumn(DataRow row, bool setStyle)
        {
            DataType = row["DATA_TYPE"].ToString().ToLower();
            TableName = row["TABLE_NAME"].ToString();
            ColumnName = row["COLUMN_NAME"].ToString();
            FTable = row["FTable"].ToString();
            FColumn = row["FColumn"].ToString();
            IsForeignKey = FTable != string.Empty;
            HasDefault = Convert.ToBoolean(row["HasDefault"].ToString());
            AllowNulls = row["IS_NULLABLE"].ToString() == "YES";
            if (!string.IsNullOrEmpty(row["CHARACTER_MAXIMUM_LENGTH"].ToString()))
                MaxLength = Convert.ToInt32(row["CHARACTER_MAXIMUM_LENGTH"]);
            //IsIdentity = Convert.ToBoolean(row["IsIdentity"]);
            //IsComputed = Convert.ToBoolean(row["IsComputed"]);
            Caption = CLSCustomCnobari.GetText(IsForeignKey ? FTable : ColumnName, TableName);
            if (setStyle) SetStyle();
            SetType();
        }

        public string DataType { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Caption { get; set; }
        public string FTable { get; set; }
        public string FColumn { get; set; }
        public int MaxLength { get; set; }
        public bool AllowNulls { get; set; }
        public bool IsForeignKey { get; set; }
        public bool HasDefault { get; set; }
        public Type Type { get; set; }
        public Style HeaderStyle { get; set; }
        public Style ColumnStyle { get; set; }
        //public bool IsIdentity { get; set; }
        //public bool IsComputed { get; set; }

        public void SetType()
        {
            switch (DataType)
            {
                case "int":
                case "smallint":
                case "bigint":
                    Type = typeof(int);
                    break;
                case "money":
                case "smallmoney":
                case "numeric":
                case "decimal":
                case "float":
                    Type = typeof(decimal);
                    break;
                case "bit":
                    Type = typeof(bool);
                    break;
                case "datetime":
                case "smalldatetime":
                case "date":
                    Type = typeof(DateTime);
                    break;
                case "nvarchar":
                case "varchar":
                    Type = typeof(string);
                    break;
            }
        }

        public void SetStyle()
        {
            HeaderStyle = new Style();
            ColumnStyle = new Style();
            switch (DataType)
            {
                case "int":
                case "smallint":
                case "bigint":
                    ColumnStyle.Number = 1;
                    HeaderStyle.Pattern = BackgroundType.Solid;
                    HeaderStyle.ForegroundColor = Color.Aqua;
                    break;
                case "money":
                case "smallmoney":
                case "numeric":
                case "decimal":
                case "float":
                    ColumnStyle.Number = 1;
                    HeaderStyle.Pattern = BackgroundType.Solid;
                    HeaderStyle.ForegroundColor = Color.Aqua;
                    break;
                case "bit":
                    ColumnStyle.Number = 0;
                    HeaderStyle.Pattern = BackgroundType.Solid;
                    HeaderStyle.ForegroundColor = Color.LightSalmon;
                    break;
                case "datetime":
                case "smalldatetime":
                case "date":
                    ColumnStyle.Number = 14;
                    ColumnStyle.Custom = "dd/MM/yyyy";
                    HeaderStyle.Pattern = BackgroundType.Solid;
                    HeaderStyle.ForegroundColor = Color.LightGreen;
                    break;
                case "nvarchar":
                case "varchar":
                    ColumnStyle.Number = 49;
                    break;
            }
        }
    }
}