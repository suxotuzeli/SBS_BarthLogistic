using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FDabr1Form : XtraForm
    {
        const string NameForReports = "FDabr";
        const string MasterId = "IdDabr1";
        const string StrComm = "SELECT *, 1 Quantity FROM DabrView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, SUM(Tanxa) Tanxa,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity " +
            "FROM DabrView ";
        readonly string[] numericFieldList =
        {
            "Raod", "Tanxa", "CompRaodTotal", ".", "IdDabr1"
        };

        public FDabr1Form()
        {
            InitializeComponent();
        }

        void FDabr1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgDabr1, ptDabr1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paDabr1);
        }
    }
}