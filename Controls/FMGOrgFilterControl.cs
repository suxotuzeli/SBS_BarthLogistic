using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_Moms.Classes;
using SBS_Moms.Interfaces;

namespace SBS_Moms.Controls
{
    [DefaultProperty("FieldName")]
    public partial class FMGOrgFilterControl : XtraUserControl, IFMGFindControl
    {
        bool _checked;
        bool alwaysChecked;

        #region IFMGFindControl

        public FMGOrgFilterControl()
        {
            InitializeComponent();
        }

        public string GetWhereCmd()
        {
            return " AND (" + FieldName + " = " + txt.Text + ") ";
        }

        public object GetValue()
        {
            return txt.Text;
        }

        public void SetValue(string value)
        {
            txt.Text = value;
        }

        public void AddProcParameter(SqlCommand cmd)
        {
            cmd.Parameters.Add("@" + (string.IsNullOrEmpty(ParameterName) ? FieldName : ParameterName),
                SqlDbType.NVarChar).Value = chb.Checked ? txt.Text : "0";
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

        #endregion

        #region Event

        void chb_CheckedChanged(object sender, EventArgs e)
        {
            if (AlwaysChecked && !chb.Checked)
            {
                chb.Checked = true;
                return;
            }
            _checked = chb.Checked;
            if (chb.Checked) decolapse();
            else colapse();
        }

        [Bindable(false)]
        void FMGTextFilterControl_Load(object sender, EventArgs e)
        {
            if (chb.Checked) decolapse();
            else colapse();
            splitContainerControl.SplitterMoved += splitContainerControl_SplitterMoved;
        }

        void splitContainerControl_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainerControl.SplitterMoved -= splitContainerControl_SplitterMoved;
            splitContainerControl.SplitterMoved += splitContainerControl_SplitterMoved_Real;
            splitContainerControl.Panel2Collapsed = false;
            this.RestoreFromRegistry();
        }
        void splitContainerControl_SplitterMoved_Real(object sender, SplitterEventArgs e)
        {
            this.SaveToRegistry();
        }

        #endregion

        #region Methodz

        void colapse()
        {
            myLabel.Visible =
            txt.Visible = false;
            splitContainerControl.Panel2Collapsed = true;
        }

        void decolapse()
        {
            myLabel.Visible =
            txt.Visible = true;
            splitContainerControl.Panel2Collapsed = false;
            this.RestoreFromRegistry();
            txt.Focus();
        }

        #endregion

    }
}