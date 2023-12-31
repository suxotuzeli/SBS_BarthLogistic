using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FAdgiliModz1Form : XtraForm
    {
        const string NameForReports = "FAdgiliModz";
        const string MasterId = "IdAdgiliModz1";
        const string StrComm = "SELECT *, 1 Quantity FROM AdgiliModzView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, 1 Quantity FROM AdgiliModzView ";
        readonly string[] numericFieldList =
        {
            "Raod", 
            "IdAdgiliModz2"
        };

        public FAdgiliModz1Form()
        {
            InitializeComponent();
        }

        void FAdgiliModz1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgAdgiliModz1, ptAdgiliModz1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paAdgiliModz1);
        }
    }
}