using DevExpress.XtraEditors;

namespace SBS_Market.FindForms
{
    partial class FXarjiForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FXarjiForm));
            this.panel1 = new PanelControl();
            this.cbValuta = new DevExpress.XtraEditors.LookUpEdit();
            this.chbValuta = new System.Windows.Forms.CheckBox();
            this.chbChart = new System.Windows.Forms.CheckBox();
            this.txtFactura = new TextEdit();
            this.chbFactura = new System.Windows.Forms.CheckBox();
            this.chbCross = new System.Windows.Forms.CheckBox();
            this.txtZedd = new TextEdit();
            this.chbZedd = new System.Windows.Forms.CheckBox();
            this.lbList = new System.Windows.Forms.ListBox();
            this.chbList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.chbTotal = new System.Windows.Forms.CheckBox();
            this.cbXarjiT = new DevExpress.XtraEditors.LookUpEdit();
            this.cbMomc = new DevExpress.XtraEditors.LookUpEdit();
            this.txtData2 = new DateEdit();
            this.txtData1 = new DateEdit();
            this.chbXarjiT = new System.Windows.Forms.CheckBox();
            this.chbMomc = new System.Windows.Forms.CheckBox();
            this.chbData = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.cbExportFormat = new System.Windows.Forms.ToolStripComboBox();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.cbFileName = new System.Windows.Forms.ToolStripComboBox();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.cbXML = new System.Windows.Forms.ToolStripComboBox();
            this.btnSaveDGlayout = new System.Windows.Forms.ToolStripButton();
            this.btnRestoreDGlayout = new System.Windows.Forms.ToolStripButton();
            this.btnGridViewSettings = new System.Windows.Forms.ToolStripButton();
            this.cbPivotXML = new System.Windows.Forms.ToolStripComboBox();
            this.btnSavePTlayout = new System.Windows.Forms.ToolStripButton();
            this.btnRestorePTlayout = new System.Windows.Forms.ToolStripButton();
            this.btnPivotTableSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHideSearchPanel = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new PanelControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dg = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdShes1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZedd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXarjiT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXarji = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMomc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXarjiTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKursi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXarjiTanxaLari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pt = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pcolData = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolMomc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolXarjiTanxa = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolValuta = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolKursi = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolXarjiTanxaLari = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolZedd = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolShen = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolXarjiT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfWeek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolDayOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pcolWeekOfYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel3 = new PanelControl();
            this.cbChartType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbChartOrientation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new LabelControl();
            this.label1 = new LabelControl();
            this.chbShowValues = new System.Windows.Forms.CheckBox();
            this.FindMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ბეჭდვაToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.miExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miSaveDGlayout = new System.Windows.Forms.ToolStripMenuItem();
            this.miRestoreDGlayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.miSavePTlayout = new System.Windows.Forms.ToolStripMenuItem();
            this.miRestorePTlayout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties.CalendarTimeProperties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChartOrientation.Properties)).BeginInit();
            this.FindMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbValuta);
            this.panel1.Controls.Add(this.chbValuta);
            this.panel1.Controls.Add(this.chbChart);
            this.panel1.Controls.Add(this.txtFactura);
            this.panel1.Controls.Add(this.chbFactura);
            this.panel1.Controls.Add(this.chbCross);
            this.panel1.Controls.Add(this.txtZedd);
            this.panel1.Controls.Add(this.chbZedd);
            this.panel1.Controls.Add(this.lbList);
            this.panel1.Controls.Add(this.chbList);
            this.panel1.Controls.Add(this.chbTotal);
            this.panel1.Controls.Add(this.cbXarjiT);
            this.panel1.Controls.Add(this.cbMomc);
            this.panel1.Controls.Add(this.txtData2);
            this.panel1.Controls.Add(this.txtData1);
            this.panel1.Controls.Add(this.chbXarjiT);
            this.panel1.Controls.Add(this.chbMomc);
            this.panel1.Controls.Add(this.chbData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 137);
            this.panel1.TabIndex = 7;
            // 
            // cbValuta
            // 
            this.cbValuta.Location = new System.Drawing.Point(129, 97);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(175, 21);
            this.cbValuta.TabIndex = 79;
            this.cbValuta.Visible = false;
            // 
            // chbValuta
            // 
            this.chbValuta.AutoSize = true;
            this.chbValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbValuta.Location = new System.Drawing.Point(12, 98);
            this.chbValuta.Name = "chbValuta";
            this.chbValuta.Size = new System.Drawing.Size(70, 20);
            this.chbValuta.TabIndex = 78;
            this.chbValuta.Text = "ვალუტა";
            this.chbValuta.UseVisualStyleBackColor = true;
            this.chbValuta.CheckedChanged += new System.EventHandler(this.chbOrgT_CheckedChanged);
            // 
            // chbChart
            // 
            this.chbChart.AutoSize = true;
            this.chbChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbChart.ForeColor = System.Drawing.Color.Maroon;
            this.chbChart.Location = new System.Drawing.Point(986, 92);
            this.chbChart.Name = "chbChart";
            this.chbChart.Size = new System.Drawing.Size(72, 20);
            this.chbChart.TabIndex = 75;
            this.chbChart.Text = "გრაფიკი";
            this.chbChart.UseVisualStyleBackColor = true;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(477, 69);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(85, 20);
            this.txtFactura.TabIndex = 71;
            this.txtFactura.Visible = false;
            // 
            // chbFactura
            // 
            this.chbFactura.AutoSize = true;
            this.chbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbFactura.Location = new System.Drawing.Point(368, 69);
            this.chbFactura.Name = "chbFactura";
            this.chbFactura.Size = new System.Drawing.Size(75, 20);
            this.chbFactura.TabIndex = 70;
            this.chbFactura.Text = "ფაქტურა";
            this.chbFactura.UseVisualStyleBackColor = true;
            this.chbFactura.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // chbCross
            // 
            this.chbCross.AutoSize = true;
            this.chbCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbCross.ForeColor = System.Drawing.Color.Maroon;
            this.chbCross.Location = new System.Drawing.Point(986, 68);
            this.chbCross.Name = "chbCross";
            this.chbCross.Size = new System.Drawing.Size(107, 20);
            this.chbCross.TabIndex = 55;
            this.chbCross.Text = "კროს. ცხრილი";
            this.chbCross.UseVisualStyleBackColor = true;
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(477, 44);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Size = new System.Drawing.Size(85, 20);
            this.txtZedd.TabIndex = 51;
            this.txtZedd.Visible = false;
            // 
            // chbZedd
            // 
            this.chbZedd.AutoSize = true;
            this.chbZedd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbZedd.Location = new System.Drawing.Point(368, 44);
            this.chbZedd.Name = "chbZedd";
            this.chbZedd.Size = new System.Drawing.Size(96, 20);
            this.chbZedd.TabIndex = 50;
            this.chbZedd.Text = "ზედდებული";
            this.chbZedd.UseVisualStyleBackColor = true;
            this.chbZedd.CheckedChanged += new System.EventHandler(this.chbZedd_CheckedChanged);
            // 
            // lbList
            // 
            this.lbList.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 14;
            this.lbList.Location = new System.Drawing.Point(903, 16);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(190, 46);
            this.lbList.TabIndex = 49;
            // 
            // chbList
            // 
            this.chbList.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbList.Appearance.Options.UseFont = true;
            this.chbList.Location = new System.Drawing.Point(707, 16);
            this.chbList.Name = "chbList";
            this.chbList.Size = new System.Drawing.Size(190, 102);
            this.chbList.TabIndex = 48;
            // 
            // chbTotal
            // 
            this.chbTotal.AutoSize = true;
            this.chbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbTotal.Location = new System.Drawing.Point(903, 68);
            this.chbTotal.Name = "chbTotal";
            this.chbTotal.Size = new System.Drawing.Size(88, 20);
            this.chbTotal.TabIndex = 44;
            this.chbTotal.Text = "დაჯგუფება";
            this.chbTotal.UseVisualStyleBackColor = true;
            // 
            // cbXarjiT
            // 
            this.cbXarjiT.Location = new System.Drawing.Point(129, 70);
            this.cbXarjiT.Name = "cbXarjiT";
            this.cbXarjiT.Size = new System.Drawing.Size(175, 21);
            this.cbXarjiT.TabIndex = 26;
            this.cbXarjiT.Visible = false;
            // 
            // cbMomc
            // 
            this.cbMomc.Location = new System.Drawing.Point(128, 43);
            this.cbMomc.Name = "cbMomc";
            this.cbMomc.Size = new System.Drawing.Size(176, 21);
            this.cbMomc.TabIndex = 20;
            this.cbMomc.Visible = false;
            // 
            // txtData2
            // 
            // 
            // 
            // 







            this.txtData2.EditValue = "1.1.2010";
            this.txtData2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData2.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtData2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData2.Properties.Mask.EditMask = "d.M.yyyy";
            
            this.txtData2.Location = new System.Drawing.Point(219, 16);
            this.txtData2.Name = "txtData2";
            
            
            this.txtData2.Size = new System.Drawing.Size(85, 20);
            this.txtData2.TabIndex = 10;
            
            this.txtData2.Visible = false;
            // 
            // txtData1
            // 
            // 
            // 
            // 






            this.txtData1.EditValue = "1.1.2010";
            this.txtData1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData1.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtData1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData1.Properties.Mask.EditMask = "d.M.yyyy";
            
            
            this.txtData1.Location = new System.Drawing.Point(128, 16);
            this.txtData1.Name = "txtData1";
            
            
            this.txtData1.Size = new System.Drawing.Size(85, 20);
            this.txtData1.TabIndex = 9;
            
            this.txtData1.Visible = false;
            // 
            // chbXarjiT
            // 
            this.chbXarjiT.AutoSize = true;
            this.chbXarjiT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbXarjiT.Location = new System.Drawing.Point(12, 71);
            this.chbXarjiT.Name = "chbXarjiT";
            this.chbXarjiT.Size = new System.Drawing.Size(95, 20);
            this.chbXarjiT.TabIndex = 4;
            this.chbXarjiT.Text = "ხარჯის ტიპი";
            this.chbXarjiT.UseVisualStyleBackColor = true;
            this.chbXarjiT.CheckedChanged += new System.EventHandler(this.chbOrgT_CheckedChanged);
            // 
            // chbMomc
            // 
            this.chbMomc.AutoSize = true;
            this.chbMomc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMomc.Location = new System.Drawing.Point(12, 44);
            this.chbMomc.Name = "chbMomc";
            this.chbMomc.Size = new System.Drawing.Size(107, 20);
            this.chbMomc.TabIndex = 2;
            this.chbMomc.Text = "მომწოდებელი";
            this.chbMomc.UseVisualStyleBackColor = true;
            this.chbMomc.CheckedChanged += new System.EventHandler(this.chbOrgT_CheckedChanged);
            // 
            // chbData
            // 
            this.chbData.AutoSize = true;
            this.chbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbData.Location = new System.Drawing.Point(12, 16);
            this.chbData.Name = "chbData";
            this.chbData.Size = new System.Drawing.Size(71, 20);
            this.chbData.TabIndex = 0;
            this.chbData.Text = "თარიღი";
            this.chbData.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFind,
            this.cbExportFormat,
            this.btnPrint,
            this.cbFileName,
            this.btnExcel,
            this.cbXML,
            this.btnSaveDGlayout,
            this.btnRestoreDGlayout,
            this.btnGridViewSettings,
            this.cbPivotXML,
            this.btnSavePTlayout,
            this.btnRestorePTlayout,
            this.btnPivotTableSettings,
            this.toolStripSeparator3,
            this.btnHideSearchPanel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1145, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = global::SBS_Market.Properties.Resources.FFind;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(23, 22);
            this.btnFind.Text = "ძებნა";
            // 
            // cbExportFormat
            // 
            this.cbExportFormat.Items.AddRange(new object[] {
            "Export To Excel",
            "Export To Word",
            "Export To Pdf",
            "Export To Text",
            "Export To HTML"});
            this.cbExportFormat.Name = "cbExportFormat";
            this.cbExportFormat.Size = new System.Drawing.Size(121, 25);
            this.cbExportFormat.Text = "Export To Excel";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = global::SBS_Market.Properties.Resources.FPrint;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "ბეჭდვა";
            // 
            // cbFileName
            // 
            this.cbFileName.Name = "cbFileName";
            this.cbFileName.Size = new System.Drawing.Size(120, 25);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = global::SBS_Market.Properties.Resources.FExcel;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExcel.Text = "ექსპორტი Excel-ში";
            // 
            // cbXML
            // 
            this.cbXML.Name = "cbXML";
            this.cbXML.Size = new System.Drawing.Size(121, 25);
            // 
            // btnSaveDGlayout
            // 
            this.btnSaveDGlayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveDGlayout.Image = global::SBS_Market.Properties.Resources.FSaveDGlayout;
            this.btnSaveDGlayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDGlayout.Name = "btnSaveDGlayout";
            this.btnSaveDGlayout.Size = new System.Drawing.Size(23, 22);
            this.btnSaveDGlayout.Text = "ცხრილის პარამეტრების შენახვა";
            // 
            // btnRestoreDGlayout
            // 
            this.btnRestoreDGlayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRestoreDGlayout.Image = global::SBS_Market.Properties.Resources.FRestoreDGlayout;
            this.btnRestoreDGlayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestoreDGlayout.Name = "btnRestoreDGlayout";
            this.btnRestoreDGlayout.Size = new System.Drawing.Size(23, 22);
            this.btnRestoreDGlayout.Text = "ცხრილის პარამეტრების აღდგენა";
            // 
            // btnGridViewSettings
            // 
            this.btnGridViewSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGridViewSettings.Image = global::SBS_Market.Properties.Resources.FGVSettings;
            this.btnGridViewSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGridViewSettings.Name = "btnGridViewSettings";
            this.btnGridViewSettings.Size = new System.Drawing.Size(23, 22);
            this.btnGridViewSettings.Text = "ცხრილის პარამეტრები";
            // 
            // cbPivotXML
            // 
            this.cbPivotXML.Name = "cbPivotXML";
            this.cbPivotXML.Size = new System.Drawing.Size(121, 25);
            // 
            // btnSavePTlayout
            // 
            this.btnSavePTlayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSavePTlayout.Image = global::SBS_Market.Properties.Resources.FSavePTlayout;
            this.btnSavePTlayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePTlayout.Name = "btnSavePTlayout";
            this.btnSavePTlayout.Size = new System.Drawing.Size(23, 22);
            this.btnSavePTlayout.Text = "კროს ცხრილის პარამეტრების შენახვა";
            // 
            // btnRestorePTlayout
            // 
            this.btnRestorePTlayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRestorePTlayout.Image = global::SBS_Market.Properties.Resources.FRestorePTlayout;
            this.btnRestorePTlayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestorePTlayout.Name = "btnRestorePTlayout";
            this.btnRestorePTlayout.Size = new System.Drawing.Size(23, 22);
            this.btnRestorePTlayout.Text = "კროს ცხრილის პარამეტრების აღდგენა";
            // 
            // btnPivotTableSettings
            // 
            this.btnPivotTableSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPivotTableSettings.Image = global::SBS_Market.Properties.Resources.FPTSettings;
            this.btnPivotTableSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPivotTableSettings.Name = "btnPivotTableSettings";
            this.btnPivotTableSettings.Size = new System.Drawing.Size(23, 22);
            this.btnPivotTableSettings.Text = "კროს ცხრილის პარამეტრები";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHideSearchPanel
            // 
            this.btnHideSearchPanel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHideSearchPanel.Image = global::SBS_Market.Properties.Resources.FHideSPanel;
            this.btnHideSearchPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHideSearchPanel.Name = "btnHideSearchPanel";
            this.btnHideSearchPanel.Size = new System.Drawing.Size(23, 22);
            this.btnHideSearchPanel.Text = "ძებნის პანელის დამალვა";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 494);
            this.panel2.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1145, 494);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1137, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ჩანაწერები";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg
            // 
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(3, 3);
            this.dg.MainView = this.gridView1;
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1131, 459);
            this.dg.TabIndex = 53;
            this.dg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdShes1,
            this.colData,
            this.colZedd,
            this.colFactura,
            this.colXarjiT,
            this.colXarji,
            this.colShen,
            this.colMomc,
            this.colXarjiTanxa,
            this.colValuta,
            this.colKursi,
            this.colXarjiTanxaLari,
            this.colUN,
            this.colCD});
            this.gridView1.FooterPanelHeight = 1;
            this.gridView1.GridControl = this.dg;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.GroupPanelText = "დაჯგუფება";
            this.gridView1.GroupRowHeight = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowZoomDetail = false;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            // 
            // colIdShes1
            // 
            this.colIdShes1.Caption = "IdShes1";
            this.colIdShes1.FieldName = "IdShes1";
            this.colIdShes1.Name = "colIdShes1";
            // 
            // colData
            // 
            this.colData.Caption = "თარიღი";
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 74;
            // 
            // colZedd
            // 
            this.colZedd.Caption = "ზედდებული";
            this.colZedd.FieldName = "Zedd";
            this.colZedd.Name = "colZedd";
            this.colZedd.Visible = true;
            this.colZedd.VisibleIndex = 1;
            this.colZedd.Width = 61;
            // 
            // colFactura
            // 
            this.colFactura.Caption = "ფაქტურა";
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 2;
            // 
            // colXarjiT
            // 
            this.colXarjiT.Caption = "ხარჯის ტიპი";
            this.colXarjiT.FieldName = "XarjiT";
            this.colXarjiT.Name = "colXarjiT";
            this.colXarjiT.Visible = true;
            this.colXarjiT.VisibleIndex = 9;
            this.colXarjiT.Width = 164;
            // 
            // colXarji
            // 
            this.colXarji.Caption = "ხარჯი";
            this.colXarji.FieldName = "Xarji";
            this.colXarji.Name = "colXarji";
            this.colXarji.Visible = true;
            this.colXarji.VisibleIndex = 5;
            // 
            // colShen
            // 
            this.colShen.Caption = "შენიშვნა";
            this.colShen.FieldName = "Shen";
            this.colShen.Name = "colShen";
            this.colShen.Visible = true;
            this.colShen.VisibleIndex = 10;
            this.colShen.Width = 174;
            // 
            // colMomc
            // 
            this.colMomc.Caption = "მომწოდებელი";
            this.colMomc.FieldName = "Momc";
            this.colMomc.Name = "colMomc";
            this.colMomc.Visible = true;
            this.colMomc.VisibleIndex = 3;
            this.colMomc.Width = 85;
            // 
            // colXarjiTanxa
            // 
            this.colXarjiTanxa.Caption = "თანხა";
            this.colXarjiTanxa.DisplayFormat.FormatString = "{0:0.00##}";
            this.colXarjiTanxa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXarjiTanxa.FieldName = "XarjiTanxa";
            this.colXarjiTanxa.Name = "colXarjiTanxa";
            this.colXarjiTanxa.SummaryItem.FieldName = "Tanxa";
            this.colXarjiTanxa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXarjiTanxa.Visible = true;
            this.colXarjiTanxa.VisibleIndex = 4;
            this.colXarjiTanxa.Width = 61;
            // 
            // colValuta
            // 
            this.colValuta.Caption = "ვალუტა";
            this.colValuta.DisplayFormat.FormatString = "{0:0.00##}";
            this.colValuta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValuta.FieldName = "Valuta";
            this.colValuta.Name = "colValuta";
            this.colValuta.Visible = true;
            this.colValuta.VisibleIndex = 6;
            // 
            // colKursi
            // 
            this.colKursi.Caption = "კურსი";
            this.colKursi.DisplayFormat.FormatString = "{0:0.00##}";
            this.colKursi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKursi.FieldName = "Kursi";
            this.colKursi.Name = "colKursi";
            this.colKursi.Visible = true;
            this.colKursi.VisibleIndex = 7;
            // 
            // colXarjiTanxaLari
            // 
            this.colXarjiTanxaLari.Caption = "თანხა ლარი";
            this.colXarjiTanxaLari.DisplayFormat.FormatString = "{0:0.00##}";
            this.colXarjiTanxaLari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXarjiTanxaLari.FieldName = "XarjiTanxaLari";
            this.colXarjiTanxaLari.Name = "colXarjiTanxaLari";
            this.colXarjiTanxaLari.Visible = true;
            this.colXarjiTanxaLari.VisibleIndex = 8;
            // 
            // colUN
            // 
            this.colUN.Caption = "მომხმარებელი";
            this.colUN.FieldName = "UN";
            this.colUN.Name = "colUN";
            this.colUN.Visible = true;
            this.colUN.VisibleIndex = 11;
            // 
            // colCD
            // 
            this.colCD.Caption = "შეტანის დრო";
            this.colCD.FieldName = "CD";
            this.colCD.Name = "colCD";
            this.colCD.Visible = true;
            this.colCD.VisibleIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1137, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "კროს ცხრილი";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pt
            // 
            this.pt.Appearance.Cell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.Cell.Options.UseFont = true;
            this.pt.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pt.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.CustomTotalCell.Options.UseFont = true;
            this.pt.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pt.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.Empty.Options.UseFont = true;
            this.pt.Appearance.ExpandButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.ExpandButton.Options.UseFont = true;
            this.pt.Appearance.FieldHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldHeader.Options.UseFont = true;
            this.pt.Appearance.FieldValue.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldValue.Options.UseFont = true;
            this.pt.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldValueGrandTotal.Options.UseFont = true;
            this.pt.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FieldValueTotal.Options.UseFont = true;
            this.pt.Appearance.FilterHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FilterHeaderArea.Options.UseFont = true;
            this.pt.Appearance.FilterSeparator.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FilterSeparator.Options.UseFont = true;
            this.pt.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.FocusedCell.Options.UseFont = true;
            this.pt.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.GrandTotalCell.Options.UseFont = true;
            this.pt.Appearance.HeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.HeaderArea.Options.UseFont = true;
            this.pt.Appearance.HeaderFilterButton.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.HeaderFilterButton.Options.UseFont = true;
            this.pt.Appearance.HeaderFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.HeaderFilterButtonActive.Options.UseFont = true;
            this.pt.Appearance.Lines.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.Lines.Options.UseFont = true;
            this.pt.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.RowHeaderArea.Options.UseFont = true;
            this.pt.Appearance.SelectedCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.SelectedCell.Options.UseFont = true;
            this.pt.Appearance.TotalCell.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pt.Appearance.TotalCell.Options.UseFont = true;
            this.pt.Cursor = System.Windows.Forms.Cursors.Default;
            this.pt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pt.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pcolData,
            this.pcolMomc,
            this.pcolYear,
            this.pcolQuarter,
            this.pcolXarjiTanxa,
            this.pcolValuta,
            this.pcolKursi,
            this.pcolXarjiTanxaLari,
            this.pcolZedd,
            this.pcolShen,
            this.pcolXarjiT,
            this.pcolMonth,
            this.pcolDayOfWeek,
            this.pcolDayOfYear,
            this.pcolWeekOfYear});
            this.pt.Location = new System.Drawing.Point(3, 3);
            this.pt.Name = "pt";
            this.pt.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea;
            this.pt.OptionsDataField.AreaIndex = 1;
            this.pt.Size = new System.Drawing.Size(1131, 459);
            this.pt.TabIndex = 2;
            // 
            // pcolData
            // 
            this.pcolData.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolData.AreaIndex = 0;
            this.pcolData.Caption = "თარიღი";
            this.pcolData.FieldName = "Data";
            this.pcolData.Name = "pcolData";
            this.pcolData.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // pcolMomc
            // 
            this.pcolMomc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pcolMomc.AreaIndex = 0;
            this.pcolMomc.Caption = "მომწოდებელი";
            this.pcolMomc.FieldName = "Momc";
            this.pcolMomc.Name = "pcolMomc";
            // 
            // pcolYear
            // 
            this.pcolYear.AreaIndex = 0;
            this.pcolYear.Caption = "წელი";
            this.pcolYear.FieldName = "Data";
            this.pcolYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.pcolYear.Name = "pcolYear";
            this.pcolYear.UnboundFieldName = "pcolYear";
            this.pcolYear.Visible = false;
            // 
            // pcolQuarter
            // 
            this.pcolQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolQuarter.AreaIndex = 0;
            this.pcolQuarter.Caption = "კვარტალი";
            this.pcolQuarter.FieldName = "Data";
            this.pcolQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.pcolQuarter.Name = "pcolQuarter";
            this.pcolQuarter.UnboundFieldName = "pcolQuarter";
            this.pcolQuarter.Visible = false;
            // 
            // pcolXarjiTanxa
            // 
            this.pcolXarjiTanxa.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pcolXarjiTanxa.AreaIndex = 0;
            this.pcolXarjiTanxa.Caption = "თანხა";
            this.pcolXarjiTanxa.CellFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxa.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolXarjiTanxa.FieldName = "XarjiTanxa";
            this.pcolXarjiTanxa.Name = "pcolXarjiTanxa";
            this.pcolXarjiTanxa.TotalCellFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxa.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolXarjiTanxa.TotalValueFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxa.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolXarjiTanxa.ValueFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxa.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pcolValuta
            // 
            this.pcolValuta.AreaIndex = 0;
            this.pcolValuta.Caption = "ვალუტა";
            this.pcolValuta.FieldName = "Valuta";
            this.pcolValuta.Name = "pcolValuta";
            // 
            // pcolKursi
            // 
            this.pcolKursi.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolKursi.AreaIndex = 1;
            this.pcolKursi.Caption = "კურსი";
            this.pcolKursi.CellFormat.FormatString = "{0:0.00##}";
            this.pcolKursi.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolKursi.FieldName = "Kursi";
            this.pcolKursi.Name = "pcolKursi";
            this.pcolKursi.TotalCellFormat.FormatString = "{0:0.00##}";
            this.pcolKursi.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolKursi.TotalValueFormat.FormatString = "{0:0.00##}";
            this.pcolKursi.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolKursi.ValueFormat.FormatString = "{0:0.00##}";
            this.pcolKursi.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolKursi.Visible = false;
            // 
            // pcolXarjiTanxaLari
            // 
            this.pcolXarjiTanxaLari.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pcolXarjiTanxaLari.AreaIndex = 1;
            this.pcolXarjiTanxaLari.Caption = "თანხა ლარი";
            this.pcolXarjiTanxaLari.CellFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxaLari.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolXarjiTanxaLari.FieldName = "XarjiTanxaLari";
            this.pcolXarjiTanxaLari.Name = "pcolXarjiTanxaLari";
            this.pcolXarjiTanxaLari.TotalCellFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxaLari.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolXarjiTanxaLari.TotalValueFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxaLari.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pcolXarjiTanxaLari.ValueFormat.FormatString = "{0:0.00##}";
            this.pcolXarjiTanxaLari.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pcolZedd
            // 
            this.pcolZedd.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolZedd.AreaIndex = 3;
            this.pcolZedd.Caption = "ზედდებული";
            this.pcolZedd.FieldName = "Zedd";
            this.pcolZedd.Name = "pcolZedd";
            this.pcolZedd.Visible = false;
            // 
            // pcolShen
            // 
            this.pcolShen.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolShen.AreaIndex = 3;
            this.pcolShen.Caption = "შენიშვნა";
            this.pcolShen.FieldName = "Shen";
            this.pcolShen.Name = "pcolShen";
            this.pcolShen.Visible = false;
            // 
            // pcolXarjiT
            // 
            this.pcolXarjiT.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolXarjiT.AreaIndex = 2;
            this.pcolXarjiT.Caption = "ხარჯის ტიპი";
            this.pcolXarjiT.FieldName = "XarjiT";
            this.pcolXarjiT.Name = "pcolXarjiT";
            this.pcolXarjiT.Visible = false;
            // 
            // pcolMonth
            // 
            this.pcolMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolMonth.AreaIndex = 2;
            this.pcolMonth.Caption = "თვე";
            this.pcolMonth.FieldName = "Data";
            this.pcolMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.pcolMonth.Name = "pcolMonth";
            this.pcolMonth.UnboundFieldName = "pcolMonth";
            this.pcolMonth.Visible = false;
            // 
            // pcolDayOfWeek
            // 
            this.pcolDayOfWeek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolDayOfWeek.AreaIndex = 3;
            this.pcolDayOfWeek.Caption = "კვირის დღე";
            this.pcolDayOfWeek.FieldName = "Data";
            this.pcolDayOfWeek.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfWeek;
            this.pcolDayOfWeek.Name = "pcolDayOfWeek";
            this.pcolDayOfWeek.UnboundFieldName = "pcolDayOfWeek";
            this.pcolDayOfWeek.Visible = false;
            // 
            // pcolDayOfYear
            // 
            this.pcolDayOfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolDayOfYear.AreaIndex = 4;
            this.pcolDayOfYear.Caption = "წლის დღე";
            this.pcolDayOfYear.FieldName = "Data";
            this.pcolDayOfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDayOfYear;
            this.pcolDayOfYear.Name = "pcolDayOfYear";
            this.pcolDayOfYear.UnboundFieldName = "pcolDayOfYear";
            this.pcolDayOfYear.Visible = false;
            // 
            // pcolWeekOfYear
            // 
            this.pcolWeekOfYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pcolWeekOfYear.AreaIndex = 5;
            this.pcolWeekOfYear.Caption = "კვირა";
            this.pcolWeekOfYear.FieldName = "Data";
            this.pcolWeekOfYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateWeekOfYear;
            this.pcolWeekOfYear.Name = "pcolWeekOfYear";
            this.pcolWeekOfYear.UnboundFieldName = "pcolWeekOfYear";
            this.pcolWeekOfYear.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartControl1);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1137, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "გრაფიკი";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(3, 39);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Mixed";
            this.chartControl1.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Black, System.Drawing.Color.Black),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Gray, System.Drawing.Color.Gray),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Silver, System.Drawing.Color.Silver)}));
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.Size = new System.Drawing.Size(1131, 423);
            this.chartControl1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChartType);
            this.panel3.Controls.Add(this.cbChartOrientation);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chbShowValues);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1131, 36);
            this.panel3.TabIndex = 1;
            // 
            // cbChartType
            // 
            this.cbChartType.Location = new System.Drawing.Point(391, 8);
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChartType.Properties.Appearance.Options.UseFont = true;
            this.cbChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChartType.Size = new System.Drawing.Size(146, 21);
            this.cbChartType.TabIndex = 6;
            // 
            // cbChartOrientation
            // 
            this.cbChartOrientation.Location = new System.Drawing.Point(127, 10);
            this.cbChartOrientation.Name = "cbChartOrientation";
            this.cbChartOrientation.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChartOrientation.Properties.Appearance.Options.UseFont = true;
            this.cbChartOrientation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChartOrientation.Size = new System.Drawing.Size(146, 21);
            this.cbChartOrientation.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "გრაფიკის სტილი";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "გრაფიკის ორიენტ.";
            // 
            // chbShowValues
            // 
            this.chbShowValues.AutoSize = true;
            this.chbShowValues.Checked = true;
            this.chbShowValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowValues.Location = new System.Drawing.Point(603, 9);
            this.chbShowValues.Name = "chbShowValues";
            this.chbShowValues.Size = new System.Drawing.Size(215, 20);
            this.chbShowValues.TabIndex = 2;
            this.chbShowValues.Text = "გრაფიკზე მნიშვნელობის გამოჩენა";
            this.chbShowValues.UseVisualStyleBackColor = true;
            // 
            // FindMenu
            // 
            this.FindMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFind,
            this.ბეჭდვაToolStripMenuItem,
            this.miPrint,
            this.miExcel,
            this.toolStripMenuItem1,
            this.miSaveDGlayout,
            this.miRestoreDGlayout,
            this.toolStripMenuItem3,
            this.miSavePTlayout,
            this.miRestorePTlayout});
            this.FindMenu.Name = "FindMenu";
            this.FindMenu.Size = new System.Drawing.Size(292, 176);
            // 
            // miFind
            // 
            this.miFind.Image = global::SBS_Market.Properties.Resources.FFind;
            this.miFind.Name = "miFind";
            this.miFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.miFind.Size = new System.Drawing.Size(291, 22);
            this.miFind.Text = "ძებნა";
            // 
            // ბეჭდვაToolStripMenuItem
            // 
            this.ბეჭდვაToolStripMenuItem.Name = "ბეჭდვაToolStripMenuItem";
            this.ბეჭდვაToolStripMenuItem.Size = new System.Drawing.Size(288, 6);
            // 
            // miPrint
            // 
            this.miPrint.Image = global::SBS_Market.Properties.Resources.FPrint;
            this.miPrint.Name = "miPrint";
            this.miPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.miPrint.Size = new System.Drawing.Size(291, 22);
            this.miPrint.Text = "ბეჭდვა";
            // 
            // miExcel
            // 
            this.miExcel.Image = global::SBS_Market.Properties.Resources.FExcel;
            this.miExcel.Name = "miExcel";
            this.miExcel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miExcel.Size = new System.Drawing.Size(291, 22);
            this.miExcel.Text = "Excel-ში გადატანა";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(288, 6);
            // 
            // miSaveDGlayout
            // 
            this.miSaveDGlayout.Image = global::SBS_Market.Properties.Resources.FSaveDGlayout;
            this.miSaveDGlayout.Name = "miSaveDGlayout";
            this.miSaveDGlayout.Size = new System.Drawing.Size(291, 22);
            this.miSaveDGlayout.Text = "ცხრილის პარამეტრების შენახვა";
            // 
            // miRestoreDGlayout
            // 
            this.miRestoreDGlayout.Image = global::SBS_Market.Properties.Resources.FRestoreDGlayout;
            this.miRestoreDGlayout.Name = "miRestoreDGlayout";
            this.miRestoreDGlayout.Size = new System.Drawing.Size(291, 22);
            this.miRestoreDGlayout.Text = "ცხრილის პარამეტრების აღდგენა";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(288, 6);
            // 
            // miSavePTlayout
            // 
            this.miSavePTlayout.Image = global::SBS_Market.Properties.Resources.FSavePTlayout;
            this.miSavePTlayout.Name = "miSavePTlayout";
            this.miSavePTlayout.Size = new System.Drawing.Size(291, 22);
            this.miSavePTlayout.Text = "კროს ცხრილის პარამეტრების შენახვა";
            // 
            // miRestorePTlayout
            // 
            this.miRestorePTlayout.Image = global::SBS_Market.Properties.Resources.FRestorePTlayout;
            this.miRestorePTlayout.Name = "miRestorePTlayout";
            this.miRestorePTlayout.Size = new System.Drawing.Size(291, 22);
            this.miRestorePTlayout.Text = "კროს ცხრილის პარამეტრების აღდგენა";
            // 
            // FXarjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 656);
            this.ContextMenuStrip = this.FindMenu;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FXarjiForm";
            this.Text = "ძებნა (შესყიდვის ხარჯები)";
            this.Load += new System.EventHandler(this.FXarjiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData1.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pt)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChartOrientation.Properties)).EndInit();
            this.FindMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PanelControl panel1;
        private DateEdit txtData2;
        private DateEdit txtData1;
        private System.Windows.Forms.CheckBox chbXarjiT;
        private System.Windows.Forms.CheckBox chbMomc;
        private System.Windows.Forms.CheckBox chbData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private DevExpress.XtraEditors.LookUpEdit cbXarjiT;
        private DevExpress.XtraEditors.LookUpEdit cbMomc;
        private PanelControl panel2;
        private System.Windows.Forms.CheckBox chbTotal;
        private DevExpress.XtraEditors.CheckedListBoxControl chbList;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripComboBox cbFileName;
        private System.Windows.Forms.CheckBox chbZedd;
        private TextEdit txtZedd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl dg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdShes1;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colZedd;
        private DevExpress.XtraGrid.Columns.GridColumn colXarjiT;
        private DevExpress.XtraGrid.Columns.GridColumn colShen;
        private DevExpress.XtraGrid.Columns.GridColumn colMomc;
        private DevExpress.XtraGrid.Columns.GridColumn colXarjiTanxa;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraPivotGrid.PivotGridControl pt;
        private DevExpress.XtraPivotGrid.PivotGridField pcolData;
        private DevExpress.XtraPivotGrid.PivotGridField pcolMomc;
        private DevExpress.XtraPivotGrid.PivotGridField pcolYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolQuarter;
        private System.Windows.Forms.CheckBox chbCross;
        private DevExpress.XtraPivotGrid.PivotGridField pcolXarjiTanxa;
        private DevExpress.XtraPivotGrid.PivotGridField pcolZedd;
        private DevExpress.XtraPivotGrid.PivotGridField pcolShen;
        private DevExpress.XtraPivotGrid.PivotGridField pcolXarjiT;
        private System.Windows.Forms.ToolStripComboBox cbXML;
        private System.Windows.Forms.ToolStripButton btnSaveDGlayout;
        private System.Windows.Forms.ToolStripButton btnRestoreDGlayout;
        private System.Windows.Forms.ToolStripComboBox cbPivotXML;
        private System.Windows.Forms.ToolStripButton btnSavePTlayout;
        private System.Windows.Forms.ToolStripButton btnRestorePTlayout;
        private System.Windows.Forms.ContextMenuStrip FindMenu;
        private System.Windows.Forms.ToolStripMenuItem miFind;
        private System.Windows.Forms.ToolStripSeparator ბეჭდვაToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripMenuItem miExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miSaveDGlayout;
        private System.Windows.Forms.ToolStripMenuItem miRestoreDGlayout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miSavePTlayout;
        private System.Windows.Forms.ToolStripMenuItem miRestorePTlayout;
        private TextEdit txtFactura;
        private System.Windows.Forms.CheckBox chbFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraPivotGrid.PivotGridField pcolMonth;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfWeek;
        private DevExpress.XtraPivotGrid.PivotGridField pcolDayOfYear;
        private DevExpress.XtraPivotGrid.PivotGridField pcolWeekOfYear;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private PanelControl panel3;
        private DevExpress.XtraEditors.ComboBoxEdit cbChartType;
        private DevExpress.XtraEditors.ComboBoxEdit cbChartOrientation;
        private LabelControl label2;
        private LabelControl label1;
        private System.Windows.Forms.CheckBox chbShowValues;
        private System.Windows.Forms.CheckBox chbChart;
        private DevExpress.XtraGrid.Columns.GridColumn colUN;
        private DevExpress.XtraGrid.Columns.GridColumn colCD;
        private System.Windows.Forms.ToolStripComboBox cbExportFormat;
        private DevExpress.XtraEditors.LookUpEdit cbValuta;
        private System.Windows.Forms.CheckBox chbValuta;
        private DevExpress.XtraGrid.Columns.GridColumn colValuta;
        private DevExpress.XtraGrid.Columns.GridColumn colKursi;
        private DevExpress.XtraGrid.Columns.GridColumn colXarjiTanxaLari;
        private DevExpress.XtraPivotGrid.PivotGridField pcolValuta;
        private DevExpress.XtraPivotGrid.PivotGridField pcolKursi;
        private DevExpress.XtraPivotGrid.PivotGridField pcolXarjiTanxaLari;
        private DevExpress.XtraGrid.Columns.GridColumn colXarji;
        private System.Windows.Forms.ToolStripButton btnGridViewSettings;
        private System.Windows.Forms.ToolStripButton btnPivotTableSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnHideSearchPanel;
    }
}