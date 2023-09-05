using System;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace SBS_BarthLogistic.Classes
{
    class CLSAedAll
    {
        readonly PanelControl panel;
        string selectedTableName;
        readonly string tableName;
        int top = 15;
        const int Left = 15;

        public CLSAedAll(string tableName)
        {
            this.tableName = tableName;
        }

        public CLSAedAll(string tableName, PanelControl panel)
        {
            this.tableName = tableName;
            this.panel = panel;
        }

        public string GetSelectString()
        {
            var dt =
                SQL.Select(
                    "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE COLUMN_NAME LIKE 'Id%' AND COLUMN_NAME <> 'Id" +
                    tableName + "' AND TABLE_NAME='" + tableName + "'");
            if (dt.Rows.Count == 0)
                selectedTableName = tableName;
            else
                selectedTableName = tableName + "View";
            return "SELECT * FROM " + selectedTableName;
        }

        public void GenerateGridViewFields(GridView gv)
        {
            var dt =
                SQL.Select("SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" +
                           selectedTableName + "'");
            if (dt.Rows.Count == 0)
                return;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var columnName = dt.Rows[i]["COLUMN_NAME"].ToString();
                var dt1 = SQL.Select("SELECT TOP 1 * FROM AdminCnobariFields WHERE FieldName  = '" + columnName + "'");
                if (dt1.Rows.Count == 0)
                {
                    AddGridViewColumn(gv, columnName, columnName.Remove(0, 2) == tableName ? "კოდი" : columnName, false, 75);
                    continue;
                }
                AddGridViewColumn(gv, columnName, dt1.Rows[0]["FieldCaption"].ToString(), true,
                    Convert.ToInt32(dt1.Rows[0]["Width"].ToString()));
            }
        }

        public void GenerateFormControls()
        {
            var dt =
                SQL.Select("SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" +
                           tableName + "'");
            if (dt.Rows.Count == 0)
                return;
            top = 10;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var columnName = dt.Rows[i]["COLUMN_NAME"].ToString();
                var type = dt.Rows[i]["DATA_TYPE"].ToString();
                if (columnName == "UN" || columnName == "CD")
                    continue;
                if (columnName.Substring(0, 2) == "Id" && columnName.Remove(0, 2) == tableName)
                    continue;
                var searchColumnName = columnName.Substring(0, 2) == "Id" ? columnName.Remove(0, 2) : columnName;
                var dt1 =
                    SQL.Select("SELECT TOP 1 * FROM AdminCnobariFields WHERE FieldName  = '" + searchColumnName + "'");
                if (dt1.Rows.Count == 0)
                    continue;
                CreateFormControl(type, dt1.Rows[0], columnName);
            }
        }

        void CreateFormControl(string type, DataRow dr, string columnName)
        {
            string fieldName = dr["FieldName"].ToString(), fieldCaption = dr["FieldCaption"].ToString(),
                   defaultValue = dr["DefaultValue"].ToString();
            int width = Convert.ToInt32(dr["Width"].ToString());

            if (columnName.Substring(0, 2) == "Id")
            {
                CreateLabel(fieldName, fieldCaption);
                CreateLookupEdit(fieldName, width);
                return;
            }
            switch (type)
            {
                case "datetime":
                case "smalldatetime":
                    CreateLabel(fieldName, fieldCaption);
                    CreateDateTime(fieldName, defaultValue, width);
                    break;
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                    CreateLabel(fieldName, fieldCaption);
                    CreateEdit(fieldName, defaultValue, width);
                    break;
                case "int":
                case "smallint":
                case "numeric":
                case "decimal":
                case "float":
                case "money":
                case "smallmoney":
                    CreateLabel(fieldName, fieldCaption);
                    CreateEdit(fieldName, defaultValue, width);
                    return;
                case "bit":
                    CreateCheckEdit(fieldName, fieldCaption, defaultValue);
                    break;
            }
        }

        void CreateLabel(string name, string caption)
        {
            var la = new LabelControl();
            la.AutoSize = true;
            la.Name = "la" + name;
            la.Text = caption;
            la.Top = top;
            la.Left = Left;
            panel.Controls.Add(la);
            top += la.Height + 5;
        }

        void CreateDateTime(string name, string defaultValue, int width)
        {
            var txt = new DateEdit();
            txt.Name = "txt" + name;
            txt.EditValue = DateTime.Now;
            txt.Top = top;
            txt.Left = Left;
            txt.Width = width;
            txt.SetDateFormat(false);
            txt.DateTime = Convert.ToDateTime(defaultValue);
            panel.Controls.Add(txt);
            top += 30;
        }

        void CreateCheckEdit(string name, string caption, string defaultValue)
        {
            var chb = new CheckEdit();
            chb.Name = "chb" + name;
            chb.Text = caption;
            chb.Top = top;
            chb.Left = Left;
            chb.Properties.AutoWidth = true;
            chb.Checked = defaultValue == "1";
            panel.Controls.Add(chb);
            top += 30;
        }

        void CreateLookupEdit(string name, int width)
        {
            var cb = new LookUpEdit();
            cb.Name = "cb" + name;
            cb.Top = top;
            cb.Left = Left;
            cb.Width = width;
            cb.Properties.AllowNullInput = DefaultBoolean.False;
            cb.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            cb.Properties.ShowHeader = false;
            cb.Properties.ShowNullValuePromptWhenFocused = true;
            cb.Properties.TextEditStyle = TextEditStyles.Standard;
            cb.Properties.NullText = StringParameters.LookupEditNullText;
            panel.Controls.Add(cb);
            top += 30;
        }

        void CreateEdit(string name, string defaultValue, int width)
        {
            var txt = new TextEdit();
            txt.Name = "txt" + name;
            txt.Top = top;
            txt.Left = Left;
            txt.Width = width;
            txt.Text = defaultValue;
            panel.Controls.Add(txt);
            top += 30;
        }

        void AddGridViewColumn(GridView gv, string columnName, string columnHeader, bool visible, int width)
        {
            var col = new GridColumn();
            col.Name = "col" + columnName;
            col.FieldName = columnName;
            col.Caption = columnHeader;
            col.Visible = visible;
            col.Width = width;
            gv.Columns.Add(col);
        }

        public bool HasUserInformation()
        {
            var dt =
                SQL.Select("SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" +
                           tableName + "'");
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var columnName = dt.Rows[i]["COLUMN_NAME"].ToString();
                if (columnName == "CD")
                    return true;
            }
            return false;
        }
    }
}