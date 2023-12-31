using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FShesShek1Form : XtraForm
    {
        const string NameForReports = "FShesShek";
        const string MasterId = "IdShesShek1";
        const string StrComm = "SELECT *, 1 Quantity FROM ShesShekView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity FROM ShesShekView ";
        readonly string[] numericFieldList = { "Raod", "CompRaodTotal", ".", "IdShesShek1", "IdShesShek2" };

        public FShesShek1Form()
        {
            InitializeComponent();
        }

        void FShesShek1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgShesShek1, ptShesShek1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paShesShek1);
        }
    }
}