namespace SBS_BarthLogistic.OtherForms
{
    partial class DailyFees
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
            this.dgOrg = new DevExpress.XtraGrid.GridControl();
            this.gvOrg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxaTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
            this.chbClient = new DevExpress.XtraEditors.CheckEdit();
            this.cbOrg = new DevExpress.XtraEditors.LookUpEdit();
            this.fmgPeriod = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrg
            // 
            this.dgOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrg.Location = new System.Drawing.Point(0, 94);
            this.dgOrg.MainView = this.gvOrg;
            this.dgOrg.Name = "dgOrg";
            this.dgOrg.Size = new System.Drawing.Size(800, 356);
            this.dgOrg.TabIndex = 5;
            this.dgOrg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrg});
            // 
            // gvOrg
            // 
            this.gvOrg.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvOrg.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvOrg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrg,
            this.colOrg,
            this.colService,
            this.colTanxa,
            this.colTanxaTotal,
            this.colData1,
            this.colData2});
            this.gvOrg.CustomizationFormBounds = new System.Drawing.Rectangle(861, 484, 208, 191);
            this.gvOrg.FooterPanelHeight = 1;
            this.gvOrg.GridControl = this.dgOrg;
            this.gvOrg.GroupPanelText = "დაჯგუფება";
            this.gvOrg.GroupRowHeight = 1;
            this.gvOrg.Name = "gvOrg";
            this.gvOrg.OptionsBehavior.Editable = false;
            this.gvOrg.OptionsDetail.AllowZoomDetail = false;
            this.gvOrg.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvOrg.OptionsView.ColumnAutoWidth = false;
            this.gvOrg.OptionsView.EnableAppearanceOddRow = true;
            this.gvOrg.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvOrg.OptionsView.ShowAutoFilterRow = true;
            this.gvOrg.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvOrg.OptionsView.ShowDetailButtons = false;
            this.gvOrg.OptionsView.ShowFooter = true;
            this.gvOrg.OptionsView.ShowGroupedColumns = true;
            this.gvOrg.OptionsView.ShowGroupPanel = false;
            // 
            // colIdOrg
            // 
            this.colIdOrg.Caption = "#";
            this.colIdOrg.FieldName = "IdOrg";
            this.colIdOrg.Name = "colIdOrg";
            // 
            // colOrg
            // 
            this.colOrg.Caption = "კლიენტი";
            this.colOrg.FieldName = "Org";
            this.colOrg.Name = "colOrg";
            this.colOrg.Visible = true;
            this.colOrg.VisibleIndex = 0;
            this.colOrg.Width = 179;
            // 
            // colService
            // 
            this.colService.Caption = "სერვისი";
            this.colService.FieldName = "Service";
            this.colService.Name = "colService";
            this.colService.Visible = true;
            this.colService.VisibleIndex = 1;
            this.colService.Width = 147;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "დღიური თანხა";
            this.colTanxa.DisplayFormat.FormatString = "##.00";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 4;
            this.colTanxa.Width = 136;
            // 
            // colTanxaTotal
            // 
            this.colTanxaTotal.Caption = "ჯარმური თანხა";
            this.colTanxaTotal.DisplayFormat.FormatString = "#.00";
            this.colTanxaTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxaTotal.FieldName = "TanxaTotal";
            this.colTanxaTotal.Name = "colTanxaTotal";
            this.colTanxaTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalTanxa", "{0:0.##}")});
            this.colTanxaTotal.Visible = true;
            this.colTanxaTotal.VisibleIndex = 5;
            // 
            // colData1
            // 
            this.colData1.Caption = "საწ. თარიღი";
            this.colData1.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colData1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData1.FieldName = "Data1";
            this.colData1.Name = "colData1";
            this.colData1.Visible = true;
            this.colData1.VisibleIndex = 2;
            // 
            // colData2
            // 
            this.colData2.Caption = "საბოლ. თარიღი";
            this.colData2.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colData2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData2.FieldName = "Data2";
            this.colData2.Name = "colData2";
            this.colData2.Visible = true;
            this.colData2.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnCalculate);
            this.groupControl1.Controls.Add(this.chbClient);
            this.groupControl1.Controls.Add(this.cbOrg);
            this.groupControl1.Controls.Add(this.fmgPeriod);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 94);
            this.groupControl1.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.save_16x16;
            this.btnSave.Location = new System.Drawing.Point(672, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "შენახვა";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.showformulas_16x16;
            this.btnCalculate.Location = new System.Drawing.Point(672, 24);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "დაგენერირება";
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // chbClient
            // 
            this.chbClient.Location = new System.Drawing.Point(13, 55);
            this.chbClient.Name = "chbClient";
            this.chbClient.Properties.Caption = "კლიენტი";
            this.chbClient.Size = new System.Drawing.Size(75, 19);
            this.chbClient.TabIndex = 3;
            this.chbClient.CheckedChanged += new System.EventHandler(this.ChbClient_CheckedChanged);
            // 
            // cbOrg
            // 
            this.cbOrg.Location = new System.Drawing.Point(167, 54);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrg.Properties.Appearance.Options.UseFont = true;
            this.cbOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrg.Size = new System.Drawing.Size(231, 22);
            this.cbOrg.TabIndex = 2;
            this.cbOrg.Visible = false;
            // 
            // fmgPeriod
            // 
            this.fmgPeriod.AlwaysChecked = true;
            this.fmgPeriod.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgPeriod.Appearance.Options.UseFont = true;
            this.fmgPeriod.AutoSize = true;
            this.fmgPeriod.Checked = true;
            this.fmgPeriod.FieldName = null;
            this.fmgPeriod.Location = new System.Drawing.Point(13, 24);
            this.fmgPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fmgPeriod.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgPeriod.Name = "fmgPeriod";
            this.fmgPeriod.ParameterName = null;
            this.fmgPeriod.Size = new System.Drawing.Size(385, 23);
            this.fmgPeriod.TabIndex = 0;
            this.fmgPeriod.Text = "პერიოდი";
            // 
            // DailyFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgOrg);
            this.Controls.Add(this.groupControl1);
            this.Name = "DailyFees";
            this.ShowIcon = false;
            this.Text = "კლიენტების ყოველდღიური დარიცხვა";
            this.Load += new System.EventHandler(this.DailyFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgOrg;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colOrg;
        private DevExpress.XtraGrid.Columns.GridColumn colService;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Controls.FMGDateFilterControl fmgPeriod;
        private DevExpress.XtraEditors.CheckEdit chbClient;
        private DevExpress.XtraEditors.LookUpEdit cbOrg;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCalculate;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxaTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colData1;
        private DevExpress.XtraGrid.Columns.GridColumn colData2;
    }
}