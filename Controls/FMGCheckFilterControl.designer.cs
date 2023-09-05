namespace SBS_BarthLogistic.Controls
{
    partial class FMGCheckFilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chb = new DevExpress.XtraEditors.CheckEdit();
            this.splitContainerControl = new System.Windows.Forms.SplitContainer();
            this.chbHidden = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbHidden.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chb
            // 
            this.chb.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb.Location = new System.Drawing.Point(0, 0);
            this.chb.Name = "chb";
            this.chb.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb.Properties.Appearance.Options.UseFont = true;
            this.chb.Properties.Caption = "CheckBox";
            this.chb.Size = new System.Drawing.Size(150, 20);
            this.chb.TabIndex = 0;
            this.chb.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.chb);
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.chbHidden);
            this.splitContainerControl.Size = new System.Drawing.Size(385, 23);
            this.splitContainerControl.SplitterDistance = 150;
            this.splitContainerControl.SplitterWidth = 5;
            this.splitContainerControl.TabIndex = 3;
            // 
            // chbHidden
            // 
            this.chbHidden.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbHidden.Location = new System.Drawing.Point(0, 0);
            this.chbHidden.Name = "chbHidden";
            this.chbHidden.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHidden.Properties.Appearance.Options.UseFont = true;
            this.chbHidden.Properties.Caption = "CheckBox";
            this.chbHidden.Size = new System.Drawing.Size(230, 20);
            this.chbHidden.TabIndex = 1;
            // 
            // FMGCheckFilterControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.MinimumSize = new System.Drawing.Size(385, 23);
            this.Name = "FMGCheckFilterControl";
            this.Size = new System.Drawing.Size(385, 23);
            this.Load += new System.EventHandler(this.FMGControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).EndInit();
            this.splitContainerControl.Panel1.ResumeLayout(false);
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbHidden.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.CheckEdit chb;
        private System.Windows.Forms.SplitContainer splitContainerControl;
        public DevExpress.XtraEditors.CheckEdit chbHidden;
    }
}
