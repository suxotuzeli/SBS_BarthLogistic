namespace SBS_BarthLogistic.OtherForms
{
    partial class GenerateShesTanxaForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.txtTanxa = new DevExpress.XtraEditors.CalcEdit();
            this.laTanxa = new DevExpress.XtraEditors.LabelControl();
            this.txtTanxaNew = new DevExpress.XtraEditors.CalcEdit();
            this.laTanxa2 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxaNew.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTanxa
            // 
            this.txtTanxa.Enabled = false;
            this.txtTanxa.Location = new System.Drawing.Point(123, 26);
            this.txtTanxa.Name = "txtTanxa";
            this.txtTanxa.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanxa.Properties.Appearance.Options.UseFont = true;
            this.txtTanxa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtTanxa.Properties.DisplayFormat.FormatString = "f4";
            this.txtTanxa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxa.Properties.EditFormat.FormatString = "f4";
            this.txtTanxa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxa.Properties.Mask.EditMask = "f4";
            this.txtTanxa.Properties.NullText = "0.0000";
            this.txtTanxa.Size = new System.Drawing.Size(120, 26);
            this.txtTanxa.TabIndex = 0;
            // 
            // laTanxa
            // 
            this.laTanxa.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTanxa.Location = new System.Drawing.Point(36, 30);
            this.laTanxa.Name = "laTanxa";
            this.laTanxa.Size = new System.Drawing.Size(77, 19);
            this.laTanxa.TabIndex = 1;
            this.laTanxa.Text = "მიმდინარე";
            // 
            // txtTanxaNew
            // 
            this.txtTanxaNew.Location = new System.Drawing.Point(123, 86);
            this.txtTanxaNew.Name = "txtTanxaNew";
            this.txtTanxaNew.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanxaNew.Properties.Appearance.Options.UseFont = true;
            this.txtTanxaNew.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txtTanxaNew.Properties.DisplayFormat.FormatString = "f4";
            this.txtTanxaNew.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxaNew.Properties.EditFormat.FormatString = "f4";
            this.txtTanxaNew.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxaNew.Properties.Mask.EditMask = "f4";
            this.txtTanxaNew.Properties.NullText = "0.0000";
            this.txtTanxaNew.Size = new System.Drawing.Size(120, 26);
            this.txtTanxaNew.TabIndex = 0;
            // 
            // laTanxa2
            // 
            this.laTanxa2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTanxa2.Location = new System.Drawing.Point(71, 90);
            this.laTanxa2.Name = "laTanxa2";
            this.laTanxa2.Size = new System.Drawing.Size(42, 19);
            this.laTanxa2.TabIndex = 1;
            this.laTanxa2.Text = "ახალი";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(82, 148);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "გადანაწილება";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GenerateShesTanxaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 200);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.laTanxa2);
            this.Controls.Add(this.laTanxa);
            this.Controls.Add(this.txtTanxaNew);
            this.Controls.Add(this.txtTanxa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateShesTanxaForm";
            this.ShowIcon = false;
            this.Text = "თანხის გადანაწილება";
            this.Load += new System.EventHandler(this.GenerateShesTanxaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxaNew.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CalcEdit txtTanxa;
        private DevExpress.XtraEditors.LabelControl laTanxa;
        private DevExpress.XtraEditors.CalcEdit txtTanxaNew;
        private DevExpress.XtraEditors.LabelControl laTanxa2;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}