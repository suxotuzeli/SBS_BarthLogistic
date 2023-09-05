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
    public partial class FMGDateFilterControl : XtraUserControl, IFMGFindControl
    {
        bool _checked;
        bool alwaysChecked;
        bool loaded;
        bool showTime;

        public FMGDateFilterControl()
        {
            InitializeComponent();
        }

        #region IFMGFindControl

        public string GetWhereCmd()
        {
            return string.Format(" AND ('{0}' <= {1} AND {1} <= '{2}') ",
                txtData1.DateTime.ToString(GlobalParameters.ServerDateTimeFormat),
                FieldName, txtData2.DateTime.ToString(GlobalParameters.ServerDateTimeFormat));
        }

        public object GetValue()
        {
            return txtData1.DateTime + " - " + txtData2.DateTime;
        }

        public void SetValue(string value)
        {
            var strings = value.Split(';');
            if (strings.Length <= 1) return;
            txtData1.DateTime = Convert.ToDateTime(strings[0]);
            txtData2.DateTime = Convert.ToDateTime(strings[1]);
        }

        public void AddProcParameter(SqlCommand cmd)
        {
            cmd.Parameters.Add("@" + (string.IsNullOrEmpty(ParameterName) ? FieldName : ParameterName) + "1",
                SqlDbType.SmallDateTime).Value = txtData1.DateTime;
            cmd.Parameters.Add("@" + (string.IsNullOrEmpty(ParameterName) ? FieldName : ParameterName) + "2",
                SqlDbType.SmallDateTime).Value = txtData2.DateTime;
        }

        public object GetId()
        {
            return txtData1.DateTime.ToString(GlobalParameters.ServerDateTimeFormat) + ';' +
                   txtData2.DateTime.ToString(GlobalParameters.ServerDateTimeFormat);
        }

        public DateTime GetValueToShortDate1()
        {
            return Convert.ToDateTime(Convert.ToDateTime(txtData1.EditValue).ToShortDateString());
        }

        public DateTime GetValueToShortDate2()
        {
            return Convert.ToDateTime(Convert.ToDateTime(txtData2.EditValue).ToShortDateString());
        }

        [Category("FMG")]
        [DefaultValue("")]
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
                chb.Checked = true;
                alwaysChecked = value;
            }
        }

        [Category("FMG")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(false)]
        [Description("გამოჩნდეს დრო")]
        public bool ShowTime
        {
            get { return showTime; }
            set
            {
                showTime = value;
                txtData1.Properties.Mask.EditMask = showTime
                    ? (txtData2.Properties.Mask.EditMask = "dd.MM.yyyy hh:mm")
                    : (txtData2.Properties.Mask.EditMask = "dd.MM.yyyy");
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

        void FMGDateFilterControl_Load(object sender, EventArgs e)
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
            txtData1.Width = txtData2.Width = splitContainerControl.Panel2.Width / 2;
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
            txtData1.Visible = txtData2.Visible = false;
            splitContainerControl.Panel2Collapsed = true;
        }

        void Decolapse()
        {
            txtData1.Visible = txtData2.Visible = true;
            splitContainerControl.Panel2Collapsed = false;
            if (this.IsInRuntimeMode())
                this.RestoreFromRegistry();
            txtData1.Focus();
            txtData1.Width = txtData2.Width = splitContainerControl.Panel2.Width / 2;
        }

        #endregion
    }
}