using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FReal1Form : XtraForm
    {
        const string NameForReports = "FReal";
        const string MasterId = "IdReal1";
        const string StrComm = "SELECT *, 1 Quantity FROM RealView ";

        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, SUM(Tanxa) Tanxa, SUM(TevadobaTotal) TevadobaTotal, SUM(TanxaTvitg) TanxaTvitg, SUM(CompRaodTotal) CompRaodTotal, SUM(StandardTanxa) StandardTanxa, SUM(StandardDiscount) StandardDiscount, 1 Quantity " +
            "FROM RealView ";

        readonly string[] numericFieldList =
        {
            "Raod", "Tanxa", "TevadobaTotal", "TanxaTvitg", "CompRaodTotal", "StandardTanxa", "StandardDiscount",  ".", "IdReal1",
            "IdReal2", "Active"
        };

        public FReal1Form()
        {
            InitializeComponent();
        }

        void FReal1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgReal1, ptReal1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paReal1);
        }
    }
}