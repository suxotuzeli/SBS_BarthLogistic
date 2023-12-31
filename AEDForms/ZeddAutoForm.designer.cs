namespace SBS_BarthLogistic.AEDForms
{
    partial class ZeddAutoForm
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
            this.bmAED = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.cbExcel = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowLog = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dgZeddAuto = new DevExpress.XtraGrid.GridControl();
            this.gvZeddAuto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdZeddAuto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTableDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrefics = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSufics = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bmAED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgZeddAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvZeddAuto)).BeginInit();
            this.SuspendLayout();
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
            this.btnExcel,
            this.barEditItem3,
            this.btnShowLog,
            this.barButtonItem2,
            this.cbExcel});
            this.bmAED.MainMenu = this.bar2;
            this.bmAED.MaxItemId = 11;
            this.bmAED.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(51, 116);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopy, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShowLog)});
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "ჩამატება";
            this.btnInsert.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Add_32x32;
            this.btnInsert.Id = 0;
            this.btnInsert.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "კოპირება";
            this.btnCopy.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Copy_32x32;
            this.btnCopy.Id = 3;
            this.btnCopy.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "განახლება";
            this.btnRefresh.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_Refresh_32x32;
            this.btnRefresh.Id = 4;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // cbExcel
            // 
            this.cbExcel.Caption = "ფაილის სახელი";
            this.cbExcel.Edit = this.repositoryItemComboBox2;
            this.cbExcel.Id = 10;
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.cbExcel.Width = 119;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excel-ში ექსპორტი";
            this.btnExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnExcel.Id = 5;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_ItemClick);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Caption = "წაშლილი ჩანაწერების ნახვა";
            this.btnShowLog.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_History_32x32;
            this.btnShowLog.Id = 30;
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnShowLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowLog_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(950, 48);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 640);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(950, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(950, 48);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 592);
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemComboBox1;
            this.barEditItem3.Id = 6;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 116;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // popupMenu1
            // 
            this.popupMenu1.AllowRibbonQATMenu = false;
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopy, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel)});
            this.popupMenu1.Manager = this.bmAED;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // dg
            // 
            this.dgZeddAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgZeddAuto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgZeddAuto.Location = new System.Drawing.Point(0, 48);
            this.dgZeddAuto.MainView = this.gvZeddAuto;
            this.dgZeddAuto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgZeddAuto.Name = "dgZeddAuto";
            this.dgZeddAuto.Size = new System.Drawing.Size(950, 592);
            this.dgZeddAuto.TabIndex = 18;
            this.dgZeddAuto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvZeddAuto});
            // 
            // gvZeddAuto
            // 
            this.gvZeddAuto.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvZeddAuto.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvZeddAuto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdZeddAuto,
            this.colTableDesc,
            this.colPrefics,
            this.colSufics,
            this.colNum,
            this.colActive});
            this.gvZeddAuto.FooterPanelHeight = 1;
            this.gvZeddAuto.GridControl = this.dgZeddAuto;
            this.gvZeddAuto.GroupPanelText = "დაჯგუფება";
            this.gvZeddAuto.GroupRowHeight = 1;
            this.gvZeddAuto.Name = "gvZeddAuto";
            this.gvZeddAuto.OptionsBehavior.Editable = false;
            this.gvZeddAuto.OptionsDetail.AllowZoomDetail = false;
            this.gvZeddAuto.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvZeddAuto.OptionsView.ColumnAutoWidth = false;
            this.gvZeddAuto.OptionsView.EnableAppearanceOddRow = true;
            this.gvZeddAuto.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvZeddAuto.OptionsView.ShowAutoFilterRow = true;
            this.gvZeddAuto.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvZeddAuto.OptionsView.ShowDetailButtons = false;
            this.gvZeddAuto.OptionsView.ShowFooter = true;
            this.gvZeddAuto.OptionsView.ShowGroupedColumns = true;
            this.gvZeddAuto.OptionsView.ShowGroupPanel = false;
            // 
            // colIdZeddAuto
            // 
            this.colIdZeddAuto.Caption = "კოდი";
            this.colIdZeddAuto.FieldName = "IdZeddAuto";
            this.colIdZeddAuto.Name = "colIdZeddAuto";
            this.colIdZeddAuto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "idZeddAuto", "")});
            // 
            // colTableDesc
            // 
            this.colTableDesc.AppearanceCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colTableDesc.AppearanceCell.Options.UseFont = true;
            this.colTableDesc.Caption = "ცხრილი";
            this.colTableDesc.FieldName = "TableDesc";
            this.colTableDesc.Name = "colTableDesc";
            this.colTableDesc.Visible = true;
            this.colTableDesc.VisibleIndex = 0;
            this.colTableDesc.Width = 269;
            // 
            // colPrefics
            // 
            this.colPrefics.Caption = "პრეფიქსი";
            this.colPrefics.FieldName = "Prefics";
            this.colPrefics.Name = "colPrefics";
            this.colPrefics.Visible = true;
            this.colPrefics.VisibleIndex = 1;
            // 
            // colSufics
            // 
            this.colSufics.Caption = "სუფიქსი";
            this.colSufics.FieldName = "Sufics";
            this.colSufics.Name = "colSufics";
            this.colSufics.Visible = true;
            this.colSufics.VisibleIndex = 2;
            this.colSufics.Width = 74;
            // 
            // colNum
            // 
            this.colNum.Caption = "ნომერი";
            this.colNum.FieldName = "Num";
            this.colNum.Name = "colNum";
            this.colNum.Visible = true;
            this.colNum.VisibleIndex = 3;
            // 
            // colActive
            // 
            this.colActive.Caption = "აქტიურია?";
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            // 
            // ZeddAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 640);
            this.Controls.Add(this.dgZeddAuto);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            
            this.Name = "ZeddAutoForm";
            this.Activated += new System.EventHandler(this.ZeddAutoForm_Activated);
            this.Load += new System.EventHandler(this.ZeddAutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmAED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgZeddAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvZeddAuto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager bmAED;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnShowLog;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarEditItem cbExcel;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.GridControl dgZeddAuto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvZeddAuto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdZeddAuto;
        private DevExpress.XtraGrid.Columns.GridColumn colTableDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colPrefics;
        private DevExpress.XtraGrid.Columns.GridColumn colSufics;
        private DevExpress.XtraGrid.Columns.GridColumn colNum;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}