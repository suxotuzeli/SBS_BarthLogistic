using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FInvoices1Form : XtraForm
    {
        const string MasterId = "IdInvoices1";
        const string NameForReports = "FInvoices";
        const string StrComm = "SELECT *, 1 Quantity FROM InvoicesView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, SUM(Tanxa) Tanxa, 1 Quantity FROM InvoicesView ";
        readonly string[] numericFieldList =
        {
            "Raod", "Tanxa",".", "IdInvoices1", "IdGas2"
        };

        public FInvoices1Form()
        {
            InitializeComponent();
        }

        void FInvoices1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgInvoices1, ptInvoices1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paInvoices1);
        }
    }
}