using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddOrgForm
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
            DevExpress.XtraEditors.LabelControl laSagad;
            DevExpress.XtraEditors.LabelControl laOrgT;
            this.laOrg = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.txtOrg = new DevExpress.XtraEditors.TextEdit();
            this.txtSagad = new DevExpress.XtraEditors.TextEdit();
            this.btnCheckSagad = new DevExpress.XtraEditors.SimpleButton();
            this.cbOrgT = new DevExpress.XtraEditors.LookUpEdit();
            this.laAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.laEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.laDirek = new DevExpress.XtraEditors.LabelControl();
            this.txtDirek = new DevExpress.XtraEditors.TextEdit();
            this.laContact = new DevExpress.XtraEditors.LabelControl();
            this.txtContact = new DevExpress.XtraEditors.TextEdit();
            laSagad = new DevExpress.XtraEditors.LabelControl();
            laOrgT = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrgT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laSagad
            // 
            laSagad.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laSagad.Appearance.Options.UseFont = true;
            laSagad.Location = new System.Drawing.Point(15, 9);
            laSagad.Name = "laSagad";
            laSagad.Size = new System.Drawing.Size(62, 16);
            laSagad.TabIndex = 23;
            laSagad.Text = "საიდ.კოდი";
            // 
            // laOrgT
            // 
            laOrgT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laOrgT.Appearance.Options.UseFont = true;
            laOrgT.Location = new System.Drawing.Point(457, 10);
            laOrgT.Name = "laOrgT";
            laOrgT.Size = new System.Drawing.Size(115, 16);
            laOrgT.TabIndex = 21;
            laOrgT.Text = "ორგანიზაციის ტიპი";
            // 
            // laOrg
            // 
            this.laOrg.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laOrg.Appearance.Options.UseFont = true;
            this.laOrg.Location = new System.Drawing.Point(162, 9);
            this.laOrg.Name = "laOrg";
            this.laOrg.Size = new System.Drawing.Size(66, 16);
            this.laOrg.TabIndex = 18;
            this.laOrg.Text = "დასახელება";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(565, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(477, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 30);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 39);
            this.panel1.TabIndex = 9;
            // 
            // txtOrg
            // 
            this.txtOrg.Location = new System.Drawing.Point(162, 28);
            this.txtOrg.Name = "txtOrg";
            this.txtOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrg.Properties.Appearance.Options.UseFont = true;
            this.txtOrg.Size = new System.Drawing.Size(289, 22);
            this.txtOrg.TabIndex = 1;
            // 
            // txtSagad
            // 
            this.txtSagad.EditValue = "";
            this.txtSagad.Location = new System.Drawing.Point(15, 28);
            this.txtSagad.Name = "txtSagad";
            this.txtSagad.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSagad.Properties.Appearance.Options.UseFont = true;
            this.txtSagad.Size = new System.Drawing.Size(114, 22);
            this.txtSagad.TabIndex = 0;
            // 
            // btnCheckSagad
            // 
            this.btnCheckSagad.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSagad.Appearance.Options.UseFont = true;
            this.btnCheckSagad.Location = new System.Drawing.Point(132, 28);
            this.btnCheckSagad.Name = "btnCheckSagad";
            this.btnCheckSagad.Size = new System.Drawing.Size(24, 22);
            this.btnCheckSagad.TabIndex = 7;
            this.btnCheckSagad.TabStop = false;
            this.btnCheckSagad.Text = "...";
            this.btnCheckSagad.Click += new System.EventHandler(this.btnCheckSagad_Click);
            // 
            // cbOrgT
            // 
            this.cbOrgT.Location = new System.Drawing.Point(457, 29);
            this.cbOrgT.Name = "cbOrgT";
            this.cbOrgT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrgT.Properties.Appearance.Options.UseFont = true;
            this.cbOrgT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrgT.Size = new System.Drawing.Size(187, 22);
            this.cbOrgT.TabIndex = 7;
            // 
            // laAddress
            // 
            this.laAddress.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laAddress.Appearance.Options.UseFont = true;
            this.laAddress.Location = new System.Drawing.Point(15, 62);
            this.laAddress.Name = "laAddress";
            this.laAddress.Size = new System.Drawing.Size(61, 16);
            this.laAddress.TabIndex = 25;
            this.laAddress.Text = "მისამართი";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 81);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(629, 22);
            this.txtAddress.TabIndex = 24;
            // 
            // laEmail
            // 
            this.laEmail.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEmail.Appearance.Options.UseFont = true;
            this.laEmail.Location = new System.Drawing.Point(15, 119);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(60, 16);
            this.laEmail.TabIndex = 27;
            this.laEmail.Text = "ელ-ფოსტა";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(224, 22);
            this.txtEmail.TabIndex = 26;
            // 
            // laDirek
            // 
            this.laDirek.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDirek.Appearance.Options.UseFont = true;
            this.laDirek.Location = new System.Drawing.Point(245, 119);
            this.laDirek.Name = "laDirek";
            this.laDirek.Size = new System.Drawing.Size(71, 16);
            this.laDirek.TabIndex = 29;
            this.laDirek.Text = "დირექტორი";
            // 
            // txtDirek
            // 
            this.txtDirek.Location = new System.Drawing.Point(245, 138);
            this.txtDirek.Name = "txtDirek";
            this.txtDirek.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirek.Properties.Appearance.Options.UseFont = true;
            this.txtDirek.Size = new System.Drawing.Size(159, 22);
            this.txtDirek.TabIndex = 28;
            // 
            // laContact
            // 
            this.laContact.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laContact.Appearance.Options.UseFont = true;
            this.laContact.Location = new System.Drawing.Point(410, 119);
            this.laContact.Name = "laContact";
            this.laContact.Size = new System.Drawing.Size(68, 16);
            this.laContact.TabIndex = 31;
            this.laContact.Text = "საკონტაქტო";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(410, 138);
            this.txtContact.Name = "txtContact";
            this.txtContact.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Properties.Appearance.Options.UseFont = true;
            this.txtContact.Size = new System.Drawing.Size(224, 22);
            this.txtContact.TabIndex = 30;
            // 
            // AddOrgForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(658, 217);
            this.Controls.Add(this.laContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.laDirek);
            this.Controls.Add(this.txtDirek);
            this.Controls.Add(this.laEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.laAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cbOrgT);
            this.Controls.Add(this.btnCheckSagad);
            this.Controls.Add(this.txtSagad);
            this.Controls.Add(laSagad);
            this.Controls.Add(laOrgT);
            this.Controls.Add(this.laOrg);
            this.Controls.Add(this.txtOrg);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrgForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddOrgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrgT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContact.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private TextEdit txtOrg;
        private TextEdit txtSagad;
        private DevExpress.XtraEditors.SimpleButton btnCheckSagad;
        private DevExpress.XtraEditors.LookUpEdit cbOrgT;
        private LabelControl laOrg;
        private LabelControl laAddress;
        private TextEdit txtAddress;
        private LabelControl laEmail;
        private TextEdit txtEmail;
        private LabelControl laDirek;
        private TextEdit txtDirek;
        private LabelControl laContact;
        private TextEdit txtContact;
    }
}