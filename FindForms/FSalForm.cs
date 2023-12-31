using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FSalForm : XtraForm
    {
        const string NameForReports = "FSal";
        const string MasterId = "IdSal";
        const string StrComm = " SELECT * FROM SalView ";
        const string StrCommWithGroupBy = "SUM(Tanxa) Tanxa FROM SalView ";

        readonly string[] numericFieldList =
        {
            "Tanxa", ".", "IdSal"
        };

        public FSalForm()
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