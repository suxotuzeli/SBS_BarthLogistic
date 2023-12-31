using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddShem1Form
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
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laZedd = new DevExpress.XtraEditors.LabelControl();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.laProek = new DevExpress.XtraEditors.LabelControl();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.cbProek = new DevExpress.XtraEditors.LookUpEdit();
            this.laOrg = new DevExpress.XtraEditors.LabelControl();
            this.laTotalOcupatedArea = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalOcupatedArea = new DevExpress.XtraEditors.CalcEdit();
            this.cbShemT = new DevExpress.XtraEditors.LookUpEdit();
            this.laShemT = new DevExpress.XtraEditors.LabelControl();
            this.cbOrg = new DevExpress.XtraEditors.LookUpEdit();
            this.txtKeepengData1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKeepengData2 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalOcupatedArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShemT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(438, 4);
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
            this.btnOK.Location = new System.Drawing.Point(347, 4);
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
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(144, 30);
            this.txtZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(113, 22);
            this.txtZedd.TabIndex = 1;
            this.txtZedd.Leave += new System.EventHandler(this.txtZedd_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 39);
            this.panel1.TabIndex = 9;
            // 
            // laZedd
            // 
            this.laZedd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laZedd.Appearance.Options.UseFont = true;
            this.laZedd.Location = new System.Drawing.Point(141, 10);
            this.laZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laZedd.Name = "laZedd";
            this.laZedd.Size = new System.Drawing.Size(74, 16);
            this.laZedd.TabIndex = 7;
            this.laZedd.Text = "ზედდებული";
            // 
            // laData
            // 
            this.laData.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laData.Appearance.Options.UseFont = true;
            this.laData.Location = new System.Drawing.Point(15, 10);
            this.laData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laData.Name = "laData";
            this.laData.Size = new System.Drawing.Size(47, 16);
            this.laData.TabIndex = 13;
            this.laData.Text = "თარიღი";
            // 
            // laProek
            // 
            this.laProek.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProek.Appearance.Options.UseFont = true;
            this.laProek.Location = new System.Drawing.Point(279, 10);
            this.laProek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProek.Name = "laProek";
            this.laProek.Size = new System.Drawing.Size(49, 16);
            this.laProek.TabIndex = 26;
            this.laProek.Text = "ობიექტი";
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Appearance.Options.UseFont = true;
            this.laShen.Location = new System.Drawing.Point(15, 219);
            this.laShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(48, 16);
            this.laShen.TabIndex = 29;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(15, 240);
            this.txtShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(507, 22);
            this.txtShen.TabIndex = 8;
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(15, 30);
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
            this.txtData.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // cbProek
            // 
            this.cbProek.Location = new System.Drawing.Point(279, 30);
            this.cbProek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProek.Name = "cbProek";
            this.cbProek.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProek.Properties.Appearance.Options.UseFont = true;
            this.cbProek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek.Size = new System.Drawing.Size(244, 22);
            this.cbProek.TabIndex = 2;
            // 
            // laOrg
            // 
            this.laOrg.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laOrg.Appearance.Options.UseFont = true;
            this.laOrg.Location = new System.Drawing.Point(279, 60);
            this.laOrg.Name = "laOrg";
            this.laOrg.Size = new System.Drawing.Size(57, 16);
            this.laOrg.TabIndex = 32;
            this.laOrg.Text = "კლიენტი";
            // 
            // laTotalOcupatedArea
            // 
            this.laTotalOcupatedArea.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalOcupatedArea.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTotalOcupatedArea.Appearance.Options.UseFont = true;
            this.laTotalOcupatedArea.Appearance.Options.UseForeColor = true;
            this.laTotalOcupatedArea.Location = new System.Drawing.Point(241, 126);
            this.laTotalOcupatedArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laTotalOcupatedArea.Name = "laTotalOcupatedArea";
            this.laTotalOcupatedArea.Size = new System.Drawing.Size(98, 16);
            this.laTotalOcupatedArea.TabIndex = 34;
            this.laTotalOcupatedArea.Text = "დაკავებული არეა";
            // 
            // txtTotalOcupatedArea
            // 
            this.txtTotalOcupatedArea.EditValue = 0;
            this.txtTotalOcupatedArea.Location = new System.Drawing.Point(241, 149);
            this.txtTotalOcupatedArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalOcupatedArea.Name = "txtTotalOcupatedArea";
            this.txtTotalOcupatedArea.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOcupatedArea.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit;
            this.txtTotalOcupatedArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtTotalOcupatedArea.Properties.DisplayFormat.FormatString = "f4";
            this.txtTotalOcupatedArea.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalOcupatedArea.Properties.EditFormat.FormatString = "f4";
            this.txtTotalOcupatedArea.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalOcupatedArea.Properties.Mask.EditMask = "f4";
            this.txtTotalOcupatedArea.Properties.NullText = "0.00";
            this.txtTotalOcupatedArea.Size = new System.Drawing.Size(85, 22);
            this.txtTotalOcupatedArea.TabIndex = 7;
            // 
            // cbShemT
            // 
            this.cbShemT.Location = new System.Drawing.Point(15, 84);
            this.cbShemT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShemT.Name = "cbShemT";
            this.cbShemT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShemT.Properties.Appearance.Options.UseFont = true;
            this.cbShemT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbShemT.Size = new System.Drawing.Size(243, 22);
            this.cbShemT.TabIndex = 3;
            // 
            // laShemT
            // 
            this.laShemT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShemT.Appearance.Options.UseFont = true;
            this.laShemT.Location = new System.Drawing.Point(15, 63);
            this.laShemT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laShemT.Name = "laShemT";
            this.laShemT.Size = new System.Drawing.Size(92, 16);
            this.laShemT.TabIndex = 27;
            this.laShemT.Text = "შემოტანის ტიპი";
            // 
            // cbOrg
            // 
            this.cbOrg.Location = new System.Drawing.Point(278, 84);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrg.Properties.Appearance.Options.UseFont = true;
            this.cbOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrg.Size = new System.Drawing.Size(245, 22);
            this.cbOrg.TabIndex = 4;
            // 
            // txtKeepengData1
            // 
            this.txtKeepengData1.EditValue = "1.1.2010";
            this.txtKeepengData1.Location = new System.Drawing.Point(15, 149);
            this.txtKeepengData1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeepengData1.Name = "txtKeepengData1";
            this.txtKeepengData1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeepengData1.Properties.Appearance.Options.UseFont = true;
            this.txtKeepengData1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKeepengData1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKeepengData1.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtKeepengData1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtKeepengData1.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtKeepengData1.Size = new System.Drawing.Size(107, 22);
            this.txtKeepengData1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(52, 126);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 16);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "დასაწყობების პერიოდი";
            // 
            // txtKeepengData2
            // 
            this.txtKeepengData2.EditValue = "1.1.2010";
            this.txtKeepengData2.Location = new System.Drawing.Point(128, 149);
            this.txtKeepengData2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeepengData2.Name = "txtKeepengData2";
            this.txtKeepengData2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeepengData2.Properties.Appearance.Options.UseFont = true;
            this.txtKeepengData2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKeepengData2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKeepengData2.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtKeepengData2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtKeepengData2.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtKeepengData2.Size = new System.Drawing.Size(107, 22);
            this.txtKeepengData2.TabIndex = 6;
            // 
            // AddShem1Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(538, 309);
            this.Controls.Add(this.txtKeepengData2);
            this.Controls.Add(this.txtKeepengData1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.laTotalOcupatedArea);
            this.Controls.Add(this.txtTotalOcupatedArea);
            this.Controls.Add(this.laOrg);
            this.Controls.Add(this.cbShemT);
            this.Controls.Add(this.cbProek);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laShemT);
            this.Controls.Add(this.laProek);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.laZedd);
            this.Controls.Add(this.txtZedd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddShem1Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddShem1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalOcupatedArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShemT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeepengData2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private TextEdit txtZedd;
        private PanelControl panel1;
        private LabelControl laZedd;
        private LabelControl laData;
        private LabelControl laProek;
        private LabelControl laShen;
        private TextEdit txtShen;
        private DateEdit txtData;
        private DevExpress.XtraEditors.LookUpEdit cbProek;
        private LabelControl laOrg;
        private LabelControl laTotalOcupatedArea;
        private CalcEdit txtTotalOcupatedArea;
        private LookUpEdit cbShemT;
        private LabelControl laShemT;
        private LookUpEdit cbOrg;
        private DateEdit txtKeepengData1;
        private LabelControl labelControl1;
        private DateEdit txtKeepengData2;
    }
}