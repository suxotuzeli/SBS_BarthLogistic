using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AEDForms
{
    partial class ProekForm
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
            this.barProek = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.popProek = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dgProek = new DevExpress.XtraGrid.GridControl();
            this.gvProek = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCustomClearance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barProek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popProek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProek)).BeginInit();
            this.SuspendLayout();
            // 
            // barProek
            // 
            this.barProek.AutoSaveInRegistry = true;
            this.barProek.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barProek.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Main", new System.Guid("52f40308-4f2f-4616-bf7b-f3565cddd384"))});
            this.barProek.DockControls.Add(this.barDockControlTop);
            this.barProek.DockControls.Add(this.barDockControlBottom);
            this.barProek.DockControls.Add(this.barDockControlLeft);
            this.barProek.DockControls.Add(this.barDockControlRight);
            this.barProek.Form = this;
            this.barProek.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInsert,
            this.btnEdit,
            this.btnDelete,
            this.btnCopy});
            this.barProek.MainMenu = this.bar1;
            this.barProek.MaxItemId = 62;
            this.barProek.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox2,
            this.repositoryItemTextEdit2,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemDateEdit3,
            this.repositoryItemDateEdit4,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4});
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(58, 131);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "დამატება";
            this.btnInsert.CategoryGuid = new System.Guid("52f40308-4f2f-4616-bf7b-f3565cddd384");
            this.btnInsert.Id = 4;
            this.btnInsert.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Add_32x32;
            this.btnInsert.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsert_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "რედაქტირება";
            this.btnEdit.CategoryGuid = new System.Guid("52f40308-4f2f-4616-bf7b-f3565cddd384");
            this.btnEdit.Id = 5;
            this.btnEdit.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Edit_32x32;
            this.btnEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "წაშლა";
            this.btnDelete.CategoryGuid = new System.Guid("52f40308-4f2f-4616-bf7b-f3565cddd384");
            this.btnDelete.Id = 6;
            this.btnDelete.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Delete_32x32;
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barProek;
            this.barDockControlTop.Size = new System.Drawing.Size(994, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 612);
            this.barDockControlBottom.Manager = this.barProek;
            this.barDockControlBottom.Size = new System.Drawing.Size(994, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barProek;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 572);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(994, 40);
            this.barDockControlRight.Manager = this.barProek;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 572);
            // 
            // btnCopy
            // 
            this.btnCopy.Caption = "კოპირება";
            this.btnCopy.CategoryGuid = new System.Guid("52f40308-4f2f-4616-bf7b-f3565cddd384");
            this.btnCopy.Id = 12;
            this.btnCopy.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Copy_32x32;
            this.btnCopy.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C));
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopy_ItemClick);
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.DisplayFormat.FormatString = "d.M.yyyy";
            this.repositoryItemDateEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.EditFormat.FormatString = "d.M.yyyy";
            this.repositoryItemDateEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.Mask.EditMask = "d.M.yyyy";
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.DisplayFormat.FormatString = "d.M.yyyy";
            this.repositoryItemDateEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit4.EditFormat.FormatString = "d.M.yyyy";
            this.repositoryItemDateEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit4.Mask.EditMask = "d.M.yyyy";
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemComboBox3.Appearance.Options.UseFont = true;
            this.repositoryItemComboBox3.AppearanceDropDown.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemComboBox3.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemComboBox3.AppearanceFocused.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemComboBox3.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Items.AddRange(new object[] {
            "დღევანდელი",
            "ბოლო 3 დღის",
            "ბოლო კვირა",
            "ბოლო თვე",
            "ბოლო წელი",
            "სრული ინფორმაცია"});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // popProek
            // 
            this.popProek.AllowRibbonQATMenu = false;
            this.popProek.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopy)});
            this.popProek.Manager = this.barProek;
            this.popProek.Name = "popProek";
            this.popProek.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.False;
            // 
            // dgProek
            // 
            this.dgProek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProek.Location = new System.Drawing.Point(0, 40);
            this.dgProek.MainView = this.gvProek;
            this.dgProek.Name = "dgProek";
            this.dgProek.Size = new System.Drawing.Size(994, 572);
            this.dgProek.TabIndex = 18;
            this.dgProek.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProek});
            // 
            // gvProek
            // 
            this.gvProek.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvProek.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProek.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProek,
            this.colProek,
            this.colProekT,
            this.colAddress,
            this.colPhone,
            this.colShen,
            this.colIsCustomClearance});
            this.gvProek.CustomizationFormBounds = new System.Drawing.Rectangle(862, 484, 208, 191);
            this.gvProek.FooterPanelHeight = 1;
            this.gvProek.GridControl = this.dgProek;
            this.gvProek.GroupPanelText = "დაჯგუფება";
            this.gvProek.GroupRowHeight = 1;
            this.gvProek.Name = "gvProek";
            this.gvProek.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvProek.OptionsBehavior.Editable = false;
            this.gvProek.OptionsDetail.AllowZoomDetail = false;
            this.gvProek.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvProek.OptionsView.ColumnAutoWidth = false;
            this.gvProek.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvProek.OptionsView.ShowAutoFilterRow = true;
            this.gvProek.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvProek.OptionsView.ShowDetailButtons = false;
            this.gvProek.OptionsView.ShowFooter = true;
            this.gvProek.OptionsView.ShowGroupedColumns = true;
            this.gvProek.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProek
            // 
            this.colIdProek.Caption = "#";
            this.colIdProek.FieldName = "IdProek";
            this.colIdProek.Name = "colIdProek";
            // 
            // colProek
            // 
            this.colProek.Caption = "ობიექტი";
            this.colProek.FieldName = "Proek";
            this.colProek.Name = "colProek";
            this.colProek.Visible = true;
            this.colProek.VisibleIndex = 0;
            this.colProek.Width = 250;
            // 
            // colProekT
            // 
            this.colProekT.Caption = "ობიექტის ტიპი";
            this.colProekT.FieldName = "ProekT";
            this.colProekT.Name = "colProekT";
            this.colProekT.Visible = true;
            this.colProekT.VisibleIndex = 1;
            this.colProekT.Width = 209;
            // 
            // colAddress
            // 
            this.colAddress.Caption = " მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 194;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "ტელეფონი";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 201;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 4;
            // 
            // colIsCustomClearance
            // 
            this.colIsCustomClearance.Caption = "არის საბაჟოს საწყობი?";
            this.colIsCustomClearance.FieldName = "IsCustomClearance";
            this.colIsCustomClearance.Name = "colIsCustomClearance";
            this.colIsCustomClearance.Visible = true;
            this.colIsCustomClearance.VisibleIndex = 5;
            // 
            // ProekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 612);
            this.Controls.Add(this.dgProek);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProekForm";
            this.Activated += new System.EventHandler(this.ProekForm_Activated);
            this.Load += new System.EventHandler(this.ProekForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barProek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popProek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barProek;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCopy;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraBars.PopupMenu popProek;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl dgProek;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProek;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProek;
        private DevExpress.XtraGrid.Columns.GridColumn colProek;
        private DevExpress.XtraGrid.Columns.GridColumn colProekT;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCustomClearance;
    }
}