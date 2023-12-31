namespace SBS_BarthLogistic.AddForms
{
    partial class AddAdminCnobariForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdminCnobariForm));
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtFieldName = new DevExpress.XtraEditors.TextEdit();
            this.laFieldName = new DevExpress.XtraEditors.LabelControl();
            this.chbActive = new DevExpress.XtraEditors.CheckEdit();
            this.paButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paButtons)).BeginInit();
            this.paButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Location = new System.Drawing.Point(24, 67);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(60, 19);
            this.laShen.TabIndex = 7;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(24, 93);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(579, 26);
            this.txtShen.TabIndex = 1;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(24, 39);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFieldName.Properties.Appearance.Options.UseFont = true;
            this.txtFieldName.Size = new System.Drawing.Size(678, 26);
            this.txtFieldName.TabIndex = 0;
            // 
            // laFieldName
            // 
            this.laFieldName.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFieldName.Location = new System.Drawing.Point(24, 13);
            this.laFieldName.Name = "laFieldName";
            this.laFieldName.Size = new System.Drawing.Size(99, 19);
            this.laFieldName.TabIndex = 7;
            this.laFieldName.Text = "ველის სახელი";
            // 
            // chbActive
            // 
            this.chbActive.EditValue = true;
            this.chbActive.Location = new System.Drawing.Point(611, 94);
            this.chbActive.Name = "chbActive";
            this.chbActive.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbActive.Properties.Appearance.Options.UseFont = true;
            this.chbActive.Properties.AutoWidth = true;
            this.chbActive.Properties.Caption = "აქტიური?";
            this.chbActive.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style15;
            this.chbActive.Size = new System.Drawing.Size(93, 23);
            this.chbActive.TabIndex = 2;
            // 
            // paButtons
            // 
            this.paButtons.Controls.Add(this.btnOK);
            this.paButtons.Controls.Add(this.btnCancel);
            this.paButtons.Controls.Add(this.btnAdd);
            this.paButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paButtons.Location = new System.Drawing.Point(0, 429);
            this.paButtons.Name = "paButtons";
            this.paButtons.Size = new System.Drawing.Size(736, 50);
            this.paButtons.TabIndex = 72;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOK.Location = new System.Drawing.Point(551, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 37);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(644, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddAdminCnobariForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(736, 479);
            this.Controls.Add(this.paButtons);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.laFieldName);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.txtShen);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "AddAdminCnobariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddAdminCnobariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paButtons)).EndInit();
            this.paButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl laShen;
        private DevExpress.XtraEditors.TextEdit txtShen;
        private DevExpress.XtraEditors.TextEdit txtFieldName;
        private DevExpress.XtraEditors.LabelControl laFieldName;
        private DevExpress.XtraEditors.CheckEdit chbActive;
        private DevExpress.XtraEditors.PanelControl paButtons;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}