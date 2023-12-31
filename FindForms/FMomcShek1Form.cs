using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FMomcShek1Form : XtraForm
    {
        const string NameForReports = "FMomcShek";
        const string MasterId = "IdMomcShek1";
        const string StrComm = "SELECT *, 1 Quantity FROM MomcShekView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity FROM MomcShekView ";
        readonly string[] numericFieldList = { "Raod", "CompRaodTotal", ".", "IdMomcShek1", "IdMomcShek2" };

        public FMomcShek1Form()
        {
            InitializeComponent();
        }

        void FMomcShek1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgMomcShek1, ptMomcShek1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paMomcShek1);
        }
    }
}