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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.cbService = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFasi = new DevExpress.XtraEditors.CalcEdit();
            this.laFasi = new DevExpress.XtraEditors.LabelControl();
            this.laIdDogo1 = new System.Windows.Forms.Label();
            this.laFileName = new System.Windows.Forms.Label();
            this.btnFFileName = new DevExpress.XtraEditors.SimpleButton();
            this.txtBeginDate = new DevExpress.XtraEditors.DateEdit();
            this.laBeginDate = new DevExpress.XtraEditors.LabelControl();
            this.txtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.laEndDate = new DevExpress.XtraEditors.LabelControl();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            laServices = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laServices
            // 
            laServices.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laServices.Appearance.Options.UseFont = true;
            laServices.Location = new System.Drawing.Point(14, 10);
            laServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            laServices.Name = "laServices";
            laServices.Size = new System.Drawing.Size(152, 19);
            laServices.TabIndex = 21;
            laServices.Text = "სერვისის დასახელება";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(648, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(545, 6);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 37);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
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
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 48);
            this.panel1.TabIndex = 9;
            // 
            // cbService
            // 
            this.cbService.Location = new System.Drawing.Point(14, 33);
            this.cbService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbService.Name = "cbService";
            this.cbService.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.Properties.Appearance.Options.UseFont = true;
            this.cbService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbService.Size = new System.Drawing.Size(281, 26);
            this.cbService.TabIndex = 7;
            // 
            // txtFasi
            // 
            this.txtFasi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtFasi.Location = new System.Drawing.Point(302, 33);
            this.txtFasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFasi.Name = "txtFasi";
            this.txtFasi.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFasi.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit;
            this.txtFasi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtFasi.Properties.DisplayFormat.FormatString = "f4";
            this.txtFasi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFasi.Properties.EditFormat.FormatString = "f4";
            this.txtFasi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtFasi.Properties.Mask.EditMask = "f4";
            this.txtFasi.Size = new System.Drawing.Size(85, 26);
            this.txtFasi.TabIndex = 22;
            // 
            // laFasi
            // 
            this.laFasi.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFasi.Appearance.Options.UseFont = true;
            this.laFasi.Location = new System.Drawing.Point(302, 9);
            this.laFasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laFasi.Name = "laFasi";
            this.laFasi.Size = new System.Drawing.Size(33, 19);
            this.laFasi.TabIndex = 23;
            this.laFasi.Text = "ფასი";
            // 
            // laIdDogo1
            // 
            this.laIdDogo1.AutoSize = true;
            this.laIdDogo1.Location = new System.Drawing.Point(134, 172);
            this.laIdDogo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laIdDogo1.Name = "laIdDogo1";
            this.laIdDogo1.Size = new System.Drawing.Size(42, 17);
            this.laIdDogo1.TabIndex = 59;
            this.laIdDogo1.Text = "label2";
            this.laIdDogo1.Visible = false;
            // 
            // laFileName
            // 
            this.laFileName.AutoSize = true;
            this.laFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laFileName.Location = new System.Drawing.Point(17, 98);
            this.laFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laFileName.Name = "laFileName";
            this.laFileName.Size = new System.Drawing.Size(69, 20);
            this.laFileName.TabIndex = 57;
            this.laFileName.Text = "ფაილი";
            // 
            // btnFFileName
            // 
            this.btnFFileName.Location = new System.Drawing.Point(298, 123);
            this.btnFFileName.Margin = new System.Windows.Forms.Padding(4);
            this.btnFFileName.Name = "btnFFileName";
            this.btnFFileName.Size = new System.Drawing.Size(32, 27);
            this.btnFFileName.TabIndex = 58;
            this.btnFFileName.Text = "...";
            this.btnFFileName.Click += new System.EventHandler(this.btnFFileName_Click);
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.EditValue = "1.1.2010";
            this.txtBeginDate.Location = new System.Drawing.Point(417, 33);
            this.txtBeginDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeginDate.Properties.Appearance.Options.UseFont = true;
            this.txtBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBeginDate.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtBeginDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtBeginDate.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtBeginDate.Size = new System.Drawing.Size(125, 26);
            this.txtBeginDate.TabIndex = 60;
            // 
            // laBeginDate
            // 
            this.laBeginDate.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laBeginDate.Appearance.Options.UseFont = true;
            this.laBeginDate.Location = new System.Drawing.Point(417, 9);
            this.laBeginDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laBeginDate.Name = "laBeginDate";
            this.laBeginDate.Size = new System.Drawing.Size(55, 19);
            this.laBeginDate.TabIndex = 61;
            this.laBeginDate.Text = "დაწყება";
            // 
            // txtEndDate
            // 
            this.txtEndDate.EditValue = "1.1.2010";
            this.txtEndDate.Location = new System.Drawing.Point(562, 33);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Properties.Appearance.Options.UseFont = true;
            this.txtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtEndDate.Size = new System.Drawing.Size(125, 26);
            this.txtEndDate.TabIndex = 62;
            // 
            // laEndDate
            // 
            this.laEndDate.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEndDate.Appearance.Options.UseFont = true;
            this.laEndDate.Location = new System.Drawing.Point(562, 9);
            this.laEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laEndDate.Name = "laEndDate";
            this.laEndDate.Size = new System.Drawing.Size(84, 19);
            this.laEndDate.TabIndex = 63;
            this.laEndDate.Text = "დასრულება";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(21, 124);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Properties.Appearance.Options.UseFont = true;
            this.txtFileName.Size = new System.Drawing.Size(261, 26);
            this.txtFileName.TabIndex = 64;
            // 
            // AddOrgServicesForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(756, 291);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.laEndDate);
            this.Controls.Add(this.txtBeginDate);
            this.Controls.Add(this.laBeginDate);
            this.Controls.Add(this.laIdDogo1);
            this.Controls.Add(this.laFileName);
            this.Controls.Add(this.btnFFileName);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
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
        private System.Windows.Forms.Label laIdDogo1;
        private System.Windows.Forms.Label laFileName;
        private SimpleButton btnFFileName;
        private DateEdit txtBeginDate;
        private LabelControl laBeginDate;
        private DateEdit txtEndDate;
        private LabelControl laEndDate;
        private TextEdit txtFileName;
    }
}