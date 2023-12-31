namespace SBS_BarthLogistic.AEDForms
{
    partial class AedAllForm
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
            this.dg = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bmAED = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cmAED = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmAED)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg.Location = new System.Drawing.Point(0, 50);
            this.dg.MainView = this.gv;
            this.dg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(881, 511);
            this.dg.TabIndex = 5;
            this.dg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            this.dg.DoubleClick += new System.EventHandler(this.dg_DoubleClick);
            // 
            // gv
            // 
            this.gv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gv.Appearance.HeaderPanel.Options.UseFont = true;
            this.gv.FooterPanelHeight = 1;
            this.gv.GridControl = this.dg;
            this.gv.GroupPanelText = "დაჯგუფება";
            this.gv.GroupRowHeight = 1;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.Editable = false;
            this.gv.OptionsDetail.AllowZoomDetail = false;
            this.gv.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gv.OptionsView.ColumnAutoWidth = false;
            this.gv.OptionsView.EnableAppearanceOddRow = true;
            this.gv.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gv.OptionsView.ShowAutoFilterRow = true;
            this.gv.OptionsView.ShowChildrenInGroupPanel = true;
            this.gv.OptionsView.ShowDetailButtons = false;
            this.gv.OptionsView.ShowFooter = true;
            this.gv.OptionsView.ShowGroupedColumns = true;
            this.gv.OptionsView.ShowGroupPanel = false;
            // 
            // bmAED
            // 
            this.bmAED.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.bmAED.DockControls.Add(this.barDockControlTop);
            this.bmAED.DockControls.Add(this.barDockControlBottom);
            this.bmAED.DockControls.Add(this.barDockControlLeft);
            this.bmAED.DockControls.Add(this.barDockControlRight);
            this.bmAED.Form = this;
            this.bmAED.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.btnCopy,
            this.btnRefresh,
            this.btnExportToExcel});
            this.bmAED.MainMenu = this.bar2;
            this.bmAED.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopy, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel)});
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "ჩამატება";
            this.btnInsert.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Add_32x32;
            this.btnInsert.Id = 0;
            this.btnInsert.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsert_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "რედაქტირება";
            this.btnEdit.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Edit_32x32;
            this.btnEdit.Id = 1;
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "წაშლა";
            this.btnDelete.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Delete_32x32;
            this.btnDelete.Id = 2;
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "კოპირება";
            this.btnCopy.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Copy_32x32;
            this.btnCopy.Id = 3;
            this.btnCopy.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C));
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "განახლება";
            this.btnRefresh.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Refresh_32x32;
            this.btnRefresh.Id = 4;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Caption = "Excel-ში ექსპორტი";
            this.btnExportToExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnExportToExcel.Id = 5;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(881, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 561);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(881, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(881, 50);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // cmAED
            // 
            this.cmAED.AllowRibbonQATMenu = false;
            this.cmAED.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopy, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel)});
            this.cmAED.Manager = this.bmAED;
            this.cmAED.Name = "cmAED";
            // 
            // AedAllForm
            // 
            this.ClientSize = new System.Drawing.Size(881, 561);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            
            this.Name = "AedAllForm";
            this.Text = "პროექტი";
            this.Activated += new System.EventHandler(this.AEDForm_Activated);
            this.Load += new System.EventHandler(this.AEDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmAED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dg;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraBars.BarManager bmAED;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        private DevExpress.XtraBars.PopupMenu cmAED;
    }
}