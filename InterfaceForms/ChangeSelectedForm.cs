using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.InterfaceForms
{
    public partial class ChangeSelectedForm : XtraForm
    {
        readonly string caption;
        readonly AdminChangeSelected adminChangeSelected;
        readonly string fieldName, text;
        readonly GridView gv;
        readonly int left = 25;
        readonly string tableName;
        BaseEdit control;
        int top = 50;

        public ChangeSelectedForm(GridView gv, GridColumn col, AdminChangeSelected adminChangeSelected)
        {
            this.gv = gv;
            this.adminChangeSelected = adminChangeSelected;
            tableName = gv.Name.Substring(2);
            fieldName = col.FieldName;
            caption = col.Caption;
            InitializeComponent();
            text = GlobalParameters.FieldName;
        }

        void ChangeSelectedForm_Load(object sender, EventArgs e)
        {
            Text = text;
            laInfo.Text = "მონიშნული ჩანაწერების რაოდენობა: " + gv.GetSelectedRows().Length;
            switch (adminChangeSelected.IdAdminControlType)
            {
                case 1:
                    CreateLabel();
                    CreateDateTime(false);
                    break;
                case 2:
                    CreateLabel();
                    CreateDateTime(false);
                    break;
                case 3:
                    CreateLabel();
                    CreateTextEdit();
                    break;
                case 4:
                    CreateLabel();
                    CreateLookupEdit();
                    break;
                case 5:
                    CreateCheckEdit();
                    break;
                case 6:
                    CreateLabel();
                    CreateSpinEdit();
                    break;
                case 7:
                    CreateLabel();
                    CreateCalcEdit();
                    break;
                default:
                    Close();
                    return;
            }

            foreach (GridColumn column in gv.Columns)
            {
                gridView.Columns.Add(new GridColumn
                {
                    Visible = column.Visible,
                    VisibleIndex = column.VisibleIndex,
                    Name = column.Name,
                    FieldName = column.FieldName,
                    Caption = column.Caption,
                    DisplayFormat =
                    {
                        FormatType = column.DisplayFormat.FormatType,
                        FormatString = column.DisplayFormat.FormatString
                    }
                });
            }
            var dt = (gv.GridControl.DataSource as DataTable).Clone();
            foreach (var s in gv.GetSelectedRows())
            {
                dt.ImportRow(gv.GetDataRow(s));
            }
            dg.DataSource = dt;
        }

        void CreateLabel()
        {
            var la = new LabelControl();
            la.AutoSize = true;
            la.Name = "la" + fieldName;
            la.Text = caption;
            la.Top = top;
            la.Left = left;
            paMain.Controls.Add(la);
            top += la.Height + 5;
        }

        void CreateDateTime(bool hasTime)
        {
            var ctrl = new DateEdit();
            ctrl.Name = "txt" + fieldName;
            ctrl.Top = top;
            ctrl.Left = left;
            ctrl.SetDateFormat(true, hasTime);
            paMain.Controls.Add(ctrl);
            control = ctrl;
        }

        void CreateCheckEdit()
        {
            var ctrl = new CheckEdit();
            ctrl.Name = "chb" + fieldName;
            ctrl.Text = caption;
            ctrl.Top = top;
            ctrl.Left = left;
            ctrl.Properties.AutoWidth = true;
            paMain.Controls.Add(ctrl);
            control = ctrl;
        }

        void CreateLookupEdit()
        {
            var ctrl = new LookUpEdit();
            ctrl.Name = "cb" + fieldName;
            ctrl.Top = top;
            ctrl.Left = left;
            ctrl.Width = 200;
            ctrl.FillDataToLookUpEditAndSetFont();
            paMain.Controls.Add(ctrl);
            control = ctrl;
        }

        void CreateTextEdit()
        {
            var ctrl = new TextEdit();
            ctrl.Name = "txt" + fieldName;
            ctrl.Top = top;
            ctrl.Left = left;
            ctrl.Width = 200;
            paMain.Controls.Add(ctrl);
            control = ctrl;
        }

        void CreateCalcEdit()
        {
            var ctrl = new CalcEdit();
            ctrl.Name = "txt" + fieldName;
            ctrl.Top = top;
            ctrl.Left = left;
            ctrl.Width = 200;
            ctrl.Properties.Appearance.Options.UseFont = true;
            ctrl.Properties.Buttons.Add(
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                {
                    ImageLocation = ImageLocation.MiddleCenter,
                    Image = Properties.Resources.AED_txtCalcEdit
                });
            ctrl.Properties.DisplayFormat.FormatString = "f4";
            ctrl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            ctrl.Properties.EditFormat.FormatString = "f4";
            ctrl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            ctrl.Properties.Mask.EditMask = "f4";
            ctrl.Properties.NullText = "0.0000";
            paMain.Controls.Add(ctrl);
            control = ctrl;
        }

        void CreateSpinEdit()
        {
            var ctrl = new SpinEdit();
            ctrl.Name = "txt" + fieldName;
            ctrl.Top = top;
            ctrl.Left = left;
            ctrl.Width = 200;
            ctrl.Properties.Appearance.Options.UseFont = true;
            ctrl.Properties.Buttons.Add(
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
                {
                    ImageLocation = ImageLocation.MiddleCenter,
                    Image = Properties.Resources.AED_txtCalcEdit
                });
            ctrl.Properties.Mask.EditMask = "d";
            paMain.Controls.Add(ctrl);
            control = ctrl;
        }

        void btnOk_Click(object sender, EventArgs e)
        {
            object result;
            var values = " IN (";
            foreach (var s in gv.GetSelectedRows())
                values = values + string.Format("N'{0}', ", gv.GetDataRow(s)["Id" + tableName]);
            values = values.Substring(0, values.Length - 2) + ")";
            if (control is LookUpEdit)
            {
                result = ((LookUpEdit)control).EditValue;
            }
            else if (control is CheckEdit)
            {
                result = ((CheckEdit)control).Checked ? 1 : 0;
            }
            else if (control is DateEdit)
            {
                result = ((DateEdit)control).DateTime.ToString(GlobalParameters.ServerDateTimeFormat);
            }
            else if (control is TextEdit)
            {
                result = control.Text.Replace("'", "''");
            }
            else
            {
                DialogResult = DialogResult.Abort;
                return;
            }
            SQL.Update(string.Format("UPDATE {0} SET {1}{2} = N'{3}' WHERE Id{0}{4}", tableName,
                control is LookUpEdit ? "Id" : string.Empty, fieldName, result, values));
            DialogResult = DialogResult.OK;
        }
    }
}