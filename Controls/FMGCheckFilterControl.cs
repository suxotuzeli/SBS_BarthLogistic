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
    public partial class FMGCheckFilterControl : XtraUserControl, IFMGFindControl
    {
        bool _checked;
        bool alwaysChecked;
        bool loaded;
        string textHidden;

        public FMGCheckFilterControl()
        {
            InitializeComponent();
        }

        #region IFMGFindControl

        public string GetWhereCmd()
        {
            return string.Format(" AND ({0} = '{1}') ", FieldName, chbHidden.Checked ? 1 : 0);
        }

        public object GetValue()
        {
            return chb.Text;
        }

        public void SetValue(string value)
        {
            chbHidden.Checked = value == "1";
        }

        public void AddProcParameter(SqlCommand cmd)
        {
            cmd.Parameters.Add("@" + (string.IsNullOrEmpty(ParameterName) ? FieldName : ParameterName),
                SqlDbType.Int).Value = Checked ? 1 : 0;
        }

        public object GetId()
        {
            return chbHidden.Checked ? 1 : 0;
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

        [Category("FMG")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("დამალული ჩექბოქსის ტექსტი")]
        public string TextHidden
        {
            get { return string.IsNullOrEmpty(textHidden) ? base.Text : textHidden; }
            set
            {
                textHidden = value;
                chbHidden.Text = value;
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
            chbHidden.Visible = false;
            splitContainerControl.Panel2Collapsed = true;
        }

        void Decolapse()
        {
            chbHidden.Visible = true;
            splitContainerControl.Panel2Collapsed = false;
            if (this.IsInRuntimeMode())
                this.RestoreFromRegistry();
            chbHidden.Focus();
        }

        #endregion
    }
}