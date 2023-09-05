using System;
using System.ComponentModel;
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
    public partial class ProdSelect : XtraUserControl, ISelect
    {
        public ProdSelect()
        {
            InitializeComponent();
            txtInput.ButtonClick += TxtInputOnButtonClick;
            Leave += txtIdProd_Leave;
            txtInput.Focus();
            SearchOnLeave = false;
            Fg = "1";
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
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [Bindable(true)]
        [DefaultValue("1")]
        [Description("ფასთა ჯგუფი")]
        public string Fg { get; set; }

        [Category("FMG")]
        [Browsable(true)]
        [Description("მოძებნილის სახელი")]
        public string Label
        {
            get { return CustomLabel == null ? laProd.Text : CustomLabel.Text; }
            set
            {
                if (CustomLabel == null) laProd.Text = value;
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

        void txtIdProd_Leave(object sender, EventArgs e)
        {
            if (!SearchOnLeave) return;
            if (ClickedForSearch != null)
                OnClickedForSearch(new ISelectArgs(Id));
            else
                SearchForProd();
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

        bool ShowFindForm()
        {
            var s = SearchOnLeave;
            SearchOnLeave = false;
            var fmFProd = new FProdForm(Fg, GenerateWhere());
            if (fmFProd.ShowDialog() != DialogResult.OK)
            {
                SearchOnLeave = s;
                return false;
            }
            txtInput.Text = OrgProdParameters.selID;
            if (CustomLabel == null)
                laProd.Text = OrgProdParameters.selName;
            else
                CustomLabel.Text = OrgProdParameters.selName;
            ValidateButtonEdit(true);
            SearchOnLeave = s;
            return true;
        }

        string GenerateWhere()
        {
            
            return Filter ?? "";
        }

        #endregion

        #region PublicMethods

        public bool SearchForProd()
        {
            bool s = SearchOnLeave;
            SearchOnLeave = false;
            ValidateButtonEdit(false);
            var dtProd =
                SQL.Select("SELECT IdProd, Prod, Fasi" + Fg + " AS Fasi FROM Prod WHERE IdProd = N'" + txtInput.Text +
                           "'" + GenerateWhere());
            if (dtProd.Rows.Count == 0)
            {
                SearchOnLeave = s;
                return ShowFindForm();
            }
            txtInput.Text = dtProd.Rows[0]["IdProd"].ToString();
            if (CustomLabel == null)
                laProd.Text = dtProd.Rows[0]["Prod"].ToString();
            else
                CustomLabel.Text = dtProd.Rows[0]["Prod"].ToString();
            OrgProdParameters.selFasi = Convert.ToDecimal(dtProd.Rows[0]["Fasi"].ToString());
            ValidateButtonEdit(true);
            SearchOnLeave = s;
            return true;
        }
        public bool SearchForProd(string whereClause)
        {
            bool s = SearchOnLeave;
            SearchOnLeave = false;
            ValidateButtonEdit(false);
            var dtProd =
                SQL.Select("SELECT IdProd, Prod, Fasi" + Fg + " AS Fasi FROM Prod WHERE IdProd = N'" + txtInput.Text +
                           "'" + whereClause);
            if (dtProd.Rows.Count == 0)
            {
                SearchOnLeave = s;
                return ShowFindForm();
            }
            txtInput.Text = dtProd.Rows[0]["IdProd"].ToString();
            if (CustomLabel == null)
                laProd.Text = dtProd.Rows[0]["Prod"].ToString();
            else
                CustomLabel.Text = dtProd.Rows[0]["Prod"].ToString();
            OrgProdParameters.selFasi = Convert.ToDecimal(dtProd.Rows[0]["Fasi"].ToString());
            ValidateButtonEdit(true);
            SearchOnLeave = s;
            return true;
        }
        public void SetLabelText()
        {
            SearchForProd();
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