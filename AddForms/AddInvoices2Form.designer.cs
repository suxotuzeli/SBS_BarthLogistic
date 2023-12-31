using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddInvoices2Form
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.paInvoices2 = new DevExpress.XtraEditors.PanelControl();
            this.laTanxaValue = new DevExpress.XtraEditors.LabelControl();
            this.laTanxa = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFasi = new DevExpress.XtraEditors.CalcEdit();
            this.cbService = new DevExpress.XtraEditors.LookUpEdit();
            this.laService = new DevExpress.XtraEditors.LabelControl();
            this.laRaod = new DevExpress.XtraEditors.LabelControl();
            this.txtRaod = new DevExpress.XtraEditors.CalcEdit();
            this.dgInvoices2 = new DevExpress.XtraGrid.GridControl();
            this.gvInvoices2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInvoices2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paInvoices2)).BeginInit();
            this.paInvoices2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(735, 4);
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
            this.btnOK.Location = new System.Drawing.Point(642, 4);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 549);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 39);
            this.panel1.TabIndex = 2;
            // 
            // paInvoices2
            // 
            this.paInvoices2.Controls.Add(this.laTanxaValue);
            this.paInvoices2.Controls.Add(this.laTanxa);
            this.paInvoices2.Controls.Add(this.labelControl1);
            this.paInvoices2.Controls.Add(this.txtFasi);
            this.paInvoices2.Controls.Add(this.cbService);
            this.paInvoices2.Controls.Add(this.laService);
            this.paInvoices2.Controls.Add(this.laRaod);
            this.paInvoices2.Controls.Add(this.txtRaod);
            this.paInvoices2.Dock = System.Windows.Forms.DockStyle.Top;
            this.paInvoices2.Location = new System.Drawing.Point(0, 0);
            this.paInvoices2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paInvoices2.Name = "paInvoices2";
            this.paInvoices2.Size = new System.Drawing.Size(829, 61);
            this.paInvoices2.TabIndex = 0;
            // 
            // laTanxaValue
            // 
            this.laTanxaValue.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTanxaValue.Appearance.Options.UseFont = true;
            this.laTanxaValue.Location = new System.Drawing.Point(445, 30);
            this.laTanxaValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laTanxaValue.Name = "laTanxaValue";
            this.laTanxaValue.Size = new System.Drawing.Size(5, 16);
            this.laTanxaValue.TabIndex = 54;
            this.laTanxaValue.Text = "-";
            // 
            // laTanxa
            // 
            this.laTanxa.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTanxa.Appearance.Options.UseFont = true;
            this.laTanxa.Location = new System.Drawing.Point(445, 6);
            this.laTanxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laTanxa.Name = "laTanxa";
            this.laTanxa.Size = new System.Drawing.Size(32, 16);
            this.laTanxa.TabIndex = 53;
            this.laTanxa.Text = "თანხა";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(366, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 16);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "ფასი";
            // 
            // txtFasi
            // 
            this.txtFasi.EditValue = 0;
            this.txtFasi.Location = new System.Drawing.Point(366, 27);
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
            this.txtFasi.Properties.NullText = "0.00";
            this.txtFasi.Size = new System.Drawing.Size(73, 22);
            this.txtFasi.TabIndex = 51;
            this.txtFasi.ValueChanged += new System.EventHandler(this.txtRaod_ValueChanged);
            // 
            // cbService
            // 
            this.cbService.Location = new System.Drawing.Point(5, 27);
            this.cbService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbService.Name = "cbService";
            this.cbService.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.Properties.Appearance.Options.UseFont = true;
            this.cbService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbService.Size = new System.Drawing.Size(276, 22);
            this.cbService.TabIndex = 2;
            this.cbService.EditValueChanged += new System.EventHandler(this.cbService_EditValueChanged);
            // 
            // laService
            // 
            this.laService.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laService.Appearance.Options.UseFont = true;
            this.laService.Location = new System.Drawing.Point(5, 6);
            this.laService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laService.Name = "laService";
            this.laService.Size = new System.Drawing.Size(47, 16);
            this.laService.TabIndex = 50;
            this.laService.Text = "სერვისი";
            // 
            // laRaod
            // 
            this.laRaod.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRaod.Appearance.Options.UseFont = true;
            this.laRaod.Location = new System.Drawing.Point(287, 7);
            this.laRaod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laRaod.Name = "laRaod";
            this.laRaod.Size = new System.Drawing.Size(65, 16);
            this.laRaod.TabIndex = 49;
            this.laRaod.Text = "რაოდენობა";
            // 
            // txtRaod
            // 
            this.txtRaod.EditValue = 0;
            this.txtRaod.Location = new System.Drawing.Point(287, 27);
            this.txtRaod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRaod.Name = "txtRaod";
            this.txtRaod.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaod.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions2.Image = global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit;
            this.txtRaod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtRaod.Properties.DisplayFormat.FormatString = "f4";
            this.txtRaod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRaod.Properties.EditFormat.FormatString = "f4";
            this.txtRaod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRaod.Properties.Mask.EditMask = "f4";
            this.txtRaod.Properties.NullText = "0.00";
            this.txtRaod.Size = new System.Drawing.Size(73, 22);
            this.txtRaod.TabIndex = 1;
            this.txtRaod.ValueChanged += new System.EventHandler(this.txtRaod_ValueChanged);
            this.txtRaod.Enter += new System.EventHandler(this.TxtRaod_Enter);
            // 
            // dgInvoices2
            // 
            this.dgInvoices2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInvoices2.Location = new System.Drawing.Point(0, 61);
            this.dgInvoices2.MainView = this.gvInvoices2;
            this.dgInvoices2.Name = "dgInvoices2";
            this.dgInvoices2.Size = new System.Drawing.Size(829, 488);
            this.dgInvoices2.TabIndex = 1;
            this.dgInvoices2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoices2});
            this.dgInvoices2.DoubleClick += new System.EventHandler(this.dgDet_DoubleClick);
            // 
            // gvInvoices2
            // 
            this.gvInvoices2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvInvoices2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvInvoices2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInvoices2,
            this.colService,
            this.colRaod,
            this.colDetUN,
            this.colDetCD,
            this.colFasi,
            this.colTanxa});
            this.gvInvoices2.DetailHeight = 284;
            this.gvInvoices2.FooterPanelHeight = 1;
            this.gvInvoices2.GridControl = this.dgInvoices2;
            this.gvInvoices2.GroupPanelText = "დაჯგუფება";
            this.gvInvoices2.GroupRowHeight = 1;
            this.gvInvoices2.Name = "gvInvoices2";
            this.gvInvoices2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvInvoices2.OptionsBehavior.Editable = false;
            this.gvInvoices2.OptionsDetail.AllowZoomDetail = false;
            this.gvInvoices2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvInvoices2.OptionsSelection.MultiSelect = true;
            this.gvInvoices2.OptionsView.ColumnAutoWidth = false;
            this.gvInvoices2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvInvoices2.OptionsView.ShowAutoFilterRow = true;
            this.gvInvoices2.OptionsView.ShowDetailButtons = false;
            this.gvInvoices2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvInvoices2.OptionsView.ShowFooter = true;
            this.gvInvoices2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdInvoices2
            // 
            this.colIdInvoices2.Caption = "მიმდ.";
            this.colIdInvoices2.FieldName = "IdInvoices2";
            this.colIdInvoices2.MinWidth = 17;
            this.colIdInvoices2.Name = "colIdInvoices2";
            this.colIdInvoices2.Width = 64;
            // 
            // colService
            // 
            this.colService.Caption = "სერვისი";
            this.colService.FieldName = "Service";
            this.colService.MinWidth = 17;
            this.colService.Name = "colService";
            this.colService.Visible = true;
            this.colService.VisibleIndex = 0;
            this.colService.Width = 148;
            // 
            // colRaod
            // 
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "{0:0.####}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRaod.FieldName = "Raod";
            this.colRaod.MinWidth = 17;
            this.colRaod.Name = "colRaod";
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 1;
            this.colRaod.Width = 91;
            // 
            // colDetUN
            // 
            this.colDetUN.Caption = "მომხმარებელი";
            this.colDetUN.FieldName = "UN";
            this.colDetUN.MinWidth = 17;
            this.colDetUN.Name = "colDetUN";
            this.colDetUN.Visible = true;
            this.colDetUN.VisibleIndex = 4;
            this.colDetUN.Width = 64;
            // 
            // colDetCD
            // 
            this.colDetCD.Caption = "ცვლილების დრო";
            this.colDetCD.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colDetCD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDetCD.FieldName = "CD";
            this.colDetCD.MinWidth = 17;
            this.colDetCD.Name = "colDetCD";
            this.colDetCD.Visible = true;
            this.colDetCD.VisibleIndex = 5;
            this.colDetCD.Width = 94;
            // 
            // colFasi
            // 
            this.colFasi.Caption = "ფასი";
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 2;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 3;
            // 
            // AddInvoices2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(829, 588);
            this.Controls.Add(this.dgInvoices2);
            this.Controls.Add(this.paInvoices2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddInvoices2Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddInvoices2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paInvoices2)).EndInit();
            this.paInvoices2.ResumeLayout(false);
            this.paInvoices2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoices2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private PanelControl paInvoices2;
        private DevExpress.XtraGrid.GridControl dgInvoices2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoices2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInvoices2;
        private DevExpress.XtraGrid.Columns.GridColumn colService;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colDetUN;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCD;
        private LookUpEdit cbService;
        private LabelControl laService;
        private LabelControl laRaod;
        private CalcEdit txtRaod;
        private LabelControl laTanxaValue;
        private LabelControl laTanxa;
        private LabelControl labelControl1;
        private CalcEdit txtFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
    }
}