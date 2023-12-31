using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddProekForm
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
            this.txtProek = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laProek = new DevExpress.XtraEditors.LabelControl();
            this.cbProekT = new DevExpress.XtraEditors.LookUpEdit();
            this.laProekT = new DevExpress.XtraEditors.LabelControl();
            this.laAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.laPhone = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.chbIsCustomClearance = new DevExpress.XtraEditors.CheckEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtProek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProekT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsCustomClearance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProek
            // 
            this.txtProek.Location = new System.Drawing.Point(15, 34);
            this.txtProek.Name = "txtProek";
            this.txtProek.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProek.Properties.Appearance.Options.UseFont = true;
            this.txtProek.Size = new System.Drawing.Size(397, 22);
            this.txtProek.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 39);
            this.panel1.TabIndex = 7;
            // 
            // laProek
            // 
            this.laProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProek.Appearance.Options.UseFont = true;
            this.laProek.Location = new System.Drawing.Point(15, 12);
            this.laProek.Name = "laProek";
            this.laProek.Size = new System.Drawing.Size(49, 16);
            this.laProek.TabIndex = 0;
            this.laProek.Text = "ობიექტი";
            // 
            // cbProekT
            // 
            this.cbProekT.Location = new System.Drawing.Point(15, 84);
            this.cbProekT.Name = "cbProekT";
            this.cbProekT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProekT.Properties.Appearance.Options.UseFont = true;
            this.cbProekT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProekT.Size = new System.Drawing.Size(397, 22);
            this.cbProekT.TabIndex = 2;
            // 
            // laProekT
            // 
            this.laProekT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProekT.Appearance.Options.UseFont = true;
            this.laProekT.Location = new System.Drawing.Point(15, 62);
            this.laProekT.Name = "laProekT";
            this.laProekT.Size = new System.Drawing.Size(110, 16);
            this.laProekT.TabIndex = 2;
            this.laProekT.Text = "ობიექტების ჯგუფი";
            // 
            // laAddress
            // 
            this.laAddress.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laAddress.Appearance.Options.UseFont = true;
            this.laAddress.Location = new System.Drawing.Point(15, 161);
            this.laAddress.Name = "laAddress";
            this.laAddress.Size = new System.Drawing.Size(61, 16);
            this.laAddress.TabIndex = 4;
            this.laAddress.Text = "მისამართი";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 183);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(397, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // laPhone
            // 
            this.laPhone.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPhone.Appearance.Options.UseFont = true;
            this.laPhone.Location = new System.Drawing.Point(15, 112);
            this.laPhone.Name = "laPhone";
            this.laPhone.Size = new System.Drawing.Size(63, 16);
            this.laPhone.TabIndex = 3;
            this.laPhone.Text = "ტელეფონი";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(397, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Appearance.Options.UseFont = true;
            this.laShen.Location = new System.Drawing.Point(15, 211);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(48, 16);
            this.laShen.TabIndex = 5;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(15, 233);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(397, 22);
            this.txtShen.TabIndex = 5;
            // 
            // chbIsCustomClearance
            // 
            this.chbIsCustomClearance.EditValue = true;
            this.chbIsCustomClearance.Location = new System.Drawing.Point(15, 271);
            this.chbIsCustomClearance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbIsCustomClearance.Name = "chbIsCustomClearance";
            this.chbIsCustomClearance.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsCustomClearance.Properties.Appearance.Options.UseFont = true;
            this.chbIsCustomClearance.Properties.AutoWidth = true;
            this.chbIsCustomClearance.Properties.Caption = "არის საბაჟოს საწყობი?";
            this.chbIsCustomClearance.Size = new System.Drawing.Size(148, 20);
            this.chbIsCustomClearance.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.add_16x161;
            this.btnAdd.Location = new System.Drawing.Point(12, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.cancel_16x161;
            this.btnCancel.Location = new System.Drawing.Point(353, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.apply_16x161;
            this.btnOK.Location = new System.Drawing.Point(263, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddProekForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(447, 340);
            this.Controls.Add(this.chbIsCustomClearance);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laPhone);
            this.Controls.Add(this.laAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cbProekT);
            this.Controls.Add(this.laProekT);
            this.Controls.Add(this.laProek);
            this.Controls.Add(this.txtProek);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProekForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddProekForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbProekT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsCustomClearance.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private TextEdit txtProek;
        private PanelControl panel1;
        private LabelControl laProek;
        private DevExpress.XtraEditors.LookUpEdit cbProekT;
        private LabelControl laProekT;
        private LabelControl laAddress;
        private TextEdit txtAddress;
        private LabelControl laPhone;
        private TextEdit txtPhone;
        private LabelControl laShen;
        private TextEdit txtShen;
        private CheckEdit chbIsCustomClearance;
    }
}