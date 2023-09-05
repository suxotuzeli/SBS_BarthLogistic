namespace SBS_BarthLogistic.InterfaceForms
{
    partial class ErrorDialog
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
            this.btnDetail = new DevExpress.XtraEditors.SimpleButton();
            this.paBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.txtToString = new DevExpress.XtraEditors.MemoEdit();
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.paBottom2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom2)).BeginInit();
            this.paBottom2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetail
            // 
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDetail.Location = new System.Drawing.Point(0, 0);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(145, 25);
            this.btnDetail.TabIndex = 0;
            this.btnDetail.Text = "დეტალურად";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // paBottom
            // 
            this.paBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paBottom.Controls.Add(this.btnClose);
            this.paBottom.Controls.Add(this.btnExit);
            this.paBottom.Controls.Add(this.btnDetail);
            this.paBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom.Location = new System.Drawing.Point(2, 101);
            this.paBottom.Name = "paBottom";
            this.paBottom.Size = new System.Drawing.Size(607, 25);
            this.paBottom.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(297, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "გაგრძელება";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(442, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "პროგამიდან გამოსვლა";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtToString
            // 
            this.txtToString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToString.Location = new System.Drawing.Point(2, 2);
            this.txtToString.Name = "txtToString";
            this.txtToString.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtToString.Properties.ReadOnly = true;
            this.txtToString.Size = new System.Drawing.Size(607, 96);
            this.txtToString.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.EditValue = "Message";
            this.txtMessage.Location = new System.Drawing.Point(2, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Properties.Appearance.Options.UseFont = true;
            this.txtMessage.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMessage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMessage.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.txtMessage.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtMessage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMessage.Properties.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(607, 99);
            this.txtMessage.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtMessage);
            this.panelControl1.Controls.Add(this.paBottom);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(611, 128);
            this.panelControl1.TabIndex = 3;
            // 
            // paBottom2
            // 
            this.paBottom2.Controls.Add(this.txtToString);
            this.paBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom2.Location = new System.Drawing.Point(0, 28);
            this.paBottom2.Name = "paBottom2";
            this.paBottom2.Size = new System.Drawing.Size(611, 100);
            this.paBottom2.TabIndex = 0;
            this.paBottom2.Visible = false;
            // 
            // ErrorDialog
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(611, 128);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.paBottom2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ErrorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtToString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom2)).EndInit();
            this.paBottom2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDetail;
        private DevExpress.XtraEditors.PanelControl paBottom;
        private DevExpress.XtraEditors.MemoEdit txtToString;
        private DevExpress.XtraEditors.MemoEdit txtMessage;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl paBottom2;

    }
}