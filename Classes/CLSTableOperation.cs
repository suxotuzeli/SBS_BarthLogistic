using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Interfaces;
using ComboBox = System.Windows.Forms.ComboBox;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    ///     -- ვერსია 1.1 -- 23 Mar 2016 15:00 ნიკა
    ///     . CLSTableOperation.Delete() გამოსწორდა ბაგი ყველას წაშლასთან დაკავშირებით
    ///     -- ვერსია 1.0 -- 29 Feb 2016 17:00 ნიკა
    ///     . InitialazeControls დრომ ISelect ებზე ხდება სახელის მიწერაც, Prod, Org...
    /// </summary>
    class CLSTableOperation
    {
        readonly bool addUserInformation;
        readonly string[] excludeControls = new string[10];
        readonly Control frm;
        readonly string tableName;

        public CLSTableOperation(Control frm, string tableName, bool addUserInformation = true)
        {
            AdditionalValues = new string[10];
            AdditionalFields = new string[10];
            this.frm = frm;
            this.tableName = tableName;
            this.addUserInformation = addUserInformation;
            AdditionalFieldsCount = 0;
        }

        public CLSTableOperation(Control frm, string tableName,
            string[] strAdditionalFields, string[] strAdditionalValues, int intAdditionalFieldsCount,
            bool addUserInformation = true)
        {
            this.frm = frm;
            this.tableName = tableName;
            this.addUserInformation = addUserInformation;
            AdditionalFieldsCount = intAdditionalFieldsCount;
            AdditionalFields = strAdditionalFields;
            AdditionalValues = strAdditionalValues;
        }

        public CLSTableOperation(Control frm, string tableName,
            string[] strAdditionalFields, string[] strAdditionalValues,
            bool addUserInformation = true)
        {
            this.frm = frm;
            this.tableName = tableName;
            this.addUserInformation = addUserInformation;
            AdditionalFieldsCount = strAdditionalValues.Length;
            AdditionalFields = strAdditionalFields;
            AdditionalValues = strAdditionalValues;
        }

        public CLSTableOperation(Control frm, string tableName, params string[] strExcludeControls)
            : this(frm, tableName, true)
        {
            excludeControls = strExcludeControls;
        }

        public CLSTableOperation(Control frm, string tableName, string[] strExcludeControls, bool addUserInformation = true)
            : this(frm, tableName, addUserInformation)
        {
            excludeControls = strExcludeControls;
        }

        public CLSTableOperation(Control frm, string tableName,
            string[] strAdditionalFields, string[] strAdditionalValues, int intAdditionalFieldsCount,
            string[] strExcludeFields, bool addUserInformation = true)
            : this(
                frm, tableName, strAdditionalFields, strAdditionalValues, intAdditionalFieldsCount, addUserInformation)
        {
            excludeControls = strExcludeFields;
        }

        public CLSTableOperation(Control frm, string tableName,
            string[] strAdditionalFields, string[] strAdditionalValues, params string[] strExcludeFields)
            : this(frm, tableName, strAdditionalFields, strAdditionalValues, strAdditionalValues.Length)
        {
            excludeControls = strExcludeFields;
        }

        public CLSTableOperation(Control frm, string tableName,
            string[] strAdditionalFields, string[] strAdditionalValues, int intAdditionalFieldsCount,
            params string[] strExcludeFields)
            : this(
                frm, tableName, strAdditionalFields, strAdditionalValues, intAdditionalFieldsCount)
        {
            excludeControls = strExcludeFields;
        }

        public int AdditionalFieldsCount { get; set; }
        public string[] AdditionalFields { get; set; }
        public string[] AdditionalValues { get; set; }

        int IsValueInExcludeControls(string value)
        {
            return IsValueInStringList(excludeControls, value);
        }

        static int IsValueInStringList(IEnumerable<string> strList, string value)
        {
            int index = -1;
            if (strList.All(s1 => s1 != value)) return index;
            index++;
            return index;
        }

        static string ReturnTextFromName(string name, int startSymbols)
        {
            int l = name.Length;
            return name.Substring(startSymbols, l - startSymbols);
        }

        static string ReturnNameViaControl(Control cr, int startSymbols, string startSymbolsText)
        {
            return startSymbolsText + ReturnTextFromName(cr.Name, startSymbols);
        }

        public int Insert(bool hasIdentity)
        {
            var strComm = new StringBuilder("INSERT INTO " + tableName + "(");
            ProcessFormHeader(strComm,frm.Controls.Cast<Control>().Where(cr => IsValueInExcludeControls(cr.Name) < 0));

            for (int i = 0; i < AdditionalFieldsCount; i++)
                strComm.Append(AdditionalFields[i] + ", ");

            if (addUserInformation)
                strComm.Append(" UN, CD ) VALUES( ");
            else
                strComm.Remove(strComm.Length - 2, 2).Append(") VALUES( ");

            ProcessFormValues(strComm,frm.Controls.Cast<Control>().Where(cr => IsValueInExcludeControls(cr.Name) < 0));

            for (int i = 0; i < AdditionalFieldsCount; i++)
                strComm.Append("N'" + AdditionalValues[i] + "', ");

            if (addUserInformation)
                strComm.Append("N'" + GlobalParameters.UserName + "', GETDATE())");
            else
                strComm.Remove(strComm.Length - 2, 2).Append(")");

            if (hasIdentity)
                strComm.Append(";SELECT SCOPE_IDENTITY()");
            return Insert(strComm.ToString());
        }

        private void ProcessFormHeader(StringBuilder strComm,IEnumerable<Control> controlList)
        {
            foreach (Control cr in controlList)
            {
                if (cr is LookUpEdit || cr is ComboBox)
                {
                    strComm.Append(ReturnNameViaControl(cr, 2, "Id") + ", ");
                    continue;
                }

                if (cr is CalcEdit || cr is TextEdit || cr is CheckEdit || cr is ISelect)
                {
                    strComm.Append(ReturnNameViaControl(cr, 3, string.Empty) + ", ");
                    continue;
                }
                if (cr is GroupControl control)
                {
                    ProcessFormHeader(strComm,control.Controls.Cast<Control>().Where(crx => IsValueInExcludeControls(crx.Name) < 0));
                }
            }
        }

        private void ProcessFormValues(StringBuilder strComm,IEnumerable<Control> controlList)
        {
            foreach (Control cr in controlList)
            {
                if (cr is GroupControl)
                {
                    ProcessFormValues(strComm,(cr as GroupControl).Controls.Cast<Control>().Where(crx => IsValueInExcludeControls(crx.Name) < 0));
                    continue;
                }
                if (cr is LabelControl || cr is PanelControl || cr is SimpleButton)
                {
                    continue;
                }
                if (cr is LookUpEdit)
                {
                    strComm.Append("N'" + (cr as LookUpEdit).EditValue + "', ");
                    continue;
                }
                if (cr is ComboBox)
                {
                    strComm.Append("N'" + (cr as ComboBox).SelectedValue + "', ");
                    continue;
                }
                if (cr is CalcEdit)
                {
                    strComm.Append((cr as CalcEdit).Value + ", ");
                    continue;
                }
                if (cr is DateEdit)
                {
                    strComm.Append("'" + Convert.ToDateTime((cr as DateEdit).DateTime).ToString(GlobalParameters.ServerDateTimeFormat) + "', ");
                    continue;
                }
                if (cr is TextEdit)
                {
                    strComm.Append("N'" + (cr as TextEdit).Text.Replace("'", "''") + "', ");
                    continue;
                }
                if (cr is ISelect)
                {
                    strComm.Append("N'" + (cr as ISelect).Id + "', ");
                    continue;
                }
                if (cr is CheckEdit)
                {
                    strComm.Append((cr as CheckEdit).ConvertCheckEditValueToInt() + ", ");
                }
            }
        }

        public int Insert()
        {
            return Insert(true);
        }

        public int Insert(string strComm)
        {
            return InsertDt(strComm);
        }

        static int InsertDt(string txtComm)
        {
            int insertedId = 0;
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
                insertedId = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception e)
            {
                e.ShowErrorDialog(txtComm);
            }
            finally
            {
                GlobalParameters.cn.Close();
            }
            return insertedId;
        }

        public void Update(int id)
        {
            Update(id.ToString());
        }

        public void Update(string id)
        {
            var ctrx = frm.Controls.Cast<Control>().Where(cr => IsValueInExcludeControls(cr.Name) < 0);
            Update(id,ctrx);
        }

        private void Update(string id,IEnumerable<Control> ctrx)
        {
            StringBuilder str = new StringBuilder();
            str.Append("UPDATE " + tableName + " SET ");
            foreach (Control cr in ctrx)
            {
                if (cr is GroupControl gr)
                {
                    Update(id, gr.Controls.Cast<Control>().Where(crX => IsValueInExcludeControls(crX.Name) < 0));
                    continue;
                }

                if (cr is LabelControl || cr is PanelControl || cr is SimpleButton)
                {
                    continue;
                }
                if (cr is LookUpEdit)
                {
                    str.Append(ReturnNameViaControl(cr, 2, "Id") + " = N'" + (cr as LookUpEdit).EditValue + "', ");
                    continue;
                }
                if (cr is ComboBox)
                {
                    str.Append(ReturnNameViaControl(cr, 2, "Id") + " = N'" + (cr as ComboBox).SelectedValue + "', ");
                    continue;
                }
                if (cr is CalcEdit)
                {
                    str.Append(ReturnNameViaControl(cr, 3, string.Empty) + " = " + (cr as CalcEdit).Value + ", ");
                    continue;
                }
                if (cr is DateEdit)
                {
                    str.Append(ReturnNameViaControl(cr, 3, string.Empty) + " = '" +
                               Convert.ToDateTime((cr as DateEdit).DateTime).ToString(
                                   GlobalParameters.ServerDateTimeFormat) + "', ");
                    continue;
                }
                if (cr is TextEdit)
                {
                    str.Append(ReturnNameViaControl(cr, 3, string.Empty) + " = N'" + (cr as TextEdit).EditValue + "', ");
                    continue;
                }
                if (cr is CheckEdit)
                {
                    str.Append(ReturnNameViaControl(cr, 3, string.Empty) + " = " +
                               (cr as CheckEdit).ConvertCheckEditValueToInt() + ", ");
                    continue;
                }
                if (cr is ISelect)
                {
                    str.Append(ReturnNameViaControl(cr, 3, string.Empty) + " = N'" + (cr as ISelect).Id + "', ");
                }
            }

            if (addUserInformation)
                str.Append("UN = N'" + GlobalParameters.UserName + "' " + ", CD = GETDATE() ");
            else
                str.Remove(str.Length - 2, 2);
            str.Append(" WHERE Id" + tableName + " = N'" + id + "'");


            var clsLog = new CLSLog();
            clsLog.AddOldValues(tableName, id);

            UpdateDt(str.ToString());

            clsLog.AddNewValues(tableName, id);
            clsLog.CreateLog(tableName, "UPDATE", string.Empty);
        }

        static void UpdateDt(string txtComm)
        {
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
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

        public DataTable InitialazeControls(string id)
        {
            DataTable dt = FillDt(string.Format("SELECT * FROM {0} WHERE Id{0} = N'{1}'", tableName, id));
            InitialazeControls(dt);
            return dt;
        }

        public DataTable InitialazeControls(int id)
        {
            DataTable dt = FillDt(string.Format("SELECT * FROM {0} WHERE Id{0} = {1}", tableName, id));
            InitialazeControls(dt);
            return dt;
        }

        void InitialazeControls(DataTable dt)
        {
            var ctrls = frm.Controls.Cast<Control>().Where(cr => IsValueInExcludeControls(cr.Name) < 0);
            InitialazeControls(ctrls, dt);
        }

        void InitialazeControls(IEnumerable<Control> ctrls,DataTable dt)
        {
            foreach (Control cr in ctrls)
            {
                if (cr is GroupControl gb)
                {
                    var gbctrls = gb.Controls.Cast<Control>().Where(crx => IsValueInExcludeControls(crx.Name) < 0);
                    InitialazeControls(gbctrls, dt);
                }
                if (cr is LabelControl || cr is PanelControl || cr is SimpleButton)
                {
                    continue;
                }
                if (cr is LookUpEdit edit)
                {
                    string returnNameViaControl = ReturnNameViaControl(edit, 2, "Id");
                    string field = dt.Rows[0][returnNameViaControl].ToString();
                    edit.SetLookUpEditValue(field);
                    continue;
                }
                if (cr is ComboBox box)
                {
                    box.SelectedValue = dt.Rows[0][ReturnNameViaControl(box, 2, "Id")].ToString();
                    continue;
                }
                if (cr is CalcEdit calcEdit)
                {
                    calcEdit.Value =
                        Convert.ToDecimal(dt.Rows[0][ReturnNameViaControl(calcEdit, 3, string.Empty)].ToString());
                    continue;
                }
                if (cr is DateEdit dateEdit)
                {
                    dateEdit.DateTime =
                        Convert.ToDateTime(dt.Rows[0][ReturnNameViaControl(dateEdit, 3, string.Empty)].ToString());
                    continue;
                }
                if (cr is TextEdit textEdit)
                {
                    textEdit.EditValue = dt.Rows[0][ReturnNameViaControl(textEdit, 3, string.Empty)].ToString();
                    continue;
                }
                if (cr is CheckEdit checkEdit)
                {
                    checkEdit.Checked =
                        Convert.ToBoolean(dt.Rows[0][ReturnNameViaControl(checkEdit, 3, string.Empty)].ToString());
                    continue;
                }
                if (cr is ISelect fmg)
                {
                    fmg.Id = dt.Rows[0][ReturnNameViaControl(cr, 3, string.Empty)].ToString();
                    fmg.SetLabelText();
                }
            }
        }

        static DataTable FillDt(string txtComm)
        {
            var dt = new DataTable();
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
                var da = new SqlDataAdapter(comm);
                da.Fill(dt);
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

        public void Delete(int id)
        {
            DeleteDt(id);
        }

        void DeleteDt(int id)
        {
            string txtComm = string.Format("DELETE FROM {0} WHERE Id{0} = {1}", tableName, id);
            try
            {
                GlobalParameters.cn.Open();
                var comm = new SqlCommand(txtComm, GlobalParameters.cn);
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
    }

    class CLSTableImageOperation
    {
        readonly Control ctl;
        readonly string tableName;

        public CLSTableImageOperation(Control ctl, string tableName)
        {
            this.tableName = tableName;
            this.ctl = ctl;
        }

        public void Load(string id)
        {
            Load(Convert.ToInt32(id));
        }

        public void Load(int id)
        {
            DataTable dt = SQL.Select(string.Format("SELECT * FROM {0} WHERE Id{0} = {1}", tableName, id));
            if (dt.Rows.Count == 0) return;

            foreach (Control cr in ctl.Controls)
            {
                if (!(cr is PictureEdit)) continue;
                ((PictureEdit)cr).Image = null;
            }

            foreach (Control cr in ctl.Controls)
            {
                if (!(cr is PictureEdit)) continue;
                PictureEdit pic = (cr as PictureEdit);
                string name = cr.Name.Remove(0, 3);
                byte[] image = dt.Rows[0][name] as byte[];
                if (image != null && image.Length != 1)
                {
                    MemoryStream ms = new MemoryStream(image);
                    pic.Image = Image.FromStream(ms);
                }
                pic.Refresh();
            }
        }

        public void Save(int id)
        {
            SqlCommand comm = new SqlCommand();
            StringBuilder str = new StringBuilder();
            str.Append("UPDATE " + tableName + " SET ");
            //" Image1 = @Image1, Image2 = @Image2, Image3 = @Image3, Image4 = @Image4 WHERE  IdRoom = @IdRoom"
            bool existsImage = false;
            foreach (Control cr in ctl.Controls)
            {
                if (!(cr is PictureEdit))
                    continue;
                if (((PictureEdit)cr).Image == null)
                {
                    string txtComm = "UPDATE " + tableName + " SET " + cr.Name.Remove(0, 3) + " = null " + " WHERE Id" +
                                     tableName + " = " + id;
                    SQL.Update(txtComm);
                    continue;
                }
                string name = cr.Name.Remove(0, 3);
                str.Append(name + " = @" + name + ",");
                MemoryStream stream = new MemoryStream();
                (cr as PictureEdit).Image.Save(stream, ImageFormat.Jpeg);
                byte[] image = stream.ToArray();
                comm.Parameters.AddWithValue("@" + name, image);
                existsImage = true;
            }
            if (!existsImage)
                return;
            str.Remove(str.Length - 1, 1);
            str.Append(" WHERE Id" + tableName + " = " + id);
            comm.Connection = GlobalParameters.cn;
            comm.CommandText = str.ToString();
            GlobalParameters.cn.Open();
            comm.ExecuteNonQuery();
            GlobalParameters.cn.Close();
        }
    }
}