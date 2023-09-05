namespace SBS_BarthLogistic.AddForms
{
    partial class AddAllForm
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
            this.paButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.paComponents = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paButtons)).BeginInit();
            this.paButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // paButtons
            // 
            this.paButtons.Controls.Add(this.btnOK);
            this.paButtons.Controls.Add(this.btnCancel);
            this.paButtons.Controls.Add(this.btnAdd);
            this.paButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paButtons.Location = new System.Drawing.Point(0, 103);
            this.paButtons.Name = "paButtons";
            this.paButtons.Size = new System.Drawing.Size(660, 50);
            this.paButtons.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            
            this.btnOK.Location = new System.Drawing.Point(428, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 37);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(544, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            
            this.btnAdd.Location = new System.Drawing.Point(5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // paComponents
            // 
            this.paComponents.AutoSize = true;
            this.paComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paComponents.Location = new System.Drawing.Point(0, 0);
            this.paComponents.Name = "paComponents";
            this.paComponents.Size = new System.Drawing.Size(660, 103);
            this.paComponents.TabIndex = 0;
            // 
            // AddAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(660, 153);
            this.Controls.Add(this.paComponents);
            this.Controls.Add(this.paButtons);
            
            this.Name = "AddAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paButtons)).EndInit();
            this.paButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paComponents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paButtons;
        private DevExpress.XtraEditors.PanelControl paComponents;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}