using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class CheckNashtiAgceraForm
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
            this.paTop = new DevExpress.XtraEditors.PanelControl();
            this.btnExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangeProd = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToReal = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToShes = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToGas = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToShem = new DevExpress.XtraEditors.SimpleButton();
            this.btnNashti = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.chbOnlyAgcera = new DevExpress.XtraEditors.CheckEdit();
            this.dgCheckNashtiAgcera = new DevExpress.XtraGrid.GridControl();
            this.gvReal2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNashti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgcera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAgcera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShemTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGasTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMomc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paFilter = new DevExpress.XtraEditors.PanelControl();
            this.fmgProdS = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgMomc = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.colProdT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbOnlyAgcera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckNashtiAgcera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paFilter)).BeginInit();
            this.paFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.btnExportToExcel);
            this.paTop.Controls.Add(this.btnChangeProd);
            this.paTop.Controls.Add(this.btnExportToReal);
            this.paTop.Controls.Add(this.btnExportToShes);
            this.paTop.Controls.Add(this.btnClose);
            this.paTop.Controls.Add(this.btnExportToGas);
            this.paTop.Controls.Add(this.btnExportToShem);
            this.paTop.Controls.Add(this.btnNashti);
            this.paTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTop.Location = new System.Drawing.Point(0, 0);
            this.paTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paTop.Name = "paTop";
            this.paTop.Size = new System.Drawing.Size(1402, 81);
            this.paTop.TabIndex = 0;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToExcel.Appearance.Options.UseFont = true;
            this.btnExportToExcel.Appearance.Options.UseTextOptions = true;
            this.btnExportToExcel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExportToExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportToExcel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_ExportToXLS_32x32;
            this.btnExportToExcel.Location = new System.Drawing.Point(948, 2);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(152, 77);
            this.btnExportToExcel.TabIndex = 6;
            this.btnExportToExcel.Text = "ექსპორტი\r\nExcel-ში";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnChangeProd
            // 
            this.btnChangeProd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeProd.Appearance.Options.UseFont = true;
            this.btnChangeProd.Appearance.Options.UseTextOptions = true;
            this.btnChangeProd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnChangeProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeProd.Image = global::SBS_BarthLogistic.Properties.Resources.convert_32x32;
            this.btnChangeProd.Location = new System.Drawing.Point(771, 2);
            this.btnChangeProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeProd.Name = "btnChangeProd";
            this.btnChangeProd.Size = new System.Drawing.Size(177, 77);
            this.btnChangeProd.TabIndex = 5;
            this.btnChangeProd.Text = "პროდუქციის ცვლილება";
            this.btnChangeProd.Click += new System.EventHandler(this.btnChangeProd_Click);
            // 
            // btnExportToReal
            // 
            this.btnExportToReal.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToReal.Appearance.Options.UseFont = true;
            this.btnExportToReal.Appearance.Options.UseTextOptions = true;
            this.btnExportToReal.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExportToReal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportToReal.Image = global::SBS_BarthLogistic.Properties.Resources.ExpGas;
            this.btnExportToReal.Location = new System.Drawing.Point(608, 2);
            this.btnExportToReal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToReal.Name = "btnExportToReal";
            this.btnExportToReal.Size = new System.Drawing.Size(163, 77);
            this.btnExportToReal.TabIndex = 4;
            this.btnExportToReal.Text = "ექსპორტი\r\nრეალიზაციაში";
            this.btnExportToReal.Click += new System.EventHandler(this.btnExportToShes_Click);
            // 
            // btnExportToShes
            // 
            this.btnExportToShes.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToShes.Appearance.Options.UseFont = true;
            this.btnExportToShes.Appearance.Options.UseTextOptions = true;
            this.btnExportToShes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExportToShes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportToShes.Image = global::SBS_BarthLogistic.Properties.Resources.ExpShem;
            this.btnExportToShes.Location = new System.Drawing.Point(445, 2);
            this.btnExportToShes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToShes.Name = "btnExportToShes";
            this.btnExportToShes.Size = new System.Drawing.Size(163, 77);
            this.btnExportToShes.TabIndex = 3;
            this.btnExportToShes.Text = "ექსპორტი\r\nშესყიდვაში";
            this.btnExportToShes.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnClose.Location = new System.Drawing.Point(1272, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 77);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "დახურვა";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExportToGas
            // 
            this.btnExportToGas.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToGas.Appearance.Options.UseFont = true;
            this.btnExportToGas.Appearance.Options.UseTextOptions = true;
            this.btnExportToGas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExportToGas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportToGas.Image = global::SBS_BarthLogistic.Properties.Resources.ExpGas;
            this.btnExportToGas.Location = new System.Drawing.Point(282, 2);
            this.btnExportToGas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToGas.Name = "btnExportToGas";
            this.btnExportToGas.Size = new System.Drawing.Size(163, 77);
            this.btnExportToGas.TabIndex = 2;
            this.btnExportToGas.Text = "ექსპორტი\r\nგასავალში";
            this.btnExportToGas.Click += new System.EventHandler(this.btnExportToGas_Click);
            // 
            // btnExportToShem
            // 
            this.btnExportToShem.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExportToShem.Appearance.Options.UseFont = true;
            this.btnExportToShem.Appearance.Options.UseTextOptions = true;
            this.btnExportToShem.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnExportToShem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportToShem.Image = global::SBS_BarthLogistic.Properties.Resources.ExpShem;
            this.btnExportToShem.Location = new System.Drawing.Point(119, 2);
            this.btnExportToShem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToShem.Name = "btnExportToShem";
            this.btnExportToShem.Size = new System.Drawing.Size(163, 77);
            this.btnExportToShem.TabIndex = 1;
            this.btnExportToShem.Text = "ექსპორტი\r\nშემოსავალში";
            this.btnExportToShem.Click += new System.EventHandler(this.btnExportToShem_Click);
            // 
            // btnNashti
            // 
            this.btnNashti.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNashti.Appearance.Options.UseFont = true;
            this.btnNashti.Appearance.Options.UseTextOptions = true;
            this.btnNashti.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnNashti.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNashti.Image = global::SBS_BarthLogistic.Properties.Resources.PRC75;
            this.btnNashti.Location = new System.Drawing.Point(2, 2);
            this.btnNashti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNashti.Name = "btnNashti";
            this.btnNashti.Size = new System.Drawing.Size(117, 77);
            this.btnNashti.TabIndex = 0;
            this.btnNashti.Text = "შედარება";
            this.btnNashti.Click += new System.EventHandler(this.btnNashti_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbOnlyAgcera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1402, 49);
            this.panel2.TabIndex = 1;
            // 
            // chbOnlyAgcera
            // 
            this.chbOnlyAgcera.EditValue = true;
            this.chbOnlyAgcera.Location = new System.Drawing.Point(12, 7);
            this.chbOnlyAgcera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbOnlyAgcera.Name = "chbOnlyAgcera";
            this.chbOnlyAgcera.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbOnlyAgcera.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.chbOnlyAgcera.Properties.Appearance.Options.UseFont = true;
            this.chbOnlyAgcera.Properties.Appearance.Options.UseForeColor = true;
            this.chbOnlyAgcera.Properties.AutoWidth = true;
            this.chbOnlyAgcera.Properties.Caption = "ექსპორტი მხოლოდ აღწერაში არსებული პროდუქციებისთვის";
            this.chbOnlyAgcera.Size = new System.Drawing.Size(672, 33);
            this.chbOnlyAgcera.TabIndex = 0;
            this.chbOnlyAgcera.CheckedChanged += new System.EventHandler(this.chbOnlyAgcera_CheckedChanged);
            // 
            // dgCheckNashtiAgcera
            // 
            this.dgCheckNashtiAgcera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCheckNashtiAgcera.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgCheckNashtiAgcera.Location = new System.Drawing.Point(0, 235);
            this.dgCheckNashtiAgcera.MainView = this.gvReal2;
            this.dgCheckNashtiAgcera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCheckNashtiAgcera.Name = "dgCheckNashtiAgcera";
            this.dgCheckNashtiAgcera.Size = new System.Drawing.Size(1402, 587);
            this.dgCheckNashtiAgcera.TabIndex = 3;
            this.dgCheckNashtiAgcera.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReal2});
            // 
            // gvReal2
            // 
            this.gvReal2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvReal2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvReal2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProd,
            this.colProd,
            this.colNashti,
            this.colAgcera,
            this.colShem,
            this.colGas,
            this.colIsAgcera,
            this.colFasi10,
            this.colFasi,
            this.colShemTanxa,
            this.colGasTanxa,
            this.colMomc,
            this.colProdT,
            this.colProdG,
            this.colProdS});
            this.gvReal2.FooterPanelHeight = 1;
            this.gvReal2.GridControl = this.dgCheckNashtiAgcera;
            this.gvReal2.GroupPanelText = "დაჯგუფება";
            this.gvReal2.GroupRowHeight = 1;
            this.gvReal2.Name = "gvReal2";
            this.gvReal2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvReal2.OptionsDetail.AllowZoomDetail = false;
            this.gvReal2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvReal2.OptionsSelection.MultiSelect = true;
            this.gvReal2.OptionsView.ColumnAutoWidth = false;
            this.gvReal2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvReal2.OptionsView.ShowAutoFilterRow = true;
            this.gvReal2.OptionsView.ShowDetailButtons = false;
            this.gvReal2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvReal2.OptionsView.ShowFooter = true;
            this.gvReal2.OptionsView.ShowGroupPanel = false;
            this.gvReal2.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvReal2_RowStyle);
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.OptionsColumn.AllowEdit = false;
            this.colIdProd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
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
            // colNashti
            // 
            this.colNashti.Caption = "ნაშთი";
            this.colNashti.DisplayFormat.FormatString = "{0:0.0###}";
            this.colNashti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNashti.FieldName = "Nashti";
            this.colNashti.Name = "colNashti";
            this.colNashti.OptionsColumn.AllowEdit = false;
            this.colNashti.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nashti", "{0:0.##}")});
            this.colNashti.Visible = true;
            this.colNashti.VisibleIndex = 3;
            this.colNashti.Width = 79;
            // 
            // colAgcera
            // 
            this.colAgcera.Caption = "აღწერა";
            this.colAgcera.FieldName = "Agcera";
            this.colAgcera.Name = "colAgcera";
            this.colAgcera.Visible = true;
            this.colAgcera.VisibleIndex = 2;
            this.colAgcera.Width = 100;
            // 
            // colShem
            // 
            this.colShem.Caption = "დანაკლისი";
            this.colShem.FieldName = "Shem";
            this.colShem.Name = "colShem";
            this.colShem.OptionsColumn.AllowEdit = false;
            this.colShem.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Shem", "{0:0.##}")});
            this.colShem.Visible = true;
            this.colShem.VisibleIndex = 4;
            this.colShem.Width = 104;
            // 
            // colGas
            // 
            this.colGas.Caption = "ზედმეტობა";
            this.colGas.FieldName = "Gas";
            this.colGas.Name = "colGas";
            this.colGas.OptionsColumn.AllowEdit = false;
            this.colGas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gas", "{0:0.##}")});
            this.colGas.Visible = true;
            this.colGas.VisibleIndex = 5;
            this.colGas.Width = 114;
            // 
            // colIsAgcera
            // 
            this.colIsAgcera.Caption = "არის აღწერაში?";
            this.colIsAgcera.FieldName = "IsAgcera";
            this.colIsAgcera.Name = "colIsAgcera";
            this.colIsAgcera.OptionsColumn.AllowEdit = false;
            // 
            // colFasi10
            // 
            this.colFasi10.Caption = "შესასყიდი ფასი";
            this.colFasi10.DisplayFormat.FormatString = "0.00";
            this.colFasi10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFasi10.FieldName = "Fasi10";
            this.colFasi10.Name = "colFasi10";
            this.colFasi10.OptionsColumn.AllowEdit = false;
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
            this.colFasi.VisibleIndex = 6;
            // 
            // colShemTanxa
            // 
            this.colShemTanxa.Caption = "დანაკლისი თანხა";
            this.colShemTanxa.DisplayFormat.FormatString = "0.00";
            this.colShemTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colShemTanxa.FieldName = "ShemTanxa";
            this.colShemTanxa.Name = "colShemTanxa";
            this.colShemTanxa.OptionsColumn.AllowEdit = false;
            this.colShemTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colShemTanxa.UnboundExpression = "[Shem]*[Fasi10]";
            this.colShemTanxa.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colShemTanxa.Visible = true;
            this.colShemTanxa.VisibleIndex = 7;
            this.colShemTanxa.Width = 112;
            // 
            // colGasTanxa
            // 
            this.colGasTanxa.Caption = "ზედმეტობა თანხა";
            this.colGasTanxa.DisplayFormat.FormatString = "0.00";
            this.colGasTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGasTanxa.FieldName = "GasTanxa";
            this.colGasTanxa.Name = "colGasTanxa";
            this.colGasTanxa.OptionsColumn.AllowEdit = false;
            this.colGasTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colGasTanxa.UnboundExpression = "[Gas]*[Fasi10]";
            this.colGasTanxa.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colGasTanxa.Visible = true;
            this.colGasTanxa.VisibleIndex = 8;
            this.colGasTanxa.Width = 124;
            // 
            // colMomc
            // 
            this.colMomc.Caption = "მომწოდებელი";
            this.colMomc.FieldName = "Momc";
            this.colMomc.Name = "colMomc";
            this.colMomc.Width = 126;
            // 
            // paFilter
            // 
            this.paFilter.Controls.Add(this.fmgProdS);
            this.paFilter.Controls.Add(this.fmgMomc);
            this.paFilter.Controls.Add(this.fmgProdT);
            this.paFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.paFilter.Location = new System.Drawing.Point(0, 130);
            this.paFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paFilter.Name = "paFilter";
            this.paFilter.Size = new System.Drawing.Size(1402, 105);
            this.paFilter.TabIndex = 2;
            this.paFilter.Visible = false;
            // 
            // fmgProdS
            // 
            this.fmgProdS.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdS.Appearance.Options.UseFont = true;
            this.fmgProdS.FieldName = "ProdS";
            this.fmgProdS.Location = new System.Drawing.Point(12, 12);
            this.fmgProdS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdS.MinimumSize = new System.Drawing.Size(524, 32);
            this.fmgProdS.Name = "fmgProdS";
            this.fmgProdS.ParameterName = null;
            this.fmgProdS.Size = new System.Drawing.Size(524, 32);
            this.fmgProdS.TabIndex = 0;
            this.fmgProdS.Text = "პროდ.სახეობა";
            // 
            // fmgMomc
            // 
            this.fmgMomc.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgMomc.Appearance.Options.UseFont = true;
            this.fmgMomc.FieldName = "Momc";
            this.fmgMomc.Location = new System.Drawing.Point(554, 12);
            this.fmgMomc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgMomc.MinimumSize = new System.Drawing.Size(524, 32);
            this.fmgMomc.Name = "fmgMomc";
            this.fmgMomc.ParameterName = null;
            this.fmgMomc.Size = new System.Drawing.Size(524, 32);
            this.fmgMomc.TabIndex = 2;
            this.fmgMomc.Text = "მომწოდებელი";
            // 
            // fmgProdT
            // 
            this.fmgProdT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdT.Appearance.Options.UseFont = true;
            this.fmgProdT.FieldName = "ProdT";
            this.fmgProdT.Location = new System.Drawing.Point(12, 54);
            this.fmgProdT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdT.MinimumSize = new System.Drawing.Size(524, 32);
            this.fmgProdT.Name = "fmgProdT";
            this.fmgProdT.ParameterName = null;
            this.fmgProdT.Size = new System.Drawing.Size(524, 32);
            this.fmgProdT.TabIndex = 1;
            this.fmgProdT.Text = "პროდ. ტიპი";
            // 
            // colProdT
            // 
            this.colProdT.Caption = "პროდ.ტიპი";
            this.colProdT.FieldName = "ProdT";
            this.colProdT.Name = "colProdT";
            this.colProdT.Visible = true;
            this.colProdT.VisibleIndex = 9;
            this.colProdT.Width = 135;
            // 
            // colProdG
            // 
            this.colProdG.Caption = "პროდ.ჯგუფი";
            this.colProdG.FieldName = "ProdG";
            this.colProdG.Name = "colProdG";
            this.colProdG.Visible = true;
            this.colProdG.VisibleIndex = 10;
            this.colProdG.Width = 154;
            // 
            // colProdS
            // 
            this.colProdS.Caption = "პროდ.სახეობა";
            this.colProdS.FieldName = "ProdS";
            this.colProdS.Name = "colProdS";
            this.colProdS.Visible = true;
            this.colProdS.VisibleIndex = 11;
            this.colProdS.Width = 154;
            // 
            // CheckNashtiAgceraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 822);
            this.Controls.Add(this.dgCheckNashtiAgcera);
            this.Controls.Add(this.paFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckNashtiAgceraForm";
            this.Text = "აღწერის შედარება მიმდინარე ნაშთთან";
            this.Load += new System.EventHandler(this.CheckNashtiAgceraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbOnlyAgcera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckNashtiAgcera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paFilter)).EndInit();
            this.paFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl paTop;
        private DevExpress.XtraEditors.SimpleButton btnNashti;
        private DevExpress.XtraGrid.GridControl dgCheckNashtiAgcera;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReal2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colNashti;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnExportToGas;
        private DevExpress.XtraEditors.SimpleButton btnExportToShem;
        private PanelControl panel2;
        private DevExpress.XtraEditors.CheckEdit chbOnlyAgcera;
        private DevExpress.XtraGrid.Columns.GridColumn colAgcera;
        private DevExpress.XtraGrid.Columns.GridColumn colShem;
        private DevExpress.XtraGrid.Columns.GridColumn colGas;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAgcera;
        private DevExpress.XtraEditors.SimpleButton btnExportToExcel;
        private DevExpress.XtraEditors.SimpleButton btnExportToReal;
        private DevExpress.XtraEditors.SimpleButton btnExportToShes;
        private PanelControl paFilter;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi10;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colShemTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colGasTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colMomc;
        private Controls.FMGComboFilterControl fmgProdT;
        private Controls.FMGComboFilterControl fmgMomc;
        private Controls.FMGComboFilterControl fmgProdS;
        private SimpleButton btnChangeProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProdT;
        private DevExpress.XtraGrid.Columns.GridColumn colProdG;
        private DevExpress.XtraGrid.Columns.GridColumn colProdS;
    }
}