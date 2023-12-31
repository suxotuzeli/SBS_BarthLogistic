using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddMdzForm
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
            DevExpress.XtraEditors.LabelControl laMocm;
            DevExpress.XtraEditors.LabelControl laNom;
            DevExpress.XtraEditors.LabelControl laMan;
            DevExpress.XtraEditors.LabelControl laMdz;
            DevExpress.XtraEditors.LabelControl laPiradiNom;
            DevExpress.XtraEditors.LabelControl laTransSxva;
            DevExpress.XtraEditors.LabelControl laTransTypes;
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMan = new DevExpress.XtraEditors.TextEdit();
            this.txtMdz = new DevExpress.XtraEditors.TextEdit();
            this.txtMocm = new DevExpress.XtraEditors.TextEdit();
            this.txtPiradiNom = new DevExpress.XtraEditors.TextEdit();
            this.btnCheckSagad = new DevExpress.XtraEditors.SimpleButton();
            this.cbTransTypes = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTransSxva = new DevExpress.XtraEditors.TextEdit();
            this.txtNom = new DevExpress.XtraEditors.TextEdit();
            this.chbMdzIsCitizen = new DevExpress.XtraEditors.CheckEdit();
            this.chbIsDriver = new DevExpress.XtraEditors.CheckEdit();
            laMocm = new DevExpress.XtraEditors.LabelControl();
            laNom = new DevExpress.XtraEditors.LabelControl();
            laMan = new DevExpress.XtraEditors.LabelControl();
            laMdz = new DevExpress.XtraEditors.LabelControl();
            laPiradiNom = new DevExpress.XtraEditors.LabelControl();
            laTransSxva = new DevExpress.XtraEditors.LabelControl();
            laTransTypes = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMdz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMocm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiradiNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransSxva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMdzIsCitizen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsDriver.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laMocm
            // 
            laMocm.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laMocm.Location = new System.Drawing.Point(299, 60);
            laMocm.Name = "laMocm";
            laMocm.Size = new System.Drawing.Size(99, 16);
            laMocm.TabIndex = 21;
            laMocm.Text = "მართვის მოწმობა";
            // 
            // laNom
            // 
            laNom.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laNom.Location = new System.Drawing.Point(196, 60);
            laNom.Name = "laNom";
            laNom.Size = new System.Drawing.Size(43, 16);
            laNom.TabIndex = 20;
            laNom.Text = "ნომერი";
            // 
            // laMan
            // 
            laMan.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laMan.Location = new System.Drawing.Point(15, 60);
            laMan.Name = "laMan";
            laMan.Size = new System.Drawing.Size(38, 16);
            laMan.TabIndex = 19;
            laMan.Text = "მანქანა";
            // 
            // laMdz
            // 
            laMdz.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laMdz.Location = new System.Drawing.Point(196, 9);
            laMdz.Name = "laMdz";
            laMdz.Size = new System.Drawing.Size(48, 16);
            laMdz.TabIndex = 18;
            laMdz.Text = "მძღოლი";
            // 
            // laPiradiNom
            // 
            laPiradiNom.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laPiradiNom.Location = new System.Drawing.Point(15, 9);
            laPiradiNom.Name = "laPiradiNom";
            laPiradiNom.Size = new System.Drawing.Size(90, 16);
            laPiradiNom.TabIndex = 23;
            laPiradiNom.Text = "პირადი ნომერი";
            // 
            // laTransSxva
            // 
            laTransSxva.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laTransSxva.Location = new System.Drawing.Point(299, 174);
            laTransSxva.Name = "laTransSxva";
            laTransSxva.Size = new System.Drawing.Size(127, 16);
            laTransSxva.TabIndex = 21;
            laTransSxva.Text = "ტრანსპორტირება სხვა";
            // 
            // laTransTypes
            // 
            laTransTypes.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laTransTypes.Location = new System.Drawing.Point(15, 174);
            laTransTypes.Name = "laTransTypes";
            laTransTypes.Size = new System.Drawing.Size(141, 16);
            laTransTypes.TabIndex = 21;
            laTransTypes.Text = "ტრანსპორტირების ტიპი";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(438, 5);
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
            this.btnOK.Location = new System.Drawing.Point(350, 5);
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
            this.panel1.Location = new System.Drawing.Point(0, 240);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 39);
            this.panel1.TabIndex = 9;
            // 
            // txtMan
            // 
            this.txtMan.Location = new System.Drawing.Point(15, 79);
            this.txtMan.Name = "txtMan";
            this.txtMan.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMan.Properties.Appearance.Options.UseFont = true;
            this.txtMan.Size = new System.Drawing.Size(160, 22);
            this.txtMan.TabIndex = 2;
            // 
            // txtMdz
            // 
            this.txtMdz.Location = new System.Drawing.Point(196, 28);
            this.txtMdz.Name = "txtMdz";
            this.txtMdz.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdz.Properties.Appearance.Options.UseFont = true;
            this.txtMdz.Size = new System.Drawing.Size(301, 22);
            this.txtMdz.TabIndex = 1;
            // 
            // txtMocm
            // 
            this.txtMocm.Location = new System.Drawing.Point(299, 79);
            this.txtMocm.Name = "txtMocm";
            this.txtMocm.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMocm.Properties.Appearance.Options.UseFont = true;
            this.txtMocm.Size = new System.Drawing.Size(198, 22);
            this.txtMocm.TabIndex = 4;
            // 
            // txtPiradiNom
            // 
            this.txtPiradiNom.EditValue = "";
            this.txtPiradiNom.Location = new System.Drawing.Point(15, 28);
            this.txtPiradiNom.Name = "txtPiradiNom";
            this.txtPiradiNom.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiradiNom.Properties.Appearance.Options.UseFont = true;
            this.txtPiradiNom.Size = new System.Drawing.Size(114, 22);
            this.txtPiradiNom.TabIndex = 0;
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
            // cbTransTypes
            // 
            this.cbTransTypes.Location = new System.Drawing.Point(15, 193);
            this.cbTransTypes.Name = "cbTransTypes";
            this.cbTransTypes.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransTypes.Properties.Appearance.Options.UseFont = true;
            this.cbTransTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTransTypes.Size = new System.Drawing.Size(241, 22);
            this.cbTransTypes.TabIndex = 7;
            // 
            // txtTransSxva
            // 
            this.txtTransSxva.Location = new System.Drawing.Point(299, 193);
            this.txtTransSxva.Name = "txtTransSxva";
            this.txtTransSxva.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransSxva.Properties.Appearance.Options.UseFont = true;
            this.txtTransSxva.Size = new System.Drawing.Size(198, 22);
            this.txtTransSxva.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(196, 79);
            this.txtNom.Name = "txtNom";
            this.txtNom.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Properties.Appearance.Options.UseFont = true;
            this.txtNom.Size = new System.Drawing.Size(97, 22);
            this.txtNom.TabIndex = 3;
            // 
            // chbMdzIsCitizen
            // 
            this.chbMdzIsCitizen.EditValue = true;
            this.chbMdzIsCitizen.Location = new System.Drawing.Point(15, 126);
            this.chbMdzIsCitizen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMdzIsCitizen.Name = "chbMdzIsCitizen";
            this.chbMdzIsCitizen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMdzIsCitizen.Properties.Appearance.Options.UseFont = true;
            this.chbMdzIsCitizen.Properties.AutoWidth = true;
            this.chbMdzIsCitizen.Properties.Caption = "არის საქართველოს მოქალაქე?";
            this.chbMdzIsCitizen.Size = new System.Drawing.Size(190, 20);
            this.chbMdzIsCitizen.TabIndex = 5;
            // 
            // chbIsDriver
            // 
            this.chbIsDriver.EditValue = true;
            this.chbIsDriver.Location = new System.Drawing.Point(299, 126);
            this.chbIsDriver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbIsDriver.Name = "chbIsDriver";
            this.chbIsDriver.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsDriver.Properties.Appearance.Options.UseFont = true;
            this.chbIsDriver.Properties.AutoWidth = true;
            this.chbIsDriver.Properties.Caption = "არის მძღოლი/გადამზიდი";
            this.chbIsDriver.Size = new System.Drawing.Size(169, 20);
            this.chbIsDriver.TabIndex = 6;
            // 
            // AddMdzForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(531, 279);
            this.Controls.Add(this.chbIsDriver);
            this.Controls.Add(this.chbMdzIsCitizen);
            this.Controls.Add(this.cbTransTypes);
            this.Controls.Add(this.btnCheckSagad);
            this.Controls.Add(this.txtPiradiNom);
            this.Controls.Add(laPiradiNom);
            this.Controls.Add(this.txtTransSxva);
            this.Controls.Add(laTransTypes);
            this.Controls.Add(laTransSxva);
            this.Controls.Add(this.txtMocm);
            this.Controls.Add(laMocm);
            this.Controls.Add(laNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(laMan);
            this.Controls.Add(this.txtMan);
            this.Controls.Add(laMdz);
            this.Controls.Add(this.txtMdz);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMdzForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddMdzForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMdz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMocm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiradiNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransSxva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMdzIsCitizen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsDriver.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private TextEdit txtMan;
        private TextEdit txtMdz;
        private TextEdit txtMocm;
        private TextEdit txtPiradiNom;
        private DevExpress.XtraEditors.SimpleButton btnCheckSagad;
        private DevExpress.XtraEditors.LookUpEdit cbTransTypes;
        private TextEdit txtTransSxva;
        private TextEdit txtNom;
        private CheckEdit chbMdzIsCitizen;
        private CheckEdit chbIsDriver;
    }
}