using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Interfaces;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    /// -- ვერსია 0.1 -- 24 Sep 2015 17:30 ნიკა
    /// </summary>

    public static class SQL
    {
        public static DataRow FillParams(string userName)
        {
            DataRow dr;
            using (var dt = new DataTable())
            {
                try
                {
                    GlobalParameters.cn.Open();
                    var txtComm = string.Format("SELECT * FROM Params WHERE UN = '{0}'", userName);
                    new SqlDataAdapter(new SqlCommand(txtComm, GlobalParameters.cn)).Fill(dt);
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog();
                    return null;
                }
                finally
                {
                    GlobalParameters.cn.Close();
                }
                if (dt.Rows.Count != 1)
                {
                    XtraMessageBox.Show(StringParameters.NoParams);
                    return null;
                }
                dr = dt.Rows[0];
            }

            return dr;
        }

        public static DataTable Select(string txtComm)
        {
            using (var dt = new DataTable())
            {
                try
                {
                    GlobalParameters.cn.Open();
                    Console.WriteLine(txtComm);
                    new SqlDataAdapter(new SqlCommand(txtComm, GlobalParameters.cn)).Fill(dt);
                }
                catch (Exception e)
                {
                    e.ShowErrorDialog(txtComm);
                }
                finally
                {
                    GlobalParameters.cn.Close();
                }
                return dt;
            }
        }

        public static DataRow GetTableRow(string txtComm)
        {
            using (var dt = Select(txtComm))
            {
                if (dt.Rows.Count == 1)
                    return dt.Rows[0];
            }

            XtraMessageBox.Show("ვერ ხერხდება ინფორმაციის გამოტანა");
            return null;
        }

        public static string ExecuteScalar(string txtComm)
        {
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
                Console.WriteLine(txtComm);

                return comm.ExecuteScalar().ToString();
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static DataTable Select(string tableName, string whereClause)
        {
            return Select(string.Format("SELECT * FROM {0} {1} ", tableName, whereClause));
        }

        public static void Delete(string txtComm)
        {
            Execute(txtComm);
        }

        public static DataTable Delete(string tableName, string whereClause, string strSelectCommand)
        {
            Execute(string.Format("DELETE FROM {0} {1}", tableName, whereClause));
            return Select(strSelectCommand);
        }

        public static DataTable Delete(string tableName, string whereClause)
        {
            Execute(string.Format("DELETE FROM {0} {1}", tableName, whereClause));
            return Select(tableName, string.Empty);
        }

        public static void Update(string txtComm, bool createLog)
        {
            if (createLog)
                Update(txtComm);
            else
                Execute(txtComm);
        }

        public static void Update(string txtComm)
        {
            if (!GlobalParameters.CreateLog)
            {
                Execute(txtComm);
                return;
            }
            string tableName;
            var clsLog = new CLSLog();
            var idArray = GenerateUpdateIdArray(txtComm, out tableName);
            foreach (var id in idArray)
            {
                clsLog.AddOldValues(tableName, id);
                clsLog.CreateLog(tableName, "UPDATE", txtComm);
            }

            Execute(txtComm);
        }

        public static string[] GenerateUpdateIdArray(string txtComm, out string tableName)
        {
            var txtCommUpper = txtComm.ToUpper();
            var posOfSet =
                Convert.ToInt32(
                    txtCommUpper.IndexOf(" SET ", StringComparison.Ordinal).ToString(CultureInfo.InvariantCulture)) - 1;
            var posOfUpdate =
                Convert.ToInt32(
                    txtCommUpper.IndexOf("UPDATE", StringComparison.Ordinal).ToString(CultureInfo.InvariantCulture));
            var posOfFrom =
                Convert.ToInt32(
                    txtCommUpper.IndexOf("FROM", StringComparison.Ordinal).ToString(CultureInfo.InvariantCulture));
            var posOfWhere =
                Convert.ToInt32(
                    txtCommUpper.IndexOf("WHERE", StringComparison.Ordinal).ToString(CultureInfo.InvariantCulture));
            tableName = txtComm.Substring(posOfUpdate + 7, posOfSet - posOfUpdate - 6).Trim();
            var fieldName = tableName + ".Id" + tableName;
            var from = posOfFrom > 0 ? " " + txtComm.Substring(posOfFrom) : " FROM " + tableName + " ";
            var where = posOfFrom > 0 ? string.Empty : posOfWhere > 0 ? " " + txtComm.Substring(posOfWhere) : " ";

            var sql = "SELECT " + fieldName + from + where;
            var dt = Select(sql);
            var idArray = new string[dt.Rows.Count];
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                idArray[i] = dt.Rows[i][0].ToString();
            }
            return idArray;
        }

        public static void Update(string tableName, string id, string txtValue)
        {
            Update(string.Format("UPDATE {0} SET {0} = N'{1}' WHERE Id{0} = {2}", tableName, txtValue, id));
        }

        public static int Insert(string txtComm)
        {
            if (txtComm.Contains("SCOPE_IDENTITY"))
                return Convert.ToInt32(ExecuteScalar(txtComm));
            Execute(txtComm);
            return -1;
        }

        public static int Insert(string tableName, string txtValue)
        {
            return Insert(string.Format("INSERT INTO {0} VALUES (N'{1}');SELECT SCOPE_IDENTITY()", tableName, txtValue));
        }

        public static void Execute(string txtComm)
        {
            if (txtComm == string.Empty) return;
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
                comm.ExecuteNonQuery();
                Console.WriteLine(txtComm);
            }
            catch (Exception e)
            {
                e.ShowErrorDialog(txtComm);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static void InsertVarBinary(string txtComm, string param, string fileName)
        {
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
                var br = new BinaryReader(new FileStream(fileName, FileMode.Open));
                comm.Parameters.Add(param, SqlDbType.VarBinary).Value = br.ReadBytes((int)br.BaseStream.Length);
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                e.ShowErrorDialog(txtComm);

            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static void InsertVarBinary(string txtComm, string param, byte[] array)
        {
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
                comm.Parameters.Add(param, SqlDbType.VarBinary).Value = array;
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                e.ShowErrorDialog(txtComm);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static void SelectVarBinary(GridView gv, string tableName, string varBinaryName, bool open)
        {
            if (gv.RowCount <= 0) return;
            try
            {
                GlobalParameters.cn.Open();
                var dt = new DataTable();
                new SqlDataAdapter(new SqlCommand(
                    string.Format("SELECT PictureText, {2} FROM {0} WHERE Id{0} = {1}", tableName,
                        gv.ReturnValue("Id" + tableName), varBinaryName), GlobalParameters.cn)).Fill(dt);
                var c = dt.Rows[0][varBinaryName] as byte[];
                if (c == null) return;
                if (!open)
                {
                    var fn = dt.Rows[0][0].ToString();
                    var sfd = new SaveFileDialog();
                    sfd.FileName = fn;
                    if (sfd.ShowDialog() != DialogResult.OK) return;
                    using (var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                        fs.Write(c, 0, c.Length);
                    if (XtraMessageBox.Show("ფაილი შენახულია, გავხსნა?".Translate(), string.Empty, MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                        Process.Start(sfd.FileName);
                }
                else
                {
                    var fn = dt.Rows[0][0].ToString();
                    using (var fs = new FileStream(Path.GetTempPath() + fn, FileMode.Create, FileAccess.Write))
                        fs.Write(c, 0, c.Length);
                    Process.Start(Path.GetTempPath() + fn);
                }
            }
            catch (Exception e)
            {
                e.ShowErrorDialog();
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }
    }

    public static class SQLOperation
    {
        public static void UpdateCalcTypeStatus(string id, string idCalcType)
        {
            UpdateCalcTypeStatus(id, idCalcType, " AND IdCalcType <> 30");
        }

        public static void UpdateCalcTypeStatus(string id, string idCalcType, string additionalWhere)
        {
            var tableName = "UPDATE Shes1 SET IdCalcType = " + idCalcType + " WHERE IdShes1 = " + id + additionalWhere;
            SQL.Update(tableName);
        }

        public static double CalcTableTanxa(double tanxa, DataTable dt, string fieldName)
        {
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                tanxa += Convert.ToDouble(dt.Rows[i][fieldName].ToString());
            }
            return tanxa;
        }

        public static string CalcZeddNum(string tableName)
        {
            var dt = SQL.Select(string.Format(
                " UPDATE ZeddAuto SET Num = Num + 1 WHERE TableName = N'{0}'; " +
                " SELECT TOP 1 Prefics, Sufics, Num FROM ZeddAuto WHERE Active = 1 AND TableName = N'{0}'",
                tableName));
            if (dt.Rows.Count <= 0) return string.Empty;
            var num = Convert.ToInt32(dt.Rows[0]["Num"].ToString());
            var zedd = dt.Rows[0]["Prefics"].ToString() + num + dt.Rows[0]["Sufics"];
            return zedd;
        }

        public static CLSZeddAuto CalcZeddAuto(string tableName, bool update)
        {
            var dt =
                SQL.Select(" SELECT TOP 1 Prefics, Sufics, Num + 1 AS Num FROM ZeddAuto WHERE TableName = N'" +
                           tableName + "'");
            if (dt.Rows.Count > 0)
            {
                if (update)
                    SQL.Update("UPDATE ZeddAuto SET Num = Num + 1 WHERE TableName = N'" + tableName + "'");
                return new CLSZeddAuto(Convert.ToInt32(dt.Rows[0]["Num"].ToString()), dt.Rows[0]["Prefics"].ToString(),
                    dt.Rows[0]["Sufics"].ToString());
            }
            return new CLSZeddAuto(0, string.Empty, string.Empty);
        }

        public static CLSZeddAuto CalcZeddAuto(string tableName)
        {
            return CalcZeddAuto(tableName, true);
        }

        public static void CopyRecordWithDetails(string tableName, string detTableName, int masterId, string fieldList,
            string detFieldList)
        {
            if (XtraMessageBox.Show("შევასრულოთ კოპირება?".Translate(), "კოპირება".Translate(), MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            string strInsertCommand = string.Empty;
            try
            {
                var shortDetFieldList =
                    detFieldList.Substring(detFieldList.IndexOf(',') + 1,
                        detFieldList.Length - detFieldList.IndexOf(',') - 1);
                var selFieldList = fieldList.Replace("Zedd", "N'" + CalcZeddNum(tableName) + "'");
                strInsertCommand =
                    string.Format("INSERT INTO {0}({1}) SELECT {3} FROM {0} WHERE Id{0} = {2}; SELECT SCOPE_IDENTITY()",
                        tableName, fieldList, masterId, selFieldList);
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(strInsertCommand, GlobalParameters.cn);
                var id = Convert.ToInt32(comm.ExecuteScalar());

                var strDetInsertCommand =
                    string.Format(
                        "INSERT INTO {0}({1}, UN, CD) SELECT {2}, {3}, '" + GlobalParameters.UserName +
                        "', GETDATE() FROM {0} WHERE Id{4} = {5}",
                        detTableName, detFieldList, id, shortDetFieldList, tableName, masterId);
                var detComm = new SqlCommand(strDetInsertCommand, GlobalParameters.cn);
                detComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                e.ShowErrorDialog("strInsertCommand: " + strInsertCommand);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
        }

        public static void SetWhereClause(this PanelControl panel1, StringBuilder s)
        {
            foreach (Control cr in panel1.Controls)
            {
                if (cr is IFMGFindControl && ((IFMGFindControl)cr).Checked)
                {
                    s.Append((cr as IFMGFindControl).GetWhereCmd());
                }
            }
        }

        public static string ReturnOrderByCondition(ListBoxControl lbList, string s, string[] fieldList,
            CheckedListBoxControl chb)
        {
            var i = 0;
            foreach (ListBoxItem item in lbList.Items)
            {
                s += ReturnFieldValueViaCheckBoxText(item.ToString(), fieldList, chb) + ", ";
                i++;
            }
            return (i > 0) ? s.Substring(0, s.LastIndexOf(",")) : string.Empty;
        }

        public static string ReturnOrderByCondition(ListBoxControl lbList, string[] fieldList, CheckedListBoxControl chb)
        {
            string s = string.Empty;
            var i = 0;
            foreach (ListBoxItem item in lbList.Items)
            {
                s += ReturnFieldValueViaCheckBoxText(item.ToString(), fieldList, chb) + ", ";
                i++;
            }
            return i > 0 ? s.Substring(0, s.LastIndexOf(",")) : string.Empty;
        }

        public static string ReturnFieldValueViaCheckBoxText(string s, string[] fieldList, CheckedListBoxControl chb)
        {
            for (var i = 0; i < chb.Items.Count; i++)
            {
                if ((string)chb.Items[i].Value == s)
                    return fieldList[i];
            }
            return fieldList[0];
        }
    }
}