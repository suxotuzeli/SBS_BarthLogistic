using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class ExportSeveralTablesToExcelForm
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
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.paExportSeveralTablesToExcel = new DevExpress.XtraEditors.PanelControl();
            this.cbExcel = new DevExpress.XtraEditors.LookUpEdit();
            this.laExcel = new DevExpress.XtraEditors.LabelControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paExportSeveralTablesToExcel)).BeginInit();
            this.paExportSeveralTablesToExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbExcel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 48);
            this.panel2.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(245, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(138, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Export";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // paExportSeveralTablesToExcel
            // 
            this.paExportSeveralTablesToExcel.Controls.Add(this.fmgData);
            this.paExportSeveralTablesToExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paExportSeveralTablesToExcel.Location = new System.Drawing.Point(0, 0);
            this.paExportSeveralTablesToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paExportSeveralTablesToExcel.Name = "paExportSeveralTablesToExcel";
            this.paExportSeveralTablesToExcel.Size = new System.Drawing.Size(483, 64);
            this.paExportSeveralTablesToExcel.TabIndex = 0;
            // 
            // cbExcel
            // 
            this.cbExcel.Location = new System.Drawing.Point(188, 70);
            this.cbExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbExcel.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExcel.Properties.Appearance.Options.UseFont = true;
            this.cbExcel.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cbExcel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbExcel.Properties.ShowHeader = false;
            this.cbExcel.Properties.ShowNullValuePromptWhenFocused = true;
            this.cbExcel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbExcel.Size = new System.Drawing.Size(252, 26);
            this.cbExcel.TabIndex = 2;
            // 
            // laExcel
            // 
            this.laExcel.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laExcel.Location = new System.Drawing.Point(43, 74);
            this.laExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laExcel.Name = "laExcel";
            this.laExcel.Size = new System.Drawing.Size(34, 19);
            this.laExcel.TabIndex = 1;
            this.laExcel.Text = "Excel";
            // 
            // fmgData
            // 
            this.fmgData.AlwaysChecked = true;
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.AutoSize = true;
            this.fmgData.Checked = true;
            this.fmgData.FieldName = "D";
            this.fmgData.Location = new System.Drawing.Point(17, 19);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgData.MinimumSize = new System.Drawing.Size(385, 26);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = null;
            this.fmgData.Size = new System.Drawing.Size(448, 26);
            this.fmgData.TabIndex = 145;
            this.fmgData.Text = "თარიღი";
            // 
            // ExportSeveralTablesToExcelForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 167);
            this.Controls.Add(this.laExcel);
            this.Controls.Add(this.cbExcel);
            this.Controls.Add(this.paExportSeveralTablesToExcel);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExportSeveralTablesToExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "მონაცემების ექსპორტი ";
            this.Load += new System.EventHandler(this.ExportToInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paExportSeveralTablesToExcel)).EndInit();
            this.paExportSeveralTablesToExcel.ResumeLayout(false);
            this.paExportSeveralTablesToExcel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbExcel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelControl panel2;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private PanelControl paExportSeveralTablesToExcel;
        private LookUpEdit cbExcel;
        private LabelControl laExcel;
        private Controls.FMGDateFilterControl fmgData;
    }
}