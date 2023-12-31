using SBS_BarthLogistic.Controls;

namespace SBS_BarthLogistic.FindForms
{
    partial class FGas1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paGas1 = new DevExpress.XtraEditors.PanelControl();
            this.gbTotal = new DevExpress.XtraEditors.GroupControl();
            this.chbList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lbList = new DevExpress.XtraEditors.ListBoxControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.fmgGasT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.tabGrids = new DevExpress.XtraTab.XtraTabControl();
            this.tpDG = new DevExpress.XtraTab.XtraTabPage();
            this.dgGas1 = new DevExpress.XtraGrid.GridControl();
            this.gvGas1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.tpPT = new DevExpress.XtraTab.XtraTabPage();
            this.ptGas1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pcolYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfWeek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolWeekOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.barDockControl19 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl20 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl18 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl17 = new DevExpress.XtraBars.BarDockControl();
            this.tpChart = new DevExpress.XtraTab.XtraTabPage();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.barDockControl23 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl24 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl22 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl21 = new DevExpress.XtraBars.BarDockControl();
            this.bmMasterAED = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSearch = new DevExpress.XtraBars.BarButtonItem();
            this.btsHidePanel = new DevExpress.XtraBars.BarCheckItem();
            this.btsTotal = new DevExpress.XtraBars.BarCheckItem();
            this.cbLayoutPA = new DevExpress.XtraBars.BarEditItem();
            this.rcbLayoutPA = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnPALayoutLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnPALayoutSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bmRecords = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.cbLayoutDG = new DevExpress.XtraBars.BarEditItem();
            this.rcbLayoutDG = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnDGLayoutLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnDGLayoutSave = new DevExpress.XtraBars.BarButtonItem();
            this.cbDGExcel = new DevExpress.XtraBars.BarEditItem();
            this.rcbDGExcel = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnDGExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnDGPrint = new DevExpress.XtraBars.BarButtonItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bmPivotGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.cbLayoutPT = new DevExpress.XtraBars.BarEditItem();
            this.rcbLayoutPT = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnPTLayoutLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTLayoutSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTParameters = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bmChart = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.cbChartOrientation = new DevExpress.XtraBars.BarEditItem();
            this.rcbChartOrientation = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbChartType = new DevExpress.XtraBars.BarEditItem();
            this.rcbChartType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnCHExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bstShowValues = new DevExpress.XtraBars.BarCheckItem();
            this.fmgProekSectorZone = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.fmgProekSector = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProek = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProekT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgIdProd = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.fmgZedd = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.colIdGas1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGas2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGasT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSagad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrgT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSectorZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcolData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolShen = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolIdProd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolRaod = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolGasT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProekT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrg = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolSagad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolAddress = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolEmail = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDirek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolContact = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrgT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProekSectorZone = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProekSector = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField12 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField13 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField14 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField15 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField16 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.paGas1)).BeginInit();
            this.paGas1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTotal)).BeginInit();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabGrids)).BeginInit();
            this.tabGrids.SuspendLayout();
            this.tpDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGas1)).BeginInit();
            this.tpPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptGas1)).BeginInit();
            this.tpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbDGExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmPivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartType)).BeginInit();
            this.SuspendLayout();
            // 
            // paGas1
            // 
            this.paGas1.Controls.Add(this.fmgIdProd);
            this.paGas1.Controls.Add(this.fmgZedd);
            this.paGas1.Controls.Add(this.fmgProekSectorZone);
            this.paGas1.Controls.Add(this.fmgProekSector);
            this.paGas1.Controls.Add(this.fmgProek);
            this.paGas1.Controls.Add(this.fmgProekT);
            this.paGas1.Controls.Add(this.gbTotal);
            this.paGas1.Controls.Add(this.fmgData);
            this.paGas1.Controls.Add(this.fmgGasT);
            this.paGas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paGas1.Location = new System.Drawing.Point(0, 40);
            this.paGas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paGas1.Name = "paGas1";
            this.paGas1.Size = new System.Drawing.Size(1234, 142);
            this.paGas1.TabIndex = 0;
            // 
            // gbTotal
            // 
            this.gbTotal.AppearanceCaption.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.AppearanceCaption.Options.UseFont = true;
            this.gbTotal.Controls.Add(this.chbList);
            this.gbTotal.Controls.Add(this.lbList);
            this.gbTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTotal.Location = new System.Drawing.Point(942, 2);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(290, 138);
            this.gbTotal.TabIndex = 77;
            this.gbTotal.Text = "დაჯგუფების პარამეტრები";
            // 
            // chbList
            // 
            this.chbList.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbList.Appearance.Options.UseFont = true;
            this.chbList.CheckOnClick = true;
            this.chbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbList.Location = new System.Drawing.Point(2, 26);
            this.chbList.Name = "chbList";
            this.chbList.Size = new System.Drawing.Size(286, 41);
            this.chbList.TabIndex = 0;
            // 
            // lbList
            // 
            this.lbList.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Appearance.Options.UseFont = true;
            this.lbList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbList.Location = new System.Drawing.Point(2, 67);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(286, 69);
            this.lbList.TabIndex = 1;
            // 
            // fmgData
            // 
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.AutoSize = true;
            this.fmgData.FieldName = "Data";
            this.fmgData.Location = new System.Drawing.Point(10, 6);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgData.MinimumSize = new System.Drawing.Size(330, 20);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = null;
            this.fmgData.Size = new System.Drawing.Size(449, 24);
            this.fmgData.TabIndex = 0;
            this.fmgData.Text = "თარიღი";
            // 
            // fmgGasT
            // 
            this.fmgGasT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgGasT.Appearance.Options.UseFont = true;
            this.fmgGasT.FieldName = "GasT";
            this.fmgGasT.Location = new System.Drawing.Point(10, 30);
            this.fmgGasT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgGasT.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgGasT.Name = "fmgGasT";
            this.fmgGasT.ParameterName = null;
            this.fmgGasT.Size = new System.Drawing.Size(449, 24);
            this.fmgGasT.TabIndex = 1;
            this.fmgGasT.Text = "გასავლის ტიპი";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabGrids);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 369);
            this.panel2.TabIndex = 8;
            // 
            // tabGrids
            // 
            this.tabGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGrids.Location = new System.Drawing.Point(2, 2);
            this.tabGrids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGrids.Name = "tabGrids";
            this.tabGrids.SelectedTabPage = this.tpDG;
            this.tabGrids.Size = new System.Drawing.Size(1230, 365);
            this.tabGrids.TabIndex = 2;
            this.tabGrids.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpDG,
            this.tpPT,
            this.tpChart});
            // 
            // tpDG
            // 
            this.tpDG.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.tpDG.Appearance.Header.Options.UseFont = true;
            this.tpDG.Appearance.HeaderActive.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.tpDG.Appearance.HeaderActive.Options.UseFont = true;
            this.tpDG.Controls.Add(this.dgGas1);
            this.tpDG.Controls.Add(this.barDockControl3);
            this.tpDG.Controls.Add(this.barDockControl4);
            this.tpDG.Controls.Add(this.barDockControl2);
            this.tpDG.Controls.Add(this.barDockControl1);
            this.tpDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDG.Name = "tpDG";
            this.tpDG.Size = new System.Drawing.Size(1227, 339);
            this.tpDG.Text = "ჩანაწერები";
            // 
            // dgGas1
            // 
            this.dgGas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGas1.Location = new System.Drawing.Point(0, 40);
            this.dgGas1.MainView = this.gvGas1;
            this.dgGas1.Name = "dgGas1";
            this.dgGas1.Size = new System.Drawing.Size(1227, 299);
            this.dgGas1.TabIndex = 58;
            this.dgGas1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGas1});
            // 
            // gvGas1
            // 
            this.gvGas1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvGas1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvGas1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGas1,
            this.colIdGas2,
            this.colData,
            this.colShen,
            this.colIdProd,
            this.colRaod,
            this.colGasT,
            this.colUN,
            this.colCD,
            this.colCD1,
            this.colProek,
            this.colProekT,
            this.colOrg,
            this.colSagad,
            this.colAddress,
            this.colEmail,
            this.colDirek,
            this.colContact,
            this.colOrgT,
            this.colProekSectorZone,
            this.colProekSector});
            this.gvGas1.DetailHeight = 284;
            this.gvGas1.FooterPanelHeight = 1;
            this.gvGas1.GridControl = this.dgGas1;
            this.gvGas1.GroupPanelText = "დაჯგუფება";
            this.gvGas1.GroupRowHeight = 1;
            this.gvGas1.Name = "gvGas1";
            this.gvGas1.OptionsBehavior.Editable = false;
            this.gvGas1.OptionsDetail.AllowZoomDetail = false;
            this.gvGas1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvGas1.OptionsView.ColumnAutoWidth = false;
            this.gvGas1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvGas1.OptionsView.ShowAutoFilterRow = true;
            this.gvGas1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvGas1.OptionsView.ShowDetailButtons = false;
            this.gvGas1.OptionsView.ShowFooter = true;
            this.gvGas1.OptionsView.ShowGroupedColumns = true;
            this.gvGas1.OptionsView.ShowGroupPanel = false;
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Manager = this.bmRecords;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 299);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1227, 40);
            this.barDockControl4.Manager = this.bmRecords;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 299);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 339);
            this.barDockControl2.Manager = this.bmRecords;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(1227, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.bmRecords;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1227, 40);
            // 
            // tpPT
            // 
            this.tpPT.Controls.Add(this.ptGas1);
            this.tpPT.Controls.Add(this.barDockControl19);
            this.tpPT.Controls.Add(this.barDockControl20);
            this.tpPT.Controls.Add(this.barDockControl18);
            this.tpPT.Controls.Add(this.barDockControl17);
            this.tpPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPT.Name = "tpPT";
            this.tpPT.Size = new System.Drawing.Size(1227, 339);
            this.tpPT.Text = "კროს ცხრილი";
            // 
            // ptGas1
            // 
            this.ptGas1.Appearance.Cell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.Cell.Options.UseFont = true;
            this.ptGas1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.ptGas1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.CustomTotalCell.Options.UseFont = true;
            this.ptGas1.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.DataHeaderArea.Options.UseFont = true;
            this.ptGas1.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.Empty.Options.UseFont = true;
            this.ptGas1.Appearance.ExpandButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.ExpandButton.Options.UseFont = true;
            this.ptGas1.Appearance.FieldHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.FieldHeader.Options.UseFont = true;
            this.ptGas1.Appearance.FieldValue.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.FieldValue.Options.UseFont = true;
            this.ptGas1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.FieldValueGrandTotal.Options.UseFont = true;
            this.ptGas1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.FieldValueTotal.Options.UseFont = true;
            this.ptGas1.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.ptGas1.Appearance.FilterSeparator.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.FilterSeparator.Options.UseFont = true;
            this.ptGas1.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.FocusedCell.Options.UseFont = true;
            this.ptGas1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.GrandTotalCell.Options.UseFont = true;
            this.ptGas1.Appearance.HeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.HeaderArea.Options.UseFont = true;
            this.ptGas1.Appearance.HeaderFilterButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.HeaderFilterButton.Options.UseFont = true;
            this.ptGas1.Appearance.HeaderFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.HeaderFilterButtonActive.Options.UseFont = true;
            this.ptGas1.Appearance.Lines.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.Lines.Options.UseFont = true;
            this.ptGas1.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.RowHeaderArea.Options.UseFont = true;
            this.ptGas1.Appearance.SelectedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.SelectedCell.Options.UseFont = true;
            this.ptGas1.Appearance.TotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptGas1.Appearance.TotalCell.Options.UseFont = true;
            this.ptGas1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptGas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptGas1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pcolYear,
            this.pcolQuarter,
            this.pcolMonth,
            this.pcolDayOfWeek,
            this.pcolDayOfYear,
            this.pcolWeekOfYear,
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField7,
            this.pivotGridField8,
            this.pivotGridField9,
            this.pivotGridField10,
            this.pivotGridField11,
            this.pivotGridField12,
            this.pivotGridField13,
            this.pivotGridField14,
            this.pivotGridField15,
            this.pivotGridField16});
            this.ptGas1.Location = new System.Drawing.Point(0, 40);
            this.ptGas1.Name = "ptGas1";
            this.ptGas1.OptionsDataField.AreaIndex = 1;
            this.ptGas1.OptionsDataField.RowHeaderWidth = 86;
            this.ptGas1.OptionsView.RowTreeOffset = 18;
            this.ptGas1.OptionsView.RowTreeWidth = 86;
            this.ptGas1.Size = new System.Drawing.Size(1227, 299);
            this.ptGas1.TabIndex = 12;
            // 
            // pcolYear
            // 
            this.pcolYear.AreaIndex = 0;
            this.pcolYear.Caption = "წელი";
            this.pcolYear.FieldName = "Data";
            this.pcolYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pcolYear.MinWidth = 17;
            this.pcolYear.Name = "pcolYear";
            this.pcolYear.UnboundFieldName = "pcolYear";
            this.pcolYear.Visible = false;
            this.pcolYear.Width = 86;
            // 
            // pcolQuarter
            // 
            this.pcolQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolQuarter.AreaIndex = 0;
            this.pcolQuarter.Caption = "კვარტალი";
            this.pcolQuarter.FieldName = "Data";
            this.pcolQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.pcolQuarter.MinWidth = 17;
            this.pcolQuarter.Name = "pcolQuarter";
            this.pcolQuarter.UnboundFieldName = "pcolQuarter";
            this.pcolQuarter.Visible = false;
            this.pcolQuarter.Width = 86;
            // 
            // pcolMonth
            // 
            this.pcolMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolMonth.AreaIndex = 1;
            this.pcolMonth.Caption = "თვე";
            this.pcolMonth.FieldName = "Data";
            this.pcolMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.pcolMonth.MinWidth = 17;
            this.pcolMonth.Name = "pcolMonth";
            this.pcolMonth.UnboundFieldName = "pcolMonth";
            this.pcolMonth.Visible = false;
            this.pcolMonth.Width = 86;
            // 
            // pcolDayOfWeek
            // 
            this.pcolDayOfWeek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolDayOfWeek.AreaIndex = 1;
            this.pcolDayOfWeek.Caption = "კვირის დღე";
            this.pcolDayOfWeek.FieldName = "Data";
            this.pcolDayOfWeek.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfWeek;
            this.pcolDayOfWeek.MinWidth = 17;
            this.pcolDayOfWeek.Name = "pcolDayOfWeek";
            this.pcolDayOfWeek.UnboundFieldName = "pcolDayOfWeek";
            this.pcolDayOfWeek.Visible = false;
            this.pcolDayOfWeek.Width = 86;
            // 
            // pcolDayOfYear
            // 
            this.pcolDayOfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolDayOfYear.AreaIndex = 1;
            this.pcolDayOfYear.Caption = "წლის დღე";
            this.pcolDayOfYear.FieldName = "Data";
            this.pcolDayOfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfYear;
            this.pcolDayOfYear.MinWidth = 17;
            this.pcolDayOfYear.Name = "pcolDayOfYear";
            this.pcolDayOfYear.UnboundFieldName = "pcolDayOfYear";
            this.pcolDayOfYear.Visible = false;
            this.pcolDayOfYear.Width = 86;
            // 
            // pcolWeekOfYear
            // 
            this.pcolWeekOfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolWeekOfYear.AreaIndex = 1;
            this.pcolWeekOfYear.Caption = "კვირა";
            this.pcolWeekOfYear.FieldName = "Data";
            this.pcolWeekOfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateWeekOfYear;
            this.pcolWeekOfYear.MinWidth = 17;
            this.pcolWeekOfYear.Name = "pcolWeekOfYear";
            this.pcolWeekOfYear.UnboundFieldName = "pcolWeekOfYear";
            this.pcolWeekOfYear.Visible = false;
            this.pcolWeekOfYear.Width = 86;
            // 
            // barDockControl19
            // 
            this.barDockControl19.CausesValidation = false;
            this.barDockControl19.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl19.Location = new System.Drawing.Point(0, 40);
            this.barDockControl19.Manager = this.bmPivotGrid;
            this.barDockControl19.Size = new System.Drawing.Size(0, 299);
            // 
            // barDockControl20
            // 
            this.barDockControl20.CausesValidation = false;
            this.barDockControl20.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl20.Location = new System.Drawing.Point(1227, 40);
            this.barDockControl20.Manager = this.bmPivotGrid;
            this.barDockControl20.Size = new System.Drawing.Size(0, 299);
            // 
            // barDockControl18
            // 
            this.barDockControl18.CausesValidation = false;
            this.barDockControl18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl18.Location = new System.Drawing.Point(0, 339);
            this.barDockControl18.Manager = this.bmPivotGrid;
            this.barDockControl18.Size = new System.Drawing.Size(1227, 0);
            // 
            // barDockControl17
            // 
            this.barDockControl17.CausesValidation = false;
            this.barDockControl17.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl17.Location = new System.Drawing.Point(0, 0);
            this.barDockControl17.Manager = this.bmPivotGrid;
            this.barDockControl17.Size = new System.Drawing.Size(1227, 40);
            // 
            // tpChart
            // 
            this.tpChart.Controls.Add(this.chart);
            this.tpChart.Controls.Add(this.barDockControl23);
            this.tpChart.Controls.Add(this.barDockControl24);
            this.tpChart.Controls.Add(this.barDockControl22);
            this.tpChart.Controls.Add(this.barDockControl21);
            this.tpChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpChart.Name = "tpChart";
            this.tpChart.Size = new System.Drawing.Size(1144, 297);
            this.tpChart.Text = "გრაფიკი";
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 40);
            this.chart.Name = "chart";
            this.chart.PaletteName = "Palette 1";
            this.chart.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Silver, System.Drawing.Color.Silver),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(64))))), System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(34))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(34)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(244))))), System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(244)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(250)))), ((int)(((byte)(140))))), System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(250)))), ((int)(((byte)(140)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(194))))), System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(194)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(202))))), System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(202)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(64))))), System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(167)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(167)))), ((int)(((byte)(226)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(26))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(154))))), System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(154)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(187))))), System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(187)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(131)))), ((int)(((byte)(251))))), System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Aqua, System.Drawing.Color.Aqua),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))))}));
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.Size = new System.Drawing.Size(1144, 257);
            this.chart.TabIndex = 7;
            // 
            // barDockControl23
            // 
            this.barDockControl23.CausesValidation = false;
            this.barDockControl23.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl23.Location = new System.Drawing.Point(0, 40);
            this.barDockControl23.Manager = this.bmChart;
            this.barDockControl23.Size = new System.Drawing.Size(0, 257);
            // 
            // barDockControl24
            // 
            this.barDockControl24.CausesValidation = false;
            this.barDockControl24.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl24.Location = new System.Drawing.Point(1144, 40);
            this.barDockControl24.Manager = this.bmChart;
            this.barDockControl24.Size = new System.Drawing.Size(0, 257);
            // 
            // barDockControl22
            // 
            this.barDockControl22.CausesValidation = false;
            this.barDockControl22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl22.Location = new System.Drawing.Point(0, 297);
            this.barDockControl22.Manager = this.bmChart;
            this.barDockControl22.Size = new System.Drawing.Size(1144, 0);
            // 
            // barDockControl21
            // 
            this.barDockControl21.CausesValidation = false;
            this.barDockControl21.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl21.Location = new System.Drawing.Point(0, 0);
            this.barDockControl21.Manager = this.bmChart;
            this.barDockControl21.Size = new System.Drawing.Size(1144, 40);
            // 
            // bmMasterAED
            // 
            this.bmMasterAED.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.bmMasterAED.DockControls.Add(this.barDockControlTop);
            this.bmMasterAED.DockControls.Add(this.barDockControlBottom);
            this.bmMasterAED.DockControls.Add(this.barDockControlLeft);
            this.bmMasterAED.DockControls.Add(this.barDockControlRight);
            this.bmMasterAED.Form = this;
            this.bmMasterAED.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSearch,
            this.btsHidePanel,
            this.btsTotal,
            this.btnPALayoutSave,
            this.btnPALayoutLoad,
            this.cbLayoutPA});
            this.bmMasterAED.MainMenu = this.bar2;
            this.bmMasterAED.MaxItemId = 35;
            this.bmMasterAED.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rcbLayoutPA});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSearch),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsHidePanel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsTotal),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbLayoutPA),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPALayoutLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPALayoutSave)});
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSearch
            // 
            this.btnSearch.Caption = "ძებნა";
            this.btnSearch.Id = 17;
            this.btnSearch.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Find_32x32;
            this.btnSearch.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.btnSearch.Name = "btnSearch";
            // 
            // btsHidePanel
            // 
            this.btsHidePanel.Caption = "ძებნის პანელის დამალვა";
            this.btsHidePanel.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btsHidePanel.Id = 28;
            this.btsHidePanel.Name = "btsHidePanel";
            // 
            // btsTotal
            // 
            this.btsTotal.Caption = "დაჯგუფება";
            this.btsTotal.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btsTotal.Id = 29;
            this.btsTotal.Name = "btsTotal";
            // 
            // cbLayoutPA
            // 
            this.cbLayoutPA.Caption = "სქემა";
            this.cbLayoutPA.Edit = this.rcbLayoutPA;
            this.cbLayoutPA.EditWidth = 161;
            this.cbLayoutPA.Id = 34;
            this.cbLayoutPA.Name = "cbLayoutPA";
            // 
            // rcbLayoutPA
            // 
            this.rcbLayoutPA.AutoHeight = false;
            this.rcbLayoutPA.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbLayoutPA.Name = "rcbLayoutPA";
            // 
            // btnPALayoutLoad
            // 
            this.btnPALayoutLoad.Caption = "ფილტრისა და დაჯგუფების პარამეტრების აღდგენა";
            this.btnPALayoutLoad.Id = 33;
            this.btnPALayoutLoad.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnPALayoutLoad.Name = "btnPALayoutLoad";
            // 
            // btnPALayoutSave
            // 
            this.btnPALayoutSave.Caption = "ფილტრისა და დაჯგუფების პარამეტრების შენახვა";
            this.btnPALayoutSave.Id = 32;
            this.btnPALayoutSave.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_SaveLayout_32x32;
            this.btnPALayoutSave.Name = "btnPALayoutSave";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmMasterAED;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1234, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Manager = this.bmMasterAED;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1234, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.bmMasterAED;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1234, 40);
            this.barDockControlRight.Manager = this.bmMasterAED;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // bmRecords
            // 
            this.bmRecords.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bmRecords.DockControls.Add(this.barDockControl1);
            this.bmRecords.DockControls.Add(this.barDockControl2);
            this.bmRecords.DockControls.Add(this.barDockControl3);
            this.bmRecords.DockControls.Add(this.barDockControl4);
            this.bmRecords.Form = this.tpDG;
            this.bmRecords.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cbLayoutDG,
            this.btnDGLayoutLoad,
            this.cbDGExcel,
            this.btnDGLayoutSave,
            this.btnDGExportToExcel,
            this.btnDGPrint});
            this.bmRecords.MainMenu = this.bar1;
            this.bmRecords.MaxItemId = 36;
            this.bmRecords.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rcbLayoutDG,
            this.rcbDGExcel});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(201, 525);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cbLayoutDG),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGLayoutLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGLayoutSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbDGExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGPrint)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // cbLayoutDG
            // 
            this.cbLayoutDG.Caption = "სქემა";
            this.cbLayoutDG.Edit = this.rcbLayoutDG;
            this.cbLayoutDG.EditWidth = 161;
            this.cbLayoutDG.Id = 21;
            this.cbLayoutDG.Name = "cbLayoutDG";
            // 
            // rcbLayoutDG
            // 
            this.rcbLayoutDG.AutoHeight = false;
            this.rcbLayoutDG.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbLayoutDG.Name = "rcbLayoutDG";
            // 
            // btnDGLayoutLoad
            // 
            this.btnDGLayoutLoad.Caption = "სქემის აღდგენა";
            this.btnDGLayoutLoad.Id = 22;
            this.btnDGLayoutLoad.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnDGLayoutLoad.Name = "btnDGLayoutLoad";
            // 
            // btnDGLayoutSave
            // 
            this.btnDGLayoutSave.Caption = "სქემის შენახვა";
            this.btnDGLayoutSave.Id = 33;
            this.btnDGLayoutSave.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_SaveLayout_32x32;
            this.btnDGLayoutSave.Name = "btnDGLayoutSave";
            // 
            // cbDGExcel
            // 
            this.cbDGExcel.Caption = "Excel-ის შაბლონი";
            this.cbDGExcel.Edit = this.rcbDGExcel;
            this.cbDGExcel.EditWidth = 148;
            this.cbDGExcel.Id = 32;
            this.cbDGExcel.Name = "cbDGExcel";
            // 
            // rcbDGExcel
            // 
            this.rcbDGExcel.AutoHeight = false;
            this.rcbDGExcel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbDGExcel.Name = "rcbDGExcel";
            // 
            // btnDGExportToExcel
            // 
            this.btnDGExportToExcel.Caption = "Excel-ში ექსპორტი";
            this.btnDGExportToExcel.Id = 34;
            this.btnDGExportToExcel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnDGExportToExcel.Name = "btnDGExportToExcel";
            // 
            // btnDGPrint
            // 
            this.btnDGPrint.Caption = "ბეჭდვა";
            this.btnDGPrint.Id = 35;
            this.btnDGPrint.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.preview_32x32;
            this.btnDGPrint.Name = "btnDGPrint";
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // bmPivotGrid
            // 
            this.bmPivotGrid.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.bmPivotGrid.DockControls.Add(this.barDockControl17);
            this.bmPivotGrid.DockControls.Add(this.barDockControl18);
            this.bmPivotGrid.DockControls.Add(this.barDockControl19);
            this.bmPivotGrid.DockControls.Add(this.barDockControl20);
            this.bmPivotGrid.Form = this.tpPT;
            this.bmPivotGrid.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnPTParameters,
            this.cbLayoutPT,
            this.btnPTLayoutLoad,
            this.btnPTExportToExcel,
            this.btnPTLayoutSave});
            this.bmPivotGrid.MainMenu = this.bar3;
            this.bmPivotGrid.MaxItemId = 32;
            this.bmPivotGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rcbLayoutPT});
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(222, 515);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cbLayoutPT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPTLayoutLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPTLayoutSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPTParameters, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPTExportToExcel, true)});
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // cbLayoutPT
            // 
            this.cbLayoutPT.Caption = "სქემა";
            this.cbLayoutPT.Edit = this.rcbLayoutPT;
            this.cbLayoutPT.EditWidth = 161;
            this.cbLayoutPT.Id = 21;
            this.cbLayoutPT.Name = "cbLayoutPT";
            // 
            // rcbLayoutPT
            // 
            this.rcbLayoutPT.AutoHeight = false;
            this.rcbLayoutPT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbLayoutPT.Name = "rcbLayoutPT";
            // 
            // btnPTLayoutLoad
            // 
            this.btnPTLayoutLoad.Caption = "სქემის აღდგენა";
            this.btnPTLayoutLoad.Id = 22;
            this.btnPTLayoutLoad.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnPTLayoutLoad.Name = "btnPTLayoutLoad";
            // 
            // btnPTLayoutSave
            // 
            this.btnPTLayoutSave.Caption = "სქემის შენახვა";
            this.btnPTLayoutSave.Id = 31;
            this.btnPTLayoutSave.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_SaveLayout_32x32;
            this.btnPTLayoutSave.Name = "btnPTLayoutSave";
            // 
            // btnPTParameters
            // 
            this.btnPTParameters.Caption = "კროს ცხრილის პარამეტერბი";
            this.btnPTParameters.Id = 20;
            this.btnPTParameters.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.pivot_32x32;
            this.btnPTParameters.Name = "btnPTParameters";
            // 
            // btnPTExportToExcel
            // 
            this.btnPTExportToExcel.Caption = "Excel-ში ექსპორტი";
            this.btnPTExportToExcel.Id = 24;
            this.btnPTExportToExcel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnPTExportToExcel.Name = "btnPTExportToExcel";
            // 
            // bmChart
            // 
            this.bmChart.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.bmChart.DockControls.Add(this.barDockControl21);
            this.bmChart.DockControls.Add(this.barDockControl22);
            this.bmChart.DockControls.Add(this.barDockControl23);
            this.bmChart.DockControls.Add(this.barDockControl24);
            this.bmChart.Form = this.tpChart;
            this.bmChart.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cbChartOrientation,
            this.cbChartType,
            this.bstShowValues,
            this.btnCHExportToExcel});
            this.bmChart.MainMenu = this.bar4;
            this.bmChart.MaxItemId = 32;
            this.bmChart.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rcbChartOrientation,
            this.rcbChartType});
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cbChartOrientation, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cbChartType, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCHExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.bstShowValues)});
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // cbChartOrientation
            // 
            this.cbChartOrientation.Caption = "გრაფიკის ორიენტაცია";
            this.cbChartOrientation.Edit = this.rcbChartOrientation;
            this.cbChartOrientation.EditWidth = 154;
            this.cbChartOrientation.Id = 26;
            this.cbChartOrientation.Name = "cbChartOrientation";
            // 
            // rcbChartOrientation
            // 
            this.rcbChartOrientation.AutoHeight = false;
            this.rcbChartOrientation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbChartOrientation.Name = "rcbChartOrientation";
            // 
            // cbChartType
            // 
            this.cbChartType.Caption = "გრაფიკის სტილი";
            this.cbChartType.Edit = this.rcbChartType;
            this.cbChartType.EditWidth = 155;
            this.cbChartType.Id = 28;
            this.cbChartType.Name = "cbChartType";
            // 
            // rcbChartType
            // 
            this.rcbChartType.AutoHeight = false;
            this.rcbChartType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbChartType.Name = "rcbChartType";
            // 
            // btnCHExportToExcel
            // 
            this.btnCHExportToExcel.Caption = "Excel-ში ექსპორტი";
            this.btnCHExportToExcel.Id = 31;
            this.btnCHExportToExcel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnCHExportToExcel.Name = "btnCHExportToExcel";
            // 
            // bstShowValues
            // 
            this.bstShowValues.Caption = "გრაფიკზე მნიშვნელობის გამოჩენა";
            this.bstShowValues.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bstShowValues.Id = 30;
            this.bstShowValues.Name = "bstShowValues";
            // 
            // fmgProekSectorZone
            // 
            this.fmgProekSectorZone.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProekSectorZone.Appearance.Options.UseFont = true;
            this.fmgProekSectorZone.FieldName = "ProekSectorZone";
            this.fmgProekSectorZone.Location = new System.Drawing.Point(478, 81);
            this.fmgProekSectorZone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProekSectorZone.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgProekSectorZone.Name = "fmgProekSectorZone";
            this.fmgProekSectorZone.ParameterName = null;
            this.fmgProekSectorZone.Size = new System.Drawing.Size(449, 30);
            this.fmgProekSectorZone.TabIndex = 84;
            this.fmgProekSectorZone.Text = "ლოკაცია";
            // 
            // fmgProekSector
            // 
            this.fmgProekSector.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProekSector.Appearance.Options.UseFont = true;
            this.fmgProekSector.FieldName = "ProekSector";
            this.fmgProekSector.Location = new System.Drawing.Point(478, 55);
            this.fmgProekSector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProekSector.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgProekSector.Name = "fmgProekSector";
            this.fmgProekSector.ParameterName = null;
            this.fmgProekSector.Size = new System.Drawing.Size(449, 30);
            this.fmgProekSector.TabIndex = 83;
            this.fmgProekSector.Text = "შენობა";
            // 
            // fmgProek
            // 
            this.fmgProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProek.Appearance.Options.UseFont = true;
            this.fmgProek.FieldName = "Proek";
            this.fmgProek.Location = new System.Drawing.Point(478, 29);
            this.fmgProek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProek.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgProek.Name = "fmgProek";
            this.fmgProek.ParameterName = null;
            this.fmgProek.Size = new System.Drawing.Size(449, 30);
            this.fmgProek.TabIndex = 82;
            this.fmgProek.Text = "ობიექტი";
            // 
            // fmgProekT
            // 
            this.fmgProekT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProekT.Appearance.Options.UseFont = true;
            this.fmgProekT.FieldName = "ProekT";
            this.fmgProekT.Location = new System.Drawing.Point(478, 6);
            this.fmgProekT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProekT.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgProekT.Name = "fmgProekT";
            this.fmgProekT.ParameterName = null;
            this.fmgProekT.Size = new System.Drawing.Size(449, 30);
            this.fmgProekT.TabIndex = 81;
            this.fmgProekT.Text = "ობიექტის ჯგ";
            // 
            // fmgIdProd
            // 
            this.fmgIdProd.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgIdProd.Appearance.Options.UseFont = true;
            this.fmgIdProd.FieldName = "IdProd";
            this.fmgIdProd.Location = new System.Drawing.Point(10, 76);
            this.fmgIdProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgIdProd.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgIdProd.Name = "fmgIdProd";
            this.fmgIdProd.ParameterName = null;
            this.fmgIdProd.Size = new System.Drawing.Size(449, 30);
            this.fmgIdProd.TabIndex = 86;
            this.fmgIdProd.Text = "პროდ.კოდი";
            // 
            // fmgZedd
            // 
            this.fmgZedd.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgZedd.Appearance.Options.UseFont = true;
            this.fmgZedd.FieldName = "Zedd";
            this.fmgZedd.Location = new System.Drawing.Point(10, 55);
            this.fmgZedd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgZedd.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgZedd.Name = "fmgZedd";
            this.fmgZedd.ParameterName = null;
            this.fmgZedd.Size = new System.Drawing.Size(449, 30);
            this.fmgZedd.TabIndex = 85;
            this.fmgZedd.Text = "ზედდებული";
            // 
            // colIdGas1
            // 
            this.colIdGas1.Caption = "#1";
            this.colIdGas1.FieldName = "IdGas1";
            this.colIdGas1.Name = "colIdGas1";
            this.colIdGas1.Width = 64;
            // 
            // colIdGas2
            // 
            this.colIdGas2.Caption = "#2";
            this.colIdGas2.FieldName = "IdGas2";
            this.colIdGas2.Name = "colIdGas2";
            this.colIdGas2.Width = 64;
            // 
            // colData
            // 
            this.colData.Caption = "თარიღი";
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 64;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 1;
            this.colShen.Width = 64;
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "პროდ კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 2;
            this.colIdProd.Width = 64;
            // 
            // colRaod
            // 
            this.colRaod.Caption = "რაოდ.";
            this.colRaod.FieldName = "Raod";
            this.colRaod.Name = "colRaod";
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 3;
            this.colRaod.Width = 64;
            // 
            // colGasT
            // 
            this.colGasT.Caption = "გატანის ტიპი";
            this.colGasT.FieldName = "GasT";
            this.colGasT.Name = "colGasT";
            this.colGasT.Visible = true;
            this.colGasT.VisibleIndex = 4;
            this.colGasT.Width = 64;
            // 
            // colUN
            // 
            this.colUN.Caption = "მომხმარებელი";
            this.colUN.FieldName = "UN";
            this.colUN.Name = "colUN";
            this.colUN.Visible = true;
            this.colUN.VisibleIndex = 5;
            this.colUN.Width = 64;
            // 
            // colCD
            // 
            this.colCD.Caption = "ცვილების დრო";
            this.colCD.FieldName = "CD";
            this.colCD.Name = "colCD";
            this.colCD.Visible = true;
            this.colCD.VisibleIndex = 6;
            this.colCD.Width = 64;
            // 
            // colCD1
            // 
            this.colCD1.Caption = "შექმნის დრო";
            this.colCD1.FieldName = "CD1";
            this.colCD1.Name = "colCD1";
            this.colCD1.Visible = true;
            this.colCD1.VisibleIndex = 7;
            this.colCD1.Width = 64;
            // 
            // colProek
            // 
            this.colProek.Caption = "ობიექტი";
            this.colProek.FieldName = "Proek";
            this.colProek.Name = "colProek";
            this.colProek.Visible = true;
            this.colProek.VisibleIndex = 8;
            this.colProek.Width = 64;
            // 
            // colProekT
            // 
            this.colProekT.Caption = "ობიექტის ტიპი";
            this.colProekT.FieldName = "ProekT";
            this.colProekT.Name = "colProekT";
            this.colProekT.Visible = true;
            this.colProekT.VisibleIndex = 9;
            this.colProekT.Width = 64;
            // 
            // colOrg
            // 
            this.colOrg.Caption = "კლიეტი";
            this.colOrg.FieldName = "Org";
            this.colOrg.Name = "colOrg";
            this.colOrg.Visible = true;
            this.colOrg.VisibleIndex = 10;
            this.colOrg.Width = 64;
            // 
            // colSagad
            // 
            this.colSagad.Caption = "საიდ. კოდი";
            this.colSagad.FieldName = "Sagad";
            this.colSagad.Name = "colSagad";
            this.colSagad.Visible = true;
            this.colSagad.VisibleIndex = 11;
            this.colSagad.Width = 64;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 12;
            this.colAddress.Width = 64;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "ელ ფოსტა";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 13;
            this.colEmail.Width = 64;
            // 
            // colDirek
            // 
            this.colDirek.Caption = "დირექტორი";
            this.colDirek.FieldName = "Direk";
            this.colDirek.Name = "colDirek";
            this.colDirek.Visible = true;
            this.colDirek.VisibleIndex = 14;
            this.colDirek.Width = 64;
            // 
            // colContact
            // 
            this.colContact.Caption = "საკონტაქტო პირი";
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 15;
            this.colContact.Width = 64;
            // 
            // colOrgT
            // 
            this.colOrgT.Caption = "კლიენტის ტიპი";
            this.colOrgT.FieldName = "OrgT";
            this.colOrgT.Name = "colOrgT";
            this.colOrgT.Visible = true;
            this.colOrgT.VisibleIndex = 16;
            this.colOrgT.Width = 64;
            // 
            // colProekSectorZone
            // 
            this.colProekSectorZone.Caption = "ლოკაცია";
            this.colProekSectorZone.FieldName = "ProekSectorZone";
            this.colProekSectorZone.Name = "colProekSectorZone";
            this.colProekSectorZone.Visible = true;
            this.colProekSectorZone.VisibleIndex = 17;
            this.colProekSectorZone.Width = 64;
            // 
            // colProekSector
            // 
            this.colProekSector.Caption = "შენობა";
            this.colProekSector.FieldName = "ProekSector";
            this.colProekSector.Name = "colProekSector";
            this.colProekSector.Visible = true;
            this.colProekSector.VisibleIndex = 18;
            this.colProekSector.Width = 64;
            // 
            // pcolData
            // 
            this.pcolData.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolData.AreaIndex = 0;
            this.pcolData.Caption = "თარიღი";
            this.pcolData.FieldName = "Data";
            this.pcolData.Name = "pcolData";
            this.pcolData.Visible = false;
            // 
            // pcolShen
            // 
            this.pcolShen.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolShen.AreaIndex = 0;
            this.pcolShen.Caption = "შენიშვნა";
            this.pcolShen.FieldName = "Shen";
            this.pcolShen.Name = "pcolShen";
            this.pcolShen.Visible = false;
            // 
            // pcolIdProd
            // 
            this.pcolIdProd.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolIdProd.AreaIndex = 0;
            this.pcolIdProd.Caption = "პროდ კოდი";
            this.pcolIdProd.FieldName = "IdProd";
            this.pcolIdProd.Name = "pcolIdProd";
            this.pcolIdProd.Visible = false;
            // 
            // pcolRaod
            // 
            this.pcolRaod.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolRaod.AreaIndex = 0;
            this.pcolRaod.Caption = "რაოდ.";
            this.pcolRaod.FieldName = "Raod";
            this.pcolRaod.Name = "pcolRaod";
            this.pcolRaod.Visible = false;
            // 
            // pcolGasT
            // 
            this.pcolGasT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolGasT.AreaIndex = 0;
            this.pcolGasT.Caption = "გატანის ტიპი";
            this.pcolGasT.FieldName = "GasT";
            this.pcolGasT.Name = "pcolGasT";
            this.pcolGasT.Visible = false;
            // 
            // pcolProek
            // 
            this.pcolProek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProek.AreaIndex = 0;
            this.pcolProek.Caption = "ობიექტი";
            this.pcolProek.FieldName = "Proek";
            this.pcolProek.Name = "pcolProek";
            this.pcolProek.Visible = false;
            // 
            // pcolProekT
            // 
            this.pcolProekT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProekT.AreaIndex = 0;
            this.pcolProekT.Caption = "ობიექტის ტიპი";
            this.pcolProekT.FieldName = "ProekT";
            this.pcolProekT.Name = "pcolProekT";
            this.pcolProekT.Visible = false;
            // 
            // pcolOrg
            // 
            this.pcolOrg.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOrg.AreaIndex = 0;
            this.pcolOrg.Caption = "კლიეტი";
            this.pcolOrg.FieldName = "Org";
            this.pcolOrg.Name = "pcolOrg";
            this.pcolOrg.Visible = false;
            // 
            // pcolSagad
            // 
            this.pcolSagad.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolSagad.AreaIndex = 0;
            this.pcolSagad.Caption = "საიდ. კოდი";
            this.pcolSagad.FieldName = "Sagad";
            this.pcolSagad.Name = "pcolSagad";
            this.pcolSagad.Visible = false;
            // 
            // pcolAddress
            // 
            this.pcolAddress.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolAddress.AreaIndex = 0;
            this.pcolAddress.Caption = "მისამართი";
            this.pcolAddress.FieldName = "Address";
            this.pcolAddress.Name = "pcolAddress";
            this.pcolAddress.Visible = false;
            // 
            // pcolEmail
            // 
            this.pcolEmail.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolEmail.AreaIndex = 0;
            this.pcolEmail.Caption = "ელ ფოსტა";
            this.pcolEmail.FieldName = "Email";
            this.pcolEmail.Name = "pcolEmail";
            this.pcolEmail.Visible = false;
            // 
            // pcolDirek
            // 
            this.pcolDirek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolDirek.AreaIndex = 0;
            this.pcolDirek.Caption = "დირექტორი";
            this.pcolDirek.FieldName = "Direk";
            this.pcolDirek.Name = "pcolDirek";
            this.pcolDirek.Visible = false;
            // 
            // pcolContact
            // 
            this.pcolContact.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolContact.AreaIndex = 0;
            this.pcolContact.Caption = "საკონტაქტო პირი";
            this.pcolContact.FieldName = "Contact";
            this.pcolContact.Name = "pcolContact";
            this.pcolContact.Visible = false;
            // 
            // pcolOrgT
            // 
            this.pcolOrgT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOrgT.AreaIndex = 0;
            this.pcolOrgT.Caption = "კლიენტის ტიპი";
            this.pcolOrgT.FieldName = "OrgT";
            this.pcolOrgT.Name = "pcolOrgT";
            this.pcolOrgT.Visible = false;
            // 
            // pcolProekSectorZone
            // 
            this.pcolProekSectorZone.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProekSectorZone.AreaIndex = 0;
            this.pcolProekSectorZone.Caption = "ლოკაცია";
            this.pcolProekSectorZone.FieldName = "ProekSectorZone";
            this.pcolProekSectorZone.Name = "pcolProekSectorZone";
            this.pcolProekSectorZone.Visible = false;
            // 
            // pcolProekSector
            // 
            this.pcolProekSector.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProekSector.AreaIndex = 0;
            this.pcolProekSector.Caption = "შენობა";
            this.pcolProekSector.FieldName = "ProekSector";
            this.pcolProekSector.Name = "pcolProekSector";
            this.pcolProekSector.Visible = false;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "თარიღი";
            this.pivotGridField1.FieldName = "Data";
            this.pivotGridField1.MinWidth = 17;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 86;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "შენიშვნა";
            this.pivotGridField2.FieldName = "Shen";
            this.pivotGridField2.MinWidth = 17;
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Visible = false;
            this.pivotGridField2.Width = 86;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 2;
            this.pivotGridField3.Caption = "პროდ კოდი";
            this.pivotGridField3.FieldName = "IdProd";
            this.pivotGridField3.MinWidth = 17;
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Width = 86;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "რაოდ.";
            this.pivotGridField4.FieldName = "Raod";
            this.pivotGridField4.MinWidth = 17;
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.Width = 86;
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField5.AreaIndex = 0;
            this.pivotGridField5.Caption = "გატანის ტიპი";
            this.pivotGridField5.FieldName = "GasT";
            this.pivotGridField5.MinWidth = 17;
            this.pivotGridField5.Name = "pivotGridField5";
            this.pivotGridField5.Visible = false;
            this.pivotGridField5.Width = 86;
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField6.AreaIndex = 1;
            this.pivotGridField6.Caption = "ობიექტი";
            this.pivotGridField6.FieldName = "Proek";
            this.pivotGridField6.MinWidth = 17;
            this.pivotGridField6.Name = "pivotGridField6";
            this.pivotGridField6.Width = 86;
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField7.AreaIndex = 0;
            this.pivotGridField7.Caption = "ობიექტის ტიპი";
            this.pivotGridField7.FieldName = "ProekT";
            this.pivotGridField7.MinWidth = 17;
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.Visible = false;
            this.pivotGridField7.Width = 86;
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.Caption = "კლიეტი";
            this.pivotGridField8.FieldName = "Org";
            this.pivotGridField8.MinWidth = 17;
            this.pivotGridField8.Name = "pivotGridField8";
            this.pivotGridField8.Width = 86;
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField9.AreaIndex = 0;
            this.pivotGridField9.Caption = "საიდ. კოდი";
            this.pivotGridField9.FieldName = "Sagad";
            this.pivotGridField9.MinWidth = 17;
            this.pivotGridField9.Name = "pivotGridField9";
            this.pivotGridField9.Visible = false;
            this.pivotGridField9.Width = 86;
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField10.AreaIndex = 0;
            this.pivotGridField10.Caption = "მისამართი";
            this.pivotGridField10.FieldName = "Address";
            this.pivotGridField10.MinWidth = 17;
            this.pivotGridField10.Name = "pivotGridField10";
            this.pivotGridField10.Visible = false;
            this.pivotGridField10.Width = 86;
            // 
            // pivotGridField11
            // 
            this.pivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField11.AreaIndex = 0;
            this.pivotGridField11.Caption = "ელ ფოსტა";
            this.pivotGridField11.FieldName = "Email";
            this.pivotGridField11.MinWidth = 17;
            this.pivotGridField11.Name = "pivotGridField11";
            this.pivotGridField11.Visible = false;
            this.pivotGridField11.Width = 86;
            // 
            // pivotGridField12
            // 
            this.pivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField12.AreaIndex = 0;
            this.pivotGridField12.Caption = "დირექტორი";
            this.pivotGridField12.FieldName = "Direk";
            this.pivotGridField12.MinWidth = 17;
            this.pivotGridField12.Name = "pivotGridField12";
            this.pivotGridField12.Visible = false;
            this.pivotGridField12.Width = 86;
            // 
            // pivotGridField13
            // 
            this.pivotGridField13.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField13.AreaIndex = 0;
            this.pivotGridField13.Caption = "საკონტაქტო პირი";
            this.pivotGridField13.FieldName = "Contact";
            this.pivotGridField13.MinWidth = 17;
            this.pivotGridField13.Name = "pivotGridField13";
            this.pivotGridField13.Visible = false;
            this.pivotGridField13.Width = 86;
            // 
            // pivotGridField14
            // 
            this.pivotGridField14.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField14.AreaIndex = 0;
            this.pivotGridField14.Caption = "კლიენტის ტიპი";
            this.pivotGridField14.FieldName = "OrgT";
            this.pivotGridField14.MinWidth = 17;
            this.pivotGridField14.Name = "pivotGridField14";
            this.pivotGridField14.Visible = false;
            this.pivotGridField14.Width = 86;
            // 
            // pivotGridField15
            // 
            this.pivotGridField15.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField15.AreaIndex = 0;
            this.pivotGridField15.Caption = "ლოკაცია";
            this.pivotGridField15.FieldName = "ProekSectorZone";
            this.pivotGridField15.MinWidth = 17;
            this.pivotGridField15.Name = "pivotGridField15";
            this.pivotGridField15.Visible = false;
            this.pivotGridField15.Width = 86;
            // 
            // pivotGridField16
            // 
            this.pivotGridField16.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField16.AreaIndex = 0;
            this.pivotGridField16.Caption = "შენობა";
            this.pivotGridField16.FieldName = "ProekSector";
            this.pivotGridField16.MinWidth = 17;
            this.pivotGridField16.Name = "pivotGridField16";
            this.pivotGridField16.Visible = false;
            this.pivotGridField16.Width = 86;
            // 
            // FGas1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paGas1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FGas1Form";
            this.Text = "ძებნა (პროდუქცია/მომსახურების გასავლები)";
            this.Load += new System.EventHandler(this.FGas1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paGas1)).EndInit();
            this.paGas1.ResumeLayout(false);
            this.paGas1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTotal)).EndInit();
            this.gbTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabGrids)).EndInit();
            this.tabGrids.ResumeLayout(false);
            this.tpDG.ResumeLayout(false);
            this.tpDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGas1)).EndInit();
            this.tpPT.ResumeLayout(false);
            this.tpPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptGas1)).EndInit();
            this.tpChart.ResumeLayout(false);
            this.tpChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbDGExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmPivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paGas1;
        private DevExpress.XtraEditors.PanelControl panel2;
        private FMGComboFilterControl fmgGasT;
        private FMGDateFilterControl fmgData;
        private DevExpress.XtraEditors.GroupControl gbTotal;
        private DevExpress.XtraEditors.CheckedListBoxControl chbList;
        private DevExpress.XtraEditors.ListBoxControl lbList;
        private DevExpress.XtraBars.BarManager bmMasterAED;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSearch;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTab.XtraTabControl tabGrids;
        private DevExpress.XtraTab.XtraTabPage tpDG;
        private DevExpress.XtraTab.XtraTabPage tpPT;
        private DevExpress.XtraTab.XtraTabPage tpChart;
        private DevExpress.XtraCharts.ChartControl chart;
        private DevExpress.XtraBars.BarManager bmRecords;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem cbLayoutDG;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbLayoutDG;
        private DevExpress.XtraBars.BarButtonItem btnDGLayoutLoad;
        private DevExpress.XtraBars.BarButtonItem btnDGLayoutSave;
        private DevExpress.XtraBars.BarEditItem cbDGExcel;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbDGExcel;
        private DevExpress.XtraBars.BarButtonItem btnDGExportToExcel;
        private DevExpress.XtraBars.BarButtonItem btnDGPrint;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl19;
        private DevExpress.XtraBars.BarDockControl barDockControl20;
        private DevExpress.XtraBars.BarDockControl barDockControl18;
        private DevExpress.XtraBars.BarDockControl barDockControl17;
        private DevExpress.XtraBars.BarManager bmPivotGrid;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarEditItem cbLayoutPT;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbLayoutPT;
        private DevExpress.XtraBars.BarButtonItem btnPTLayoutLoad;
        private DevExpress.XtraBars.BarButtonItem btnPTLayoutSave;
        private DevExpress.XtraBars.BarButtonItem btnPTParameters;
        private DevExpress.XtraBars.BarButtonItem btnPTExportToExcel;
        private DevExpress.XtraBars.BarDockControl barDockControl23;
        private DevExpress.XtraBars.BarDockControl barDockControl24;
        private DevExpress.XtraBars.BarDockControl barDockControl22;
        private DevExpress.XtraBars.BarDockControl barDockControl21;
        private DevExpress.XtraBars.BarManager bmChart;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarEditItem cbChartOrientation;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbChartOrientation;
        private DevExpress.XtraBars.BarEditItem cbChartType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbChartType;
        private DevExpress.XtraBars.BarCheckItem btsHidePanel;
        private DevExpress.XtraBars.BarCheckItem btsTotal;
        private DevExpress.XtraBars.BarButtonItem btnCHExportToExcel;
        private DevExpress.XtraBars.BarCheckItem bstShowValues;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbLayoutPA;
        private DevExpress.XtraBars.BarButtonItem btnPALayoutSave;
        private DevExpress.XtraBars.BarButtonItem btnPALayoutLoad;
        private DevExpress.XtraBars.BarEditItem cbLayoutPA;
        private DevExpress.XtraGrid.GridControl dgGas1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGas1;
        private DevExpress.XtraPivotGrid.PivotGridControl ptGas1;
        private DevExpress.XtraPivotGrid.PivotGridField pcolYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField pcolMonth;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfWeek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolWeekOfYear;
        private FMGTextFilterControl fmgProekSectorZone;
        private FMGComboFilterControl fmgProekSector;
        private FMGComboFilterControl fmgProek;
        private FMGComboFilterControl fmgProekT;
        private FMGTextFilterControl fmgIdProd;
        private FMGTextFilterControl fmgZedd;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGas1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGas2;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colGasT;
        private DevExpress.XtraGrid.Columns.GridColumn colUN;
        private DevExpress.XtraGrid.Columns.GridColumn colCD;
        private DevExpress.XtraGrid.Columns.GridColumn colCD1;
        private DevExpress.XtraGrid.Columns.GridColumn colProek;
        private DevExpress.XtraGrid.Columns.GridColumn colProekT;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colSagad;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDirek;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colOrgT;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSectorZone;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSector;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField11;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField12;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField13;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField14;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField15;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField16;
        private DevExpress.XtraPivotGrid.PivotGridField pcolData;
        private DevExpress.XtraPivotGrid.PivotGridField pcolShen;
        private DevExpress.XtraPivotGrid.PivotGridField pcolIdProd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolRaod;
        private DevExpress.XtraPivotGrid.PivotGridField pcolGasT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrg;
        private DevExpress.XtraPivotGrid.PivotGridField pcolSagad;
        private DevExpress.XtraPivotGrid.PivotGridField pcolAddress;
        private DevExpress.XtraPivotGrid.PivotGridField pcolEmail;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDirek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolContact;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrgT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekSectorZone;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekSector;
    }
}