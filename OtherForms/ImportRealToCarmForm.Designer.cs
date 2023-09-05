namespace SBS_BarthLogistic.OtherForms
{
    partial class ImportRealToCarmForm
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
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.chbAutoCarm2 = new DevExpress.XtraEditors.CheckEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.paCarm1 = new DevExpress.XtraEditors.PanelControl();
            this.fmgProek = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAutoCarm2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCarm1)).BeginInit();
            this.paCarm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(14, 37);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Properties.Appearance.Options.UseFont = true;
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtData.Size = new System.Drawing.Size(125, 26);
            this.txtData.TabIndex = 1;
            // 
            // laData
            // 
            this.laData.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laData.Location = new System.Drawing.Point(14, 14);
            this.laData.Name = "laData";
            this.laData.Size = new System.Drawing.Size(57, 19);
            this.laData.TabIndex = 0;
            this.laData.Text = "თარიღი";
            // 
            // chbAutoCarm2
            // 
            this.chbAutoCarm2.Location = new System.Drawing.Point(14, 127);
            this.chbAutoCarm2.Name = "chbAutoCarm2";
            this.chbAutoCarm2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAutoCarm2.Properties.Appearance.Options.UseFont = true;
            this.chbAutoCarm2.Properties.AutoWidth = true;
            this.chbAutoCarm2.Properties.Caption = "ნედლეულის ავტომატური ჩამოწერა(არსებულს წაშლის და თავიდან ჩამოწერს)";
            this.chbAutoCarm2.Size = new System.Drawing.Size(573, 23);
            this.chbAutoCarm2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(512, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // paCarm1
            // 
            this.paCarm1.Controls.Add(this.laData);
            this.paCarm1.Controls.Add(this.txtData);
            this.paCarm1.Controls.Add(this.chbAutoCarm2);
            this.paCarm1.Controls.Add(this.fmgProek);
            this.paCarm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paCarm1.Location = new System.Drawing.Point(0, 0);
            this.paCarm1.Name = "paCarm1";
            this.paCarm1.Size = new System.Drawing.Size(623, 178);
            this.paCarm1.TabIndex = 0;
            // 
            // fmgProek
            // 
            this.fmgProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProek.Appearance.Options.UseFont = true;
            this.fmgProek.FieldName = "Proek";
            this.fmgProek.Location = new System.Drawing.Point(14, 72);
            this.fmgProek.Name = "fmgProek";
            this.fmgProek.ParameterName = null;
            this.fmgProek.Size = new System.Drawing.Size(473, 30);
            this.fmgProek.TabIndex = 2;
            this.fmgProek.Text = "ობიექტი";
            // 
            // ImportRealToCarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 226);
            this.Controls.Add(this.paCarm1);
            this.Controls.Add(this.panel1);
            this.Name = "ImportRealToCarmForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "წარმოებული პროდუქციის იმპორტი რეალიზაციიდან";
            this.Load += new System.EventHandler(this.ImporRealToCarmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAutoCarm2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCarm1)).EndInit();
            this.paCarm1.ResumeLayout(false);
            this.paCarm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit txtData;
        private Controls.FMGComboFilterControl fmgProek;
        private DevExpress.XtraEditors.LabelControl laData;
        private DevExpress.XtraEditors.CheckEdit chbAutoCarm2;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PanelControl paCarm1;
    }
}