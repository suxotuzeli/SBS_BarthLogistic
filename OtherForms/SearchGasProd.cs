using System.Windows.Forms;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class SearchGasProd : Form
    {
        public string IdProd = "";
        public string Prod = "";
        private string idOrg;
        private string idProd = "";
        public SearchGasProd(string idOrg)
        {
            this.idOrg = idOrg;
            InitializeComponent();
            FillData();
        }

        public SearchGasProd(string idOrg,string idProd)
        {
            this.idOrg = idOrg;
            this.idProd = idProd;
            InitializeComponent();
            FillData();
        }

        private void FillData(string filter ="")
        {
            var prodFilter = string.IsNullOrEmpty(idProd) ? "" : $"AND IdProd = N'{idProd}'";
            dgShem2.DataSource =  SQL.Select(
                $"SELECT ProekSectorZone,ProekSector,IdProd,Prod,Raod,Fasi,Palet,PartNumber " +
                $"FROM dbo.Shem2 " +
                $"INNER JOIN dbo.Shem1 ON Shem1.IdShem1 = Shem2.IdShem1 " +
                $"INNER JOIN dbo.ProekSector ON ProekSector.IdProekSector = Shem2.IdProekSector " +
                $"WHERE IdOrg = {idOrg} {prodFilter} {filter}" +
                $"GROUP BY ProekSectorZone,ProekSector,IdProd,Prod,Raod,Fasi,Palet,PartNumber");
        }

        private void DgGas2_DoubleClick(object sender, System.EventArgs e)
        {
            btnOk_Click(sender,e);
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            var x = gvShem2.ReturnValue("IdProd");
            if (x == "0")
                XtraMessageBox.Show("გთოხვთ აირჩიოთ პროდუქცია", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                IdProd = x;
                Prod = gvShem2.ReturnValue("Prod");
                Close();
            }
        }

        private void txtProdName_EditValueChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdName.Text))
                FillData();
            else
                FillData(
                    $" AND (IdProd LIKE N'%{txtProdName.Text}%' OR Prod LIKE N'%{txtProdName.Text}%' OR PartNumber LIKE N'%{txtProdName.Text}%')");
        }
    }
}
