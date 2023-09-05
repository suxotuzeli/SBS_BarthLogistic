using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Interfaces;

namespace SBS_BarthLogistic.Controls
{
    [DefaultProperty("FieldName")]
    [Designer(typeof(FMGControlDesigner))]
    public partial class FMGComboFilterControl : XtraUserControl, IFMGFindControl
    {
        bool _checked;
        bool alwaysChecked;
        bool loaded;

        public FMGComboFilterControl()
        {
            InitializeComponent();
        }

        #region IFMGFindControl

        public string GetWhereCmd()
        {
            return string.Format(" AND (Id{0} = N'{1}') ", FieldName, chb.Checked ? cb.EditValue : 0);
        }

        public object GetValue()
        {
            return cb.Text;
        }

        public void SetValue(string value)
        {
            cb.SetLookUpEditValue(value);
        }

        public void AddProcParameter(SqlCommand cmd)
        {
            cmd.Parameters.Add("@" + (string.IsNullOrEmpty(ParameterName) ? "Id" + FieldName : ParameterName),
                SqlDbType.Int).Value = Checked ? cb.EditValue : 0;
        }

        [Category("FMG")]
        [Description("ველი/ცხრილი სახელი")]
        public string FieldName { get; set; }

        [DefaultValue("")]
        [Category("FMG")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("პარამეტრი, იმ შემთხვევაში თუ არ ემთხვევა FieldName-ს")]
        public string ParameterName { get; set; }

        [Category("FMG")]
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("ჩექბოქსი მონიშნულია თუ არა")]
        public bool Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                chb.Checked = _checked;
            }
        }

        [Category("FMG")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(false)]
        [Description("მუდმივად Checked")]
        public bool AlwaysChecked
        {
            get { return alwaysChecked; }
            set
            {
                if (!chb.Checked)
                    chb.Checked = value;
                alwaysChecked = value;
            }
        }

        [Category("FMG")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("ჩექბოქსის ტექსტი")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                chb.Text = value;
                base.Text = value;
            }
        }

        [Browsable(false)]
        public SplitContainer SplitContainer
        {
            get { return splitContainerControl; }
            set { }
        }

        public object GetId()
        {
            return chb.Checked ? Convert.ToInt32(cb.EditValue) : 0;
        }

        #endregion

        #region Events

        void chb_CheckedChanged(object sender, EventArgs e)
        {
            if (AlwaysChecked && !chb.Checked)
            {
                chb.Checked = true;
                return;
            }
            _checked = chb.Checked;
            if (!loaded) return;
            if (chb.Checked) Decolapse();
            else Colapse();
        }

        void FMGComboFilterControl_Load(object sender, EventArgs e)
        {
            loaded = true;
            if (chb.Checked) Decolapse();
            else Colapse();
            splitContainerControl.MouseUp += splitContainerControl_MouseUp;
            splitContainerControl.SplitterMoved += splitContainerControl_SplitterMoved;
        }

        bool save;

        void splitContainerControl_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (!save) return;
            this.SaveToRegistry();
            save = false;
        }

        void splitContainerControl_MouseUp(object sender, MouseEventArgs e)
        {
            save = true;
        }

        #endregion

        #region Methodz

        void Colapse()
        {
            if (this.IsInDesignMode()) return;
            cb.Visible = false;
            splitContainerControl.Panel2Collapsed = true;
        }

        void Decolapse()
        {
            cb.Visible = true;
            splitContainerControl.Panel2Collapsed = false;
            if (this.IsInRuntimeMode())
                this.RestoreFromRegistry();
            cb.Focus();
        }

        #endregion
    }
}