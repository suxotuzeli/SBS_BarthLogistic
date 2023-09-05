namespace SBS_BarthLogistic.OtherForms
{
    partial class SetCalcFasiForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTvitg = new DevExpress.XtraEditors.CalcEdit();
            this.txtDanamati = new DevExpress.XtraEditors.CalcEdit();
            this.txtPercent = new DevExpress.XtraEditors.CalcEdit();
            this.txtTanxa = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTvitg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanamati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(221, 199);
            
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(110, 199);
            
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 28);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&Update";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "თვითღირებულება";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "დანამატი";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ნამატი პროცენტი";
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "გასაყიდი ფასი";
            // 
            // txtTvitg
            // 
            this.txtTvitg.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTvitg.Location = new System.Drawing.Point(303, 15);
            this.txtTvitg.Name = "txtTvitg";
            this.txtTvitg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTvitg.Properties.Appearance.Options.UseFont = true;
            this.txtTvitg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtTvitg.Properties.DisplayFormat.FormatString = "f2";
            this.txtTvitg.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTvitg.Properties.EditFormat.FormatString = "f2";
            this.txtTvitg.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTvitg.Properties.Mask.EditMask = "f2";
            this.txtTvitg.Size = new System.Drawing.Size(85, 26);
            this.txtTvitg.TabIndex = 1;
            // 
            // txtDanamati
            // 
            this.txtDanamati.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDanamati.Location = new System.Drawing.Point(303, 55);
            this.txtDanamati.Name = "txtDanamati";
            this.txtDanamati.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanamati.Properties.Appearance.Options.UseFont = true;
            this.txtDanamati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txtDanamati.Properties.DisplayFormat.FormatString = "f2";
            this.txtDanamati.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDanamati.Properties.EditFormat.FormatString = "f2";
            this.txtDanamati.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDanamati.Properties.Mask.EditMask = "f2";
            this.txtDanamati.Size = new System.Drawing.Size(85, 26);
            this.txtDanamati.TabIndex = 3;
            // 
            // txtPercent
            // 
            this.txtPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPercent.Location = new System.Drawing.Point(303, 96);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Properties.Appearance.Options.UseFont = true;
            this.txtPercent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.txtPercent.Properties.DisplayFormat.FormatString = "f2";
            this.txtPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPercent.Properties.EditFormat.FormatString = "f2";
            this.txtPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPercent.Properties.Mask.EditMask = "f2";
            this.txtPercent.Size = new System.Drawing.Size(85, 26);
            this.txtPercent.TabIndex = 5;
            // 
            // txtTanxa
            // 
            this.txtTanxa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTanxa.Location = new System.Drawing.Point(303, 141);
            this.txtTanxa.Name = "txtTanxa";
            this.txtTanxa.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanxa.Properties.Appearance.Options.UseFont = true;
            this.txtTanxa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.txtTanxa.Properties.DisplayFormat.FormatString = "f2";
            this.txtTanxa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxa.Properties.EditFormat.FormatString = "f2";
            this.txtTanxa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxa.Properties.Mask.EditMask = "f2";
            this.txtTanxa.Size = new System.Drawing.Size(85, 26);
            this.txtTanxa.TabIndex = 7;
            // 
            // SetCalcFasiForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(419, 241);
            this.Controls.Add(this.txtTanxa);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtDanamati);
            this.Controls.Add(this.txtTvitg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetCalcFasiForm";
            this.ShowIcon = false;
            this.Text = "წარმოებული პროდუქციის  ფასის ფორმირება";
            this.Load += new System.EventHandler(this.SetCalcFasiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTvitg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDanamati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.CalcEdit txtTvitg;
        private DevExpress.XtraEditors.CalcEdit txtDanamati;
        private DevExpress.XtraEditors.CalcEdit txtPercent;
        private DevExpress.XtraEditors.CalcEdit txtTanxa;
    }
}