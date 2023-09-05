using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraTab;
using SBS_BarthLogistic.InterfaceForms;
using SBS_BarthLogistic.Properties;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;

namespace SBS_BarthLogistic.Classes
{
    /// <summary>
    ///     -- ვერსია 0.10 -- 24 Oct 2016 02:00 ნიკა
    ///     . პივოტის ექსპორტისას მიყვება ფილტრიც, გასაახლებელია ასევე CLSExcel-იც.
    ///     -- ვერსია 0.9 -- 10 Jun 2016 16:00 ნიკა
    ///     . დაჯგუფების სიას დავუმატე ღილაკი, მონიშნულის გაუქმება.
    ///     . დაჯგუფებისა სათაური და ტაბკონროლი ითარგმნება და ფონტიც ენიჭება
    ///     -- ვერსია 0.8 -- 6 Jun 2016 14:00 ნიკა
    ///     . Font ებზე შევცვალე რაღაცები
    ///     -- ვერსია 0.7 -- 16 Feb 2016 14:00 მერო
    ///     . Data ავტომატურად იჯდება ColumnAreaში და ენიჭება Caption
    ///     -- ვერსია 0.6 -- 25 Noe 2015 17:00 ნიკა
    ///     . რიდონლები გავასწორე და Linq ამოვიღე
    ///     -- ვერსია 0.5 -- 23 Oct 2015 14:00 ნიკა
    ///     . სქემის აღდგენისას როცა ჩამოსაშლელი მენიუ ცარიელი იყო, შეცდომა გამოჰქონდა
    ///     -- ვერსია 0.4 -- 18 Oct 2015 19:00 ნიკა
    ///     . ამოვარდა ცხრილის პატამეტრების ღილაკი
    ///     -- ვერსია 0.3 -- 9 Oct 2015 13:00 ნიკა
    /// </summary>
    internal class CLSFForms
    {
        readonly CheckedListBoxControl chbList;
        readonly ListBoxControl lbList;
        readonly XtraTabControl tab;
        BarEditItem cbDgExcel;
        BarEditItem cbLayoutDg;
        BarEditItem cbLayoutPa;
        BarEditItem cbLayoutPt;
        ChartControl chart;
        string[] chbFieldList;
        string checkedFieldNames;
        CLSChartOperation clsChart;
        CLSGridViewOperation clsGridViewOperation;
        bool cross;
        GridControl dg;
        DataTable dt;
        GridView gv;

        string masterId;
        string nameForReports;
        string[] numericFieldList;
        PanelControl panel;

        PanelLayoutOperations panelLayoutOperations;
        PivotGridControl pt;
        string strComm;
        string strCommWithGroupBy;
        bool total;

        public CLSFForms(XtraTabControl tab, CheckedListBoxControl chbList, ListBoxControl lbList)
        {
            this.tab = tab;
            this.chbList = chbList;
            this.lbList = lbList;
            lbList.DoubleClick += lbList_DoubleClick;
            chbList.Appearance.Font = GlobalParameters.Font;
            lbList.Appearance.Font = GlobalParameters.Font;
            tab.SetTexts();
            if (!(chbList.Parent is GroupControl)) return;
            ((GroupControl)chbList.Parent).Text = StringParameters.FFormGroupPanelText;
            ((GroupControl)chbList.Parent).AppearanceCaption.Font = GlobalParameters.Font;
            GroupBoxButton btnClear = new GroupBoxButton();
            btnClear.Caption = StringParameters.FFormGroupPanelClear;
            btnClear.UseCaption = false;
            btnClear.ToolTip = btnClear.Caption;
            btnClear.Image = Resources.Freeze_Column_Remove_All;
            ((GroupControl)chbList.Parent).CustomButtonClick += delegate
            {
                foreach (CheckedListBoxItem item in chbList.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
            };
            ((GroupControl)chbList.Parent).CustomHeaderButtonsLocation = GroupElementLocation.AfterText;
            ((GroupControl)chbList.Parent).CustomHeaderButtons.Add(btnClear);
        }

        void lbList_DoubleClick(object sender, EventArgs e)
        {
            if (lbList.SelectedItem == null) return;
            foreach (CheckedListBoxItem item in chbList.CheckedItems)
            {
                if (item.Value.ToString() != lbList.SelectedItem.ToString()) continue;
                item.InvertCheckState();
                return;
            }
        }

        void pt_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            using (PTRowsForm fmTemp = new PTRowsForm(e, pt))
                fmTemp.ShowDialog();
        }

        void dg_DoubleClick(object sender, EventArgs e)
        {
            if (masterId != null)
                GlobalParameters.FindID = gv.ReturnInt32(masterId);
        }

        void chbList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chbList.Items[e.Index].CheckState == CheckState.Checked)
                lbList.Items.Add(chbList.Items[e.Index]);
            else
                lbList.Items.Remove(chbList.Items[e.Index]);
        }

        string ReturnStrComm(string whereClause, string orderByClause)
        {
            return strComm + whereClause + orderByClause;
        }

        string ReturnStrCommWithGroupBy(string whereClause, string orderByClause, string groupByClause)
        {
            if (checkedFieldNames.Trim() != string.Empty)
                return "SELECT " + checkedFieldNames + "," + strCommWithGroupBy + whereClause + groupByClause +
                       orderByClause;
            return "SELECT " + checkedFieldNames + strCommWithGroupBy + whereClause + groupByClause + orderByClause;
        }

        string[] FillCheckBox()
        {
            string[] fieldList = new string[gv.Columns.Count];
            int j = 0;
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (IsStringValueInList(gv.Columns[i].FieldName, numericFieldList)) continue;
                chbList.Items.Add(new CheckedListBoxItem(gv.Columns[i].Caption, CheckState.Unchecked));
                fieldList[j] = gv.Columns[i].FieldName;
                j++;
            }
            return fieldList;
        }

        static bool IsStringValueInList(string s, string[] notIncludedFields)
        {
            foreach (string s1 in notIncludedFields)
                if (s1 == s) return true;
            return false;
        }

        public static string[] GetStringFileList(string filter, string gafartoeba)
        {
            string folder;
            switch (gafartoeba)
            {
                case "*.xml":
                    folder = GlobalParameters.XMLFolder;
                    break;
                default:
                    folder = GlobalParameters.ReportsFolder;
                    break;
            }
            return Directory.GetFiles(folder, filter + gafartoeba);
        }

        public void InitializeBar(BarManager bmMasterAed, BarManager bmRecords, BarManager bmPivotGrid,
            BarManager bmChart)
        {
            CLSCustomCnobari.SetTexts(bmMasterAed, bmRecords, bmPivotGrid, bmChart);
            cbLayoutDg = bmRecords.FindControlInForm("cbLayoutDG") as BarEditItem;
            cbLayoutDg = bmRecords.FindControlInForm("cbLayoutDG") as BarEditItem;
            cbLayoutPt = bmPivotGrid.FindControlInForm("cbLayoutPT") as BarEditItem;
            //Panel
            cbLayoutPa = bmMasterAed.FindControlInForm("cbLayoutPA") as BarEditItem;
            BarButtonItem btnPaLayoutSave = bmMasterAed.FindControlInForm("btnPALayoutSave") as BarButtonItem;
            BarButtonItem btnPaLayoutLoad = bmMasterAed.FindControlInForm("btnPALayoutLoad") as BarButtonItem;

            BarButtonItem btnDgLayoutLoad = bmRecords.FindControlInForm("btnDGLayoutLoad") as BarButtonItem;
            BarButtonItem btnPtLayoutLoad = bmPivotGrid.FindControlInForm("btnPTLayoutLoad") as BarButtonItem;
            BarButtonItem btnDgLayoutSave = bmRecords.FindControlInForm("btnDGLayoutSave") as BarButtonItem;
            BarButtonItem btnPtLayoutSave = bmPivotGrid.FindControlInForm("btnPTLayoutSave") as BarButtonItem;

            BarButtonItem btnSearch = bmMasterAed.FindControlInForm("btnSearch") as BarButtonItem;
            BarCheckItem btsHidePanel = bmMasterAed.FindControlInForm("btsHidePanel") as BarCheckItem;
            BarCheckItem btsTotal = bmMasterAed.FindControlInForm("btsTotal") as BarCheckItem;

            cbDgExcel = bmRecords.FindControlInForm("cbDGExcel") as BarEditItem;

            BarButtonItem btnPtParameters = bmPivotGrid.FindControlInForm("btnPTParameters") as BarButtonItem;

            BarButtonItem btnDgExportToExcel = bmRecords.FindControlInForm("btnDGExportToExcel") as BarButtonItem;
            BarButtonItem btnPtExportToExcel = bmPivotGrid.FindControlInForm("btnPTExportToExcel") as BarButtonItem;
            BarButtonItem btnChExportToExcel = bmChart.FindControlInForm("btnCHExportToExcel") as BarButtonItem;
            BarButtonItem btnPopExportToExcel = bmRecords.FindControlInForm("btnPopExportToExcel") as BarButtonItem;
            BarButtonItem btnPopExportToExcelFull = bmRecords.FindControlInForm("btnPopExportToExcelFull") as BarButtonItem;

            BarButtonItem btnDgPrint = bmRecords.FindControlInForm("btnDGPrint") as BarButtonItem;

            BarEditItem cbChartOrientation = bmChart.FindControlInForm("cbChartOrientation") as BarEditItem;
            BarEditItem cbChartType = bmChart.FindControlInForm("cbChartType") as BarEditItem;
            BarCheckItem bstShowValues = bmChart.FindControlInForm("bstShowValues") as BarCheckItem;

            btnSearch.ItemClick += Search;
            btsHidePanel.CheckedChanged += Hide_Panel;
            btsTotal.CheckedChanged += Total_Changed;

            btnDgLayoutLoad.ItemClick += btnDGLayoutLoad_ItemClick;
            btnDgLayoutSave.ItemClick += btnDGLayoutSave_ItemClick;
            btnPtLayoutLoad.ItemClick += btnPTLayoutLoad_ItemClick;
            btnPtLayoutSave.ItemClick += btnPTLayoutSave_ItemClick;
            btnPaLayoutSave.ItemClick += btnPALayoutSave_ItemClick;
            btnPaLayoutLoad.ItemClick += btnPALayoutLoad_ItemClick;

            if (btnPopExportToExcel != null)
                btnPopExportToExcel.ItemClick += btnPopExportToExcel_ItemClick;
            if (btnPopExportToExcelFull != null)
                btnPopExportToExcelFull.ItemClick += btnPopExportToExcelFull_ItemClick;

            cbLayoutPt.EditValueChanged += cbLayoutPT_EditValueChanged;
            cbLayoutDg.EditValueChanged += cbLayoutDG_EditValueChanged;

            btnPtParameters.ItemClick += btnPTParameters_ItemClick;

            btnDgExportToExcel.ItemClick += btnDGExportToExcel_ItemClick;
            btnPtExportToExcel.ItemClick += btnPTExportToExcel_ItemClick;
            btnChExportToExcel.ItemClick += btnCHExportToExcel_ItemClick;
            btnDgPrint.ItemClick += btnDGPrint_ItemClick;

            btnSearch.ItemShortcut = new BarShortcut(Keys.Control | Keys.F);

            FillExcel(cbDgExcel);
            FillLayouts(cbLayoutDg, true);
            FillLayouts(cbLayoutPt, false);
            FillPanelLayouts(cbLayoutPa);
            clsChart = new CLSChartOperation(pt, chart, cbChartOrientation, cbChartType, bstShowValues);
            clsChart.InitializeChart();
            clsGridViewOperation = new CLSGridViewOperation(dg.MainView as GridView, numericFieldList);
        }

        void btnPopExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dg.DataSource == null) return;
            if (cbDgExcel.EditValue == null)
                CLSExcel.ExportToExcel(dg, nameForReports);
            else
            {
                CLSExcel excel = new CLSExcel(dg.DataSource as DataTable, cbDgExcel.EditValue.ToString());
                excel.InitializePanelParams(panel);
                excel.Export();
            }
        }

        void btnPopExportToExcelFull_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dg.DataSource == null) return;
            CLSExcel.ExportToExcel(dg, nameForReports);
        }

        public void InitializePanel(PanelControl argPanel)
        {
            panel = argPanel;
            panel.ChangeFonts();
            panel.SetFFormText(panel.Name.Substring(2));
            CLSGraphicalElements.Hide();
        }

        public void InitializeStrings(string argmasterId, string argNameForReports, string argStrComm,
            string argStrCommWithGroupBy,
            string[] argNumericFieldList)
        {
            masterId = argmasterId;
            nameForReports = argNameForReports;
            strComm = argStrComm;
            strCommWithGroupBy = argStrCommWithGroupBy;
            numericFieldList = argNumericFieldList;
        }

        public void InitializeGrids(GridControl argDg, PivotGridControl argPt, ChartControl chartControl1)
        {
            dg = argDg;
            pt = argPt;
            chart = chartControl1;
            gv = argDg.MainView as GridView;
            gv.ChangeFonts();
            pt.ChangeFonts();
            chbFieldList = FillCheckBox();

            chbList.ItemCheck += chbList_ItemCheck;
            gv.DoubleClick += dg_DoubleClick;
            pt.CellDoubleClick += pt_CellDoubleClick;
            tab.SelectedPageChanged += Tab_SelectedPageChanged;
        }

        void btnDGPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gv.OptionsPrint.AutoWidth = false;
            gv.OptionsPrint.AllowMultilineHeaders = true;
            gv.OptionsPrint.AllowCancelPrintExport = false;
            gv.OptionsPrint.UsePrintStyles = false;
            dg.ShowPrintPreview();
        }

        void btnDGExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dg.DataSource == null) return;
            if (cbDgExcel.EditValue == null)
                CLSExcel.ExportToExcel(dg, nameForReports);
            else
            {
                CLSExcel excel = new CLSExcel(dg.DataSource as DataTable, cbDgExcel.EditValue.ToString());
                excel.InitializePanelParams(panel);
                excel.Export();
            }
        }

        void btnPTExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            CLSExcel.ExportToExcel(pt, nameForReports, panel);
        }

        void btnPTParameters_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (PivotTableSettingsForm f = new PivotTableSettingsForm(pt))
            {
                f.ShowDialog();
            }
        }

        void btnCHExportToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fileName = GlobalParameters.ReportsFolder + "CH_" + nameForReports + ".xls";
            if (PrintParameters.UseExcel2007)
                fileName = GlobalParameters.ReportsFolder + "CH_" + nameForReports + ".xlsx";

            chart.ExportToXls(fileName);
            Process.Start(fileName);
        }

        void cbLayoutDG_EditValueChanged(object sender, EventArgs e)
        {
            if (GlobalParameters.FindFormsRestoreDgSettings)
                btnDGLayoutLoad_ItemClick(sender, null);
        }

        void cbLayoutPT_EditValueChanged(object sender, EventArgs e)
        {
            if (GlobalParameters.FindFormsRestoreDgSettings)
                btnPTLayoutLoad_ItemClick(sender, null);
        }

        void btnPTLayoutSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (GridLayoutOperations f = new GridLayoutOperations(pt, nameForReports))
            {
                f.ShowDialog();
                FillLayouts(cbLayoutPt, false);
            }
        }

        void btnPTLayoutLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cbLayoutPt.EditValue == null) return;
            string layout = cbLayoutPt.EditValue.ToString();
            GridLayoutOperations.RestoreLayout(pt, nameForReports, layout);
        }

        void btnDGLayoutSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (GridLayoutOperations f = new GridLayoutOperations(dg, nameForReports))
            {
                f.ShowDialog();
                FillLayouts(cbLayoutDg, true);
            }
        }

        void btnDGLayoutLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cbLayoutDg.EditValue == null) return;
            string layout = cbLayoutDg.EditValue.ToString();
            GridLayoutOperations.RestoreLayout(dg, nameForReports, layout);
        }

        void btnPALayoutSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (panelLayoutOperations == null)
                panelLayoutOperations = new PanelLayoutOperations(panel, chbList, nameForReports);
            panelLayoutOperations.ShowDialog();
            FillPanelLayouts(cbLayoutPa);
        }

        void btnPALayoutLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cbLayoutPa.EditValue == null) return;
            string layout = cbLayoutPa.EditValue.ToString();
            PanelLayoutOperations.RestorePanel(panel, chbList, nameForReports, layout);
        }

        void Total_Changed(object sender, ItemClickEventArgs e)
        {
            total = (sender as BarCheckItem).Checked;
        }

        void Tab_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (tab.SelectedTabPageIndex != 1) return;
            if (pt.DataSource == null)
                pt.DataSource = dg.DataSource;
            cross = true;
        }

        void Hide_Panel(object sender, ItemClickEventArgs e)
        {
            panel.Visible = !(e.Item as BarCheckItem).Checked;
        }

        string ReturnCondition(string start)
        {
            return checkedFieldNames.Trim() == string.Empty ? string.Empty : start + checkedFieldNames;
        }

        void Search(object sender, ItemClickEventArgs e)
        {
            CLSGraphicalElements.Show();
            gv = clsGridViewOperation.ShowOtherCols(true);
            StringBuilder s = new StringBuilder("WHERE (1 = 1)");
            panel.SetWhereClause(s);
            checkedFieldNames = SQLOperation.ReturnOrderByCondition(lbList, chbFieldList, chbList);
            if (total)
            {
                if (chbList.CheckedItems.Count < 1)
                {
                    XtraMessageBox.Show(StringParameters.NoGroupBy);
                    dg.DataSource = pt.DataSource = dt = null;
                    return;
                }
                dt =
                    SQL.Select(ReturnStrCommWithGroupBy(s.ToString(), ReturnCondition(" ORDER BY "),
                        ReturnCondition(" GROUP BY ")));
                gv = clsGridViewOperation.ShowOtherCols(false);
                gv = clsGridViewOperation.SetVisibleColumnsViaGroupByClause(checkedFieldNames);
            }
            else
                dt = SQL.Select(ReturnStrComm(s.ToString(), ReturnCondition(" ORDER BY ")));
            dg.DataSource = dt;
            if (cross)
                pt.DataSource = dt;
            CLSGraphicalElements.Hide();
        }

        void FillExcel(BarEditItem argCbDgExcel)
        {
            RepositoryItemComboBox cb = argCbDgExcel.Edit as RepositoryItemComboBox;
            string[] s = GetStringFileList(nameForReports, "*.xls");
            cb.Items.Clear();
            foreach (string item in s)
            {
                string s1 = item.Substring(item.LastIndexOf("\\") + 1, item.Length - item.LastIndexOf("\\") - 1);
                s1 = s1.Substring(0, s1.Length - 4);
                cb.Items.Add(s1);
            }
            if (s.Length > 0)
            {
                argCbDgExcel.EditValue = cb.Items[0];
            }
        }

        void FillLayouts(BarEditItem cbLayout, bool isDg)
        {
            RepositoryItemComboBox cb = cbLayout.Edit as RepositoryItemComboBox;
            DataTable layours = GridLayoutOperations.GetLayouts(nameForReports, isDg);
            cb.Items.Clear();
            foreach (DataRow row in layours.Rows)
                cb.Items.Add(row["Name"]);
            if (cb.Items.Count > 0)
            {
                cbLayout.EditValue = cb.Items[0];
            }
        }

        void FillPanelLayouts(BarEditItem cbLayout)
        {
            if (cbLayout == null) return;
            RepositoryItemComboBox cb = cbLayout.Edit as RepositoryItemComboBox;
            DataTable layours = PanelLayoutOperations.GetLayouts(nameForReports);
            cb.Items.Clear();
            foreach (DataRow row in layours.Rows)
                cb.Items.Add(row["Name"]);
            if (cb.Items.Count > 0)
            {
                cbLayout.EditValue = cb.Items[0];
            }
        }
    }
}