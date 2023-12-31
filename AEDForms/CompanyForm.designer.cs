namespace SBS_BarthLogistic.AEDForms
{
    partial class CompanyForm
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
            this.dgCompany = new DevExpress.XtraGrid.GridControl();
            this.gvCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyDirek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSagad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barCompany = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.cbExcel = new DevExpress.XtraBars.BarEditItem();
            this.btnExportToExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowLog = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.popCompany = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCompany
            // 
            this.dgCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCompany.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgCompany.Location = new System.Drawing.Point(0, 48);
            this.dgCompany.MainView = this.gvCompany;
            this.dgCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgCompany.Name = "dgCompany";
            this.dgCompany.Size = new System.Drawing.Size(1153, 549);
            this.dgCompany.TabIndex = 4;
            this.dgCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompany});
            // 
            // gvCompany
            // 
            this.gvCompany.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvCompany.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCompany,
            this.colCompany,
            this.colCompanyName,
            this.colCompanyAddress,
            this.colCompanyPhone,
            this.colCompanyContact,
            this.colCompanyDirek,
            this.colServiceUser,
            this.colCompanyIP,
            this.ColSagad});
            this.gvCompany.CustomizationFormBounds = new System.Drawing.Rectangle(861, 484, 208, 191);
            this.gvCompany.FooterPanelHeight = 1;
            this.gvCompany.GridControl = this.dgCompany;
            this.gvCompany.GroupPanelText = "დაჯგუფება";
            this.gvCompany.GroupRowHeight = 1;
            this.gvCompany.Name = "gvCompany";
            this.gvCompany.OptionsBehavior.Editable = false;
            this.gvCompany.OptionsDetail.AllowZoomDetail = false;
            this.gvCompany.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvCompany.OptionsView.ColumnAutoWidth = false;
            this.gvCompany.OptionsView.EnableAppearanceOddRow = true;
            this.gvCompany.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvCompany.OptionsView.ShowAutoFilterRow = true;
            this.gvCompany.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvCompany.OptionsView.ShowDetailButtons = false;
            this.gvCompany.OptionsView.ShowFooter = true;
            this.gvCompany.OptionsView.ShowGroupedColumns = true;
            this.gvCompany.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCompany
            // 
            this.colIdCompany.Caption = "კოდი";
            this.colIdCompany.FieldName = "IdCompany";
            this.colIdCompany.Name = "colIdCompany";
            this.colIdCompany.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "idCompany", "")});
            this.colIdCompany.Visible = true;
            this.colIdCompany.VisibleIndex = 0;
            this.colIdCompany.Width = 60;
            // 
            // colCompany
            // 
            this.colCompany.Caption = "კომპანია (მოკლე დასახელება)";
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 1;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "კომანიის დასახელება";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 3;
            this.colCompanyName.Width = 151;
            // 
            // colCompanyAddress
            // 
            this.colCompanyAddress.Caption = "მისამართი";
            this.colCompanyAddress.FieldName = "CompanyAddress";
            this.colCompanyAddress.Name = "colCompanyAddress";
            this.colCompanyAddress.Visible = true;
            this.colCompanyAddress.VisibleIndex = 4;
            this.colCompanyAddress.Width = 146;
            // 
            // colCompanyPhone
            // 
            this.colCompanyPhone.Caption = "ტელეფონი";
            this.colCompanyPhone.FieldName = "CompanyPhone";
            this.colCompanyPhone.Name = "colCompanyPhone";
            this.colCompanyPhone.Visible = true;
            this.colCompanyPhone.VisibleIndex = 7;
            this.colCompanyPhone.Width = 84;
            // 
            // colCompanyContact
            // 
            this.colCompanyContact.Caption = "საკონტაქტო პირი";
            this.colCompanyContact.FieldName = "CompanyContact";
            this.colCompanyContact.Name = "colCompanyContact";
            this.colCompanyContact.Visible = true;
            this.colCompanyContact.VisibleIndex = 6;
            this.colCompanyContact.Width = 133;
            // 
            // colCompanyDirek
            // 
            this.colCompanyDirek.Caption = "დირექტორი";
            this.colCompanyDirek.FieldName = "CompanyDirek";
            this.colCompanyDirek.Name = "colCompanyDirek";
            this.colCompanyDirek.Visible = true;
            this.colCompanyDirek.VisibleIndex = 5;
            this.colCompanyDirek.Width = 116;
            // 
            // colServiceUser
            // 
            this.colServiceUser.Caption = "სერვისის მომხმარებელი";
            this.colServiceUser.FieldName = "ServiceUser";
            this.colServiceUser.Name = "colServiceUser";
            this.colServiceUser.Visible = true;
            this.colServiceUser.VisibleIndex = 8;
            // 
            // colCompanyIP
            // 
            this.colCompanyIP.Caption = "IP Address";
            this.colCompanyIP.FieldName = "CompanyIP";
            this.colCompanyIP.Name = "colCompanyIP";
            this.colCompanyIP.Visible = true;
            this.colCompanyIP.VisibleIndex = 9;
            // 
            // ColSagad
            // 
            this.ColSagad.Caption = "საიდენტიფიკაციო კოდი";
            this.ColSagad.FieldName = "CompanySagad";
            this.ColSagad.Name = "ColSagad";
            this.ColSagad.Visible = true;
            this.ColSagad.VisibleIndex = 2;
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            // 
            // barCompany
            // 
            this.barCompany.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barCompany.DockControls.Add(this.barDockControlTop);
            this.barCompany.DockControls.Add(this.barDockControlBottom);
            this.barCompany.DockControls.Add(this.barDockControlLeft);
            this.barCompany.DockControls.Add(this.barDockControlRight);
            this.barCompany.Form = this;
            this.barCompany.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.btnCopy,
            this.btnRefresh,
            this.btnExportToExcel,
            this.cbExcel,
            this.btnShowLog});
            this.barCompany.MainMenu = this.bar2;
            this.barCompany.MaxItemId = 9;
            this.barCompany.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel),
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
            this.btnCopy.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
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
            // cbExcel
            // 
            this.cbExcel.Caption = "ფაილის სახელი";
            this.cbExcel.Edit = this.repositoryItemComboBox5;
            this.cbExcel.Id = 40;
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Width = 100;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Caption = "Excel-ში ექსპორტი";
            this.btnExportToExcel.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnExportToExcel.Id = 5;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_ItemClick);
            // 
            // btnShowLog
            // 
            this.btnShowLog.Caption = "წაშლილი ჩანაწერების ნახვა";
            this.btnShowLog.Glyph = global::SBS_BarthLogistic.Properties.Resources.AED_History_32x32;
            this.btnShowLog.Id = 30;
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowLog_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1153, 48);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 597);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1153, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 549);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1153, 48);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 549);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // popCompany
            // 
            this.popCompany.AllowRibbonQATMenu = false;
            this.popCompany.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInsert, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCopy, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToExcel)});
            this.popCompany.Manager = this.barCompany;
            this.popCompany.Name = "popCompany";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "ფაილის სახელი";
            this.barEditItem1.Edit = null;
            this.barEditItem1.Id = 40;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 100;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "ფაილის სახელი";
            this.barEditItem2.Edit = null;
            this.barEditItem2.Id = 40;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 100;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 597);
            this.Controls.Add(this.dgCompany);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            
            this.Name = "CompanyForm";
            this.Text = "პროექტი";
            this.Activated += new System.EventHandler(this.CompanyForm_Activated);
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyContact;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyDirek;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyIP;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn ColSagad;
        private DevExpress.XtraBars.BarManager barCompany;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;

        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popCompany;
        private DevExpress.XtraBars.BarEditItem cbExcel;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraBars.BarButtonItem btnShowLog;
    }
}