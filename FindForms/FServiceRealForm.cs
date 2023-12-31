using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FServiceRealForm : XtraForm
    {
        public const string NameForReports = "FServiceReal";
        public const string MasterId = "IdServiceReal";
        public const string StrComm = " SELECT *, 1 Quantity FROM ServiceRealView ";
        public const string StrCommWithGroupBy = "SUM(Tanxa) Tanxa, 1 Quantity FROM ServiceRealView ";

        readonly string[] numericFieldList =
        {
            "Tanxa", ".", "IdSal"
        };

        public FServiceRealForm()
        {
            InitializeComponent();
        }

        void FSalForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgSal, ptSal, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paSal);
        }
    }
}