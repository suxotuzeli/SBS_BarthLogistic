using SBS_BarthLogistic.Controls;

namespace SBS_BarthLogistic.FindForms
{
    partial class FXGasForm
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
            this.paXGas = new DevExpress.XtraEditors.PanelControl();
            this.fmgSalaro = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.gbTotal = new DevExpress.XtraEditors.GroupControl();
            this.chbList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lbList = new DevExpress.XtraEditors.ListBoxControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.fmgZedd = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.fmgProek = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgTanam = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgXGasT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.tabGrids = new DevExpress.XtraTab.XtraTabControl();
            this.tpDG = new DevExpress.XtraTab.XtraTabPage();
            this.dgXGas = new DevExpress.XtraGrid.GridControl();
            this.gvXGas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdXGas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZedd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXGasT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMizezi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.tpPT = new DevExpress.XtraTab.XtraTabPage();
            this.ptXGas = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pcolData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanam = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolZedd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolSalaro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolShen = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolXGasT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolMizezi = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfWeek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolWeekOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaValue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaRowPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaColPercent = new DevExpress.XtraPivotGrid.PivotGridField();
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
            ((System.ComponentModel.ISupportInitialize)(this.paXGas)).BeginInit();
            this.paXGas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTotal)).BeginInit();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabGrids)).BeginInit();
            this.tabGrids.SuspendLayout();
            this.tpDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgXGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXGas)).BeginInit();
            this.tpPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptXGas)).BeginInit();
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
            // paXGas
            // 
            this.paXGas.Controls.Add(this.fmgSalaro);
            this.paXGas.Controls.Add(this.gbTotal);
            this.paXGas.Controls.Add(this.fmgData);
            this.paXGas.Controls.Add(this.fmgZedd);
            this.paXGas.Controls.Add(this.fmgProek);
            this.paXGas.Controls.Add(this.fmgTanam);
            this.paXGas.Controls.Add(this.fmgXGasT);
            this.paXGas.Dock = System.Windows.Forms.DockStyle.Top;
            this.paXGas.Location = new System.Drawing.Point(0, 40);
            this.paXGas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paXGas.Name = "paXGas";
            this.paXGas.Size = new System.Drawing.Size(1150, 131);
            this.paXGas.TabIndex = 0;
            // 
            // fmgSalaro
            // 
            this.fmgSalaro.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgSalaro.Appearance.Options.UseFont = true;
            this.fmgSalaro.FieldName = "Salaro";
            this.fmgSalaro.Location = new System.Drawing.Point(378, 6);
            this.fmgSalaro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgSalaro.Name = "fmgSalaro";
            this.fmgSalaro.ParameterName = null;
            this.fmgSalaro.Size = new System.Drawing.Size(375, 24);
            this.fmgSalaro.TabIndex = 78;
            this.fmgSalaro.Text = "სალარო";
            // 
            // gbTotal
            // 
            this.gbTotal.AppearanceCaption.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.AppearanceCaption.Options.UseFont = true;
            this.gbTotal.Controls.Add(this.chbList);
            this.gbTotal.Controls.Add(this.lbList);
            this.gbTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTotal.Location = new System.Drawing.Point(858, 2);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(290, 127);
            this.gbTotal.TabIndex = 77;
            this.gbTotal.Text = "დაჯგუფების პარამეტრები";
            // 
            // chbList
            // 
            this.chbList.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbList.Appearance.Options.UseFont = true;
            this.chbList.CheckOnClick = true;
            this.chbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbList.Location = new System.Drawing.Point(2, 21);
            this.chbList.Name = "chbList";
            this.chbList.Size = new System.Drawing.Size(286, 35);
            this.chbList.TabIndex = 0;
            // 
            // lbList
            // 
            this.lbList.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Appearance.Options.UseFont = true;
            this.lbList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbList.Location = new System.Drawing.Point(2, 56);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(286, 69);
            this.lbList.TabIndex = 1;
            // 
            // fmgData
            // 
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.FieldName = "Data";
            this.fmgData.Location = new System.Drawing.Point(10, 6);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = null;
            this.fmgData.Size = new System.Drawing.Size(363, 24);
            this.fmgData.TabIndex = 0;
            this.fmgData.Text = "თარიღი";
            // 
            // fmgZedd
            // 
            this.fmgZedd.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgZedd.Appearance.Options.UseFont = true;
            this.fmgZedd.FieldName = "Zedd";
            this.fmgZedd.Location = new System.Drawing.Point(378, 53);
            this.fmgZedd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgZedd.Name = "fmgZedd";
            this.fmgZedd.ParameterName = null;
            this.fmgZedd.Size = new System.Drawing.Size(363, 24);
            this.fmgZedd.TabIndex = 4;
            this.fmgZedd.Text = "ზედდებული";
            // 
            // fmgProek
            // 
            this.fmgProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProek.Appearance.Options.UseFont = true;
            this.fmgProek.FieldName = "Proek";
            this.fmgProek.Location = new System.Drawing.Point(378, 29);
            this.fmgProek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProek.Name = "fmgProek";
            this.fmgProek.ParameterName = null;
            this.fmgProek.Size = new System.Drawing.Size(363, 24);
            this.fmgProek.TabIndex = 3;
            this.fmgProek.Text = "ობიექტი";
            // 
            // fmgTanam
            // 
            this.fmgTanam.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgTanam.Appearance.Options.UseFont = true;
            this.fmgTanam.FieldName = "Tanam";
            this.fmgTanam.Location = new System.Drawing.Point(10, 53);
            this.fmgTanam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgTanam.Name = "fmgTanam";
            this.fmgTanam.ParameterName = null;
            this.fmgTanam.Size = new System.Drawing.Size(363, 24);
            this.fmgTanam.TabIndex = 2;
            this.fmgTanam.Text = "თანამშრომელი";
            // 
            // fmgXGasT
            // 
            this.fmgXGasT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgXGasT.Appearance.Options.UseFont = true;
            this.fmgXGasT.FieldName = "XGasT";
            this.fmgXGasT.Location = new System.Drawing.Point(10, 29);
            this.fmgXGasT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgXGasT.Name = "fmgXGasT";
            this.fmgXGasT.ParameterName = null;
            this.fmgXGasT.Size = new System.Drawing.Size(363, 24);
            this.fmgXGasT.TabIndex = 1;
            this.fmgXGasT.Text = "თანხის გას. ტიპი";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabGrids);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 380);
            this.panel2.TabIndex = 8;
            // 
            // tabGrids
            // 
            this.tabGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGrids.Location = new System.Drawing.Point(2, 2);
            this.tabGrids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGrids.Name = "tabGrids";
            this.tabGrids.SelectedTabPage = this.tpDG;
            this.tabGrids.Size = new System.Drawing.Size(1146, 376);
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
            this.tpDG.Controls.Add(this.dgXGas);
            this.tpDG.Controls.Add(this.barDockControl3);
            this.tpDG.Controls.Add(this.barDockControl4);
            this.tpDG.Controls.Add(this.barDockControl2);
            this.tpDG.Controls.Add(this.barDockControl1);
            this.tpDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDG.Name = "tpDG";
            this.tpDG.Size = new System.Drawing.Size(1140, 347);
            this.tpDG.Text = "ჩანაწერები";
            // 
            // dgXGas
            // 
            this.dgXGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgXGas.Location = new System.Drawing.Point(0, 40);
            this.dgXGas.MainView = this.gvXGas;
            this.dgXGas.Name = "dgXGas";
            this.dgXGas.Size = new System.Drawing.Size(1140, 307);
            this.dgXGas.TabIndex = 63;
            this.dgXGas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXGas});
            // 
            // gvXGas
            // 
            this.gvXGas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvXGas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvXGas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdXGas,
            this.colData,
            this.colZedd,
            this.colXGasT,
            this.colSalaro,
            this.colShen,
            this.colTanam,
            this.colProek,
            this.colTanxa,
            this.colMizezi,
            this.colUN,
            this.colCD});
            this.gvXGas.FooterPanelHeight = 1;
            this.gvXGas.GridControl = this.dgXGas;
            this.gvXGas.GroupPanelText = "დაჯგუფება";
            this.gvXGas.GroupRowHeight = 1;
            this.gvXGas.Name = "gvXGas";
            this.gvXGas.OptionsBehavior.Editable = false;
            this.gvXGas.OptionsDetail.AllowZoomDetail = false;
            this.gvXGas.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvXGas.OptionsView.ColumnAutoWidth = false;
            this.gvXGas.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvXGas.OptionsView.ShowAutoFilterRow = true;
            this.gvXGas.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvXGas.OptionsView.ShowDetailButtons = false;
            this.gvXGas.OptionsView.ShowFooter = true;
            this.gvXGas.OptionsView.ShowGroupedColumns = true;
            // 
            // colIdXGas
            // 
            this.colIdXGas.Caption = "IdXGas";
            this.colIdXGas.FieldName = "IdXGas";
            this.colIdXGas.Name = "colIdXGas";
            // 
            // colData
            // 
            this.colData.Caption = "თარიღი";
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 74;
            // 
            // colZedd
            // 
            this.colZedd.Caption = "ზედდებული";
            this.colZedd.FieldName = "Zedd";
            this.colZedd.Name = "colZedd";
            this.colZedd.Visible = true;
            this.colZedd.VisibleIndex = 1;
            this.colZedd.Width = 61;
            // 
            // colXGasT
            // 
            this.colXGasT.Caption = "თანხის გატამის ტიპი";
            this.colXGasT.FieldName = "XGasT";
            this.colXGasT.Name = "colXGasT";
            this.colXGasT.Visible = true;
            this.colXGasT.VisibleIndex = 5;
            this.colXGasT.Width = 164;
            // 
            // colSalaro
            // 
            this.colSalaro.Caption = "სალარო";
            this.colSalaro.FieldName = "Salaro";
            this.colSalaro.Name = "colSalaro";
            this.colSalaro.Visible = true;
            this.colSalaro.VisibleIndex = 4;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 7;
            this.colShen.Width = 174;
            // 
            // colTanam
            // 
            this.colTanam.Caption = "თანამშრომელი";
            this.colTanam.FieldName = "Tanam";
            this.colTanam.Name = "colTanam";
            this.colTanam.Visible = true;
            this.colTanam.VisibleIndex = 2;
            this.colTanam.Width = 85;
            // 
            // colProek
            // 
            this.colProek.Caption = "ობიექტი";
            this.colProek.FieldName = "Proek";
            this.colProek.Name = "colProek";
            this.colProek.Visible = true;
            this.colProek.VisibleIndex = 6;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "{0:0.00##}";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 3;
            this.colTanxa.Width = 61;
            // 
            // colMizezi
            // 
            this.colMizezi.Caption = "მიზეზი";
            this.colMizezi.FieldName = "Mizezi";
            this.colMizezi.Name = "colMizezi";
            this.colMizezi.Visible = true;
            this.colMizezi.VisibleIndex = 8;
            // 
            // colUN
            // 
            this.colUN.Caption = "მომხმარებელი";
            this.colUN.FieldName = "UN";
            this.colUN.Name = "colUN";
            this.colUN.Visible = true;
            this.colUN.VisibleIndex = 9;
            // 
            // colCD
            // 
            this.colCD.Caption = "ცვლილების დრო";
            this.colCD.FieldName = "CD";
            this.colCD.Name = "colCD";
            this.colCD.Visible = true;
            this.colCD.VisibleIndex = 10;
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1140, 40);
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 347);
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(1140, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1140, 40);
            // 
            // tpPT
            // 
            this.tpPT.Controls.Add(this.ptXGas);
            this.tpPT.Controls.Add(this.barDockControl19);
            this.tpPT.Controls.Add(this.barDockControl20);
            this.tpPT.Controls.Add(this.barDockControl18);
            this.tpPT.Controls.Add(this.barDockControl17);
            this.tpPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPT.Name = "tpPT";
            this.tpPT.Size = new System.Drawing.Size(1140, 347);
            this.tpPT.Text = "კროს ცხრილი";
            // 
            // ptXGas
            // 
            this.ptXGas.Appearance.Cell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.Cell.Options.UseFont = true;
            this.ptXGas.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.ptXGas.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.CustomTotalCell.Options.UseFont = true;
            this.ptXGas.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.DataHeaderArea.Options.UseFont = true;
            this.ptXGas.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.Empty.Options.UseFont = true;
            this.ptXGas.Appearance.ExpandButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.ExpandButton.Options.UseFont = true;
            this.ptXGas.Appearance.FieldHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.FieldHeader.Options.UseFont = true;
            this.ptXGas.Appearance.FieldValue.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.FieldValue.Options.UseFont = true;
            this.ptXGas.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.FieldValueGrandTotal.Options.UseFont = true;
            this.ptXGas.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.FieldValueTotal.Options.UseFont = true;
            this.ptXGas.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.ptXGas.Appearance.FilterSeparator.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.FilterSeparator.Options.UseFont = true;
            this.ptXGas.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.FocusedCell.Options.UseFont = true;
            this.ptXGas.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.GrandTotalCell.Options.UseFont = true;
            this.ptXGas.Appearance.HeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.HeaderArea.Options.UseFont = true;
            this.ptXGas.Appearance.HeaderFilterButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.HeaderFilterButton.Options.UseFont = true;
            this.ptXGas.Appearance.HeaderFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.HeaderFilterButtonActive.Options.UseFont = true;
            this.ptXGas.Appearance.Lines.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.Lines.Options.UseFont = true;
            this.ptXGas.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.RowHeaderArea.Options.UseFont = true;
            this.ptXGas.Appearance.SelectedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.SelectedCell.Options.UseFont = true;
            this.ptXGas.Appearance.TotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptXGas.Appearance.TotalCell.Options.UseFont = true;
            this.ptXGas.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptXGas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptXGas.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pcolData,
            this.pcolProek,
            this.pcolTanam,
            this.pcolYear,
            this.pcolQuarter,
            this.pcolTanxa,
            this.pcolZedd,
            this.pcolSalaro,
            this.pcolShen,
            this.pcolXGasT,
            this.pcolMizezi,
            this.pcolMonth,
            this.pcolDayOfWeek,
            this.pcolDayOfYear,
            this.pcolWeekOfYear,
            this.pcolTanxaValue,
            this.pcolTanxaPercent,
            this.pcolTanxaRowPercent,
            this.pcolTanxaColPercent});
            this.ptXGas.Location = new System.Drawing.Point(0, 40);
            this.ptXGas.Name = "ptXGas";
            this.ptXGas.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.ptXGas.Size = new System.Drawing.Size(1140, 307);
            this.ptXGas.TabIndex = 17;
            // 
            // pcolData
            // 
            this.pcolData.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolData.AreaIndex = 0;
            this.pcolData.Caption = "თარიღი";
            this.pcolData.CellFormat.FormatString = "d.M.yyyy";
            this.pcolData.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pcolData.FieldName = "Data";
            this.pcolData.Name = "pcolData";
            this.pcolData.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // pcolProek
            // 
            this.pcolProek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProek.AreaIndex = 1;
            this.pcolProek.Caption = "ობიექტი";
            this.pcolProek.FieldName = "Proek";
            this.pcolProek.Name = "pcolProek";
            this.pcolProek.Visible = false;
            // 
            // pcolTanam
            // 
            this.pcolTanam.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolTanam.AreaIndex = 0;
            this.pcolTanam.Caption = "თანამშრომელი";
            this.pcolTanam.FieldName = "Tanam";
            this.pcolTanam.Name = "pcolTanam";
            // 
            // pcolYear
            // 
            this.pcolYear.AreaIndex = 0;
            this.pcolYear.Caption = "წელი";
            this.pcolYear.FieldName = "Data";
            this.pcolYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pcolYear.Name = "pcolYear";
            this.pcolYear.UnboundFieldName = "pcolYear";
            this.pcolYear.Visible = false;
            // 
            // pcolQuarter
            // 
            this.pcolQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolQuarter.AreaIndex = 0;
            this.pcolQuarter.Caption = "კვარტალი";
            this.pcolQuarter.FieldName = "Data";
            this.pcolQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.pcolQuarter.Name = "pcolQuarter";
            this.pcolQuarter.UnboundFieldName = "pcolQuarter";
            this.pcolQuarter.Visible = false;
            // 
            // pcolTanxa
            // 
            this.pcolTanxa.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pcolTanxa.AreaIndex = 0;
            this.pcolTanxa.Caption = "თანხა";
            this.pcolTanxa.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa.FieldName = "Tanxa";
            this.pcolTanxa.Name = "pcolTanxa";
            this.pcolTanxa.TotalCellFormat.FormatString = "{0:0.00##}";
            this.pcolTanxa.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa.TotalValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxa.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa.ValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxa.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pcolZedd
            // 
            this.pcolZedd.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolZedd.AreaIndex = 3;
            this.pcolZedd.Caption = "ზედდებული";
            this.pcolZedd.FieldName = "Zedd";
            this.pcolZedd.Name = "pcolZedd";
            this.pcolZedd.Visible = false;
            // 
            // pcolSalaro
            // 
            this.pcolSalaro.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolSalaro.AreaIndex = 2;
            this.pcolSalaro.Caption = "სალარო";
            this.pcolSalaro.FieldName = "Salaro";
            this.pcolSalaro.Name = "pcolSalaro";
            this.pcolSalaro.Visible = false;
            // 
            // pcolShen
            // 
            this.pcolShen.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolShen.AreaIndex = 1;
            this.pcolShen.Caption = "შენიშვნა";
            this.pcolShen.FieldName = "Shen";
            this.pcolShen.Name = "pcolShen";
            this.pcolShen.Visible = false;
            // 
            // pcolXGasT
            // 
            this.pcolXGasT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolXGasT.AreaIndex = 2;
            this.pcolXGasT.Caption = "თანხის გატამის ტიპი";
            this.pcolXGasT.FieldName = "XGasT";
            this.pcolXGasT.Name = "pcolXGasT";
            this.pcolXGasT.Visible = false;
            // 
            // pcolMizezi
            // 
            this.pcolMizezi.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolMizezi.AreaIndex = 1;
            this.pcolMizezi.Caption = "მიზეზი";
            this.pcolMizezi.FieldName = "Mizezi";
            this.pcolMizezi.Name = "pcolMizezi";
            this.pcolMizezi.Visible = false;
            // 
            // pcolMonth
            // 
            this.pcolMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolMonth.AreaIndex = 2;
            this.pcolMonth.Caption = "თვე";
            this.pcolMonth.FieldName = "Data";
            this.pcolMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.pcolMonth.Name = "pcolMonth";
            this.pcolMonth.UnboundFieldName = "pcolMonth";
            this.pcolMonth.Visible = false;
            // 
            // pcolDayOfWeek
            // 
            this.pcolDayOfWeek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolDayOfWeek.AreaIndex = 3;
            this.pcolDayOfWeek.Caption = "კვირის დღე";
            this.pcolDayOfWeek.FieldName = "Data";
            this.pcolDayOfWeek.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfWeek;
            this.pcolDayOfWeek.Name = "pcolDayOfWeek";
            this.pcolDayOfWeek.UnboundFieldName = "pcolDayOfWeek";
            this.pcolDayOfWeek.Visible = false;
            // 
            // pcolDayOfYear
            // 
            this.pcolDayOfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolDayOfYear.AreaIndex = 4;
            this.pcolDayOfYear.Caption = "წლის დღე";
            this.pcolDayOfYear.FieldName = "Data";
            this.pcolDayOfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfYear;
            this.pcolDayOfYear.Name = "pcolDayOfYear";
            this.pcolDayOfYear.UnboundFieldName = "pcolDayOfYear";
            this.pcolDayOfYear.Visible = false;
            // 
            // pcolWeekOfYear
            // 
            this.pcolWeekOfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolWeekOfYear.AreaIndex = 5;
            this.pcolWeekOfYear.Caption = "კვირა";
            this.pcolWeekOfYear.FieldName = "Data";
            this.pcolWeekOfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateWeekOfYear;
            this.pcolWeekOfYear.Name = "pcolWeekOfYear";
            this.pcolWeekOfYear.UnboundFieldName = "pcolWeekOfYear";
            this.pcolWeekOfYear.Visible = false;
            // 
            // pcolTanxaValue
            // 
            this.pcolTanxaValue.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcolTanxaValue.Appearance.Header.Options.UseFont = true;
            this.pcolTanxaValue.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.pcolTanxaValue.Appearance.Value.Options.UseFont = true;
            this.pcolTanxaValue.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxaValue.AreaIndex = 3;
            this.pcolTanxaValue.Caption = "ცვლილება (თანხა)";
            this.pcolTanxaValue.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaValue.FieldName = "Tanxa";
            this.pcolTanxaValue.Name = "pcolTanxaValue";
            this.pcolTanxaValue.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.AbsoluteVariation;
            this.pcolTanxaValue.TotalCellFormat.FormatString = "{0:0.00##}";
            this.pcolTanxaValue.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaValue.TotalValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxaValue.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaValue.ValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxaValue.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaValue.Visible = false;
            // 
            // pcolTanxaPercent
            // 
            this.pcolTanxaPercent.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcolTanxaPercent.Appearance.Header.Options.UseFont = true;
            this.pcolTanxaPercent.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.pcolTanxaPercent.Appearance.Value.Options.UseFont = true;
            this.pcolTanxaPercent.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxaPercent.AreaIndex = 3;
            this.pcolTanxaPercent.Caption = "ცვლილება % (თანხა)";
            this.pcolTanxaPercent.FieldName = "Tanxa";
            this.pcolTanxaPercent.Name = "pcolTanxaPercent";
            this.pcolTanxaPercent.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentVariation;
            this.pcolTanxaPercent.Visible = false;
            // 
            // pcolTanxaRowPercent
            // 
            this.pcolTanxaRowPercent.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcolTanxaRowPercent.Appearance.Header.Options.UseFont = true;
            this.pcolTanxaRowPercent.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.pcolTanxaRowPercent.Appearance.Value.Options.UseFont = true;
            this.pcolTanxaRowPercent.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxaRowPercent.AreaIndex = 3;
            this.pcolTanxaRowPercent.Caption = "% სტრიქონების მიხედვით (თანხა)";
            this.pcolTanxaRowPercent.FieldName = "Tanxa";
            this.pcolTanxaRowPercent.Name = "pcolTanxaRowPercent";
            this.pcolTanxaRowPercent.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfRow;
            this.pcolTanxaRowPercent.Visible = false;
            // 
            // pcolTanxaColPercent
            // 
            this.pcolTanxaColPercent.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcolTanxaColPercent.Appearance.Header.Options.UseFont = true;
            this.pcolTanxaColPercent.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.pcolTanxaColPercent.Appearance.Value.Options.UseFont = true;
            this.pcolTanxaColPercent.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxaColPercent.AreaIndex = 2;
            this.pcolTanxaColPercent.Caption = "% სტვეტების მიხედვით (თანხა)";
            this.pcolTanxaColPercent.FieldName = "Tanxa";
            this.pcolTanxaColPercent.Name = "pcolTanxaColPercent";
            this.pcolTanxaColPercent.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.PercentOfColumn;
            this.pcolTanxaColPercent.Visible = false;
            // 
            // barDockControl19
            // 
            this.barDockControl19.CausesValidation = false;
            this.barDockControl19.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl19.Location = new System.Drawing.Point(0, 40);
            this.barDockControl19.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControl20
            // 
            this.barDockControl20.CausesValidation = false;
            this.barDockControl20.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl20.Location = new System.Drawing.Point(1140, 40);
            this.barDockControl20.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControl18
            // 
            this.barDockControl18.CausesValidation = false;
            this.barDockControl18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl18.Location = new System.Drawing.Point(0, 347);
            this.barDockControl18.Size = new System.Drawing.Size(1140, 0);
            // 
            // barDockControl17
            // 
            this.barDockControl17.CausesValidation = false;
            this.barDockControl17.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl17.Location = new System.Drawing.Point(0, 0);
            this.barDockControl17.Size = new System.Drawing.Size(1140, 40);
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
            this.tpChart.Size = new System.Drawing.Size(1141, 349);
            this.tpChart.Text = "გრაფიკი";
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.chart.Size = new System.Drawing.Size(1141, 309);
            this.chart.TabIndex = 7;
            // 
            // barDockControl23
            // 
            this.barDockControl23.CausesValidation = false;
            this.barDockControl23.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl23.Location = new System.Drawing.Point(0, 40);
            this.barDockControl23.Size = new System.Drawing.Size(0, 309);
            // 
            // barDockControl24
            // 
            this.barDockControl24.CausesValidation = false;
            this.barDockControl24.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl24.Location = new System.Drawing.Point(1141, 40);
            this.barDockControl24.Size = new System.Drawing.Size(0, 309);
            // 
            // barDockControl22
            // 
            this.barDockControl22.CausesValidation = false;
            this.barDockControl22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl22.Location = new System.Drawing.Point(0, 349);
            this.barDockControl22.Size = new System.Drawing.Size(1141, 0);
            // 
            // barDockControl21
            // 
            this.barDockControl21.CausesValidation = false;
            this.barDockControl21.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl21.Location = new System.Drawing.Point(0, 0);
            this.barDockControl21.Size = new System.Drawing.Size(1141, 40);
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
            this.btnSearch.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Find_32x32;
            this.btnSearch.Id = 17;
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
            this.cbLayoutPA.Id = 34;
            this.cbLayoutPA.Name = "cbLayoutPA";
            this.cbLayoutPA.Width = 161;
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
            this.btnPALayoutLoad.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnPALayoutLoad.Id = 33;
            this.btnPALayoutLoad.Name = "btnPALayoutLoad";
            // 
            // btnPALayoutSave
            // 
            this.btnPALayoutSave.Caption = "ფილტრისა და დაჯგუფების პარამეტრების შენახვა";
            this.btnPALayoutSave.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_SaveLayout_32x32;
            this.btnPALayoutSave.Id = 32;
            this.btnPALayoutSave.Name = "btnPALayoutSave";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1150, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1150, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1150, 40);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.cbDGExcel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGPrint)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // cbLayoutDG
            // 
            this.cbLayoutDG.Caption = "სქემა";
            this.cbLayoutDG.Edit = this.rcbLayoutDG;
            this.cbLayoutDG.Id = 21;
            this.cbLayoutDG.Name = "cbLayoutDG";
            this.cbLayoutDG.Width = 161;
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
            this.btnDGLayoutLoad.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnDGLayoutLoad.Id = 22;
            this.btnDGLayoutLoad.Name = "btnDGLayoutLoad";
            // 
            // btnDGLayoutSave
            // 
            this.btnDGLayoutSave.Caption = "სქემის შენახვა";
            this.btnDGLayoutSave.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_SaveLayout_32x32;
            this.btnDGLayoutSave.Id = 33;
            this.btnDGLayoutSave.Name = "btnDGLayoutSave";
            // 
            // cbDGExcel
            // 
            this.cbDGExcel.Caption = "Excel-ის შაბლონი";
            this.cbDGExcel.Edit = this.rcbDGExcel;
            this.cbDGExcel.Id = 32;
            this.cbDGExcel.Name = "cbDGExcel";
            this.cbDGExcel.Width = 148;
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
            this.btnDGExportToExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnDGExportToExcel.Id = 34;
            this.btnDGExportToExcel.Name = "btnDGExportToExcel";
            // 
            // btnDGPrint
            // 
            this.btnDGPrint.Caption = "ბეჭდვა";
            this.btnDGPrint.Glyph = global::SBS_BarthLogistic.Properties.Resources.preview_32x32;
            this.btnDGPrint.Id = 35;
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
            this.cbLayoutPT.Id = 21;
            this.cbLayoutPT.Name = "cbLayoutPT";
            this.cbLayoutPT.Width = 161;
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
            this.btnPTLayoutLoad.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnPTLayoutLoad.Id = 22;
            this.btnPTLayoutLoad.Name = "btnPTLayoutLoad";
            // 
            // btnPTLayoutSave
            // 
            this.btnPTLayoutSave.Caption = "სქემის შენახვა";
            this.btnPTLayoutSave.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_SaveLayout_32x32;
            this.btnPTLayoutSave.Id = 31;
            this.btnPTLayoutSave.Name = "btnPTLayoutSave";
            // 
            // btnPTParameters
            // 
            this.btnPTParameters.Caption = "კროს ცხრილის პარამეტერბი";
            this.btnPTParameters.Glyph = global::SBS_BarthLogistic.Properties.Resources.pivot_32x32;
            this.btnPTParameters.Id = 20;
            this.btnPTParameters.Name = "btnPTParameters";
            // 
            // btnPTExportToExcel
            // 
            this.btnPTExportToExcel.Caption = "Excel-ში ექსპორტი";
            this.btnPTExportToExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnPTExportToExcel.Id = 24;
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
            this.cbChartOrientation.Id = 26;
            this.cbChartOrientation.Name = "cbChartOrientation";
            this.cbChartOrientation.Width = 154;
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
            this.cbChartType.Id = 28;
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Width = 155;
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
            this.btnCHExportToExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnCHExportToExcel.Id = 31;
            this.btnCHExportToExcel.Name = "btnCHExportToExcel";
            // 
            // bstShowValues
            // 
            this.bstShowValues.Caption = "გრაფიკზე მნიშვნელობის გამოჩენა";
            this.bstShowValues.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bstShowValues.Id = 30;
            this.bstShowValues.Name = "bstShowValues";
            // 
            // FXGasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paXGas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FXGasForm";
            this.Text = "ძებნა (თანხების გასავლები)";
            this.Load += new System.EventHandler(this.FXGasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paXGas)).EndInit();
            this.paXGas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbTotal)).EndInit();
            this.gbTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabGrids)).EndInit();
            this.tabGrids.ResumeLayout(false);
            this.tpDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgXGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXGas)).EndInit();
            this.tpPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptXGas)).EndInit();
            this.tpChart.ResumeLayout(false);
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

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paXGas;
        private DevExpress.XtraEditors.PanelControl panel2;
        private FMGComboFilterControl fmgXGasT;
        private FMGComboFilterControl fmgProek;
        private FMGComboFilterControl fmgTanam;
        private FMGTextFilterControl fmgZedd;
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
        private DevExpress.XtraGrid.GridControl dgXGas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXGas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdXGas;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colZedd;
        private DevExpress.XtraGrid.Columns.GridColumn colXGasT;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaro;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colTanam;
        private DevExpress.XtraGrid.Columns.GridColumn colProek;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colMizezi;
        private DevExpress.XtraGrid.Columns.GridColumn colUN;
        private DevExpress.XtraGrid.Columns.GridColumn colCD;
        private DevExpress.XtraPivotGrid.PivotGridControl ptXGas;
        private DevExpress.XtraPivotGrid.PivotGridField pcolData;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanam;
        private DevExpress.XtraPivotGrid.PivotGridField pcolYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxa;
        private DevExpress.XtraPivotGrid.PivotGridField pcolZedd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolSalaro;
        private DevExpress.XtraPivotGrid.PivotGridField pcolShen;
        private DevExpress.XtraPivotGrid.PivotGridField pcolXGasT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolMizezi;
        private DevExpress.XtraPivotGrid.PivotGridField pcolMonth;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfWeek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolWeekOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaValue;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaPercent;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaRowPercent;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaColPercent;
        private FMGComboFilterControl fmgSalaro;
    }
}