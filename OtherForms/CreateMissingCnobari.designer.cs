namespace SBS_BarthLogistic.OtherForms
{
    partial class CreateMissingCnobari
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
            this.dgCnobari = new DevExpress.XtraGrid.GridControl();
            this.gvCnobari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExists = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCnobari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCnobari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCnobari
            // 
            this.dgCnobari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCnobari.Location = new System.Drawing.Point(0, 45);
            this.dgCnobari.MainView = this.gvCnobari;
            this.dgCnobari.Name = "dgCnobari";
            this.dgCnobari.Size = new System.Drawing.Size(658, 399);
            this.dgCnobari.TabIndex = 9;
            this.dgCnobari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCnobari});
            // 
            // gvCnobari
            // 
            this.gvCnobari.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvCnobari.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCnobari.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colExists});
            this.gvCnobari.FooterPanelHeight = 1;
            this.gvCnobari.GridControl = this.dgCnobari;
            this.gvCnobari.GroupPanelText = "დაჯგუფება";
            this.gvCnobari.GroupRowHeight = 1;
            this.gvCnobari.Name = "gvCnobari";
            this.gvCnobari.OptionsBehavior.Editable = false;
            this.gvCnobari.OptionsCustomization.AllowGroup = false;
            this.gvCnobari.OptionsDetail.AllowZoomDetail = false;
            this.gvCnobari.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvCnobari.OptionsSelection.MultiSelect = true;
            this.gvCnobari.OptionsView.ColumnAutoWidth = false;
            this.gvCnobari.OptionsView.EnableAppearanceOddRow = true;
            this.gvCnobari.OptionsView.ShowAutoFilterRow = true;
            this.gvCnobari.OptionsView.ShowDetailButtons = false;
            this.gvCnobari.OptionsView.ShowFooter = true;
            this.gvCnobari.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "#";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.Caption = "ჩანაწერი";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 356;
            // 
            // colExists
            // 
            this.colExists.Caption = "ჩანაწერი არსებობს ბაზაში";
            this.colExists.FieldName = "Exists";
            this.colExists.Name = "colExists";
            this.colExists.Visible = true;
            this.colExists.VisibleIndex = 1;
            this.colExists.Width = 152;
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Location = new System.Drawing.Point(487, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 35);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "იმპორტი";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 45);
            this.panel1.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(574, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateMissingCnobari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(658, 444);
            this.Controls.Add(this.dgCnobari);
            this.Controls.Add(this.panel1);
            this.Name = "CreateMissingCnobari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ცნობარის ჩანაწერების იმპორტი";
            this.Load += new System.EventHandler(this.CreateMissingCnobari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCnobari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCnobari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgCnobari;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCnobari;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colExists;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}