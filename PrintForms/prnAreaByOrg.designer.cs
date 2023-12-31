namespace SBS_BarthLogistic.PrintForms
{
    partial class prnAreaByOrg {
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
            this.fmgOrgT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgOrg = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
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
            this.pcolOrg = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOrgT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolArea = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolOperation = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.paNashti)).BeginInit();
            this.paNashti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLayoutPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptNashti)).BeginInit();
            this.SuspendLayout();
            // 
            // paNashti
            // 
            this.paNashti.Controls.Add(this.fmgOrgT);
            this.paNashti.Controls.Add(this.fmgOrg);
            this.paNashti.Controls.Add(this.fmgProek);
            this.paNashti.Controls.Add(this.fmgData);
            this.paNashti.Dock = System.Windows.Forms.DockStyle.Top;
            this.paNashti.Location = new System.Drawing.Point(0, 40);
            this.paNashti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paNashti.Name = "paNashti";
            this.paNashti.Size = new System.Drawing.Size(1247, 101);
            this.paNashti.TabIndex = 0;
            // 
            // fmgOrgT
            // 
            this.fmgOrgT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrgT.Appearance.Options.UseFont = true;
            this.fmgOrgT.FieldName = "OrgT";
            this.fmgOrgT.Location = new System.Drawing.Point(15, 38);
            this.fmgOrgT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgOrgT.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrgT.Name = "fmgOrgT";
            this.fmgOrgT.ParameterName = null;
            this.fmgOrgT.Size = new System.Drawing.Size(385, 24);
            this.fmgOrgT.TabIndex = 7;
            this.fmgOrgT.Text = "კლიენტის ტიპი";
            // 
            // fmgOrg
            // 
            this.fmgOrg.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgOrg.Appearance.Options.UseFont = true;
            this.fmgOrg.FieldName = "Org";
            this.fmgOrg.Location = new System.Drawing.Point(15, 70);
            this.fmgOrg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgOrg.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgOrg.Name = "fmgOrg";
            this.fmgOrg.ParameterName = null;
            this.fmgOrg.Size = new System.Drawing.Size(385, 24);
            this.fmgOrg.TabIndex = 6;
            this.fmgOrg.Text = "კლიენტი";
            // 
            // fmgProek
            // 
            this.fmgProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProek.Appearance.Options.UseFont = true;
            this.fmgProek.FieldName = "Proek";
            this.fmgProek.Location = new System.Drawing.Point(418, 38);
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
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField7,
            this.pivotGridField8,
            this.pivotGridField9});
            this.ptNashti.Location = new System.Drawing.Point(0, 141);
            this.ptNashti.Name = "ptNashti";
            this.ptNashti.OptionsCustomization.AllowFilter = false;
            this.ptNashti.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.ptNashti.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.ptNashti.Size = new System.Drawing.Size(1247, 403);
            this.ptNashti.TabIndex = 126;
            // 
            // pcolOrg
            // 
            this.pcolOrg.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOrg.AreaIndex = 0;
            this.pcolOrg.Caption = "კლეინტი";
            this.pcolOrg.FieldName = "Org";
            this.pcolOrg.Name = "pcolOrg";
            // 
            // pcolOrgT
            // 
            this.pcolOrgT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOrgT.AreaIndex = 1;
            this.pcolOrgT.Caption = "კლიენტის ტიპი";
            this.pcolOrgT.FieldName = "OrgT";
            this.pcolOrgT.Name = "pcolOrgT";
            // 
            // pcolArea
            // 
            this.pcolArea.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolArea.AreaIndex = 2;
            this.pcolArea.Caption = "ფართობი";
            this.pcolArea.FieldName = "Area";
            this.pcolArea.Name = "pcolArea";
            // 
            // pcolData
            // 
            this.pcolData.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolData.AreaIndex = 3;
            this.pcolData.Caption = "თარიღი";
            this.pcolData.FieldName = "Data";
            this.pcolData.Name = "pcolData";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "კლეინტი";
            this.pivotGridField1.FieldName = "Org";
            this.pivotGridField1.Name = "pivotGridField1";
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "კლიენტის ტიპი";
            this.pivotGridField2.FieldName = "OrgT";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "ფართობი";
            this.pivotGridField3.FieldName = "Area";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.AreaIndex = 0;
            this.pivotGridField4.Caption = "თარიღი";
            this.pivotGridField4.FieldName = "Data";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pcolOperation
            // 
            this.pcolOperation.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolOperation.AreaIndex = 0;
            this.pcolOperation.Caption = "ოპერაცია";
            this.pcolOperation.FieldName = "Operation";
            this.pcolOperation.Name = "pcolOperation";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField5.AreaIndex = 1;
            this.pivotGridField5.Caption = "კლეინტი";
            this.pivotGridField5.FieldName = "Org";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.Caption = "კლიენტის ტიპი";
            this.pivotGridField6.FieldName = "OrgT";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField7.AreaIndex = 0;
            this.pivotGridField7.Caption = "ფართობი";
            this.pivotGridField7.CellFormat.FormatString = "#.00";
            this.pivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField7.FieldName = "Area";
            this.pivotGridField7.Name = "pivotGridField7";
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.Caption = "თარიღი";
            this.pivotGridField8.FieldName = "Data";
            this.pivotGridField8.Name = "pivotGridField8";
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.AreaIndex = 1;
            this.pivotGridField9.Caption = "ოპერაცია";
            this.pivotGridField9.FieldName = "Operation";
            this.pivotGridField9.Name = "pivotGridField9";
            // 
            // prnAreaByOrg
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
            this.Name = "prnAreaByOrg";
            this.Text = "დაკავებული ფართობი ორგანიზაციების მიხედვით";
            this.Load += new System.EventHandler(this.prnAreaByOrg_Load);
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
        private Controls.FMGComboFilterControl fmgOrg;
        private Controls.FMGComboFilterControl fmgProek;
        private Controls.FMGComboFilterControl fmgOrgT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrg;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOrgT;
        private DevExpress.XtraPivotGrid.PivotGridField pcolArea;
        private DevExpress.XtraPivotGrid.PivotGridField pcolData;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pcolOperation;
    }
}