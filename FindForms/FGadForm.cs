using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FGadForm : XtraForm
    {
        const string NameForReports = "FGad";
        const string MasterId = "IdGad";
        const string StrComm = "SELECT *, 1 Quantity FROM GadView ";
        const string StrCommWithGroupBy = "SUM(Tanxa) Tanxa, SUM(TanxaLari) TanxaLari, 1 Quantity FROM GadView ";
        readonly string[] numericFieldList = { "Tanxa", "TanxaLari", ".", "IdGad", "UN", "CD" };

        public FGadForm()
        {
            InitializeComponent();
        }

        void FGadForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgGad, ptGad, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paGad);
        }
    }
}