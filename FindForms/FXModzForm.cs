using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FXModzForm : XtraForm
    {
        const string NameForReports = "FXModz";
        const string MasterId = "IdXModz";
        const string StrComm = "SELECT 1 Quantity, * FROM XModzView ";
        const string StrCommWithGroupBy = "SUM(Tanxa), 1 Quantity Tanxa FROM XModzView ";
        readonly string[] numericFieldList = {  "Tanxa", ".", "IdXModz", "UN", "CD" };

        public FXModzForm()
        {
            InitializeComponent();
        }

        void FXModzForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgXModz, ptXModz, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paXModz);
        }
    }
}