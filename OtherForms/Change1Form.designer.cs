namespace SBS_BarthLogistic.OtherForms
{
    partial class Change1Form {
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
            this.dgChange1 = new DevExpress.XtraGrid.GridControl();
            this.gvChange1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdChange1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableNameText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSql = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgChange2 = new DevExpress.XtraGrid.GridControl();
            this.gvChange2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdChange2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bmMasterAED = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.txtData1 = new DevExpress.XtraBars.BarEditItem();
            this.rtxtData1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtData2 = new DevExpress.XtraBars.BarEditItem();
            this.rtxtData2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cbPeriod = new DevExpress.XtraBars.BarEditItem();
            this.rcbPeriod = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogDelete = new DevExpress.XtraBars.BarButtonItem();
            this.cbbtnFillById = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.cmMasterAED = new DevExpress.XtraBars.PopupMenu(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barBarCode = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnDetExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportPocket = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChange2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChange2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmMasterAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgChange1
            // 
            this.dgChange1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgChange1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChange1.Location = new System.Drawing.Point(0, 0);
            this.dgChange1.MainView = this.gvChange1;
            this.dgChange1.Name = "dgChange1";
            this.dgChange1.Size = new System.Drawing.Size(1174, 348);
            this.dgChange1.TabIndex = 4;
            this.dgChange1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChange1});
            // 
            // gvChange1
            // 
            this.gvChange1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvChange1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvChange1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdChange1,
            this.colData,
            this.colTableName,
            this.colUserName,
            this.colTableNameText,
            this.colOperType,
            this.colSql});
            this.gvChange1.FooterPanelHeight = 1;
            this.gvChange1.GridControl = this.dgChange1;
            this.gvChange1.GroupPanelText = "დაჯგუფება";
            this.gvChange1.GroupRowHeight = 1;
            this.gvChange1.Name = "gvChange1";
            this.gvChange1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvChange1.OptionsBehavior.Editable = false;
            this.gvChange1.OptionsDetail.AllowZoomDetail = false;
            this.gvChange1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvChange1.OptionsView.ColumnAutoWidth = false;
            this.gvChange1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvChange1.OptionsView.ShowAutoFilterRow = true;
            this.gvChange1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvChange1.OptionsView.ShowDetailButtons = false;
            this.gvChange1.OptionsView.ShowFooter = true;
            this.gvChange1.OptionsView.ShowGroupedColumns = true;
            this.gvChange1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdChange1
            // 
            this.colIdChange1.Caption = "IdChange1";
            this.colIdChange1.FieldName = "IdChange1";
            this.colIdChange1.Name = "colIdChange1";
            // 
            // colData
            // 
            this.colData.Caption = "თარიღი";
            this.colData.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 138;
            // 
            // colTableName
            // 
            this.colTableName.Caption = "ცხრილის დასახელება";
            this.colTableName.FieldName = "TableName";
            this.colTableName.Name = "colTableName";
            this.colTableName.Visible = true;
            this.colTableName.VisibleIndex = 2;
            this.colTableName.Width = 169;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "მომხმარებელი";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            this.colUserName.Width = 110;
            // 
            // colTableNameText
            // 
            this.colTableNameText.Caption = "ცხრილის დასახელება";
            this.colTableNameText.FieldName = "TableNameText";
            this.colTableNameText.Name = "colTableNameText";
            this.colTableNameText.Visible = true;
            this.colTableNameText.VisibleIndex = 3;
            this.colTableNameText.Width = 252;
            // 
            // colOperType
            // 
            this.colOperType.Caption = "ოპერაციის ტიპი";
            this.colOperType.FieldName = "OperType";
            this.colOperType.Name = "colOperType";
            this.colOperType.Visible = true;
            this.colOperType.VisibleIndex = 4;
            this.colOperType.Width = 119;
            // 
            // colSql
            // 
            this.colSql.Caption = "SQL";
            this.colSql.FieldName = "Sql";
            this.colSql.Name = "colSql";
            this.colSql.Visible = true;
            this.colSql.VisibleIndex = 5;
            this.colSql.Width = 605;
            // 
            // dgChange2
            // 
            this.dgChange2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChange2.Location = new System.Drawing.Point(0, 40);
            this.dgChange2.MainView = this.gvChange2;
            this.dgChange2.Name = "dgChange2";
            this.dgChange2.Size = new System.Drawing.Size(1174, 222);
            this.dgChange2.TabIndex = 4;
            this.dgChange2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChange2});
            this.dgChange2.DoubleClick += new System.EventHandler(this.dgDet_DoubleClick);
            // 
            // gvChange2
            // 
            this.gvChange2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvChange2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvChange2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdChange2,
            this.colFieldName,
            this.colFieldCaption,
            this.colOldValue,
            this.colNewValue});
            this.gvChange2.FooterPanelHeight = 1;
            this.gvChange2.GridControl = this.dgChange2;
            this.gvChange2.GroupPanelText = "დაჯგუფება";
            this.gvChange2.GroupRowHeight = 1;
            this.gvChange2.Name = "gvChange2";
            this.gvChange2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvChange2.OptionsBehavior.Editable = false;
            this.gvChange2.OptionsDetail.AllowZoomDetail = false;
            this.gvChange2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvChange2.OptionsSelection.MultiSelect = true;
            this.gvChange2.OptionsView.ColumnAutoWidth = false;
            this.gvChange2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvChange2.OptionsView.ShowAutoFilterRow = true;
            this.gvChange2.OptionsView.ShowDetailButtons = false;
            this.gvChange2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvChange2.OptionsView.ShowFooter = true;
            this.gvChange2.OptionsView.ShowGroupPanel = false;
            this.gvChange2.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView2_RowStyle);
            // 
            // colIdChange2
            // 
            this.colIdChange2.Caption = "მიმდ.";
            this.colIdChange2.FieldName = "IdChange2";
            this.colIdChange2.Name = "colIdChange2";
            this.colIdChange2.OptionsFilter.ShowEmptyDateFilter = true;
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "ველის დასახელება";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 0;
            this.colFieldName.Width = 135;
            // 
            // colFieldCaption
            // 
            this.colFieldCaption.Caption = "ველის დასახელება";
            this.colFieldCaption.FieldName = "FieldCaption";
            this.colFieldCaption.Name = "colFieldCaption";
            this.colFieldCaption.Visible = true;
            this.colFieldCaption.VisibleIndex = 1;
            this.colFieldCaption.Width = 184;
            // 
            // colOldValue
            // 
            this.colOldValue.Caption = "ძველი მნიშვნელობა";
            this.colOldValue.FieldName = "OldValue";
            this.colOldValue.Name = "colOldValue";
            this.colOldValue.Visible = true;
            this.colOldValue.VisibleIndex = 2;
            this.colOldValue.Width = 186;
            // 
            // colNewValue
            // 
            this.colNewValue.Caption = "ახალი მნიშვნელობა";
            this.colNewValue.FieldName = "NewValue";
            this.colNewValue.Name = "colNewValue";
            this.colNewValue.Visible = true;
            this.colNewValue.VisibleIndex = 3;
            this.colNewValue.Width = 178;
            // 
            // bmMasterAED
            // 
            this.bmMasterAED.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.bmMasterAED.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Period", new System.Guid("03b4dee1-ff9b-491c-86eb-3be65c186e35"))});
            this.bmMasterAED.DockControls.Add(this.barDockControl1);
            this.bmMasterAED.DockControls.Add(this.barDockControl2);
            this.bmMasterAED.DockControls.Add(this.barDockControl3);
            this.bmMasterAED.DockControls.Add(this.barDockControl4);
            this.bmMasterAED.Form = this;
            this.bmMasterAED.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRefresh,
            this.btnExportToExcel,
            this.txtData1,
            this.txtData2,
            this.cbPeriod,
            this.btnLayout,
            this.btnPrint,
            this.btnLogDelete,
            this.cbbtnFillById});
            this.bmMasterAED.MainMenu = this.bar2;
            this.bmMasterAED.MaxItemId = 19;
            this.bmMasterAED.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtData1,
            this.rtxtData2,
            this.rcbPeriod});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtData1),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtData2),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.cbPeriod, "პერიოდი", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbbtnFillById)});
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Caption = "ექსელში ექსპორტი";
            this.btnExportToExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnExportToExcel.Id = 5;
            this.btnExportToExcel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "ბეჭვდა";
            this.btnPrint.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Print_32x32;
            this.btnPrint.Id = 15;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_Click);
            // 
            // txtData1
            // 
            this.txtData1.Caption = "საწყისი თარიღი";
            this.txtData1.CategoryGuid = new System.Guid("03b4dee1-ff9b-491c-86eb-3be65c186e35");
            this.txtData1.Edit = this.rtxtData1;
            this.txtData1.EditWidth = 70;
            this.txtData1.Id = 6;
            this.txtData1.Name = "txtData1";
            // 
            // rtxtData1
            // 
            this.rtxtData1.AutoHeight = false;
            this.rtxtData1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData1.Name = "rtxtData1";
            // 
            // txtData2
            // 
            this.txtData2.Caption = "საბოლოო თარიღი";
            this.txtData2.CategoryGuid = new System.Guid("03b4dee1-ff9b-491c-86eb-3be65c186e35");
            this.txtData2.Edit = this.rtxtData2;
            this.txtData2.EditWidth = 70;
            this.txtData2.Id = 8;
            this.txtData2.Name = "txtData2";
            // 
            // rtxtData2
            // 
            this.rtxtData2.AutoHeight = false;
            this.rtxtData2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData2.Name = "rtxtData2";
            // 
            // cbPeriod
            // 
            this.cbPeriod.Caption = "პერიოდი";
            this.cbPeriod.CategoryGuid = new System.Guid("03b4dee1-ff9b-491c-86eb-3be65c186e35");
            this.cbPeriod.Edit = this.rcbPeriod;
            this.cbPeriod.EditWidth = 134;
            this.cbPeriod.Id = 9;
            this.cbPeriod.Name = "cbPeriod";
            // 
            // rcbPeriod
            // 
            this.rcbPeriod.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcbPeriod.Appearance.Options.UseFont = true;
            this.rcbPeriod.AppearanceDropDown.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.rcbPeriod.AppearanceDropDown.Options.UseFont = true;
            this.rcbPeriod.AppearanceFocused.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.rcbPeriod.AppearanceFocused.Options.UseFont = true;
            this.rcbPeriod.AutoHeight = false;
            this.rcbPeriod.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbPeriod.Items.AddRange(new object[] {
            "დღევანდელი",
            "ბოლო 3 დღის",
            "ბოლო კვირა",
            "ბოლო თვე",
            "ბოლო წელი",
            "სრული ინფორმაცია"});
            this.rcbPeriod.Name = "rcbPeriod";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "განახლება";
            this.btnRefresh.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Refresh_32x32;
            this.btnRefresh.Id = 4;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnLayout
            // 
            this.btnLayout.Caption = "ცხრილის სქემა";
            this.btnLayout.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnLayout.Id = 13;
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveDGlayout_Click);
            // 
            // btnLogDelete
            // 
            this.btnLogDelete.Caption = "ისტორიის წაშლა";
            this.btnLogDelete.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Delete_32x32;
            this.btnLogDelete.Id = 17;
            this.btnLogDelete.Name = "btnLogDelete";
            this.btnLogDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogDelete_Click);
            // 
            // cbbtnFillById
            // 
            this.cbbtnFillById.Caption = "ძებნა კოდის მიხედვით";
            this.cbbtnFillById.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_FindById_32x32;
            this.cbbtnFillById.Id = 18;
            this.cbbtnFillById.Name = "cbbtnFillById";
            this.cbbtnFillById.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFillById_Click);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(1174, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 655);
            this.barDockControl2.Size = new System.Drawing.Size(1174, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Size = new System.Drawing.Size(0, 615);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1174, 40);
            this.barDockControl4.Size = new System.Drawing.Size(0, 615);
            // 
            // cmMasterAED
            // 
            this.cmMasterAED.AllowRibbonQATMenu = false;
            this.cmMasterAED.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint)});
            this.cmMasterAED.Manager = this.bmMasterAED;
            this.cmMasterAED.Name = "cmMasterAED";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.dgChange1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dgChange2);
            this.splitContainerControl1.Panel2.Controls.Add(this.barDockControl7);
            this.splitContainerControl1.Panel2.Controls.Add(this.barDockControl8);
            this.splitContainerControl1.Panel2.Controls.Add(this.barDockControl6);
            this.splitContainerControl1.Panel2.Controls.Add(this.barDockControl5);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1174, 615);
            this.splitContainerControl1.SplitterPosition = 348;
            this.splitContainerControl1.TabIndex = 16;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 40);
            this.barDockControl7.Size = new System.Drawing.Size(0, 222);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1174, 40);
            this.barDockControl8.Size = new System.Drawing.Size(0, 222);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 262);
            this.barDockControl6.Size = new System.Drawing.Size(1174, 0);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Size = new System.Drawing.Size(1174, 40);
            // 
            // barBarCode
            // 
            this.barBarCode.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barBarCode.DockControls.Add(this.barDockControl5);
            this.barBarCode.DockControls.Add(this.barDockControl6);
            this.barBarCode.DockControls.Add(this.barDockControl7);
            this.barBarCode.DockControls.Add(this.barDockControl8);
            this.barBarCode.Form = this.splitContainerControl1.Panel2;
            this.barBarCode.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDetExport,
            this.barButtonItem2,
            this.btnImportPocket});
            this.barBarCode.MainMenu = this.bar1;
            this.barBarCode.MaxItemId = 19;
            this.barBarCode.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox5,
            this.repositoryItemTextEdit3,
            this.repositoryItemLookUpEdit3});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetExport)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnDetExport
            // 
            this.btnDetExport.Caption = "ექსელში ექსპორტი";
            this.btnDetExport.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnDetExport.Id = 4;
            this.btnDetExport.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.N));
            this.btnDetExport.Name = "btnDetExport";
            this.btnDetExport.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnDetExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetExport_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Excel-დან ინფორმაციის იმპორტი";
            this.barButtonItem2.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.LargeGlyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnImportPocket
            // 
            this.btnImportPocket.Caption = "მონაცემების იმპორტი ხელის კოპიუტერიდან";
            this.btnImportPocket.Glyph = global::SBS_BarthLogistic.Properties.Resources.ImportPocket;
            this.btnImportPocket.Id = 15;
            this.btnImportPocket.LargeGlyph = global::SBS_BarthLogistic.Properties.Resources.ImportPocket;
            this.btnImportPocket.Name = "btnImportPocket";
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // Change1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 655);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Change1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ტრანზაქციების ისტორია";
            this.Activated += new System.EventHandler(this.Gas1Form_Activated);
            this.Load += new System.EventHandler(this.Gas1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChange2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChange2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmMasterAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgChange1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChange1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChange1;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.GridControl dgChange2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChange2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChange2;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colTableName;
        private DevExpress.XtraGrid.Columns.GridColumn colTableNameText;
        private DevExpress.XtraGrid.Columns.GridColumn colOperType;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colOldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNewValue;
        private DevExpress.XtraGrid.Columns.GridColumn colSql;
        private DevExpress.XtraBars.BarManager bmMasterAED;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarEditItem txtData1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rtxtData1;
        private DevExpress.XtraBars.BarEditItem txtData2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rtxtData2;
        private DevExpress.XtraBars.BarEditItem cbPeriod;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbPeriod;
        private DevExpress.XtraBars.BarButtonItem btnLayout;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.PopupMenu cmMasterAED;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.BarButtonItem btnLogDelete;
        private DevExpress.XtraBars.BarButtonItem cbbtnFillById;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarManager barBarCode;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnDetExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnImportPocket;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
    }
}