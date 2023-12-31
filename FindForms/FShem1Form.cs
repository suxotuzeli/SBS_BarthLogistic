using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FShem1Form : XtraForm
    {
        const string NameForReports = "FShem";
        const string MasterId = "IdShem1";
        const string StrComm = "SELECT *, 1 Quantity FROM ShemView ";
        const string StrCommWithGroupBy = "SUM(Raod) Raod FROM ShemView ";
        readonly string[] numericFieldList = { "Raod", ".", "IdShem1", "IdShem2" };

        public FShem1Form()
        {
            InitializeComponent();
        }

        void FShem1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgShem1, ptShem1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paShem1);
        }
    }
}