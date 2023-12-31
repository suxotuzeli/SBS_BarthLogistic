using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FMDabr1Form : XtraForm
    {
        const string NameForReports = "FMDabr";
        const string MasterId = "IdMDabr1";
        const string StrComm = "SELECT *, 1 Quantity FROM MDabrView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, SUM(Tanxa) Tanxa, SUM(TanxaLari) TanxaLari, SUM(CompRaodTotal) CompRaodTotal, 1 Quantity " +
            "FROM MDabrView ";
        readonly string[] numericFieldList = { "Raod", "Tanxa", "TanxaLari", "CompRaodTotal", ".", "IdMDabr1" };

        public FMDabr1Form()
        {
            InitializeComponent();
        }

        void FMDabr1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgMDabr1, ptMDabr1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paMDabr1);
        }
    }
}