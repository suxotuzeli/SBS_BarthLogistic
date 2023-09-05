namespace SBS_Market.OtherForms
{
    partial class EditCopyReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.laSchema = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.txtReportSchema = new System.Windows.Forms.TextBox();
            this.txtReportDesc = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "რეპორტის სახელი";
            // 
            // laSchema
            // 
            this.laSchema.AutoSize = true;
            this.laSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSchema.Location = new System.Drawing.Point(574, 85);
            this.laSchema.Name = "laSchema";
            this.laSchema.Size = new System.Drawing.Size(108, 20);
            this.laSchema.TabIndex = 8;
            this.laSchema.Text = "საწყისი სიტყვა";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "რეპორტის აღწერა";
            // 
            // txtReportName
            // 
            this.txtReportName.Location = new System.Drawing.Point(17, 43);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(714, 20);
            this.txtReportName.TabIndex = 0;
            // 
            // txtReportSchema
            // 
            this.txtReportSchema.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportSchema.Location = new System.Drawing.Point(579, 108);
            this.txtReportSchema.Name = "txtReportSchema";
            this.txtReportSchema.Size = new System.Drawing.Size(152, 23);
            this.txtReportSchema.TabIndex = 2;
            // 
            // txtReportDesc
            // 
            this.txtReportDesc.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportDesc.Location = new System.Drawing.Point(17, 108);
            this.txtReportDesc.Name = "txtReportDesc";
            this.txtReportDesc.Size = new System.Drawing.Size(539, 23);
            this.txtReportDesc.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(394, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(302, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EditCopyReportForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(768, 187);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtReportDesc);
            this.Controls.Add(this.txtReportSchema);
            this.Controls.Add(this.txtReportName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laSchema);
            this.Controls.Add(this.label1);
            this.Name = "EditCopyReportForm";
            this.Text = "რეპორტის ინფორმაციის ცვლილება";
            this.Load += new System.EventHandler(this.EditCopyReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laSchema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.TextBox txtReportSchema;
        private System.Windows.Forms.TextBox txtReportDesc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}