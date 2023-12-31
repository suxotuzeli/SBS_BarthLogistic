using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FGadadeba1Form : XtraForm
    {
        private const string NameForReports = "FGadadeba";
        private const string MasterId = "IdGadadeba1";
        private const string StrComm = "SELECT *, 1 Quantity FROM GadadebaView ";
        private const string StrCommWithGroupBy = "SUM(Raod) Raod, SUM(Tanxa) Tanxa,  SUM(CompRaodTotal) CompRaodTotal, SUM(StandardTanxa) StandardTanxa, SUM(StandardDiscount) StandardDiscount, 1 Quantity FROM GadadebaView ";
        private readonly string[] numericFieldList = { "Raod", "Tanxa", "CompRaodTotal", "StandardTanxa", "StandardDiscount", ".", "IdGadadeba1", "IdGadadeba2" };
        public FGadadeba1Form()
        {
            InitializeComponent();
        }

        void FGadadeba1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgGadadeba1, ptGadadeba1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paGadadeba1);
        }
    }
}