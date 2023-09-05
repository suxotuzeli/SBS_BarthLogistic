using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class GenerateMomcShekForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.fmgMomc = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdTG = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdG = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdS = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgData = new SBS_BarthLogistic.Controls.FMGDateFilterControl();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.dgShesShek = new DevExpress.XtraGrid.GridControl();
            this.gvShesShek = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSulRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDgg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKoef = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShesShek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShesShek)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.fmgMomc);
            this.panel2.Controls.Add(this.fmgProdT);
            this.panel2.Controls.Add(this.fmgProdTG);
            this.panel2.Controls.Add(this.fmgProdG);
            this.panel2.Controls.Add(this.fmgProdS);
            this.panel2.Controls.Add(this.fmgData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 315);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFind);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(555, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 311);
            this.panel3.TabIndex = 18;
            // 
            // btnFind
            // 
            this.btnFind.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Appearance.Options.UseFont = true;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.Image = global::SBS_BarthLogistic.Properties.Resources.ImportWaybills;
            this.btnFind.Location = new System.Drawing.Point(0, 0);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(304, 44);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "ფილტრი";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // fmgMomc
            // 
            this.fmgMomc.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgMomc.Appearance.Options.UseFont = true;
            this.fmgMomc.FieldName = "Momc";
            this.fmgMomc.Location = new System.Drawing.Point(14, 220);
            this.fmgMomc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgMomc.Name = "fmgMomc";
            this.fmgMomc.ParameterName = null;
            this.fmgMomc.Size = new System.Drawing.Size(379, 30);
            this.fmgMomc.TabIndex = 17;
            this.fmgMomc.Text = "მომწოდებელი";
            // 
            // fmgProdT
            // 
            this.fmgProdT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdT.Appearance.Options.UseFont = true;
            this.fmgProdT.FieldName = "ProdT";
            this.fmgProdT.Location = new System.Drawing.Point(14, 142);
            this.fmgProdT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdT.Name = "fmgProdT";
            this.fmgProdT.ParameterName = null;
            this.fmgProdT.Size = new System.Drawing.Size(379, 30);
            this.fmgProdT.TabIndex = 16;
            this.fmgProdT.Text = "პროდ. ტიპი";
            // 
            // fmgProdTG
            // 
            this.fmgProdTG.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdTG.Appearance.Options.UseFont = true;
            this.fmgProdTG.FieldName = "ProdTG";
            this.fmgProdTG.Location = new System.Drawing.Point(14, 180);
            this.fmgProdTG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdTG.Name = "fmgProdTG";
            this.fmgProdTG.ParameterName = null;
            this.fmgProdTG.Size = new System.Drawing.Size(379, 30);
            this.fmgProdTG.TabIndex = 15;
            this.fmgProdTG.Text = "პროდ.ტიპ.ჯგ";
            // 
            // fmgProdG
            // 
            this.fmgProdG.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdG.Appearance.Options.UseFont = true;
            this.fmgProdG.FieldName = "ProdG";
            this.fmgProdG.Location = new System.Drawing.Point(14, 102);
            this.fmgProdG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdG.Name = "fmgProdG";
            this.fmgProdG.ParameterName = null;
            this.fmgProdG.Size = new System.Drawing.Size(423, 30);
            this.fmgProdG.TabIndex = 12;
            this.fmgProdG.Text = "პროდ. ჯგუფი";
            // 
            // fmgProdS
            // 
            this.fmgProdS.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdS.Appearance.Options.UseFont = true;
            this.fmgProdS.FieldName = "ProdS";
            this.fmgProdS.Location = new System.Drawing.Point(14, 70);
            this.fmgProdS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdS.Name = "fmgProdS";
            this.fmgProdS.ParameterName = null;
            this.fmgProdS.Size = new System.Drawing.Size(423, 30);
            this.fmgProdS.TabIndex = 11;
            this.fmgProdS.Text = "პროდ.სახეობა";
            // 
            // fmgData
            // 
            this.fmgData.AlwaysChecked = true;
            this.fmgData.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgData.Appearance.Options.UseFont = true;
            this.fmgData.Checked = true;
            this.fmgData.FieldName = "Data";
            this.fmgData.Location = new System.Drawing.Point(14, 30);
            this.fmgData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgData.Name = "fmgData";
            this.fmgData.ParameterName = "D";
            this.fmgData.Size = new System.Drawing.Size(379, 30);
            this.fmgData.TabIndex = 1;
            this.fmgData.Text = "თარიღი";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 703);
            
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 7);
            
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(759, 7);
            
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(653, 7);
            
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            // 
            // dgShesShek
            // 
            this.dgShesShek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgShesShek.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgShesShek.Location = new System.Drawing.Point(0, 315);
            this.dgShesShek.MainView = this.gvShesShek;
            this.dgShesShek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgShesShek.Name = "dgShesShek";
            this.dgShesShek.Size = new System.Drawing.Size(861, 388);
            this.dgShesShek.TabIndex = 35;
            this.dgShesShek.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShesShek});
            // 
            // gvShesShek
            // 
            this.gvShesShek.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvShesShek.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvShesShek.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProd,
            this.colRaod,
            this.colFasi,
            this.colMaxRaod,
            this.colSulRaod,
            this.colTanxa,
            this.colIdProd,
            this.colDgg,
            this.colKoef});
            this.gvShesShek.FooterPanelHeight = 1;
            this.gvShesShek.GridControl = this.dgShesShek;
            this.gvShesShek.GroupPanelText = "დაჯგუფება";
            this.gvShesShek.GroupRowHeight = 1;
            this.gvShesShek.Name = "gvShesShek";
            this.gvShesShek.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvShesShek.OptionsDetail.AllowZoomDetail = false;
            this.gvShesShek.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvShesShek.OptionsSelection.MultiSelect = true;
            this.gvShesShek.OptionsView.ColumnAutoWidth = false;
            this.gvShesShek.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvShesShek.OptionsView.ShowAutoFilterRow = true;
            this.gvShesShek.OptionsView.ShowDetailButtons = false;
            this.gvShesShek.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvShesShek.OptionsView.ShowFooter = true;
            this.gvShesShek.OptionsView.ShowGroupPanel = false;
            // 
            // colProd
            // 
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.OptionsColumn.AllowEdit = false;
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 173;
            // 
            // colRaod
            // 
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "{0:0.##}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRaod.FieldName = "Raod";
            this.colRaod.Name = "colRaod";
            this.colRaod.OptionsColumn.AllowEdit = false;
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Raod", "{0:#.##}")});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 127;
            // 
            // colFasi
            // 
            this.colFasi.Caption = "ფასი";
            this.colFasi.DisplayFormat.FormatString = "{0:0.00}";
            this.colFasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.OptionsColumn.AllowEdit = false;
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 5;
            this.colFasi.Width = 63;
            // 
            // colMaxRaod
            // 
            this.colMaxRaod.Caption = "მაქს.რაოდ";
            this.colMaxRaod.DisplayFormat.FormatString = "{0:0.00}";
            this.colMaxRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaxRaod.FieldName = "MaxRaod";
            this.colMaxRaod.Name = "colMaxRaod";
            this.colMaxRaod.Visible = true;
            this.colMaxRaod.VisibleIndex = 3;
            this.colMaxRaod.Width = 118;
            // 
            // colSulRaod
            // 
            this.colSulRaod.Caption = "შეკვეთილი იყო";
            this.colSulRaod.FieldName = "SulRaod";
            this.colSulRaod.Name = "colSulRaod";
            this.colSulRaod.Visible = true;
            this.colSulRaod.VisibleIndex = 4;
            this.colSulRaod.Width = 134;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "{0:0.00}";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.OptionsColumn.AllowEdit = false;
            this.colTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tanxa", "{0:#.00}")});
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 6;
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
            // colDgg
            // 
            this.colDgg.Caption = "დღგ";
            this.colDgg.FieldName = "Dgg";
            this.colDgg.Name = "colDgg";
            this.colDgg.OptionsColumn.AllowEdit = false;
            this.colDgg.Visible = true;
            this.colDgg.VisibleIndex = 7;
            // 
            // colKoef
            // 
            this.colKoef.Caption = "კოეფიციენტი";
            this.colKoef.FieldName = "Koef";
            this.colKoef.Name = "colKoef";
            this.colKoef.OptionsColumn.AllowEdit = false;
            this.colKoef.Visible = true;
            this.colKoef.VisibleIndex = 8;
            // 
            // GenerateMomcShekForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 753);
            this.Controls.Add(this.dgShesShek);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            
            this.Name = "GenerateMomcShekForm";
            this.Text = "მომწოდებელზე შეკვეთის იმპორტი შესყიდვაში";
            this.Load += new System.EventHandler(this.GenerateMomcShekToShesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgShesShek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShesShek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel2;
        private PanelControl panel1;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl dgShesShek;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShesShek;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colSulRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colDgg;
        private DevExpress.XtraGrid.Columns.GridColumn colKoef;
        private Controls.FMGDateFilterControl fmgData;
        private Controls.FMGComboFilterControl fmgProdG;
        private Controls.FMGComboFilterControl fmgProdS;
        private Controls.FMGComboFilterControl fmgMomc;
        private Controls.FMGComboFilterControl fmgProdT;
        private Controls.FMGComboFilterControl fmgProdTG;
        private System.Windows.Forms.Panel panel3;
        private SimpleButton btnFind;
    }
}