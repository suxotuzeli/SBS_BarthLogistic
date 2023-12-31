using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FGas1Form : XtraForm
    {
        const string MasterId = "IdGas1";
        const string NameForReports = "FGas";
        const string StrComm = "SELECT *, 1 Quantity FROM GasView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod FROM GasView ";
        readonly string[] numericFieldList =
        {
            "Raod", ".", "IdGas1", "IdGas2"
        };

        public FGas1Form()
        {
            InitializeComponent();
        }

        void FGas1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgGas1, ptGas1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paGas1);
        }
    }
}