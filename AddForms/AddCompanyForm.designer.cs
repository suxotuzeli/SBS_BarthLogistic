using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddCompanyForm
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.laCompanyPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyPhone = new DevExpress.XtraEditors.TextEdit();
            this.laCompanyDirek = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyDirek = new DevExpress.XtraEditors.TextEdit();
            this.laCompanyAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyAddress = new DevExpress.XtraEditors.TextEdit();
            this.laCompanyShen = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyShen = new DevExpress.XtraEditors.TextEdit();
            this.laCompanyMail = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyMail = new DevExpress.XtraEditors.TextEdit();
            this.laCompanyContact = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyContact = new DevExpress.XtraEditors.TextEdit();
            this.laServiceUser = new DevExpress.XtraEditors.LabelControl();
            this.txtServiceUser = new DevExpress.XtraEditors.TextEdit();
            this.laServicePassword = new DevExpress.XtraEditors.LabelControl();
            this.txtServicePassword = new DevExpress.XtraEditors.TextEdit();
            this.laCompanyIP = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyIP = new DevExpress.XtraEditors.TextEdit();
            this.laCompany = new DevExpress.XtraEditors.LabelControl();
            this.txtCompany = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanySagad = new DevExpress.XtraEditors.TextEdit();
            this.laCompanySagad = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyDirek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanySagad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(458, 10);
            
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            
            this.btnOK.Location = new System.Drawing.Point(353, 10);
            
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            
            this.btnAdd.Location = new System.Drawing.Point(21, 10);
            
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(21, 34);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyName.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyName.Size = new System.Drawing.Size(525, 26);
            this.txtCompanyName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 64);
            this.panel1.TabIndex = 9;
            // 
            // laCompanyName
            // 
            this.laCompanyName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyName.Location = new System.Drawing.Point(17, 11);
            this.laCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyName.Name = "laCompanyName";
            this.laCompanyName.Size = new System.Drawing.Size(169, 20);
            this.laCompanyName.TabIndex = 7;
            this.laCompanyName.Text = "კომპანიის დასახელება";
            // 
            // laCompanyPhone
            // 
            this.laCompanyPhone.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyPhone.Location = new System.Drawing.Point(286, 139);
            this.laCompanyPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyPhone.Name = "laCompanyPhone";
            this.laCompanyPhone.Size = new System.Drawing.Size(82, 20);
            this.laCompanyPhone.TabIndex = 9;
            this.laCompanyPhone.Text = "ტელეფონი";
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Location = new System.Drawing.Point(289, 161);
            this.txtCompanyPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyPhone.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyPhone.Size = new System.Drawing.Size(257, 26);
            this.txtCompanyPhone.TabIndex = 3;
            // 
            // laCompanyDirek
            // 
            this.laCompanyDirek.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyDirek.Location = new System.Drawing.Point(21, 139);
            this.laCompanyDirek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyDirek.Name = "laCompanyDirek";
            this.laCompanyDirek.Size = new System.Drawing.Size(90, 20);
            this.laCompanyDirek.TabIndex = 35;
            this.laCompanyDirek.Text = "დირექტორი";
            // 
            // txtCompanyDirek
            // 
            this.txtCompanyDirek.Location = new System.Drawing.Point(21, 161);
            this.txtCompanyDirek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyDirek.Name = "txtCompanyDirek";
            this.txtCompanyDirek.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyDirek.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyDirek.Size = new System.Drawing.Size(257, 26);
            this.txtCompanyDirek.TabIndex = 2;
            // 
            // laCompanyAddress
            // 
            this.laCompanyAddress.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyAddress.Location = new System.Drawing.Point(21, 199);
            this.laCompanyAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyAddress.Name = "laCompanyAddress";
            this.laCompanyAddress.Size = new System.Drawing.Size(164, 20);
            this.laCompanyAddress.TabIndex = 37;
            this.laCompanyAddress.Text = "ფიზიკური მისამართი";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(21, 222);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyAddress.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyAddress.Size = new System.Drawing.Size(525, 26);
            this.txtCompanyAddress.TabIndex = 4;
            // 
            // laCompanyShen
            // 
            this.laCompanyShen.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyShen.Location = new System.Drawing.Point(292, 386);
            this.laCompanyShen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyShen.Name = "laCompanyShen";
            this.laCompanyShen.Size = new System.Drawing.Size(66, 20);
            this.laCompanyShen.TabIndex = 44;
            this.laCompanyShen.Text = "შენიშვნა";
            // 
            // txtCompanyShen
            // 
            this.txtCompanyShen.Location = new System.Drawing.Point(295, 410);
            this.txtCompanyShen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyShen.Name = "txtCompanyShen";
            this.txtCompanyShen.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyShen.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyShen.Size = new System.Drawing.Size(258, 26);
            this.txtCompanyShen.TabIndex = 10;
            // 
            // laCompanyMail
            // 
            this.laCompanyMail.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyMail.Location = new System.Drawing.Point(292, 263);
            this.laCompanyMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyMail.Name = "laCompanyMail";
            this.laCompanyMail.Size = new System.Drawing.Size(49, 20);
            this.laCompanyMail.TabIndex = 46;
            this.laCompanyMail.Text = "მეილი";
            // 
            // txtCompanyMail
            // 
            this.txtCompanyMail.Location = new System.Drawing.Point(295, 287);
            this.txtCompanyMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyMail.Name = "txtCompanyMail";
            this.txtCompanyMail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyMail.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyMail.Size = new System.Drawing.Size(257, 26);
            this.txtCompanyMail.TabIndex = 6;
            // 
            // laCompanyContact
            // 
            this.laCompanyContact.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyContact.Location = new System.Drawing.Point(23, 263);
            this.laCompanyContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyContact.Name = "laCompanyContact";
            this.laCompanyContact.Size = new System.Drawing.Size(132, 20);
            this.laCompanyContact.TabIndex = 48;
            this.laCompanyContact.Text = "საკონტაქტო პირი";
            // 
            // txtCompanyContact
            // 
            this.txtCompanyContact.Location = new System.Drawing.Point(27, 286);
            this.txtCompanyContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyContact.Name = "txtCompanyContact";
            this.txtCompanyContact.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyContact.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyContact.Size = new System.Drawing.Size(257, 26);
            this.txtCompanyContact.TabIndex = 5;
            // 
            // laServiceUser
            // 
            this.laServiceUser.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laServiceUser.Location = new System.Drawing.Point(23, 325);
            this.laServiceUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laServiceUser.Name = "laServiceUser";
            this.laServiceUser.Size = new System.Drawing.Size(183, 20);
            this.laServiceUser.TabIndex = 54;
            this.laServiceUser.Text = "სერვისის მომხმარებელი";
            // 
            // txtServiceUser
            // 
            this.txtServiceUser.Location = new System.Drawing.Point(27, 347);
            this.txtServiceUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServiceUser.Name = "txtServiceUser";
            this.txtServiceUser.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServiceUser.Properties.Appearance.Options.UseFont = true;
            this.txtServiceUser.Size = new System.Drawing.Size(257, 26);
            this.txtServiceUser.TabIndex = 7;
            // 
            // laServicePassword
            // 
            this.laServicePassword.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laServicePassword.Location = new System.Drawing.Point(292, 325);
            this.laServicePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laServicePassword.Name = "laServicePassword";
            this.laServicePassword.Size = new System.Drawing.Size(135, 20);
            this.laServicePassword.TabIndex = 53;
            this.laServicePassword.Text = "სერვისის პაროლი";
            // 
            // txtServicePassword
            // 
            this.txtServicePassword.Location = new System.Drawing.Point(295, 348);
            this.txtServicePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServicePassword.Name = "txtServicePassword";
            this.txtServicePassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtServicePassword.Properties.Appearance.Options.UseFont = true;
            this.txtServicePassword.Properties.PasswordChar = '*';
            this.txtServicePassword.Size = new System.Drawing.Size(257, 26);
            this.txtServicePassword.TabIndex = 8;
            // 
            // laCompanyIP
            // 
            this.laCompanyIP.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanyIP.Location = new System.Drawing.Point(23, 388);
            this.laCompanyIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanyIP.Name = "laCompanyIP";
            this.laCompanyIP.Size = new System.Drawing.Size(78, 20);
            this.laCompanyIP.TabIndex = 56;
            this.laCompanyIP.Text = "IP Address";
            // 
            // txtCompanyIP
            // 
            this.txtCompanyIP.Location = new System.Drawing.Point(27, 410);
            this.txtCompanyIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyIP.Name = "txtCompanyIP";
            this.txtCompanyIP.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanyIP.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyIP.Size = new System.Drawing.Size(257, 26);
            this.txtCompanyIP.TabIndex = 9;
            // 
            // laCompany
            // 
            this.laCompany.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompany.Location = new System.Drawing.Point(17, 76);
            this.laCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompany.Name = "laCompany";
            this.laCompany.Size = new System.Drawing.Size(226, 20);
            this.laCompany.TabIndex = 58;
            this.laCompany.Text = "კომპანია (მოკლე დასახელება)";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(21, 100);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompany.Properties.Appearance.Options.UseFont = true;
            this.txtCompany.Size = new System.Drawing.Size(257, 26);
            this.txtCompany.TabIndex = 1;
            // 
            // txtCompanySagad
            // 
            this.txtCompanySagad.Location = new System.Drawing.Point(289, 100);
            this.txtCompanySagad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanySagad.Name = "txtCompanySagad";
            this.txtCompanySagad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompanySagad.Properties.Appearance.Options.UseFont = true;
            this.txtCompanySagad.Size = new System.Drawing.Size(257, 26);
            this.txtCompanySagad.TabIndex = 3;
            // 
            // laCompanySagad
            // 
            this.laCompanySagad.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCompanySagad.Location = new System.Drawing.Point(292, 76);
            this.laCompanySagad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCompanySagad.Name = "laCompanySagad";
            this.laCompanySagad.Size = new System.Drawing.Size(182, 20);
            this.laCompanySagad.TabIndex = 9;
            this.laCompanySagad.Text = "საიდენტიფიკაციო კოდი";
            // 
            // AddCompanyForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(566, 508);
            this.Controls.Add(this.laCompany);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.laCompanyIP);
            this.Controls.Add(this.txtCompanyIP);
            this.Controls.Add(this.laServiceUser);
            this.Controls.Add(this.txtServiceUser);
            this.Controls.Add(this.laServicePassword);
            this.Controls.Add(this.txtServicePassword);
            this.Controls.Add(this.laCompanyContact);
            this.Controls.Add(this.txtCompanyContact);
            this.Controls.Add(this.laCompanyMail);
            this.Controls.Add(this.txtCompanyMail);
            this.Controls.Add(this.laCompanyShen);
            this.Controls.Add(this.txtCompanyShen);
            this.Controls.Add(this.laCompanyAddress);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.laCompanyDirek);
            this.Controls.Add(this.txtCompanyDirek);
            this.Controls.Add(this.laCompanySagad);
            this.Controls.Add(this.txtCompanySagad);
            this.Controls.Add(this.laCompanyPhone);
            this.Controls.Add(this.txtCompanyPhone);
            this.Controls.Add(this.laCompanyName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.panel1);
            
            this.Name = "AddCompanyForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyDirek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanySagad.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private TextEdit txtCompanyName;
        private PanelControl panel1;
        private LabelControl laCompanyName;
        private LabelControl laCompanyPhone;
        private TextEdit txtCompanyPhone;
        private LabelControl laCompanyAddress;
        private TextEdit txtCompanyAddress;
        private LabelControl laCompanyDirek;
        private TextEdit txtCompanyDirek;
        private LabelControl laCompanyShen;
        private TextEdit txtCompanyShen;
        private LabelControl laCompanyMail;
        private TextEdit txtCompanyMail;
        private LabelControl laCompanyContact;
        private TextEdit txtCompanyContact;
        private LabelControl laServiceUser;
        private TextEdit txtServiceUser;
        private LabelControl laServicePassword;
        private TextEdit txtServicePassword;
        private LabelControl laCompanyIP;
        private TextEdit txtCompanyIP;
        private LabelControl laCompany;
        private TextEdit txtCompany;
        private LabelControl laCompanySagad;
        private TextEdit txtCompanySagad;
    }
}