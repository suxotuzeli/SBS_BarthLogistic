namespace SBS_BarthLogistic.AEDForms
{
    partial class SalForm
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
            if (disposing && (components != null))
            {
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
            this.dgSal = new DevExpress.XtraGrid.GridControl();
            this.gvSal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZedd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGvari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGvariT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalaro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barSal = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.txtData1 = new DevExpress.XtraBars.BarEditItem();
            this.rtxtData1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtData2 = new DevExpress.XtraBars.BarEditItem();
            this.rtxtData2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cbPeriod = new DevExpress.XtraBars.BarEditItem();
            this.rcbPeriod = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintSalZedd = new DevExpress.XtraBars.BarButtonItem();
            this.btnFind = new DevExpress.XtraBars.BarButtonItem();
            this.btnFilterWithFindID = new DevExpress.XtraBars.BarButtonItem();
            this.btnLayout = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowLog = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.popSal = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSal
            // 
            this.dgSal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSal.Location = new System.Drawing.Point(0, 40);
            this.dgSal.MainView = this.gvSal;
            this.dgSal.Name = "dgSal";
            this.dgSal.Size = new System.Drawing.Size(1220, 505);
            this.dgSal.TabIndex = 5;
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
            this.colSalT,
            this.colShen,
            this.colSal,
            this.colIdGvari,
            this.colGvariT,
            this.colUN,
            this.colCD,
            this.colSalaro,
            this.colTanxa});
            this.gvSal.FooterPanelHeight = 1;
            this.gvSal.GridControl = this.dgSal;
            this.gvSal.GroupPanelText = "დაჯგუფება";
            this.gvSal.GroupRowHeight = 1;
            this.gvSal.Name = "gvSal";
            this.gvSal.OptionsBehavior.AllowIncrementalSearch = true;
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
            this.colIdSal.Caption = "#";
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
            this.colData.Width = 82;
            // 
            // colZedd
            // 
            this.colZedd.Caption = "ზედდებული";
            this.colZedd.FieldName = "Zedd";
            this.colZedd.Name = "colZedd";
            this.colZedd.Visible = true;
            this.colZedd.VisibleIndex = 4;
            this.colZedd.Width = 106;
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
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 8;
            this.colShen.Width = 174;
            // 
            // colSal
            // 
            this.colSal.Caption = "მყიდველი";
            this.colSal.FieldName = "Org";
            this.colSal.Name = "colSal";
            this.colSal.Visible = true;
            this.colSal.VisibleIndex = 1;
            this.colSal.Width = 204;
            // 
            // colIdGvari
            // 
            this.colIdGvari.Caption = "მყიდვ. კოდი";
            this.colIdGvari.FieldName = "IdGvari";
            this.colIdGvari.Name = "colIdGvari";
            this.colIdGvari.Visible = true;
            this.colIdGvari.VisibleIndex = 6;
            this.colIdGvari.Width = 101;
            // 
            // colGvariT
            // 
            this.colGvariT.Caption = "მყიდველის ტიპი";
            this.colGvariT.FieldName = "GvariT";
            this.colGvariT.Name = "colGvariT";
            this.colGvariT.Visible = true;
            this.colGvariT.VisibleIndex = 7;
            this.colGvariT.Width = 130;
            // 
            // colUN
            // 
            this.colUN.Caption = "მომხმარებელი";
            this.colUN.FieldName = "UN";
            this.colUN.Name = "colUN";
            this.colUN.Visible = true;
            this.colUN.VisibleIndex = 9;
            this.colUN.Width = 116;
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
            this.colCD.Width = 107;
            // 
            // colSalaro
            // 
            this.colSalaro.Caption = "სალარო";
            this.colSalaro.FieldName = "Salaro";
            this.colSalaro.Name = "colSalaro";
            this.colSalaro.Visible = true;
            this.colSalaro.VisibleIndex = 2;
            this.colSalaro.Width = 103;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "{0:0.00##}";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tanxa", "{0:0.00##}")});
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 3;
            // 
            // barSal
            // 
            this.barSal.AutoSaveInRegistry = true;
            this.barSal.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barSal.DockControls.Add(this.barDockControl5);
            this.barSal.DockControls.Add(this.barDockControl6);
            this.barSal.DockControls.Add(this.barDockControl7);
            this.barSal.DockControls.Add(this.barDockControl8);
            this.barSal.Form = this;
            this.barSal.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.btnCopy,
            this.btnRefresh,
            this.txtData1,
            this.txtData2,
            this.cbPeriod,
            this.btnLayout,
            this.btnFilterWithFindID,
            this.btnShowLog,
            this.btnPrintSalZedd,
            this.btnFind});
            this.barSal.MainMenu = this.bar1;
            this.barSal.MaxItemId = 36;
            this.barSal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtData1,
            this.rtxtData2,
            this.rcbPeriod});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(286, 168);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtData1),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtData2),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbPeriod),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintSalZedd, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFind),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFilterWithFindID),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLayout, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowLog)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "ახალი ჩანაწერი";
            this.btnInsert.Id = 4;
            this.btnInsert.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Add_32x32;
            this.btnInsert.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsert_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "რედაქტირება";
            this.btnEdit.Id = 5;
            this.btnEdit.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Edit_32x32;
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "წაშლა";
            this.btnDelete.Id = 6;
            this.btnDelete.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Delete_32x32;
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "კოპირება";
            this.btnCopy.Id = 12;
            this.btnCopy.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Copy_32x32;
            this.btnCopy.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C));
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // txtData1
            // 
            this.txtData1.Caption = "საწყისი თარიღი";
            this.txtData1.Edit = this.rtxtData1;
            this.txtData1.EditWidth = 70;
            this.txtData1.Id = 16;
            this.txtData1.Name = "txtData1";
            // 
            // rtxtData1
            // 
            this.rtxtData1.AutoHeight = false;
            this.rtxtData1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData1.DisplayFormat.FormatString = "d.M.yyyy";
            this.rtxtData1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rtxtData1.EditFormat.FormatString = "d.M.yyyy";
            this.rtxtData1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rtxtData1.Mask.EditMask = "d.M.yyyy";
            this.rtxtData1.Name = "rtxtData1";
            // 
            // txtData2
            // 
            this.txtData2.Caption = "საბოლოო თარიღი";
            this.txtData2.Edit = this.rtxtData2;
            this.txtData2.EditWidth = 67;
            this.txtData2.Id = 17;
            this.txtData2.Name = "txtData2";
            // 
            // rtxtData2
            // 
            this.rtxtData2.AutoHeight = false;
            this.rtxtData2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rtxtData2.DisplayFormat.FormatString = "d.M.yyyy";
            this.rtxtData2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rtxtData2.EditFormat.FormatString = "d.M.yyyy";
            this.rtxtData2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rtxtData2.Mask.EditMask = "d.M.yyyy";
            this.rtxtData2.Name = "rtxtData2";
            // 
            // cbPeriod
            // 
            this.cbPeriod.Caption = "პერიოდი";
            this.cbPeriod.Edit = this.rcbPeriod;
            this.cbPeriod.EditWidth = 146;
            this.cbPeriod.Id = 18;
            this.cbPeriod.Name = "cbPeriod";
            // 
            // rcbPeriod
            // 
            this.rcbPeriod.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcbPeriod.Appearance.Options.UseFont = true;
            this.rcbPeriod.AppearanceDropDown.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcbPeriod.AppearanceDropDown.Options.UseFont = true;
            this.rcbPeriod.AppearanceFocused.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcbPeriod.AppearanceFocused.Options.UseFont = true;
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
            this.btnRefresh.Id = 13;
            this.btnRefresh.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Refresh_32x32;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnPrintSalZedd
            // 
            this.btnPrintSalZedd.Caption = "სალაროს შემოსავლის ორდერის ბეჭდვა";
            this.btnPrintSalZedd.Id = 31;
            this.btnPrintSalZedd.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Print_32x32;
            this.btnPrintSalZedd.Name = "btnPrintSalZedd";
            this.btnPrintSalZedd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintSalZedd_ItemClick);
            // 
            // btnFind
            // 
            this.btnFind.Caption = "ძებნა";
            this.btnFind.Id = 32;
            this.btnFind.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Find_32x32;
            this.btnFind.Name = "btnFind";
            this.btnFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFind_ItemClick);
            // 
            // btnFilterWithFindID
            // 
            this.btnFilterWithFindID.Caption = "მოძებნილზე გადასვლა";
            this.btnFilterWithFindID.Id = 28;
            this.btnFilterWithFindID.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_FindById_32x32;
            this.btnFilterWithFindID.Name = "btnFilterWithFindID";
            this.btnFilterWithFindID.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFilterWithFindID_ItemClick);
            // 
            // btnLayout
            // 
            this.btnLayout.Caption = "სქემის აღდგენა";
            this.btnLayout.Id = 24;
            this.btnLayout.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLayout_ItemClick);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Caption = "წაშლილი ჩანაწერების ნახვა";
            this.btnShowLog.Id = 30;
            this.btnShowLog.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_History_32x32;
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowLog_ItemClick);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Manager = this.barSal;
            this.barDockControl5.Size = new System.Drawing.Size(1220, 40);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl6.Location = new System.Drawing.Point(0, 545);
            this.barDockControl6.Manager = this.barSal;
            this.barDockControl6.Size = new System.Drawing.Size(1220, 0);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl7.Location = new System.Drawing.Point(0, 40);
            this.barDockControl7.Manager = this.barSal;
            this.barDockControl7.Size = new System.Drawing.Size(0, 505);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl8.Location = new System.Drawing.Point(1220, 40);
            this.barDockControl8.Manager = this.barSal;
            this.barDockControl8.Size = new System.Drawing.Size(0, 505);
            // 
            // popSal
            // 
            this.popSal.AllowRibbonQATMenu = false;
            this.popSal.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopy, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.popSal.Manager = this.barSal;
            this.popSal.Name = "popSal";
            // 
            // SalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 545);
            this.Controls.Add(this.dgSal);
            this.Controls.Add(this.barDockControl7);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControl6);
            this.Controls.Add(this.barDockControl5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalForm";
            this.Text = "SalForm";
            this.Load += new System.EventHandler(this.SalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtData2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgSal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSal;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colZedd;
        private DevExpress.XtraGrid.Columns.GridColumn colSalT;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colGvariT;
        private DevExpress.XtraGrid.Columns.GridColumn colUN;
        private DevExpress.XtraGrid.Columns.GridColumn colCD;
        private DevExpress.XtraGrid.Columns.GridColumn colSalaro;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colSal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGvari;
        private DevExpress.XtraBars.BarManager barSal;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarEditItem txtData1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rtxtData1;
        private DevExpress.XtraBars.BarEditItem txtData2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rtxtData2;
        private DevExpress.XtraBars.BarEditItem cbPeriod;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbPeriod;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnPrintSalZedd;
        private DevExpress.XtraBars.BarButtonItem btnFind;
        private DevExpress.XtraBars.BarButtonItem btnFilterWithFindID;
        private DevExpress.XtraBars.BarButtonItem btnLayout;
        private DevExpress.XtraBars.BarButtonItem btnShowLog;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.PopupMenu popSal;
    }
}