using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FQulaCvlilebaForm : XtraForm
    {
        const string NameForReports = "FQulaCvlileba";
        const string MasterId = "IdQulaCvlileba";
        const string StrComm = "SELECT *, 1 Quantity FROM QulaCvlilebaView ";
        const string StrCommWithGroupBy = "SUM(Qula) Qula, 1 Quantity FROM QulaCvlilebaView ";
        readonly string[] numericFieldList =
        {
            "Qula", ".", "IdQulaCvlileba"
        };

        public FQulaCvlilebaForm()
        {
            InitializeComponent();
        }

        void FQulaCvlilebaForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgQulaCvlileba, ptQulaCvlileba, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paQulaCvlileba);
        }
    }
}