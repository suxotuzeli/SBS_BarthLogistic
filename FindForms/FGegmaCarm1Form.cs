using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FGegmaCarm1Form : XtraForm
    {
        const string MasterId = "IdGegmaCarm1";
        const string NameForReports = "FGegmaCarm";
        const string StrComm = "SELECT *, 1 Quantity FROM GegmaCarmView ";
        const string StrCommWithGroupBy = "SUM(Raod) Raod,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity FROM GegmaCarmView ";

        readonly string[] numericFieldList =
        {
            "Raod", "CompRaodTotal", ".", "IdGegmaCarm1", "IdGegmaCarm2"
        };

        public FGegmaCarm1Form()
        {
            InitializeComponent();
        }

        void FGegmaCarm1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgGegmaCarm1, ptGegmaCarm1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paGegmaCarm1);
        }
    }
}