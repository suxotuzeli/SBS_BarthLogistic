using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class GenerateRealForm
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
            this.label14 = new DevExpress.XtraEditors.LabelControl();
            this.chbTransGamkidveli = new DevExpress.XtraEditors.CheckEdit();
            this.txtTransTypesName = new DevExpress.XtraEditors.TextEdit();
            this.cbTransTypes = new DevExpress.XtraEditors.LookUpEdit();
            this.laTransTypes = new DevExpress.XtraEditors.LabelControl();
            this.chbIsTransportireba = new DevExpress.XtraEditors.CheckEdit();
            this.label13 = new DevExpress.XtraEditors.LabelControl();
            this.txtMdzNom = new DevExpress.XtraEditors.TextEdit();
            this.txtTransTanxa = new DevExpress.XtraEditors.CalcEdit();
            this.label12 = new DevExpress.XtraEditors.LabelControl();
            this.txtActivateData = new DevExpress.XtraEditors.DateEdit();
            this.txtDataFactura = new DevExpress.XtraEditors.DateEdit();
            this.label15 = new DevExpress.XtraEditors.LabelControl();
            this.label11 = new DevExpress.XtraEditors.LabelControl();
            this.label10 = new DevExpress.XtraEditors.LabelControl();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.cbMdz = new DevExpress.XtraEditors.LookUpEdit();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.laName = new DevExpress.XtraEditors.LabelControl();
            this.cbRealT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtFG = new DevExpress.XtraEditors.CalcEdit();
            this.txtIdGvari = new SBS_BarthLogistic.Controls.GvariSelect();
            this.laIdGvari = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbTransGamkidveli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTypesName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsTransportireba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMdzNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTanxa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivateData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivateData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFactura.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMdz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRealT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 34);
            this.panel1.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(473, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(380, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label14
            // 
            this.label14.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 350);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "რომელი ფასთა ჯგუფი გამოვიყენოთ";
            // 
            // chbTransGamkidveli
            // 
            this.chbTransGamkidveli.EditValue = true;
            this.chbTransGamkidveli.Location = new System.Drawing.Point(150, 253);
            this.chbTransGamkidveli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbTransGamkidveli.Name = "chbTransGamkidveli";
            this.chbTransGamkidveli.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTransGamkidveli.Properties.Appearance.Options.UseFont = true;
            this.chbTransGamkidveli.Properties.AutoWidth = true;
            this.chbTransGamkidveli.Properties.Caption = "გამყიდველი?";
            this.chbTransGamkidveli.Size = new System.Drawing.Size(97, 20);
            this.chbTransGamkidveli.TabIndex = 11;
            // 
            // txtTransTypesName
            // 
            this.txtTransTypesName.Location = new System.Drawing.Point(397, 251);
            this.txtTransTypesName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTransTypesName.Name = "txtTransTypesName";
            this.txtTransTypesName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransTypesName.Properties.Appearance.Options.UseFont = true;
            this.txtTransTypesName.Size = new System.Drawing.Size(117, 22);
            this.txtTransTypesName.TabIndex = 13;
            // 
            // cbTransTypes
            // 
            this.cbTransTypes.Location = new System.Drawing.Point(271, 251);
            this.cbTransTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTransTypes.Name = "cbTransTypes";
            this.cbTransTypes.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTransTypes.Properties.Appearance.Options.UseFont = true;
            this.cbTransTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTransTypes.Size = new System.Drawing.Size(119, 22);
            this.cbTransTypes.TabIndex = 12;
            // 
            // laTransTypes
            // 
            this.laTransTypes.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTransTypes.Location = new System.Drawing.Point(317, 232);
            this.laTransTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laTransTypes.Name = "laTransTypes";
            this.laTransTypes.Size = new System.Drawing.Size(141, 16);
            this.laTransTypes.TabIndex = 10;
            this.laTransTypes.Text = "ტრანსპორტირების ტიპი";
            // 
            // chbIsTransportireba
            // 
            this.chbIsTransportireba.EditValue = true;
            this.chbIsTransportireba.Location = new System.Drawing.Point(12, 253);
            this.chbIsTransportireba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbIsTransportireba.Name = "chbIsTransportireba";
            this.chbIsTransportireba.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsTransportireba.Properties.Appearance.Options.UseFont = true;
            this.chbIsTransportireba.Properties.AutoWidth = true;
            this.chbIsTransportireba.Properties.Caption = "ტრანსპორტირება";
            this.chbIsTransportireba.Size = new System.Drawing.Size(123, 20);
            this.chbIsTransportireba.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(150, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "მანქანის #";
            // 
            // txtMdzNom
            // 
            this.txtMdzNom.Location = new System.Drawing.Point(150, 213);
            this.txtMdzNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMdzNom.Name = "txtMdzNom";
            this.txtMdzNom.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdzNom.Properties.Appearance.Options.UseFont = true;
            this.txtMdzNom.Size = new System.Drawing.Size(118, 22);
            this.txtMdzNom.TabIndex = 9;
            // 
            // txtTransTanxa
            // 
            this.txtTransTanxa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTransTanxa.Location = new System.Drawing.Point(12, 214);
            this.txtTransTanxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTransTanxa.Name = "txtTransTanxa";
            this.txtTransTanxa.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransTanxa.Properties.Appearance.Options.UseFont = true;
            this.txtTransTanxa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtTransTanxa.Properties.DisplayFormat.FormatString = "f2";
            this.txtTransTanxa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTransTanxa.Properties.EditFormat.FormatString = "f2";
            this.txtTransTanxa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTransTanxa.Properties.Mask.EditMask = "f2";
            this.txtTransTanxa.Size = new System.Drawing.Size(100, 22);
            this.txtTransTanxa.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "ტრანს. თანხა";
            // 
            // txtActivateData
            // 
            this.txtActivateData.EditValue = "1.1.2010";
            this.txtActivateData.Location = new System.Drawing.Point(405, 155);
            this.txtActivateData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtActivateData.Name = "txtActivateData";
            this.txtActivateData.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivateData.Properties.Appearance.Options.UseFont = true;
            this.txtActivateData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtActivateData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtActivateData.Properties.DisplayFormat.FormatString = "d.M.yyyy H:mm";
            this.txtActivateData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtActivateData.Properties.Mask.EditMask = "d.M.yyyy H:mm";
            this.txtActivateData.Size = new System.Drawing.Size(124, 22);
            this.txtActivateData.TabIndex = 7;
            // 
            // txtDataFactura
            // 
            this.txtDataFactura.EditValue = new System.DateTime(2015, 10, 10, 0, 0, 0, 0);
            this.txtDataFactura.Location = new System.Drawing.Point(150, 155);
            this.txtDataFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataFactura.Name = "txtDataFactura";
            this.txtDataFactura.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFactura.Properties.Appearance.Options.UseFont = true;
            this.txtDataFactura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFactura.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataFactura.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtDataFactura.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDataFactura.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtDataFactura.Size = new System.Drawing.Size(107, 22);
            this.txtDataFactura.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(402, 136);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 7;
            this.label15.Text = "აქტივაციის დრო";
            // 
            // label11
            // 
            this.label11.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 136);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "ფაქტურის თარიღი";
            // 
            // label10
            // 
            this.label10.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "ფაქტურა";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(12, 155);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Properties.Appearance.Options.UseFont = true;
            this.txtFactura.Size = new System.Drawing.Size(119, 22);
            this.txtFactura.TabIndex = 4;
            // 
            // cbMdz
            // 
            this.cbMdz.Location = new System.Drawing.Point(12, 100);
            this.cbMdz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMdz.Name = "cbMdz";
            this.cbMdz.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMdz.Properties.Appearance.Options.UseFont = true;
            this.cbMdz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMdz.Size = new System.Drawing.Size(381, 22);
            this.cbMdz.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "მძღოლი";
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(271, 155);
            this.txtZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(119, 22);
            this.txtZedd.TabIndex = 6;
            // 
            // laName
            // 
            this.laName.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laName.Location = new System.Drawing.Point(271, 136);
            this.laName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(74, 16);
            this.laName.TabIndex = 6;
            this.laName.Text = "ზედდებული";
            // 
            // cbRealT
            // 
            this.cbRealT.Location = new System.Drawing.Point(306, 25);
            this.cbRealT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRealT.Name = "cbRealT";
            this.cbRealT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRealT.Properties.Appearance.Options.UseFont = true;
            this.cbRealT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRealT.Size = new System.Drawing.Size(247, 22);
            this.cbRealT.TabIndex = 2;
            this.cbRealT.Enter += new System.EventHandler(this.cbRealT_Enter);
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(12, 25);
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
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "რეალიზაციის ტიპი";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "თარიღი";
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Location = new System.Drawing.Point(12, 294);
            this.laShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(48, 16);
            this.laShen.TabIndex = 11;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(12, 313);
            this.txtShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(508, 22);
            this.txtShen.TabIndex = 14;
            // 
            // txtFG
            // 
            this.txtFG.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFG.Location = new System.Drawing.Point(271, 347);
            this.txtFG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFG.Name = "txtFG";
            this.txtFG.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFG.Properties.Appearance.Options.UseFont = true;
            this.txtFG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txtFG.Size = new System.Drawing.Size(67, 22);
            this.txtFG.TabIndex = 16;
            // 
            // txtIdGvari
            // 
            this.txtIdGvari.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGvari.Appearance.Options.UseFont = true;
            this.txtIdGvari.CustomLabel = null;
            this.txtIdGvari.Filter = null;
            this.txtIdGvari.Id = null;
            this.txtIdGvari.Label = "";
            this.txtIdGvari.Location = new System.Drawing.Point(138, 28);
            this.txtIdGvari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdGvari.Name = "txtIdGvari";
            this.txtIdGvari.Size = new System.Drawing.Size(162, 52);
            this.txtIdGvari.TabIndex = 1;
            // 
            // laIdGvari
            // 
            this.laIdGvari.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIdGvari.Location = new System.Drawing.Point(138, 6);
            this.laIdGvari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laIdGvari.Name = "laIdGvari";
            this.laIdGvari.Size = new System.Drawing.Size(72, 16);
            this.laIdGvari.TabIndex = 1;
            this.laIdGvari.Text = "მყიდვ. კოდი";
            // 
            // GenerateRealForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.laIdGvari);
            this.Controls.Add(this.txtIdGvari);
            this.Controls.Add(this.txtFG);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.chbTransGamkidveli);
            this.Controls.Add(this.txtTransTypesName);
            this.Controls.Add(this.cbTransTypes);
            this.Controls.Add(this.laTransTypes);
            this.Controls.Add(this.chbIsTransportireba);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMdzNom);
            this.Controls.Add(this.txtTransTanxa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtActivateData);
            this.Controls.Add(this.txtDataFactura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.cbMdz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtZedd);
            this.Controls.Add(this.laName);
            this.Controls.Add(this.cbRealT);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Name = "GenerateRealForm";
            this.ShowIcon = false;
            this.Text = "აღწერის შედეგების ჩასმა რეალიზაციაში";
            this.Load += new System.EventHandler(this.GenerateRealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbTransGamkidveli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTypesName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIsTransportireba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMdzNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransTanxa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivateData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActivateData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFactura.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMdz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRealT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFG.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelControl panel1;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private LabelControl label14;
        private DevExpress.XtraEditors.CheckEdit chbTransGamkidveli;
        private TextEdit txtTransTypesName;
        private DevExpress.XtraEditors.LookUpEdit cbTransTypes;
        private LabelControl laTransTypes;
        private DevExpress.XtraEditors.CheckEdit chbIsTransportireba;
        private LabelControl label13;
        private TextEdit txtMdzNom;
        private CalcEdit  txtTransTanxa;
        private LabelControl label12;
        private DateEdit txtActivateData;
        private DateEdit txtDataFactura;
        private LabelControl label15;
        private LabelControl label11;
        private LabelControl label10;
        private TextEdit txtFactura;
        private DevExpress.XtraEditors.LookUpEdit cbMdz;
        private LabelControl label9;
        private TextEdit txtZedd;
        private LabelControl laName;
        private DevExpress.XtraEditors.LookUpEdit cbRealT;
        private DateEdit txtData;
        private LabelControl label5;
        private LabelControl label3;
        private LabelControl laShen;
        private TextEdit txtShen;
        private CalcEdit txtFG;
        private Controls.GvariSelect txtIdGvari;
        private LabelControl laIdGvari;
    }
}