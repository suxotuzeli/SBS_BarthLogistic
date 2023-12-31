using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FVaucherRealForm : XtraForm
    {
        const string NameForReports = "FVaucherReal";
        const string MasterId = "IdVaucherReal";
        const string StrComm = " SELECT *, 1 Quantity FROM VaucherRealView ";
        const string StrCommWithGroupBy = "SUM(Tanxa) Tanxa, SUM(VaucherTanxa) VaucherTanxa, 1 Quantity FROM VaucherRealView ";

        readonly string[] numericFieldList =
        {
             "Tanxa", "VaucherTanxa", ".", "IdVaucherReal"
        };

        public FVaucherRealForm()
        {
            InitializeComponent();
        }

        void FVaucherRealForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgVaucherReal, ptVaucherReal, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paVaucherReal);
        }
    }
}