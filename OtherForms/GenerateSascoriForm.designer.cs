using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class GenerateSascoriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateSascoriForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtErt = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.laPath = new DevExpress.XtraEditors.LabelControl();
            this.laFg = new DevExpress.XtraEditors.LabelControl();
            this.txtFG = new DevExpress.XtraEditors.CalcEdit();
            this.laSascori = new DevExpress.XtraEditors.LabelControl();
            this.cbSascoriModel = new DevExpress.XtraEditors.LookUpEdit();
            this.fmgProdS = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtErt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSascoriModel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_InValid_16x16;
            this.btnCancel.Location = new System.Drawing.Point(251, 216);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::SBS_BarthLogistic.Properties.Resources.AED_IsValid_16x16;
            this.btnOK.Location = new System.Drawing.Point(146, 216);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "ერთეული";
            // 
            // txtErt
            // 
            this.txtErt.EditValue = "კგ";
            this.txtErt.Location = new System.Drawing.Point(12, 97);
            this.txtErt.Name = "txtErt";
            this.txtErt.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtErt.Properties.Appearance.Options.UseFont = true;
            this.txtErt.Size = new System.Drawing.Size(119, 22);
            this.txtErt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.laPath);
            this.panel1.Controls.Add(this.laFg);
            this.panel1.Controls.Add(this.txtFG);
            this.panel1.Controls.Add(this.laSascori);
            this.panel1.Controls.Add(this.cbSascoriModel);
            this.panel1.Controls.Add(this.fmgProdS);
            this.panel1.Controls.Add(this.txtErt);
            this.panel1.Controls.Add(this.fmgProdT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 212);
            this.panel1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(445, 36);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 20);
            this.btnBrowse.TabIndex = 214;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPath.Properties.Appearance.Options.UseFont = true;
            this.txtPath.Size = new System.Drawing.Size(428, 22);
            this.txtPath.TabIndex = 212;
            this.txtPath.EditValueChanged += new System.EventHandler(this.txtPath_EditValueChanged);
            // 
            // laPath
            // 
            this.laPath.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPath.Location = new System.Drawing.Point(12, 12);
            this.laPath.Name = "laPath";
            this.laPath.Size = new System.Drawing.Size(109, 16);
            this.laPath.TabIndex = 213;
            this.laPath.Text = "ფაილის მისამართი";
            // 
            // laFg
            // 
            this.laFg.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laFg.Location = new System.Drawing.Point(392, 76);
            this.laFg.Name = "laFg";
            this.laFg.Size = new System.Drawing.Size(78, 16);
            this.laFg.TabIndex = 211;
            this.laFg.Text = "ფასთა ჯგუფი";
            // 
            // txtFG
            // 
            this.txtFG.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFG.Location = new System.Drawing.Point(392, 97);
            this.txtFG.Name = "txtFG";
            this.txtFG.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtFG.Properties.Appearance.Options.UseFont = true;
            this.txtFG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtFG.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFG.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFG.Properties.NullText = "0";
            this.txtFG.Size = new System.Drawing.Size(70, 22);
            this.txtFG.TabIndex = 2;
            // 
            // laSascori
            // 
            this.laSascori.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laSascori.Location = new System.Drawing.Point(189, 75);
            this.laSascori.Name = "laSascori";
            this.laSascori.Size = new System.Drawing.Size(42, 16);
            this.laSascori.TabIndex = 209;
            this.laSascori.Text = "საწორი";
            // 
            // cbSascoriModel
            // 
            this.cbSascoriModel.Location = new System.Drawing.Point(189, 97);
            this.cbSascoriModel.Name = "cbSascoriModel";
            this.cbSascoriModel.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.cbSascoriModel.Properties.Appearance.Options.UseFont = true;
            this.cbSascoriModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSascoriModel.Size = new System.Drawing.Size(160, 22);
            this.cbSascoriModel.TabIndex = 1;
            // 
            // fmgProdS
            // 
            this.fmgProdS.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdS.Appearance.Options.UseFont = true;
            this.fmgProdS.FieldName = "ProdS";
            this.fmgProdS.Location = new System.Drawing.Point(5, 172);
            this.fmgProdS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdS.MinimumSize = new System.Drawing.Size(330, 19);
            this.fmgProdS.Name = "fmgProdS";
            this.fmgProdS.ParameterName = null;
            this.fmgProdS.Size = new System.Drawing.Size(458, 24);
            this.fmgProdS.TabIndex = 4;
            this.fmgProdS.Text = "პროდ.სახეობა";
            // 
            // fmgProdT
            // 
            this.fmgProdT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdT.Appearance.Options.UseFont = true;
            this.fmgProdT.FieldName = "ProdT";
            this.fmgProdT.Location = new System.Drawing.Point(5, 140);
            this.fmgProdT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdT.MinimumSize = new System.Drawing.Size(330, 19);
            this.fmgProdT.Name = "fmgProdT";
            this.fmgProdT.ParameterName = null;
            this.fmgProdT.Size = new System.Drawing.Size(458, 24);
            this.fmgProdT.TabIndex = 3;
            this.fmgProdT.Text = "პროდ.ტიპი";
            // 
            // GenerateSascoriForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(501, 259);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateSascoriForm";
            this.ShowIcon = false;
            this.Text = "სასწორის ფაილის გენერირება";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateSascoriForm_FormClosing);
            this.Load += new System.EventHandler(this.GenerateSascoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtErt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSascoriModel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private LabelControl label1;
        private TextEdit txtErt;
        private PanelControl panel1;
        private Controls.FMGComboFilterControl fmgProdS;
        private Controls.FMGComboFilterControl fmgProdT;
        private LookUpEdit cbSascoriModel;
        private LabelControl laSascori;
        private LabelControl laFg;
        private CalcEdit txtFG;
        private SimpleButton btnBrowse;
        private TextEdit txtPath;
        private LabelControl laPath;
    }
}