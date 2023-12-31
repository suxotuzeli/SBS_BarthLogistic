using System;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;

namespace SBS_BarthLogistic.FindForms
{
    public partial class FShesXarjiForm : XtraForm
    {
        const string NameForReports = "FShesXarji";
        const string MasterId = "IdShes1";
        const string StrComm = "SELECT *, 1 Quantity FROM ShesXarjiView ";
        const string StrCommWithGroupBy = "SUM(Tanxa) Tanxa, SUM(TanxaLari) TanxaLari, 1 Quantity FROM ShesXarjiView ";
        readonly string[] numericFieldList = {  "XarjiTanxa", "XarjiTanxaLari", ".", "IdShes1", "UN", "CD" };

        public FShesXarjiForm()
        {
            InitializeComponent();
        }

        void FShesXarjiForm_Load(object sender, EventArgs e)
        {
            var clsFForm = new CLSFForms(tabGrids, chbList, lbList);
            clsFForm.InitializeStrings(MasterId, NameForReports, StrComm, StrCommWithGroupBy, numericFieldList);
            clsFForm.InitializeGrids(dgShesXarji, ptShesXarji, chart);
            clsFForm.InitializeBar(bmMasterAED, bmRecords, bmPivotGrid, bmChart);
            clsFForm.InitializePanel(paShesXarji);
        }
    }
}