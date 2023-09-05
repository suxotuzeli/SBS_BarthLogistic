using DevExpress.XtraEditors;

namespace SBS_Market.OtherForms
{
    partial class GridViewSettingsForm
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
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.btnFixedColumns = new System.Windows.Forms.Button();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.chbChoiseMultipleValuesInFilter = new System.Windows.Forms.CheckBox();
            this.btnChoiseMultipleValuesInFilter = new System.Windows.Forms.Button();
            this.txtLeftFixedColumns = new DevExpress.XtraEditors.CalcEdit();
            this.txtRightFixedColumns = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeftFixedColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRightFixedColumns.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Image = global::SBS_Market.Properties.Resources.AED_Edit_32x32;
            this.btnOK.Location = new System.Drawing.Point(206, 224);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 50);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "&Close";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "მარცხნივ ფიქსირებული სვეტების რაოდენობა";
            // 
            // btnFixedColumns
            // 
            this.btnFixedColumns.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixedColumns.Location = new System.Drawing.Point(426, 23);
            this.btnFixedColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFixedColumns.Name = "btnFixedColumns";
            this.btnFixedColumns.Size = new System.Drawing.Size(126, 63);
            this.btnFixedColumns.TabIndex = 72;
            this.btnFixedColumns.Text = "SET";
            this.btnFixedColumns.UseVisualStyleBackColor = true;
            this.btnFixedColumns.Click += new System.EventHandler(this.btnFixedColumns_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "მარჯვნივ ფიქსირებული სვეტების რაოდენობა";
            // 
            // chbChoiseMultipleValuesInFilter
            // 
            this.chbChoiseMultipleValuesInFilter.AutoSize = true;
            this.chbChoiseMultipleValuesInFilter.Checked = true;
            this.chbChoiseMultipleValuesInFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbChoiseMultipleValuesInFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbChoiseMultipleValuesInFilter.Location = new System.Drawing.Point(34, 155);
            this.chbChoiseMultipleValuesInFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbChoiseMultipleValuesInFilter.Name = "chbChoiseMultipleValuesInFilter";
            this.chbChoiseMultipleValuesInFilter.Size = new System.Drawing.Size(318, 24);
            this.chbChoiseMultipleValuesInFilter.TabIndex = 78;
            this.chbChoiseMultipleValuesInFilter.Text = "ფილტრში რამდენიმე მნიშვნელობის არჩევა";
            this.chbChoiseMultipleValuesInFilter.UseVisualStyleBackColor = true;
            // 
            // btnChoiseMultipleValuesInFilter
            // 
            this.btnChoiseMultipleValuesInFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiseMultipleValuesInFilter.Location = new System.Drawing.Point(373, 148);
            this.btnChoiseMultipleValuesInFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChoiseMultipleValuesInFilter.Name = "btnChoiseMultipleValuesInFilter";
            this.btnChoiseMultipleValuesInFilter.Size = new System.Drawing.Size(178, 37);
            this.btnChoiseMultipleValuesInFilter.TabIndex = 79;
            this.btnChoiseMultipleValuesInFilter.Text = "SET";
            this.btnChoiseMultipleValuesInFilter.UseVisualStyleBackColor = true;
            this.btnChoiseMultipleValuesInFilter.Click += new System.EventHandler(this.btnChoiseMultipleValuesInFilter_Click);
            // 
            // txtLeftFixedColumns
            // 
            this.txtLeftFixedColumns.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLeftFixedColumns.Location = new System.Drawing.Point(373, 23);
            this.txtLeftFixedColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLeftFixedColumns.Name = "txtLeftFixedColumns";
            this.txtLeftFixedColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLeftFixedColumns.Size = new System.Drawing.Size(40, 22);
            this.txtLeftFixedColumns.TabIndex = 80;
            // 
            // txtRightFixedColumns
            // 
            this.txtRightFixedColumns.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRightFixedColumns.Location = new System.Drawing.Point(373, 64);
            this.txtRightFixedColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRightFixedColumns.Name = "txtRightFixedColumns";
            this.txtRightFixedColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtRightFixedColumns.Size = new System.Drawing.Size(40, 22);
            this.txtRightFixedColumns.TabIndex = 81;
            // 
            // GridViewSettingsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 286);
            this.Controls.Add(this.txtRightFixedColumns);
            this.Controls.Add(this.txtLeftFixedColumns);
            this.Controls.Add(this.btnChoiseMultipleValuesInFilter);
            this.Controls.Add(this.chbChoiseMultipleValuesInFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFixedColumns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GridViewSettingsForm";
            this.Text = "კროს ცხრილის პარამეტრები";
            this.Load += new System.EventHandler(this.GridViewSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLeftFixedColumns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRightFixedColumns.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnOK;
        private LabelControl label4;
        private System.Windows.Forms.Button btnFixedColumns;
        private LabelControl label1;
        private System.Windows.Forms.CheckBox chbChoiseMultipleValuesInFilter;
        private System.Windows.Forms.Button btnChoiseMultipleValuesInFilter;
        private CalcEdit txtLeftFixedColumns;
        private CalcEdit txtRightFixedColumns;
    }
}