using System;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using SBS_Market.Classes;
using SBS_Market.InterfaceForms;

namespace SBS_Market.PrintForms
{
    public partial class prnCarmShedarebaForm : XtraForm
    {
        const string NameForReports = "prnCarmShedareba";

        public prnCarmShedarebaForm()
        {
            InitializeComponent();
        }

        void prnNashtiForm_Load(object sender, EventArgs e)
        {
            paFilter.ChangeFonts();
            pt.ChangeFonts();
            Text = GlobalParameters.FieldName;
            GridLayoutOperations.FillLayouts(cbLayoutPT, NameForReports, false);
        }

        void pt_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
//            DBClass.ptShowDetailedRecords(e, pt);
        }

        void pt_CustomDrawCell(object sender, PivotCustomDrawCellEventArgs e)
        {
            if (e.DataField == pcolMinGadaxra)
            {
                if (Convert.ToDouble(e.Value) < 0)
                    e.Appearance.ForeColor = Color.Red;
            }
            if (e.DataField == pcolMaxGadaxra)
            {
                if (Convert.ToDouble(e.Value) < 0)
                    e.Appearance.ForeColor = Color.Red;
            }

        }

        void btnFind_Click(object sender, ItemClickEventArgs e)
        {
            CLSProcedures.CLSSpAll proc = new CLSProcedures.CLSSpAll(paFilter, "spCarmShedareba");
            pt.DataSource = proc.Exceute();
        }

        void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            var clsExcel = new CLSExcel();
            clsExcel.ExportPTFull(pt,
                GlobalParameters.MonacemebiFolder + "pv" + NameForReports + PrintParameters.ReportNumber++ + ".xls");
        }

        void btnDGLayoutLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            var layout = cbLayoutPT.EditValue.ToString();
            GridLayoutOperations.RestoreLayout(pt, NameForReports, layout);
        }

        void btnDGLayoutSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new GridLayoutOperations(pt, NameForReports))
            {
                f.ShowDialog();
                GridLayoutOperations.FillLayouts(cbLayoutPT, NameForReports, false);
            }
        }

        void btnPTParameters_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var fm = new PivotTableSettingsForm(pt))
                fm.ShowDialog();
        }
    }
}