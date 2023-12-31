using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddAgcera1Form
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.laProek = new DevExpress.XtraEditors.LabelControl();
            this.laAgceraT = new DevExpress.XtraEditors.LabelControl();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.cbProek = new DevExpress.XtraEditors.LookUpEdit();
            this.cbAgceraT = new DevExpress.XtraEditors.LookUpEdit();
            this.cbOrg = new DevExpress.XtraEditors.LookUpEdit();
            this.laGvari = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgceraT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(612, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(513, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
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
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 39);
            this.panel1.TabIndex = 5;
            // 
            // laData
            // 
            this.laData.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laData.Appearance.Options.UseFont = true;
            this.laData.Location = new System.Drawing.Point(18, 10);
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
            this.laProek.Location = new System.Drawing.Point(382, 10);
            this.laProek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProek.Name = "laProek";
            this.laProek.Size = new System.Drawing.Size(49, 16);
            this.laProek.TabIndex = 26;
            this.laProek.Text = "ობიექტი";
            // 
            // laAgceraT
            // 
            this.laAgceraT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laAgceraT.Appearance.Options.UseFont = true;
            this.laAgceraT.Location = new System.Drawing.Point(18, 63);
            this.laAgceraT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laAgceraT.Name = "laAgceraT";
            this.laAgceraT.Size = new System.Drawing.Size(80, 16);
            this.laAgceraT.TabIndex = 27;
            this.laAgceraT.Text = "აღწერის ტიპი";
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Appearance.Options.UseFont = true;
            this.laShen.Location = new System.Drawing.Point(267, 62);
            this.laShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(48, 16);
            this.laShen.TabIndex = 29;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(267, 82);
            this.txtShen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(416, 22);
            this.txtShen.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(18, 29);
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
            this.cbProek.Location = new System.Drawing.Point(382, 29);
            this.cbProek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProek.Name = "cbProek";
            this.cbProek.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProek.Properties.Appearance.Options.UseFont = true;
            this.cbProek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek.Size = new System.Drawing.Size(243, 22);
            this.cbProek.TabIndex = 2;
            // 
            // cbAgceraT
            // 
            this.cbAgceraT.Location = new System.Drawing.Point(18, 82);
            this.cbAgceraT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAgceraT.Name = "cbAgceraT";
            this.cbAgceraT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgceraT.Properties.Appearance.Options.UseFont = true;
            this.cbAgceraT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAgceraT.Size = new System.Drawing.Size(243, 22);
            this.cbAgceraT.TabIndex = 3;
            // 
            // cbOrg
            // 
            this.cbOrg.Location = new System.Drawing.Point(131, 29);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrg.Properties.Appearance.Options.UseFont = true;
            this.cbOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrg.Size = new System.Drawing.Size(245, 22);
            this.cbOrg.TabIndex = 1;
            // 
            // laGvari
            // 
            this.laGvari.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laGvari.Appearance.Options.UseFont = true;
            this.laGvari.Location = new System.Drawing.Point(131, 11);
            this.laGvari.Name = "laGvari";
            this.laGvari.Size = new System.Drawing.Size(57, 16);
            this.laGvari.TabIndex = 33;
            this.laGvari.Text = "კლიენტი";
            // 
            // AddAgcera1Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(707, 164);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.laGvari);
            this.Controls.Add(this.cbAgceraT);
            this.Controls.Add(this.cbProek);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laAgceraT);
            this.Controls.Add(this.laProek);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAgcera1Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddAgcera1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgceraT.Properties)).EndInit();
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
        private LabelControl laAgceraT;
        private LabelControl laProek;
        private LabelControl laShen;
        private TextEdit txtShen;
        private DateEdit txtData;
        private DevExpress.XtraEditors.LookUpEdit cbProek;
        private DevExpress.XtraEditors.LookUpEdit cbAgceraT;
        private LookUpEdit cbOrg;
        private LabelControl laGvari;
    }
}