using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aspose.Cells;
using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using SBS_BarthLogistic.Interfaces;
using ComboBox = System.Windows.Forms.ComboBox;

namespace SBS_BarthLogistic.Classes
{
    class CLSExcel
    {
        public static int ReportNumber = 1;
        readonly DataTable dt;
        readonly DataTable dtNo;

        readonly int[] xlsPanelParamsCol =
        {
            0, 0, 0, 0, 4, 4, 4, 4, 8, 8, 8, 8
        };

        readonly int[] xlsPanelParamsRow =
        {
            1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4
        };

        readonly string[] xlsPanelParamsValue = new string[40];
        readonly int[] xlsParamsCol;
        readonly int[] xlsParamsRow;
        readonly string[] xlsParamsValue;
        string ext;
        string fileName;
        bool is2007;
        string mizeziWhyNotImported;
        Worksheet sheet;
        int startCol;
        int startRow;
        Workbook workbook;
        int xlsPanelParamsCount;
        int xlsParamsCount;

        public static void ExportToExcel(GridControl dg)
        {
            var name = GlobalParameters.MonacemebiFolder + dg.Name.Substring(2) + ReportNumber + ".xls";
            dg.ExportToXls(name);
            Process.Start(name);
        }

        public static void ExportToExcel(PivotGridControl pt)
        {
            var name = GlobalParameters.MonacemebiFolder + pt.Name.Substring(2) + ReportNumber + ".xls";
            pt.ExportToXls(name, new XlsExportOptionsEx
            {
                ExportType = ExportType.WYSIWYG
            });
            CLSTools.OpenFile(name);
        }

        public static void ExportToExcel(PivotGridControl pt, string nameForReports)
        {
            var name = GlobalParameters.MonacemebiFolder + nameForReports + ReportNumber + ".xls";
            pt.ExportToXls(name, new XlsExportOptionsEx
            {
                ExportType = ExportType.WYSIWYG
            });
            CLSTools.OpenFile(name);
        }

        public static void ExportToExcel(GridControl dg, string nameForReports)
        {
            var name = GlobalParameters.MonacemebiFolder + nameForReports + ReportNumber + ".xls";
            dg.ExportToXls(name);
            Process.Start(name);
        }

        public static void ExportToExcel(PivotGridControl pt, string nameForReports, PanelControl pa)
        {
            string name = GlobalParameters.MonacemebiFolder + nameForReports + ReportNumber++ + ".xls";
            pt.ExportToXls(name, new XlsExportOptionsEx
            {
                ExportType = ExportType.WYSIWYG
            });
            Workbook workbook = new Workbook(name);
            Worksheet sheet = workbook.Worksheets[0];

            sheet.Cells.InsertRow(0);

            foreach (IFMGFindControl cr in pa.Controls.OfType<IFMGFindControl>().Where(a => a.Checked))
            {
                sheet.Cells.InsertRow(0);
                sheet.Cells[0, 0].Value = string.Format("{0}: {1}", cr.GetValue(), cr.Text);
            }
            sheet.Cells.InsertRow(0);
            workbook.Save(name);
            CLSTools.OpenFile(name);
        }


        public void GetFileList(string filter, ComboBox cbFileName, string extention)
        {
            var s = Directory.GetFiles(GlobalParameters.ReportsFolder, filter + extention);
            cbFileName.Items.Clear();
            foreach (var item in s)
            {
                var s1 = item.Substring(item.LastIndexOf("\\", StringComparison.Ordinal) + 1,
                    item.Length - item.LastIndexOf("\\", StringComparison.Ordinal) - 1);
                s1 = s1.Substring(0, s1.Length - 4);
                cbFileName.Items.Add(s1);
            }
            try
            {
                cbFileName.Text = cbFileName.Items[0].ToString();
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
        }

        public string ExportPtFull(PivotGridControl pt, string strFileName)
        {
            pt.ExportToXls(strFileName, new XlsExportOptionsEx
            {
                AllowGrouping = DefaultBoolean.False
            });
            CLSTools.OpenFile(strFileName);
            return strFileName;
        }

        public string Export(string tableNameForFastExport)
        {
            var outputFileName = GlobalParameters.MonacemebiFolder + fileName + ReportNumber + ext;
            var designer = new WorkbookDesigner();

            designer.Workbook = new Workbook(GlobalParameters.ReportsFolder + fileName + ext);
            dt.TableName = tableNameForFastExport;
            designer.SetDataSource(dt);

            designer.Process();

            designer.Workbook.Save(outputFileName);

            try
            {
                workbook = new Workbook(outputFileName);
                sheet = workbook.Worksheets[0];

                for (var i = 0; i < xlsPanelParamsCount; i++)
                    sheet.Cells[xlsPanelParamsRow[i], xlsPanelParamsCol[i]].PutValue(xlsPanelParamsValue[i]);

                HideColumns();

                workbook.Save(outputFileName);

                try
                {
                    Process.Start(outputFileName);
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog();
                }
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
            finally
            {
                ReportNumber++;
            }
            return outputFileName;
        }

        void HideColumns()
        {
            var colCount = 0;
            while (sheet.Cells[startRow - 1, startCol + colCount].Type != CellValueType.IsNull)
            {
                if (sheet.Cells[startRow, startCol + colCount].Type == CellValueType.IsNull)
                    sheet.Cells.HideColumn(startCol + colCount);
                colCount++;
            }
        }

        public string Export()
        {
            //            workbook = !is2007 ? new Workbook(FileFormatType.Excel97To2003) : new Workbook(FileFormatType.Excel2007Xlsx);
            workbook = new Workbook(GlobalParameters.ReportsFolder + fileName + ext);

            sheet = workbook.Worksheets[0];

            ReadParameters();

            var outputFileName = GlobalParameters.MonacemebiFolder + fileName + ReportNumber + ext;
            try
            {
                if (dt.Rows.Count > 0)
                    ExportDt();
                for (var i = 0; i < xlsPanelParamsCount; i++)
                    sheet.Cells[xlsPanelParamsRow[i], xlsPanelParamsCol[i]].PutValue(xlsPanelParamsValue[i]);

                workbook.Save(outputFileName);

                try
                {
                    Process.Start(outputFileName);
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog();
                }
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
            finally
            {
                ReportNumber++;
            }
            return outputFileName;
        }
        public string GenerateExcel()
        {
            //            workbook = !is2007 ? new Workbook(FileFormatType.Excel97To2003) : new Workbook(FileFormatType.Excel2007Xlsx);
            workbook = new Workbook(GlobalParameters.ReportsFolder + fileName + ext);

            sheet = workbook.Worksheets[0];

            ReadParameters();

            var outputFileName = GlobalParameters.MonacemebiFolder + fileName + ReportNumber + ext;
            try
            {
                if (dt.Rows.Count > 0)
                    ExportDt();
                for (var i = 0; i < xlsPanelParamsCount; i++)
                    sheet.Cells[xlsPanelParamsRow[i], xlsPanelParamsCol[i]].PutValue(xlsPanelParamsValue[i]);

                workbook.Save(outputFileName);

//                try
//                {
//                    Process.Start(outputFileName);
//                }
//                catch (Exception e)
//                {
//                    e.ShowErrorDialog();
//                }
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
            finally
            {
                ReportNumber++;
            }
            return outputFileName;
        }
        public void ExportDt()
        {
            var colCount = 0;
            var rowCount = dt.Rows.Count;
            var r = startRow + rowCount - 1;
            var colNames = new string[100];
            var colFormula = new string[100];

            ExportParameters();

            while (sheet.Cells[startRow, startCol + colCount].Type != CellValueType.IsNull)
            {
                if (sheet.Cells[startRow, startCol + colCount].IsFormula)
                    colNames[colCount] = "";
                else
                    colNames[colCount] = (string)sheet.Cells[startRow, startCol + colCount].Value;
                if (sheet.Cells[startRow + 1, startCol + colCount].Type == CellValueType.IsString)
                    colFormula[colCount] = (string)sheet.Cells[startRow + 1, startCol + colCount].Value;
                if (!string.IsNullOrEmpty(colFormula[colCount]))
                {
                    var c = startCol + colCount;
                    colFormula[colCount] = string.Format("={0}(R{1}C{2}:R{3}C{2})",
                        colFormula[colCount], startRow + 1, c + 1, r + 1);
                }
                sheet.Cells[startRow + 1, startCol + colCount].PutValue("");
                colCount++;
            }

            for (var i = 0; i < colCount; i++)
                SetRangeAllStyle(startRow + rowCount, startCol + i, (rowCount > 1 ? rowCount - 1 : 1), startRow + 1);
            for (var i = 0; i < rowCount; i++)
            {
                var dr = dt.Rows[i];
                for (var j = 0; j < colCount; j++)
                {
                    if (!string.IsNullOrEmpty(colNames[j]) && CheckHasOrNotField(colNames[j]))
                    {
                        switch (dr[colNames[j]].GetType().FullName)
                        {
                            case "System.DateTime":
                                sheet.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToDateTime(dr[colNames[j]].ToString()));
                                break;
                            case "System.Decimal":
                                sheet.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToDecimal(dr[colNames[j]].ToString()));
                                break;
                            case "System.Double":
                                sheet.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToDouble(dr[colNames[j]].ToString()));
                                break;
                            case "System.Int":
                                sheet.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToInt32(dr[colNames[j]].ToString()));
                                break;
                            default:
                                sheet.Cells[startRow + i, startCol + j].PutValue(dr[colNames[j]].ToString());
                                break;
                        }
                    }
                }
            }

            for (var i = 0; i < colCount; i++)
            {
                if (string.IsNullOrEmpty(colNames[i]))
                {
                    for (var j = 1; j < rowCount; j++)
                    {
                        sheet.Cells[startRow + j, startCol + i].Copy(sheet.Cells[startRow, startCol + i]);
                    }
                }
                SetRangeAllStyle(startRow, startCol + i, rowCount);
            }

            for (var i = 0; i < colCount; i++)
                if (!string.IsNullOrEmpty(colFormula[i]))
                    sheet.Cells[r + 1, startCol + i].R1C1Formula = colFormula[i];

            HideIfHasNotField(colNames, startCol + colCount);

            SetExcelPropertiesUsingParameters();
        }

        public void ExportDt(Worksheet sheet1)
        {
            var colCount = 0;
            var rowCount = dt.Rows.Count;
            var r = startRow + rowCount - 1;
            var colNames = new string[100];
            var colFormula = new string[100];

            ExportParameters();

            while (sheet1.Cells[startRow, startCol + colCount].Type != CellValueType.IsNull)
            {
                if (sheet1.Cells[startRow, startCol + colCount].IsFormula)
                    colNames[colCount] = "";
                else
                    colNames[colCount] = (string)sheet1.Cells[startRow, startCol + colCount].Value;
                if (sheet1.Cells[startRow + 1, startCol + colCount].Type == CellValueType.IsString)
                    colFormula[colCount] = (string)sheet1.Cells[startRow + 1, startCol + colCount].Value;
                if (!string.IsNullOrEmpty(colFormula[colCount]))
                {
                    var c = startCol + colCount;
                    colFormula[colCount] = string.Format("={0}(R{1}C{2}:R{3}C{2})",
                        colFormula[colCount], startRow + 1, c + 1, r + 1);
                }
                sheet1.Cells[startRow + 1, startCol + colCount].PutValue("");
                colCount++;
            }

            for (var i = 0; i < colCount; i++)
                SetRangeAllStyle(startRow + rowCount, startCol + i, rowCount, startRow + 1);
            for (var i = 0; i < rowCount; i++)
            {
                var dr = dt.Rows[i];
                for (var j = 0; j < colCount; j++)
                {
                    if (!string.IsNullOrEmpty(colNames[j]) && CheckHasOrNotField(colNames[j]))
                    {
                        switch (dr[colNames[j]].GetType().FullName)
                        {
                            case "System.DateTime":
                                sheet1.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToDateTime(dr[colNames[j]].ToString()));
                                break;
                            case "System.Decimal":
                                sheet1.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToDecimal(dr[colNames[j]].ToString()));
                                break;
                            case "System.Double":
                                sheet1.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToDouble(dr[colNames[j]].ToString()));
                                break;
                            case "System.Int":
                                sheet1.Cells[startRow + i, startCol + j].PutValue(
                                    Convert.ToInt32(dr[colNames[j]].ToString()));
                                break;
                            default:
                                sheet1.Cells[startRow + i, startCol + j].PutValue(dr[colNames[j]].ToString());
                                break;
                        }
                    }
                }
            }

            for (var i = 0; i < colCount; i++)
            {
                if (string.IsNullOrEmpty(colNames[i]))
                {
                    for (var j = 1; j < rowCount; j++)
                    {
                        sheet1.Cells[startRow + j, startCol + i].Copy(sheet1.Cells[startRow, startCol + i]);
                    }
                }
                SetRangeAllStyle(startRow, startCol + i, rowCount);
            }

            for (var i = 0; i < colCount; i++)
                if (!string.IsNullOrEmpty(colFormula[i]))
                    sheet1.Cells[r + 1, startCol + i].R1C1Formula = colFormula[i];

            HideIfHasNotField(colNames, startCol + colCount);
            SetExcelPropertiesUsingParameters();
        }

        bool CheckHasOrNotField(string columnName)
        {
            for (var i = 0; i < dt.Columns.Count; i++)
                if (dt.Columns[i].ColumnName == columnName)
                    return true;
            return false;
        }

        void HideIfHasNotField(string[] colNames, int endCol)
        {
            for (var i = startCol; i < endCol; i++)
            {
                var b = false;
                for (var j = 0; j < endCol - startCol; j++)
                    if (colNames[j] == Convert.ToString(sheet.Cells[startRow, i].Value) &&
                        !string.IsNullOrEmpty(colNames[j]))
                        b = true;
                if (b)
                    sheet.Cells.HideColumn(i);
            }
        }

        void SetExcelPropertiesUsingParameters()
        {
            //            if (CLSTools.cbFreezePanes)
            //                sheet.FreezePanes(startRow, startCol + CLSTools.FreezeColumnCount, startRow, startCol + CLSTools.FreezeColumnCount);
            //            if (CLSTools.cbColumnAutoFit)
            //                sheet.AutoFitColumns();
        }

        public void ExportParameters()
        {
            for (var i = 0; i < xlsParamsCount; i++)
                sheet.Cells[xlsParamsRow[i], xlsParamsCol[i]].PutValue(xlsParamsValue[i]);
            xlsParamsCount = 0;
        }

        void SetRangeAllStyle(int rangeStartRow, int rangeStartCol, int rowCount, int baseRow)
        {
            var range = sheet.Cells.CreateRange(rangeStartRow, rangeStartCol, rowCount, 1);
            range.ApplyStyle(sheet.Cells[baseRow, rangeStartCol].GetStyle(), new StyleFlag
            {
                All = true
            });
        }

        void SetRangeAllStyle(int rangeStartRow, int rangeStartCol, int rowCount)
        {
            SetRangeAllStyle(startRow, rangeStartCol, rowCount, rangeStartRow);
        }

        public void InitializePanelParams(PanelControl pnl)
        {
            xlsPanelParamsCount = 0;
            foreach (var cr in pnl.Controls.OfType<IFMGFindControl>().Where(a => a.Checked))
                xlsPanelParamsValue[xlsPanelParamsCount] = ReturnParameter(cr.GetValue().ToString(), cr.Text);
        }

        string ReturnParameter(string txtValue, string text)
        {
            xlsPanelParamsCount++;
            return string.Format("{0}: {1}", text, txtValue);
        }

        //        public void InitializePanelParams(PanelControl pnl, DateEdit txtData1, DateEdit txtData2)
        //        {
        //            xlsPanelParamsCount = 0;
        //            foreach (Control cr in pnl.Controls)
        //            {
        //                if (cr is CheckBox)
        //                {
        //                    if (cr.Name.Length > 8 && cr.Name.Substring(0, 9) == "chbHidden")
        //                        continue;
        //                    var c = pnl.Controls.Find("chbHidden" + cr.Name.Remove(0, 3), false);
        //                    if (c.Length > 0)
        //                        continue;
        //                    switch (cr.Name)
        //                    {
        //                        case "chbTotal":
        //                        case "chbCross":
        //                        case "chbChart":
        //                        case "chbSalData":
        //                            continue;
        //                        case "chbZedd":
        //                        case "chbFactura":
        //                        case "chbMZedd":
        //                            xlsPanelParamsValue[xlsPanelParamsCount] = ReturnReportParameter((cr as CheckBox).Checked,
        //                                pnl.Controls.Find("txt" + cr.Name.Substring(3), false)[0].Text, (cr as CheckBox).Text);
        //                            break;
        //                        case "chbData":
        //                            xlsPanelParamsValue[xlsPanelParamsCount] = ReturnReportParameter((cr as CheckBox).Checked,
        //                                "(" + txtData1.DateTime.ToShortDateString() + " - " +
        //                                txtData2.DateTime.ToShortDateString() + ")", (cr as CheckBox).Text);
        //                            break;
        //                        case "chbGvari":
        //                            xlsPanelParamsValue[xlsPanelParamsCount] = ReturnReportParameter((cr as CheckBox).Checked,
        //                                pnl.Controls.Find("laGvari", false)[0].Text, (cr as CheckBox).Text);
        //                            break;
        //                        case "chbProd":
        //                            xlsPanelParamsValue[xlsPanelParamsCount] = ReturnReportParameter((cr as CheckBox).Checked,
        //                                pnl.Controls.Find("laProd", false)[0].Text, (cr as CheckBox).Text);
        //                            break;
        //                        case "chbMoms":
        //                            xlsPanelParamsValue[xlsPanelParamsCount] = ReturnReportParameter((cr as CheckBox).Checked,
        //                                pnl.Controls.Find("laMoms", false)[0].Text, (cr as CheckBox).Text);
        //                            break;
        //                        default:
        //                            xlsPanelParamsValue[xlsPanelParamsCount] = ReturnReportParameter((cr as CheckBox).Checked,
        //                                pnl.Controls.Find("cb" + cr.Name.Substring(3), false)[0].Text, (cr as CheckBox).Text);
        //                            break;
        //                    }
        //                }
        //            }
        //        }

        //        private string ReturnReportParameter(bool b, string txtValue, string text)
        //        {
        //            if (b)
        //            {
        //                xlsPanelParamsCount++;
        //                return string.Format("{0}: {1}", text, txtValue);
        //            }
        //            return "";
        //        }

        public void ExportOnlyParams()
        {
            workbook = new Workbook(GlobalParameters.ReportsFolder + fileName + ext);
            var sheet1 = workbook.Worksheets[0];
            var outputFileName = GlobalParameters.MonacemebiFolder + fileName + ReportNumber + ext;
            try
            {
                for (var i = 0; i < xlsParamsCount; i++)
                    sheet1.Cells[xlsParamsRow[i], xlsParamsCol[i]].PutValue(xlsParamsValue[i]);

                workbook.Save(outputFileName);

                try
                {
                    Process.Start(outputFileName);
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog();
                }
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
            finally
            {
                ReportNumber++;
            }
        }

        //        private bool CheckParameters()
        //        {
        //            try {
        //                IWorksheet worksheet = Sworkbook.Worksheets["Parameters"];
        //                worksheet.Range[1, 1].CellStyle.Font.Bold = true;
        //                return true;
        //            }
        //            catch {
        //                return false;
        //            }
        //        }

        void ReadParameters()
        {
            if (workbook.Worksheets["Parameters"] != null)
            {
                var paramSheet = workbook.Worksheets["Parameters"];
                var row = 1;
                while (paramSheet.Cells[row, 0].Value != null)
                {
                    SetParamsValue(paramSheet.Cells[row, 0].Value.ToString(),
                        Convert.ToInt32(paramSheet.Cells[row, 1].Value.ToString()));
                    row++;
                }
            }
        }

        void SetParamsValue(string paramsName, int paramsValue)
        {
            var index = paramsName.IndexOf("_", StringComparison.Ordinal);
            if (index > 0)
            {
                Fields.TableName = paramsName.Substring(0, index);
                Fields.Rows[Fields.Count] = startRow;
                Fields.Cols[Fields.Count] = paramsValue - 1;
                Fields.Names[Fields.Count] = paramsName.Substring(index + 1, paramsName.Length - index - 1);
                Fields.Count++;
                return;
            }

            try
            {
                switch (paramsName)
                {
                    case "StartRow":
                        startRow = paramsValue - 1;
                        break;
                    case "StartCol":
                        startCol = paramsValue - 1;
                        break;
                }
            }
            catch
            {
                // ignored
            }
        }

        public void Import(string importFileName, string masterField, string masterId, string[] foreignTable)
        {
            Import(importFileName, masterField, masterId, foreignTable, true);
        }

        public void Import(string importFileName, string masterField, string masterId, string[] foreignTable,
            bool addUserInformation)
        {
            dtNo.Rows.Clear();

            workbook = new Workbook(importFileName);
            sheet = workbook.Worksheets["Parameters"];

            ReadParameters();

            if (Fields.Count == 0 || Fields.TableName == "")
            {
                XtraMessageBox.Show("იმპორტის პარამეტრები არასწორედაა შევსებული, მონაცემების იმპორტი შეუძლებელია",
                    StringParameters.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (var i = 0; i < Fields.Count; i++)
                dtNo.Columns.Add(Fields.Names[i]);
            dtNo.Columns.Add("Mizezi1");

            sheet = workbook.Worksheets[0];

            string mf, mid;
            if (masterId == "0")
            {
                mf = "";
                mid = "";
            }
            else
            {
                mf = masterField + ", ";
                mid = "N'" + masterId + "', ";
            }

            var strComm = "INSERT INTO " + Fields.TableName + "(" + mf;
            for (var i = 0; i < Fields.Count; i++)
                strComm += Fields.Names[i] + ", ";
            if (addUserInformation)
                strComm += "UN, CD) VALUES(" + mid;
            else
                strComm = strComm.Substring(0, strComm.Length - 2) + ") VALUES(" + mid;

            var row = 0;
            while (sheet.Cells[Fields.Rows[0] + row, Fields.Cols[0]].Value != null)
            {
                var hasRow = foreignTable.All(t => HasForeignTableRow(t, row));
                if (hasRow && TableNameForImport != string.Empty)
                    hasRow = HasTableRow(row);
                if (hasRow)
                {
                    try
                    {
                        var strComm1 = string.Empty;
                        for (var i = 0; i < Fields.Count; i++)
                        {
                            if (IsNumericField(Fields.Names[i]))
                                strComm1 += "'" + sheet.Cells[Fields.Rows[0] + row, Fields.Cols[i]].Value + "', ";
                            else
                                strComm1 += "N'" + sheet.Cells[Fields.Rows[0] + row, Fields.Cols[i]].Value + "', ";
                        }
                        if (addUserInformation)
                            strComm1 += "N'" + GlobalParameters.UserName + "', GETDATE())";
                        else
                            strComm1 = strComm1.Substring(0, strComm1.Length - 2) + ")";
                        SQL.Insert(strComm + strComm1);
                        ImportedRowsCount++;
                    }
                    catch
                    {
                        break;
                    }
                }
                else
                {
                    var dr = dtNo.NewRow();
                    for (var i = 0; i < Fields.Count; i++)
                    {
                        dr[Fields.Names[i]] = sheet.Cells[Fields.Rows[0] + row, Fields.Cols[i]].Value;
                    }
                    dr["Mizezi1"] = mizeziWhyNotImported;
                    dtNo.Rows.Add(dr);
                }
                row++;
            }
        }

        public void Update(string updateFileName, string masterField, string masterId, string[] foreignTable)
        {
            dtNo.Rows.Clear();

            workbook = new Workbook(updateFileName);
            sheet = workbook.Worksheets["Parameters"];

            ReadParameters();

            if (Fields.Count == 0 || Fields.TableName == "")
            {
                XtraMessageBox.Show("იმპორტის პარამეტრები არასწორედაა შევსებული, მონაცემების იმპორტი შეუძლებელია",
                    StringParameters.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (var i = 0; i < Fields.Count; i++)
                dtNo.Columns.Add(Fields.Names[i]);
            dtNo.Columns.Add("Mizezi1");

            sheet = workbook.Worksheets[0];

            var strComm = "UPDATE " + Fields.TableName + " SET ";

            var row = 0;
            while (sheet.Cells[Fields.Rows[0] + row, Fields.Cols[0]].Value != null)
            {
                try
                {
                    var strComm1 = "";
                    for (var i = 0; i < Fields.Count; i++)
                    {
                        if (IsNumericField(Fields.Names[i]))
                            strComm1 += Fields.Names[i] + " = " +
                                        sheet.Cells[Fields.Rows[0] + row, Fields.Cols[i]].Value + ", ";
                        else
                            strComm1 += Fields.Names[i] + " = N'" +
                                        sheet.Cells[Fields.Rows[0] + row, Fields.Cols[i]].Value + "', ";
                    }
                    strComm1 = strComm1.Substring(0, strComm1.Length - 2);
                    SQL.Insert(strComm + strComm1 + " WHERE Id" + Fields.TableName + " = N'" +
                               sheet.Cells[Fields.Rows[0] + row, Fields.Cols[0]].Value + "'");
                    ImportedRowsCount++;
                }
                catch
                {
                    break;
                }
                row++;
            }
        }

        bool HasForeignTableRow(string foreignTable, int row)
        {
            var hasRow = false;
            mizeziWhyNotImported = "ვერ დამყარდა კავშირი";
            if (foreignTable != "")
            {
                //                if (sheet.Cells[fields.Rows[0] + row, fields.Cols[ReturnForeignKeyValue(ForeignTable)]].Type == CellValueType.IsNumeric)
                //                    s1 = sheet.Cells[fields.Rows[0] + row, fields.Cols[ReturnForeignKeyValue(ForeignTable)]].Value.ToString();
                //                else
                var s1 =
                    sheet.Cells[Fields.Rows[0] + row, Fields.Cols[ReturnForeignKeyValue(foreignTable)]].Value.ToString();
                s1 = string.Format("SELECT TOP 1 Id{0} FROM {0} WHERE Id{0} = '{1}'", foreignTable, s1);

                using (var dtForeign = SQL.Select(s1))
                {
                    if (dtForeign.Rows.Count > 0)
                        hasRow = true;
                }
            }
            return hasRow;
        }

        bool HasTableRow(int row)
        {
            mizeziWhyNotImported = "ასეთი ჩანაწერი არსებობს";
            //            if (string.IsNullOrEmpty(Ssheet.Range[fields.Rows[0] + row, fields.Cols[ReturnForeignKeyValue("Id" + tableNameForImport)]].Text))
            //                s1 = Ssheet.Range[fields.Rows[0] + row, fields.Cols[ReturnForeignKeyValue("Id" + tableNameForImport)]].Value;
            //            else
            var s1 =
                sheet.Cells[Fields.Rows[0] + row, Fields.Cols[ReturnForeignKeyValue("Id" + TableNameForImport)]].Value
                    .ToString();

            using (var dt1 =
                SQL.Select(string.Format("SELECT TOP 1 * FROM {0} WHERE Id{0} = N'{1}'", TableNameForImport, s1)))
            {
                return dt1.Rows.Count <= 0;
            }
        }

        int ReturnForeignKeyValue(string foreignTable)
        {
            for (var i = 0; i < Fields.Count; i++)
            {
                if (Fields.Names[i] == "Id" + foreignTable)
                    return i;
            }
            return 0;
        }

        bool IsNumericField(string s)
        {
            return Fields.NumericFields.Contains(s);
        }

        #region Constuctors And Properties

        public CLSExcel()
        {
            TableNameForImport = string.Empty;
            Fields = new CLSImportField();
            xlsParamsCount = 0;
            startRow = 6;
            startCol = 0;
            dtNo = new DataTable();
        }

        public CLSExcel(GridControl dg, string fileName)
            : this()
        {
            this.fileName = fileName;
            dt = dg.DataSource as DataTable;
            SetIs2007();
        }

        public CLSExcel(DataTable dt, string fileName)
            : this()
        {
            this.fileName = fileName;
            this.dt = dt;
            SetIs2007();
        }

        void SetIs2007()
        {
            is2007 = !File.Exists(GlobalParameters.ReportsFolder + fileName + ".xls");
            if (is2007)
                fileName = fileName.Remove(fileName.Length - 1);
            ext = is2007 ? ".XLSX" : ".XLS";
        }

        public CLSExcel(DataTable dt, string fileName, Worksheet sheet)
            : this()
        {
            this.fileName = fileName;
            this.dt = dt;
            this.sheet = sheet;
            SetIs2007();
        }

        public CLSExcel(int startRow, int startCol, DataTable dt, string fileName)
        {
            TableNameForImport = string.Empty;
            Fields = new CLSImportField();
            this.startRow = startRow;
            this.startCol = startCol;
            this.dt = dt;
            this.fileName = fileName;
            SetIs2007();
        }

        public CLSExcel(DataTable dt, string fileName, int xlsParamsCount, string[] xlsParamsValue,
            int[] xlsParamsRow, int[] xlsParamsCol)
            : this(dt, fileName)
        {
            this.xlsParamsCount = xlsParamsCount;
            this.xlsParamsValue = xlsParamsValue;
            this.xlsParamsRow = xlsParamsRow;
            this.xlsParamsCol = xlsParamsCol;
        }

        public CLSExcel(int startRow, int startCol, DataTable dt, string fileName, int xlsParamsCount,
            string[] xlsParamsValue, int[] xlsParamsRow, int[] xlsParamsCol) :
            this(startRow, startCol, dt, fileName)
        {
            this.xlsParamsCount = xlsParamsCount;
            this.xlsParamsValue = xlsParamsValue;
            this.xlsParamsRow = xlsParamsRow;
            this.xlsParamsCol = xlsParamsCol;
        }

        public CLSImportField Fields { get; set; }

        public int ImportedRowsCount { get; private set; }

        public string ImportFileName { get; set; }

        public string TableNameForImport { get; set; }

        public DataTable DtNo
        {
            get { return dtNo; }
        }

        #endregion Constuctors And Properties

        #region PrintSasZeddAndFactura

        public void PrintSasZeddAndFactura(bool printFact)
        {
            PrintSasZeddAndFactura(printFact, PrintParameters.ZeddRowCount, PrintParameters.FacturaRowCount);
        }

        public void PrintSasZeddAndFactura(bool printFact, int zeddRowCount, int facturaRowCount)
        {
            workbook = new Workbook(GlobalParameters.ReportsFolder + fileName + ext);

            var sheet1 = workbook.Worksheets["Zeddebuli"];
            var sheet2 = workbook.Worksheets["Zedd Danarti"];
            var sheet3 = workbook.Worksheets["angariS faqtura"];
            var sheet4 = workbook.Worksheets["Ang Fact Danarti"];
            var outputFileName = GlobalParameters.MonacemebiFolder + fileName + ReportNumber + ".XLS";

            try
            {
                for (var i = 0; i < xlsParamsCount; i++)
                    sheet1.Cells[xlsParamsRow[i], xlsParamsCol[i]].PutValue(xlsParamsValue[i]);

                PrintSasRsZedd(sheet1, sheet2, zeddRowCount);

                if (printFact)
                    PrintFactura(sheet3, sheet4, facturaRowCount);
                else
                {
                    sheet3.IsVisible = false;
                    sheet4.IsVisible = false;
                }

                workbook.Save(outputFileName);

                try
                {
                    Process.Start(outputFileName);
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog();
                }
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
            finally
            {
                ReportNumber++;
            }
        }

        void PrintSasRsZedd(Worksheet sheet1, Worksheet sheet2, int zeddRowCount)
        {
            const int zeddStartRow = 24;
            const int zeddDanartiStartRow = 24;

            var count = dt.Rows.Count > zeddRowCount ? zeddRowCount - 1 : dt.Rows.Count;
            var paramsZeddRowCount = PrintParameters.ZeddRowCount;

            if (PrintParameters.SasZeddAllInDanarti)
            {
                if (dt.Rows.Count > zeddRowCount)
                {
                    zeddRowCount = 1;
                    count = zeddRowCount - 1;
                    paramsZeddRowCount = 1;
                }
                else
                {
                    count = dt.Rows.Count;
                }
            }

            var j = 0;
            var n = 0;

            for (var i = 0; i < 3000; i++)
            {
                if (i == dt.Rows.Count)
                    return;
                if (count == 0)
                    break;
                sheet1.Cells[zeddStartRow + i, 3].PutValue(dt.Rows[i]["Prod"].ToString());
                sheet1.Cells[zeddStartRow + i, 22].PutValue(dt.Rows[i]["IdProd"].ToString());
                sheet1.Cells[zeddStartRow + i, 27].PutValue(dt.Rows[i]["UnitName"].ToString());
                sheet1.Cells[zeddStartRow + i, 31].PutValue(Convert.ToDouble(dt.Rows[i]["Raod"].ToString()));
                sheet1.Cells[zeddStartRow + i, 35].PutValue(Convert.ToDouble(dt.Rows[i]["Fasi"].ToString()));
                sheet1.Cells[zeddStartRow + i, 39].PutValue(Convert.ToDouble(dt.Rows[i]["Tanxa"].ToString()));
                j++;
                if (j != count)
                    continue;
                n = i + 1;
                break;
            }
            j = 0;
            if (dt.Rows.Count <= paramsZeddRowCount)
                return;
            double raod = 0, tanxa = 0;
            for (var i = n; i < dt.Rows.Count; i++)
            {
                sheet2.Cells[zeddDanartiStartRow + i - count, 3].PutValue(dt.Rows[i]["Prod"].ToString());
                sheet2.Cells[zeddDanartiStartRow + i - count, 22].PutValue(dt.Rows[i]["IdProd"].ToString());
                sheet2.Cells[zeddDanartiStartRow + i - count, 27].PutValue(dt.Rows[i]["UnitName"].ToString());
                sheet2.Cells[zeddDanartiStartRow + i - count, 31].PutValue(
                    Convert.ToDouble(dt.Rows[i]["Raod"].ToString()));
                sheet2.Cells[zeddDanartiStartRow + i - count, 35].PutValue(
                    Convert.ToDouble(dt.Rows[i]["Fasi"].ToString()));
                sheet2.Cells[zeddDanartiStartRow + i - count, 39].PutValue(
                    Convert.ToDouble(dt.Rows[i]["Tanxa"].ToString()));
                raod += Convert.ToDouble(dt.Rows[i]["Raod"].ToString());
                tanxa += Convert.ToDouble(dt.Rows[i]["Tanxa"].ToString());
                j++;
            }
            sheet1.Cells[zeddStartRow + count, 3].PutValue("დანართის მიხედვით");
            sheet1.Cells[zeddStartRow + count, 31].PutValue(raod);
            sheet1.Cells[zeddStartRow + count, 39].PutValue(tanxa);
        }

        void PrintFactura(Worksheet sheet1, Worksheet sheet2, int facturaRowCount)
        {
            int count;
            var paramsFacturaRowCount = PrintParameters.FacturaRowCount;

            if (dt.Rows.Count > facturaRowCount)
            {
                facturaRowCount = 1;
                count = facturaRowCount - 1;
                paramsFacturaRowCount = 1;
            }
            else
            {
                count = dt.Rows.Count;
            }

            var j = 0;
            var n = 0;

            for (var i = 0; i < 3000; i++)
            {
                if (i == dt.Rows.Count)
                    return;
                if (count == 0)
                    break;
                if (Convert.ToDouble(dt.Rows[i]["Dgg"].ToString()) <= 0)
                    continue;
                sheet1.Cells[33 + j, 2].PutValue(dt.Rows[i]["Prod"].ToString());
                sheet1.Cells[33 + j, 5].PutValue(dt.Rows[i]["Ert"].ToString());
                sheet1.Cells[33 + j, 6].PutValue(Convert.ToDouble(dt.Rows[i]["Raod"].ToString()));
                sheet1.Cells[33 + j, 7].PutValue(Convert.ToDouble(dt.Rows[i]["Tanxa"].ToString()));
                j++;
                if (j != count)
                    continue;
                n = i + 1;
                break;
            }
            j = 0;
            if (dt.Rows.Count <= paramsFacturaRowCount)
                return;
            for (var i = n; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDouble(dt.Rows[i]["Dgg"].ToString()) <= 0)
                    continue;
                sheet2.Cells[12 + j, 2].PutValue(dt.Rows[i]["Prod"].ToString());
                sheet2.Cells[12 + j, 3].PutValue(dt.Rows[i]["Ert"].ToString());
                sheet2.Cells[12 + j, 4].PutValue(Convert.ToDouble(dt.Rows[i]["Raod"].ToString()));
                sheet2.Cells[12 + j, 6].PutValue(Convert.ToDouble(dt.Rows[i]["Tanxa"].ToString()));
                j++;
            }

            if (count != 0)
                return;
            sheet1.Cells[33, 2].PutValue("საგადასახადო  ანგარიშ ფაქტურა");
            sheet1.Cells[34, 2].PutValue("გამოიწერა 1 ცალი ზედნადებით ");
            sheet1.Cells[35, 2].PutValue("მიწოდებული " + dt.Rows.Count + " დასახელების");
            sheet1.Cells[36, 2].PutValue("საქონელზე დანართი");
            sheet1.Cells[37, 2].PutValue(" #7 ის მიხედვით");
            sheet1.Cells[33, 5].R1C1Formula = "=(1.0 - 1.0)";
            sheet1.Cells[39, 13].R1C1Formula = "=(1.0 - 1.0)";
        }

        #endregion PrintSasZeddAndFactura
    }

    class CLSImportField
    {
        public CLSImportField()
        {
            Count = 0;
            Names = new string[40];
            Rows = new int[40];
            Cols = new int[40];
        }

        public CLSImportField(string[] numericFields)
        {
            NumericFields = numericFields;
        }

        public CLSImportField(string[] names, int[] rows, int[] cols, string tableName)
        {
            Names = names;
            Rows = rows;
            Cols = cols;
            TableName = tableName;
            Count = names.Length;
        }

        public string[] NumericFields { get; set; }
        public int Count { get; set; }
        public string TableName { get; set; }
        public int[] Rows { get; set; }
        public int[] Cols { get; set; }
        public string[] Names { get; set; }
    }
}