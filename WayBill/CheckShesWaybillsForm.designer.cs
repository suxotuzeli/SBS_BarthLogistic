using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.WayBill
{
    partial class CheckShesWaybillsForm
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

        #region Windows XtraForm Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.gbZeddType = new DevExpress.XtraEditors.GroupControl();
            this.chb6 = new DevExpress.XtraEditors.CheckEdit();
            this.chb5 = new DevExpress.XtraEditors.CheckEdit();
            this.chb4 = new DevExpress.XtraEditors.CheckEdit();
            this.chb3 = new DevExpress.XtraEditors.CheckEdit();
            this.chb2 = new DevExpress.XtraEditors.CheckEdit();
            this.chb1 = new DevExpress.XtraEditors.CheckEdit();
            this.txtComment = new DevExpress.XtraEditors.TextEdit();
            this.chbComment = new DevExpress.XtraEditors.CheckEdit();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportWaybills = new DevExpress.XtraEditors.SimpleButton();
            this.txtTanxa = new DevExpress.XtraEditors.TextEdit();
            this.chbTanxa = new DevExpress.XtraEditors.CheckEdit();
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.chbZedd = new DevExpress.XtraEditors.CheckEdit();
            this.txtSagad = new DevExpress.XtraEditors.TextEdit();
            this.chbSagad = new DevExpress.XtraEditors.CheckEdit();
            this.txtMan = new DevExpress.XtraEditors.TextEdit();
            this.chbMan = new DevExpress.XtraEditors.CheckEdit();
            this.txtPiradiNom = new DevExpress.XtraEditors.TextEdit();
            this.txtDataBegin2 = new DevExpress.XtraEditors.DateEdit();
            this.txtDataBegin1 = new DevExpress.XtraEditors.DateEdit();
            this.chbDataBegin = new DevExpress.XtraEditors.CheckEdit();
            this.txtDataClose2 = new DevExpress.XtraEditors.DateEdit();
            this.txtDataClose1 = new DevExpress.XtraEditors.DateEdit();
            this.chbDataClose = new DevExpress.XtraEditors.CheckEdit();
            this.txtDataDelivery2 = new DevExpress.XtraEditors.DateEdit();
            this.txtDataDelivery1 = new DevExpress.XtraEditors.DateEdit();
            this.chbDataDelivery = new DevExpress.XtraEditors.CheckEdit();
            this.txtDataCreate2 = new DevExpress.XtraEditors.DateEdit();
            this.txtDataCreate1 = new DevExpress.XtraEditors.DateEdit();
            this.chbDataCreate = new DevExpress.XtraEditors.CheckEdit();
            this.chbPiradiNom = new DevExpress.XtraEditors.CheckEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgReal1 = new DevExpress.XtraGrid.GridControl();
            this.cmExcel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.gvReal1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_CONFIRMED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELLER_TIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELLER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRIVER_TIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANSPORT_COAST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECEPTION_INFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECEIVER_INFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDELIVERY_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVATE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TANXA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAR_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAYBILL_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colS_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBEGIN_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAYBILL_COMMENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgRealRs = new DevExpress.XtraGrid.GridControl();
            this.gvRealRs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsBAR_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsW_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsVAT_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_TXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgReal2 = new DevExpress.XtraGrid.GridControl();
            this.gvReal2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdReal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbZeddType)).BeginInit();
            this.gbZeddType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chb6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTanxa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSagad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiradiNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataDelivery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPiradiNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReal1)).BeginInit();
            this.cmExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRealRs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRealRs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbZeddType);
            this.panel2.Controls.Add(this.txtComment);
            this.panel2.Controls.Add(this.chbComment);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtTanxa);
            this.panel2.Controls.Add(this.chbTanxa);
            this.panel2.Controls.Add(this.txtZedd);
            this.panel2.Controls.Add(this.chbZedd);
            this.panel2.Controls.Add(this.txtSagad);
            this.panel2.Controls.Add(this.chbSagad);
            this.panel2.Controls.Add(this.txtMan);
            this.panel2.Controls.Add(this.chbMan);
            this.panel2.Controls.Add(this.txtPiradiNom);
            this.panel2.Controls.Add(this.txtDataBegin2);
            this.panel2.Controls.Add(this.txtDataBegin1);
            this.panel2.Controls.Add(this.chbDataBegin);
            this.panel2.Controls.Add(this.txtDataClose2);
            this.panel2.Controls.Add(this.txtDataClose1);
            this.panel2.Controls.Add(this.chbDataClose);
            this.panel2.Controls.Add(this.txtDataDelivery2);
            this.panel2.Controls.Add(this.txtDataDelivery1);
            this.panel2.Controls.Add(this.chbDataDelivery);
            this.panel2.Controls.Add(this.txtDataCreate2);
            this.panel2.Controls.Add(this.txtDataCreate1);
            this.panel2.Controls.Add(this.chbDataCreate);
            this.panel2.Controls.Add(this.chbPiradiNom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1483, 213);
            this.panel2.TabIndex = 0;
            // 
            // gbZeddType
            // 
            this.gbZeddType.AppearanceCaption.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbZeddType.AppearanceCaption.Options.UseFont = true;
            this.gbZeddType.Controls.Add(this.chb6);
            this.gbZeddType.Controls.Add(this.chb5);
            this.gbZeddType.Controls.Add(this.chb4);
            this.gbZeddType.Controls.Add(this.chb3);
            this.gbZeddType.Controls.Add(this.chb2);
            this.gbZeddType.Controls.Add(this.chb1);
            this.gbZeddType.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbZeddType.Location = new System.Drawing.Point(1044, 2);
            this.gbZeddType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbZeddType.Name = "gbZeddType";
            this.gbZeddType.Size = new System.Drawing.Size(255, 209);
            this.gbZeddType.TabIndex = 24;
            this.gbZeddType.Text = "ზედნადების ტიპი";
            // 
            // chb6
            // 
            this.chb6.Location = new System.Drawing.Point(15, 171);
            this.chb6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb6.Name = "chb6";
            this.chb6.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chb6.Properties.Appearance.Options.UseFont = true;
            this.chb6.Properties.AutoWidth = true;
            this.chb6.Properties.Caption = "6 ქვეზედნადები";
            this.chb6.Size = new System.Drawing.Size(136, 23);
            this.chb6.TabIndex = 5;
            this.chb6.Tag = "6";
            // 
            // chb5
            // 
            this.chb5.Location = new System.Drawing.Point(15, 142);
            this.chb5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb5.Name = "chb5";
            this.chb5.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chb5.Properties.Appearance.Options.UseFont = true;
            this.chb5.Properties.AutoWidth = true;
            this.chb5.Properties.Caption = "5 უკან დაბრუნება";
            this.chb5.Size = new System.Drawing.Size(147, 23);
            this.chb5.TabIndex = 4;
            this.chb5.Tag = "5";
            // 
            // chb4
            // 
            this.chb4.Location = new System.Drawing.Point(15, 113);
            this.chb4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb4.Name = "chb4";
            this.chb4.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chb4.Properties.Appearance.Options.UseFont = true;
            this.chb4.Properties.AutoWidth = true;
            this.chb4.Properties.Caption = "4 დისტრიბუცია";
            this.chb4.Size = new System.Drawing.Size(135, 23);
            this.chb4.TabIndex = 3;
            this.chb4.Tag = "4";
            // 
            // chb3
            // 
            this.chb3.Location = new System.Drawing.Point(15, 84);
            this.chb3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb3.Name = "chb3";
            this.chb3.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chb3.Properties.Appearance.Options.UseFont = true;
            this.chb3.Properties.AutoWidth = true;
            this.chb3.Properties.Caption = "3 ტრანსპორტირების გარეშე";
            this.chb3.Size = new System.Drawing.Size(219, 23);
            this.chb3.TabIndex = 2;
            this.chb3.Tag = "3";
            // 
            // chb2
            // 
            this.chb2.Location = new System.Drawing.Point(15, 55);
            this.chb2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb2.Name = "chb2";
            this.chb2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chb2.Properties.Appearance.Options.UseFont = true;
            this.chb2.Properties.AutoWidth = true;
            this.chb2.Properties.Caption = "2 ტრანსპორტირებით";
            this.chb2.Size = new System.Drawing.Size(173, 23);
            this.chb2.TabIndex = 1;
            this.chb2.Tag = "2";
            // 
            // chb1
            // 
            this.chb1.Location = new System.Drawing.Point(15, 26);
            this.chb1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb1.Name = "chb1";
            this.chb1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chb1.Properties.Appearance.Options.UseFont = true;
            this.chb1.Properties.AutoWidth = true;
            this.chb1.Properties.Caption = "1 შიდა გადაზიდვა";
            this.chb1.Size = new System.Drawing.Size(151, 23);
            this.chb1.TabIndex = 0;
            this.chb1.Tag = "1";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(178, 134);
            this.txtComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComment.Name = "txtComment";
            this.txtComment.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Properties.Appearance.Options.UseFont = true;
            this.txtComment.Size = new System.Drawing.Size(215, 26);
            this.txtComment.TabIndex = 13;
            this.txtComment.Visible = false;
            // 
            // chbComment
            // 
            this.chbComment.Location = new System.Drawing.Point(17, 134);
            this.chbComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbComment.Name = "chbComment";
            this.chbComment.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbComment.Properties.Appearance.Options.UseFont = true;
            this.chbComment.Properties.AutoWidth = true;
            this.chbComment.Properties.Caption = "კომენტარი";
            this.chbComment.Size = new System.Drawing.Size(98, 23);
            this.chbComment.TabIndex = 12;
            this.chbComment.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnImportWaybills);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1299, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 209);
            this.panel1.TabIndex = 25;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfirm.Image = global::SBS_BarthLogistic.Properties.Resources.Confirm;
            this.btnConfirm.Location = new System.Drawing.Point(2, 90);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(178, 44);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "დადასტურება";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnImport
            // 
            this.btnImport.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.Image = global::SBS_BarthLogistic.Properties.Resources.ExportReal;
            this.btnImport.Location = new System.Drawing.Point(2, 46);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(178, 44);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "იმპორტი";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnClose.Location = new System.Drawing.Point(2, 160);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 47);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "დახურვა";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImportWaybills
            // 
            this.btnImportWaybills.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImportWaybills.Appearance.Options.UseFont = true;
            this.btnImportWaybills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportWaybills.Image = global::SBS_BarthLogistic.Properties.Resources.ImportWaybills;
            this.btnImportWaybills.Location = new System.Drawing.Point(2, 2);
            this.btnImportWaybills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportWaybills.Name = "btnImportWaybills";
            this.btnImportWaybills.Size = new System.Drawing.Size(178, 44);
            this.btnImportWaybills.TabIndex = 0;
            this.btnImportWaybills.Text = "ფილტრი";
            this.btnImportWaybills.Click += new System.EventHandler(this.btnImportWaybills_Click);
            // 
            // txtTanxa
            // 
            this.txtTanxa.Location = new System.Drawing.Point(577, 134);
            this.txtTanxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTanxa.Name = "txtTanxa";
            this.txtTanxa.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTanxa.Properties.Appearance.Options.UseFont = true;
            this.txtTanxa.Size = new System.Drawing.Size(170, 26);
            this.txtTanxa.TabIndex = 23;
            this.txtTanxa.Visible = false;
            // 
            // chbTanxa
            // 
            this.chbTanxa.Location = new System.Drawing.Point(400, 134);
            this.chbTanxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbTanxa.Name = "chbTanxa";
            this.chbTanxa.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTanxa.Properties.Appearance.Options.UseFont = true;
            this.chbTanxa.Properties.AutoWidth = true;
            this.chbTanxa.Properties.Caption = "ზედდებულის თანხა";
            this.chbTanxa.Size = new System.Drawing.Size(167, 23);
            this.chbTanxa.TabIndex = 22;
            this.chbTanxa.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(577, 103);
            this.txtZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(170, 26);
            this.txtZedd.TabIndex = 21;
            this.txtZedd.Visible = false;
            // 
            // chbZedd
            // 
            this.chbZedd.Location = new System.Drawing.Point(400, 103);
            this.chbZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbZedd.Name = "chbZedd";
            this.chbZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbZedd.Properties.Appearance.Options.UseFont = true;
            this.chbZedd.Properties.AutoWidth = true;
            this.chbZedd.Properties.Caption = "ზედდებულის #";
            this.chbZedd.Size = new System.Drawing.Size(134, 23);
            this.chbZedd.TabIndex = 20;
            this.chbZedd.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // txtSagad
            // 
            this.txtSagad.Location = new System.Drawing.Point(577, 76);
            this.txtSagad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSagad.Name = "txtSagad";
            this.txtSagad.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSagad.Properties.Appearance.Options.UseFont = true;
            this.txtSagad.Size = new System.Drawing.Size(170, 26);
            this.txtSagad.TabIndex = 19;
            this.txtSagad.Visible = false;
            // 
            // chbSagad
            // 
            this.chbSagad.Location = new System.Drawing.Point(400, 75);
            this.chbSagad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSagad.Name = "chbSagad";
            this.chbSagad.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSagad.Properties.Appearance.Options.UseFont = true;
            this.chbSagad.Properties.AutoWidth = true;
            this.chbSagad.Properties.Caption = "მომწ-ის საიდ.კოდი";
            this.chbSagad.Size = new System.Drawing.Size(160, 23);
            this.chbSagad.TabIndex = 18;
            this.chbSagad.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // txtMan
            // 
            this.txtMan.Location = new System.Drawing.Point(577, 47);
            this.txtMan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMan.Name = "txtMan";
            this.txtMan.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMan.Properties.Appearance.Options.UseFont = true;
            this.txtMan.Size = new System.Drawing.Size(170, 26);
            this.txtMan.TabIndex = 17;
            this.txtMan.Visible = false;
            // 
            // chbMan
            // 
            this.chbMan.Location = new System.Drawing.Point(400, 47);
            this.chbMan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMan.Name = "chbMan";
            this.chbMan.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMan.Properties.Appearance.Options.UseFont = true;
            this.chbMan.Properties.AutoWidth = true;
            this.chbMan.Properties.Caption = "მანქანის #";
            this.chbMan.Size = new System.Drawing.Size(93, 23);
            this.chbMan.TabIndex = 16;
            this.chbMan.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // txtPiradiNom
            // 
            this.txtPiradiNom.Location = new System.Drawing.Point(577, 20);
            this.txtPiradiNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPiradiNom.Name = "txtPiradiNom";
            this.txtPiradiNom.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiradiNom.Properties.Appearance.Options.UseFont = true;
            this.txtPiradiNom.Size = new System.Drawing.Size(170, 26);
            this.txtPiradiNom.TabIndex = 15;
            this.txtPiradiNom.Visible = false;
            // 
            // txtDataBegin2
            // 
            this.txtDataBegin2.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataBegin2.Location = new System.Drawing.Point(289, 47);
            this.txtDataBegin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataBegin2.Name = "txtDataBegin2";
            this.txtDataBegin2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBegin2.Properties.Appearance.Options.UseFont = true;
            this.txtDataBegin2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataBegin2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataBegin2.Size = new System.Drawing.Size(104, 26);
            this.txtDataBegin2.TabIndex = 5;
            this.txtDataBegin2.Visible = false;
            // 
            // txtDataBegin1
            // 
            this.txtDataBegin1.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataBegin1.Location = new System.Drawing.Point(178, 47);
            this.txtDataBegin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataBegin1.Name = "txtDataBegin1";
            this.txtDataBegin1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBegin1.Properties.Appearance.Options.UseFont = true;
            this.txtDataBegin1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataBegin1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataBegin1.Size = new System.Drawing.Size(104, 26);
            this.txtDataBegin1.TabIndex = 4;
            this.txtDataBegin1.Visible = false;
            // 
            // chbDataBegin
            // 
            this.chbDataBegin.Location = new System.Drawing.Point(17, 47);
            this.chbDataBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDataBegin.Name = "chbDataBegin";
            this.chbDataBegin.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDataBegin.Properties.Appearance.Options.UseFont = true;
            this.chbDataBegin.Properties.AutoWidth = true;
            this.chbDataBegin.Properties.Caption = "ტრანსპ. თარიღი";
            this.chbDataBegin.Size = new System.Drawing.Size(138, 23);
            this.chbDataBegin.TabIndex = 3;
            this.chbDataBegin.CheckedChanged += new System.EventHandler(this.chbDataCreate_CheckedChanged);
            // 
            // txtDataClose2
            // 
            this.txtDataClose2.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataClose2.Location = new System.Drawing.Point(289, 103);
            this.txtDataClose2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataClose2.Name = "txtDataClose2";
            this.txtDataClose2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataClose2.Properties.Appearance.Options.UseFont = true;
            this.txtDataClose2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataClose2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataClose2.Size = new System.Drawing.Size(104, 26);
            this.txtDataClose2.TabIndex = 11;
            this.txtDataClose2.Visible = false;
            // 
            // txtDataClose1
            // 
            this.txtDataClose1.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataClose1.Location = new System.Drawing.Point(178, 103);
            this.txtDataClose1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataClose1.Name = "txtDataClose1";
            this.txtDataClose1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataClose1.Properties.Appearance.Options.UseFont = true;
            this.txtDataClose1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataClose1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataClose1.Size = new System.Drawing.Size(104, 26);
            this.txtDataClose1.TabIndex = 10;
            this.txtDataClose1.Visible = false;
            // 
            // chbDataClose
            // 
            this.chbDataClose.Location = new System.Drawing.Point(17, 103);
            this.chbDataClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDataClose.Name = "chbDataClose";
            this.chbDataClose.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDataClose.Properties.Appearance.Options.UseFont = true;
            this.chbDataClose.Properties.AutoWidth = true;
            this.chbDataClose.Properties.Caption = "დახურვის თარიღი";
            this.chbDataClose.Size = new System.Drawing.Size(155, 23);
            this.chbDataClose.TabIndex = 9;
            this.chbDataClose.CheckedChanged += new System.EventHandler(this.chbDataCreate_CheckedChanged);
            // 
            // txtDataDelivery2
            // 
            this.txtDataDelivery2.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataDelivery2.Location = new System.Drawing.Point(289, 76);
            this.txtDataDelivery2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataDelivery2.Name = "txtDataDelivery2";
            this.txtDataDelivery2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDelivery2.Properties.Appearance.Options.UseFont = true;
            this.txtDataDelivery2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataDelivery2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataDelivery2.Size = new System.Drawing.Size(104, 26);
            this.txtDataDelivery2.TabIndex = 8;
            this.txtDataDelivery2.Visible = false;
            // 
            // txtDataDelivery1
            // 
            this.txtDataDelivery1.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataDelivery1.Location = new System.Drawing.Point(178, 76);
            this.txtDataDelivery1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataDelivery1.Name = "txtDataDelivery1";
            this.txtDataDelivery1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataDelivery1.Properties.Appearance.Options.UseFont = true;
            this.txtDataDelivery1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataDelivery1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataDelivery1.Size = new System.Drawing.Size(104, 26);
            this.txtDataDelivery1.TabIndex = 7;
            this.txtDataDelivery1.Visible = false;
            // 
            // chbDataDelivery
            // 
            this.chbDataDelivery.Location = new System.Drawing.Point(17, 75);
            this.chbDataDelivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDataDelivery.Name = "chbDataDelivery";
            this.chbDataDelivery.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDataDelivery.Properties.Appearance.Options.UseFont = true;
            this.chbDataDelivery.Properties.AutoWidth = true;
            this.chbDataDelivery.Properties.Caption = "მიტანის თარიღი";
            this.chbDataDelivery.Size = new System.Drawing.Size(140, 23);
            this.chbDataDelivery.TabIndex = 6;
            this.chbDataDelivery.CheckedChanged += new System.EventHandler(this.chbDataCreate_CheckedChanged);
            // 
            // txtDataCreate2
            // 
            this.txtDataCreate2.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataCreate2.Location = new System.Drawing.Point(289, 20);
            this.txtDataCreate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataCreate2.Name = "txtDataCreate2";
            this.txtDataCreate2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCreate2.Properties.Appearance.Options.UseFont = true;
            this.txtDataCreate2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataCreate2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataCreate2.Size = new System.Drawing.Size(104, 26);
            this.txtDataCreate2.TabIndex = 2;
            this.txtDataCreate2.Visible = false;
            // 
            // txtDataCreate1
            // 
            this.txtDataCreate1.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtDataCreate1.Location = new System.Drawing.Point(178, 20);
            this.txtDataCreate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataCreate1.Name = "txtDataCreate1";
            this.txtDataCreate1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCreate1.Properties.Appearance.Options.UseFont = true;
            this.txtDataCreate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataCreate1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataCreate1.Size = new System.Drawing.Size(104, 26);
            this.txtDataCreate1.TabIndex = 1;
            this.txtDataCreate1.Visible = false;
            // 
            // chbDataCreate
            // 
            this.chbDataCreate.Location = new System.Drawing.Point(17, 20);
            this.chbDataCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDataCreate.Name = "chbDataCreate";
            this.chbDataCreate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDataCreate.Properties.Appearance.Options.UseFont = true;
            this.chbDataCreate.Properties.AutoWidth = true;
            this.chbDataCreate.Properties.Caption = "შექმნის თარიღი";
            this.chbDataCreate.Size = new System.Drawing.Size(137, 23);
            this.chbDataCreate.TabIndex = 0;
            this.chbDataCreate.CheckedChanged += new System.EventHandler(this.chbDataCreate_CheckedChanged);
            // 
            // chbPiradiNom
            // 
            this.chbPiradiNom.Location = new System.Drawing.Point(400, 20);
            this.chbPiradiNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPiradiNom.Name = "chbPiradiNom";
            this.chbPiradiNom.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPiradiNom.Properties.Appearance.Options.UseFont = true;
            this.chbPiradiNom.Properties.AutoWidth = true;
            this.chbPiradiNom.Properties.Caption = "მძღოლის პირადი #";
            this.chbPiradiNom.Size = new System.Drawing.Size(159, 23);
            this.chbPiradiNom.TabIndex = 14;
            this.chbPiradiNom.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 213);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgReal1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1483, 625);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgReal1
            // 
            this.dgReal1.ContextMenuStrip = this.cmExcel;
            this.dgReal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReal1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgReal1.Location = new System.Drawing.Point(0, 0);
            this.dgReal1.MainView = this.gvReal1;
            this.dgReal1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgReal1.Name = "dgReal1";
            this.dgReal1.Size = new System.Drawing.Size(1483, 333);
            this.dgReal1.TabIndex = 0;
            this.dgReal1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReal1,
            this.gridView5});
            // 
            // cmExcel
            // 
            this.cmExcel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmExcel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExportToExcel});
            this.cmExcel.Name = "cmExcel";
            this.cmExcel.Size = new System.Drawing.Size(212, 28);
            this.cmExcel.Opening += new System.ComponentModel.CancelEventHandler(this.cmExcel_Opening);
            // 
            // miExportToExcel
            // 
            this.miExportToExcel.Name = "miExportToExcel";
            this.miExportToExcel.Size = new System.Drawing.Size(211, 24);
            this.miExportToExcel.Text = "ექსელში ექსპორტი";
            this.miExportToExcel.Click += new System.EventHandler(this.miExportToExcel_Click);
            // 
            // gvReal1
            // 
            this.gvReal1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvReal1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvReal1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIS_CONFIRMED,
            this.colSELLER_TIN,
            this.colSELLER_NAME,
            this.colCREATE_DATE,
            this.colSTART_ADDRESS,
            this.colEND_ADDRESS,
            this.colDRIVER_TIN,
            this.colTRANSPORT_COAST,
            this.colRECEPTION_INFO,
            this.colRECEIVER_INFO,
            this.colDELIVERY_DATE,
            this.colSTATUS,
            this.colACTIVATE_DATE,
            this.colPAR_ID,
            this.colFULL_AMOUNT,
            this.col_TANXA,
            this.colCAR_NUMBER,
            this.colWAYBILL_NUMBER,
            this.colCLOSE_DATE,
            this.colS_USER_ID,
            this.colBEGIN_DATE,
            this.colWAYBILL_COMMENT,
            this.colTYPE,
            this.colTypeText});
            this.gvReal1.FooterPanelHeight = 1;
            this.gvReal1.GridControl = this.dgReal1;
            this.gvReal1.GroupPanelText = "დაჯგუფება";
            this.gvReal1.GroupRowHeight = 1;
            this.gvReal1.Name = "gvReal1";
            this.gvReal1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvReal1.OptionsBehavior.Editable = false;
            this.gvReal1.OptionsDetail.AllowZoomDetail = false;
            this.gvReal1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvReal1.OptionsSelection.MultiSelect = true;
            this.gvReal1.OptionsView.ColumnAutoWidth = false;
            this.gvReal1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvReal1.OptionsView.ShowAutoFilterRow = true;
            this.gvReal1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvReal1.OptionsView.ShowDetailButtons = false;
            this.gvReal1.OptionsView.ShowFooter = true;
            this.gvReal1.OptionsView.ShowGroupedColumns = true;
            this.gvReal1.OptionsView.ShowGroupPanel = false;
            this.gvReal1.OptionsView.ShowIndicator = false;
            this.gvReal1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvReal1_RowStyle);
            this.gvReal1.ColumnWidthChanged += new DevExpress.XtraGrid.Views.Base.ColumnEventHandler(this.gvReal1_ColumnWidthChanged);
            this.gvReal1.ColumnPositionChanged += new System.EventHandler(this.gvReal1_ColumnPositionChanged);
            this.gvReal1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvReal1_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.Caption = "ზედდებულის ID";
            this.colID.DisplayFormat.FormatString = "0,##";
            this.colID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colIS_CONFIRMED
            // 
            this.colIS_CONFIRMED.Caption = "დადასტურება";
            this.colIS_CONFIRMED.FieldName = "IS_CONFIRMED";
            this.colIS_CONFIRMED.Name = "colIS_CONFIRMED";
            this.colIS_CONFIRMED.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TYPE", "")});
            // 
            // colSELLER_TIN
            // 
            this.colSELLER_TIN.Caption = "საიდ.კოდი";
            this.colSELLER_TIN.FieldName = "SELLER_TIN";
            this.colSELLER_TIN.Name = "colSELLER_TIN";
            this.colSELLER_TIN.Visible = true;
            this.colSELLER_TIN.VisibleIndex = 2;
            this.colSELLER_TIN.Width = 90;
            // 
            // colSELLER_NAME
            // 
            this.colSELLER_NAME.Caption = "ორგანიზაცია";
            this.colSELLER_NAME.FieldName = "SELLER_NAME";
            this.colSELLER_NAME.Name = "colSELLER_NAME";
            this.colSELLER_NAME.Visible = true;
            this.colSELLER_NAME.VisibleIndex = 3;
            this.colSELLER_NAME.Width = 104;
            // 
            // colCREATE_DATE
            // 
            this.colCREATE_DATE.Caption = "შექმნის თარიღი";
            this.colCREATE_DATE.FieldName = "CREATE_DATE";
            this.colCREATE_DATE.Name = "colCREATE_DATE";
            this.colCREATE_DATE.Visible = true;
            this.colCREATE_DATE.VisibleIndex = 8;
            this.colCREATE_DATE.Width = 127;
            // 
            // colSTART_ADDRESS
            // 
            this.colSTART_ADDRESS.Caption = "დაწყების მისამართი";
            this.colSTART_ADDRESS.FieldName = "START_ADDRESS";
            this.colSTART_ADDRESS.Name = "colSTART_ADDRESS";
            this.colSTART_ADDRESS.Visible = true;
            this.colSTART_ADDRESS.VisibleIndex = 9;
            this.colSTART_ADDRESS.Width = 157;
            // 
            // colEND_ADDRESS
            // 
            this.colEND_ADDRESS.Caption = "დასრულების მისამართი";
            this.colEND_ADDRESS.FieldName = "END_ADDRESS";
            this.colEND_ADDRESS.Name = "colEND_ADDRESS";
            this.colEND_ADDRESS.Visible = true;
            this.colEND_ADDRESS.VisibleIndex = 10;
            this.colEND_ADDRESS.Width = 186;
            // 
            // colDRIVER_TIN
            // 
            this.colDRIVER_TIN.Caption = "მძღოლის პირადი #";
            this.colDRIVER_TIN.FieldName = "DRIVER_TIN";
            this.colDRIVER_TIN.Name = "colDRIVER_TIN";
            // 
            // colTRANSPORT_COAST
            // 
            this.colTRANSPORT_COAST.Caption = "ტრანს. თანხა";
            this.colTRANSPORT_COAST.FieldName = "TRANSPORT_COAST";
            this.colTRANSPORT_COAST.Name = "colTRANSPORT_COAST";
            this.colTRANSPORT_COAST.Visible = true;
            this.colTRANSPORT_COAST.VisibleIndex = 7;
            this.colTRANSPORT_COAST.Width = 105;
            // 
            // colRECEPTION_INFO
            // 
            this.colRECEPTION_INFO.Caption = "გაგმზავნი";
            this.colRECEPTION_INFO.FieldName = "RECEPTION_INFO";
            this.colRECEPTION_INFO.Name = "colRECEPTION_INFO";
            // 
            // colRECEIVER_INFO
            // 
            this.colRECEIVER_INFO.Caption = "მიმღები";
            this.colRECEIVER_INFO.FieldName = "RECEIVER_INFO";
            this.colRECEIVER_INFO.Name = "colRECEIVER_INFO";
            // 
            // colDELIVERY_DATE
            // 
            this.colDELIVERY_DATE.Caption = "მიტანის დრო";
            this.colDELIVERY_DATE.FieldName = "DELIVERY_DATE";
            this.colDELIVERY_DATE.Name = "colDELIVERY_DATE";
            // 
            // colSTATUS
            // 
            this.colSTATUS.Caption = "სტატუსი";
            this.colSTATUS.FieldName = "STATUS";
            this.colSTATUS.Name = "colSTATUS";
            // 
            // colACTIVATE_DATE
            // 
            this.colACTIVATE_DATE.Caption = "აქტივიზაციის დრო";
            this.colACTIVATE_DATE.FieldName = "ACTIVATE_DATE";
            this.colACTIVATE_DATE.Name = "colACTIVATE_DATE";
            // 
            // colPAR_ID
            // 
            this.colPAR_ID.Caption = "დედა ზედნადების ID";
            this.colPAR_ID.FieldName = "PAR_ID";
            this.colPAR_ID.Name = "colPAR_ID";
            // 
            // colFULL_AMOUNT
            // 
            this.colFULL_AMOUNT.Caption = "თანხა";
            this.colFULL_AMOUNT.DisplayFormat.FormatString = "{0:0.00##}";
            this.colFULL_AMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFULL_AMOUNT.FieldName = "FULL_AMOUNT";
            this.colFULL_AMOUNT.Name = "colFULL_AMOUNT";
            this.colFULL_AMOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FULL_AMOUNT", "{0:0.00##}")});
            this.colFULL_AMOUNT.Visible = true;
            this.colFULL_AMOUNT.VisibleIndex = 4;
            // 
            // col_TANXA
            // 
            this.col_TANXA.Caption = "თანხა(პროგრამაში)";
            this.col_TANXA.DisplayFormat.FormatString = "{0:0.00##}";
            this.col_TANXA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_TANXA.FieldName = "Tanxa";
            this.col_TANXA.Name = "col_TANXA";
            this.col_TANXA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tanxa", "{0:0.00##}")});
            this.col_TANXA.Visible = true;
            this.col_TANXA.VisibleIndex = 5;
            this.col_TANXA.Width = 147;
            // 
            // colCAR_NUMBER
            // 
            this.colCAR_NUMBER.Caption = "მანქანის #";
            this.colCAR_NUMBER.FieldName = "CAR_NUMBER";
            this.colCAR_NUMBER.Name = "colCAR_NUMBER";
            this.colCAR_NUMBER.Visible = true;
            this.colCAR_NUMBER.VisibleIndex = 6;
            this.colCAR_NUMBER.Width = 83;
            // 
            // colWAYBILL_NUMBER
            // 
            this.colWAYBILL_NUMBER.Caption = "ზედდებული";
            this.colWAYBILL_NUMBER.FieldName = "WAYBILL_NUMBER";
            this.colWAYBILL_NUMBER.Name = "colWAYBILL_NUMBER";
            this.colWAYBILL_NUMBER.Visible = true;
            this.colWAYBILL_NUMBER.VisibleIndex = 1;
            this.colWAYBILL_NUMBER.Width = 104;
            // 
            // colCLOSE_DATE
            // 
            this.colCLOSE_DATE.Caption = "დახურვის თარიღი";
            this.colCLOSE_DATE.FieldName = "CLOSE_DATE";
            this.colCLOSE_DATE.Name = "colCLOSE_DATE";
            // 
            // colS_USER_ID
            // 
            this.colS_USER_ID.Caption = "მომხმარებლის ID";
            this.colS_USER_ID.FieldName = "S_USER_ID";
            this.colS_USER_ID.Name = "colS_USER_ID";
            // 
            // colBEGIN_DATE
            // 
            this.colBEGIN_DATE.Caption = "დაწყების დრო";
            this.colBEGIN_DATE.FieldName = "BEGIN_DATE";
            this.colBEGIN_DATE.Name = "colBEGIN_DATE";
            // 
            // colWAYBILL_COMMENT
            // 
            this.colWAYBILL_COMMENT.Caption = "კომენტარი";
            this.colWAYBILL_COMMENT.FieldName = "WAYBILL_COMMENT";
            this.colWAYBILL_COMMENT.Name = "colWAYBILL_COMMENT";
            // 
            // colTYPE
            // 
            this.colTYPE.Caption = "ტიპი";
            this.colTYPE.FieldName = "TYPE";
            this.colTYPE.Name = "colTYPE";
            // 
            // colTypeText
            // 
            this.colTypeText.Caption = "ზედნადების ტიპი";
            this.colTypeText.FieldName = "TypeText";
            this.colTypeText.Name = "colTypeText";
            this.colTypeText.Visible = true;
            this.colTypeText.VisibleIndex = 0;
            this.colTypeText.Width = 115;
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.dgReal1;
            this.gridView5.Name = "gridView5";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgRealRs);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgReal2);
            this.splitContainer2.Size = new System.Drawing.Size(1483, 287);
            this.splitContainer2.SplitterDistance = 716;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // dgRealRs
            // 
            this.dgRealRs.ContextMenuStrip = this.cmExcel;
            this.dgRealRs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRealRs.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRealRs.Location = new System.Drawing.Point(0, 0);
            this.dgRealRs.MainView = this.gvRealRs;
            this.dgRealRs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRealRs.Name = "dgRealRs";
            this.dgRealRs.Size = new System.Drawing.Size(716, 287);
            this.dgRealRs.TabIndex = 0;
            this.dgRealRs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRealRs,
            this.gridView2});
            // 
            // gvRealRs
            // 
            this.gvRealRs.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvRealRs.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRealRs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRsID,
            this.colRsBAR_CODE,
            this.colRsW_NAME,
            this.colRsQUANTITY,
            this.colRsPRICE,
            this.colRsAMOUNT,
            this.colRsVAT_TYPE_NAME,
            this.colUNIT_TXT});
            this.gvRealRs.FooterPanelHeight = 1;
            this.gvRealRs.GridControl = this.dgRealRs;
            this.gvRealRs.GroupPanelText = "დაჯგუფება";
            this.gvRealRs.GroupRowHeight = 1;
            this.gvRealRs.Name = "gvRealRs";
            this.gvRealRs.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvRealRs.OptionsBehavior.Editable = false;
            this.gvRealRs.OptionsDetail.AllowZoomDetail = false;
            this.gvRealRs.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvRealRs.OptionsSelection.MultiSelect = true;
            this.gvRealRs.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvRealRs.OptionsView.ShowAutoFilterRow = true;
            this.gvRealRs.OptionsView.ShowDetailButtons = false;
            this.gvRealRs.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvRealRs.OptionsView.ShowFooter = true;
            this.gvRealRs.OptionsView.ShowGroupPanel = false;
            // 
            // colRsID
            // 
            this.colRsID.Caption = "მიმდ.";
            this.colRsID.FieldName = "ID";
            this.colRsID.Name = "colRsID";
            // 
            // colRsBAR_CODE
            // 
            this.colRsBAR_CODE.Caption = "კოდი";
            this.colRsBAR_CODE.FieldName = "BAR_CODE";
            this.colRsBAR_CODE.Name = "colRsBAR_CODE";
            this.colRsBAR_CODE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProd", "")});
            this.colRsBAR_CODE.Visible = true;
            this.colRsBAR_CODE.VisibleIndex = 0;
            this.colRsBAR_CODE.Width = 92;
            // 
            // colRsW_NAME
            // 
            this.colRsW_NAME.Caption = "პროდუქცია";
            this.colRsW_NAME.FieldName = "W_NAME";
            this.colRsW_NAME.Name = "colRsW_NAME";
            this.colRsW_NAME.Visible = true;
            this.colRsW_NAME.VisibleIndex = 1;
            this.colRsW_NAME.Width = 173;
            // 
            // colRsQUANTITY
            // 
            this.colRsQUANTITY.Caption = "რაოდენობა";
            this.colRsQUANTITY.DisplayFormat.FormatString = "{0:0.####}";
            this.colRsQUANTITY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRsQUANTITY.FieldName = "QUANTITY";
            this.colRsQUANTITY.Name = "colRsQUANTITY";
            this.colRsQUANTITY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:#.####}")});
            this.colRsQUANTITY.Visible = true;
            this.colRsQUANTITY.VisibleIndex = 2;
            this.colRsQUANTITY.Width = 80;
            // 
            // colRsPRICE
            // 
            this.colRsPRICE.Caption = "ფასი";
            this.colRsPRICE.DisplayFormat.FormatString = "{0:0.00##}";
            this.colRsPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRsPRICE.FieldName = "PRICE";
            this.colRsPRICE.Name = "colRsPRICE";
            this.colRsPRICE.Visible = true;
            this.colRsPRICE.VisibleIndex = 3;
            this.colRsPRICE.Width = 63;
            // 
            // colRsAMOUNT
            // 
            this.colRsAMOUNT.Caption = "თანხა";
            this.colRsAMOUNT.DisplayFormat.FormatString = "{0:0.00##}";
            this.colRsAMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRsAMOUNT.FieldName = "AMOUNT";
            this.colRsAMOUNT.Name = "colRsAMOUNT";
            this.colRsAMOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMOUNT", "{0:#.00##}")});
            this.colRsAMOUNT.Visible = true;
            this.colRsAMOUNT.VisibleIndex = 4;
            // 
            // colRsVAT_TYPE_NAME
            // 
            this.colRsVAT_TYPE_NAME.Caption = "დაბეგვრის ტიპი";
            this.colRsVAT_TYPE_NAME.FieldName = "VAT_TYPE_NAME";
            this.colRsVAT_TYPE_NAME.Name = "colRsVAT_TYPE_NAME";
            this.colRsVAT_TYPE_NAME.Visible = true;
            this.colRsVAT_TYPE_NAME.VisibleIndex = 5;
            // 
            // colUNIT_TXT
            // 
            this.colUNIT_TXT.Caption = "ერთეული";
            this.colUNIT_TXT.FieldName = "UNIT_TXT";
            this.colUNIT_TXT.Name = "colUNIT_TXT";
            this.colUNIT_TXT.Visible = true;
            this.colUNIT_TXT.VisibleIndex = 6;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgRealRs;
            this.gridView2.Name = "gridView2";
            // 
            // dgReal2
            // 
            this.dgReal2.ContextMenuStrip = this.cmExcel;
            this.dgReal2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReal2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgReal2.Location = new System.Drawing.Point(0, 0);
            this.dgReal2.MainView = this.gvReal2;
            this.dgReal2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgReal2.Name = "dgReal2";
            this.dgReal2.Size = new System.Drawing.Size(762, 287);
            this.dgReal2.TabIndex = 0;
            this.dgReal2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReal2,
            this.gridView4});
            // 
            // gvReal2
            // 
            this.gvReal2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvReal2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvReal2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdReal2,
            this.colIdProd,
            this.colProd,
            this.colRaod,
            this.colFasi,
            this.colTanxa,
            this.colVatType,
            this.colUnit});
            this.gvReal2.FooterPanelHeight = 1;
            this.gvReal2.GridControl = this.dgReal2;
            this.gvReal2.GroupPanelText = "დაჯგუფება";
            this.gvReal2.GroupRowHeight = 1;
            this.gvReal2.Name = "gvReal2";
            this.gvReal2.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvReal2.OptionsBehavior.Editable = false;
            this.gvReal2.OptionsDetail.AllowZoomDetail = false;
            this.gvReal2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvReal2.OptionsSelection.MultiSelect = true;
            this.gvReal2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvReal2.OptionsView.ShowAutoFilterRow = true;
            this.gvReal2.OptionsView.ShowDetailButtons = false;
            this.gvReal2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvReal2.OptionsView.ShowFooter = true;
            this.gvReal2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdReal2
            // 
            this.colIdReal2.Caption = "მიმდ.";
            this.colIdReal2.FieldName = "IdReal2";
            this.colIdReal2.Name = "colIdReal2";
            // 
            // colIdProd
            // 
            this.colIdProd.Caption = "კოდი";
            this.colIdProd.FieldName = "IdProd";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdProd.Visible = true;
            this.colIdProd.VisibleIndex = 0;
            // 
            // colProd
            // 
            this.colProd.Caption = "პროდუქცია";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 1;
            this.colProd.Width = 173;
            // 
            // colRaod
            // 
            this.colRaod.Caption = "რაოდენობა";
            this.colRaod.DisplayFormat.FormatString = "{0:0.####}";
            this.colRaod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRaod.FieldName = "Raod";
            this.colRaod.Name = "colRaod";
            this.colRaod.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Raod", "{0:#.####}")});
            this.colRaod.Visible = true;
            this.colRaod.VisibleIndex = 2;
            this.colRaod.Width = 79;
            // 
            // colFasi
            // 
            this.colFasi.Caption = "ფასი";
            this.colFasi.DisplayFormat.FormatString = "{0:0.00##}";
            this.colFasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            this.colFasi.Visible = true;
            this.colFasi.VisibleIndex = 3;
            // 
            // colTanxa
            // 
            this.colTanxa.Caption = "თანხა";
            this.colTanxa.DisplayFormat.FormatString = "{0:0.00##}";
            this.colTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTanxa.FieldName = "Tanxa";
            this.colTanxa.Name = "colTanxa";
            this.colTanxa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tanxa", "{0:#.00##}")});
            this.colTanxa.Visible = true;
            this.colTanxa.VisibleIndex = 4;
            // 
            // colVatType
            // 
            this.colVatType.Caption = "დაბეგვრის ტიპი";
            this.colVatType.FieldName = "VatType";
            this.colVatType.Name = "colVatType";
            this.colVatType.Visible = true;
            this.colVatType.VisibleIndex = 5;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "ერთეული";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 6;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.dgReal2;
            this.gridView4.Name = "gridView4";
            // 
            // CheckShesWaybillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 838);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckShesWaybillsForm";
            this.ShowIcon = false;
            this.Text = "ინფორმაციის მიღება საგადასახადო საიტიდან";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckWaybillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbZeddType)).EndInit();
            this.gbZeddType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chb6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chb1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTanxa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSagad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSagad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPiradiNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBegin1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataClose1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataDelivery1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataDelivery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCreate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDataCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbPiradiNom.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReal1)).EndInit();
            this.cmExcel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvReal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRealRs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRealRs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel2;
        private DevExpress.XtraEditors.SimpleButton btnImportWaybills;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl dgReal1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReal1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.GridControl dgReal2;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReal2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdReal2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRaod;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colTanxa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private CheckEdit chbPiradiNom;
        private DateEdit txtDataBegin2;
        private DateEdit txtDataBegin1;
        private CheckEdit chbDataBegin;
        private DateEdit txtDataClose2;
        private DateEdit txtDataClose1;
        private CheckEdit chbDataClose;
        private DateEdit txtDataDelivery2;
        private DateEdit txtDataDelivery1;
        private CheckEdit chbDataDelivery;
        private DateEdit txtDataCreate2;
        private DateEdit txtDataCreate1;
        private CheckEdit chbDataCreate;
        private DevExpress.XtraEditors.GroupControl gbZeddType;
        private CheckEdit chb6;
        private CheckEdit chb5;
        private CheckEdit chb4;
        private CheckEdit chb3;
        private CheckEdit chb2;
        private CheckEdit chb1;
        private TextEdit txtPiradiNom;
        private TextEdit txtTanxa;
        private CheckEdit chbTanxa;
        private TextEdit txtZedd;
        private CheckEdit chbZedd;
        private TextEdit txtSagad;
        private CheckEdit chbSagad;
        private TextEdit txtMan;
        private CheckEdit chbMan;
        private DevExpress.XtraEditors.PanelControl panel1;
        private TextEdit txtComment;
        private CheckEdit chbComment;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_CONFIRMED;
        private DevExpress.XtraGrid.Columns.GridColumn colSELLER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colDRIVER_TIN;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANSPORT_COAST;
        private DevExpress.XtraGrid.Columns.GridColumn colRECEPTION_INFO;
        private DevExpress.XtraGrid.Columns.GridColumn colRECEIVER_INFO;
        private DevExpress.XtraGrid.Columns.GridColumn colDELIVERY_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVATE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colPAR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colCAR_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colWAYBILL_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colS_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBEGIN_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colWAYBILL_COMMENT;
        private DevExpress.XtraGrid.Columns.GridColumn colSELLER_TIN;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl dgRealRs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRealRs;
        private DevExpress.XtraGrid.Columns.GridColumn colRsID;
        private DevExpress.XtraGrid.Columns.GridColumn colRsBAR_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRsW_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colRsQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colRsPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colRsAMOUNT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_TANXA;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraGrid.Columns.GridColumn colTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colRsVAT_TYPE_NAME;
        private System.Windows.Forms.ContextMenuStrip cmExcel;
        private System.Windows.Forms.ToolStripMenuItem miExportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeText;
        private DevExpress.XtraGrid.Columns.GridColumn colVatType;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_TXT;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
    }
}