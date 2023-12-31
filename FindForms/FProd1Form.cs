using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FProd1Form : XtraForm
    {
        const string MasterId = "IdProd";
        const string NameForReports = "FProd";
        const string StrComm = "SELECT *, 1 Quantity FROM ProdView ";
        const string StrCommWithGroupBy = " 1 Quantity FROM ProdView ";

        readonly string[] numericFieldList =
        {
            "Raod", ".", "Fasi1", "Fasi2"
        };

        public FProd1Form()
        {
            InitializeComponent();
        }

        void FProd1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrid, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgProd, ptProd, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paProd);
        }
    }
}