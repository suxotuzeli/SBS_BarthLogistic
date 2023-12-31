using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FProekShek1Form : XtraForm
    {
        const string NameForReports = "FProekShek";
        const string MasterId = "IdProekShek1";
        const string StrComm = "SELECT *, 1 Quantity FROM ProekShekView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, SUM(Tanxa1) Tanxa1, SUM(TanxaTvitg) TanxaTvitg,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity FROM ProekShekView ";
        readonly string[] numericFieldList =
        {
            "Raod", "Tanxa1", "TanxaTvitg", "CompRaodTotal", ".", "IdProekShek1",
            "IdProekShek2"
        };

        public FProekShek1Form()
        {
            InitializeComponent();
        }

        void FProekShek1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgProekShek1, ptProekShek1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paProekShek1);
        }
    }
}