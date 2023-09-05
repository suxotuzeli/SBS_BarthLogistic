namespace SBS_BarthLogistic.Controls
{
    partial class FMGDateFilterControl
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.chb = new DevExpress.XtraEditors.CheckEdit();
            this.txtData2 = new DevExpress.XtraEditors.DateEdit();
            this.txtData1 = new DevExpress.XtraEditors.DateEdit();
            this.splitContainerControl = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties)).BeginInit();
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
            this.chb.Name = "chb";
            this.chb.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb.Properties.Appearance.Options.UseFont = true;
            this.chb.Properties.Caption = "CheckBox";
            this.chb.Size = new System.Drawing.Size(148, 20);
            this.chb.TabIndex = 0;
            this.chb.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // txtData2
            // 
            this.txtData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData2.EditValue = new System.DateTime(2015, 8, 6, 0, 0, 0, 0);
            this.txtData2.Location = new System.Drawing.Point(116, 0);
            this.txtData2.Name = "txtData2";
            this.txtData2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Properties.Appearance.Options.UseFont = true;
            this.txtData2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtData_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtData2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData2.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.txtData2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData2.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.txtData2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData2.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.txtData2.Size = new System.Drawing.Size(116, 22);
            this.txtData2.TabIndex = 0;
            // 
            // txtData1
            // 
            this.txtData1.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtData1.EditValue = new System.DateTime(2015, 8, 6, 0, 0, 0, 0);
            this.txtData1.Location = new System.Drawing.Point(0, 0);
            this.txtData1.Name = "txtData1";
            this.txtData1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData1.Properties.Appearance.Options.UseFont = true;
            this.txtData1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtData_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txtData1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData1.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.txtData1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData1.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.txtData1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData1.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.txtData1.Size = new System.Drawing.Size(116, 22);
            this.txtData1.TabIndex = 0;
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.chb);
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.txtData2);
            this.splitContainerControl.Panel2.Controls.Add(this.txtData1);
            this.splitContainerControl.Size = new System.Drawing.Size(385, 23);
            this.splitContainerControl.SplitterDistance = 148;
            this.splitContainerControl.SplitterWidth = 5;
            this.splitContainerControl.TabIndex = 0;
            // 
            // FMGDateFilterControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainerControl);
            this.MinimumSize = new System.Drawing.Size(385, 23);
            this.Name = "FMGDateFilterControl";
            this.Size = new System.Drawing.Size(385, 23);
            this.Load += new System.EventHandler(this.FMGDateFilterControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties)).EndInit();
            this.splitContainerControl.Panel1.ResumeLayout(false);
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.CheckEdit chb;
        public DevExpress.XtraEditors.DateEdit txtData2;
        public DevExpress.XtraEditors.DateEdit txtData1;
        private System.Windows.Forms.SplitContainer splitContainerControl;
    }
}
