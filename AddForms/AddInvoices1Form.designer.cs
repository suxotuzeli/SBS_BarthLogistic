using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddInvoices1Form
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
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.laZedd = new DevExpress.XtraEditors.LabelControl();
            this.laData = new DevExpress.XtraEditors.LabelControl();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.cbOrg = new DevExpress.XtraEditors.LookUpEdit();
            this.laGvari = new DevExpress.XtraEditors.LabelControl();
            this.cbInvoicesT = new DevExpress.XtraEditors.LookUpEdit();
            this.laInvoicesT = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInvoicesT.Properties)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 45);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(444, 6);
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
            this.btnOK.Location = new System.Drawing.Point(345, 6);
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
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laShen.Appearance.Options.UseFont = true;
            this.laShen.Location = new System.Drawing.Point(18, 133);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(58, 16);
            this.laShen.TabIndex = 29;
            this.laShen.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(18, 155);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(508, 22);
            this.txtShen.TabIndex = 4;
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
            // cbOrg
            // 
            this.cbOrg.Location = new System.Drawing.Point(281, 28);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrg.Properties.Appearance.Options.UseFont = true;
            this.cbOrg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOrg.Size = new System.Drawing.Size(245, 22);
            this.cbOrg.TabIndex = 2;
            // 
            // laGvari
            // 
            this.laGvari.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laGvari.Appearance.Options.UseFont = true;
            this.laGvari.Location = new System.Drawing.Point(281, 10);
            this.laGvari.Name = "laGvari";
            this.laGvari.Size = new System.Drawing.Size(57, 16);
            this.laGvari.TabIndex = 31;
            this.laGvari.Text = "კლიენტი";
            // 
            // cbInvoicesT
            // 
            this.cbInvoicesT.Location = new System.Drawing.Point(18, 82);
            this.cbInvoicesT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInvoicesT.Name = "cbInvoicesT";
            this.cbInvoicesT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoicesT.Properties.Appearance.Options.UseFont = true;
            this.cbInvoicesT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbInvoicesT.Size = new System.Drawing.Size(245, 22);
            this.cbInvoicesT.TabIndex = 3;
            // 
            // laInvoicesT
            // 
            this.laInvoicesT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laInvoicesT.Appearance.Options.UseFont = true;
            this.laInvoicesT.Location = new System.Drawing.Point(18, 64);
            this.laInvoicesT.Name = "laInvoicesT";
            this.laInvoicesT.Size = new System.Drawing.Size(93, 16);
            this.laInvoicesT.TabIndex = 33;
            this.laInvoicesT.Text = "ინვოისის ტიპი";
            // 
            // AddInvoices1Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(539, 240);
            this.Controls.Add(this.cbInvoicesT);
            this.Controls.Add(this.laInvoicesT);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.laGvari);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.laShen);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.laData);
            this.Controls.Add(this.laZedd);
            this.Controls.Add(this.txtZedd);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddInvoices1Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddInvoices1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbOrg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInvoicesT.Properties)).EndInit();
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
        private LabelControl laShen;
        private TextEdit txtShen;
        private DateEdit txtData;
        private LookUpEdit cbOrg;
        private LabelControl laGvari;
        private LookUpEdit cbInvoicesT;
        private LabelControl laInvoicesT;
    }
}