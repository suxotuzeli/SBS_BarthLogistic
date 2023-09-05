namespace SBS_BarthLogistic.InterfaceForms
{
    partial class ImportFromExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFromExcelForm));
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCnobari = new System.Windows.Forms.TabPage();
            this.dgCnobari = new DevExpress.XtraGrid.GridControl();
            this.gvCnobari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFieldValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnCnobariCheckCnobari = new DevExpress.XtraEditors.SimpleButton();
            this.tpErrors = new System.Windows.Forms.TabPage();
            this.dgErrors = new DevExpress.XtraGrid.GridControl();
            this.gvErrors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.chbUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.btnCreateExcelModelUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreateExcelModel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.tabControl1.SuspendLayout();
            this.tpCnobari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCnobari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCnobari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCnobari);
            this.tabControl1.Controls.Add(this.tpErrors);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 485);
            this.tabControl1.TabIndex = 1;
            // 
            // tpCnobari
            // 
            this.tpCnobari.Controls.Add(this.dgCnobari);
            this.tpCnobari.Controls.Add(this.panel2);
            this.tpCnobari.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCnobari.Location = new System.Drawing.Point(4, 27);
            this.tpCnobari.Name = "tpCnobari";
            this.tpCnobari.Size = new System.Drawing.Size(1126, 454);
            this.tpCnobari.TabIndex = 0;
            this.tpCnobari.Text = "ჩანაწერები";
            this.tpCnobari.UseVisualStyleBackColor = true;
            // 
            // dgCnobari
            // 
            this.dgCnobari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCnobari.Location = new System.Drawing.Point(0, 0);
            this.dgCnobari.MainView = this.gvCnobari;
            this.dgCnobari.Name = "dgCnobari";
            this.dgCnobari.Size = new System.Drawing.Size(962, 454);
            this.dgCnobari.TabIndex = 0;
            this.dgCnobari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCnobari});
            // 
            // gvCnobari
            // 
            this.gvCnobari.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvCnobari.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCnobari.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFieldName,
            this.colFieldCaption,
            this.colFieldValue,
            this.colId});
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
            // colFieldName
            // 
            this.colFieldName.Caption = "ცხირილის დასახელება";
            this.colFieldName.FieldName = "FieldName";
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.Visible = true;
            this.colFieldName.VisibleIndex = 0;
            this.colFieldName.Width = 162;
            // 
            // colFieldCaption
            // 
            this.colFieldCaption.Caption = "ცხრილის დასახელება";
            this.colFieldCaption.FieldName = "FieldCaption";
            this.colFieldCaption.Name = "colFieldCaption";
            this.colFieldCaption.Width = 268;
            // 
            // colFieldValue
            // 
            this.colFieldValue.Caption = "მნიშვნელობა";
            this.colFieldValue.FieldName = "FieldValue";
            this.colFieldValue.Name = "colFieldValue";
            this.colFieldValue.Visible = true;
            this.colFieldValue.VisibleIndex = 1;
            this.colFieldValue.Width = 503;
            // 
            // colId
            // 
            this.colId.Caption = "კოდი";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 98;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnCnobariCheckCnobari);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(962, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 454);
            this.panel2.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Appearance.Options.UseTextOptions = true;
            this.btnImport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(2, 42);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(160, 40);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "მონაცემების იმპორტი";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCnobariCheckCnobari
            // 
            this.btnCnobariCheckCnobari.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCnobariCheckCnobari.Appearance.Options.UseFont = true;
            this.btnCnobariCheckCnobari.Appearance.Options.UseTextOptions = true;
            this.btnCnobariCheckCnobari.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCnobariCheckCnobari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCnobariCheckCnobari.Image = ((System.Drawing.Image)(resources.GetObject("btnCnobariCheckCnobari.Image")));
            this.btnCnobariCheckCnobari.Location = new System.Drawing.Point(2, 2);
            this.btnCnobariCheckCnobari.Name = "btnCnobariCheckCnobari";
            this.btnCnobariCheckCnobari.Size = new System.Drawing.Size(160, 40);
            this.btnCnobariCheckCnobari.TabIndex = 0;
            this.btnCnobariCheckCnobari.Text = "ინფორმაციის შემოწმება";
            this.btnCnobariCheckCnobari.Click += new System.EventHandler(this.btnCnobariCheckCnobari_Click);
            // 
            // tpErrors
            // 
            this.tpErrors.Controls.Add(this.dgErrors);
            this.tpErrors.Location = new System.Drawing.Point(4, 27);
            this.tpErrors.Name = "tpErrors";
            this.tpErrors.Size = new System.Drawing.Size(1126, 439);
            this.tpErrors.TabIndex = 1;
            this.tpErrors.Text = "შეცდომები";
            this.tpErrors.UseVisualStyleBackColor = true;
            // 
            // dgErrors
            // 
            this.dgErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgErrors.Location = new System.Drawing.Point(0, 0);
            this.dgErrors.MainView = this.gvErrors;
            this.dgErrors.Name = "dgErrors";
            this.dgErrors.Size = new System.Drawing.Size(1126, 439);
            this.dgErrors.TabIndex = 0;
            this.dgErrors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvErrors});
            // 
            // gvErrors
            // 
            this.gvErrors.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvErrors.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvErrors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStatus,
            this.colMessage,
            this.colRow});
            this.gvErrors.FooterPanelHeight = 1;
            this.gvErrors.GridControl = this.dgErrors;
            this.gvErrors.GroupPanelText = "დაჯგუფება";
            this.gvErrors.GroupRowHeight = 1;
            this.gvErrors.Name = "gvErrors";
            this.gvErrors.OptionsBehavior.Editable = false;
            this.gvErrors.OptionsCustomization.AllowGroup = false;
            this.gvErrors.OptionsDetail.AllowZoomDetail = false;
            this.gvErrors.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvErrors.OptionsSelection.MultiSelect = true;
            this.gvErrors.OptionsView.ColumnAutoWidth = false;
            this.gvErrors.OptionsView.EnableAppearanceOddRow = true;
            this.gvErrors.OptionsView.ShowAutoFilterRow = true;
            this.gvErrors.OptionsView.ShowDetailButtons = false;
            this.gvErrors.OptionsView.ShowFooter = true;
            this.gvErrors.OptionsView.ShowGroupPanel = false;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "სტატუსი";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 1;
            this.colStatus.Width = 138;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "შეცდომა";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 2;
            this.colMessage.Width = 736;
            // 
            // colRow
            // 
            this.colRow.Caption = "ჩანაწერის ნომერი";
            this.colRow.FieldName = "Row";
            this.colRow.Name = "colRow";
            this.colRow.Visible = true;
            this.colRow.VisibleIndex = 0;
            this.colRow.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbUpdate);
            this.panel1.Controls.Add(this.btnCreateExcelModelUpdate);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnCreateExcelModel);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 60);
            this.panel1.TabIndex = 0;
            // 
            // chbUpdate
            // 
            this.chbUpdate.Location = new System.Drawing.Point(532, 8);
            this.chbUpdate.Name = "chbUpdate";
            this.chbUpdate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUpdate.Properties.Appearance.Options.UseFont = true;
            this.chbUpdate.Properties.AutoWidth = true;
            this.chbUpdate.Properties.Caption = "ინფორმაციის გაახლება?";
            this.chbUpdate.Size = new System.Drawing.Size(158, 20);
            this.chbUpdate.TabIndex = 0;
            // 
            // btnCreateExcelModelUpdate
            // 
            this.btnCreateExcelModelUpdate.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExcelModelUpdate.Appearance.Options.UseFont = true;
            this.btnCreateExcelModelUpdate.Appearance.Options.UseTextOptions = true;
            this.btnCreateExcelModelUpdate.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCreateExcelModelUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateExcelModelUpdate.Image")));
            this.btnCreateExcelModelUpdate.Location = new System.Drawing.Point(926, 10);
            this.btnCreateExcelModelUpdate.Name = "btnCreateExcelModelUpdate";
            this.btnCreateExcelModelUpdate.Size = new System.Drawing.Size(184, 40);
            this.btnCreateExcelModelUpdate.TabIndex = 4;
            this.btnCreateExcelModelUpdate.Text = "ნიმუშის შექმნა && ინფორმაციის გადატანა";
            this.btnCreateExcelModelUpdate.Click += new System.EventHandler(this.btnCreateExcelModelUpdate_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(8, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ფაილი იმპორტისთვის";
            // 
            // btnCreateExcelModel
            // 
            this.btnCreateExcelModel.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExcelModel.Appearance.Options.UseFont = true;
            this.btnCreateExcelModel.Appearance.Options.UseTextOptions = true;
            this.btnCreateExcelModel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnCreateExcelModel.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateExcelModel.Image")));
            this.btnCreateExcelModel.Location = new System.Drawing.Point(766, 10);
            this.btnCreateExcelModel.Name = "btnCreateExcelModel";
            this.btnCreateExcelModel.Size = new System.Drawing.Size(160, 40);
            this.btnCreateExcelModel.TabIndex = 3;
            this.btnCreateExcelModel.Text = "ნიმუშის შექმნა";
            this.btnCreateExcelModel.Click += new System.EventHandler(this.btnCreateExcelModel_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Location = new System.Drawing.Point(697, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(44, 22);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.ToolTip = "ფაილის არჩევა";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(6, 30);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Properties.Appearance.Options.UseFont = true;
            this.txtFileName.Size = new System.Drawing.Size(685, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // ImportFromExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 545);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportFromExcelForm";
            this.Text = "Excel-დან იმპორტი";
            this.Load += new System.EventHandler(this.ImportFromExcelFullForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCnobari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCnobari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCnobari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tpErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabControl tabControl1;
        private DevExpress.XtraEditors.PanelControl panel1;
        private System.Windows.Forms.TabPage tpCnobari;
        private DevExpress.XtraEditors.PanelControl panel2;
        private DevExpress.XtraGrid.GridControl dgCnobari;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCnobari;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldName;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colFieldValue;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private DevExpress.XtraEditors.SimpleButton btnCnobariCheckCnobari;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnCreateExcelModel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreateExcelModelUpdate;
        private System.Windows.Forms.TabPage tpErrors;
        private DevExpress.XtraGrid.GridControl dgErrors;
        private DevExpress.XtraGrid.Views.Grid.GridView gvErrors;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colRow;
        private DevExpress.XtraEditors.CheckEdit chbUpdate;
    }
}