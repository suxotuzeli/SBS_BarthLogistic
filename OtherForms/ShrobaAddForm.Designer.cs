using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class ShrobaAddForm
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
            this.dgDet = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdModz2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGasRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.cbGasT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.label23 = new DevExpress.XtraEditors.LabelControl();
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.cbProek = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGasT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDet
            // 
            this.dgDet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgDet.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDet.Location = new System.Drawing.Point(0, 228);
            this.dgDet.MainView = this.gridView2;
            this.dgDet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgDet.Name = "dgDet";
            this.dgDet.Size = new System.Drawing.Size(731, 325);
            this.dgDet.TabIndex = 74;
            this.dgDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdModz2,
            this.colRaod,
            this.colProd,
            this.colGasRaod,
            this.colIdProd});
            this.gridView2.FooterPanelHeight = 1;
            this.gridView2.GridControl = this.dgDet;
            this.gridView2.GroupPanelText = "დაჯგუფება";
            this.gridView2.GroupRowHeight = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.AllowZoomDetail = false;
            this.gridView2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdModz2
            // 
            this.colIdModz2.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.colIdModz2.AppearanceHeader.Options.UseFont = true;
            this.colIdModz2.Caption = "კოდი";
            this.colIdModz2.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss";
            this.colIdModz2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIdModz2.FieldName = "IdModz2";
            this.colIdModz2.Name = "colIdModz2";
            // 
            // colRaod
            // 
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "0.##";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRaod.FieldName = "Raod";
            this.colRaod.Name = "colRaod";
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 119;
            // 
            // colProd
            // 
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 241;
            // 
            // colGasRaod
            // 
            this.colGasRaod.Caption = "შრობის რაოდენობა";
            this.colGasRaod.DisplayFormat.FormatString = "0.##";
            this.colGasRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGasRaod.FieldName = "GasRaod";
            this.colGasRaod.Name = "colGasRaod";
            this.colGasRaod.Visible = true;
            this.colGasRaod.VisibleIndex = 3;
            this.colGasRaod.Width = 124;
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "პროდ. კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            this.colIdProd.Width = 115;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 48);
            this.panel1.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(619, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(512, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 37);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(12, 175);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(700, 26);
            this.txtShen.TabIndex = 4;
            // 
            // cbGasT
            // 
            this.cbGasT.Location = new System.Drawing.Point(12, 109);
            this.cbGasT.Name = "cbGasT";
            this.cbGasT.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGasT.Properties.Appearance.Options.UseFont = true;
            this.cbGasT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGasT.Size = new System.Drawing.Size(700, 26);
            this.cbGasT.TabIndex = 3;
            // 
            // txtData
            // 
            this.txtData.EditValue = "1.1.2010";
            this.txtData.Location = new System.Drawing.Point(12, 35);
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
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "გატანის ტიპი";
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 98;
            this.label7.Text = "თარიღი";
            // 
            // label23
            // 
            this.label23.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(155, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 19);
            this.label23.TabIndex = 94;
            this.label23.Text = "ზედდებული";
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(159, 35);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(182, 26);
            this.txtZedd.TabIndex = 1;
            this.txtZedd.Leave += new System.EventHandler(this.txtZedd_Leave_1);
            // 
            // cbProek
            // 
            this.cbProek.Location = new System.Drawing.Point(374, 35);
            this.cbProek.Name = "cbProek";
            this.cbProek.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProek.Properties.Appearance.Options.UseFont = true;
            this.cbProek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProek.Size = new System.Drawing.Size(338, 26);
            this.cbProek.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 102;
            this.label4.Text = "საწყობი";
            // 
            // ShrobaAddForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(731, 601);
            this.Controls.Add(this.cbProek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGasT);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtZedd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShen);
            this.Controls.Add(this.dgDet);
            this.Controls.Add(this.panel1);
            this.Name = "ShrobaAddForm";
            this.ShowIcon = false;
            this.Text = "პროდუქციაზე შრობის დარიცხვა";
            this.Load += new System.EventHandler(this.ShrobaAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGasT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProek.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgDet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdModz2;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private PanelControl panel1;
        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private LabelControl label1;
        private TextEdit txtShen;
        private DevExpress.XtraEditors.LookUpEdit cbGasT;
        private DateEdit txtData;
        private LabelControl label3;
        private LabelControl label7;
        private LabelControl label23;
        private TextEdit txtZedd;
        private DevExpress.XtraEditors.LookUpEdit cbProek;
        private LabelControl label4;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colGasRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
    }
}