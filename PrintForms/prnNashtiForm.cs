using System;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SBS_BarthLogistic.Classes;
using SBS_BarthLogistic.InterfaceForms;

namespace SBS_BarthLogistic.PrintForms
{
    public partial class prnNashtiForm : XtraForm
    {
        const string NameForReports = "prnNashti";

        public prnNashtiForm()
        {
            InitializeComponent();
        }

        void prnNashtiForm_Load(object sender, EventArgs e)
        {
            Text = GlobalParameters.FieldName;
            paNashti.ChangeFonts();
            ptNashti.ChangeFonts();
            GridLayoutOperations.FillLayouts(cbLayoutPT, NameForReports, false);
        }


        void btnFind_Click(object sender, ItemClickEventArgs e)
        {
            CLSSpAll proc = new CLSSpAll(paNashti, "spNashti");
            ptNashti.DataSource = proc.Exceute();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clsExcel = new CLSExcel();
//            clsExcel.ExportPtFull(ptNashti,GlobalParameters.MonacemebiFolder + "pv" + NameForReports + PrintParameters.ReportNumber++ + ".xls");
            CLSExcel.ExportToExcel(ptNashti,NameForReports, paNashti);
        }

        void btnDGLayoutLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            var layout = cbLayoutPT.EditValue.ToString();
            GridLayoutOperations.RestoreLayout(ptNashti, NameForReports, layout);
            Text = GlobalParameters.FieldName;
        }

        void btnDGLayoutSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new GridLayoutOperations(ptNashti, NameForReports))
            {
                f.ShowDialog();
                GridLayoutOperations.FillLayouts(cbLayoutPT, NameForReports, false);
            }
        }

        void btnPTParameters_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var fm = new PivotTableSettingsForm(ptNashti))
                fm.ShowDialog();
        }
    }
}