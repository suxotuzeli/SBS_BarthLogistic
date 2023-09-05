namespace SBS_BarthLogistic.OtherForms
{
    partial class ProdBarcodesForm
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
            this.dgProdBarCode = new DevExpress.XtraGrid.GridControl();
            this.gvProdBarCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProdBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCodeProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarCodeIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProdBarCode
            // 
            this.dgProdBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProdBarCode.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgProdBarCode.Location = new System.Drawing.Point(0, 0);
            this.dgProdBarCode.MainView = this.gvProdBarCode;
            this.dgProdBarCode.Name = "dgProdBarCode";
            this.dgProdBarCode.Size = new System.Drawing.Size(1076, 482);
            this.dgProdBarCode.TabIndex = 15;
            this.dgProdBarCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProdBarCode});
            // 
            // gvProdBarCode
            // 
            this.gvProdBarCode.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvProdBarCode.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProdBarCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProdBarCode,
            this.colBarCode,
            this.colBarCodeProd,
            this.colBarCodeIdProd});
            this.gvProdBarCode.CustomizationFormBounds = new System.Drawing.Rectangle(862, 484, 208, 191);
            this.gvProdBarCode.FooterPanelHeight = 1;
            this.gvProdBarCode.GridControl = this.dgProdBarCode;
            this.gvProdBarCode.GroupPanelText = "დაჯგუფება";
            this.gvProdBarCode.GroupRowHeight = 1;
            this.gvProdBarCode.Name = "gvProdBarCode";
            this.gvProdBarCode.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvProdBarCode.OptionsBehavior.Editable = false;
            this.gvProdBarCode.OptionsDetail.AllowZoomDetail = false;
            this.gvProdBarCode.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvProdBarCode.OptionsSelection.MultiSelect = true;
            this.gvProdBarCode.OptionsView.ColumnAutoWidth = false;
            this.gvProdBarCode.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvProdBarCode.OptionsView.ShowAutoFilterRow = true;
            this.gvProdBarCode.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvProdBarCode.OptionsView.ShowDetailButtons = false;
            this.gvProdBarCode.OptionsView.ShowFooter = true;
            this.gvProdBarCode.OptionsView.ShowGroupedColumns = true;
            this.gvProdBarCode.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProdBarCode
            // 
            this.colIdProdBarCode.Caption = "#";
            this.colIdProdBarCode.FieldName = "IdProdBarCode";
            this.colIdProdBarCode.Name = "colIdProdBarCode";
            this.colIdProdBarCode.Width = 169;
            // 
            // colBarCode
            // 
            this.colBarCode.Caption = "ალტერნატიული კოდი";
            this.colBarCode.FieldName = "BarCode";
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.Visible = true;
            this.colBarCode.VisibleIndex = 0;
            this.colBarCode.Width = 200;
            // 
            // colBarCodeProd
            // 
            this.colBarCodeProd.Caption = "პროდუქცია";
            this.colBarCodeProd.FieldName = "Prod";
            this.colBarCodeProd.Name = "colBarCodeProd";
            this.colBarCodeProd.Visible = true;
            this.colBarCodeProd.VisibleIndex = 2;
            this.colBarCodeProd.Width = 380;
            // 
            // colBarCodeIdProd
            // 
            this.colBarCodeIdProd.Caption = "პროდუქციის კოდი";
            this.colBarCodeIdProd.FieldName = "IdProd";
            this.colBarCodeIdProd.Name = "colBarCodeIdProd";
            this.colBarCodeIdProd.Visible = true;
            this.colBarCodeIdProd.VisibleIndex = 1;
            this.colBarCodeIdProd.Width = 206;
            // 
            // ProdBarcodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 482);
            this.Controls.Add(this.dgProdBarCode);
            this.Name = "ProdBarcodesForm";
            this.Text = "ალტერნატიული კოდები";
            this.Load += new System.EventHandler(this.ProdBarcodesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdBarCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgProdBarCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProdBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProdBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCodeProd;
        private DevExpress.XtraGrid.Columns.GridColumn colBarCodeIdProd;
    }
}