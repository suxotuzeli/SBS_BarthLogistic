using SBS_BarthLogistic.Controls;

namespace SBS_BarthLogistic.FindForms
{
    partial class FSalForm
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
            this.paSal = new DevExpress.XtraEditors.PanelControl();
            this.fmgOrg = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgSalaro = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgOrgT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.gbTotal = new DevExpress.XtraEditors.GroupControl();
            this.chbList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lbList = new DevExpress.XtraEditors.ListBoxControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.fmgZedd = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.fmgSalT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.tabGrids = new DevExpress.XtraTab.XtraTabControl();
            this.tpDG = new DevExpress.XtraTab.XtraTabPage();
            this.dgSal = new DevExpress.XtraGrid.GridControl();
            this.gvSal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZedd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrgT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
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
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.tpPT = new DevExpress.XtraTab.XtraTabPage();
            this.ptSal = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pcolData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolIdOrg = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrgT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolZedd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolShen = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolSalaro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolSalT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfWeek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolWeekOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaValue = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaRowPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxaColPercent = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrg = new DevExpress.XtraPivotGrid.PivotGridField();
            this.barDockControl19 = new DevExpress.XtraBars.BarDockControl();
            this.bmPivotGrid = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.cbLayoutPT = new DevExpress.XtraBars.BarEditItem();
            this.rcbLayoutPT = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnPTLayoutLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTLayoutSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTParameters = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl17 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl18 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl20 = new DevExpress.XtraBars.BarDockControl();
            this.tpChart = new DevExpress.XtraTab.XtraTabPage();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.barDockControl23 = new DevExpress.XtraBars.BarDockControl();
            this.bmChart = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.cbChartOrientation = new DevExpress.XtraBars.BarEditItem();
            this.rcbChartOrientation = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbChartType = new DevExpress.XtraBars.BarEditItem();
            this.rcbChartType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnCHExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bstShowValues = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControl21 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl22 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl24 = new DevExpress.XtraBars.BarDockControl();
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.paSal)).BeginInit();
            this.paSal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTotal)).BeginInit();
            this.gbTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabGrids)).BeginInit();
            this.tabGrids.SuspendLayout();
            this.tpDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbDGExcel)).BeginInit();
            this.tpPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmPivotGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).BeginInit();
            this.tpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // paSal
            // 
            this.paSal.Controls.Add(this.fmgOrg);
            this.paSal.Controls.Add(this.fmgSalaro);
            this.paSal.Controls.Add(this.fmgOrgT);
            this.paSal.Controls.Add(this.gbTotal);
            this.paSal.Controls.Add(this.fmgData);
            this.paSal.Controls.Add(this.fmgZedd);
            this.paSal.Controls.Add(this.fmgSalT);
            this.paSal.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSal.Location = new System.Drawing.Point(0, 40);
            this.paSal.Name = "paSal";
            this.paSal.Size = new System.Drawing.Size(1150, 161);
            this.paSal.TabIndex = 0;
            // 
            // fmgOrg
            // 
            this.fmgOrg.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrg.Appearance.Options.UseFont = true;
            this.fmgOrg.FieldName = "GvariT";
            this.fmgOrg.Location = new System.Drawing.Point(10, 70);
            this.fmgOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgOrg.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrg.Name = "fmgOrg";
            this.fmgOrg.ParameterName = null;
            this.fmgOrg.Size = new System.Drawing.Size(385, 24);
            this.fmgOrg.TabIndex = 90;
            this.fmgOrg.Text = "კლიენტი";
            // 
            // fmgSalaro
            // 
            this.fmgSalaro.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgSalaro.Appearance.Options.UseFont = true;
            this.fmgSalaro.FieldName = "Salaro";
            this.fmgSalaro.Location = new System.Drawing.Point(425, 6);
            this.fmgSalaro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgSalaro.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgSalaro.Name = "fmgSalaro";
            this.fmgSalaro.ParameterName = null;
            this.fmgSalaro.Size = new System.Drawing.Size(385, 24);
            this.fmgSalaro.TabIndex = 88;
            this.fmgSalaro.Text = "სალარო";
            // 
            // fmgOrgT
            // 
            this.fmgOrgT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrgT.Appearance.Options.UseFont = true;
            this.fmgOrgT.FieldName = "OrgT";
            this.fmgOrgT.Location = new System.Drawing.Point(10, 38);
            this.fmgOrgT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgOrgT.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrgT.Name = "fmgOrgT";
            this.fmgOrgT.ParameterName = null;
            this.fmgOrgT.Size = new System.Drawing.Size(385, 24);
            this.fmgOrgT.TabIndex = 86;
            this.fmgOrgT.Text = "კლიენტის ტიპი";
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
            this.gbTotal.Size = new System.Drawing.Size(290, 157);
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
            this.chbList.Size = new System.Drawing.Size(286, 65);
            this.chbList.TabIndex = 0;
            // 
            // lbList
            // 
            this.lbList.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Appearance.Options.UseFont = true;
            this.lbList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbList.Location = new System.Drawing.Point(2, 86);
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
            this.fmgZedd.Location = new System.Drawing.Point(425, 70);
            this.fmgZedd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgZedd.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgZedd.Name = "fmgZedd";
            this.fmgZedd.ParameterName = null;
            this.fmgZedd.Size = new System.Drawing.Size(385, 24);
            this.fmgZedd.TabIndex = 4;
            this.fmgZedd.Text = "ზედდებული";
            // 
            // fmgSalT
            // 
            this.fmgSalT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgSalT.Appearance.Options.UseFont = true;
            this.fmgSalT.FieldName = "SalT";
            this.fmgSalT.Location = new System.Drawing.Point(425, 38);
            this.fmgSalT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgSalT.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgSalT.Name = "fmgSalT";
            this.fmgSalT.ParameterName = null;
            this.fmgSalT.Size = new System.Drawing.Size(385, 24);
            this.fmgSalT.TabIndex = 1;
            this.fmgSalT.Text = "გადახდის ტიპი";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabGrids);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 350);
            this.panel2.TabIndex = 8;
            // 
            // tabGrids
            // 
            this.tabGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGrids.Location = new System.Drawing.Point(2, 2);
            this.tabGrids.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGrids.Name = "tabGrids";
            this.tabGrids.SelectedTabPage = this.tpDG;
            this.tabGrids.Size = new System.Drawing.Size(1146, 346);
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
            this.tpDG.Controls.Add(this.dgSal);
            this.tpDG.Controls.Add(this.barDockControl3);
            this.tpDG.Controls.Add(this.barDockControl4);
            this.tpDG.Controls.Add(this.barDockControl2);
            this.tpDG.Controls.Add(this.barDockControl1);
            this.tpDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDG.Name = "tpDG";
            this.tpDG.Size = new System.Drawing.Size(1140, 317);
            this.tpDG.Text = "ჩანაწერები";
            // 
            // dgSal
            // 
            this.dgSal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSal.Location = new System.Drawing.Point(0, 40);
            this.dgSal.MainView = this.gvSal;
            this.dgSal.Name = "dgSal";
            this.dgSal.Size = new System.Drawing.Size(1140, 277);
            this.dgSal.TabIndex = 63;
            this.dgSal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSal});
            // 
            // gvSal
            // 
            this.gvSal.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvSal.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSal,
            this.colData,
            this.colZedd,
            this.colOrg,
            this.colSalT,
            this.colSalaro,
            this.colShen,
            this.colTanxa,
            this.colIdOrg,
            this.colOrgT,
            this.colUN,
            this.colCD,
            this.colReg});
            this.gvSal.FooterPanelHeight = 1;
            this.gvSal.GridControl = this.dgSal;
            this.gvSal.GroupPanelText = "დაჯგუფება";
            this.gvSal.GroupRowHeight = 1;
            this.gvSal.Name = "gvSal";
            this.gvSal.OptionsBehavior.Editable = false;
            this.gvSal.OptionsDetail.AllowZoomDetail = false;
            this.gvSal.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvSal.OptionsView.ColumnAutoWidth = false;
            this.gvSal.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvSal.OptionsView.ShowAutoFilterRow = true;
            this.gvSal.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvSal.OptionsView.ShowDetailButtons = false;
            this.gvSal.OptionsView.ShowFooter = true;
            this.gvSal.OptionsView.ShowGroupedColumns = true;
            this.gvSal.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSal
            // 
            this.colIdSal.Caption = "IdSal";
            this.colIdSal.FieldName = "IdSal";
            this.colIdSal.Name = "colIdSal";
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
            // colOrg
            // 
            this.colOrg.Caption = "მყიდველი";
            this.colOrg.FieldName = "Org";
            this.colOrg.Name = "colOrg";
            this.colOrg.Visible = true;
            this.colOrg.VisibleIndex = 2;
            // 
            // colSalT
            // 
            this.colSalT.Caption = "გადახდის ტიპი";
            this.colSalT.FieldName = "SalT";
            this.colSalT.Name = "colSalT";
            this.colSalT.Visible = true;
            this.colSalT.VisibleIndex = 5;
            this.colSalT.Width = 164;
            // 
            // colSalaro
            // 
            this.colSalaro.Caption = "სალარო";
            this.colSalaro.FieldName = "Salaro";
            this.colSalaro.Name = "colSalaro";
            this.colSalaro.Visible = true;
            this.colSalaro.VisibleIndex = 3;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 6;
            this.colShen.Width = 174;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "{0:0.00##}";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tanxa", "{0:#.00##}")});
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 4;
            this.colTanxa.Width = 61;
            // 
            // colIdOrg
            // 
            this.colIdOrg.Caption = "მყიდვ. კოდი";
            this.colIdOrg.FieldName = "IdOrg";
            this.colIdOrg.Name = "colIdOrg";
            this.colIdOrg.Visible = true;
            this.colIdOrg.VisibleIndex = 7;
            // 
            // colOrgT
            // 
            this.colOrgT.Caption = "მყიდვ. ტიპი";
            this.colOrgT.FieldName = "OrgT";
            this.colOrgT.Name = "colOrgT";
            this.colOrgT.Visible = true;
            this.colOrgT.VisibleIndex = 8;
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
            this.colCD.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colCD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCD.FieldName = "CD";
            this.colCD.Name = "colCD";
            this.colCD.Visible = true;
            this.colCD.VisibleIndex = 10;
            // 
            // colReg
            // 
            this.colReg.Caption = "რეგიონი";
            this.colReg.FieldName = "Reg";
            this.colReg.Name = "colReg";
            this.colReg.Visible = true;
            this.colReg.VisibleIndex = 11;
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Manager = this.bmRecords;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 277);
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
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.bmRecords;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1140, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 317);
            this.barDockControl2.Manager = this.bmRecords;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(1140, 0);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1140, 40);
            this.barDockControl4.Manager = this.bmRecords;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 277);
            // 
            // tpPT
            // 
            this.tpPT.Controls.Add(this.ptSal);
            this.tpPT.Controls.Add(this.barDockControl19);
            this.tpPT.Controls.Add(this.barDockControl20);
            this.tpPT.Controls.Add(this.barDockControl18);
            this.tpPT.Controls.Add(this.barDockControl17);
            this.tpPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPT.Name = "tpPT";
            this.tpPT.Size = new System.Drawing.Size(1140, 317);
            this.tpPT.Text = "კროს ცხრილი";
            // 
            // ptSal
            // 
            this.ptSal.Appearance.Cell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.Cell.Options.UseFont = true;
            this.ptSal.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.ptSal.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.CustomTotalCell.Options.UseFont = true;
            this.ptSal.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.DataHeaderArea.Options.UseFont = true;
            this.ptSal.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.Empty.Options.UseFont = true;
            this.ptSal.Appearance.ExpandButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.ExpandButton.Options.UseFont = true;
            this.ptSal.Appearance.FieldHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.FieldHeader.Options.UseFont = true;
            this.ptSal.Appearance.FieldValue.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.FieldValue.Options.UseFont = true;
            this.ptSal.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.FieldValueGrandTotal.Options.UseFont = true;
            this.ptSal.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.FieldValueTotal.Options.UseFont = true;
            this.ptSal.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.ptSal.Appearance.FilterSeparator.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.FilterSeparator.Options.UseFont = true;
            this.ptSal.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.FocusedCell.Options.UseFont = true;
            this.ptSal.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.GrandTotalCell.Options.UseFont = true;
            this.ptSal.Appearance.HeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.HeaderArea.Options.UseFont = true;
            this.ptSal.Appearance.HeaderFilterButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.HeaderFilterButton.Options.UseFont = true;
            this.ptSal.Appearance.HeaderFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.HeaderFilterButtonActive.Options.UseFont = true;
            this.ptSal.Appearance.Lines.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.Lines.Options.UseFont = true;
            this.ptSal.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.RowHeaderArea.Options.UseFont = true;
            this.ptSal.Appearance.SelectedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.SelectedCell.Options.UseFont = true;
            this.ptSal.Appearance.TotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptSal.Appearance.TotalCell.Options.UseFont = true;
            this.ptSal.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptSal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptSal.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pcolData,
            this.pcolIdOrg,
            this.pcolOrgT,
            this.pcolYear,
            this.pcolQuarter,
            this.pcolTanxa,
            this.pcolZedd,
            this.pcolShen,
            this.pcolSalaro,
            this.pcolSalT,
            this.pcolMonth,
            this.pcolDayOfWeek,
            this.pcolDayOfYear,
            this.pcolWeekOfYear,
            this.pcolTanxaValue,
            this.pcolTanxaPercent,
            this.pcolTanxaRowPercent,
            this.pcolTanxaColPercent,
            this.pcolOrg});
            this.ptSal.Location = new System.Drawing.Point(0, 40);
            this.ptSal.Name = "ptSal";
            this.ptSal.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.ptSal.Size = new System.Drawing.Size(1140, 277);
            this.ptSal.TabIndex = 17;
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
            // pcolIdOrg
            // 
            this.pcolIdOrg.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolIdOrg.AreaIndex = 5;
            this.pcolIdOrg.Caption = "მყიდვ. კოდი";
            this.pcolIdOrg.FieldName = "IdOrg";
            this.pcolIdOrg.Name = "pcolIdOrg";
            this.pcolIdOrg.Visible = false;
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
            this.pcolTanxa.CellFormat.FormatString = "{0:#.00##}";
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
            // pcolShen
            // 
            this.pcolShen.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolShen.AreaIndex = 3;
            this.pcolShen.Caption = "შენიშვნა";
            this.pcolShen.FieldName = "Shen";
            this.pcolShen.Name = "pcolShen";
            this.pcolShen.Visible = false;
            // 
            // pcolSalaro
            // 
            this.pcolSalaro.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolSalaro.AreaIndex = 1;
            this.pcolSalaro.Caption = "სალარო";
            this.pcolSalaro.FieldName = "Salaro";
            this.pcolSalaro.Name = "pcolSalaro";
            this.pcolSalaro.Visible = false;
            // 
            // pcolSalT
            // 
            this.pcolSalT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolSalT.AreaIndex = 2;
            this.pcolSalT.Caption = "გადახდის ტიპი";
            this.pcolSalT.FieldName = "SalT";
            this.pcolSalT.Name = "pcolSalT";
            this.pcolSalT.Visible = false;
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
            this.pcolTanxaValue.CellFormat.FormatString = "{0:#.00##}";
            this.pcolTanxaValue.FieldName = "Tanxa";
            this.pcolTanxaValue.Name = "pcolTanxaValue";
            this.pcolTanxaValue.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.AbsoluteVariation;
            this.pcolTanxaValue.TotalCellFormat.FormatString = "{0:#.00##}";
            this.pcolTanxaValue.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaValue.TotalValueFormat.FormatString = "{0:#.00##}";
            this.pcolTanxaValue.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolTanxaValue.ValueFormat.FormatString = "{0:#.00##}";
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
            // pcolOrg
            // 
            this.pcolOrg.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOrg.AreaIndex = 1;
            this.pcolOrg.Caption = "კლიენტი";
            this.pcolOrg.FieldName = "Org";
            this.pcolOrg.Name = "pcolOrg";
            this.pcolOrg.Visible = false;
            // 
            // barDockControl19
            // 
            this.barDockControl19.CausesValidation = false;
            this.barDockControl19.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl19.Location = new System.Drawing.Point(0, 40);
            this.barDockControl19.Manager = this.bmPivotGrid;
            this.barDockControl19.Size = new System.Drawing.Size(0, 277);
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
            this.btnPTParameters.Caption = "კროს ცხრილის პარამეტრები";
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
            // barDockControl17
            // 
            this.barDockControl17.CausesValidation = false;
            this.barDockControl17.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl17.Location = new System.Drawing.Point(0, 0);
            this.barDockControl17.Manager = this.bmPivotGrid;
            this.barDockControl17.Size = new System.Drawing.Size(1140, 40);
            // 
            // barDockControl18
            // 
            this.barDockControl18.CausesValidation = false;
            this.barDockControl18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl18.Location = new System.Drawing.Point(0, 317);
            this.barDockControl18.Manager = this.bmPivotGrid;
            this.barDockControl18.Size = new System.Drawing.Size(1140, 0);
            // 
            // barDockControl20
            // 
            this.barDockControl20.CausesValidation = false;
            this.barDockControl20.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl20.Location = new System.Drawing.Point(1140, 40);
            this.barDockControl20.Manager = this.bmPivotGrid;
            this.barDockControl20.Size = new System.Drawing.Size(0, 277);
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
            this.tpChart.Size = new System.Drawing.Size(1140, 317);
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
            this.chart.Size = new System.Drawing.Size(1140, 277);
            this.chart.TabIndex = 7;
            // 
            // barDockControl23
            // 
            this.barDockControl23.CausesValidation = false;
            this.barDockControl23.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl23.Location = new System.Drawing.Point(0, 40);
            this.barDockControl23.Manager = this.bmChart;
            this.barDockControl23.Size = new System.Drawing.Size(0, 277);
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
            // barDockControl21
            // 
            this.barDockControl21.CausesValidation = false;
            this.barDockControl21.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl21.Location = new System.Drawing.Point(0, 0);
            this.barDockControl21.Manager = this.bmChart;
            this.barDockControl21.Size = new System.Drawing.Size(1140, 40);
            // 
            // barDockControl22
            // 
            this.barDockControl22.CausesValidation = false;
            this.barDockControl22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl22.Location = new System.Drawing.Point(0, 317);
            this.barDockControl22.Manager = this.bmChart;
            this.barDockControl22.Size = new System.Drawing.Size(1140, 0);
            // 
            // barDockControl24
            // 
            this.barDockControl24.CausesValidation = false;
            this.barDockControl24.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl24.Location = new System.Drawing.Point(1140, 40);
            this.barDockControl24.Manager = this.bmChart;
            this.barDockControl24.Size = new System.Drawing.Size(0, 277);
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
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // FSalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paSal);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FSalForm";
            this.Text = "ძებნა (კლიენტის გადახდები)";
            this.Load += new System.EventHandler(this.FSalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paSal)).EndInit();
            this.paSal.ResumeLayout(false);
            this.paSal.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbDGExcel)).EndInit();
            this.tpPT.ResumeLayout(false);
            this.tpPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmPivotGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).EndInit();
            this.tpChart.ResumeLayout(false);
            this.tpChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paSal;
        private DevExpress.XtraEditors.PanelControl panel2;
        private SBS_BarthLogistic.Controls.FMGComboFilterControl fmgSalT;
        private SBS_BarthLogistic.Controls.FMGTextFilterControl fmgZedd;
        private SBS_BarthLogistic.Controls.FMGDateFilterControl fmgData;
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
        private DevExpress.XtraGrid.GridControl dgSal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSal;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colZedd;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colSalT;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaro;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colOrgT;
        private DevExpress.XtraGrid.Columns.GridColumn colUN;
        private DevExpress.XtraGrid.Columns.GridColumn colCD;
        private DevExpress.XtraGrid.Columns.GridColumn colReg;
        private DevExpress.XtraPivotGrid.PivotGridControl ptSal;
        private DevExpress.XtraPivotGrid.PivotGridField pcolData;
        private DevExpress.XtraPivotGrid.PivotGridField pcolIdOrg;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrgT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxa;
        private DevExpress.XtraPivotGrid.PivotGridField pcolZedd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolShen;
        private DevExpress.XtraPivotGrid.PivotGridField pcolSalaro;
        private DevExpress.XtraPivotGrid.PivotGridField pcolSalT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolMonth;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfWeek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolWeekOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaValue;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaPercent;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaRowPercent;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxaColPercent;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrg;
        private SBS_BarthLogistic.Controls.FMGComboFilterControl fmgOrgT;
        private SBS_BarthLogistic.Controls.FMGComboFilterControl fmgSalaro;
        private FMGComboFilterControl fmgOrg;
    }
}