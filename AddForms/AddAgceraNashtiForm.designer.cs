using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddAgceraNashtiForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laIdProd = new DevExpress.XtraEditors.LabelControl();
            this.laRaod = new DevExpress.XtraEditors.LabelControl();
            this.dgAgceraNashti = new DevExpress.XtraGrid.GridControl();
            this.gvAgceraNashti = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAgceraNashti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paAgceraNashti = new DevExpress.XtraEditors.PanelControl();
            this.txtRaod = new DevExpress.XtraEditors.CalcEdit();
            this.txtIdProd = new SBS_BarthLogistic.Controls.ProdSelect();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgceraNashti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgceraNashti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paAgceraNashti)).BeginInit();
            this.paAgceraNashti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(710, 6);
            
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            
            this.btnOK.Location = new System.Drawing.Point(602, 6);
            
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            
            this.btnAdd.Location = new System.Drawing.Point(21, 6);
            
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 50);
            this.panel1.TabIndex = 1;
            // 
            // laIdProd
            // 
            this.laIdProd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laIdProd.Location = new System.Drawing.Point(19, 11);
            this.laIdProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laIdProd.Name = "laIdProd";
            this.laIdProd.Size = new System.Drawing.Size(40, 20);
            this.laIdProd.TabIndex = 7;
            this.laIdProd.Text = "კოდი";
            // 
            // laRaod
            // 
            this.laRaod.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laRaod.Location = new System.Drawing.Point(349, 11);
            this.laRaod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laRaod.Name = "laRaod";
            this.laRaod.Size = new System.Drawing.Size(83, 20);
            this.laRaod.TabIndex = 10;
            this.laRaod.Text = "რაოდენობა";
            // 
            // dgAgceraNashti
            // 
            this.dgAgceraNashti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAgceraNashti.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgAgceraNashti.Location = new System.Drawing.Point(0, 110);
            this.dgAgceraNashti.MainView = this.gvAgceraNashti;
            this.dgAgceraNashti.Name = "dgAgceraNashti";
            this.dgAgceraNashti.Size = new System.Drawing.Size(820, 288);
            this.dgAgceraNashti.TabIndex = 31;
            this.dgAgceraNashti.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAgceraNashti});
            this.dgAgceraNashti.DoubleClick += new System.EventHandler(this.dgDet_DoubleClick);
            // 
            // gvAgceraNashti
            // 
            this.gvAgceraNashti.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAgceraNashti,
            this.colIdProd,
            this.colProd,
            this.colRaod});
            this.gvAgceraNashti.FooterPanelHeight = 1;
            this.gvAgceraNashti.GridControl = this.dgAgceraNashti;
            this.gvAgceraNashti.GroupPanelText = "დაჯგუფება";
            this.gvAgceraNashti.GroupRowHeight = 1;
            this.gvAgceraNashti.Name = "gvAgceraNashti";
            this.gvAgceraNashti.OptionsBehavior.Editable = false;
            this.gvAgceraNashti.OptionsDetail.AllowZoomDetail = false;
            this.gvAgceraNashti.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvAgceraNashti.OptionsView.ColumnAutoWidth = false;
            this.gvAgceraNashti.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvAgceraNashti.OptionsView.ShowDetailButtons = false;
            this.gvAgceraNashti.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvAgceraNashti.OptionsView.ShowFooter = true;
            this.gvAgceraNashti.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAgceraNashti
            // 
            this.colIdAgceraNashti.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIdAgceraNashti.AppearanceHeader.Options.UseFont = true;
            this.colIdAgceraNashti.Caption = "IdAgceraNashti";
            this.colIdAgceraNashti.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colIdAgceraNashti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIdAgceraNashti.FieldName = "IdAgceraNashti";
            this.colIdAgceraNashti.Name = "colIdAgceraNashti";
            // 
            // colIdProd
            // 
            this.colIdProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIdProd.AppearanceHeader.Options.UseFont = true;
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            // 
            // colProd
            // 
            this.colProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colRaod.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRaod.AppearanceHeader.Options.UseFont = true;
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "{0:0.###}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRaod.FieldName = "Raod";
            this.colRaod.Name = "colRaod";
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 106;
            // 
            // paAgceraNashti
            // 
            this.paAgceraNashti.Controls.Add(this.txtRaod);
            this.paAgceraNashti.Controls.Add(this.txtIdProd);
            this.paAgceraNashti.Controls.Add(this.laIdProd);
            this.paAgceraNashti.Controls.Add(this.laRaod);
            this.paAgceraNashti.Dock = System.Windows.Forms.DockStyle.Top;
            this.paAgceraNashti.Location = new System.Drawing.Point(0, 0);
            this.paAgceraNashti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paAgceraNashti.Name = "paAgceraNashti";
            this.paAgceraNashti.Size = new System.Drawing.Size(820, 110);
            this.paAgceraNashti.TabIndex = 0;
            // 
            // txtRaod
            // 
            this.txtRaod.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRaod.Location = new System.Drawing.Point(349, 37);
            this.txtRaod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRaod.Name = "txtRaod";
            this.txtRaod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtRaod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRaod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRaod.Size = new System.Drawing.Size(85, 22);
            this.txtRaod.TabIndex = 1;
            this.txtRaod.Enter += new System.EventHandler(this.txtRaod_Enter);
            // 
            // txtIdProd
            // 
            this.txtIdProd.CustomLabel = null;
            this.txtIdProd.Id = null;
            this.txtIdProd.Label = "";
            this.txtIdProd.Location = new System.Drawing.Point(17, 40);
            this.txtIdProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.SearchOnLeave = false;
            this.txtIdProd.Size = new System.Drawing.Size(234, 62);
            this.txtIdProd.TabIndex = 0;
            this.txtIdProd.Enter += new System.EventHandler(this.txtIdProd_Enter);
            this.txtIdProd.Leave += new System.EventHandler(this.txtIdProd_Leave);
            // 
            // AddAgceraNashtiForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(820, 448);
            this.Controls.Add(this.dgAgceraNashti);
            this.Controls.Add(this.paAgceraNashti);
            this.Controls.Add(this.panel1);
            
            this.Name = "AddAgceraNashtiForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddAgceraNashtiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgceraNashti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgceraNashti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paAgceraNashti)).EndInit();
            this.paAgceraNashti.ResumeLayout(false);
            this.paAgceraNashti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private LabelControl laIdProd;
        private LabelControl laRaod;
        private DevExpress.XtraGrid.GridControl dgAgceraNashti;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAgceraNashti;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAgceraNashti;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private PanelControl paAgceraNashti;
        private Controls.ProdSelect txtIdProd;
        private CalcEdit txtRaod;
    }
}