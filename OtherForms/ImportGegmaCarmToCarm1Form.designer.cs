using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class ImportGegmaCarmToCarm1
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
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.laShen = new DevExpress.XtraEditors.LabelControl();
            this.cbProek2 = new DevExpress.XtraEditors.LookUpEdit();
            this.laCarmGegmaProek2 = new DevExpress.XtraEditors.LabelControl();
            this.cbCarmT = new DevExpress.XtraEditors.LookUpEdit();
            this.laCarmT = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dgGegmaCarm = new DevExpress.XtraGrid.GridControl();
            this.gvGegmaCarm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarmT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGegmaCarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGegmaCarm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.txtShen);
            this.panel2.Controls.Add(this.laShen);
            this.panel2.Controls.Add(this.cbProek2);
            this.panel2.Controls.Add(this.laCarmGegmaProek2);
            this.panel2.Controls.Add(this.cbCarmT);
            this.panel2.Controls.Add(this.laCarmT);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 170);
            this.panel2.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Appearance.Options.UseFont = true;
            this.btnGenerate.Location = new System.Drawing.Point(715, 107);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(258, 39);
            this.btnGenerate.TabIndex = 154;
            this.btnGenerate.Text = "გენერირება";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(26, 115);
            this.txtShen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(639, 26);
            this.txtShen.TabIndex = 5;
            // 
            // laShen
            // 
            this.laShen.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShen.Location = new System.Drawing.Point(26, 88);
            this.laShen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laShen.Name = "laShen";
            this.laShen.Size = new System.Drawing.Size(60, 19);
            this.laShen.TabIndex = 151;
            this.laShen.Text = "შენიშვნა";
            // 
            // cbProek2
            // 
            this.cbProek2.Location = new System.Drawing.Point(407, 39);
            this.cbProek2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProek2.Name = "cbProek2";
            this.cbProek2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProek2.Properties.Appearance.Options.UseFont = true;
            this.cbProek2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek2.Size = new System.Drawing.Size(566, 26);
            this.cbProek2.TabIndex = 4;
            // 
            // laCarmGegmaProek2
            // 
            this.laCarmGegmaProek2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCarmGegmaProek2.Location = new System.Drawing.Point(407, 12);
            this.laCarmGegmaProek2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCarmGegmaProek2.Name = "laCarmGegmaProek2";
            this.laCarmGegmaProek2.Size = new System.Drawing.Size(103, 19);
            this.laCarmGegmaProek2.TabIndex = 148;
            this.laCarmGegmaProek2.Text = "სად მზადდება";
            // 
            // cbCarmT
            // 
            this.cbCarmT.Location = new System.Drawing.Point(166, 39);
            this.cbCarmT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCarmT.Name = "cbCarmT";
            this.cbCarmT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarmT.Properties.Appearance.Options.UseFont = true;
            this.cbCarmT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCarmT.Size = new System.Drawing.Size(214, 26);
            this.cbCarmT.TabIndex = 1;
            // 
            // laCarmT
            // 
            this.laCarmT.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCarmT.Location = new System.Drawing.Point(171, 15);
            this.laCarmT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.laCarmT.Name = "laCarmT";
            this.laCarmT.Size = new System.Drawing.Size(117, 19);
            this.laCarmT.TabIndex = 144;
            this.laCarmT.Text = "მოძრაობის ტიპი";
            // 
            // txtData
            // 
            this.txtData.EditValue = new System.DateTime(2015, 10, 10, 0, 0, 0, 0);
            this.txtData.Location = new System.Drawing.Point(26, 39);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.txtData.Size = new System.Drawing.Size(125, 26);
            this.txtData.TabIndex = 0;
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 119;
            this.label3.Text = "თარიღი";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(897, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            // 
            // dgGegmaCarm
            // 
            this.dgGegmaCarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGegmaCarm.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgGegmaCarm.Location = new System.Drawing.Point(0, 170);
            this.dgGegmaCarm.MainView = this.gvGegmaCarm;
            this.dgGegmaCarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgGegmaCarm.Name = "dgGegmaCarm";
            this.dgGegmaCarm.Size = new System.Drawing.Size(998, 289);
            this.dgGegmaCarm.TabIndex = 34;
            this.dgGegmaCarm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGegmaCarm});
            // 
            // gvGegmaCarm
            // 
            this.gvGegmaCarm.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvGegmaCarm.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvGegmaCarm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProd,
            this.colRaod,
            this.colIdProd});
            this.gvGegmaCarm.FooterPanelHeight = 1;
            this.gvGegmaCarm.GridControl = this.dgGegmaCarm;
            this.gvGegmaCarm.GroupPanelText = "დაჯგუფება";
            this.gvGegmaCarm.GroupRowHeight = 1;
            this.gvGegmaCarm.Name = "gvGegmaCarm";
            this.gvGegmaCarm.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvGegmaCarm.OptionsDetail.AllowZoomDetail = false;
            this.gvGegmaCarm.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvGegmaCarm.OptionsSelection.MultiSelect = true;
            this.gvGegmaCarm.OptionsView.ColumnAutoWidth = false;
            this.gvGegmaCarm.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvGegmaCarm.OptionsView.ShowAutoFilterRow = true;
            this.gvGegmaCarm.OptionsView.ShowDetailButtons = false;
            this.gvGegmaCarm.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvGegmaCarm.OptionsView.ShowFooter = true;
            this.gvGegmaCarm.OptionsView.ShowGroupPanel = false;
            this.gvGegmaCarm.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvGegmaCarm_CustomUnboundColumnData);
            // 
            // colProd
            // 
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.OptionsColumn.AllowEdit = false;
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 370;
            // 
            // colRaod
            // 
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "{0:0.0###}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRaod.FieldName = "Raod";
            this.colRaod.Name = "colRaod";
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:#.####}")});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 131;
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.OptionsColumn.AllowEdit = false;
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            this.colIdProd.Width = 102;
            // 
            // ImportGegmaCarmToCarm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 501);
            this.Controls.Add(this.dgGegmaCarm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ImportGegmaCarmToCarm1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ImportGegmaCarmToCarm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCarmT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGegmaCarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGegmaCarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel2;
        private PanelControl panel1;
        private SimpleButton btnCancel;
        private SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl dgGegmaCarm;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGegmaCarm;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DateEdit txtData;
        private LabelControl label3;
        private LookUpEdit cbCarmT;
        private LabelControl laCarmT;
        private LookUpEdit cbProek2;
        private LabelControl laCarmGegmaProek2;
        private TextEdit txtShen;
        private LabelControl laShen;
        private SimpleButton btnGenerate;
    }
}