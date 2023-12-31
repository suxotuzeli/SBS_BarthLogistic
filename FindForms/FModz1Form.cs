using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FModz1Form : XtraForm
    {
        const string NameForReports = "FModz";
        const string MasterId = "IdModz1";
        const string StrComm = "SELECT *, 1 Quantity FROM ModzView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, SUM(Tanxa1) Tanxa1, SUM(TanxaTvitg) TanxaTvitg,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity FROM ModzView ";
        readonly string[] numericFieldList =
        {
            "Raod", "Tanxa1", "TanxaTvitg", "CompRaodTotal", ".", "IdModz1",
            "IdModz2"
        };

        public FModz1Form()
        {
            InitializeComponent();
        }

        void FModz1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgModz1, ptModz1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paModz1);
        }
    }
}