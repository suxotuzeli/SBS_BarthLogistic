using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FAgcera1Form : XtraForm
    {
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity FROM AgceraView ";
        const string MasterId = "IdAgcera1";
        const string NameForReports = "FAgcera";
        const string StrComm = "SELECT *, 1 Quantity FROM AgceraView ";
        readonly string[] numericFieldList = { "Raod", "CompRaodTotal", ".", "IdAgcera1", "IdAgcera2" };

        public FAgcera1Form()
        {
            InitializeComponent();
        }

        void FAgcera1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgAgcera1, ptAgcera1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paAgcera1);
        }
    }
}