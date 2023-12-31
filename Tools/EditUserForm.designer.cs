using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.Tools {
    partial class EditUserForm {
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
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass2 = new DevExpress.XtraEditors.TextEdit();
            this.txtPass1 = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(176, 15);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Properties.Appearance.Options.UseFont = true;
            this.txtOldPass.Properties.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(194, 26);
            this.txtOldPass.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "ძველი პაროლი";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(176, 102);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.Properties.Appearance.Options.UseFont = true;
            this.txtPass2.Properties.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(194, 26);
            this.txtPass2.TabIndex = 28;
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(176, 55);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass1.Properties.Appearance.Options.UseFont = true;
            this.txtPass1.Properties.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(194, 26);
            this.txtPass1.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(198, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(91, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "გაიმეორეთ პაროლი";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "პაროლი";
            // 
            // EditUserForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(390, 192);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditUserForm";
            this.ShowIcon = false;
            this.Text = "პაროლის შეცვლა";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextEdit txtOldPass;
        private LabelControl label4;
        private TextEdit txtPass2;
        private TextEdit txtPass1;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private LabelControl label3;
        private LabelControl label2;
    }
}