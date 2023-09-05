using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddOrgServicesForm
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
            DevExpress.XtraEditors.LabelControl laServices;
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.cbService = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFasi = new DevExpress.XtraEditors.CalcEdit();
            this.laFasi = new DevExpress.XtraEditors.LabelControl();
            laServices = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laServices
            // 
            laServices.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laServices.Appearance.Options.UseFont = true;
            laServices.Location = new System.Drawing.Point(12, 8);
            laServices.Name = "laServices";
            laServices.Size = new System.Drawing.Size(122, 16);
            laServices.TabIndex = 21;
            laServices.Text = "სერვისის დასახელება";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(275, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(187, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 30);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 39);
            this.panel1.TabIndex = 9;
            // 
            // cbService
            // 
            this.cbService.Location = new System.Drawing.Point(12, 27);
            this.cbService.Name = "cbService";
            this.cbService.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.Properties.Appearance.Options.UseFont = true;
            this.cbService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbService.Size = new System.Drawing.Size(241, 22);
            this.cbService.TabIndex = 7;
            // 
            // txtFasi
            // 
            this.txtFasi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtFasi.Location = new System.Drawing.Point(259, 27);
            this.txtFasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFasi.Name = "txtFasi";
            this.txtFasi.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFasi.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit;
            this.txtFasi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtFasi.Properties.DisplayFormat.FormatString = "f4";
            this.txtFasi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFasi.Properties.EditFormat.FormatString = "f4";
            this.txtFasi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFasi.Properties.Mask.EditMask = "f4";
            this.txtFasi.Size = new System.Drawing.Size(73, 22);
            this.txtFasi.TabIndex = 22;
            // 
            // laFasi
            // 
            this.laFasi.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFasi.Appearance.Options.UseFont = true;
            this.laFasi.Location = new System.Drawing.Point(259, 7);
            this.laFasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laFasi.Name = "laFasi";
            this.laFasi.Size = new System.Drawing.Size(27, 16);
            this.laFasi.TabIndex = 23;
            this.laFasi.Text = "ფასი";
            // 
            // AddOrgServicesForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 125);
            this.Controls.Add(this.txtFasi);
            this.Controls.Add(this.laFasi);
            this.Controls.Add(this.cbService);
            this.Controls.Add(laServices);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrgServicesForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddOrgServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private DevExpress.XtraEditors.LookUpEdit cbService;
        private CalcEdit txtFasi;
        private LabelControl laFasi;
    }
}