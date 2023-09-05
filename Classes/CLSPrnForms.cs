using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPivotGrid;
using SBS_BarthLogistic.InterfaceForms;

namespace SBS_BarthLogistic.Classes
{
    class CLSPrnForms
    {
        readonly BarManager bm;
        BarEditItem cbLayoutPt;
        readonly string nameForReports;
        readonly PanelControl panel;
        readonly PivotGridControl pt;

        public CLSPrnForms(PanelControl panel, string nameForReports)
        {
            this.panel = panel;
            pt = new PivotGridControl();
            bm = new BarManager();
            this.nameForReports = nameForReports;
        }

        public CLSPrnForms(PanelControl panel, string nameForReports, PivotGridControl pt, BarManager bm)
        {
            this.panel = panel;
            this.pt = pt;
            this.bm = bm;
            this.nameForReports = nameForReports;
        }

        public void Initialie()
        {
            pt.ChangeFonts();
            panel.ChangeFonts();

            var btnFind = bm.FindControlInForm("btnFind") as BarButtonItem;
            var btnPTLayoutLoad = bm.FindControlInForm("btnPTLayoutLoad") as BarButtonItem;
            var btnPTLayoutSave = bm.FindControlInForm("btnPTLayoutSave") as BarButtonItem;
            var btnPTParameters = bm.FindControlInForm("btnPTParameters") as BarButtonItem;
            cbLayoutPt = bm.FindControlInForm("cbLayoutPT") as BarEditItem;
            var btnPTExportToExcel = bm.FindControlInForm("btnPTExportToExcel") as BarButtonItem;

            btnPTLayoutLoad.ItemClick += btnPTLayoutLoad_ItemClick;
            btnPTLayoutSave.ItemClick += btnPTLayoutSave_ItemClick;
            btnPTParameters.ItemClick += btnPTParameters_ItemClick;

            cbLayoutPt.EditValueChanged += cbLayoutPT_EditValueChanged;

            btnFind.ItemShortcut = new BarShortcut((Keys.Control | Keys.F));
            btnPTExportToExcel.ItemShortcut = new BarShortcut((Keys.Control | Keys.X));

            btnPTExportToExcel.ItemClick += btnPTExportToExcel_ItemClick;
            FillLayouts(cbLayoutPt, false);
        }

        void btnPTExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(pt, nameForReports);
        }

        void FillLayouts(BarEditItem cbLayout, bool isDg)
        {
            var cb = (cbLayout.Edit as RepositoryItemComboBox);
            var layours = GridLayoutOperations.GetLayouts(nameForReports, isDg);
            cb.Items.Clear();
            foreach (DataRow row in layours.Rows)
            {
                cb.Items.Add(row["Name"]);
            }
        }

        void btnPTLayoutSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new GridLayoutOperations(pt, nameForReports))
            {
                f.ShowDialog();
                FillLayouts(cbLayoutPt, false);
            }
        }

        void btnPTLayoutLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            var layout = cbLayoutPt.EditValue.ToString();
            GridLayoutOperations.RestoreLayout(pt, nameForReports, layout);
        }

        void btnPTParameters_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var f = new PivotTableSettingsForm(pt))
            {
                f.ShowDialog();
            }
        }

        void cbLayoutPT_EditValueChanged(object sender, EventArgs e)
        {
            btnPTLayoutLoad_ItemClick(sender, null);
        }
    }
}