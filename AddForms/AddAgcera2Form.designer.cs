using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddAgcera2Form
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.txtProekSectorZone = new DevExpress.XtraEditors.TextEdit();
            this.laProdText = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.laProekSectorZone = new DevExpress.XtraEditors.LabelControl();
            this.cbProekSector = new DevExpress.XtraEditors.LookUpEdit();
            this.laProekSector = new DevExpress.XtraEditors.LabelControl();
            this.txtIdProd = new DevExpress.XtraEditors.TextEdit();
            this.laIdProd = new DevExpress.XtraEditors.LabelControl();
            this.laRaod = new DevExpress.XtraEditors.LabelControl();
            this.txtRaod = new DevExpress.XtraEditors.CalcEdit();
            this.dgAgcera2 = new DevExpress.XtraGrid.GridControl();
            this.gvAgcera2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGas2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSectorZone = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProekSectorZone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProekSector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgcera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgcera2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(649, 4);
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
            this.btnOK.Location = new System.Drawing.Point(556, 4);
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
            this.panel1.Size = new System.Drawing.Size(743, 39);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtProekSectorZone);
            this.panel2.Controls.Add(this.laProdText);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.laProekSectorZone);
            this.panel2.Controls.Add(this.cbProekSector);
            this.panel2.Controls.Add(this.laProekSector);
            this.panel2.Controls.Add(this.txtIdProd);
            this.panel2.Controls.Add(this.laIdProd);
            this.panel2.Controls.Add(this.laRaod);
            this.panel2.Controls.Add(this.txtRaod);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 89);
            this.panel2.TabIndex = 0;
            // 
            // txtProekSectorZone
            // 
            this.txtProekSectorZone.Location = new System.Drawing.Point(196, 31);
            this.txtProekSectorZone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProekSectorZone.Name = "txtProekSectorZone";
            this.txtProekSectorZone.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProekSectorZone.Properties.Appearance.Options.UseFont = true;
            this.txtProekSectorZone.Size = new System.Drawing.Size(189, 22);
            this.txtProekSectorZone.TabIndex = 55;
            // 
            // laProdText
            // 
            this.laProdText.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProdText.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laProdText.Appearance.Options.UseFont = true;
            this.laProdText.Appearance.Options.UseForeColor = true;
            this.laProdText.Location = new System.Drawing.Point(394, 57);
            this.laProdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProdText.Name = "laProdText";
            this.laProdText.Size = new System.Drawing.Size(5, 16);
            this.laProdText.TabIndex = 63;
            this.laProdText.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.lookup_reference_16x16;
            this.btnSearch.Location = new System.Drawing.Point(610, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 22);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // laProekSectorZone
            // 
            this.laProekSectorZone.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProekSectorZone.Appearance.Options.UseFont = true;
            this.laProekSectorZone.Location = new System.Drawing.Point(198, 10);
            this.laProekSectorZone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProekSectorZone.Name = "laProekSectorZone";
            this.laProekSectorZone.Size = new System.Drawing.Size(29, 16);
            this.laProekSectorZone.TabIndex = 61;
            this.laProekSectorZone.Text = "ზონა";
            // 
            // cbProekSector
            // 
            this.cbProekSector.Location = new System.Drawing.Point(5, 31);
            this.cbProekSector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProekSector.Name = "cbProekSector";
            this.cbProekSector.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProekSector.Properties.Appearance.Options.UseFont = true;
            this.cbProekSector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProekSector.Size = new System.Drawing.Size(187, 22);
            this.cbProekSector.TabIndex = 54;
            // 
            // laProekSector
            // 
            this.laProekSector.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProekSector.Appearance.Options.UseFont = true;
            this.laProekSector.Location = new System.Drawing.Point(5, 10);
            this.laProekSector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProekSector.Name = "laProekSector";
            this.laProekSector.Size = new System.Drawing.Size(51, 16);
            this.laProekSector.TabIndex = 60;
            this.laProekSector.Text = "სექტორი";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(391, 31);
            this.txtIdProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProd.Properties.Appearance.Options.UseFont = true;
            this.txtIdProd.Size = new System.Drawing.Size(217, 22);
            this.txtIdProd.TabIndex = 56;
            // 
            // laIdProd
            // 
            this.laIdProd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIdProd.Appearance.Options.UseFont = true;
            this.laIdProd.Location = new System.Drawing.Point(394, 11);
            this.laIdProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laIdProd.Name = "laIdProd";
            this.laIdProd.Size = new System.Drawing.Size(71, 16);
            this.laIdProd.TabIndex = 58;
            this.laIdProd.Text = "შტრიხ კოდი";
            // 
            // laRaod
            // 
            this.laRaod.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRaod.Appearance.Options.UseFont = true;
            this.laRaod.Location = new System.Drawing.Point(643, 11);
            this.laRaod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laRaod.Name = "laRaod";
            this.laRaod.Size = new System.Drawing.Size(65, 16);
            this.laRaod.TabIndex = 59;
            this.laRaod.Text = "რაოდენობა";
            // 
            // txtRaod
            // 
            this.txtRaod.EditValue = 0;
            this.txtRaod.Location = new System.Drawing.Point(643, 31);
            this.txtRaod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRaod.Name = "txtRaod";
            this.txtRaod.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaod.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit;
            this.txtRaod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtRaod.Properties.DisplayFormat.FormatString = "f4";
            this.txtRaod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRaod.Properties.EditFormat.FormatString = "f4";
            this.txtRaod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRaod.Properties.Mask.EditMask = "f4";
            this.txtRaod.Properties.NullText = "0.00";
            this.txtRaod.Size = new System.Drawing.Size(73, 22);
            this.txtRaod.TabIndex = 57;
            this.txtRaod.Enter += new System.EventHandler(this.txtRaod_Enter);
            // 
            // dgAgcera2
            // 
            this.dgAgcera2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAgcera2.Location = new System.Drawing.Point(0, 89);
            this.dgAgcera2.MainView = this.gvAgcera2;
            this.dgAgcera2.Name = "dgAgcera2";
            this.dgAgcera2.Size = new System.Drawing.Size(743, 460);
            this.dgAgcera2.TabIndex = 2;
            this.dgAgcera2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAgcera2});
            // 
            // gvAgcera2
            // 
            this.gvAgcera2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvAgcera2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAgcera2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGas2,
            this.colIdProd,
            this.colProd,
            this.colRaod,
            this.colDetUN,
            this.colDetCD,
            this.colProekSector,
            this.colProekSectorZone});
            this.gvAgcera2.DetailHeight = 284;
            this.gvAgcera2.FooterPanelHeight = 1;
            this.gvAgcera2.GridControl = this.dgAgcera2;
            this.gvAgcera2.GroupPanelText = "დაჯგუფება";
            this.gvAgcera2.GroupRowHeight = 1;
            this.gvAgcera2.Name = "gvAgcera2";
            this.gvAgcera2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvAgcera2.OptionsBehavior.Editable = false;
            this.gvAgcera2.OptionsDetail.AllowZoomDetail = false;
            this.gvAgcera2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvAgcera2.OptionsSelection.MultiSelect = true;
            this.gvAgcera2.OptionsView.ColumnAutoWidth = false;
            this.gvAgcera2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvAgcera2.OptionsView.ShowAutoFilterRow = true;
            this.gvAgcera2.OptionsView.ShowDetailButtons = false;
            this.gvAgcera2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvAgcera2.OptionsView.ShowFooter = true;
            this.gvAgcera2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdGas2
            // 
            this.colIdGas2.Caption = "მიმდ.";
            this.colIdGas2.FieldName = "IdGas2";
            this.colIdGas2.MinWidth = 17;
            this.colIdGas2.Name = "colIdGas2";
            this.colIdGas2.Width = 64;
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.MinWidth = 17;
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            this.colIdProd.Width = 64;
            // 
            // colProd
            // 
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.MinWidth = 17;
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 148;
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
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 91;
            // 
            // colDetUN
            // 
            this.colDetUN.Caption = "მომხმარებელი";
            this.colDetUN.FieldName = "UN";
            this.colDetUN.MinWidth = 17;
            this.colDetUN.Name = "colDetUN";
            this.colDetUN.Visible = true;
            this.colDetUN.VisibleIndex = 3;
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
            this.colDetCD.VisibleIndex = 4;
            this.colDetCD.Width = 94;
            // 
            // colProekSector
            // 
            this.colProekSector.Caption = "სექტორი";
            this.colProekSector.FieldName = "ProekSector";
            this.colProekSector.Name = "colProekSector";
            this.colProekSector.Visible = true;
            this.colProekSector.VisibleIndex = 5;
            // 
            // colProekSectorZone
            // 
            this.colProekSectorZone.Caption = "ზონა";
            this.colProekSectorZone.FieldName = "ProekSectorZone";
            this.colProekSectorZone.Name = "colProekSectorZone";
            this.colProekSectorZone.Visible = true;
            this.colProekSectorZone.VisibleIndex = 6;
            // 
            // AddAgcera2Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(743, 588);
            this.Controls.Add(this.dgAgcera2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAgcera2Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddAgcera2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProekSectorZone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProekSector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgcera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAgcera2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private PanelControl panel2;
        private TextEdit txtProekSectorZone;
        private LabelControl laProdText;
        private SimpleButton btnSearch;
        private LabelControl laProekSectorZone;
        private LookUpEdit cbProekSector;
        private LabelControl laProekSector;
        private TextEdit txtIdProd;
        private LabelControl laIdProd;
        private LabelControl laRaod;
        private CalcEdit txtRaod;
        private DevExpress.XtraGrid.GridControl dgAgcera2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAgcera2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGas2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colDetUN;
        private DevExpress.XtraGrid.Columns.GridColumn colDetCD;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSector;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSectorZone;
    }
}