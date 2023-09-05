namespace SBS_Moms.InterfaceForms
{
    partial class NoteForm
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
            this.paTop = new DevExpress.XtraEditors.PanelControl();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.laRemind = new DevExpress.XtraEditors.LabelControl();
            this.cbTanam = new DevExpress.XtraEditors.LookUpEdit();
            this.chbTanamshromeli = new DevExpress.XtraEditors.CheckEdit();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.paBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTanam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTanamshromeli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.txtData);
            this.paTop.Controls.Add(this.laRemind);
            this.paTop.Controls.Add(this.cbTanam);
            this.paTop.Controls.Add(this.chbTanamshromeli);
            this.paTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTop.Location = new System.Drawing.Point(0, 0);
            this.paTop.Name = "paTop";
            this.paTop.Size = new System.Drawing.Size(659, 40);
            this.paTop.TabIndex = 0;
            // 
            // txtData
            // 
            this.txtData.EditValue = new System.DateTime(2015, 8, 26, 22, 28, 24, 0);
            this.txtData.Location = new System.Drawing.Point(108, 6);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtData.Properties.Appearance.Options.UseFont = true;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            this.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm";
            this.txtData.Size = new System.Drawing.Size(140, 28);
            this.txtData.TabIndex = 10;
            // 
            // laRemind
            // 
            this.laRemind.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laRemind.Location = new System.Drawing.Point(12, 9);
            this.laRemind.Name = "laRemind";
            this.laRemind.Size = new System.Drawing.Size(74, 22);
            this.laRemind.TabIndex = 11;
            this.laRemind.Text = "შემახსენოს";
            // 
            // cbTanam
            // 
            this.cbTanam.Location = new System.Drawing.Point(411, 6);
            this.cbTanam.Name = "cbTanam";
            this.cbTanam.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanam.Properties.Appearance.Options.UseFont = true;
            this.cbTanam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTanam.Size = new System.Drawing.Size(233, 28);
            this.cbTanam.TabIndex = 8;
            // 
            // chbTanamshromeli
            // 
            this.chbTanamshromeli.Location = new System.Drawing.Point(254, 7);
            this.chbTanamshromeli.Name = "chbTanamshromeli";
            this.chbTanamshromeli.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbTanamshromeli.Properties.Appearance.Options.UseFont = true;
            this.chbTanamshromeli.Properties.AutoWidth = true;
            this.chbTanamshromeli.Properties.Caption = "გაგზავნა სხვისთვის";
            this.chbTanamshromeli.Size = new System.Drawing.Size(151, 26);
            this.chbTanamshromeli.TabIndex = 9;
            this.chbTanamshromeli.CheckedChanged += new System.EventHandler(this.chbTanam_CheckedChanged);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.EditValue = "";
            this.txtNote.Location = new System.Drawing.Point(0, 40);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Size = new System.Drawing.Size(659, 297);
            this.txtNote.TabIndex = 1;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btnClose);
            this.paBottom.Controls.Add(this.btnSave);
            this.paBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom.Location = new System.Drawing.Point(0, 337);
            this.paBottom.Name = "paBottom";
            this.paBottom.Size = new System.Drawing.Size(659, 50);
            this.paBottom.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::SBS_Moms.Properties.Resources.AED_Close_32x32;
            this.btnClose.Location = new System.Drawing.Point(546, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 46);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 387);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.paBottom);
            this.Controls.Add(this.paTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NoteForm";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTanam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTanamshromeli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paTop;
        private DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.PanelControl paBottom;
        private DevExpress.XtraEditors.CheckEdit chbTanamshromeli;
        private DevExpress.XtraEditors.LookUpEdit cbTanam;
        private DevExpress.XtraEditors.DateEdit txtData;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl laRemind;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}