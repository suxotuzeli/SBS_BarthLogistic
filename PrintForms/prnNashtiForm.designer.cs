namespace SBS_BarthLogistic.PrintForms
{
    partial class prnNashtiForm {
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
            this.paNashti = new DevExpress.XtraEditors.PanelControl();
            this.fmgProekSectorZone = new SBS_BarthLogistic.Controls.FMGTextFilterControl();
            this.fmgOrg = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProekSector = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProek = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.bm = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.btnFind = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.cbLayoutPT = new DevExpress.XtraBars.BarEditItem();
            this.rcbLayoutPT = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnDGLayoutLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnDGLayoutSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTParameters = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ptNashti = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pcolIdProd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolRaod = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOperT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProekSector = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolProekSectorZone = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrg1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolPartNumber = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolUnit = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolRaodInBox = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolPalet = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolWeight = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolFasi = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolValuta = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolCompRaodTotal = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolTanxa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrg = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.paNashti)).BeginInit();
            this.paNashti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptNashti)).BeginInit();
            this.SuspendLayout();
            // 
            // paNashti
            // 
            this.paNashti.Controls.Add(this.fmgProekSectorZone);
            this.paNashti.Controls.Add(this.fmgOrg);
            this.paNashti.Controls.Add(this.fmgProekSector);
            this.paNashti.Controls.Add(this.fmgProek);
            this.paNashti.Controls.Add(this.fmgData);
            this.paNashti.Dock = System.Windows.Forms.DockStyle.Top;
            this.paNashti.Location = new System.Drawing.Point(0, 40);
            this.paNashti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paNashti.Name = "paNashti";
            this.paNashti.Size = new System.Drawing.Size(1247, 101);
            this.paNashti.TabIndex = 0;
            // 
            // fmgProekSectorZone
            // 
            this.fmgProekSectorZone.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProekSectorZone.Appearance.Options.UseFont = true;
            this.fmgProekSectorZone.FieldName = "ProekSectorZone";
            this.fmgProekSectorZone.Location = new System.Drawing.Point(417, 69);
            this.fmgProekSectorZone.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgProekSectorZone.Name = "fmgProekSectorZone";
            this.fmgProekSectorZone.ParameterName = null;
            this.fmgProekSectorZone.Size = new System.Drawing.Size(385, 23);
            this.fmgProekSectorZone.TabIndex = 7;
            this.fmgProekSectorZone.Text = "ლოკაცია";
            // 
            // fmgOrg
            // 
            this.fmgOrg.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrg.Appearance.Options.UseFont = true;
            this.fmgOrg.FieldName = "Org";
            this.fmgOrg.Location = new System.Drawing.Point(15, 41);
            this.fmgOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgOrg.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrg.Name = "fmgOrg";
            this.fmgOrg.ParameterName = null;
            this.fmgOrg.Size = new System.Drawing.Size(385, 24);
            this.fmgOrg.TabIndex = 6;
            this.fmgOrg.Text = "კლიენტი";
            // 
            // fmgProekSector
            // 
            this.fmgProekSector.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProekSector.Appearance.Options.UseFont = true;
            this.fmgProekSector.FieldName = "ProekSector";
            this.fmgProekSector.Location = new System.Drawing.Point(417, 38);
            this.fmgProekSector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProekSector.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgProekSector.Name = "fmgProekSector";
            this.fmgProekSector.ParameterName = null;
            this.fmgProekSector.Size = new System.Drawing.Size(385, 24);
            this.fmgProekSector.TabIndex = 4;
            this.fmgProekSector.Text = "შენობა";
            // 
            // fmgProek
            // 
            this.fmgProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProek.Appearance.Options.UseFont = true;
            this.fmgProek.FieldName = "Proek";
            this.fmgProek.Location = new System.Drawing.Point(417, 6);
            this.fmgProek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProek.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgProek.Name = "fmgProek";
            this.fmgProek.ParameterName = null;
            this.fmgProek.Size = new System.Drawing.Size(385, 24);
            this.fmgProek.TabIndex = 3;
            this.fmgProek.Text = "ობიექტი";
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
            this.btnPTParameters,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDGLayoutSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPTParameters, true)});
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
            // btnPTParameters
            // 
            this.btnPTParameters.Caption = "ცხრილის პარამეტერბი";
            this.btnPTParameters.Id = 20;
            this.btnPTParameters.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.AED_CustomizeGrid_32x32;
            this.btnPTParameters.Name = "btnPTParameters";
            this.btnPTParameters.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPTParameters_ItemClick);
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
            // ptNashti
            // 
            this.ptNashti.Appearance.Cell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.Cell.Options.UseFont = true;
            this.ptNashti.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.ptNashti.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.CustomTotalCell.Options.UseFont = true;
            this.ptNashti.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.DataHeaderArea.Options.UseFont = true;
            this.ptNashti.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.Empty.Options.UseFont = true;
            this.ptNashti.Appearance.ExpandButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.ExpandButton.Options.UseFont = true;
            this.ptNashti.Appearance.FieldHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.FieldHeader.Options.UseFont = true;
            this.ptNashti.Appearance.FieldValue.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.FieldValue.Options.UseFont = true;
            this.ptNashti.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.FieldValueGrandTotal.Options.UseFont = true;
            this.ptNashti.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.FieldValueTotal.Options.UseFont = true;
            this.ptNashti.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.ptNashti.Appearance.FilterSeparator.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.FilterSeparator.Options.UseFont = true;
            this.ptNashti.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.FocusedCell.Options.UseFont = true;
            this.ptNashti.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.GrandTotalCell.Options.UseFont = true;
            this.ptNashti.Appearance.HeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.HeaderArea.Options.UseFont = true;
            this.ptNashti.Appearance.HeaderFilterButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.HeaderFilterButton.Options.UseFont = true;
            this.ptNashti.Appearance.HeaderFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.HeaderFilterButtonActive.Options.UseFont = true;
            this.ptNashti.Appearance.Lines.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.Lines.Options.UseFont = true;
            this.ptNashti.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.RowHeaderArea.Options.UseFont = true;
            this.ptNashti.Appearance.SelectedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.SelectedCell.Options.UseFont = true;
            this.ptNashti.Appearance.TotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.ptNashti.Appearance.TotalCell.Options.UseFont = true;
            this.ptNashti.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptNashti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptNashti.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pcolIdProd,
            this.pcolProd,
            this.pcolRaod,
            this.pcolProek,
            this.pcolOperT,
            this.pcolProekSector,
            this.pcolProekSectorZone,
            this.pcolOrg1,
            this.pcolPartNumber,
            this.pcolUnit,
            this.pcolRaodInBox,
            this.pcolPalet,
            this.pcolWeight,
            this.pcolFasi,
            this.pcolValuta,
            this.pcolCompRaodTotal,
            this.pcolTanxa});
            this.ptNashti.Location = new System.Drawing.Point(0, 141);
            this.ptNashti.Name = "ptNashti";
            this.ptNashti.OptionsCustomization.AllowFilter = false;
            this.ptNashti.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.ptNashti.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.ptNashti.Size = new System.Drawing.Size(1247, 403);
            this.ptNashti.TabIndex = 126;
            // 
            // pcolIdProd
            // 
            this.pcolIdProd.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolIdProd.Appearance.Header.Options.UseFont = true;
            this.pcolIdProd.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolIdProd.Appearance.Value.Options.UseFont = true;
            this.pcolIdProd.Appearance.ValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolIdProd.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolIdProd.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolIdProd.AreaIndex = 1;
            this.pcolIdProd.Caption = "პროდ. კოდი";
            this.pcolIdProd.FieldName = "IdProd";
            this.pcolIdProd.MinWidth = 17;
            this.pcolIdProd.Name = "pcolIdProd";
            this.pcolIdProd.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.True;
            this.pcolIdProd.Width = 86;
            // 
            // pcolProd
            // 
            this.pcolProd.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolProd.Appearance.Header.Options.UseFont = true;
            this.pcolProd.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolProd.Appearance.Value.Options.UseFont = true;
            this.pcolProd.Appearance.ValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolProd.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolProd.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolProd.AreaIndex = 2;
            this.pcolProd.Caption = "პროდუქცია";
            this.pcolProd.FieldName = "Prod";
            this.pcolProd.MinWidth = 17;
            this.pcolProd.Name = "pcolProd";
            this.pcolProd.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.True;
            this.pcolProd.Width = 86;
            // 
            // pcolRaod
            // 
            this.pcolRaod.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolRaod.Appearance.Header.Options.UseFont = true;
            this.pcolRaod.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolRaod.Appearance.Value.Options.UseFont = true;
            this.pcolRaod.Appearance.ValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolRaod.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolRaod.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pcolRaod.AreaIndex = 0;
            this.pcolRaod.Caption = "რაოდენობა";
            this.pcolRaod.CellFormat.FormatString = "{0:0.###}";
            this.pcolRaod.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.FieldName = "Raod";
            this.pcolRaod.GrandTotalCellFormat.FormatString = "{0:0.###}";
            this.pcolRaod.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.MinWidth = 17;
            this.pcolRaod.Name = "pcolRaod";
            this.pcolRaod.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.True;
            this.pcolRaod.TotalCellFormat.FormatString = "{0:0.###}";
            this.pcolRaod.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.TotalValueFormat.FormatString = "{0:0.###}";
            this.pcolRaod.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.ValueFormat.FormatString = "{0:0.###}";
            this.pcolRaod.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.Width = 86;
            // 
            // pcolProek
            // 
            this.pcolProek.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolProek.Appearance.Header.Options.UseFont = true;
            this.pcolProek.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolProek.Appearance.Value.Options.UseFont = true;
            this.pcolProek.Appearance.ValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolProek.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolProek.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolProek.AreaIndex = 0;
            this.pcolProek.Caption = "ობიექტი";
            this.pcolProek.FieldName = "Proek";
            this.pcolProek.MinWidth = 17;
            this.pcolProek.Name = "pcolProek";
            this.pcolProek.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.True;
            this.pcolProek.Width = 86;
            // 
            // pcolOperT
            // 
            this.pcolOperT.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolOperT.Appearance.Header.Options.UseFont = true;
            this.pcolOperT.Appearance.Value.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolOperT.Appearance.Value.Options.UseFont = true;
            this.pcolOperT.Appearance.ValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pcolOperT.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolOperT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOperT.AreaIndex = 0;
            this.pcolOperT.Caption = "ოპერაციის ტიპი";
            this.pcolOperT.FieldName = "OperT";
            this.pcolOperT.MinWidth = 17;
            this.pcolOperT.Name = "pcolOperT";
            this.pcolOperT.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.True;
            this.pcolOperT.Width = 86;
            // 
            // pcolProekSector
            // 
            this.pcolProekSector.AreaIndex = 0;
            this.pcolProekSector.Caption = "სექცია";
            this.pcolProekSector.FieldName = "ProekSector";
            this.pcolProekSector.Name = "pcolProekSector";
            // 
            // pcolProekSectorZone
            // 
            this.pcolProekSectorZone.AreaIndex = 1;
            this.pcolProekSectorZone.Caption = "ზონა";
            this.pcolProekSectorZone.FieldName = "ProekSectorZone";
            this.pcolProekSectorZone.Name = "pcolProekSectorZone";
            // 
            // pcolOrg1
            // 
            this.pcolOrg1.AreaIndex = 2;
            this.pcolOrg1.Caption = "ორგანიზაცია";
            this.pcolOrg1.FieldName = "Org";
            this.pcolOrg1.Name = "pcolOrg1";
            // 
            // pcolPartNumber
            // 
            this.pcolPartNumber.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolPartNumber.AreaIndex = 1;
            this.pcolPartNumber.Caption = "არტიკული(PartNumber)";
            this.pcolPartNumber.FieldName = "PartNumber";
            this.pcolPartNumber.Name = "pcolPartNumber";
            this.pcolPartNumber.Visible = false;
            // 
            // pcolUnit
            // 
            this.pcolUnit.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolUnit.AreaIndex = 1;
            this.pcolUnit.Caption = "ერთეული";
            this.pcolUnit.FieldName = "Unit";
            this.pcolUnit.Name = "pcolUnit";
            this.pcolUnit.Visible = false;
            // 
            // pcolRaodInBox
            // 
            this.pcolRaodInBox.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolRaodInBox.AreaIndex = 1;
            this.pcolRaodInBox.Caption = "რაოდ. ყუთში";
            this.pcolRaodInBox.FieldName = "RaodInBox";
            this.pcolRaodInBox.Name = "pcolRaodInBox";
            this.pcolRaodInBox.Visible = false;
            // 
            // pcolPalet
            // 
            this.pcolPalet.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolPalet.AreaIndex = 1;
            this.pcolPalet.Caption = "პალეტი";
            this.pcolPalet.FieldName = "Palet";
            this.pcolPalet.Name = "pcolPalet";
            this.pcolPalet.Visible = false;
            // 
            // pcolWeight
            // 
            this.pcolWeight.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolWeight.AreaIndex = 1;
            this.pcolWeight.Caption = "წონა";
            this.pcolWeight.FieldName = "Weight";
            this.pcolWeight.Name = "pcolWeight";
            this.pcolWeight.Visible = false;
            // 
            // pcolFasi
            // 
            this.pcolFasi.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolFasi.AreaIndex = 1;
            this.pcolFasi.Caption = "ფასი";
            this.pcolFasi.Name = "pcolFasi";
            this.pcolFasi.Visible = false;
            // 
            // pcolValuta
            // 
            this.pcolValuta.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolValuta.AreaIndex = 1;
            this.pcolValuta.Caption = "ვალუტა";
            this.pcolValuta.FieldName = "Valuta";
            this.pcolValuta.Name = "pcolValuta";
            this.pcolValuta.Visible = false;
            // 
            // pcolCompRaodTotal
            // 
            this.pcolCompRaodTotal.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolCompRaodTotal.AreaIndex = 1;
            this.pcolCompRaodTotal.Caption = "კომპელქტი";
            this.pcolCompRaodTotal.FieldName = "CompRaodTotal";
            this.pcolCompRaodTotal.Name = "pcolCompRaodTotal";
            this.pcolCompRaodTotal.Visible = false;
            // 
            // pcolTanxa
            // 
            this.pcolTanxa.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolTanxa.AreaIndex = 1;
            this.pcolTanxa.Caption = "თანხა";
            this.pcolTanxa.FieldName = "Tanxa";
            this.pcolTanxa.Name = "pcolTanxa";
            this.pcolTanxa.Visible = false;
            // 
            // pcolOrg
            // 
            this.pcolOrg.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOrg.AreaIndex = 3;
            this.pcolOrg.Caption = "ორგანიზაცია";
            this.pcolOrg.FieldName = "Org";
            this.pcolOrg.Name = "pcolOrg";
            // 
            // prnNashtiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 544);
            this.Controls.Add(this.ptNashti);
            this.Controls.Add(this.paNashti);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "prnNashtiForm";
            this.Text = "საწყობის ნაშთი";
            this.Load += new System.EventHandler(this.prnNashtiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paNashti)).EndInit();
            this.paNashti.ResumeLayout(false);
            this.paNashti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptNashti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paNashti;
        private SBS_BarthLogistic.Controls.FMGDateFilterControl fmgData;
        private SBS_BarthLogistic.Controls.FMGComboFilterControl fmgProek;
        private DevExpress.XtraBars.BarManager bm;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarEditItem cbLayoutPT;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbLayoutPT;
        private DevExpress.XtraBars.BarButtonItem btnDGLayoutLoad;
        private DevExpress.XtraBars.BarButtonItem btnDGLayoutSave;
        private DevExpress.XtraBars.BarButtonItem btnPTParameters;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnFind;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPivotGrid.PivotGridControl ptNashti;
        private DevExpress.XtraPivotGrid.PivotGridField pcolIdProd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolRaod;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOperT;
        private Controls.FMGComboFilterControl fmgOrg;
        private Controls.FMGComboFilterControl fmgProekSector;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekSector;
        private DevExpress.XtraPivotGrid.PivotGridField pcolProekSectorZone;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrg1;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrg;
        private Controls.FMGTextFilterControl fmgProekSectorZone;
        private DevExpress.XtraPivotGrid.PivotGridField pcolPartNumber;
        private DevExpress.XtraPivotGrid.PivotGridField pcolUnit;
        private DevExpress.XtraPivotGrid.PivotGridField pcolRaodInBox;
        private DevExpress.XtraPivotGrid.PivotGridField pcolPalet;
        private DevExpress.XtraPivotGrid.PivotGridField pcolWeight;
        private DevExpress.XtraPivotGrid.PivotGridField pcolFasi;
        private DevExpress.XtraPivotGrid.PivotGridField pcolValuta;
        private DevExpress.XtraPivotGrid.PivotGridField pcolCompRaodTotal;
        private DevExpress.XtraPivotGrid.PivotGridField pcolTanxa;
    }
}