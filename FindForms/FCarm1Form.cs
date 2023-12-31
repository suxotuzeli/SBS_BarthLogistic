using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FCarm1Form : XtraForm
    {
        const string NameForReports = "FCarm";
        const string MasterId = "IdCarm1";
        const string StrComm = "SELECT *, 1 Quantity FROM CarmView ";
        const string StrCommWithGroupBy = "SUM(CompRaodTotal) CompRaodTotal, SUM(Raod) Raod, 1 Quantity FROM CarmView ";
        readonly string[] numericFieldList = { "Raod", "CompRaodTotal", ".", "IdCarm1", "IdCarm2" };

        public FCarm1Form()
        {
            InitializeComponent();
        }

        void FCarm1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgCarm1, ptCarm1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paCarm1);
        }
    }
}