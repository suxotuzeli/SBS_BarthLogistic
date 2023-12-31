namespace SBS_BarthLogistic.PrintForms
{
    partial class prnProdBaratiForm {
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
            this.paProdBarati = new DevExpress.XtraEditors.PanelControl();
            this.fmgOrg = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgIdProd = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.btnFind = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.cbLayoutPT = new DevExpress.XtraBars.BarEditItem();
            this.rcbLayoutPT = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnDGLayoutLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnDGLayoutSave = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pcolProekSector = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProekSectorZone = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrg = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dgProdBarati = new DevExpress.XtraGrid.GridControl();
            this.gvProdBarati = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paProdBarati)).BeginInit();
            this.paProdBarati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdBarati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdBarati)).BeginInit();
            this.SuspendLayout();
            // 
            // paProdBarati
            // 
            this.paProdBarati.Controls.Add(this.fmgOrg);
            this.paProdBarati.Controls.Add(this.fmgIdProd);
            this.paProdBarati.Controls.Add(this.fmgData);
            this.paProdBarati.Dock = System.Windows.Forms.DockStyle.Top;
            this.paProdBarati.Location = new System.Drawing.Point(0, 40);
            this.paProdBarati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paProdBarati.Name = "paProdBarati";
            this.paProdBarati.Size = new System.Drawing.Size(1247, 49);
            this.paProdBarati.TabIndex = 0;
            // 
            // fmgOrg
            // 
            this.fmgOrg.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrg.Appearance.Options.UseFont = true;
            this.fmgOrg.FieldName = "Org";
            this.fmgOrg.Location = new System.Drawing.Point(408, 9);
            this.fmgOrg.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrg.Name = "fmgOrg";
            this.fmgOrg.ParameterName = "IdOrg";
            this.fmgOrg.Size = new System.Drawing.Size(385, 23);
            this.fmgOrg.TabIndex = 2;
            this.fmgOrg.Text = "კლიენტი";
            // 
            // fmgIdProd
            // 
            this.fmgIdProd.AlwaysChecked = true;
            this.fmgIdProd.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgIdProd.Appearance.Options.UseFont = true;
            this.fmgIdProd.Checked = true;
            this.fmgIdProd.FieldName = "IdProd";
            this.fmgIdProd.Location = new System.Drawing.Point(820, 10);
            this.fmgIdProd.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgIdProd.Name = "fmgIdProd";
            this.fmgIdProd.ParameterName = "IdProd";
            this.fmgIdProd.Size = new System.Drawing.Size(385, 23);
            this.fmgIdProd.TabIndex = 1;
            this.fmgIdProd.Text = "პროდ კოდი";
            // 
            // fmgData
            // 
            this.fmgData.AlwaysChecked = true;
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.AutoSize = true;
            this.fmgData.Checked = true;
            this.fmgData.FieldName = "Data";
            this.fmgData.Location = new System.Drawing.Point(15, 9);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgData.MinimumSize = new System.Drawing.Size(330, 20);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = "D";
            this.fmgData.Size = new System.Drawing.Size(364, 24);
            this.fmgData.TabIndex = 0;
            this.fmgData.Text = "თარიღი";
            // 
            // bm
            // 
            this.bm.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
            this.bm.DockControls.Add(this.standaloneBarDockControl1);
            this.bm.DockControls.Add(this.barDockControlBottom);
            this.bm.DockControls.Add(this.barDockControlLeft);
            this.bm.DockControls.Add(this.barDockControlRight);
            this.bm.Form = this;
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cbLayoutPT,
            this.btnDGLayoutLoad,
            this.btnDGLayoutSave,
            this.btnPrint,
            this.btnFind});
            this.bm.MainMenu = this.bar;
            this.bm.MaxItemId = 37;
            this.bm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rcbLayoutPT});
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar.FloatLocation = new System.Drawing.Point(178, 203);
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFind),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.cbLayoutPT),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGLayoutLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGLayoutSave)});
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar.Text = "Main menu";
            // 
            // btnFind
            // 
            this.btnFind.Caption = "ძებნა";
            this.btnFind.Id = 36;
            this.btnFind.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Find_32x32;
            this.btnFind.Name = "btnFind";
            this.btnFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFind_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "ბეჭდვა";
            this.btnPrint.Id = 35;
            this.btnPrint.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.preview_32x32;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // cbLayoutPT
            // 
            this.cbLayoutPT.Caption = "სქემა";
            this.cbLayoutPT.Edit = this.rcbLayoutPT;
            this.cbLayoutPT.EditWidth = 162;
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
            // btnDGLayoutLoad
            // 
            this.btnDGLayoutLoad.Caption = "სქემის აღდგენა";
            this.btnDGLayoutLoad.Id = 22;
            this.btnDGLayoutLoad.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnDGLayoutLoad.Name = "btnDGLayoutLoad";
            this.btnDGLayoutLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDGLayoutLoad_ItemClick);
            // 
            // btnDGLayoutSave
            // 
            this.btnDGLayoutSave.Caption = "სქემის შენახვა";
            this.btnDGLayoutSave.Id = 33;
            this.btnDGLayoutSave.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_SaveLayout_32x32;
            this.btnDGLayoutSave.Name = "btnDGLayoutSave";
            this.btnDGLayoutSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDGLayoutSave_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = this.bm;
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1247, 40);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 544);
            this.barDockControlBottom.Manager = this.bm;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1247, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.bm;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 544);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1247, 0);
            this.barDockControlRight.Manager = this.bm;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 544);
            // 
            // pcolProekSector
            // 
            this.pcolProekSector.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProekSector.AreaIndex = 1;
            this.pcolProekSector.Caption = "სექცია";
            this.pcolProekSector.FieldName = "ProekSector";
            this.pcolProekSector.Name = "pcolProekSector";
            // 
            // pcolProekSectorZone
            // 
            this.pcolProekSectorZone.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolProekSectorZone.AreaIndex = 2;
            this.pcolProekSectorZone.Caption = "ზონა";
            this.pcolProekSectorZone.FieldName = "ProekSectorZone";
            this.pcolProekSectorZone.Name = "pcolProekSectorZone";
            // 
            // pcolOrg
            // 
            this.pcolOrg.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOrg.AreaIndex = 3;
            this.pcolOrg.Caption = "ორგანიზაცია";
            this.pcolOrg.FieldName = "Org";
            this.pcolOrg.Name = "pcolOrg";
            // 
            // dgProdBarati
            // 
            this.dgProdBarati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdBarati.Location = new System.Drawing.Point(0, 89);
            this.dgProdBarati.MainView = this.gvProdBarati;
            this.dgProdBarati.Name = "dgProdBarati";
            this.dgProdBarati.Size = new System.Drawing.Size(1247, 455);
            this.dgProdBarati.TabIndex = 131;
            this.dgProdBarati.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdBarati});
            // 
            // gvProdBarati
            // 
            this.gvProdBarati.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProd,
            this.colProd,
            this.colShem,
            this.colGas,
            this.colData});
            this.gvProdBarati.GridControl = this.dgProdBarati;
            this.gvProdBarati.Name = "gvProdBarati";
            this.gvProdBarati.OptionsBehavior.Editable = false;
            this.gvProdBarati.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            this.colIdProd.Width = 147;
            // 
            // colProd
            // 
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 663;
            // 
            // colShem
            // 
            this.colShem.Caption = "შემოსავალი";
            this.colShem.DisplayFormat.FormatString = "##.00";
            this.colShem.FieldName = "Shem";
            this.colShem.Name = "colShem";
            this.colShem.Visible = true;
            this.colShem.VisibleIndex = 3;
            this.colShem.Width = 341;
            // 
            // colGas
            // 
            this.colGas.Caption = "გასავალი";
            this.colGas.DisplayFormat.FormatString = "##.00";
            this.colGas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGas.FieldName = "Gas";
            this.colGas.Name = "colGas";
            this.colGas.Visible = true;
            this.colGas.VisibleIndex = 4;
            this.colGas.Width = 289;
            // 
            // colData
            // 
            this.colData.Caption = "თარიღი";
            this.colData.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 2;
            this.colData.Width = 182;
            // 
            // prnProdBaratiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 544);
            this.Controls.Add(this.dgProdBarati);
            this.Controls.Add(this.paProdBarati);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "prnProdBaratiForm";
            this.Text = "პროდუქციის ბარათი";
            this.Load += new System.EventHandler(this.prnProdBaratiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paProdBarati)).EndInit();
            this.paProdBarati.ResumeLayout(false);
            this.paProdBarati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdBarati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdBarati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paProdBarati;
        private SBS_BarthLogistic.Controls.FMGDateFilterControl fmgData;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarEditItem cbLayoutPT;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbLayoutPT;
        private DevExpress.XtraBars.BarButtonItem btnDGLayoutLoad;
        private DevExpress.XtraBars.BarButtonItem btnDGLayoutSave;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnFind;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekSector;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekSectorZone;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrg;
        private Controls.FMGComboFilterControl fmgOrg;
        private Controls.FMGTextFilterControl fmgIdProd;
        private DevExpress.XtraGrid.GridControl dgProdBarati;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdBarati;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colShem;
        private DevExpress.XtraGrid.Columns.GridColumn colGas;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
    }
}