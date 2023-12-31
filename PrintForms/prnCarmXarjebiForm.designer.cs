namespace SBS_Market.PrintForms
{
    partial class prnCarmXarjebiForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prnCarmXarjebiForm));
            this.paFilter = new DevExpress.XtraEditors.PanelControl();
            this.fmgCarmT = new SBS_Market.Controls.FMGComboFilterControl();
            this.fmgProek = new SBS_Market.Controls.FMGComboFilterControl();
            this.fmgData = new SBS_Market.Controls.FMGDateFilterControl();
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
            this.pt = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pcolSalaro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolRaodAuto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolRaod = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolCarmT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolZedd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolCarmProd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolGasProd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolCarmRaod = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.paFilter)).BeginInit();
            this.paFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).BeginInit();
            this.SuspendLayout();
            // 
            // paFilter
            // 
            this.paFilter.Controls.Add(this.fmgCarmT);
            this.paFilter.Controls.Add(this.fmgProek);
            this.paFilter.Controls.Add(this.fmgData);
            this.paFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.paFilter.Location = new System.Drawing.Point(0, 48);
            this.paFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paFilter.Name = "paFilter";
            this.paFilter.Size = new System.Drawing.Size(1332, 65);
            this.paFilter.TabIndex = 0;
            // 
            // fmgCarmT
            // 
            this.fmgCarmT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgCarmT.Appearance.Options.UseFont = true;
            this.fmgCarmT.FieldName = "CarmT";
            this.fmgCarmT.Location = new System.Drawing.Point(877, 11);
            this.fmgCarmT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgCarmT.Name = "fmgCarmT";
            this.fmgCarmT.ParameterName = null;
            this.fmgCarmT.Size = new System.Drawing.Size(423, 30);
            this.fmgCarmT.TabIndex = 9;
            this.fmgCarmT.Text = "წარმოების ტიპი";
            // 
            // fmgProek
            // 
            this.fmgProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProek.Appearance.Options.UseFont = true;
            this.fmgProek.FieldName = "Proek";
            this.fmgProek.Location = new System.Drawing.Point(447, 11);
            this.fmgProek.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProek.Name = "fmgProek";
            this.fmgProek.ParameterName = null;
            this.fmgProek.Size = new System.Drawing.Size(423, 30);
            this.fmgProek.TabIndex = 3;
            this.fmgProek.Text = "ობიექტი";
            // 
            // fmgData
            // 
            this.fmgData.AlwaysChecked = true;
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.Checked = true;
            this.fmgData.FieldName = "Data";
            this.fmgData.Location = new System.Drawing.Point(17, 11);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = "D";
            this.fmgData.Size = new System.Drawing.Size(425, 30);
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
            this.bar.OptionsBar.MultiLine = false;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar.Text = "Main menu";
            // 
            // btnFind
            // 
            this.btnFind.Caption = "ძებნა";
            this.btnFind.Glyph = global::SBS_Market.Properties.Resources.AED_Find_32x32;
            this.btnFind.Id = 36;
            this.btnFind.Name = "btnFind";
            this.btnFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFind_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "ბეჭდვა";
            this.btnPrint.Glyph = global::SBS_Market.Properties.Resources.preview_32x32;
            this.btnPrint.Id = 35;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // cbLayoutPT
            // 
            this.cbLayoutPT.Caption = "სქემა";
            this.cbLayoutPT.Edit = this.rcbLayoutPT;
            this.cbLayoutPT.Id = 21;
            this.cbLayoutPT.Name = "cbLayoutPT";
            this.cbLayoutPT.Width = 162;
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
            this.btnDGLayoutLoad.Glyph = global::SBS_Market.Properties.Resources.AED_RestoreLayout_32x32;
            this.btnDGLayoutLoad.Id = 22;
            this.btnDGLayoutLoad.Name = "btnDGLayoutLoad";
            this.btnDGLayoutLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDGLayoutLoad_ItemClick);
            // 
            // btnDGLayoutSave
            // 
            this.btnDGLayoutSave.Caption = "სქემის შენახვა";
            this.btnDGLayoutSave.Glyph = global::SBS_Market.Properties.Resources.AED_SaveLayout_32x32;
            this.btnDGLayoutSave.Id = 33;
            this.btnDGLayoutSave.Name = "btnDGLayoutSave";
            this.btnDGLayoutSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDGLayoutSave_ItemClick);
            // 
            // btnPTParameters
            // 
            this.btnPTParameters.Caption = "ცხრილის პარამეტერბი";
            this.btnPTParameters.Glyph = global::SBS_Market.Properties.Resources.AED_CustomizeGrid_32x32;
            this.btnPTParameters.Id = 20;
            this.btnPTParameters.Name = "btnPTParameters";
            this.btnPTParameters.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPTParameters_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1332, 48);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 670);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1332, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 670);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1332, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 670);
            // 
            // pt
            // 
            this.pt.Appearance.Cell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.Cell.Options.UseFont = true;
            this.pt.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pt.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.CustomTotalCell.Options.UseFont = true;
            this.pt.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pt.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.Empty.Options.UseFont = true;
            this.pt.Appearance.ExpandButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.ExpandButton.Options.UseFont = true;
            this.pt.Appearance.FieldHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldHeader.Options.UseFont = true;
            this.pt.Appearance.FieldValue.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldValue.Options.UseFont = true;
            this.pt.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldValueGrandTotal.Options.UseFont = true;
            this.pt.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldValueTotal.Options.UseFont = true;
            this.pt.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.pt.Appearance.FilterSeparator.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FilterSeparator.Options.UseFont = true;
            this.pt.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FocusedCell.Options.UseFont = true;
            this.pt.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.GrandTotalCell.Options.UseFont = true;
            this.pt.Appearance.HeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.HeaderArea.Options.UseFont = true;
            this.pt.Appearance.HeaderFilterButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.HeaderFilterButton.Options.UseFont = true;
            this.pt.Appearance.HeaderFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.HeaderFilterButtonActive.Options.UseFont = true;
            this.pt.Appearance.Lines.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.Lines.Options.UseFont = true;
            this.pt.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.RowHeaderArea.Options.UseFont = true;
            this.pt.Appearance.SelectedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.SelectedCell.Options.UseFont = true;
            this.pt.Appearance.TotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.TotalCell.Options.UseFont = true;
            this.pt.Cursor = System.Windows.Forms.Cursors.Default;
            this.pt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pt.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pcolSalaro,
            this.pcolRaodAuto,
            this.pcolRaod,
            this.pcolCarmT,
            this.pcolData,
            this.pcolZedd,
            this.pcolCarmProd,
            this.pcolGasProd,
            this.pcolCarmRaod});
            this.pt.Location = new System.Drawing.Point(0, 113);
            this.pt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pt.Name = "pt";
            this.pt.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.pt.OptionsDataField.AreaIndex = 1;
            this.pt.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pt.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pt.Size = new System.Drawing.Size(1332, 557);
            this.pt.TabIndex = 106;
            // 
            // pcolSalaro
            // 
            this.pcolSalaro.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.pcolSalaro.Appearance.Header.Options.UseFont = true;
            this.pcolSalaro.Appearance.Value.Font = new System.Drawing.Font("AcadMtavr", 8.249999F);
            this.pcolSalaro.Appearance.Value.Options.UseFont = true;
            this.pcolSalaro.Appearance.ValueTotal.Font = new System.Drawing.Font("AcadMtavr", 8.249999F);
            this.pcolSalaro.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolSalaro.AreaIndex = 1;
            this.pcolSalaro.Caption = "ობიექტი";
            this.pcolSalaro.FieldName = "Salaro";
            this.pcolSalaro.Name = "pcolSalaro";
            // 
            // pcolRaodAuto
            // 
            this.pcolRaodAuto.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pcolRaodAuto.AreaIndex = 0;
            this.pcolRaodAuto.Caption = "გეგმიური ხარჯი";
            this.pcolRaodAuto.CellFormat.FormatString = "{0:#.00}";
            this.pcolRaodAuto.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaodAuto.FieldName = "RaodAuto";
            this.pcolRaodAuto.Name = "pcolRaodAuto";
            this.pcolRaodAuto.TotalCellFormat.FormatString = "{0:#.00}";
            this.pcolRaodAuto.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaodAuto.TotalValueFormat.FormatString = "{0:#.00}";
            this.pcolRaodAuto.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaodAuto.ValueFormat.FormatString = "{0:#.00}";
            this.pcolRaodAuto.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pcolRaod
            // 
            this.pcolRaod.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pcolRaod.AreaIndex = 1;
            this.pcolRaod.Caption = "ხარჯი";
            this.pcolRaod.CellFormat.FormatString = "{0:#.00}";
            this.pcolRaod.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.FieldName = "Raod";
            this.pcolRaod.Name = "pcolRaod";
            this.pcolRaod.TotalCellFormat.FormatString = "{0:#.00}";
            this.pcolRaod.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.TotalValueFormat.FormatString = "{0:#.00}";
            this.pcolRaod.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolRaod.ValueFormat.FormatString = "{0:#.00}";
            this.pcolRaod.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pcolCarmT
            // 
            this.pcolCarmT.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.pcolCarmT.Appearance.Header.Options.UseFont = true;
            this.pcolCarmT.Appearance.Value.Font = new System.Drawing.Font("AcadMtavr", 8.249999F);
            this.pcolCarmT.Appearance.Value.Options.UseFont = true;
            this.pcolCarmT.Appearance.ValueTotal.Font = new System.Drawing.Font("AcadMtavr", 8.249999F);
            this.pcolCarmT.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolCarmT.AreaIndex = 0;
            this.pcolCarmT.Caption = "წარმოების ტიპი";
            this.pcolCarmT.FieldName = "CarmT";
            this.pcolCarmT.Name = "pcolCarmT";
            // 
            // pcolData
            // 
            this.pcolData.Appearance.Header.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.pcolData.Appearance.Header.Options.UseFont = true;
            this.pcolData.Appearance.Value.Font = new System.Drawing.Font("AcadMtavr", 8.249999F);
            this.pcolData.Appearance.Value.Options.UseFont = true;
            this.pcolData.Appearance.ValueTotal.Font = new System.Drawing.Font("AcadMtavr", 8.249999F);
            this.pcolData.Appearance.ValueTotal.Options.UseFont = true;
            this.pcolData.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolData.AreaIndex = 0;
            this.pcolData.Caption = "თარიღი";
            this.pcolData.CellFormat.FormatString = "d";
            this.pcolData.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pcolData.FieldName = "Data";
            this.pcolData.Name = "pcolData";
            // 
            // pcolZedd
            // 
            this.pcolZedd.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolZedd.AreaIndex = 1;
            this.pcolZedd.Caption = "ზედდ";
            this.pcolZedd.FieldName = "Zedd";
            this.pcolZedd.Name = "pcolZedd";
            // 
            // pcolCarmProd
            // 
            this.pcolCarmProd.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolCarmProd.AreaIndex = 2;
            this.pcolCarmProd.Caption = "წარმ. პროდ";
            this.pcolCarmProd.FieldName = "CarmProd";
            this.pcolCarmProd.Name = "pcolCarmProd";
            // 
            // pcolGasProd
            // 
            this.pcolGasProd.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolGasProd.AreaIndex = 0;
            this.pcolGasProd.Caption = "დახარჯული პროდ.";
            this.pcolGasProd.FieldName = "GasProd";
            this.pcolGasProd.Name = "pcolGasProd";
            // 
            // pcolCarmRaod
            // 
            this.pcolCarmRaod.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolCarmRaod.AreaIndex = 3;
            this.pcolCarmRaod.Caption = "წარმ.რაოდ";
            this.pcolCarmRaod.CellFormat.FormatString = "{0:#.00}";
            this.pcolCarmRaod.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolCarmRaod.FieldName = "CarmRaod";
            this.pcolCarmRaod.Name = "pcolCarmRaod";
            // 
            // prnCarmXarjebiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 670);
            this.Controls.Add(this.pt);
            this.Controls.Add(this.paFilter);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "prnCarmXarjebiForm";
            this.Text = "საწყობის ნაშთი";
            this.Load += new System.EventHandler(this.prnNashtiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paFilter)).EndInit();
            this.paFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paFilter;
        private SBS_Market.Controls.FMGDateFilterControl fmgData;
        private SBS_Market.Controls.FMGComboFilterControl fmgProek;
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
        private Controls.FMGComboFilterControl fmgCarmT;
        private DevExpress.XtraPivotGrid.PivotGridControl pt;
        private DevExpress.XtraPivotGrid.PivotGridField pcolSalaro;
        private DevExpress.XtraPivotGrid.PivotGridField pcolRaodAuto;
        private DevExpress.XtraPivotGrid.PivotGridField pcolRaod;
        private DevExpress.XtraPivotGrid.PivotGridField pcolCarmT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolData;
        private DevExpress.XtraPivotGrid.PivotGridField pcolZedd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolCarmProd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolGasProd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolCarmRaod;
    }
}