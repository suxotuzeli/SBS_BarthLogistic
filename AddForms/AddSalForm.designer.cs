using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddSalForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.laSalT = new DevExpress.XtraEditors.LabelControl();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.cbSalT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTanxa = new DevExpress.XtraEditors.CalcEdit();
            this.laTanxa = new DevExpress.XtraEditors.LabelControl();
            this.laZedd = new DevExpress.XtraEditors.LabelControl();
            this.cbSalaro = new DevExpress.XtraEditors.LookUpEdit();
            this.laSalaro = new DevExpress.XtraEditors.LabelControl();
            this.laIdGvari = new DevExpress.XtraEditors.LabelControl();
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.cbOrg = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSalT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSalaro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(454, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(362, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 39);
            this.panel1.TabIndex = 7;
            // 
            // laData
            // 
            this.laData.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laData.Appearance.Options.UseFont = true;
            this.laData.Location = new System.Drawing.Point(18, 6);
            this.laData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laData.Name = "laData";
            this.laData.Size = new System.Drawing.Size(47, 16);
            this.laData.TabIndex = 0;
            this.laData.Text = "თარიღი";
            // 
            // laSalT
            // 
            this.laSalT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSalT.Appearance.Options.UseFont = true;
            this.laSalT.Location = new System.Drawing.Point(18, 136);
            this.laSalT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laSalT.Name = "laSalT";
            this.laSalT.Size = new System.Drawing.Size(87, 16);
            this.laSalT.TabIndex = 6;
            this.laSalT.Text = "გადახდის ტიპი";
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Appearance.Options.UseFont = true;
            this.laShen.Location = new System.Drawing.Point(287, 136);
            this.laShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(48, 16);
            this.laShen.TabIndex = 7;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(287, 155);
            this.txtShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(245, 22);
            this.txtShen.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(18, 26);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtData.Size = new System.Drawing.Size(107, 22);
            this.txtData.TabIndex = 0;
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // cbSalT
            // 
            this.cbSalT.Location = new System.Drawing.Point(18, 155);
            this.cbSalT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalT.Name = "cbSalT";
            this.cbSalT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalT.Properties.Appearance.Options.UseFont = true;
            this.cbSalT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSalT.Size = new System.Drawing.Size(245, 22);
            this.cbSalT.TabIndex = 5;
            // 
            // txtTanxa
            // 
            this.txtTanxa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTanxa.Location = new System.Drawing.Point(287, 83);
            this.txtTanxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTanxa.Name = "txtTanxa";
            this.txtTanxa.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanxa.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit;
            this.txtTanxa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtTanxa.Properties.DisplayFormat.FormatString = "f4";
            this.txtTanxa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxa.Properties.EditFormat.FormatString = "f4";
            this.txtTanxa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTanxa.Properties.Mask.EditMask = "f4";
            this.txtTanxa.Properties.NullText = "0.0000";
            this.txtTanxa.Size = new System.Drawing.Size(100, 22);
            this.txtTanxa.TabIndex = 4;
            // 
            // laTanxa
            // 
            this.laTanxa.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTanxa.Appearance.Options.UseFont = true;
            this.laTanxa.Location = new System.Drawing.Point(287, 62);
            this.laTanxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laTanxa.Name = "laTanxa";
            this.laTanxa.Size = new System.Drawing.Size(32, 16);
            this.laTanxa.TabIndex = 4;
            this.laTanxa.Text = "თანხა";
            // 
            // laZedd
            // 
            this.laZedd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laZedd.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.laZedd.Appearance.Options.UseFont = true;
            this.laZedd.Appearance.Options.UseForeColor = true;
            this.laZedd.Location = new System.Drawing.Point(412, 6);
            this.laZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laZedd.Name = "laZedd";
            this.laZedd.Size = new System.Drawing.Size(74, 16);
            this.laZedd.TabIndex = 2;
            this.laZedd.Text = "ზედდებული";
            // 
            // cbSalaro
            // 
            this.cbSalaro.Location = new System.Drawing.Point(18, 83);
            this.cbSalaro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSalaro.Name = "cbSalaro";
            this.cbSalaro.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalaro.Properties.Appearance.Options.UseFont = true;
            this.cbSalaro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSalaro.Size = new System.Drawing.Size(245, 22);
            this.cbSalaro.TabIndex = 3;
            this.cbSalaro.Enter += new System.EventHandler(this.cbSalaro_Enter);
            // 
            // laSalaro
            // 
            this.laSalaro.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSalaro.Appearance.Options.UseFont = true;
            this.laSalaro.Location = new System.Drawing.Point(18, 62);
            this.laSalaro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laSalaro.Name = "laSalaro";
            this.laSalaro.Size = new System.Drawing.Size(45, 16);
            this.laSalaro.TabIndex = 3;
            this.laSalaro.Text = "სალარო";
            // 
            // laIdGvari
            // 
            this.laIdGvari.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIdGvari.Appearance.Options.UseFont = true;
            this.laIdGvari.Location = new System.Drawing.Point(143, 6);
            this.laIdGvari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laIdGvari.Name = "laIdGvari";
            this.laIdGvari.Size = new System.Drawing.Size(72, 16);
            this.laIdGvari.TabIndex = 1;
            this.laIdGvari.Text = "მყიდვ. კოდი";
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(412, 26);
            this.txtZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(119, 22);
            this.txtZedd.TabIndex = 2;
            this.txtZedd.Enter += new System.EventHandler(this.txtZedd_Enter);
            // 
            // cbOrg
            // 
            this.cbOrg.Location = new System.Drawing.Point(143, 26);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrg.Properties.Appearance.Options.UseFont = true;
            this.cbOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrg.Size = new System.Drawing.Size(245, 22);
            this.cbOrg.TabIndex = 1;
            // 
            // AddSalForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(552, 233);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.txtZedd);
            this.Controls.Add(this.laIdGvari);
            this.Controls.Add(this.cbSalaro);
            this.Controls.Add(this.laZedd);
            this.Controls.Add(this.laSalaro);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtTanxa);
            this.Controls.Add(this.laTanxa);
            this.Controls.Add(this.cbSalT);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.laSalT);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddSalForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddSalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSalT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSalaro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private LabelControl laData;
        private LabelControl laSalT;
        private LabelControl laShen;
        private TextEdit txtShen;
        private DateEdit txtData;
        private DevExpress.XtraEditors.LookUpEdit cbSalT;
        private CalcEdit  txtTanxa;
        private LabelControl laTanxa;
        private LabelControl laZedd;
        private DevExpress.XtraEditors.LookUpEdit cbSalaro;
        private LabelControl laSalaro;
        private LabelControl laIdGvari;
        private TextEdit txtZedd;
        private LookUpEdit cbOrg;
    }
}