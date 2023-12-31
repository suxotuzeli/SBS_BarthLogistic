using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FXGasForm : XtraForm
    {
        const string NameForReports = "FXGas";
        const string MasterId = "IdXGas";
        const string StrComm = "SELECT 1 Quantity, * FROM XGasView ";
        const string StrCommWithGroupBy = "SUM(Tanxa), 1 Quantity Tanxa FROM XGasView ";
        readonly string[] numericFieldList = {  "Tanxa", ".", "IdXGas", "UN", "CD" };

        public FXGasForm()
        {
            InitializeComponent();
        }

        void FXGasForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgXGas, ptXGas, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paXGas);
        }
    }
}