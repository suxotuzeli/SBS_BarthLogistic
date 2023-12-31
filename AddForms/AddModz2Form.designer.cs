using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddModz2Form
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
            this.dgModz2 = new DevExpress.XtraGrid.GridControl();
            this.gvModz2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdModz2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paModz2 = new DevExpress.XtraEditors.PanelControl();
            this.txtProekSectorZone1 = new DevExpress.XtraEditors.TextEdit();
            this.laProdText = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.laProekSectorZone1 = new DevExpress.XtraEditors.LabelControl();
            this.cbProekSector1 = new DevExpress.XtraEditors.LookUpEdit();
            this.laProekSector1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdProd = new DevExpress.XtraEditors.TextEdit();
            this.laIdProd = new DevExpress.XtraEditors.LabelControl();
            this.laRaod = new DevExpress.XtraEditors.LabelControl();
            this.txtRaod = new DevExpress.XtraEditors.CalcEdit();
            this.txtProekSectorZone2 = new DevExpress.XtraEditors.TextEdit();
            this.laProekSectorZone2 = new DevExpress.XtraEditors.LabelControl();
            this.cbProekSector2 = new DevExpress.XtraEditors.LookUpEdit();
            this.laProekSector2 = new DevExpress.XtraEditors.LabelControl();
            this.colProekSectorZone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSectorZone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSector1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSector2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paModz2)).BeginInit();
            this.paModz2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProekSectorZone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProekSector1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProekSectorZone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProekSector2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(677, 4);
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
            this.btnOK.Location = new System.Drawing.Point(584, 4);
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
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 39);
            this.panel1.TabIndex = 2;
            // 
            // dgModz2
            // 
            this.dgModz2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgModz2.Location = new System.Drawing.Point(0, 123);
            this.dgModz2.MainView = this.gvModz2;
            this.dgModz2.Name = "dgModz2";
            this.dgModz2.Size = new System.Drawing.Size(771, 213);
            this.dgModz2.TabIndex = 1;
            this.dgModz2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvModz2});
            this.dgModz2.DoubleClick += new System.EventHandler(this.dgDet_DoubleClick);
            // 
            // gvModz2
            // 
            this.gvModz2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdModz2,
            this.colIdProd,
            this.colProd,
            this.colRaod,
            this.colProekSectorZone1,
            this.colProekSectorZone2,
            this.colProekSector1,
            this.colProekSector2});
            this.gvModz2.DetailHeight = 284;
            this.gvModz2.FooterPanelHeight = 1;
            this.gvModz2.GridControl = this.dgModz2;
            this.gvModz2.GroupPanelText = "დაჯგუფება";
            this.gvModz2.GroupRowHeight = 1;
            this.gvModz2.Name = "gvModz2";
            this.gvModz2.OptionsBehavior.Editable = false;
            this.gvModz2.OptionsDetail.AllowZoomDetail = false;
            this.gvModz2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvModz2.OptionsView.ColumnAutoWidth = false;
            this.gvModz2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvModz2.OptionsView.ShowDetailButtons = false;
            this.gvModz2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvModz2.OptionsView.ShowFooter = true;
            this.gvModz2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdModz2
            // 
            this.colIdModz2.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colIdModz2.AppearanceHeader.Options.UseFont = true;
            this.colIdModz2.Caption = "IdModz2";
            this.colIdModz2.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colIdModz2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIdModz2.FieldName = "IdModz2";
            this.colIdModz2.MinWidth = 17;
            this.colIdModz2.Name = "colIdModz2";
            this.colIdModz2.Width = 64;
            // 
            // colIdProd
            // 
            this.colIdProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colIdProd.AppearanceHeader.Options.UseFont = true;
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.MinWidth = 17;
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 4;
            this.colIdProd.Width = 64;
            // 
            // colProd
            // 
            this.colProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colProd.AppearanceHeader.Options.UseFont = true;
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.MinWidth = 17;
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 5;
            this.colProd.Width = 148;
            // 
            // colRaod
            // 
            this.colRaod.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colRaod.AppearanceHeader.Options.UseFont = true;
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "{0:0.###}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRaod.FieldName = "Raod";
            this.colRaod.MinWidth = 17;
            this.colRaod.Name = "colRaod";
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 6;
            this.colRaod.Width = 91;
            // 
            // paModz2
            // 
            this.paModz2.Controls.Add(this.txtProekSectorZone2);
            this.paModz2.Controls.Add(this.laProekSectorZone2);
            this.paModz2.Controls.Add(this.cbProekSector2);
            this.paModz2.Controls.Add(this.laProekSector2);
            this.paModz2.Controls.Add(this.txtProekSectorZone1);
            this.paModz2.Controls.Add(this.laProdText);
            this.paModz2.Controls.Add(this.btnSearch);
            this.paModz2.Controls.Add(this.laProekSectorZone1);
            this.paModz2.Controls.Add(this.cbProekSector1);
            this.paModz2.Controls.Add(this.laProekSector1);
            this.paModz2.Controls.Add(this.txtIdProd);
            this.paModz2.Controls.Add(this.laIdProd);
            this.paModz2.Controls.Add(this.laRaod);
            this.paModz2.Controls.Add(this.txtRaod);
            this.paModz2.Dock = System.Windows.Forms.DockStyle.Top;
            this.paModz2.Location = new System.Drawing.Point(0, 0);
            this.paModz2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paModz2.Name = "paModz2";
            this.paModz2.Size = new System.Drawing.Size(771, 123);
            this.paModz2.TabIndex = 0;
            // 
            // txtProekSectorZone1
            // 
            this.txtProekSectorZone1.Location = new System.Drawing.Point(196, 30);
            this.txtProekSectorZone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProekSectorZone1.Name = "txtProekSectorZone1";
            this.txtProekSectorZone1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProekSectorZone1.Properties.Appearance.Options.UseFont = true;
            this.txtProekSectorZone1.Size = new System.Drawing.Size(189, 22);
            this.txtProekSectorZone1.TabIndex = 1;
            // 
            // laProdText
            // 
            this.laProdText.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProdText.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laProdText.Appearance.Options.UseFont = true;
            this.laProdText.Appearance.Options.UseForeColor = true;
            this.laProdText.Location = new System.Drawing.Point(420, 79);
            this.laProdText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProdText.Name = "laProdText";
            this.laProdText.Size = new System.Drawing.Size(5, 16);
            this.laProdText.TabIndex = 63;
            this.laProdText.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.lookup_reference_16x16;
            this.btnSearch.Location = new System.Drawing.Point(636, 53);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 22);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // laProekSectorZone1
            // 
            this.laProekSectorZone1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProekSectorZone1.Appearance.Options.UseFont = true;
            this.laProekSectorZone1.Location = new System.Drawing.Point(198, 9);
            this.laProekSectorZone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProekSectorZone1.Name = "laProekSectorZone1";
            this.laProekSectorZone1.Size = new System.Drawing.Size(38, 16);
            this.laProekSectorZone1.TabIndex = 61;
            this.laProekSectorZone1.Text = "ზონა 1";
            // 
            // cbProekSector1
            // 
            this.cbProekSector1.Location = new System.Drawing.Point(5, 30);
            this.cbProekSector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProekSector1.Name = "cbProekSector1";
            this.cbProekSector1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProekSector1.Properties.Appearance.Options.UseFont = true;
            this.cbProekSector1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProekSector1.Size = new System.Drawing.Size(187, 22);
            this.cbProekSector1.TabIndex = 0;
            // 
            // laProekSector1
            // 
            this.laProekSector1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProekSector1.Appearance.Options.UseFont = true;
            this.laProekSector1.Location = new System.Drawing.Point(5, 9);
            this.laProekSector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProekSector1.Name = "laProekSector1";
            this.laProekSector1.Size = new System.Drawing.Size(60, 16);
            this.laProekSector1.TabIndex = 60;
            this.laProekSector1.Text = "სექტორი 1";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(417, 53);
            this.txtIdProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProd.Properties.Appearance.Options.UseFont = true;
            this.txtIdProd.Size = new System.Drawing.Size(217, 22);
            this.txtIdProd.TabIndex = 4;
            // 
            // laIdProd
            // 
            this.laIdProd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIdProd.Appearance.Options.UseFont = true;
            this.laIdProd.Location = new System.Drawing.Point(420, 33);
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
            this.laRaod.Location = new System.Drawing.Point(669, 33);
            this.laRaod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laRaod.Name = "laRaod";
            this.laRaod.Size = new System.Drawing.Size(65, 16);
            this.laRaod.TabIndex = 59;
            this.laRaod.Text = "რაოდენობა";
            // 
            // txtRaod
            // 
            this.txtRaod.EditValue = 0;
            this.txtRaod.Location = new System.Drawing.Point(669, 53);
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
            this.txtRaod.TabIndex = 5;
            this.txtRaod.Enter += new System.EventHandler(this.txtRaod_Enter);
            // 
            // txtProekSectorZone2
            // 
            this.txtProekSectorZone2.Location = new System.Drawing.Point(196, 81);
            this.txtProekSectorZone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProekSectorZone2.Name = "txtProekSectorZone2";
            this.txtProekSectorZone2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProekSectorZone2.Properties.Appearance.Options.UseFont = true;
            this.txtProekSectorZone2.Size = new System.Drawing.Size(189, 22);
            this.txtProekSectorZone2.TabIndex = 3;
            // 
            // laProekSectorZone2
            // 
            this.laProekSectorZone2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProekSectorZone2.Appearance.Options.UseFont = true;
            this.laProekSectorZone2.Location = new System.Drawing.Point(198, 60);
            this.laProekSectorZone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProekSectorZone2.Name = "laProekSectorZone2";
            this.laProekSectorZone2.Size = new System.Drawing.Size(38, 16);
            this.laProekSectorZone2.TabIndex = 67;
            this.laProekSectorZone2.Text = "ზონა 2";
            // 
            // cbProekSector2
            // 
            this.cbProekSector2.Location = new System.Drawing.Point(5, 81);
            this.cbProekSector2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProekSector2.Name = "cbProekSector2";
            this.cbProekSector2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProekSector2.Properties.Appearance.Options.UseFont = true;
            this.cbProekSector2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProekSector2.Size = new System.Drawing.Size(187, 22);
            this.cbProekSector2.TabIndex = 2;
            // 
            // laProekSector2
            // 
            this.laProekSector2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProekSector2.Appearance.Options.UseFont = true;
            this.laProekSector2.Location = new System.Drawing.Point(5, 60);
            this.laProekSector2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laProekSector2.Name = "laProekSector2";
            this.laProekSector2.Size = new System.Drawing.Size(60, 16);
            this.laProekSector2.TabIndex = 66;
            this.laProekSector2.Text = "სექტორი 2";
            // 
            // colProekSectorZone1
            // 
            this.colProekSectorZone1.Caption = "ლოკაცია 1";
            this.colProekSectorZone1.FieldName = "ProekSectorZone1";
            this.colProekSectorZone1.Name = "colProekSectorZone1";
            this.colProekSectorZone1.Visible = true;
            this.colProekSectorZone1.VisibleIndex = 2;
            // 
            // colProekSectorZone2
            // 
            this.colProekSectorZone2.Caption = "ლოკაცია 2";
            this.colProekSectorZone2.FieldName = "ProekSectorZone2";
            this.colProekSectorZone2.Name = "colProekSectorZone2";
            this.colProekSectorZone2.Visible = true;
            this.colProekSectorZone2.VisibleIndex = 3;
            // 
            // colProekSector1
            // 
            this.colProekSector1.Caption = "შენობა 1 ";
            this.colProekSector1.FieldName = "ProekSector1";
            this.colProekSector1.Name = "colProekSector1";
            this.colProekSector1.Visible = true;
            this.colProekSector1.VisibleIndex = 0;
            // 
            // colProekSector2
            // 
            this.colProekSector2.Caption = "შენობა 2";
            this.colProekSector2.FieldName = "ProekSector2";
            this.colProekSector2.Name = "colProekSector2";
            this.colProekSector2.Visible = true;
            this.colProekSector2.VisibleIndex = 1;
            // 
            // AddModz2Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(771, 375);
            this.Controls.Add(this.dgModz2);
            this.Controls.Add(this.paModz2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddModz2Form";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddModz2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgModz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paModz2)).EndInit();
            this.paModz2.ResumeLayout(false);
            this.paModz2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProekSectorZone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProekSector1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProekSectorZone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProekSector2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private DevExpress.XtraGrid.GridControl dgModz2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvModz2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdModz2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private PanelControl paModz2;
        private TextEdit txtProekSectorZone1;
        private LabelControl laProdText;
        private SimpleButton btnSearch;
        private LabelControl laProekSectorZone1;
        private LookUpEdit cbProekSector1;
        private LabelControl laProekSector1;
        private TextEdit txtIdProd;
        private LabelControl laIdProd;
        private LabelControl laRaod;
        private CalcEdit txtRaod;
        private TextEdit txtProekSectorZone2;
        private LabelControl laProekSectorZone2;
        private LookUpEdit cbProekSector2;
        private LabelControl laProekSector2;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSectorZone1;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSectorZone2;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSector1;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSector2;
    }
}