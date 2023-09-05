namespace SBS_BarthLogistic.Controls
{
    partial class FMGCheckedComboBoxFilter
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
            this.cb = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chb
            // 
            this.chb.Dock = System.Windows.Forms.DockStyle.Top;
            this.chb.Location = new System.Drawing.Point(0, 0);
            this.chb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb.Name = "chb";
            this.chb.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb.Properties.Appearance.Options.UseFont = true;
            this.chb.Properties.Caption = "";
            this.chb.Size = new System.Drawing.Size(174, 19);
            this.chb.TabIndex = 0;
            this.chb.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.chb);
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.cb);
            this.splitContainerControl.Size = new System.Drawing.Size(449, 30);
            this.splitContainerControl.SplitterDistance = 174;
            this.splitContainerControl.SplitterWidth = 5;
            this.splitContainerControl.TabIndex = 3;
            // 
            // cb
            // 
            this.cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb.EditValue = "";
            this.cb.Location = new System.Drawing.Point(0, 0);
            this.cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb.Name = "cb";
            this.cb.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Properties.Appearance.Options.UseFont = true;
            this.cb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb.Properties.IncrementalSearch = true;
            this.cb.Properties.SelectAllItemCaption = "(ყველას მონიშვნა)";
            this.cb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb.Size = new System.Drawing.Size(270, 26);
            this.cb.TabIndex = 0;
            // 
            // FMGCheckedComboBoxFilter
            // 
            this.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FMGCheckedComboBoxFilter";
            this.Size = new System.Drawing.Size(449, 30);
            this.Load += new System.EventHandler(this.FMGCheckedComboBoxFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).EndInit();
            this.splitContainerControl.Panel1.ResumeLayout(false);
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.CheckEdit chb;
        private System.Windows.Forms.SplitContainer splitContainerControl;
        public DevExpress.XtraEditors.CheckedComboBoxEdit cb;
    }
}
