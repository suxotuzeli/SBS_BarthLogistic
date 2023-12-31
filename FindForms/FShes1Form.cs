using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FShes1Form : XtraForm
    {
        const string NameForReports = "FShes";
        const string MasterId = "IdShes1";
        const string StrComm = "SELECT *, 1 Quantity FROM ShesView ";
        const string StrCommWithGroupBy =
            "SUM(Raod) Raod, SUM(Tanxa) Tanxa, SUM(TanxaTvitg) TanxaTvitg, SUM(Tanxa1) Tanxa1,  SUM(CompRaodTotal) CompRaodTotal, 1 Quantity  FROM ShesView ";

        readonly string[] numericFieldList =
        {
             "Raod", "Tanxa", "TanxaTvitg", "Tanxa1", "CompRaodTotal", ".", "IdShes1", "IdShes2"
        };

        public FShes1Form()
        {
            InitializeComponent();
        }

        void FShes1Form_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgShes1, ptShes1, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paShes1);
        }
    }
}