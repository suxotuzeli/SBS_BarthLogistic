using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class ImportFromExcelOldForm
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
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.laCount = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.chbUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.dgNotImportedRows = new DevExpress.XtraGrid.GridControl();
            this.gvNotImportedRows = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotImportedRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotImportedRows)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Location = new System.Drawing.Point(724, 15);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 25);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Location = new System.Drawing.Point(317, 63);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(149, 28);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import From Excel";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.EditValue = "";
            this.txtFileName.Location = new System.Drawing.Point(14, 15);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Properties.Appearance.Options.UseFont = true;
            this.txtFileName.Size = new System.Drawing.Size(703, 26);
            this.txtFileName.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(668, 63);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // laCount
            // 
            this.laCount.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCount.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laCount.Location = new System.Drawing.Point(14, 107);
            this.laCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCount.Name = "laCount";
            this.laCount.Size = new System.Drawing.Size(6, 19);
            this.laCount.TabIndex = 5;
            this.laCount.Text = "-";
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(489, 63);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(149, 28);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chbUpdate
            // 
            this.chbUpdate.Location = new System.Drawing.Point(14, 63);
            this.chbUpdate.Name = "chbUpdate";
            this.chbUpdate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUpdate.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.chbUpdate.Properties.Appearance.Options.UseFont = true;
            this.chbUpdate.Properties.Appearance.Options.UseForeColor = true;
            this.chbUpdate.Properties.AutoWidth = true;
            this.chbUpdate.Properties.Caption = "რედაქტირება";
            this.chbUpdate.Size = new System.Drawing.Size(117, 23);
            this.chbUpdate.TabIndex = 7;
            // 
            // dgNotImportedRows
            // 
            this.dgNotImportedRows.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgNotImportedRows.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgNotImportedRows.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgNotImportedRows.Location = new System.Drawing.Point(0, 138);
            this.dgNotImportedRows.MainView = this.gvNotImportedRows;
            this.dgNotImportedRows.Name = "dgNotImportedRows";
            this.dgNotImportedRows.Size = new System.Drawing.Size(770, 533);
            this.dgNotImportedRows.TabIndex = 8;
            this.dgNotImportedRows.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNotImportedRows});
            // 
            // gvNotImportedRows
            // 
            this.gvNotImportedRows.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvNotImportedRows.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNotImportedRows.FooterPanelHeight = 1;
            this.gvNotImportedRows.GridControl = this.dgNotImportedRows;
            this.gvNotImportedRows.GroupPanelText = "დაჯგუფება";
            this.gvNotImportedRows.GroupRowHeight = 1;
            this.gvNotImportedRows.Name = "gvNotImportedRows";
            this.gvNotImportedRows.OptionsBehavior.Editable = false;
            this.gvNotImportedRows.OptionsCustomization.AllowGroup = false;
            this.gvNotImportedRows.OptionsDetail.AllowZoomDetail = false;
            this.gvNotImportedRows.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvNotImportedRows.OptionsSelection.MultiSelect = true;
            this.gvNotImportedRows.OptionsView.ColumnAutoWidth = false;
            this.gvNotImportedRows.OptionsView.EnableAppearanceOddRow = true;
            this.gvNotImportedRows.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvNotImportedRows.OptionsView.ShowAutoFilterRow = true;
            this.gvNotImportedRows.OptionsView.ShowDetailButtons = false;
            this.gvNotImportedRows.OptionsView.ShowFooter = true;
            this.gvNotImportedRows.OptionsView.ShowGroupPanel = false;
            // 
            // ImportFromExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 671);
            this.Controls.Add(this.dgNotImportedRows);
            this.Controls.Add(this.chbUpdate);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.laCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            
            this.Name = "ImportFromExcelForm";
            this.ShowIcon = false;
            this.Text = "ექსელიდან იმპორტი";
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotImportedRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotImportedRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private TextEdit txtFileName;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.OpenFileDialog ofd;
        private LabelControl laCount;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.CheckEdit chbUpdate;
        private DevExpress.XtraGrid.GridControl dgNotImportedRows;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNotImportedRows;
    }
}