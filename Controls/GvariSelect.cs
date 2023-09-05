using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.FindForms;
using SBS_BarthLogistic.Interfaces;
using SBS_BarthLogistic.Properties;

namespace SBS_BarthLogistic.Controls
{
    [DefaultProperty("SearchOnLeave")]
    [DefaultEvent("ClickedForSearch")]
    [Designer(typeof(FMGSelectDesigner))]
    public partial class GvariSelect : XtraUserControl, ISelect
    {
        public GvariSelect()
        {
            InitializeComponent();
            txtInput.ButtonClick += TxtInputOnButtonClick;
            Leave += txtIdGvari_Leave;
            txtInput.Focus();
            SearchOnLeave = false;
        }

        #region  Properties

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("გამოიყენეთ Id Text-ის მაგივრად", true)]
        public override string Text { get; set; }

        [Category("FMG")]
        [Browsable(true)]
        [DefaultValue(false)]
        [Description("ტაბზე ძებნა")]
        public bool SearchOnLeave { get; set; }

        [Category("FMG")]
        [Browsable(true)]
        [Description("მიმდინარე აიდი")]
        public string Id
        {
            get { return txtInput.EditValue == null ? null : txtInput.EditValue.ToString(); }
            set { txtInput.EditValue = value; }
        }
        [Category("FMG")]
        [Browsable(true)]
        [Description("მოძებნილის სახელი")]

        public string Label
        {
            get { return CustomLabel == null ? laGvari.Text : CustomLabel.Text; }
            set
            {
                if (CustomLabel == null) laGvari.Text = value;
                else CustomLabel.Text = value;
            }
        }

        [Category("FMG")]
        [Browsable(true)]
        [Description("ფილტრი")]
        public string Filter { get; set; }

        [Category("FMG")]
        [Browsable(true)]
        [Description("დამატებითი Label")]
        public LabelControl CustomLabel { get; set; }

        #endregion

        #region PrivateMethods

        void txtIdGvari_Leave(object sender, EventArgs e)
        {
            if (!SearchOnLeave) return;
            if (ClickedForSearch != null)
                OnClickedForSearch(new ISelectArgs(Id));
            else
                SearchForGvari();
        }

        void TxtInputOnButtonClick(object sender, ButtonPressedEventArgs buttonPressedEventArgs)
        {
            if (ClickedForSearch != null)
                OnClickedForSearch(new ISelectArgs(Id));
            else
            {
                ValidateButtonEdit(false);
                ShowFindForm();
            }
        }

        void ValidateButtonEdit(bool validated)
        {
            if (txtInput.Properties.Buttons.Count == 2)
                txtInput.Properties.Buttons[1].Image = validated
                    ? Resources.AED_IsValid_16x16 : Resources.AED_InValid_16x16;
            else
            {
                var x = new EditorButton(ButtonPredefines.Glyph);
                x.IsLeft = true;
                x.Width = txtInput.Properties.Buttons[0].Width;
                x.Image = validated ? Resources.AED_IsValid_16x16 : Resources.AED_InValid_16x16;
                txtInput.Properties.Buttons.Add(x);
            }
        }

        void ShowFindForm()
        {
            //var fmFGvari = new FGvariForm(GenerateWhere());
            var fmFGvari = new FGvariForm();
            if (fmFGvari.ShowDialog() != DialogResult.OK) return;
            txtInput.Text = OrgProdParameters.selID;
            if (CustomLabel == null)
                laGvari.Text = OrgProdParameters.selName;
            else
                CustomLabel.Text = OrgProdParameters.selName;
            ValidateButtonEdit(true);
        }

        string GenerateWhere()
        {
            //var wh = string.Empty;
            //foreach (var parameterse in Filter)
            //{
            //    if (string.IsNullOrEmpty(parameterse.FieldName))
            //        wh += " " + parameterse.Value + " ";
            //    else
            //        wh += " AND " + parameterse.FieldName + " = N'" + parameterse.Value + "'";
            //}
            //return wh;
            return Filter ?? "";
        }

        #endregion

        #region PublicMethods

        public void SearchForGvari()
        {
            ValidateButtonEdit(false);
            var dtGvari =
                SQL.Select("SELECT IdGvari, Gvari FROM Gvari WHERE IdGvari = N'" + txtInput.Text +
                           "'" + GenerateWhere());
            if (dtGvari.Rows.Count == 0)
            {
                ShowFindForm();
            }
            else
            {
                txtInput.Text = dtGvari.Rows[0]["IdGvari"].ToString();
                if (CustomLabel == null)
                    laGvari.Text = dtGvari.Rows[0]["Gvari"].ToString();
                else
                    CustomLabel.Text = dtGvari.Rows[0]["Gvari"].ToString();
                ValidateButtonEdit(true);
            }
        }

        public void SetLabelText()
        {
            SearchForGvari();
        }

        #endregion

        #region Events

        public event EventHandler<ISelectArgs> ClickedForSearch;

        protected virtual void OnClickedForSearch(ISelectArgs e)
        {
            var handler = ClickedForSearch;
            if (handler != null)
                handler(this, e);
        }

        #endregion
    }
}