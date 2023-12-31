namespace SBS_Moms.FindForms
{
    partial class FAbonimentiForm
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocate = new DevExpress.XtraEditors.TextEdit();
            this.dg = new DevExpress.XtraGrid.GridControl();
            this.gvAbonimenti = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAbonimenti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbonimenti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbonimentiT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbonimenti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.radioGroup1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtLocate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 62);
            this.panel1.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = global::SBS_Moms.Properties.Resources.AED_Add_32x32;
            this.btnAdd.Location = new System.Drawing.Point(1006, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 36);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 1;
            this.radioGroup1.Location = new System.Drawing.Point(281, 10);
            this.radioGroup1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioGroup1.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.radioGroup1.Properties.Columns = 3;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "სახელით"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "კოდით")});
            this.radioGroup1.Size = new System.Drawing.Size(318, 42);
            this.radioGroup1.TabIndex = 52;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_Moms.Properties.Resources.AED_Close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(904, 16);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Image = global::SBS_Moms.Properties.Resources.AED_Edit_32x32;
            this.btnOK.Location = new System.Drawing.Point(809, 16);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLocate
            // 
            this.txtLocate.Location = new System.Drawing.Point(14, 16);
            this.txtLocate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocate.Name = "txtLocate";
            this.txtLocate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLocate.Properties.Appearance.Options.UseFont = true;
            this.txtLocate.Size = new System.Drawing.Size(235, 36);
            this.txtLocate.TabIndex = 0;
            this.txtLocate.TextChanged += new System.EventHandler(this.txtLocate_TextChanged);
            this.txtLocate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocate_KeyDown);
            // 
            // dg
            // 
            this.dg.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.MainView = this.gvAbonimenti;
            this.dg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1097, 388);
            this.dg.TabIndex = 8;
            this.dg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAbonimenti});
            // 
            // gvAbonimenti
            // 
            this.gvAbonimenti.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvAbonimenti.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAbonimenti.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAbonimenti,
            this.colAbonimenti,
            this.colVada,
            this.colFasi,
            this.colShen,
            this.colAbonimentiT});
            this.gvAbonimenti.FooterPanelHeight = 1;
            this.gvAbonimenti.GridControl = this.dg;
            this.gvAbonimenti.GroupPanelText = "დაჯგუფება";
            this.gvAbonimenti.GroupRowHeight = 1;
            this.gvAbonimenti.Name = "gvAbonimenti";
            this.gvAbonimenti.OptionsBehavior.Editable = false;
            this.gvAbonimenti.OptionsCustomization.AllowGroup = false;
            this.gvAbonimenti.OptionsDetail.AllowZoomDetail = false;
            this.gvAbonimenti.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvAbonimenti.OptionsSelection.MultiSelect = true;
            this.gvAbonimenti.OptionsView.EnableAppearanceOddRow = true;
            this.gvAbonimenti.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvAbonimenti.OptionsView.ShowAutoFilterRow = true;
            this.gvAbonimenti.OptionsView.ShowDetailButtons = false;
            this.gvAbonimenti.OptionsView.ShowFooter = true;
            this.gvAbonimenti.OptionsView.ShowGroupPanel = false;
            // 
            // colIdAbonimenti
            // 
            this.colIdAbonimenti.Caption = "კოდი";
            this.colIdAbonimenti.FieldName = "IdAbonimenti";
            this.colIdAbonimenti.Name = "colIdAbonimenti";
            this.colIdAbonimenti.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "idPatient", "")});
            this.colIdAbonimenti.Visible = true;
            this.colIdAbonimenti.VisibleIndex = 0;
            this.colIdAbonimenti.Width = 125;
            // 
            // colAbonimenti
            // 
            this.colAbonimenti.Caption = "აბონიმენტის დასახელება";
            this.colAbonimenti.FieldName = "Abonimenti";
            this.colAbonimenti.Name = "colAbonimenti";
            this.colAbonimenti.Visible = true;
            this.colAbonimenti.VisibleIndex = 1;
            this.colAbonimenti.Width = 300;
            // 
            // colVada
            // 
            this.colVada.Caption = "ვადა";
            this.colVada.FieldName = "Vada";
            this.colVada.Name = "colVada";
            this.colVada.Visible = true;
            this.colVada.VisibleIndex = 3;
            // 
            // colFasi
            // 
            this.colFasi.Caption = "ფასი";
            this.colFasi.DisplayFormat.FormatString = "{0:0.00##}";
            this.colFasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 4;
            this.colFasi.Width = 92;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 5;
            this.colShen.Width = 200;
            // 
            // colAbonimentiT
            // 
            this.colAbonimentiT.Caption = "აბონიმენტის ტიპი";
            this.colAbonimentiT.FieldName = "AbonimentiT";
            this.colAbonimentiT.Name = "colAbonimentiT";
            this.colAbonimentiT.Visible = true;
            this.colAbonimentiT.VisibleIndex = 2;
            this.colAbonimentiT.Width = 150;
            // 
            // FAbonimentiForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FAbonimentiForm";
            this.ShowIcon = false;
            this.Text = "ძებნა (აბონიმენტი)";
            this.Activated += new System.EventHandler(this.FAbonimentiForm_Activated);
            this.Load += new System.EventHandler(this.FAbonimentiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAbonimenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.TextEdit txtLocate;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl dg;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAbonimenti;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAbonimenti;
        private DevExpress.XtraGrid.Columns.GridColumn colAbonimenti;
        private DevExpress.XtraGrid.Columns.GridColumn colVada;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colAbonimentiT;
    }
}