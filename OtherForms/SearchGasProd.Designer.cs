namespace SBS_BarthLogistic.OtherForms
{
    partial class SearchGasProd
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
            this.dgShem2 = new DevExpress.XtraGrid.GridControl();
            this.gvShem2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdShem2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProekSectorZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaodInBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomClearanceMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompRaodTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNashti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgShem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShem2
            // 
            this.dgShem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgShem2.Location = new System.Drawing.Point(0, 0);
            this.dgShem2.MainView = this.gvShem2;
            this.dgShem2.Name = "dgShem2";
            this.dgShem2.Size = new System.Drawing.Size(800, 395);
            this.dgShem2.TabIndex = 2;
            this.dgShem2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShem2});
            this.dgShem2.DoubleClick += new System.EventHandler(this.DgGas2_DoubleClick);
            // 
            // gvShem2
            // 
            this.gvShem2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdShem2,
            this.colIdProd,
            this.colProd,
            this.colPalet,
            this.colProekSector,
            this.colProekSectorZone,
            this.colPartNumber,
            this.colFasi,
            this.colData,
            this.colCompRaod,
            this.colRaodInBox,
            this.colWeight,
            this.colAnumber,
            this.colCnumber,
            this.colShen,
            this.colUnit,
            this.colCustomClearanceMode,
            this.colValuta,
            this.colCompRaodTotal,
            this.colTanxa,
            this.colNashti});
            this.gvShem2.DetailHeight = 284;
            this.gvShem2.FooterPanelHeight = 1;
            this.gvShem2.GridControl = this.dgShem2;
            this.gvShem2.GroupPanelText = "დაჯგუფება";
            this.gvShem2.GroupRowHeight = 1;
            this.gvShem2.Name = "gvShem2";
            this.gvShem2.OptionsBehavior.Editable = false;
            this.gvShem2.OptionsDetail.AllowZoomDetail = false;
            this.gvShem2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvShem2.OptionsView.ColumnAutoWidth = false;
            this.gvShem2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvShem2.OptionsView.ShowDetailButtons = false;
            this.gvShem2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvShem2.OptionsView.ShowFooter = true;
            this.gvShem2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdShem2
            // 
            this.colIdShem2.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colIdShem2.AppearanceHeader.Options.UseFont = true;
            this.colIdShem2.Caption = "IdShem2";
            this.colIdShem2.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colIdShem2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIdShem2.FieldName = "IdShem2";
            this.colIdShem2.MinWidth = 17;
            this.colIdShem2.Name = "colIdShem2";
            this.colIdShem2.Width = 64;
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
            this.colIdProd.VisibleIndex = 3;
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
            this.colProd.VisibleIndex = 4;
            this.colProd.Width = 148;
            // 
            // colPalet
            // 
            this.colPalet.Caption = "პალეტი";
            this.colPalet.FieldName = "Palet";
            this.colPalet.Name = "colPalet";
            this.colPalet.Visible = true;
            this.colPalet.VisibleIndex = 9;
            this.colPalet.Width = 73;
            // 
            // colProekSector
            // 
            this.colProekSector.Caption = "შენობა";
            this.colProekSector.FieldName = "ProekSector";
            this.colProekSector.Name = "colProekSector";
            this.colProekSector.Visible = true;
            this.colProekSector.VisibleIndex = 1;
            // 
            // colProekSectorZone
            // 
            this.colProekSectorZone.Caption = "ლოკაცია";
            this.colProekSectorZone.FieldName = "ProekSectorZone";
            this.colProekSectorZone.Name = "colProekSectorZone";
            this.colProekSectorZone.Visible = true;
            this.colProekSectorZone.VisibleIndex = 2;
            // 
            // colPartNumber
            // 
            this.colPartNumber.Caption = "არტიკული(PartNumber)";
            this.colPartNumber.FieldName = "PartNumber";
            this.colPartNumber.Name = "colPartNumber";
            this.colPartNumber.Visible = true;
            this.colPartNumber.VisibleIndex = 10;
            this.colPartNumber.Width = 137;
            // 
            // colFasi
            // 
            this.colFasi.Caption = "ფასი";
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 6;
            // 
            // colData
            // 
            this.colData.Caption = "თარიღი";
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            // 
            // colCompRaod
            // 
            this.colCompRaod.Caption = "კომპლექტი";
            this.colCompRaod.FieldName = "CompRaod";
            this.colCompRaod.Name = "colCompRaod";
            this.colCompRaod.Visible = true;
            this.colCompRaod.VisibleIndex = 11;
            // 
            // colRaodInBox
            // 
            this.colRaodInBox.Caption = "რაოდენობა ყუშთი";
            this.colRaodInBox.FieldName = "RaodInBox";
            this.colRaodInBox.Name = "colRaodInBox";
            this.colRaodInBox.Visible = true;
            this.colRaodInBox.VisibleIndex = 12;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "წონა";
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 13;
            // 
            // colAnumber
            // 
            this.colAnumber.Caption = "A ნომერი";
            this.colAnumber.FieldName = "Anumber";
            this.colAnumber.Name = "colAnumber";
            this.colAnumber.Visible = true;
            this.colAnumber.VisibleIndex = 14;
            // 
            // colCnumber
            // 
            this.colCnumber.Caption = "C ნომერი";
            this.colCnumber.FieldName = "Cnumber";
            this.colCnumber.Name = "colCnumber";
            this.colCnumber.Visible = true;
            this.colCnumber.VisibleIndex = 15;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 16;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "ერთეული";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 17;
            // 
            // colCustomClearanceMode
            // 
            this.colCustomClearanceMode.Caption = "რეჟიმი";
            this.colCustomClearanceMode.FieldName = "CustomClearanceMode";
            this.colCustomClearanceMode.Name = "colCustomClearanceMode";
            this.colCustomClearanceMode.Visible = true;
            this.colCustomClearanceMode.VisibleIndex = 18;
            // 
            // colValuta
            // 
            this.colValuta.Caption = "ვალუტა";
            this.colValuta.Name = "colValuta";
            this.colValuta.Visible = true;
            this.colValuta.VisibleIndex = 7;
            // 
            // colCompRaodTotal
            // 
            this.colCompRaodTotal.Caption = "ყუთების ჯამური რაოდ";
            this.colCompRaodTotal.FieldName = "CompRaodTotal";
            this.colCompRaodTotal.Name = "colCompRaodTotal";
            this.colCompRaodTotal.Visible = true;
            this.colCompRaodTotal.VisibleIndex = 19;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "##.00";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tanxa", "{0:##.00}")});
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 8;
            // 
            // colNashti
            // 
            this.colNashti.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
            this.colNashti.AppearanceHeader.Options.UseForeColor = true;
            this.colNashti.Caption = "ნაშთი";
            this.colNashti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNashti.FieldName = "Nashti";
            this.colNashti.Name = "colNashti";
            this.colNashti.Visible = true;
            this.colNashti.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnOk);
            this.panelControl1.Controls.Add(this.txtProdName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 395);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 55);
            this.panelControl1.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.apply_16x16;
            this.btnOk.Location = new System.Drawing.Point(583, 19);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(13, 22);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(325, 20);
            this.txtProdName.TabIndex = 2;
            this.txtProdName.EditValueChanged += new System.EventHandler(this.txtProdName_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(321, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "საკვანძო სიტყვა (დასახელება | შტრიხ კოდი | არტიკული)";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = global::SBS_BarthLogistic.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(664, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            // 
            // SearchGasProd
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgShem2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SearchGasProd";
            this.ShowIcon = false;
            this.Text = "ძებნა";
            ((System.ComponentModel.ISupportInitialize)(this.dgShem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvShem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgShem2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvShem2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdShem2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colPalet;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSector;
        private DevExpress.XtraGrid.Columns.GridColumn colProekSectorZone;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtProdName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colCompRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colRaodInBox;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colAnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomClearanceMode;
        private DevExpress.XtraGrid.Columns.GridColumn colValuta;
        private DevExpress.XtraGrid.Columns.GridColumn colCompRaodTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Columns.GridColumn colNashti;
    }
}