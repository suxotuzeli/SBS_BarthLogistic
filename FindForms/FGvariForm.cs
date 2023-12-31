using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.AddForms;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.Parameters;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FGvariForm : XtraForm
    {
        public FGvariForm()
        {
            InitializeComponent();
        }

        void FGvariForm_Activated(object sender, EventArgs e)
        {
            gvGvari.ChangeFonts();
            dgGvari.DataSource = ProceduresClass.SpReturnGvaris(txtLocate.Text);
        }

        void FGvariForm_Load(object sender, EventArgs e)
        {
            //            CLSTools.FPosition_Restore(this);
            if (File.Exists(GlobalParameters.XMLFolder + "ProdSearch.xml"))
                dgGvari.DefaultView.RestoreLayoutFromXml(GlobalParameters.XMLFolder + "GvariSearch.xml");
        }

        void txtLocate_TextChanged(object sender, EventArgs e)
        {
            dgGvari.DataSource = ProceduresClass.SpReturnGvaris(txtLocate.Text);
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            OrgProdParameters.selName = "";
            OrgProdParameters.selID = "0";
            Close();
        }

        void txtLocate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                gvGvari.MovePrev();

            if (e.KeyCode == Keys.Down)
                gvGvari.MoveNext();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            if (gvGvari.FocusedRowHandle > -1)
            {
                OrgProdParameters.selName = gvGvari.GetFocusedRowCellValue("Gvari").ToString();
                OrgProdParameters.selID = gvGvari.GetFocusedRowCellValue("IdGvari").ToString();
                OrgProdParameters.FG = Convert.ToInt32(gvGvari.GetFocusedRowCellValue("FG").ToString());
                OrgProdParameters.GvariAddress = gvGvari.GetFocusedRowCellValue("Address").ToString();
                OrgProdParameters.Miigo = gvGvari.GetFocusedRowCellValue("Miigo").ToString();
                Close();
            }
            else
                XtraMessageBox.Show("კლიენტი არაა არჩეული");
        }

        void btnAddDialog_Click(object sender, EventArgs e)
        {
            AedShow(0);
        }

        void AedShow(int idgvari)
        {
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvGvari.DataRowCount > 0)
                AedShow(Convert.ToInt32(gvGvari.GetFocusedRowCellValue("IdGvari").ToString()));
        }

        void gvGvari_ColumnPositionChanged(object sender, EventArgs e)
        {
            dgGvari.DefaultView.SaveLayoutToXml(GlobalParameters.XMLFolder + "GvariSearch.xml");
        }

        void FGvariForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLSTools.FPosition_Save(this);
        }
    }
}