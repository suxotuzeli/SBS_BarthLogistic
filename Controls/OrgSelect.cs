using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SBS_Moms.Classes;
using SBS_Moms.FindForms;
using SBS_Moms.Interfaces;

namespace SBS_Moms.Controls
{
    public partial class OrgSelect : XtraUserControl, ISelect
    {
        public OrgSelect()
        {
            InitializeComponent();
            txtInput.ButtonClick += TxtInputOnButtonClick;
            Leave += txtIdOrg_Leave;
            txtInput.Focus();
            SearchOnLeave = false;
        }

        public bool SearchOnLeave { get; set; }

        public object Id
        {
            get { return txtInput.EditValue; }
            set { txtInput.EditValue = value; }
        }

        public string Label
        {
            get
            {
                return CustomLabel == null ? laOrg.Text : CustomLabel.Text;
            }
            set
            {
                if (CustomLabel == null) laOrg.Text = value;
                else CustomLabel.Text = value;
            }
        }

        public override string Text
        {
            get { return txtInput.Text; }
            set
            {
                txtInput.Text = value;
                if (value == string.Empty)
                    ValidateButtonEdit(txtInput, false);
            }
        }

        [Browsable(true)]
        public LabelControl CustomLabel { get; set; }

        void txtIdOrg_Leave(object sender, EventArgs e)
        {
            if (SearchOnLeave)
                SearchForOrg();
        }

        void TxtInputOnButtonClick(object sender, ButtonPressedEventArgs buttonPressedEventArgs)
        {
            ValidateButtonEdit(txtInput, false);
            var fmFOrg = new FOrgForm();
            if (fmFOrg.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = OrgProdParameters.selID.ToString();
                if (CustomLabel == null)
                    laOrg.Text = OrgProdParameters.selName;
                else
                    CustomLabel.Text = OrgProdParameters.selName;
                ValidateButtonEdit(txtInput, true);
            }
        }

        void ValidateButtonEdit(ButtonEdit cr, bool validated)
        {
            if (validated)
            {
                var resources = new ComponentResourceManager(typeof(OrgSelect));
                var x = new EditorButton(ButtonPredefines.Glyph);
                x.IsLeft = true;
                x.Width = cr.Properties.Buttons[0].Width;
                x.Image = (Image)resources.GetObject("txtInput.Properties.Buttons");
                cr.Properties.Buttons.Add(x);
            }
            else
            {
                cr.Tag = null;
                if (cr.Properties.Buttons.Count == 2)
                {
                    cr.Properties.Buttons.RemoveAt(1);
                }
            }
        }

        public void SearchForOrg()
        {
            if (!SearchOnLeave) return;
            ValidateButtonEdit(txtInput, false);
            var dtOrg = SQL.Select("SELECT IdOrg,Org FROM Org WHERE IdOrg = N'" + txtInput.Text + "'");
            if (dtOrg.Rows.Count == 0)
            {
                var fmFOrg = new FOrgForm();
                if (fmFOrg.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = OrgProdParameters.selID.ToString();
                    if (CustomLabel == null)
                        laOrg.Text = OrgProdParameters.selName;
                    else
                        CustomLabel.Text = OrgProdParameters.selName;
                    ValidateButtonEdit(txtInput, true);
                }
            }
            else
            {
                txtInput.Text = dtOrg.Rows[0]["IdOrg"].ToString();
                if (CustomLabel == null)
                    laOrg.Text = dtOrg.Rows[0]["Org"].ToString();
                else
                    CustomLabel.Text = dtOrg.Rows[0]["Org"].ToString();
                ValidateButtonEdit(txtInput, true);
            }
        }

        public void SearchForOrg(string filter)
        {
            if (!SearchOnLeave) return;
            ValidateButtonEdit(txtInput, false);
            if (filter != string.Empty)
                filter = "AND " + filter;
            var dtOrg = SQL.Select("SELECT IdOrg,Org FROM Org WHERE IdOrg = N'" + txtInput.Text + "' " + filter);
            if (dtOrg.Rows.Count == 0)
            {
                var fmFOrg = new FOrgForm();
                if (fmFOrg.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = OrgProdParameters.selID.ToString();
                    if (CustomLabel == null)
                        laOrg.Text = OrgProdParameters.selName;
                    else
                        CustomLabel.Text = OrgProdParameters.selName;
                    ValidateButtonEdit(txtInput, true);
                }
            }
            else
            {
                txtInput.Text = dtOrg.Rows[0]["IdOrg"].ToString();
                if (CustomLabel == null)
                    laOrg.Text = dtOrg.Rows[0]["Org"].ToString();
                else
                    CustomLabel.Text = dtOrg.Rows[0]["Org"].ToString();
                ValidateButtonEdit(txtInput, true);
            }
        }
    }
}