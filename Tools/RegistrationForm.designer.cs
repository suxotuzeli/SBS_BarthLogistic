namespace SBS_BarthLogistic.Tools
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.cbUser = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.laPass = new DevExpress.XtraEditors.LabelControl();
            this.laUser = new DevExpress.XtraEditors.LabelControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.paParams = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paParams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(150, 95);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(48, 95);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbUser
            // 
            this.cbUser.Location = new System.Drawing.Point(116, 25);
            this.cbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUser.Name = "cbUser";
            this.cbUser.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUser.Properties.Appearance.Options.UseFont = true;
            this.cbUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUser.Size = new System.Drawing.Size(112, 24);
            this.cbUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(116, 59);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(142, 24);
            this.txtPass.TabIndex = 1;
            // 
            // laPass
            // 
            this.laPass.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPass.Location = new System.Drawing.Point(8, 61);
            this.laPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laPass.Name = "laPass";
            this.laPass.Size = new System.Drawing.Size(49, 18);
            this.laPass.TabIndex = 5;
            this.laPass.Text = "პაროლი";
            // 
            // laUser
            // 
            this.laUser.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUser.Location = new System.Drawing.Point(8, 27);
            this.laUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(92, 18);
            this.laUser.TabIndex = 4;
            this.laUser.Text = "მომხმარებელი";
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = global::SBS_BarthLogistic.Properties.Resources.DelUSR;
            this.btnDel.Image = global::SBS_BarthLogistic.Properties.Resources.DelUSR;
            this.btnDel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDel.Location = new System.Drawing.Point(230, 24);
            this.btnDel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(25, 25);
            this.btnDel.TabIndex = 6;
            this.btnDel.Click += new System.EventHandler(this.txtUser_Leave);
            this.btnDel.Enter += new System.EventHandler(this.btnDel_Enter);
            // 
            // paParams
            // 
            this.paParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.paParams.Location = new System.Drawing.Point(0, 0);
            this.paParams.Name = "paParams";
            this.paParams.Size = new System.Drawing.Size(274, 18);
            this.paParams.TabIndex = 7;
            this.paParams.DoubleClick += new System.EventHandler(this.paParams_DoubleClick);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(274, 135);
            this.Controls.Add(this.paParams);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.laUser);
            this.Controls.Add(this.laPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "რეგისტრაცია";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.ComboBoxEdit cbUser;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl laPass;
        private DevExpress.XtraEditors.LabelControl laUser;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.PanelControl paParams;
    }
}