using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class GenerateShesForm
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.laFactura = new DevExpress.XtraEditors.LabelControl();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.chbIncludeDgg = new DevExpress.XtraEditors.CheckEdit();
            this.txtKursi = new DevExpress.XtraEditors.CalcEdit();
            this.laKursi = new DevExpress.XtraEditors.LabelControl();
            this.cbMomc = new DevExpress.XtraEditors.LookUpEdit();
            this.laMomc = new DevExpress.XtraEditors.LabelControl();
            this.cbValuta = new DevExpress.XtraEditors.LookUpEdit();
            this.cbShesT = new DevExpress.XtraEditors.LookUpEdit();
            this.laValuta = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.laShesT = new DevExpress.XtraEditors.LabelControl();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.laZedd = new DevExpress.XtraEditors.LabelControl();
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.cbProek = new DevExpress.XtraEditors.LookUpEdit();
            this.laProek = new DevExpress.XtraEditors.LabelControl();
            this.laFG = new DevExpress.XtraEditors.LabelControl();
            this.cbCalcType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFG = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIncludeDgg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKursi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbValuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShesT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCalcType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 357);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 42);
            this.panel1.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(684, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(577, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // laFactura
            // 
            this.laFactura.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFactura.Location = new System.Drawing.Point(314, 18);
            this.laFactura.Name = "laFactura";
            this.laFactura.Size = new System.Drawing.Size(63, 19);
            this.laFactura.TabIndex = 91;
            this.laFactura.Text = "ფაქტურა";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(318, 43);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Properties.Appearance.Options.UseFont = true;
            this.txtFactura.Size = new System.Drawing.Size(90, 26);
            this.txtFactura.TabIndex = 2;
            // 
            // chbIncludeDgg
            // 
            this.chbIncludeDgg.Location = new System.Drawing.Point(318, 174);
            this.chbIncludeDgg.Name = "chbIncludeDgg";
            this.chbIncludeDgg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIncludeDgg.Properties.Appearance.Options.UseFont = true;
            this.chbIncludeDgg.Properties.AutoWidth = true;
            this.chbIncludeDgg.Properties.Caption = "ფასები შეიცავს დღგ-ს?";
            this.chbIncludeDgg.Size = new System.Drawing.Size(183, 23);
            this.chbIncludeDgg.TabIndex = 8;
            // 
            // txtKursi
            // 
            this.txtKursi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtKursi.Location = new System.Drawing.Point(161, 110);
            this.txtKursi.Name = "txtKursi";
            this.txtKursi.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKursi.Properties.Appearance.Options.UseFont = true;
            this.txtKursi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtKursi.Properties.DisplayFormat.FormatString = "f4";
            this.txtKursi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKursi.Properties.EditFormat.FormatString = "f4";
            this.txtKursi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKursi.Properties.Mask.EditMask = "f4";
            this.txtKursi.Size = new System.Drawing.Size(117, 26);
            this.txtKursi.TabIndex = 5;
            // 
            // laKursi
            // 
            this.laKursi.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laKursi.Location = new System.Drawing.Point(161, 87);
            this.laKursi.Name = "laKursi";
            this.laKursi.Size = new System.Drawing.Size(44, 19);
            this.laKursi.TabIndex = 85;
            this.laKursi.Text = "კურსი";
            // 
            // cbMomc
            // 
            this.cbMomc.Location = new System.Drawing.Point(443, 43);
            this.cbMomc.Name = "cbMomc";
            this.cbMomc.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMomc.Properties.Appearance.Options.UseFont = true;
            this.cbMomc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMomc.Size = new System.Drawing.Size(319, 26);
            this.cbMomc.TabIndex = 3;
            // 
            // laMomc
            // 
            this.laMomc.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMomc.Location = new System.Drawing.Point(439, 18);
            this.laMomc.Name = "laMomc";
            this.laMomc.Size = new System.Drawing.Size(103, 19);
            this.laMomc.TabIndex = 83;
            this.laMomc.Text = "მომწოდებელი";
            // 
            // cbValuta
            // 
            this.cbValuta.Location = new System.Drawing.Point(14, 110);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValuta.Properties.Appearance.Options.UseFont = true;
            this.cbValuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbValuta.Size = new System.Drawing.Size(122, 26);
            this.cbValuta.TabIndex = 4;
            // 
            // cbShesT
            // 
            this.cbShesT.Location = new System.Drawing.Point(14, 172);
            this.cbShesT.Name = "cbShesT";
            this.cbShesT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShesT.Properties.Appearance.Options.UseFont = true;
            this.cbShesT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbShesT.Size = new System.Drawing.Size(283, 26);
            this.cbShesT.TabIndex = 7;
            // 
            // laValuta
            // 
            this.laValuta.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laValuta.Location = new System.Drawing.Point(14, 87);
            this.laValuta.Name = "laValuta";
            this.laValuta.Size = new System.Drawing.Size(55, 19);
            this.laValuta.TabIndex = 82;
            this.laValuta.Text = "ვალუტა";
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(14, 43);
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
            this.txtData.TabIndex = 0;
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Location = new System.Drawing.Point(14, 204);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(60, 19);
            this.laShen.TabIndex = 81;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(14, 232);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(748, 26);
            this.txtShen.TabIndex = 10;
            // 
            // laShesT
            // 
            this.laShesT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShesT.Location = new System.Drawing.Point(14, 147);
            this.laShesT.Name = "laShesT";
            this.laShesT.Size = new System.Drawing.Size(112, 19);
            this.laShesT.TabIndex = 80;
            this.laShesT.Text = "შესყიდვის ტიპი";
            // 
            // laData
            // 
            this.laData.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laData.Location = new System.Drawing.Point(14, 18);
            this.laData.Name = "laData";
            this.laData.Size = new System.Drawing.Size(57, 19);
            this.laData.TabIndex = 76;
            this.laData.Text = "თარიღი";
            // 
            // laZedd
            // 
            this.laZedd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laZedd.Location = new System.Drawing.Point(161, 18);
            this.laZedd.Name = "laZedd";
            this.laZedd.Size = new System.Drawing.Size(92, 19);
            this.laZedd.TabIndex = 70;
            this.laZedd.Text = "ზედდებული";
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(161, 43);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(139, 26);
            this.txtZedd.TabIndex = 1;
            // 
            // cbProek
            // 
            this.cbProek.Location = new System.Drawing.Point(318, 110);
            this.cbProek.Name = "cbProek";
            this.cbProek.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProek.Properties.Appearance.Options.UseFont = true;
            this.cbProek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek.Size = new System.Drawing.Size(444, 26);
            this.cbProek.TabIndex = 6;
            // 
            // laProek
            // 
            this.laProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProek.Location = new System.Drawing.Point(319, 86);
            this.laProek.Name = "laProek";
            this.laProek.Size = new System.Drawing.Size(60, 19);
            this.laProek.TabIndex = 95;
            this.laProek.Text = "ობიექტი";
            // 
            // laFG
            // 
            this.laFG.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFG.Location = new System.Drawing.Point(14, 294);
            this.laFG.Name = "laFG";
            this.laFG.Size = new System.Drawing.Size(258, 19);
            this.laFG.TabIndex = 93;
            this.laFG.Text = "რომელი ფასთა ჯგუფი გამოვიყენოთ";
            // 
            // cbCalcType
            // 
            this.cbCalcType.Location = new System.Drawing.Point(504, 172);
            this.cbCalcType.Name = "cbCalcType";
            this.cbCalcType.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCalcType.Properties.Appearance.Options.UseFont = true;
            this.cbCalcType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCalcType.Size = new System.Drawing.Size(258, 26);
            this.cbCalcType.TabIndex = 9;
            this.cbCalcType.Visible = false;
            // 
            // txtFG
            // 
            this.txtFG.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtFG.Location = new System.Drawing.Point(324, 292);
            this.txtFG.Name = "txtFG";
            this.txtFG.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFG.Properties.Appearance.Options.UseFont = true;
            this.txtFG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txtFG.Size = new System.Drawing.Size(78, 26);
            this.txtFG.TabIndex = 11;
            // 
            // GenerateShesForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(785, 399);
            this.Controls.Add(this.txtFG);
            this.Controls.Add(this.cbCalcType);
            this.Controls.Add(this.cbProek);
            this.Controls.Add(this.laProek);
            this.Controls.Add(this.laFG);
            this.Controls.Add(this.laFactura);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.chbIncludeDgg);
            this.Controls.Add(this.txtKursi);
            this.Controls.Add(this.laKursi);
            this.Controls.Add(this.cbMomc);
            this.Controls.Add(this.laMomc);
            this.Controls.Add(this.cbValuta);
            this.Controls.Add(this.cbShesT);
            this.Controls.Add(this.laValuta);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laShesT);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.laZedd);
            this.Controls.Add(this.txtZedd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GenerateShesForm";
            this.ShowIcon = false;
            this.Text = "აღწერის შედეგების ჩასმა შესყიდვაში";
            this.Load += new System.EventHandler(this.GenerateShesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIncludeDgg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKursi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbValuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShesT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCalcType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFG.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelControl panel1;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private LabelControl laFactura;
        private TextEdit txtFactura;
        private DevExpress.XtraEditors.CheckEdit chbIncludeDgg;
        private CalcEdit  txtKursi;
        private LabelControl laKursi;
        private DevExpress.XtraEditors.LookUpEdit cbMomc;
        private LabelControl laMomc;
        private DevExpress.XtraEditors.LookUpEdit cbValuta;
        private DevExpress.XtraEditors.LookUpEdit cbShesT;
        private LabelControl laValuta;
        private DateEdit txtData;
        private LabelControl laShen;
        private TextEdit txtShen;
        private LabelControl laShesT;
        private LabelControl laData;
        private LabelControl laZedd;
        private TextEdit txtZedd;
        private DevExpress.XtraEditors.LookUpEdit cbProek;
        private LabelControl laProek;
        private LabelControl laFG;
        private DevExpress.XtraEditors.LookUpEdit cbCalcType;
        private CalcEdit txtFG;
    }
}