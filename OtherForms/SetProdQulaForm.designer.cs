using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class SetProdQulaForm
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.chbDamrgvaleba = new DevExpress.XtraEditors.CheckEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTanxa = new DevExpress.XtraEditors.CalcEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPercent = new DevExpress.XtraEditors.CalcEdit();
            this.txtFasi2 = new DevExpress.XtraEditors.SpinEdit();
            this.txtDabrgvalebaCifri = new DevExpress.XtraEditors.SpinEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.fmgProdG = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdS = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.chbDamrgvaleba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDabrgvalebaCifri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(259, 171);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(169, 171);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chbDamrgvaleba
            // 
            this.chbDamrgvaleba.Location = new System.Drawing.Point(417, 16);
            this.chbDamrgvaleba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDamrgvaleba.Name = "chbDamrgvaleba";
            this.chbDamrgvaleba.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDamrgvaleba.Properties.Appearance.Options.UseFont = true;
            this.chbDamrgvaleba.Properties.AutoWidth = true;
            this.chbDamrgvaleba.Properties.Caption = "დამრგვალება";
            this.chbDamrgvaleba.Size = new System.Drawing.Size(97, 20);
            this.chbDamrgvaleba.TabIndex = 4;
            this.chbDamrgvaleba.CheckedChanged += new System.EventHandler(this.chbDamrgvaleba_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = ") *";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            // 
            // txtTanxa
            // 
            this.txtTanxa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTanxa.Location = new System.Drawing.Point(236, 15);
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
            this.txtTanxa.Size = new System.Drawing.Size(73, 22);
            this.txtTanxa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = " = ( ფასი";
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ქულა";
            // 
            // txtPercent
            // 
            this.txtPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPercent.Location = new System.Drawing.Point(337, 15);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Properties.Appearance.Options.UseFont = true;
            this.txtPercent.Properties.DisplayFormat.FormatString = "p2";
            this.txtPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPercent.Properties.EditFormat.FormatString = "p2";
            this.txtPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPercent.Properties.Mask.EditMask = "p2";
            this.txtPercent.Properties.NullText = "0.00%";
            this.txtPercent.Size = new System.Drawing.Size(73, 22);
            this.txtPercent.TabIndex = 3;
            // 
            // txtFasi2
            // 
            this.txtFasi2.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFasi2.Location = new System.Drawing.Point(164, 15);
            this.txtFasi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFasi2.Name = "txtFasi2";
            this.txtFasi2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFasi2.Properties.Appearance.Options.UseFont = true;
            this.txtFasi2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFasi2.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtFasi2.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFasi2.Size = new System.Drawing.Size(51, 22);
            this.txtFasi2.TabIndex = 1;
            // 
            // txtDabrgvalebaCifri
            // 
            this.txtDabrgvalebaCifri.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDabrgvalebaCifri.Location = new System.Drawing.Point(523, 15);
            this.txtDabrgvalebaCifri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDabrgvalebaCifri.Name = "txtDabrgvalebaCifri";
            this.txtDabrgvalebaCifri.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDabrgvalebaCifri.Properties.Appearance.Options.UseFont = true;
            this.txtDabrgvalebaCifri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDabrgvalebaCifri.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtDabrgvalebaCifri.Properties.MinValue = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.txtDabrgvalebaCifri.Size = new System.Drawing.Size(54, 22);
            this.txtDabrgvalebaCifri.TabIndex = 5;
            this.txtDabrgvalebaCifri.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fmgProdG);
            this.panel1.Controls.Add(this.fmgProdS);
            this.panel1.Controls.Add(this.txtTanxa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fmgProdT);
            this.panel1.Controls.Add(this.chbDamrgvaleba);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFasi2);
            this.panel1.Controls.Add(this.txtPercent);
            this.panel1.Controls.Add(this.txtDabrgvalebaCifri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 165);
            this.panel1.TabIndex = 127;
            // 
            // fmgProdG
            // 
            this.fmgProdG.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdG.Appearance.Options.UseFont = true;
            this.fmgProdG.FieldName = "ProdG";
            this.fmgProdG.Location = new System.Drawing.Point(6, 112);
            this.fmgProdG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdG.MinimumSize = new System.Drawing.Size(330, 19);
            this.fmgProdG.Name = "fmgProdG";
            this.fmgProdG.ParameterName = null;
            this.fmgProdG.Size = new System.Drawing.Size(571, 24);
            this.fmgProdG.TabIndex = 8;
            this.fmgProdG.Text = "პროდ.ჯგუფი";
            // 
            // fmgProdS
            // 
            this.fmgProdS.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdS.Appearance.Options.UseFont = true;
            this.fmgProdS.FieldName = "ProdS";
            this.fmgProdS.Location = new System.Drawing.Point(6, 80);
            this.fmgProdS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdS.MinimumSize = new System.Drawing.Size(330, 19);
            this.fmgProdS.Name = "fmgProdS";
            this.fmgProdS.ParameterName = null;
            this.fmgProdS.Size = new System.Drawing.Size(571, 24);
            this.fmgProdS.TabIndex = 7;
            this.fmgProdS.Text = "პროდ.სახეობა";
            // 
            // fmgProdT
            // 
            this.fmgProdT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdT.Appearance.Options.UseFont = true;
            this.fmgProdT.FieldName = "ProdT";
            this.fmgProdT.Location = new System.Drawing.Point(6, 47);
            this.fmgProdT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fmgProdT.MinimumSize = new System.Drawing.Size(330, 19);
            this.fmgProdT.Name = "fmgProdT";
            this.fmgProdT.ParameterName = null;
            this.fmgProdT.Size = new System.Drawing.Size(571, 24);
            this.fmgProdT.TabIndex = 6;
            this.fmgProdT.Text = "პროდ.ტიპი";
            // 
            // SetProdQulaForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(609, 207);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SetProdQulaForm";
            this.Text = "ფასების ავტომატური ფორმირება";
            this.Load += new System.EventHandler(this.SetProdFasiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chbDamrgvaleba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDabrgvalebaCifri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckEdit chbDamrgvaleba;
        private LabelControl label4;
        private LabelControl label3;
        private CalcEdit  txtTanxa;
        private LabelControl label2;
        private LabelControl label1;
        private CalcEdit txtPercent;
        private SpinEdit txtFasi2;
        private SpinEdit txtDabrgvalebaCifri;
        private Controls.FMGComboFilterControl fmgProdT;
        private Controls.FMGComboFilterControl fmgProdS;
        private PanelControl panel1;
        private Controls.FMGComboFilterControl fmgProdG;
    }
}