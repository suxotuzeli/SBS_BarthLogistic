using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace SBS_BarthLogistic.FindForms
{
    partial class FGvariForm
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDialog = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtLocate = new DevExpress.XtraEditors.TextEdit();
            this.dgGvari = new DevExpress.XtraGrid.GridControl();
            this.gvGvari = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGvari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSagad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGvariT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGvari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGvari)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddDialog);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtLocate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 58);
            this.panel1.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(1034, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 39);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(824, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDialog
            // 
            this.btnAddDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDialog.Location = new System.Drawing.Point(929, 11);
            this.btnAddDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddDialog.Name = "btnAddDialog";
            this.btnAddDialog.Size = new System.Drawing.Size(99, 39);
            this.btnAddDialog.TabIndex = 5;
            this.btnAddDialog.Text = "&Add";
            this.btnAddDialog.Click += new System.EventHandler(this.btnAddDialog_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(719, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtLocate
            // 
            this.txtLocate.Location = new System.Drawing.Point(15, 10);
            this.txtLocate.Name = "txtLocate";
            this.txtLocate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLocate.Properties.Appearance.Options.UseFont = true;
            this.txtLocate.Size = new System.Drawing.Size(291, 36);
            this.txtLocate.TabIndex = 0;
            this.txtLocate.TextChanged += new System.EventHandler(this.txtLocate_TextChanged);
            this.txtLocate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocate_KeyDown);
            // 
            // dgGvari
            // 
            this.dgGvari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGvari.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgGvari.Location = new System.Drawing.Point(0, 0);
            this.dgGvari.MainView = this.gvGvari;
            this.dgGvari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgGvari.Name = "dgGvari";
            this.dgGvari.Size = new System.Drawing.Size(1137, 430);
            this.dgGvari.TabIndex = 9;
            this.dgGvari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGvari});
            // 
            // gvGvari
            // 
            this.gvGvari.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvGvari.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvGvari.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGvari,
            this.colProd,
            this.colSagad,
            this.colFG,
            this.colAddress,
            this.colDisc1,
            this.colGvariT});
            this.gvGvari.FooterPanelHeight = 1;
            this.gvGvari.GridControl = this.dgGvari;
            this.gvGvari.GroupPanelText = "დაჯგუფება";
            this.gvGvari.GroupRowHeight = 1;
            this.gvGvari.Name = "gvGvari";
            this.gvGvari.OptionsBehavior.Editable = false;
            this.gvGvari.OptionsCustomization.AllowGroup = false;
            this.gvGvari.OptionsDetail.AllowZoomDetail = false;
            this.gvGvari.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvGvari.OptionsSelection.MultiSelect = true;
            this.gvGvari.OptionsView.ColumnAutoWidth = false;
            this.gvGvari.OptionsView.EnableAppearanceOddRow = true;
            this.gvGvari.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvGvari.OptionsView.ShowAutoFilterRow = true;
            this.gvGvari.OptionsView.ShowDetailButtons = false;
            this.gvGvari.OptionsView.ShowFooter = true;
            this.gvGvari.OptionsView.ShowGroupPanel = false;
            this.gvGvari.ColumnPositionChanged += new System.EventHandler(this.gvGvari_ColumnPositionChanged);
            // 
            // colIdGvari
            // 
            this.colIdGvari.Caption = "კოდი";
            this.colIdGvari.FieldName = "IdGvari";
            this.colIdGvari.Name = "colIdGvari";
            this.colIdGvari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "idOrg", "")});
            this.colIdGvari.Visible = true;
            this.colIdGvari.VisibleIndex = 0;
            this.colIdGvari.Width = 134;
            // 
            // colProd
            // 
            this.colProd.Caption = "დასახელება";
            this.colProd.FieldName = "Gvari";
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 287;
            // 
            // colSagad
            // 
            this.colSagad.Caption = "საიდ. კოდი";
            this.colSagad.FieldName = "Sagad";
            this.colSagad.Name = "colSagad";
            this.colSagad.Visible = true;
            this.colSagad.VisibleIndex = 2;
            this.colSagad.Width = 159;
            // 
            // colFG
            // 
            this.colFG.Caption = "ფასთა ჯგუფი";
            this.colFG.DisplayFormat.FormatString = "{0:0.00##}";
            this.colFG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFG.FieldName = "FG";
            this.colFG.Name = "colFG";
            this.colFG.Visible = true;
            this.colFG.VisibleIndex = 3;
            this.colFG.Width = 148;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 127;
            // 
            // colDisc1
            // 
            this.colDisc1.Caption = "ფასდაკლება";
            this.colDisc1.FieldName = "Disc1";
            this.colDisc1.Name = "colDisc1";
            this.colDisc1.Visible = true;
            this.colDisc1.VisibleIndex = 5;
            this.colDisc1.Width = 129;
            // 
            // colGvariT
            // 
            this.colGvariT.Caption = "ორგანიზაციის ტიპი";
            this.colGvariT.FieldName = "GvariT";
            this.colGvariT.Name = "colGvariT";
            this.colGvariT.Visible = true;
            this.colGvariT.VisibleIndex = 6;
            this.colGvariT.Width = 124;
            // 
            // FGvariForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1137, 488);
            this.Controls.Add(this.dgGvari);
            this.Controls.Add(this.panel1);
            this.Name = "FGvariForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ორგანიზაციის ძებნა";
            this.Activated += new System.EventHandler(this.FGvariForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FGvariForm_FormClosing);
            this.Load += new System.EventHandler(this.FGvariForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLocate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGvari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGvari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panel1;
        private SimpleButton btnCancel;
        private SimpleButton btnAddDialog;
        private SimpleButton btnOK;
        private TextEdit txtLocate;
        private GridControl dgGvari;
        private GridView gvGvari;
        private GridColumn colIdGvari;
        private GridColumn colProd;
        private GridColumn colSagad;
        private GridColumn colFG;
        private GridColumn colAddress;
        private GridColumn colDisc1;
        private GridColumn colGvariT;
        private SimpleButton btnEdit;
    }
}