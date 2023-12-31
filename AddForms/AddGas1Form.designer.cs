using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddGas1Form
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
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.laZedd = new DevExpress.XtraEditors.LabelControl();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.laProek = new DevExpress.XtraEditors.LabelControl();
            this.laGasT = new DevExpress.XtraEditors.LabelControl();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.cbProek = new DevExpress.XtraEditors.LookUpEdit();
            this.cbGasT = new DevExpress.XtraEditors.LookUpEdit();
            this.cbOrg = new DevExpress.XtraEditors.LookUpEdit();
            this.laGvari = new DevExpress.XtraEditors.LabelControl();
            this.laTotalArea = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalOcupatedArea = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGasT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalOcupatedArea.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(144, 28);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(119, 22);
            this.txtZedd.TabIndex = 1;
            this.txtZedd.Leave += new System.EventHandler(this.txtZedd_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 45);
            this.panel1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(443, 6);
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
            this.btnOK.Location = new System.Drawing.Point(344, 6);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // laZedd
            // 
            this.laZedd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laZedd.Appearance.Options.UseFont = true;
            this.laZedd.Location = new System.Drawing.Point(141, 9);
            this.laZedd.Name = "laZedd";
            this.laZedd.Size = new System.Drawing.Size(84, 16);
            this.laZedd.TabIndex = 7;
            this.laZedd.Text = "ზედდებული";
            // 
            // laData
            // 
            this.laData.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laData.Appearance.Options.UseFont = true;
            this.laData.Location = new System.Drawing.Point(18, 10);
            this.laData.Name = "laData";
            this.laData.Size = new System.Drawing.Size(53, 16);
            this.laData.TabIndex = 13;
            this.laData.Text = "თარიღი";
            // 
            // laProek
            // 
            this.laProek.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laProek.Appearance.Options.UseFont = true;
            this.laProek.Location = new System.Drawing.Point(283, 9);
            this.laProek.Name = "laProek";
            this.laProek.Size = new System.Drawing.Size(53, 16);
            this.laProek.TabIndex = 26;
            this.laProek.Text = "ობიექტი";
            // 
            // laGasT
            // 
            this.laGasT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laGasT.Appearance.Options.UseFont = true;
            this.laGasT.Location = new System.Drawing.Point(18, 65);
            this.laGasT.Name = "laGasT";
            this.laGasT.Size = new System.Drawing.Size(86, 16);
            this.laGasT.TabIndex = 27;
            this.laGasT.Text = "გატანის ტიპი";
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laShen.Appearance.Options.UseFont = true;
            this.laShen.Location = new System.Drawing.Point(18, 164);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(58, 16);
            this.laShen.TabIndex = 29;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(18, 186);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(508, 22);
            this.txtShen.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(18, 30);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtData.Size = new System.Drawing.Size(107, 20);
            this.txtData.TabIndex = 0;
            this.txtData.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // cbProek
            // 
            this.cbProek.Location = new System.Drawing.Point(283, 29);
            this.cbProek.Name = "cbProek";
            this.cbProek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek.Size = new System.Drawing.Size(243, 20);
            this.cbProek.TabIndex = 2;
            // 
            // cbGasT
            // 
            this.cbGasT.Location = new System.Drawing.Point(18, 84);
            this.cbGasT.Name = "cbGasT";
            this.cbGasT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGasT.Size = new System.Drawing.Size(243, 20);
            this.cbGasT.TabIndex = 3;
            // 
            // cbOrg
            // 
            this.cbOrg.Location = new System.Drawing.Point(283, 84);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrg.Properties.Appearance.Options.UseFont = true;
            this.cbOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrg.Size = new System.Drawing.Size(245, 22);
            this.cbOrg.TabIndex = 4;
            // 
            // laGvari
            // 
            this.laGvari.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laGvari.Appearance.Options.UseFont = true;
            this.laGvari.Location = new System.Drawing.Point(283, 66);
            this.laGvari.Name = "laGvari";
            this.laGvari.Size = new System.Drawing.Size(57, 16);
            this.laGvari.TabIndex = 31;
            this.laGvari.Text = "კლიენტი";
            // 
            // laTotalArea
            // 
            this.laTotalArea.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalArea.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTotalArea.Appearance.Options.UseFont = true;
            this.laTotalArea.Appearance.Options.UseForeColor = true;
            this.laTotalArea.Location = new System.Drawing.Point(19, 114);
            this.laTotalArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laTotalArea.Name = "laTotalArea";
            this.laTotalArea.Size = new System.Drawing.Size(147, 16);
            this.laTotalArea.TabIndex = 36;
            this.laTotalArea.Text = "განთავისუფლებული არეა";
            // 
            // txtTotalOcupatedArea
            // 
            this.txtTotalOcupatedArea.EditValue = 0;
            this.txtTotalOcupatedArea.Location = new System.Drawing.Point(19, 137);
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
            this.txtTotalOcupatedArea.TabIndex = 5;
            // 
            // AddGas1Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(538, 270);
            this.Controls.Add(this.laTotalArea);
            this.Controls.Add(this.txtTotalOcupatedArea);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.laGvari);
            this.Controls.Add(this.cbGasT);
            this.Controls.Add(this.cbProek);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laGasT);
            this.Controls.Add(this.laProek);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.laZedd);
            this.Controls.Add(this.txtZedd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddGas1Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddGas1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGasT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalOcupatedArea.Properties)).EndInit();
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
        private LabelControl laGasT;
        private LabelControl laProek;
        private LabelControl laShen;
        private TextEdit txtShen;
        private DateEdit txtData;
        private DevExpress.XtraEditors.LookUpEdit cbProek;
        private DevExpress.XtraEditors.LookUpEdit cbGasT;
        private LookUpEdit cbOrg;
        private LabelControl laGvari;
        private LabelControl laTotalArea;
        private CalcEdit txtTotalOcupatedArea;
    }
}