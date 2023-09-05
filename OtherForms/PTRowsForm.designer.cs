namespace SBS_Market.OtherForms
{
    partial class PTRowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PTRowsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbExportFormat = new System.Windows.Forms.ToolStripComboBox();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.dg = new DevExpress.XtraGrid.GridControl();
            this.dgv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbExportFormat,
            this.btnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbExportFormat
            // 
            this.cbExportFormat.Items.AddRange(new object[] {
            "Export To Excel",
            "Export To Word",
            "Export To Pdf",
            "Export To Text",
            "Export To HTML"});
            this.cbExportFormat.Name = "cbExportFormat";
            this.cbExportFormat.Size = new System.Drawing.Size(121, 25);
            this.cbExportFormat.Text = "Export To Excel";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "ბეჭდვა";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dg
            // 
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EmbeddedNavigator.Name = "";
            this.dg.Location = new System.Drawing.Point(0, 25);
            this.dg.MainView = this.dgv;
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(831, 394);
            this.dg.TabIndex = 6;
            this.dg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv});
            // 
            // dgv
            // 
            this.dgv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.dgv.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgv.FooterPanelHeight = 1;
            this.dgv.GridControl = this.dg;
            this.dgv.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.dgv.GroupPanelText = "დაჯგუფება";
            this.dgv.GroupRowHeight = 1;
            this.dgv.Name = "dgv";
            this.dgv.OptionsBehavior.Editable = false;
            this.dgv.OptionsDetail.AllowZoomDetail = false;
            this.dgv.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.dgv.OptionsView.ColumnAutoWidth = false;
            this.dgv.OptionsView.EnableAppearanceOddRow = true;
            this.dgv.OptionsView.ShowAutoFilterRow = true;
            this.dgv.OptionsView.ShowChildrenInGroupPanel = true;
            this.dgv.OptionsView.ShowDetailButtons = false;
            this.dgv.OptionsView.ShowFooter = true;
            this.dgv.OptionsView.ShowGroupedColumns = true;
            // 
            // PTRowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 419);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PTRowsForm";
            this.Text = "PTRowsForm";
            this.Load += new System.EventHandler(this.PTRowsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl dg;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv;
        private System.Windows.Forms.ToolStripComboBox cbExportFormat;
        private System.Windows.Forms.ToolStripButton btnPrint;
    }
}