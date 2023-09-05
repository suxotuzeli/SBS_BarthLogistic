namespace SBS_Moms.Controls
{
    partial class FMGOrgFilterControl
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
            this.myLabel = new DevExpress.XtraEditors.LabelControl();
            this.txt = new SBS_Moms.Controls.OrgSelect();
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // chb
            // 
            this.chb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chb.Location = new System.Drawing.Point(0, 3);
            this.chb.Name = "chb";
            this.chb.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F);
            this.chb.Properties.Appearance.Options.UseFont = true;
            this.chb.Properties.Caption = "CheckBox";
            this.chb.Size = new System.Drawing.Size(175, 23);
            this.chb.TabIndex = 0;
            this.chb.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.myLabel);
            this.splitContainerControl.Panel1.Controls.Add(this.chb);
            this.splitContainerControl.Panel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.txt);
            this.splitContainerControl.Panel2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.splitContainerControl.Size = new System.Drawing.Size(448, 60);
            this.splitContainerControl.SplitterDistance = 175;
            this.splitContainerControl.SplitterWidth = 5;
            this.splitContainerControl.TabIndex = 3;
            // 
            // myLabel
            // 
            this.myLabel.Location = new System.Drawing.Point(0, 33);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(0, 16);
            this.myLabel.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.CustomLabel = this.myLabel;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Id = null;
            this.txt.Label = "";
            this.txt.Location = new System.Drawing.Point(0, 1);
            this.txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt.Name = "txt";
            this.txt.SearchOnLeave = false;
            this.txt.Size = new System.Drawing.Size(268, 59);
            this.txt.TabIndex = 0;
            // 
            // FMGOrgFilterControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Name = "FMGOrgFilterControl";
            this.Size = new System.Drawing.Size(448, 60);
            this.Load += new System.EventHandler(this.FMGTextFilterControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).EndInit();
            this.splitContainerControl.Panel1.ResumeLayout(false);
            this.splitContainerControl.Panel1.PerformLayout();
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.CheckEdit chb;
        private System.Windows.Forms.SplitContainer splitContainerControl;
        private OrgSelect txt;
        private DevExpress.XtraEditors.LabelControl myLabel;
    }
}
