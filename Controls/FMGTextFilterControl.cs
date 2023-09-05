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
    public partial class FMGTextFilterControl : XtraUserControl, IFMGFindControl
    {
        bool _checked;
        bool alwaysChecked;
        bool loaded;

        public FMGTextFilterControl()
        {
            InitializeComponent();
        }

        #region IFMGFindControl

        public string GetWhereCmd()
        {
            if (string.IsNullOrEmpty(FieldName))
                return " AND (" + Name.Substring(3) + " = N'" + txt.Text + "') ";
            return " AND (" + FieldName + " = N'" + txt.Text + "') ";
        }

        public object GetValue()
        {
            return Text;
        }

        public void SetValue(string value)
        {
            txt.Text = value;
        }

        public void AddProcParameter(SqlCommand cmd)
        {
            cmd.Parameters.Add("@" + (string.IsNullOrEmpty(ParameterName) ? FieldName : ParameterName),
                SqlDbType.NVarChar).Value = chb.Checked ? txt.Text : string.Empty;
        }

        public object GetId()
        {
            return txt.Text;
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(false)]
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
                alwaysChecked = value;
                if (!chb.Checked)
                    chb.Checked = value;
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

        [Bindable(false)]
        void FMGControl_Load(object sender, EventArgs e)
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
            txt.Visible = false;
            splitContainerControl.Panel2Collapsed = true;
        }

        void Decolapse()
        {
            txt.Visible = true;
            splitContainerControl.Panel2Collapsed = false;
            if (this.IsInRuntimeMode())
                this.RestoreFromRegistry();
            txt.Focus();
        }

        #endregion
    }
}