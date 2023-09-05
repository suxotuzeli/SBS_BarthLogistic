namespace SBS_BarthLogistic.OtherForms
{
    partial class ExportDataToExcelForm
    {

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.paAction = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.laExcel = new DevExpress.XtraEditors.LabelControl();
            this.cbExcel = new DevExpress.XtraEditors.LookUpEdit();
            this.paExportDataToExcel = new DevExpress.XtraEditors.PanelControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.paAction)).BeginInit();
            this.paAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paExportDataToExcel)).BeginInit();
            this.paExportDataToExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // paAction
            // 
            this.paAction.Controls.Add(this.btnCancel);
            this.paAction.Controls.Add(this.btnOK);
            this.paAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paAction.Location = new System.Drawing.Point(0, 97);
            this.paAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paAction.Name = "paAction";
            this.paAction.Size = new System.Drawing.Size(414, 39);
            this.paAction.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(210, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Close";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(118, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Export";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // laExcel
            // 
            this.laExcel.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laExcel.Location = new System.Drawing.Point(37, 60);
            this.laExcel.Name = "laExcel";
            this.laExcel.Size = new System.Drawing.Size(27, 16);
            this.laExcel.TabIndex = 5;
            this.laExcel.Text = "Excel";
            // 
            // cbExcel
            // 
            this.cbExcel.Location = new System.Drawing.Point(161, 57);
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
            this.cbExcel.Size = new System.Drawing.Size(216, 22);
            this.cbExcel.TabIndex = 6;
            // 
            // paExportDataToExcel
            // 
            this.paExportDataToExcel.Controls.Add(this.fmgData);
            this.paExportDataToExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paExportDataToExcel.Location = new System.Drawing.Point(0, 0);
            this.paExportDataToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paExportDataToExcel.Name = "paExportDataToExcel";
            this.paExportDataToExcel.Size = new System.Drawing.Size(414, 52);
            this.paExportDataToExcel.TabIndex = 4;
            // 
            // fmgData
            // 
            this.fmgData.AlwaysChecked = true;
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.AutoSize = true;
            this.fmgData.Checked = true;
            this.fmgData.FieldName = "Data";
            this.fmgData.Location = new System.Drawing.Point(15, 15);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fmgData.MinimumSize = new System.Drawing.Size(385, 23);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = "D";
            this.fmgData.Size = new System.Drawing.Size(385, 23);
            this.fmgData.TabIndex = 0;
            this.fmgData.Text = "თარიღი";
            // 
            // ExportDataToExcelForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 136);
            this.Controls.Add(this.paAction);
            this.Controls.Add(this.laExcel);
            this.Controls.Add(this.cbExcel);
            this.Controls.Add(this.paExportDataToExcel);
            this.Name = "ExportDataToExcelForm";
            this.Load += new System.EventHandler(this.ExportDataToExcelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paAction)).EndInit();
            this.paAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paExportDataToExcel)).EndInit();
            this.paExportDataToExcel.ResumeLayout(false);
            this.paExportDataToExcel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paExportDataToExcel;
        private Controls.FMGDateFilterControl fmgData;
        private DevExpress.XtraEditors.PanelControl paAction;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl laExcel;
        private DevExpress.XtraEditors.LookUpEdit cbExcel;

    }
}