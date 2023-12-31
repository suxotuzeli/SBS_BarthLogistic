namespace SBS_BarthLogistic.AEDForms
{
    partial class AdminCnobariForm
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
            this.dgAdminCnobari = new DevExpress.XtraGrid.GridControl();
            this.gvAdminCnobari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAdminCnobari = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminCnobari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdminCnobari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAdminCnobari
            // 
            this.dgAdminCnobari.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAdminCnobari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAdminCnobari.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgAdminCnobari.Location = new System.Drawing.Point(0, 48);
            this.dgAdminCnobari.MainView = this.gvAdminCnobari;
            this.dgAdminCnobari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgAdminCnobari.Name = "dgAdminCnobari";
            this.dgAdminCnobari.Size = new System.Drawing.Size(1269, 535);
            this.dgAdminCnobari.TabIndex = 7;
            this.dgAdminCnobari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdminCnobari});
            // 
            // gvAdminCnobari
            // 
            this.gvAdminCnobari.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvAdminCnobari.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAdminCnobari.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFieldName,
            this.colShen,
            this.colIdAdminCnobari});
            this.gvAdminCnobari.FooterPanelHeight = 1;
            this.gvAdminCnobari.GridControl = this.dgAdminCnobari;
            this.gvAdminCnobari.GroupPanelText = "დაჯგუფება";
            this.gvAdminCnobari.GroupRowHeight = 1;
            this.gvAdminCnobari.Name = "gvAdminCnobari";
            this.gvAdminCnobari.OptionsBehavior.Editable = false;
            this.gvAdminCnobari.OptionsCustomization.AllowGroup = false;
            this.gvAdminCnobari.OptionsDetail.AllowZoomDetail = false;
            this.gvAdminCnobari.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvAdminCnobari.OptionsSelection.MultiSelect = true;
            this.gvAdminCnobari.OptionsView.ColumnAutoWidth = false;
            this.gvAdminCnobari.OptionsView.EnableAppearanceOddRow = true;
            this.gvAdminCnobari.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvAdminCnobari.OptionsView.ShowAutoFilterRow = true;
            this.gvAdminCnobari.OptionsView.ShowDetailButtons = false;
            this.gvAdminCnobari.OptionsView.ShowFooter = true;
            this.gvAdminCnobari.OptionsView.ShowGroupPanel = false;
            // 
            // colFieldName
            // 
            this.colFieldName.Caption = "ველის სახელი";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 0;
            this.colFieldName.Width = 250;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Width = 200;
            // 
            // colIdAdminCnobari
            // 
            this.colIdAdminCnobari.Caption = "#";
            this.colIdAdminCnobari.FieldName = "IdAdminCnobari";
            this.colIdAdminCnobari.Name = "colIdAdminCnobari";
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
            this.cbExcel.Caption = "ექსელი";
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
            this.btnLayout.Caption = "ცხრილის სქემა";
            this.btnLayout.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_CustomizeGrid_32x32;
            this.btnLayout.Id = 13;
            this.btnLayout.Name = "btnLayout";
            this.btnLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowCaption_Click);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl1.Size = new System.Drawing.Size(1269, 48);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 583);
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl2.Size = new System.Drawing.Size(1269, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 48);
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl3.Size = new System.Drawing.Size(0, 535);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1269, 48);
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 535);
            // 
            // AdminCnobariForm
            // 
            this.ClientSize = new System.Drawing.Size(1269, 583);
            this.Controls.Add(this.dgAdminCnobari);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            
            this.Name = "AdminCnobariForm";
            this.Text = "Language";
            this.Activated += new System.EventHandler(this.AdminCnobariForm_Activated);
            this.Load += new System.EventHandler(this.AdminCnobariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminCnobari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdminCnobari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMasterAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgAdminCnobari;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdminCnobari;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAdminCnobari;
        private DevExpress.XtraBars.BarManager bmMasterAED;
        private DevExpress.XtraBars.Bar barMaster;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarEditItem cbExcel;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbExcel;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        private DevExpress.XtraBars.BarButtonItem btnLayout;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
    }
}