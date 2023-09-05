namespace SBS_BarthLogistic.Controls
{
    partial class FMGGvariFilterControl
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
            this.txt = new SBS_BarthLogistic.Controls.GvariSelect();
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // chb
            // 
            this.chb.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb.Location = new System.Drawing.Point(0, 0);
            this.chb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb.Name = "chb";
            this.chb.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F);
            this.chb.Properties.Appearance.Options.UseFont = true;
            this.chb.Properties.Caption = "CheckBox";
            this.chb.Size = new System.Drawing.Size(150, 19);
            this.chb.TabIndex = 0;
            this.chb.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.myLabel);
            this.splitContainerControl.Panel1.Controls.Add(this.chb);
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.txt);
            this.splitContainerControl.Size = new System.Drawing.Size(384, 44);
            this.splitContainerControl.SplitterDistance = 150;
            this.splitContainerControl.TabIndex = 3;
            // 
            // myLabel
            // 
            this.myLabel.Location = new System.Drawing.Point(0, 24);
            this.myLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(0, 13);
            this.myLabel.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.CustomLabel = null;
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.Filter = null;
            this.txt.Id = null;
            this.txt.Label = "";
            this.txt.Location = new System.Drawing.Point(0, 0);
            this.txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(230, 44);
            this.txt.TabIndex = 0;
            // 
            // FMGGvariFilterControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMGGvariFilterControl";
            this.Size = new System.Drawing.Size(384, 44);
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
        private GvariSelect txt;
        private DevExpress.XtraEditors.LabelControl myLabel;
    }
}
