using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FXShemForm : XtraForm
    {
        const string NameForReports = "FXShem";
        const string MasterId = "IdXShem";
        const string StrComm = "SELECT 1 Quantity, * FROM XShemView ";
        const string StrCommWithGroupBy = "SUM(Tanxa), 1 Quantity Tanxa FROM XShemView ";
        readonly string[] numericFieldList = {  "Tanxa", ".", "IdXShem", "UN", "CD" };

        public FXShemForm()
        {
            InitializeComponent();
        }

        void FXShemForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgXShem, ptXShem, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paXShem);
        }
    }
}