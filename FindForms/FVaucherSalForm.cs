using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FVaucherSalForm : XtraForm
    {
        const string NameForReports = "FVaucherSal";
        const string MasterId = "IdVaucherSal";
        const string StrComm = " SELECT *, 1 Quantity FROM VaucherSalView ";
        const string StrCommWithGroupBy = "SUM(Tanxa) Tanxa, 1 Quantity FROM VaucherSalView ";
        readonly string[] numericFieldList = { "Tanxa", ".", "IdVaucherSal" };

        public FVaucherSalForm()
        {
            InitializeComponent();
        }

        void FVaucherSalForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgVaucherSal, ptVaucherSal, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paVaucherSal);
        }
    }
}