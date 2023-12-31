using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddModz1Form
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laZedd = new DevExpress.XtraEditors.LabelControl();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.laProek1 = new DevExpress.XtraEditors.LabelControl();
            this.laModzT = new DevExpress.XtraEditors.LabelControl();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.cbProek1 = new DevExpress.XtraEditors.LookUpEdit();
            this.cbModzT = new DevExpress.XtraEditors.LookUpEdit();
            this.cbProek2 = new DevExpress.XtraEditors.LookUpEdit();
            this.laProek2 = new DevExpress.XtraEditors.LabelControl();
            this.cbOrg = new DevExpress.XtraEditors.LookUpEdit();
            this.laGvari = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModzT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(442, 4);
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
            this.btnOK.Location = new System.Drawing.Point(354, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(132, 30);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(118, 22);
            this.txtZedd.TabIndex = 1;
            this.txtZedd.Leave += new System.EventHandler(this.txtZedd_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 39);
            this.panel1.TabIndex = 7;
            // 
            // laZedd
            // 
            this.laZedd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laZedd.Appearance.Options.UseFont = true;
            this.laZedd.Location = new System.Drawing.Point(132, 8);
            this.laZedd.Name = "laZedd";
            this.laZedd.Size = new System.Drawing.Size(74, 16);
            this.laZedd.TabIndex = 7;
            this.laZedd.Text = "ზედდებული";
            // 
            // laData
            // 
            this.laData.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laData.Appearance.Options.UseFont = true;
            this.laData.Location = new System.Drawing.Point(18, 10);
            this.laData.Name = "laData";
            this.laData.Size = new System.Drawing.Size(47, 16);
            this.laData.TabIndex = 13;
            this.laData.Text = "თარიღი";
            // 
            // laProek1
            // 
            this.laProek1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laProek1.Appearance.Options.UseFont = true;
            this.laProek1.Location = new System.Drawing.Point(18, 68);
            this.laProek1.Name = "laProek1";
            this.laProek1.Size = new System.Drawing.Size(112, 16);
            this.laProek1.TabIndex = 26;
            this.laProek1.Text = "ობიექტიდან გავიდა";
            // 
            // laModzT
            // 
            this.laModzT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laModzT.Appearance.Options.UseFont = true;
            this.laModzT.Location = new System.Drawing.Point(282, 10);
            this.laModzT.Name = "laModzT";
            this.laModzT.Size = new System.Drawing.Size(95, 16);
            this.laModzT.TabIndex = 27;
            this.laModzT.Text = "მოძრაობის ტიპი";
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laShen.Appearance.Options.UseFont = true;
            this.laShen.Location = new System.Drawing.Point(20, 176);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(48, 16);
            this.laShen.TabIndex = 29;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(19, 198);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(508, 22);
            this.txtShen.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(18, 30);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
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
            // cbProek1
            // 
            this.cbProek1.Location = new System.Drawing.Point(18, 93);
            this.cbProek1.Name = "cbProek1";
            this.cbProek1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.cbProek1.Properties.Appearance.Options.UseFont = true;
            this.cbProek1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek1.Size = new System.Drawing.Size(243, 22);
            this.cbProek1.TabIndex = 3;
            // 
            // cbModzT
            // 
            this.cbModzT.Location = new System.Drawing.Point(282, 30);
            this.cbModzT.Name = "cbModzT";
            this.cbModzT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.cbModzT.Properties.Appearance.Options.UseFont = true;
            this.cbModzT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbModzT.Size = new System.Drawing.Size(244, 22);
            this.cbModzT.TabIndex = 2;
            // 
            // cbProek2
            // 
            this.cbProek2.Location = new System.Drawing.Point(282, 93);
            this.cbProek2.Name = "cbProek2";
            this.cbProek2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.cbProek2.Properties.Appearance.Options.UseFont = true;
            this.cbProek2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek2.Size = new System.Drawing.Size(244, 22);
            this.cbProek2.TabIndex = 4;
            // 
            // laProek2
            // 
            this.laProek2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laProek2.Appearance.Options.UseFont = true;
            this.laProek2.Location = new System.Drawing.Point(282, 69);
            this.laProek2.Name = "laProek2";
            this.laProek2.Size = new System.Drawing.Size(98, 16);
            this.laProek2.TabIndex = 31;
            this.laProek2.Text = "ობიექტში შევიდა";
            // 
            // cbOrg
            // 
            this.cbOrg.Location = new System.Drawing.Point(20, 149);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrg.Properties.Appearance.Options.UseFont = true;
            this.cbOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrg.Size = new System.Drawing.Size(245, 22);
            this.cbOrg.TabIndex = 5;
            // 
            // laGvari
            // 
            this.laGvari.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laGvari.Appearance.Options.UseFont = true;
            this.laGvari.Location = new System.Drawing.Point(20, 131);
            this.laGvari.Name = "laGvari";
            this.laGvari.Size = new System.Drawing.Size(57, 16);
            this.laGvari.TabIndex = 33;
            this.laGvari.Text = "კლიენტი";
            // 
            // AddModz1Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(538, 284);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.laGvari);
            this.Controls.Add(this.cbProek2);
            this.Controls.Add(this.laProek2);
            this.Controls.Add(this.cbModzT);
            this.Controls.Add(this.cbProek1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.laModzT);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laProek1);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.laZedd);
            this.Controls.Add(this.txtZedd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddModz1Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddModz1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbModzT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).EndInit();
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
        private LabelControl laModzT;
        private LabelControl laProek1;
        private LabelControl laShen;
        private TextEdit txtShen;
        private DateEdit txtData;
        private DevExpress.XtraEditors.LookUpEdit cbProek1;
        private DevExpress.XtraEditors.LookUpEdit cbModzT;
        private DevExpress.XtraEditors.LookUpEdit cbProek2;
        private LabelControl laProek2;
        private LookUpEdit cbOrg;
        private LabelControl laGvari;
    }
}