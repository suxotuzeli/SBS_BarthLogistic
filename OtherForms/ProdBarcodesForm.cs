using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.OtherForms
{
    public partial class ProdBarcodesForm : XtraForm
    {
        public ProdBarcodesForm()
        {
            InitializeComponent();
        }

        void ProdBarcodesForm_Load(object sender, EventArgs e)
        {
            LoadData();
            Activated += ProdBarcodesForm_Activated;
        }

        void LoadData()
        {
            dgProdBarCode.DataSource =
                SQL.Select("SELECT * FROM ProdBarCode INNER JOIN Prod ON Prod.IdProd = ProdBarCode.IdProd ");
        }

        void ProdBarcodesForm_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}