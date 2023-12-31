namespace SBS_BarthLogistic.AEDForms
{
    partial class MISubForm
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
            this.dgMISub = new DevExpress.XtraGrid.GridControl();
            this.gvMISub = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMISub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMIMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMISub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForAll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bmMasterAED = new DevExpress.XtraBars.BarManager(this.components);
            this.barMaster = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.cbExcel = new DevExpress.XtraBars.BarEditItem();
            this.rcbExcel = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnLayout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgMISub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMISub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMISub
            // 
            this.dgMISub.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgMISub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMISub.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMISub.Location = new System.Drawing.Point(0, 48);
            this.dgMISub.MainView = this.gvMISub;
            this.dgMISub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMISub.Name = "dgMISub";
            this.dgMISub.Size = new System.Drawing.Size(1357, 586);
            this.dgMISub.TabIndex = 7;
            this.dgMISub.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMISub});
            // 
            // gvMISub
            // 
            this.gvMISub.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvMISub.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMISub.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMISub,
            this.colIdMIMain,
            this.colMISub,
            this.colMIName,
            this.colTableList,
            this.colProcList,
            this.colViewList,
            this.colControlList,
            this.colForAll});
            this.gvMISub.FooterPanelHeight = 1;
            this.gvMISub.GridControl = this.dgMISub;
            this.gvMISub.GroupPanelText = "დაჯგუფება";
            this.gvMISub.GroupRowHeight = 1;
            this.gvMISub.Name = "gvMISub";
            this.gvMISub.OptionsBehavior.Editable = false;
            this.gvMISub.OptionsCustomization.AllowGroup = false;
            this.gvMISub.OptionsDetail.AllowZoomDetail = false;
            this.gvMISub.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvMISub.OptionsSelection.MultiSelect = true;
            this.gvMISub.OptionsView.ColumnAutoWidth = false;
            this.gvMISub.OptionsView.EnableAppearanceOddRow = true;
            this.gvMISub.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvMISub.OptionsView.ShowAutoFilterRow = true;
            this.gvMISub.OptionsView.ShowDetailButtons = false;
            this.gvMISub.OptionsView.ShowFooter = true;
            this.gvMISub.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMISub
            // 
            this.colIdMISub.Caption = "IdMISub";
            this.colIdMISub.FieldName = "IdMISub";
            this.colIdMISub.Name = "colIdMISub";
            this.colIdMISub.Visible = true;
            this.colIdMISub.VisibleIndex = 0;
            // 
            // colIdMIMain
            // 
            this.colIdMIMain.Caption = "IdMIMain";
            this.colIdMIMain.FieldName = "IdMIMain";
            this.colIdMIMain.Name = "colIdMIMain";
            this.colIdMIMain.Visible = true;
            this.colIdMIMain.VisibleIndex = 1;
            // 
            // colMISub
            // 
            this.colMISub.Caption = "MISub";
            this.colMISub.FieldName = "MISub";
            this.colMISub.Name = "colMISub";
            this.colMISub.Visible = true;
            this.colMISub.VisibleIndex = 2;
            this.colMISub.Width = 200;
            // 
            // colMIName
            // 
            this.colMIName.Caption = "MIName";
            this.colMIName.FieldName = "MIName";
            this.colMIName.Name = "colMIName";
            this.colMIName.Visible = true;
            this.colMIName.VisibleIndex = 3;
            this.colMIName.Width = 200;
            // 
            // colTableList
            // 
            this.colTableList.Caption = "TableList";
            this.colTableList.FieldName = "TableList";
            this.colTableList.Name = "colTableList";
            this.colTableList.Visible = true;
            this.colTableList.VisibleIndex = 4;
            this.colTableList.Width = 200;
            // 
            // colProcList
            // 
            this.colProcList.Caption = "ProcList";
            this.colProcList.FieldName = "ProcList";
            this.colProcList.Name = "colProcList";
            this.colProcList.Visible = true;
            this.colProcList.VisibleIndex = 5;
            this.colProcList.Width = 200;
            // 
            // colViewList
            // 
            this.colViewList.Caption = "ViewList";
            this.colViewList.FieldName = "ViewList";
            this.colViewList.Name = "colViewList";
            this.colViewList.Visible = true;
            this.colViewList.VisibleIndex = 6;
            this.colViewList.Width = 200;
            // 
            // colControlList
            // 
            this.colControlList.Caption = "ControlList";
            this.colControlList.FieldName = "ControlList";
            this.colControlList.Name = "colControlList";
            this.colControlList.Visible = true;
            this.colControlList.VisibleIndex = 7;
            this.colControlList.Width = 200;
            // 
            // colForAll
            // 
            this.colForAll.Caption = "ForAll";
            this.colForAll.FieldName = "ForAll";
            this.colForAll.Name = "colForAll";
            this.colForAll.Visible = true;
            this.colForAll.VisibleIndex = 8;
            // 
            // bmMasterAED
            // 
            this.bmMasterAED.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMaster});
            this.bmMasterAED.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Main", new System.Guid("949ba49e-a66a-41de-9695-1cda72c633a9")),
            new DevExpress.XtraBars.BarManagerCategory("Period", new System.Guid("03b4dee1-ff9b-491c-86eb-3be65c186e35")),
            new DevExpress.XtraBars.BarManagerCategory("Other", new System.Guid("6adb5c94-6c4b-466b-a3f4-ce9d9dd253c3"))});
            this.bmMasterAED.DockControls.Add(this.barDockControl1);
            this.bmMasterAED.DockControls.Add(this.barDockControl2);
            this.bmMasterAED.DockControls.Add(this.barDockControl3);
            this.bmMasterAED.DockControls.Add(this.barDockControl4);
            this.bmMasterAED.Form = this;
            this.bmMasterAED.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh,
            this.btnExportToExcel,
            this.btnLayout,
            this.btnCopy,
            this.cbExcel});
            this.bmMasterAED.MainMenu = this.barMaster;
            this.bmMasterAED.MaxItemId = 20;
            this.bmMasterAED.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rcbExcel});
            // 
            // barMaster
            // 
            this.barMaster.BarName = "Main menu";
            this.barMaster.DockCol = 0;
            this.barMaster.DockRow = 0;
            this.barMaster.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMaster.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopy),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLayout, true)});
            this.barMaster.OptionsBar.UseWholeRow = true;
            this.barMaster.Text = "Main menu";
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "ჩამატება";
            this.btnInsert.CategoryGuid = new System.Guid("949ba49e-a66a-41de-9695-1cda72c633a9");
            this.btnInsert.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Add_32x32;
            this.btnInsert.Id = 0;
            this.btnInsert.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "რედაქტირება";
            this.btnEdit.CategoryGuid = new System.Guid("949ba49e-a66a-41de-9695-1cda72c633a9");
            this.btnEdit.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Edit_32x32;
            this.btnEdit.Id = 1;
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "წაშლა";
            this.btnDelete.CategoryGuid = new System.Guid("949ba49e-a66a-41de-9695-1cda72c633a9");
            this.btnDelete.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Delete_32x32;
            this.btnDelete.Id = 2;
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "კოპირება";
            this.btnCopy.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Copy_32x32;
            this.btnCopy.Id = 18;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "განახლება";
            this.btnRefresh.CategoryGuid = new System.Guid("949ba49e-a66a-41de-9695-1cda72c633a9");
            this.btnRefresh.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Refresh_32x32;
            this.btnRefresh.Id = 4;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // cbExcel
            // 
            this.cbExcel.Caption = "barEditItem1";
            this.cbExcel.Edit = this.rcbExcel;
            this.cbExcel.Id = 19;
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Width = 200;
            // 
            // rcbExcel
            // 
            this.rcbExcel.AutoHeight = false;
            this.rcbExcel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbExcel.Name = "rcbExcel";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Caption = "ექსელში ექსპორტი";
            this.btnExportToExcel.CategoryGuid = new System.Guid("949ba49e-a66a-41de-9695-1cda72c633a9");
            this.btnExportToExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnExportToExcel.Id = 5;
            this.btnExportToExcel.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_Click);
            // 
            // btnLayout
            // 
            this.btnLayout.Caption = "რიბონის სახელების გამოჩენა";
            this.btnLayout.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnLayout.Id = 13;
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLayout_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl1.Size = new System.Drawing.Size(1357, 48);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 634);
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl2.Size = new System.Drawing.Size(1357, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 48);
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 586);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1357, 48);
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 586);
            // 
            // MISubForm
            // 
            this.ClientSize = new System.Drawing.Size(1357, 634);
            this.Controls.Add(this.dgMISub);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            
            this.Name = "MISubForm";
            this.Load += new System.EventHandler(this.MISubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMISub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMISub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgMISub;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMISub;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMISub;
        private DevExpress.XtraGrid.Columns.GridColumn colMIName;
        private DevExpress.XtraGrid.Columns.GridColumn colProcList;
        private DevExpress.XtraGrid.Columns.GridColumn colTableList;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMIMain;
        private DevExpress.XtraGrid.Columns.GridColumn colMISub;
        private DevExpress.XtraGrid.Columns.GridColumn colViewList;
        private DevExpress.XtraGrid.Columns.GridColumn colControlList;
        private DevExpress.XtraGrid.Columns.GridColumn colForAll;
        private DevExpress.XtraBars.BarManager bmMasterAED;
        private DevExpress.XtraBars.Bar barMaster;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        private DevExpress.XtraBars.BarButtonItem btnLayout;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarEditItem cbExcel;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbExcel;
    }
}