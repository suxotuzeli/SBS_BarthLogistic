using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FProdForm : XtraForm
    {
        readonly string additionalFilter;
        readonly string fg;

        public FProdForm(string fg)
        {
            InitializeComponent();
            this.fg = fg;
            additionalFilter = "";
        }

        public FProdForm(string fg, string additionalFilter)
        {
            InitializeComponent();
            this.fg = fg;
            this.additionalFilter = additionalFilter;
        }

        public FProdForm()
        {
            InitializeComponent();
            fg = "1";
            additionalFilter = "";
        }

        void FProdForm_Activated(object sender, EventArgs e)
        {
            ReturnProds();
        }

        void ReturnProds()
        {
            if (txtLocate.Text.Length >= OrgProdParameters.ProdSearchSymbolCount)
                dgProd.DataSource = ProceduresClass.SpReturnProds(txtLocate.Text, fg, radioGroup1.SelectedIndex,
                    additionalFilter);
        }

        void FProdForm_Load(object sender, EventArgs e)
        {
            gvProd.ChangeFonts();
            gvProdBarCode.ChangeFonts();
            dgProd.DataSource = new DataTable();
            dgProd.RestoreLayoutFromXml();
            //TODO qveda kometari mosaxsnelia
            //CLSTools.FPosition_Restore(this);

            radioGroup1.SelectedIndex = OrgProdParameters.ProdSearchInCode ? 1 : 0;
            txtLocate.Text = OrgProdParameters.ProdSearchInCode ? OrgProdParameters.IdProd : OrgProdParameters.Prod;
            btnProdPicture.Visible = OrgProdParameters.ShowProdPicture;
            xtraTabControl1.SelectedPageChanged += xtraTabControl1_TabIndexChanged;
        }

        void txtLocate_TextChanged(object sender, EventArgs e)
        {
            ReturnProds();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            OrgProdParameters.selName = "";
            OrgProdParameters.selID = "";
            OrgProdParameters.ProdRaod = 0;
            Close();
        }

        void txtLocate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && ModifierKeys == Keys.Control)
            {
                radioGroup1.SelectedIndex = radioGroup1.SelectedIndex == 2 ? 0 : radioGroup1.SelectedIndex + 1;
                e.Handled = true;
            }
        }

        void txtLocate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                gvProd.MovePrev();

            if (e.KeyCode == Keys.Down)
                gvProd.MoveNext();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (gvProd.FocusedRowHandle > -1)
            {
                OrgProdParameters.selName = gvProd.GetFocusedRowCellValue("Prod").ToString();
                OrgProdParameters.selID = gvProd.GetFocusedRowCellValue("IdProd").ToString();
                OrgProdParameters.selFasi = Convert.ToDecimal(gvProd.GetFocusedRowCellValue("Fasi"));
                OrgProdParameters.ProdRaod = Convert.ToDouble(gvProd.GetFocusedRowCellValue("ProdRaod"));
                OrgProdParameters.SacCheck = Convert.ToBoolean(gvProd.GetFocusedRowCellValue("SacControl"));
                OrgProdParameters.selCompRaod = Convert.ToDouble(gvProd.GetFocusedRowCellValue("CompRaod"));

                Close();
            }
            else
                XtraMessageBox.Show("არ მოიძებნა შესაბამისი ჩანაწერი");
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var idprod = (sender as SimpleButton).Name != "btnAdd"
                ? gvProd.GetFocusedRowCellValue("IdProd").ToString() : "0";
            InterfaceParameters.CloseForm = true;
//            using (var fm = new AddProdForm(idprod, idprod != "0", "Prod"))
//            {
//                if (fm.ShowDialog() != DialogResult.OK)
//                {
//                    InterfaceParameters.CloseForm = false;
//                    return;
//                }
//                var dtProd =
//                    SQL.Select("SELECT * FROM Prod INNER JOIN ProdG ON Prod.IdProdG = ProdG.IdProdG WHERE IdProd = N'" +
//                               fm.IdProd + "'");
//                if (dtProd.Rows.Count == 0)
//                    return;
//                OrgProdParameters.selName = dtProd.Rows[0]["Prod"].ToString();
//                OrgProdParameters.selID = dtProd.Rows[0]["IdProd"].ToString();
//                OrgProdParameters.selFasi = Convert.ToDecimal(dtProd.Rows[0]["Fasi" + fg].ToString());
//                OrgProdParameters.ProdRaod = Convert.ToDouble(dtProd.Rows[0]["ProdRaod"].ToString());
//                OrgProdParameters.SacCheck = Convert.ToBoolean(dtProd.Rows[0]["SacControl"].ToString());
//                DialogResult = DialogResult.OK;
//            }
            InterfaceParameters.CloseForm = false;
        }

        void btnProdPicture_Click(object sender, EventArgs e)
        {
        }

        void gvProd_ColumnPositionChanged(object sender, EventArgs e)
        {
            dgProd.SaveLayoutToXml();
        }

        void gvProd_ColumnWidthChanged(object sender, ColumnEventArgs e)
        {
            dgProd.SaveLayoutToXml();
        }

        void FProdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLSTools.FPosition_Save(this);
        }

        void dgProdBarCode_DoubleClick(object sender, EventArgs e)
        {
            var row = gvProdBarCode.GetFocusedDataRow();
            if (row != null)
                txtLocate.Text = row["IdProd"].ToString();
        }

        void xtraTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (gvProdBarCode.RowCount < 1)
                dgProdBarCode.DataSource =
                    SQL.Select("SELECT * FROM ProdBarCode INNER JOIN Prod ON Prod.IdProd = ProdBarCode.IdProd ");
        }
    }
}