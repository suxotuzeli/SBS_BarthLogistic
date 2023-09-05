namespace SBS_BuilderBudjet.WayBill
{
    partial class WayBillImportShesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgDet = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdShes2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdVada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTvitg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtWayBillData = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label13 = new System.Windows.Forms.Label();
            this.chbMomcSagad = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbMomc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWayBillSagad = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWayBillData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWayBillData.Calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgDet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 612);
            this.panel2.TabIndex = 1;
            // 
            // dgDet
            // 
            this.dgDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDet.Location = new System.Drawing.Point(0, 0);
            this.dgDet.MainView = this.gridView2;
            this.dgDet.Name = "dgDet";
            this.dgDet.Size = new System.Drawing.Size(751, 612);
            this.dgDet.TabIndex = 32;
            this.dgDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdShes2,
            this.colIdProd,
            this.colProd,
            this.colRaod,
            this.colFasi,
            this.colTanxa,
            this.colProdVada,
            this.colTvitg});
            this.gridView2.FooterPanelHeight = 1;
            this.gridView2.GridControl = this.dgDet;
            this.gridView2.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView2.GroupPanelText = "დაჯგუფება";
            this.gridView2.GroupRowHeight = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.AllowZoomDetail = false;
            this.gridView2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdShes2
            // 
            this.colIdShes2.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colIdShes2.AppearanceHeader.Options.UseFont = true;
            this.colIdShes2.Caption = "IdShes2";
            this.colIdShes2.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colIdShes2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIdShes2.FieldName = "IdShes2";
            this.colIdShes2.Name = "colIdShes2";
            // 
            // colIdProd
            // 
            this.colIdProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colIdProd.AppearanceHeader.Options.UseFont = true;
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            // 
            // colProd
            // 
            this.colProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colProd.AppearanceHeader.Options.UseFont = true;
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 173;
            // 
            // colRaod
            // 
            this.colRaod.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colRaod.AppearanceHeader.Options.UseFont = true;
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "{0:0.####}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRaod.FieldName = "Raod";
            this.colRaod.Name = "colRaod";
            this.colRaod.SummaryItem.DisplayFormat = "{0:0.###}";
            this.colRaod.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 106;
            // 
            // colFasi
            // 
            this.colFasi.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colFasi.AppearanceHeader.Options.UseFont = true;
            this.colFasi.Caption = "ფასი";
            this.colFasi.DisplayFormat.FormatString = "{0:0.00##}";
            this.colFasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 3;
            // 
            // colTanxa
            // 
            this.colTanxa.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colTanxa.AppearanceHeader.Options.UseFont = true;
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "{0:0.00##}";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.SummaryItem.DisplayFormat = "{0:0.00##}";
            this.colTanxa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 4;
            // 
            // colProdVada
            // 
            this.colProdVada.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProdVada.AppearanceHeader.Options.UseFont = true;
            this.colProdVada.Caption = "ვადა";
            this.colProdVada.FieldName = "ProdVada";
            this.colProdVada.Name = "colProdVada";
            this.colProdVada.Visible = true;
            this.colProdVada.VisibleIndex = 5;
            // 
            // colTvitg
            // 
            this.colTvitg.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colTvitg.AppearanceHeader.Options.UseFont = true;
            this.colTvitg.Caption = "თვითღირებულება";
            this.colTvitg.DisplayFormat.FormatString = "{0:#.00##}";
            this.colTvitg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTvitg.FieldName = "Tvitg";
            this.colTvitg.Name = "colTvitg";
            this.colTvitg.Visible = true;
            this.colTvitg.VisibleIndex = 6;
            this.colTvitg.Width = 123;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.txtWayBillSagad);
            this.panel3.Controls.Add(this.cbMomc);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.chbMomcSagad);
            this.panel3.Controls.Add(this.txtWayBillData);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 104);
            this.panel3.TabIndex = 2;
            // 
            // txtWayBillData
            // 
            // 
            // 
            // 
            this.txtWayBillData.Calendar.AllowMultipleSelection = false;
            this.txtWayBillData.Calendar.Culture = new System.Globalization.CultureInfo("");
            this.txtWayBillData.Calendar.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.txtWayBillData.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWayBillData.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWayBillData.Calendar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWayBillData.Calendar.Location = new System.Drawing.Point(0, 0);
            this.txtWayBillData.Calendar.MinValue = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtWayBillData.Calendar.Name = "monthCalendar";
            this.txtWayBillData.Calendar.SelectedDates = new System.DateTime[] {
        new System.DateTime(2007, 2, 24, 12, 22, 2, 734)};
            this.txtWayBillData.Calendar.Size = new System.Drawing.Size(217, 174);
            this.txtWayBillData.Calendar.SizeToFit = true;
            this.txtWayBillData.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.txtWayBillData.Calendar.TabIndex = 0;
            this.txtWayBillData.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.txtWayBillData.Calendar.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.txtWayBillData.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP;
            this.txtWayBillData.Calendar.NoneButton.Location = new System.Drawing.Point(145, 0);
            this.txtWayBillData.Calendar.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.txtWayBillData.Calendar.NoneButton.Text = "None";
            // 
            // 
            // 
            this.txtWayBillData.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP;
            this.txtWayBillData.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.txtWayBillData.Calendar.TodayButton.Size = new System.Drawing.Size(145, 20);
            this.txtWayBillData.Calendar.TodayButton.Text = "Today";
            this.txtWayBillData.ClipboardFormat = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtWayBillData.CustomFormat = "dd.MM.yyyy";
            this.txtWayBillData.DropDownImage = null;
            this.txtWayBillData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtWayBillData.Location = new System.Drawing.Point(70, 8);
            this.txtWayBillData.Name = "txtWayBillData";
            this.txtWayBillData.NoneButtonVisible = false;
            this.txtWayBillData.ShowCheckBox = false;
            this.txtWayBillData.Size = new System.Drawing.Size(107, 20);
            this.txtWayBillData.TabIndex = 76;
            this.txtWayBillData.Value = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 77;
            this.label13.Text = "თარიღი";
            // 
            // chbMomcSagad
            // 
            this.chbMomcSagad.AutoSize = true;
            this.chbMomcSagad.Checked = true;
            this.chbMomcSagad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMomcSagad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMomcSagad.Location = new System.Drawing.Point(251, 8);
            this.chbMomcSagad.Name = "chbMomcSagad";
            this.chbMomcSagad.Size = new System.Drawing.Size(88, 20);
            this.chbMomcSagad.TabIndex = 78;
            this.chbMomcSagad.Text = "საიდ. კოდი";
            this.chbMomcSagad.UseVisualStyleBackColor = true;
            this.chbMomcSagad.CheckedChanged += new System.EventHandler(this.chbSagad_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(639, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 104);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbMomc
            // 
            this.cbMomc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMomc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMomc.FormattingEnabled = true;
            this.cbMomc.Location = new System.Drawing.Point(170, 56);
            this.cbMomc.Name = "cbMomc";
            this.cbMomc.Size = new System.Drawing.Size(351, 21);
            this.cbMomc.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(11, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 16);
            this.label14.TabIndex = 83;
            this.label14.Text = "ზედნადები/მომწოდებელი";
            // 
            // txtWayBillSagad
            // 
            this.txtWayBillSagad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWayBillSagad.Location = new System.Drawing.Point(365, 5);
            this.txtWayBillSagad.Name = "txtWayBillSagad";
            this.txtWayBillSagad.Size = new System.Drawing.Size(156, 22);
            this.txtWayBillSagad.TabIndex = 84;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(527, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 104);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // WayBillImportShesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "WayBillImportShesForm";
            this.Text = "WayBillImportShesForm";
            this.Load += new System.EventHandler(this.WayBillImportShesForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWayBillData.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWayBillData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgDet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdShes2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colProdVada;
        private DevExpress.XtraGrid.Columns.GridColumn colTvitg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtWayBillSagad;
        private System.Windows.Forms.ComboBox cbMomc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chbMomcSagad;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv txtWayBillData;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
    }
}