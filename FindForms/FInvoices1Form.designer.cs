using SBS_BarthLogistic.Controls;

namespace SBS_BarthLogistic.FindForms
{
    partial class FInvoices1Form
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
            this.paInvoices1 = new DevExpress.XtraEditors.PanelControl();
            this.gbTotal = new DevExpress.XtraEditors.GroupControl();
            this.chbList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lbList = new DevExpress.XtraEditors.ListBoxControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.fmgZedd = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.fmgInvoiceT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.tabGrids = new DevExpress.XtraTab.XtraTabControl();
            this.tpDG = new DevExpress.XtraTab.XtraTabPage();
            this.dgInvoices1 = new DevExpress.XtraGrid.GridControl();
            this.gvInvoices1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInvoices1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZedd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.tpPT = new DevExpress.XtraTab.XtraTabPage();
            this.ptInvoices1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pcolData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProdS = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProdT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProdTG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolIdProd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolRaod = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolZedd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolShen = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolGasT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfWeek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolWeekOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProekT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProdG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolFeri = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolForma = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolStili = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolSqesi = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolZoma = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaTvitg = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxa1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolFasi10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxa10 = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.fmgOrgT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgOrg = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgService = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrgT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paInvoices1)).BeginInit();
            this.paInvoices1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTotal)).BeginInit();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabGrids)).BeginInit();
            this.tabGrids.SuspendLayout();
            this.tpDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices1)).BeginInit();
            this.tpPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptInvoices1)).BeginInit();
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
            // paInvoices1
            // 
            this.paInvoices1.Controls.Add(this.fmgService);
            this.paInvoices1.Controls.Add(this.fmgOrg);
            this.paInvoices1.Controls.Add(this.fmgOrgT);
            this.paInvoices1.Controls.Add(this.gbTotal);
            this.paInvoices1.Controls.Add(this.fmgData);
            this.paInvoices1.Controls.Add(this.fmgZedd);
            this.paInvoices1.Controls.Add(this.fmgInvoiceT);
            this.paInvoices1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paInvoices1.Location = new System.Drawing.Point(0, 40);
            this.paInvoices1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paInvoices1.Name = "paInvoices1";
            this.paInvoices1.Size = new System.Drawing.Size(1150, 124);
            this.paInvoices1.TabIndex = 0;
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
            this.gbTotal.Size = new System.Drawing.Size(290, 120);
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
            this.chbList.Size = new System.Drawing.Size(286, 28);
            this.chbList.TabIndex = 0;
            // 
            // lbList
            // 
            this.lbList.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Appearance.Options.UseFont = true;
            this.lbList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbList.Location = new System.Drawing.Point(2, 49);
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
            this.fmgData.Size = new System.Drawing.Size(363, 24);
            this.fmgData.TabIndex = 0;
            this.fmgData.Text = "თარიღი";
            // 
            // fmgZedd
            // 
            this.fmgZedd.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgZedd.Appearance.Options.UseFont = true;
            this.fmgZedd.FieldName = "Zedd";
            this.fmgZedd.Location = new System.Drawing.Point(415, 6);
            this.fmgZedd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgZedd.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgZedd.Name = "fmgZedd";
            this.fmgZedd.ParameterName = null;
            this.fmgZedd.Size = new System.Drawing.Size(385, 24);
            this.fmgZedd.TabIndex = 4;
            this.fmgZedd.Text = "ზედდებული";
            // 
            // fmgInvoiceT
            // 
            this.fmgInvoiceT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgInvoiceT.Appearance.Options.UseFont = true;
            this.fmgInvoiceT.FieldName = "InvoiceT";
            this.fmgInvoiceT.Location = new System.Drawing.Point(10, 38);
            this.fmgInvoiceT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgInvoiceT.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgInvoiceT.Name = "fmgInvoiceT";
            this.fmgInvoiceT.ParameterName = null;
            this.fmgInvoiceT.Size = new System.Drawing.Size(385, 24);
            this.fmgInvoiceT.TabIndex = 1;
            this.fmgInvoiceT.Text = "ინვოისის ტიპი";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabGrids);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 387);
            this.panel2.TabIndex = 8;
            // 
            // tabGrids
            // 
            this.tabGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGrids.Location = new System.Drawing.Point(2, 2);
            this.tabGrids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGrids.Name = "tabGrids";
            this.tabGrids.SelectedTabPage = this.tpDG;
            this.tabGrids.Size = new System.Drawing.Size(1146, 383);
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
            this.tpDG.Controls.Add(this.dgInvoices1);
            this.tpDG.Controls.Add(this.barDockControl3);
            this.tpDG.Controls.Add(this.barDockControl4);
            this.tpDG.Controls.Add(this.barDockControl2);
            this.tpDG.Controls.Add(this.barDockControl1);
            this.tpDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDG.Name = "tpDG";
            this.tpDG.Size = new System.Drawing.Size(1140, 354);
            this.tpDG.Text = "ჩანაწერები";
            // 
            // dgInvoices1
            // 
            this.dgInvoices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInvoices1.Location = new System.Drawing.Point(0, 40);
            this.dgInvoices1.MainView = this.gvInvoices1;
            this.dgInvoices1.Name = "dgInvoices1";
            this.dgInvoices1.Size = new System.Drawing.Size(1140, 314);
            this.dgInvoices1.TabIndex = 58;
            this.dgInvoices1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoices1});
            // 
            // gvInvoices1
            // 
            this.gvInvoices1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvInvoices1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvInvoices1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInvoices1,
            this.colData,
            this.colZedd,
            this.colInvoices,
            this.colShen,
            this.colRaod,
            this.colFasi,
            this.colTanxa,
            this.colService,
            this.colOrg,
            this.colOrgT});
            this.gvInvoices1.DetailHeight = 284;
            this.gvInvoices1.FooterPanelHeight = 1;
            this.gvInvoices1.GridControl = this.dgInvoices1;
            this.gvInvoices1.GroupPanelText = "დაჯგუფება";
            this.gvInvoices1.GroupRowHeight = 1;
            this.gvInvoices1.Name = "gvInvoices1";
            this.gvInvoices1.OptionsBehavior.Editable = false;
            this.gvInvoices1.OptionsDetail.AllowZoomDetail = false;
            this.gvInvoices1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvInvoices1.OptionsView.ColumnAutoWidth = false;
            this.gvInvoices1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvInvoices1.OptionsView.ShowAutoFilterRow = true;
            this.gvInvoices1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvInvoices1.OptionsView.ShowDetailButtons = false;
            this.gvInvoices1.OptionsView.ShowFooter = true;
            this.gvInvoices1.OptionsView.ShowGroupedColumns = true;
            this.gvInvoices1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdInvoices1
            // 
            this.colIdInvoices1.Caption = "IdInvoices1";
            this.colIdInvoices1.FieldName = "IdInvoices1";
            this.colIdInvoices1.MinWidth = 17;
            this.colIdInvoices1.Name = "colIdInvoices1";
            this.colIdInvoices1.Width = 64;
            // 
            // colData
            // 
            this.colData.Caption = "თარიღი";
            this.colData.FieldName = "Data";
            this.colData.MinWidth = 17;
            this.colData.Name = "colData";
            this.colData.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 63;
            // 
            // colZedd
            // 
            this.colZedd.Caption = "ზედდებული";
            this.colZedd.FieldName = "Zedd";
            this.colZedd.MinWidth = 17;
            this.colZedd.Name = "colZedd";
            this.colZedd.Visible = true;
            this.colZedd.VisibleIndex = 1;
            this.colZedd.Width = 52;
            // 
            // colInvoices
            // 
            this.colInvoices.Caption = "ინვოისის ტიპი";
            this.colInvoices.FieldName = "InvoicesT";
            this.colInvoices.MinWidth = 17;
            this.colInvoices.Name = "colInvoices";
            this.colInvoices.Visible = true;
            this.colInvoices.VisibleIndex = 3;
            this.colInvoices.Width = 141;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.MinWidth = 17;
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 4;
            this.colShen.Width = 149;
            // 
            // colRaod
            // 
            this.colRaod.Caption = "რაოდ.";
            this.colRaod.DisplayFormat.FormatString = "{0:0.###}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRaod.FieldName = "Raod";
            this.colRaod.MinWidth = 17;
            this.colRaod.Name = "colRaod";
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 51;
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Manager = this.bmRecords;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 314);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1140, 40);
            this.barDockControl4.Manager = this.bmRecords;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 314);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 354);
            this.barDockControl2.Manager = this.bmRecords;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(1140, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.bmRecords;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1140, 40);
            // 
            // tpPT
            // 
            this.tpPT.Controls.Add(this.ptInvoices1);
            this.tpPT.Controls.Add(this.barDockControl19);
            this.tpPT.Controls.Add(this.barDockControl20);
            this.tpPT.Controls.Add(this.barDockControl18);
            this.tpPT.Controls.Add(this.barDockControl17);
            this.tpPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPT.Name = "tpPT";
            this.tpPT.Size = new System.Drawing.Size(1140, 354);
            this.tpPT.Text = "კროს ცხრილი";
            // 
            // ptInvoices1
            // 
            this.ptInvoices1.Appearance.Cell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.Cell.Options.UseFont = true;
            this.ptInvoices1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.ptInvoices1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.CustomTotalCell.Options.UseFont = true;
            this.ptInvoices1.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.DataHeaderArea.Options.UseFont = true;
            this.ptInvoices1.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.Empty.Options.UseFont = true;
            this.ptInvoices1.Appearance.ExpandButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.ExpandButton.Options.UseFont = true;
            this.ptInvoices1.Appearance.FieldHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.FieldHeader.Options.UseFont = true;
            this.ptInvoices1.Appearance.FieldValue.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.FieldValue.Options.UseFont = true;
            this.ptInvoices1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.FieldValueGrandTotal.Options.UseFont = true;
            this.ptInvoices1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.FieldValueTotal.Options.UseFont = true;
            this.ptInvoices1.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.ptInvoices1.Appearance.FilterSeparator.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.FilterSeparator.Options.UseFont = true;
            this.ptInvoices1.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.FocusedCell.Options.UseFont = true;
            this.ptInvoices1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.GrandTotalCell.Options.UseFont = true;
            this.ptInvoices1.Appearance.HeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.HeaderArea.Options.UseFont = true;
            this.ptInvoices1.Appearance.HeaderFilterButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.HeaderFilterButton.Options.UseFont = true;
            this.ptInvoices1.Appearance.HeaderFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.HeaderFilterButtonActive.Options.UseFont = true;
            this.ptInvoices1.Appearance.Lines.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.Lines.Options.UseFont = true;
            this.ptInvoices1.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.RowHeaderArea.Options.UseFont = true;
            this.ptInvoices1.Appearance.SelectedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.SelectedCell.Options.UseFont = true;
            this.ptInvoices1.Appearance.TotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptInvoices1.Appearance.TotalCell.Options.UseFont = true;
            this.ptInvoices1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptInvoices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptInvoices1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pcolData,
            this.pcolProdS,
            this.pcolProdT,
            this.pcolProdTG,
            this.pcolIdProd,
            this.pcolProd,
            this.pcolYear,
            this.pcolQuarter,
            this.pcolRaod,
            this.pcolZedd,
            this.pcolShen,
            this.pcolProek,
            this.pcolGasT,
            this.pcolMonth,
            this.pcolDayOfWeek,
            this.pcolDayOfYear,
            this.pcolWeekOfYear,
            this.pcolProekT,
            this.pcolProdG,
            this.pcolFeri,
            this.pcolForma,
            this.pcolStili,
            this.pcolSqesi,
            this.pcolZoma,
            this.pcolTanxaTvitg,
            this.pcolTanxa1,
            this.pcolFasi10,
            this.pcolTanxa10});
            this.ptInvoices1.Location = new System.Drawing.Point(0, 40);
            this.ptInvoices1.Name = "ptInvoices1";
            this.ptInvoices1.OptionsDataField.AreaIndex = 1;
            this.ptInvoices1.Size = new System.Drawing.Size(1140, 314);
            this.ptInvoices1.TabIndex = 12;
            // 
            // pcolData
            // 
            this.pcolData.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolData.AreaIndex = 0;
            this.pcolData.Caption = "თარიღი";
            this.pcolData.CellFormat.FormatString = "d.M.yyyy";
            this.pcolData.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pcolData.FieldName = "Data";
            this.pcolData.MinWidth = 17;
            this.pcolData.Name = "pcolData";
            this.pcolData.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.pcolData.Width = 86;
            // 
            // pcolProdS
            // 
            this.pcolProdS.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolProdS.AreaIndex = 1;
            this.pcolProdS.Caption = "პროდუქციის სახეობა";
            this.pcolProdS.FieldName = "ProdS";
            this.pcolProdS.MinWidth = 17;
            this.pcolProdS.Name = "pcolProdS";
            this.pcolProdS.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.pcolProdS.Visible = false;
            this.pcolProdS.Width = 86;
            // 
            // pcolProdT
            // 
            this.pcolProdT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProdT.AreaIndex = 3;
            this.pcolProdT.Caption = "პროდუქციის ტიპი";
            this.pcolProdT.FieldName = "ProdT";
            this.pcolProdT.MinWidth = 17;
            this.pcolProdT.Name = "pcolProdT";
            this.pcolProdT.Visible = false;
            this.pcolProdT.Width = 86;
            // 
            // pcolProdTG
            // 
            this.pcolProdTG.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProdTG.AreaIndex = 1;
            this.pcolProdTG.Caption = "პროდ.ტიპის ჯგ.";
            this.pcolProdTG.FieldName = "ProdTG";
            this.pcolProdTG.MinWidth = 17;
            this.pcolProdTG.Name = "pcolProdTG";
            this.pcolProdTG.Visible = false;
            this.pcolProdTG.Width = 86;
            // 
            // pcolIdProd
            // 
            this.pcolIdProd.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolIdProd.AreaIndex = 4;
            this.pcolIdProd.Caption = "პროდ. კოდი";
            this.pcolIdProd.FieldName = "IdProd";
            this.pcolIdProd.MinWidth = 17;
            this.pcolIdProd.Name = "pcolIdProd";
            this.pcolIdProd.Visible = false;
            this.pcolIdProd.Width = 86;
            // 
            // pcolProd
            // 
            this.pcolProd.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolProd.AreaIndex = 0;
            this.pcolProd.Caption = "პროდუქცია";
            this.pcolProd.FieldName = "Prod";
            this.pcolProd.MinWidth = 17;
            this.pcolProd.Name = "pcolProd";
            this.pcolProd.Width = 86;
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
            // pcolRaod
            // 
            this.pcolRaod.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pcolRaod.AreaIndex = 0;
            this.pcolRaod.Caption = "რაოდენობა";
            this.pcolRaod.CellFormat.FormatString = "{0:0.###}";
            this.pcolRaod.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.FieldName = "Raod";
            this.pcolRaod.MinWidth = 17;
            this.pcolRaod.Name = "pcolRaod";
            this.pcolRaod.TotalCellFormat.FormatString = "{0:0.###}";
            this.pcolRaod.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.TotalValueFormat.FormatString = "{0:0.###}";
            this.pcolRaod.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.ValueFormat.FormatString = "{0:0.###}";
            this.pcolRaod.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.Width = 86;
            // 
            // pcolZedd
            // 
            this.pcolZedd.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolZedd.AreaIndex = 3;
            this.pcolZedd.Caption = "ზედდებული";
            this.pcolZedd.FieldName = "Zedd";
            this.pcolZedd.MinWidth = 17;
            this.pcolZedd.Name = "pcolZedd";
            this.pcolZedd.Visible = false;
            this.pcolZedd.Width = 86;
            // 
            // pcolShen
            // 
            this.pcolShen.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolShen.AreaIndex = 3;
            this.pcolShen.Caption = "შენიშვნა";
            this.pcolShen.FieldName = "Shen";
            this.pcolShen.MinWidth = 17;
            this.pcolShen.Name = "pcolShen";
            this.pcolShen.Visible = false;
            this.pcolShen.Width = 86;
            // 
            // pcolProek
            // 
            this.pcolProek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProek.AreaIndex = 3;
            this.pcolProek.Caption = "ობიექტი";
            this.pcolProek.FieldName = "Proek";
            this.pcolProek.MinWidth = 17;
            this.pcolProek.Name = "pcolProek";
            this.pcolProek.Visible = false;
            this.pcolProek.Width = 86;
            // 
            // pcolGasT
            // 
            this.pcolGasT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolGasT.AreaIndex = 2;
            this.pcolGasT.Caption = "გატ.ტიპი";
            this.pcolGasT.FieldName = "GasT";
            this.pcolGasT.MinWidth = 17;
            this.pcolGasT.Name = "pcolGasT";
            this.pcolGasT.Visible = false;
            this.pcolGasT.Width = 86;
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
            // pcolProekT
            // 
            this.pcolProekT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProekT.AreaIndex = 1;
            this.pcolProekT.Caption = "ობიექტების ჯგუფი";
            this.pcolProekT.FieldName = "ProekT";
            this.pcolProekT.MinWidth = 17;
            this.pcolProekT.Name = "pcolProekT";
            this.pcolProekT.Visible = false;
            this.pcolProekT.Width = 86;
            // 
            // pcolProdG
            // 
            this.pcolProdG.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProdG.AreaIndex = 1;
            this.pcolProdG.Caption = "პროდ.ჯგუფი";
            this.pcolProdG.FieldName = "ProdG";
            this.pcolProdG.MinWidth = 17;
            this.pcolProdG.Name = "pcolProdG";
            this.pcolProdG.Visible = false;
            this.pcolProdG.Width = 86;
            // 
            // pcolFeri
            // 
            this.pcolFeri.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolFeri.AreaIndex = 1;
            this.pcolFeri.Caption = "ფერი";
            this.pcolFeri.FieldName = "Feri";
            this.pcolFeri.MinWidth = 17;
            this.pcolFeri.Name = "pcolFeri";
            this.pcolFeri.Visible = false;
            this.pcolFeri.Width = 86;
            // 
            // pcolForma
            // 
            this.pcolForma.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolForma.AreaIndex = 1;
            this.pcolForma.Caption = "ფორმა";
            this.pcolForma.FieldName = "Forma";
            this.pcolForma.MinWidth = 17;
            this.pcolForma.Name = "pcolForma";
            this.pcolForma.Visible = false;
            this.pcolForma.Width = 86;
            // 
            // pcolStili
            // 
            this.pcolStili.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolStili.AreaIndex = 1;
            this.pcolStili.Caption = "სტილი";
            this.pcolStili.FieldName = "Stili";
            this.pcolStili.MinWidth = 17;
            this.pcolStili.Name = "pcolStili";
            this.pcolStili.Visible = false;
            this.pcolStili.Width = 86;
            // 
            // pcolSqesi
            // 
            this.pcolSqesi.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolSqesi.AreaIndex = 1;
            this.pcolSqesi.Caption = "სქესი";
            this.pcolSqesi.FieldName = "Sqesi";
            this.pcolSqesi.MinWidth = 17;
            this.pcolSqesi.Name = "pcolSqesi";
            this.pcolSqesi.Visible = false;
            this.pcolSqesi.Width = 86;
            // 
            // pcolZoma
            // 
            this.pcolZoma.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolZoma.AreaIndex = 1;
            this.pcolZoma.Caption = "ზომა";
            this.pcolZoma.FieldName = "Zoma";
            this.pcolZoma.MinWidth = 17;
            this.pcolZoma.Name = "pcolZoma";
            this.pcolZoma.Visible = false;
            this.pcolZoma.Width = 86;
            // 
            // pcolTanxaTvitg
            // 
            this.pcolTanxaTvitg.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxaTvitg.AreaIndex = 1;
            this.pcolTanxaTvitg.Caption = "თანხა თვიღთირებულება 1";
            this.pcolTanxaTvitg.CellFormat.FormatString = "{0:0.00##}";
            this.pcolTanxaTvitg.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaTvitg.FieldName = "TanxaTvitg";
            this.pcolTanxaTvitg.MinWidth = 17;
            this.pcolTanxaTvitg.Name = "pcolTanxaTvitg";
            this.pcolTanxaTvitg.TotalCellFormat.FormatString = "{0:0.00##}";
            this.pcolTanxaTvitg.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaTvitg.TotalValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxaTvitg.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaTvitg.ValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxaTvitg.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaTvitg.Visible = false;
            this.pcolTanxaTvitg.Width = 86;
            // 
            // pcolTanxa1
            // 
            this.pcolTanxa1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxa1.AreaIndex = 1;
            this.pcolTanxa1.Caption = "სარეალიზაციო თანხა 1";
            this.pcolTanxa1.CellFormat.FormatString = "{0:0.00##}";
            this.pcolTanxa1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa1.FieldName = "Tanxa1";
            this.pcolTanxa1.MinWidth = 17;
            this.pcolTanxa1.Name = "pcolTanxa1";
            this.pcolTanxa1.TotalCellFormat.FormatString = "{0:0.00##}";
            this.pcolTanxa1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa1.TotalValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxa1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa1.ValueFormat.FormatString = "{0:0.00##}";
            this.pcolTanxa1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa1.Visible = false;
            this.pcolTanxa1.Width = 86;
            // 
            // pcolFasi10
            // 
            this.pcolFasi10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolFasi10.AreaIndex = 1;
            this.pcolFasi10.Caption = "შესყ.ფასი";
            this.pcolFasi10.CellFormat.FormatString = "0.###";
            this.pcolFasi10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolFasi10.MinWidth = 17;
            this.pcolFasi10.Name = "pcolFasi10";
            this.pcolFasi10.TotalCellFormat.FormatString = "0.###";
            this.pcolFasi10.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolFasi10.ValueFormat.FormatString = "0.###";
            this.pcolFasi10.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolFasi10.Visible = false;
            this.pcolFasi10.Width = 86;
            // 
            // pcolTanxa10
            // 
            this.pcolTanxa10.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxa10.AreaIndex = 2;
            this.pcolTanxa10.Caption = "შესყ.თანხა";
            this.pcolTanxa10.CellFormat.FormatString = "0.###";
            this.pcolTanxa10.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa10.FieldName = "Tanxa10";
            this.pcolTanxa10.MinWidth = 17;
            this.pcolTanxa10.Name = "pcolTanxa10";
            this.pcolTanxa10.TotalCellFormat.FormatString = "0.###";
            this.pcolTanxa10.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa10.ValueFormat.FormatString = "0.###";
            this.pcolTanxa10.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxa10.Visible = false;
            this.pcolTanxa10.Width = 86;
            // 
            // barDockControl19
            // 
            this.barDockControl19.CausesValidation = false;
            this.barDockControl19.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl19.Location = new System.Drawing.Point(0, 40);
            this.barDockControl19.Manager = this.bmPivotGrid;
            this.barDockControl19.Size = new System.Drawing.Size(0, 314);
            // 
            // barDockControl20
            // 
            this.barDockControl20.CausesValidation = false;
            this.barDockControl20.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl20.Location = new System.Drawing.Point(1140, 40);
            this.barDockControl20.Manager = this.bmPivotGrid;
            this.barDockControl20.Size = new System.Drawing.Size(0, 314);
            // 
            // barDockControl18
            // 
            this.barDockControl18.CausesValidation = false;
            this.barDockControl18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl18.Location = new System.Drawing.Point(0, 354);
            this.barDockControl18.Manager = this.bmPivotGrid;
            this.barDockControl18.Size = new System.Drawing.Size(1140, 0);
            // 
            // barDockControl17
            // 
            this.barDockControl17.CausesValidation = false;
            this.barDockControl17.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl17.Location = new System.Drawing.Point(0, 0);
            this.barDockControl17.Manager = this.bmPivotGrid;
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
            this.tpChart.Size = new System.Drawing.Size(1141, 294);
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
            this.chart.SeriesTemplate.SeriesColorizer = null;
            this.chart.Size = new System.Drawing.Size(1141, 254);
            this.chart.TabIndex = 7;
            // 
            // barDockControl23
            // 
            this.barDockControl23.CausesValidation = false;
            this.barDockControl23.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl23.Location = new System.Drawing.Point(0, 40);
            this.barDockControl23.Manager = this.bmChart;
            this.barDockControl23.Size = new System.Drawing.Size(0, 254);
            // 
            // barDockControl24
            // 
            this.barDockControl24.CausesValidation = false;
            this.barDockControl24.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl24.Location = new System.Drawing.Point(1141, 40);
            this.barDockControl24.Manager = this.bmChart;
            this.barDockControl24.Size = new System.Drawing.Size(0, 254);
            // 
            // barDockControl22
            // 
            this.barDockControl22.CausesValidation = false;
            this.barDockControl22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl22.Location = new System.Drawing.Point(0, 294);
            this.barDockControl22.Manager = this.bmChart;
            this.barDockControl22.Size = new System.Drawing.Size(1141, 0);
            // 
            // barDockControl21
            // 
            this.barDockControl21.CausesValidation = false;
            this.barDockControl21.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl21.Location = new System.Drawing.Point(0, 0);
            this.barDockControl21.Manager = this.bmChart;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1150, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Manager = this.bmMasterAED;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1150, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1150, 40);
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
            // fmgOrgT
            // 
            this.fmgOrgT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrgT.Appearance.Options.UseFont = true;
            this.fmgOrgT.FieldName = "InvoiceT";
            this.fmgOrgT.Location = new System.Drawing.Point(10, 64);
            this.fmgOrgT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgOrgT.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrgT.Name = "fmgOrgT";
            this.fmgOrgT.ParameterName = "OrgT";
            this.fmgOrgT.Size = new System.Drawing.Size(385, 24);
            this.fmgOrgT.TabIndex = 78;
            this.fmgOrgT.Text = "კლიენტის ტიპი";
            // 
            // fmgOrg
            // 
            this.fmgOrg.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrg.Appearance.Options.UseFont = true;
            this.fmgOrg.FieldName = "InvoiceT";
            this.fmgOrg.Location = new System.Drawing.Point(10, 89);
            this.fmgOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgOrg.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrg.Name = "fmgOrg";
            this.fmgOrg.ParameterName = "Org";
            this.fmgOrg.Size = new System.Drawing.Size(385, 24);
            this.fmgOrg.TabIndex = 79;
            this.fmgOrg.Text = "კლიენტი";
            // 
            // fmgService
            // 
            this.fmgService.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgService.Appearance.Options.UseFont = true;
            this.fmgService.FieldName = "InvoiceT";
            this.fmgService.Location = new System.Drawing.Point(415, 38);
            this.fmgService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgService.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgService.Name = "fmgService";
            this.fmgService.ParameterName = "Service";
            this.fmgService.Size = new System.Drawing.Size(385, 24);
            this.fmgService.TabIndex = 80;
            this.fmgService.Text = "სერვისი";
            // 
            // colFasi
            // 
            this.colFasi.Caption = "ფასი";
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 5;
            this.colFasi.Width = 64;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 6;
            this.colTanxa.Width = 64;
            // 
            // colService
            // 
            this.colService.Caption = "სერვისი";
            this.colService.FieldName = "Service";
            this.colService.Name = "colService";
            this.colService.Visible = true;
            this.colService.VisibleIndex = 7;
            this.colService.Width = 64;
            // 
            // colOrg
            // 
            this.colOrg.Caption = "ჯლიენტი";
            this.colOrg.FieldName = "Org";
            this.colOrg.Name = "colOrg";
            this.colOrg.Visible = true;
            this.colOrg.VisibleIndex = 8;
            this.colOrg.Width = 64;
            // 
            // colOrgT
            // 
            this.colOrgT.Caption = "კლიენტის ტიპი";
            this.colOrgT.FieldName = "OrgT";
            this.colOrgT.Name = "colOrgT";
            this.colOrgT.Visible = true;
            this.colOrgT.VisibleIndex = 9;
            this.colOrgT.Width = 64;
            // 
            // FInvoices1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paInvoices1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FInvoices1Form";
            this.Text = "ძებნა (პროდუქცია/მომსახურების გასავლები)";
            this.Load += new System.EventHandler(this.FInvoices1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paInvoices1)).EndInit();
            this.paInvoices1.ResumeLayout(false);
            this.paInvoices1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices1)).EndInit();
            this.tpPT.ResumeLayout(false);
            this.tpPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptInvoices1)).EndInit();
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

        private DevExpress.XtraEditors.PanelControl paInvoices1;
        private DevExpress.XtraEditors.PanelControl panel2;
        private FMGComboFilterControl fmgInvoiceT;
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
        private DevExpress.XtraGrid.GridControl dgInvoices1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoices1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInvoices1;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colZedd;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoices;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraPivotGrid.PivotGridControl ptInvoices1;
        private DevExpress.XtraPivotGrid.PivotGridField pcolData;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProdS;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProdT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProdTG;
        private DevExpress.XtraPivotGrid.PivotGridField pcolIdProd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField pcolRaod;
        private DevExpress.XtraPivotGrid.PivotGridField pcolZedd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolShen;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolGasT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolMonth;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfWeek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolWeekOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProdG;
        private DevExpress.XtraPivotGrid.PivotGridField pcolFeri;
        private DevExpress.XtraPivotGrid.PivotGridField pcolForma;
        private DevExpress.XtraPivotGrid.PivotGridField pcolStili;
        private DevExpress.XtraPivotGrid.PivotGridField pcolSqesi;
        private DevExpress.XtraPivotGrid.PivotGridField pcolZoma;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaTvitg;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxa1;
        private DevExpress.XtraPivotGrid.PivotGridField pcolFasi10;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxa10;
        private FMGComboFilterControl fmgOrg;
        private FMGComboFilterControl fmgOrgT;
        private FMGComboFilterControl fmgService;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colService;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colOrgT;
    }
}