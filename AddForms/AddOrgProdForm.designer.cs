using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddOrgProdForm
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
            DevExpress.XtraEditors.LabelControl laUnit;
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.dgOrgProd = new DevExpress.XtraGrid.GridControl();
            this.gvOrgProd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGas2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paGas2 = new DevExpress.XtraEditors.PanelControl();
            this.txtWeight = new DevExpress.XtraEditors.CalcEdit();
            this.laWeight = new DevExpress.XtraEditors.LabelControl();
            this.laPalet = new DevExpress.XtraEditors.LabelControl();
            this.txtPalet = new DevExpress.XtraEditors.TextEdit();
            this.cbUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.laBox = new DevExpress.XtraEditors.LabelControl();
            this.txtBox = new DevExpress.XtraEditors.TextEdit();
            this.laProd = new DevExpress.XtraEditors.LabelControl();
            this.txtProd = new DevExpress.XtraEditors.TextEdit();
            this.laIdProd = new DevExpress.XtraEditors.LabelControl();
            this.txtIdProd = new DevExpress.XtraEditors.TextEdit();
            laUnit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrgProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrgProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paGas2)).BeginInit();
            this.paGas2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laUnit
            // 
            laUnit.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            laUnit.Appearance.Options.UseFont = true;
            laUnit.Location = new System.Drawing.Point(426, 65);
            laUnit.Name = "laUnit";
            laUnit.Size = new System.Drawing.Size(58, 16);
            laUnit.TabIndex = 23;
            laUnit.Text = "ერთეული";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(609, 4);
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
            this.btnOK.Location = new System.Drawing.Point(516, 4);
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
            this.panel1.Size = new System.Drawing.Size(703, 39);
            this.panel1.TabIndex = 1;
            // 
            // dgOrgProd
            // 
            this.dgOrgProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrgProd.Location = new System.Drawing.Point(0, 125);
            this.dgOrgProd.MainView = this.gvOrgProd;
            this.dgOrgProd.Name = "dgOrgProd";
            this.dgOrgProd.Size = new System.Drawing.Size(703, 424);
            this.dgOrgProd.TabIndex = 0;
            this.dgOrgProd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrgProd});
            this.dgOrgProd.DoubleClick += new System.EventHandler(this.dgDet_DoubleClick);
            // 
            // gvOrgProd
            // 
            this.gvOrgProd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGas2,
            this.colIdProd,
            this.colProd,
            this.colBox,
            this.colPalet,
            this.colWeight,
            this.colUnit});
            this.gvOrgProd.DetailHeight = 284;
            this.gvOrgProd.FooterPanelHeight = 1;
            this.gvOrgProd.GridControl = this.dgOrgProd;
            this.gvOrgProd.GroupPanelText = "დაჯგუფება";
            this.gvOrgProd.GroupRowHeight = 1;
            this.gvOrgProd.Name = "gvOrgProd";
            this.gvOrgProd.OptionsBehavior.Editable = false;
            this.gvOrgProd.OptionsDetail.AllowZoomDetail = false;
            this.gvOrgProd.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvOrgProd.OptionsView.ColumnAutoWidth = false;
            this.gvOrgProd.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvOrgProd.OptionsView.ShowDetailButtons = false;
            this.gvOrgProd.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvOrgProd.OptionsView.ShowFooter = true;
            this.gvOrgProd.OptionsView.ShowGroupPanel = false;
            // 
            // colIdGas2
            // 
            this.colIdGas2.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIdGas2.AppearanceHeader.Options.UseFont = true;
            this.colIdGas2.Caption = "IdGas2";
            this.colIdGas2.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colIdGas2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIdGas2.FieldName = "IdGas2";
            this.colIdGas2.MinWidth = 17;
            this.colIdGas2.Name = "colIdGas2";
            this.colIdGas2.Width = 64;
            // 
            // colIdProd
            // 
            this.colIdProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colIdProd.AppearanceHeader.Options.UseFont = true;
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.MinWidth = 17;
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            this.colIdProd.Width = 164;
            // 
            // colProd
            // 
            this.colProd.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colProd.AppearanceHeader.Options.UseFont = true;
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.MinWidth = 17;
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 362;
            // 
            // colBox
            // 
            this.colBox.Caption = "ყუთი";
            this.colBox.FieldName = "Box";
            this.colBox.Name = "colBox";
            this.colBox.Visible = true;
            this.colBox.VisibleIndex = 2;
            // 
            // colPalet
            // 
            this.colPalet.Caption = "პალეტი";
            this.colPalet.FieldName = "Palet";
            this.colPalet.Name = "colPalet";
            this.colPalet.Visible = true;
            this.colPalet.VisibleIndex = 3;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "წონა";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 4;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "ერთეული";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 5;
            // 
            // paGas2
            // 
            this.paGas2.Controls.Add(this.txtWeight);
            this.paGas2.Controls.Add(this.laWeight);
            this.paGas2.Controls.Add(this.laPalet);
            this.paGas2.Controls.Add(this.txtPalet);
            this.paGas2.Controls.Add(this.cbUnit);
            this.paGas2.Controls.Add(laUnit);
            this.paGas2.Controls.Add(this.laBox);
            this.paGas2.Controls.Add(this.txtBox);
            this.paGas2.Controls.Add(this.laProd);
            this.paGas2.Controls.Add(this.txtProd);
            this.paGas2.Controls.Add(this.laIdProd);
            this.paGas2.Controls.Add(this.txtIdProd);
            this.paGas2.Dock = System.Windows.Forms.DockStyle.Top;
            this.paGas2.Location = new System.Drawing.Point(0, 0);
            this.paGas2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paGas2.Name = "paGas2";
            this.paGas2.Size = new System.Drawing.Size(703, 125);
            this.paGas2.TabIndex = 0;
            // 
            // txtWeight
            // 
            this.txtWeight.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtWeight.Location = new System.Drawing.Point(347, 84);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit;
            this.txtWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtWeight.Properties.DisplayFormat.FormatString = "f4";
            this.txtWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWeight.Properties.EditFormat.FormatString = "f4";
            this.txtWeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWeight.Properties.Mask.EditMask = "f4";
            this.txtWeight.Size = new System.Drawing.Size(73, 22);
            this.txtWeight.TabIndex = 4;
            // 
            // laWeight
            // 
            this.laWeight.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laWeight.Appearance.Options.UseFont = true;
            this.laWeight.Location = new System.Drawing.Point(347, 64);
            this.laWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laWeight.Name = "laWeight";
            this.laWeight.Size = new System.Drawing.Size(26, 16);
            this.laWeight.TabIndex = 27;
            this.laWeight.Text = "წონა";
            // 
            // laPalet
            // 
            this.laPalet.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPalet.Appearance.Options.UseFont = true;
            this.laPalet.Location = new System.Drawing.Point(176, 62);
            this.laPalet.Name = "laPalet";
            this.laPalet.Size = new System.Drawing.Size(44, 16);
            this.laPalet.TabIndex = 24;
            this.laPalet.Text = "პალეტი";
            // 
            // txtPalet
            // 
            this.txtPalet.Location = new System.Drawing.Point(176, 84);
            this.txtPalet.Name = "txtPalet";
            this.txtPalet.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalet.Properties.Appearance.Options.UseFont = true;
            this.txtPalet.Size = new System.Drawing.Size(165, 22);
            this.txtPalet.TabIndex = 3;
            // 
            // cbUnit
            // 
            this.cbUnit.Location = new System.Drawing.Point(426, 84);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnit.Properties.Appearance.Options.UseFont = true;
            this.cbUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnit.Size = new System.Drawing.Size(102, 22);
            this.cbUnit.TabIndex = 5;
            // 
            // laBox
            // 
            this.laBox.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laBox.Appearance.Options.UseFont = true;
            this.laBox.Location = new System.Drawing.Point(5, 62);
            this.laBox.Name = "laBox";
            this.laBox.Size = new System.Drawing.Size(32, 16);
            this.laBox.TabIndex = 11;
            this.laBox.Text = "ყუთი";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(5, 84);
            this.txtBox.Name = "txtBox";
            this.txtBox.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Properties.Appearance.Options.UseFont = true;
            this.txtBox.Size = new System.Drawing.Size(165, 22);
            this.txtBox.TabIndex = 2;
            // 
            // laProd
            // 
            this.laProd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProd.Appearance.Options.UseFont = true;
            this.laProd.Location = new System.Drawing.Point(176, 10);
            this.laProd.Name = "laProd";
            this.laProd.Size = new System.Drawing.Size(67, 16);
            this.laProd.TabIndex = 8;
            this.laProd.Text = "პროდუქცია";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(176, 32);
            this.txtProd.Name = "txtProd";
            this.txtProd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Properties.Appearance.Options.UseFont = true;
            this.txtProd.Size = new System.Drawing.Size(397, 22);
            this.txtProd.TabIndex = 1;
            // 
            // laIdProd
            // 
            this.laIdProd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIdProd.Appearance.Options.UseFont = true;
            this.laIdProd.Location = new System.Drawing.Point(5, 10);
            this.laIdProd.Name = "laIdProd";
            this.laIdProd.Size = new System.Drawing.Size(31, 16);
            this.laIdProd.TabIndex = 6;
            this.laIdProd.Text = "კოდი";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(5, 32);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProd.Properties.Appearance.Options.UseFont = true;
            this.txtIdProd.Size = new System.Drawing.Size(165, 22);
            this.txtIdProd.TabIndex = 0;
            // 
            // AddOrgProdForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(703, 588);
            this.Controls.Add(this.dgOrgProd);
            this.Controls.Add(this.paGas2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrgProdForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddOrgProdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrgProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrgProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paGas2)).EndInit();
            this.paGas2.ResumeLayout(false);
            this.paGas2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPalet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrgProd;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGas2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private PanelControl paGas2;
        private LabelControl laProd;
        private TextEdit txtProd;
        private LabelControl laIdProd;
        private LabelControl laBox;
        private TextEdit txtBox;
        private LookUpEdit cbUnit;
        private LabelControl laPalet;
        private TextEdit txtPalet;
        private CalcEdit txtWeight;
        private LabelControl laWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colBox;
        private DevExpress.XtraGrid.Columns.GridColumn colPalet;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        public TextEdit txtIdProd;
        public DevExpress.XtraGrid.GridControl dgOrgProd;
    }
}