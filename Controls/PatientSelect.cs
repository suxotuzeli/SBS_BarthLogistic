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
    public partial class PatientSelect : XtraUserControl, ISelect
    {
        public PatientSelect()
        {
            InitializeComponent();
            txtInput.ButtonClick += TxtInputOnButtonClick;
            Leave += txtIdPatient_Leave;
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
                return CustomLabel == null ? laPatient.Text : CustomLabel.Text;
            }
            set
            {
                if (CustomLabel == null) laPatient.Text = value;
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

        void txtIdPatient_Leave(object sender, EventArgs e)
        {
            if (SearchOnLeave)
                SearchForPatient();
        }

        void TxtInputOnButtonClick(object sender, ButtonPressedEventArgs buttonPressedEventArgs)
        {
            ValidateButtonEdit(txtInput, false);
            var fmFPatient = new FPatientForm();
            if (fmFPatient.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = OrgProdParameters.selID.ToString();
                if (CustomLabel == null)
                    laPatient.Text = OrgProdParameters.selName;
                else
                    CustomLabel.Text = OrgProdParameters.selName;
                ValidateButtonEdit(txtInput, true);
            }
        }

        void ValidateButtonEdit(ButtonEdit cr, bool validated)
        {
            if (validated)
            {
                var resources = new ComponentResourceManager(typeof(PatientSelect));
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

        public void SearchForPatient()
        {
            if (!SearchOnLeave) return;
            ValidateButtonEdit(txtInput, false);
            var dtPatient = SQL.Select("SELECT IdPatient,Patient FROM Patient WHERE IdPatient = N'" + txtInput.Text + "'");
            if (dtPatient.Rows.Count == 0)
            {
                var fmFPatient = new FPatientForm();
                if (fmFPatient.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = OrgProdParameters.selID.ToString();
                    if (CustomLabel == null)
                        laPatient.Text = OrgProdParameters.selName;
                    else
                        CustomLabel.Text = OrgProdParameters.selName;
                    ValidateButtonEdit(txtInput, true);
                }
            }
            else
            {
                txtInput.Text = dtPatient.Rows[0]["IdPatient"].ToString();
                if (CustomLabel == null)
                    laPatient.Text = dtPatient.Rows[0]["Patient"].ToString();
                else
                    CustomLabel.Text = dtPatient.Rows[0]["Patient"].ToString();
                ValidateButtonEdit(txtInput, true);
            }
        }

        public void SearchForPatient(string filter)
        {
            if (!SearchOnLeave) return;
            ValidateButtonEdit(txtInput, false);
            if (filter != string.Empty)
                filter = "AND " + filter;
            var dtPatient = SQL.Select("SELECT IdPatient,Patient FROM Patient WHERE IdPatient = N'" + txtInput.Text + "' " + filter);
            if (dtPatient.Rows.Count == 0)
            {
                var fmFPatient = new FPatientForm();
                if (fmFPatient.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = OrgProdParameters.selID.ToString();
                    if (CustomLabel == null)
                        laPatient.Text = OrgProdParameters.selName;
                    else
                        CustomLabel.Text = OrgProdParameters.selName;
                    ValidateButtonEdit(txtInput, true);
                }
            }
            else
            {
                txtInput.Text = dtPatient.Rows[0]["IdPatient"].ToString();
                if (CustomLabel == null)
                    laPatient.Text = dtPatient.Rows[0]["Patient"].ToString();
                else
                    CustomLabel.Text = dtPatient.Rows[0]["Patient"].ToString();
                ValidateButtonEdit(txtInput, true);
            }
        }
    }
}