using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class GenerateShesShekForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateShesShekForm));
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.fmgProdT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdTG = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdG = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdS = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgShesShek = new DevExpress.XtraGrid.GridControl();
            this.gvShesShek = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSulRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgProekShesShek = new DevExpress.XtraGrid.GridControl();
            this.gvProekShesShek = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekShek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekNashti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccepted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProek1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShesShek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShesShek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProekShesShek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProekShesShek)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExportExcel);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.fmgProdT);
            this.panel2.Controls.Add(this.fmgProdTG);
            this.panel2.Controls.Add(this.fmgProdG);
            this.panel2.Controls.Add(this.fmgProdS);
            this.panel2.Controls.Add(this.fmgData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 118);
            this.panel2.TabIndex = 0;
            // 
            // fmgProdT
            // 
            this.fmgProdT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdT.Appearance.Options.UseFont = true;
            this.fmgProdT.FieldName = "ProdT";
            this.fmgProdT.Location = new System.Drawing.Point(12, 76);
            this.fmgProdT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdT.MinimumSize = new System.Drawing.Size(385, 24);
            this.fmgProdT.Name = "fmgProdT";
            this.fmgProdT.ParameterName = null;
            this.fmgProdT.Size = new System.Drawing.Size(385, 24);
            this.fmgProdT.TabIndex = 16;
            this.fmgProdT.Text = "პროდ. ტიპი";
            // 
            // fmgProdTG
            // 
            this.fmgProdTG.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdTG.Appearance.Options.UseFont = true;
            this.fmgProdTG.FieldName = "ProdTG";
            this.fmgProdTG.Location = new System.Drawing.Point(417, 76);
            this.fmgProdTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdTG.MinimumSize = new System.Drawing.Size(385, 24);
            this.fmgProdTG.Name = "fmgProdTG";
            this.fmgProdTG.ParameterName = null;
            this.fmgProdTG.Size = new System.Drawing.Size(385, 24);
            this.fmgProdTG.TabIndex = 15;
            this.fmgProdTG.Text = "პროდ.ტიპ.ჯგ";
            // 
            // fmgProdG
            // 
            this.fmgProdG.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdG.Appearance.Options.UseFont = true;
            this.fmgProdG.FieldName = "ProdG";
            this.fmgProdG.Location = new System.Drawing.Point(417, 44);
            this.fmgProdG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdG.MinimumSize = new System.Drawing.Size(385, 24);
            this.fmgProdG.Name = "fmgProdG";
            this.fmgProdG.ParameterName = null;
            this.fmgProdG.Size = new System.Drawing.Size(385, 24);
            this.fmgProdG.TabIndex = 12;
            this.fmgProdG.Text = "პროდ. ჯგუფი";
            // 
            // fmgProdS
            // 
            this.fmgProdS.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdS.Appearance.Options.UseFont = true;
            this.fmgProdS.FieldName = "ProdS";
            this.fmgProdS.Location = new System.Drawing.Point(12, 44);
            this.fmgProdS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdS.MinimumSize = new System.Drawing.Size(385, 24);
            this.fmgProdS.Name = "fmgProdS";
            this.fmgProdS.ParameterName = null;
            this.fmgProdS.Size = new System.Drawing.Size(385, 24);
            this.fmgProdS.TabIndex = 11;
            this.fmgProdS.Text = "პროდ.სახეობა";
            // 
            // fmgData
            // 
            this.fmgData.AlwaysChecked = true;
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.AutoSize = true;
            this.fmgData.Checked = true;
            this.fmgData.FieldName = "Data";
            this.fmgData.Location = new System.Drawing.Point(12, 11);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgData.MinimumSize = new System.Drawing.Size(330, 21);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = "D";
            this.fmgData.Size = new System.Drawing.Size(330, 24);
            this.fmgData.TabIndex = 1;
            this.fmgData.Text = "თარიღი";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 571);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(833, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(742, 6);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 118);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgShesShek);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgProekShesShek);
            this.splitContainer1.Size = new System.Drawing.Size(921, 453);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 36;
            // 
            // dgShesShek
            // 
            this.dgShesShek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgShesShek.Location = new System.Drawing.Point(0, 0);
            this.dgShesShek.MainView = this.gvShesShek;
            this.dgShesShek.Name = "dgShesShek";
            this.dgShesShek.Size = new System.Drawing.Size(495, 453);
            this.dgShesShek.TabIndex = 36;
            this.dgShesShek.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShesShek});
            // 
            // gvShesShek
            // 
            this.gvShesShek.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvShesShek.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvShesShek.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProd,
            this.colRaod,
            this.colFasi,
            this.colSulRaod,
            this.colTanxa,
            this.colIdProd});
            this.gvShesShek.FooterPanelHeight = 1;
            this.gvShesShek.GridControl = this.dgShesShek;
            this.gvShesShek.GroupPanelText = "დაჯგუფება";
            this.gvShesShek.GroupRowHeight = 1;
            this.gvShesShek.Name = "gvShesShek";
            this.gvShesShek.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvShesShek.OptionsDetail.AllowZoomDetail = false;
            this.gvShesShek.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvShesShek.OptionsSelection.MultiSelect = true;
            this.gvShesShek.OptionsView.ColumnAutoWidth = false;
            this.gvShesShek.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvShesShek.OptionsView.ShowAutoFilterRow = true;
            this.gvShesShek.OptionsView.ShowDetailButtons = false;
            this.gvShesShek.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvShesShek.OptionsView.ShowFooter = true;
            this.gvShesShek.OptionsView.ShowGroupPanel = false;
            this.gvShesShek.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvShesShek_CellValueChanged);
            // 
            // colProd
            // 
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.OptionsColumn.AllowEdit = false;
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 173;
            // 
            // colRaod
            // 
            this.colRaod.Caption = "ნაშთი";
            this.colRaod.DisplayFormat.FormatString = "{0:0.##}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRaod.FieldName = "Nashti";
            this.colRaod.Name = "colRaod";
            this.colRaod.OptionsColumn.AllowEdit = false;
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Raod", "{0:#.##}")});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 127;
            // 
            // colFasi
            // 
            this.colFasi.Caption = "ფასი";
            this.colFasi.DisplayFormat.FormatString = "{0:0.00}";
            this.colFasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.OptionsColumn.AllowEdit = false;
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 4;
            this.colFasi.Width = 63;
            // 
            // colSulRaod
            // 
            this.colSulRaod.Caption = "შეკვეთა";
            this.colSulRaod.FieldName = "Raod";
            this.colSulRaod.Name = "colSulRaod";
            this.colSulRaod.Visible = true;
            this.colSulRaod.VisibleIndex = 3;
            this.colSulRaod.Width = 134;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "{0:0.00}";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.OptionsColumn.AllowEdit = false;
            this.colTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tanxa", "{0:#.00}")});
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 5;
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.OptionsColumn.AllowEdit = false;
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            this.colIdProd.Width = 102;
            // 
            // dgProekShesShek
            // 
            this.dgProekShesShek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProekShesShek.Location = new System.Drawing.Point(0, 0);
            this.dgProekShesShek.MainView = this.gvProekShesShek;
            this.dgProekShesShek.Name = "dgProekShesShek";
            this.dgProekShesShek.Size = new System.Drawing.Size(423, 453);
            this.dgProekShesShek.TabIndex = 37;
            this.dgProekShesShek.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProekShesShek});
            this.dgProekShesShek.DoubleClick += new System.EventHandler(this.dgProekShesShek_DoubleClick);
            // 
            // gvProekShesShek
            // 
            this.gvProekShesShek.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvProekShesShek.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProekShesShek.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProek,
            this.colProekShek,
            this.colProekNashti,
            this.colAccepted,
            this.colIdProek1,
            this.colProekIdProd});
            this.gvProekShesShek.FooterPanelHeight = 1;
            this.gvProekShesShek.GridControl = this.dgProekShesShek;
            this.gvProekShesShek.GroupPanelText = "დაჯგუფება";
            this.gvProekShesShek.GroupRowHeight = 1;
            this.gvProekShesShek.Name = "gvProekShesShek";
            this.gvProekShesShek.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvProekShesShek.OptionsDetail.AllowZoomDetail = false;
            this.gvProekShesShek.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvProekShesShek.OptionsSelection.MultiSelect = true;
            this.gvProekShesShek.OptionsView.ColumnAutoWidth = false;
            this.gvProekShesShek.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvProekShesShek.OptionsView.ShowAutoFilterRow = true;
            this.gvProekShesShek.OptionsView.ShowDetailButtons = false;
            this.gvProekShesShek.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvProekShesShek.OptionsView.ShowFooter = true;
            this.gvProekShesShek.OptionsView.ShowGroupPanel = false;
            // 
            // colProek
            // 
            this.colProek.Caption = "ობიექტი";
            this.colProek.FieldName = "Proek";
            this.colProek.Name = "colProek";
            this.colProek.Visible = true;
            this.colProek.VisibleIndex = 0;
            this.colProek.Width = 278;
            // 
            // colProekShek
            // 
            this.colProekShek.Caption = "შეკვეთილი";
            this.colProekShek.FieldName = "Raod";
            this.colProekShek.Name = "colProekShek";
            this.colProekShek.Visible = true;
            this.colProekShek.VisibleIndex = 1;
            this.colProekShek.Width = 88;
            // 
            // colProekNashti
            // 
            this.colProekNashti.Caption = "ნაშთი";
            this.colProekNashti.FieldName = "Nashti";
            this.colProekNashti.Name = "colProekNashti";
            this.colProekNashti.OptionsColumn.AllowEdit = false;
            this.colProekNashti.Visible = true;
            this.colProekNashti.VisibleIndex = 2;
            // 
            // colAccepted
            // 
            this.colAccepted.Caption = "დაკმაყოფილდა";
            this.colAccepted.FieldName = "Accepted";
            this.colAccepted.Name = "colAccepted";
            this.colAccepted.OptionsColumn.AllowEdit = false;
            this.colAccepted.Width = 122;
            // 
            // colIdProek1
            // 
            this.colIdProek1.Caption = "IdProek1";
            this.colIdProek1.FieldName = "IdProek1";
            this.colIdProek1.Name = "colIdProek1";
            this.colIdProek1.Visible = true;
            this.colIdProek1.VisibleIndex = 3;
            // 
            // colProekIdProd
            // 
            this.colProekIdProd.Caption = "IdProd";
            this.colProekIdProd.FieldName = "IdProd";
            this.colProekIdProd.Name = "colProekIdProd";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(417, 11);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 22);
            this.btnFind.TabIndex = 39;
            this.btnFind.Text = "ძებნა";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(570, 11);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(232, 22);
            this.btnExportExcel.TabIndex = 40;
            this.btnExportExcel.Text = "ექსელში ექსპორტი";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // GenerateShesShekForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 612);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GenerateShesShekForm";
            this.Text = "შეკვეთის გენერირება ობიექტის შეკვეთების მიხედვით";
            this.Load += new System.EventHandler(this.GenerateShesShekToShesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgShesShek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShesShek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProekShesShek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProekShesShek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel2;
        private PanelControl panel1;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private Controls.FMGDateFilterControl fmgData;
        private Controls.FMGComboFilterControl fmgProdG;
        private Controls.FMGComboFilterControl fmgProdS;
        private Controls.FMGComboFilterControl fmgProdT;
        private Controls.FMGComboFilterControl fmgProdTG;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl dgShesShek;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShesShek;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colSulRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.GridControl dgProekShesShek;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProekShesShek;
        private DevExpress.XtraGrid.Columns.GridColumn colProek;
        private DevExpress.XtraGrid.Columns.GridColumn colProekShek;
        private DevExpress.XtraGrid.Columns.GridColumn colProekNashti;
        private DevExpress.XtraGrid.Columns.GridColumn colAccepted;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProek1;
        private DevExpress.XtraGrid.Columns.GridColumn colProekIdProd;
        private SimpleButton btnExportExcel;
        private SimpleButton btnFind;
    }
}