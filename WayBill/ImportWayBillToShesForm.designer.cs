using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.WayBill
{
    partial class ImportWayBillToShesForm
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
            this.paShes1 = new DevExpress.XtraEditors.PanelControl();
            this.txtKursi = new DevExpress.XtraEditors.SpinEdit();
            this.cbCalcType = new System.Windows.Forms.ComboBox();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.txtIdShesWayBill1 = new DevExpress.XtraEditors.TextEdit();
            this.chbIncludeDgg = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.cbMomc = new System.Windows.Forms.ComboBox();
            this.laMomc = new DevExpress.XtraEditors.LabelControl();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.cbShesT = new System.Windows.Forms.ComboBox();
            this.cbProek = new System.Windows.Forms.ComboBox();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.txtData = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtShen = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label23 = new DevExpress.XtraEditors.LabelControl();
            this.txtZedd = new DevExpress.XtraEditors.TextEdit();
            this.btnChangeMomcCode = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dgRealRs = new DevExpress.XtraGrid.GridControl();
            this.gvRealRs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsBAR_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsW_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsPRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWinaFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSxvaoba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsAMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsIdProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsDgg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRsKoef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompRaodFasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRaodTanxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new DevExpress.XtraEditors.PanelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtKoef = new DevExpress.XtraEditors.SpinEdit();
            this.btnNameMatch = new DevExpress.XtraEditors.SimpleButton();
            this.chbFasiUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.colUNIT_TXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paShes1)).BeginInit();
            this.paShes1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKursi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdShesWayBill1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIncludeDgg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRealRs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRealRs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoef.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFasiUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // paShes1
            // 
            this.paShes1.Controls.Add(this.txtKursi);
            this.paShes1.Controls.Add(this.cbCalcType);
            this.paShes1.Controls.Add(this.label8);
            this.paShes1.Controls.Add(this.txtFactura);
            this.paShes1.Controls.Add(this.txtIdShesWayBill1);
            this.paShes1.Controls.Add(this.chbIncludeDgg);
            this.paShes1.Controls.Add(this.label2);
            this.paShes1.Controls.Add(this.cbMomc);
            this.paShes1.Controls.Add(this.laMomc);
            this.paShes1.Controls.Add(this.cbValuta);
            this.paShes1.Controls.Add(this.cbShesT);
            this.paShes1.Controls.Add(this.cbProek);
            this.paShes1.Controls.Add(this.label6);
            this.paShes1.Controls.Add(this.txtData);
            this.paShes1.Controls.Add(this.label1);
            this.paShes1.Controls.Add(this.txtShen);
            this.paShes1.Controls.Add(this.label5);
            this.paShes1.Controls.Add(this.label4);
            this.paShes1.Controls.Add(this.label3);
            this.paShes1.Controls.Add(this.label23);
            this.paShes1.Controls.Add(this.txtZedd);
            this.paShes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paShes1.Location = new System.Drawing.Point(0, 0);
            this.paShes1.Name = "paShes1";
            this.paShes1.Size = new System.Drawing.Size(1202, 240);
            this.paShes1.TabIndex = 0;
            // 
            // txtKursi
            // 
            this.txtKursi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtKursi.Location = new System.Drawing.Point(151, 87);
            this.txtKursi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKursi.Name = "txtKursi";
            this.txtKursi.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKursi.Properties.Appearance.Options.UseFont = true;
            this.txtKursi.Properties.DisplayFormat.FormatString = "f4";
            this.txtKursi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKursi.Properties.EditFormat.FormatString = "f4";
            this.txtKursi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKursi.Properties.Mask.EditMask = "f4";
            this.txtKursi.Size = new System.Drawing.Size(86, 22);
            this.txtKursi.TabIndex = 93;
            // 
            // cbCalcType
            // 
            this.cbCalcType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCalcType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCalcType.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCalcType.FormattingEnabled = true;
            this.cbCalcType.Location = new System.Drawing.Point(657, 146);
            this.cbCalcType.Name = "cbCalcType";
            this.cbCalcType.Size = new System.Drawing.Size(233, 24);
            this.cbCalcType.TabIndex = 92;
            this.cbCalcType.Visible = false;
            // 
            // label8
            // 
            this.label8.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "ფაქტურა";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(290, 31);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Properties.Appearance.Options.UseFont = true;
            this.txtFactura.Size = new System.Drawing.Size(118, 22);
            this.txtFactura.TabIndex = 2;
            // 
            // txtIdShesWayBill1
            // 
            this.txtIdShesWayBill1.Location = new System.Drawing.Point(467, 147);
            this.txtIdShesWayBill1.Name = "txtIdShesWayBill1";
            this.txtIdShesWayBill1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdShesWayBill1.Properties.Appearance.Options.UseFont = true;
            this.txtIdShesWayBill1.Size = new System.Drawing.Size(118, 22);
            this.txtIdShesWayBill1.TabIndex = 88;
            this.txtIdShesWayBill1.Visible = false;
            // 
            // chbIncludeDgg
            // 
            this.chbIncludeDgg.Location = new System.Drawing.Point(290, 88);
            this.chbIncludeDgg.Name = "chbIncludeDgg";
            this.chbIncludeDgg.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIncludeDgg.Properties.Appearance.Options.UseFont = true;
            this.chbIncludeDgg.Properties.AutoWidth = true;
            this.chbIncludeDgg.Properties.Caption = "ფასები შეიცავს დღგ-ს?";
            this.chbIncludeDgg.Size = new System.Drawing.Size(151, 20);
            this.chbIncludeDgg.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "კურსი";
            // 
            // cbMomc
            // 
            this.cbMomc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMomc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMomc.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMomc.FormattingEnabled = true;
            this.cbMomc.Location = new System.Drawing.Point(467, 30);
            this.cbMomc.Name = "cbMomc";
            this.cbMomc.Size = new System.Drawing.Size(423, 24);
            this.cbMomc.TabIndex = 3;
            this.cbMomc.SelectedIndexChanged += new System.EventHandler(this.cbMomc_SelectedIndexChanged);
            this.cbMomc.Leave += new System.EventHandler(this.cbMomc_Leave);
            // 
            // laMomc
            // 
            this.laMomc.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMomc.Location = new System.Drawing.Point(467, 10);
            this.laMomc.Name = "laMomc";
            this.laMomc.Size = new System.Drawing.Size(82, 16);
            this.laMomc.TabIndex = 81;
            this.laMomc.Text = "მომწოდებელი";
            // 
            // cbValuta
            // 
            this.cbValuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbValuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbValuta.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(22, 86);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(108, 24);
            this.cbValuta.TabIndex = 4;
            // 
            // cbShesT
            // 
            this.cbShesT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbShesT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbShesT.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShesT.FormattingEnabled = true;
            this.cbShesT.Location = new System.Drawing.Point(22, 146);
            this.cbShesT.Name = "cbShesT";
            this.cbShesT.Size = new System.Drawing.Size(385, 24);
            this.cbShesT.TabIndex = 9;
            // 
            // cbProek
            // 
            this.cbProek.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProek.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProek.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProek.FormattingEnabled = true;
            this.cbProek.Location = new System.Drawing.Point(467, 86);
            this.cbProek.Name = "cbProek";
            this.cbProek.Size = new System.Drawing.Size(423, 24);
            this.cbProek.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "ვალუტა";
            // 
            // txtData
            // 
            this.txtData.EditValue = new System.DateTime(2007, 2, 24, 12, 22, 2, 734);
            this.txtData.Location = new System.Drawing.Point(22, 31);
            this.txtData.Name = "txtData";
            this.txtData.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Properties.Appearance.Options.UseFont = true;
            this.txtData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtData.Properties.DisplayFormat.FormatString = "d.M.yyyy";
            this.txtData.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.EditFormat.FormatString = "d.M.yyyy";
            this.txtData.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtData.Properties.Mask.EditMask = "d.M.yyyy";
            this.txtData.Size = new System.Drawing.Size(107, 22);
            this.txtData.TabIndex = 0;
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "შენიშვნა";
            // 
            // txtShen
            // 
            this.txtShen.Location = new System.Drawing.Point(22, 207);
            this.txtShen.Name = "txtShen";
            this.txtShen.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShen.Properties.Appearance.Options.UseFont = true;
            this.txtShen.Size = new System.Drawing.Size(867, 22);
            this.txtShen.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "შესყიდვის ტიპი";
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "ობიექტი";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "თარიღი";
            // 
            // label23
            // 
            this.label23.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(151, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 16);
            this.label23.TabIndex = 68;
            this.label23.Text = "ზედდებული";
            // 
            // txtZedd
            // 
            this.txtZedd.Location = new System.Drawing.Point(151, 31);
            this.txtZedd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZedd.Name = "txtZedd";
            this.txtZedd.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZedd.Properties.Appearance.Options.UseFont = true;
            this.txtZedd.Size = new System.Drawing.Size(118, 22);
            this.txtZedd.TabIndex = 1;
            // 
            // btnChangeMomcCode
            // 
            this.btnChangeMomcCode.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeMomcCode.Appearance.Options.UseFont = true;
            this.btnChangeMomcCode.AutoSize = true;
            this.btnChangeMomcCode.Location = new System.Drawing.Point(570, 6);
            this.btnChangeMomcCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeMomcCode.Name = "btnChangeMomcCode";
            this.btnChangeMomcCode.Size = new System.Drawing.Size(100, 25);
            this.btnChangeMomcCode.TabIndex = 134;
            this.btnChangeMomcCode.Text = "კოდის შეცვლა";
            this.btnChangeMomcCode.Click += new System.EventHandler(this.btnChangeMomcCode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 34);
            this.panel1.TabIndex = 32;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1115, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            // 
            // dgRealRs
            // 
            this.dgRealRs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRealRs.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgRealRs.Location = new System.Drawing.Point(0, 283);
            this.dgRealRs.MainView = this.gvRealRs;
            this.dgRealRs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgRealRs.Name = "dgRealRs";
            this.dgRealRs.Size = new System.Drawing.Size(1202, 239);
            this.dgRealRs.TabIndex = 34;
            this.dgRealRs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRealRs});
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
            this.colWinaFasi,
            this.colSxvaoba,
            this.colRsAMOUNT,
            this.colRsIdProd,
            this.colRsDgg,
            this.colRsKoef,
            this.colFasi,
            this.colCompRaodFasi,
            this.colRaodTanxa,
            this.colProd,
            this.colUNIT_TXT,
            this.colUnit});
            this.gvRealRs.FooterPanelHeight = 1;
            this.gvRealRs.GridControl = this.dgRealRs;
            this.gvRealRs.GroupPanelText = "დაჯგუფება";
            this.gvRealRs.GroupRowHeight = 1;
            this.gvRealRs.Name = "gvRealRs";
            this.gvRealRs.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvRealRs.OptionsDetail.AllowZoomDetail = false;
            this.gvRealRs.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvRealRs.OptionsSelection.MultiSelect = true;
            this.gvRealRs.OptionsView.ColumnAutoWidth = false;
            this.gvRealRs.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvRealRs.OptionsView.ShowAutoFilterRow = true;
            this.gvRealRs.OptionsView.ShowDetailButtons = false;
            this.gvRealRs.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvRealRs.OptionsView.ShowFooter = true;
            this.gvRealRs.OptionsView.ShowGroupPanel = false;
            this.gvRealRs.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvRealRs_RowStyle);
            this.gvRealRs.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvRealRs_FocusedRowChanged);
            this.gvRealRs.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvRealRs_CellValueChanged);
            // 
            // colRsID
            // 
            this.colRsID.Caption = "მიმდ.";
            this.colRsID.FieldName = "ID";
            this.colRsID.Name = "colRsID";
            // 
            // colRsBAR_CODE
            // 
            this.colRsBAR_CODE.Caption = "კოდი RS.GE-ზე";
            this.colRsBAR_CODE.FieldName = "BAR_CODE";
            this.colRsBAR_CODE.Name = "colRsBAR_CODE";
            this.colRsBAR_CODE.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colRsBAR_CODE.OptionsColumn.ReadOnly = true;
            this.colRsBAR_CODE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProd", "")});
            this.colRsBAR_CODE.Visible = true;
            this.colRsBAR_CODE.VisibleIndex = 1;
            this.colRsBAR_CODE.Width = 108;
            // 
            // colRsW_NAME
            // 
            this.colRsW_NAME.Caption = "პროდუქცია RS-ზე";
            this.colRsW_NAME.FieldName = "W_NAME";
            this.colRsW_NAME.Name = "colRsW_NAME";
            this.colRsW_NAME.OptionsColumn.ReadOnly = true;
            this.colRsW_NAME.Visible = true;
            this.colRsW_NAME.VisibleIndex = 2;
            this.colRsW_NAME.Width = 185;
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
            this.colRsQUANTITY.VisibleIndex = 6;
            this.colRsQUANTITY.Width = 80;
            // 
            // colRsPRICE
            // 
            this.colRsPRICE.Caption = "ფასი";
            this.colRsPRICE.DisplayFormat.FormatString = "{0:0.00##}";
            this.colRsPRICE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRsPRICE.FieldName = "PRICE";
            this.colRsPRICE.Name = "colRsPRICE";
            this.colRsPRICE.OptionsColumn.ReadOnly = true;
            this.colRsPRICE.Visible = true;
            this.colRsPRICE.VisibleIndex = 7;
            this.colRsPRICE.Width = 63;
            // 
            // colWinaFasi
            // 
            this.colWinaFasi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colWinaFasi.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colWinaFasi.AppearanceCell.Options.UseBackColor = true;
            this.colWinaFasi.Caption = "წინა ფასი";
            this.colWinaFasi.DisplayFormat.FormatString = "{0:0.00##}";
            this.colWinaFasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWinaFasi.FieldName = "WinaFasi";
            this.colWinaFasi.Name = "colWinaFasi";
            this.colWinaFasi.OptionsColumn.ReadOnly = true;
            this.colWinaFasi.Visible = true;
            this.colWinaFasi.VisibleIndex = 8;
            // 
            // colSxvaoba
            // 
            this.colSxvaoba.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colSxvaoba.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colSxvaoba.AppearanceCell.Options.UseBackColor = true;
            this.colSxvaoba.Caption = "სხვაობა";
            this.colSxvaoba.DisplayFormat.FormatString = "{0:0.00##}";
            this.colSxvaoba.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSxvaoba.FieldName = "Sxvaoba";
            this.colSxvaoba.Name = "colSxvaoba";
            this.colSxvaoba.OptionsColumn.ReadOnly = true;
            this.colSxvaoba.Visible = true;
            this.colSxvaoba.VisibleIndex = 9;
            // 
            // colRsAMOUNT
            // 
            this.colRsAMOUNT.Caption = "თანხა";
            this.colRsAMOUNT.DisplayFormat.FormatString = "{0:0.00##}";
            this.colRsAMOUNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRsAMOUNT.FieldName = "AMOUNT";
            this.colRsAMOUNT.Name = "colRsAMOUNT";
            this.colRsAMOUNT.OptionsColumn.ReadOnly = true;
            this.colRsAMOUNT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMOUNT", "{0:#.00##}")});
            this.colRsAMOUNT.Visible = true;
            this.colRsAMOUNT.VisibleIndex = 10;
            // 
            // colRsIdProd
            // 
            this.colRsIdProd.Caption = "კოდი";
            this.colRsIdProd.FieldName = "IdProd";
            this.colRsIdProd.Name = "colRsIdProd";
            this.colRsIdProd.Visible = true;
            this.colRsIdProd.VisibleIndex = 0;
            this.colRsIdProd.Width = 102;
            // 
            // colRsDgg
            // 
            this.colRsDgg.Caption = "დღგ";
            this.colRsDgg.FieldName = "Dgg";
            this.colRsDgg.Name = "colRsDgg";
            this.colRsDgg.OptionsColumn.ReadOnly = true;
            this.colRsDgg.Visible = true;
            this.colRsDgg.VisibleIndex = 11;
            // 
            // colRsKoef
            // 
            this.colRsKoef.Caption = "კოეფიციენტი";
            this.colRsKoef.FieldName = "Koef";
            this.colRsKoef.Name = "colRsKoef";
            this.colRsKoef.OptionsColumn.ReadOnly = true;
            this.colRsKoef.Visible = true;
            this.colRsKoef.VisibleIndex = 12;
            // 
            // colFasi
            // 
            this.colFasi.Caption = "გასაყიდი ფასი";
            this.colFasi.FieldName = "Fasi";
            this.colFasi.Name = "colFasi";
            // 
            // colCompRaodFasi
            // 
            this.colCompRaodFasi.Caption = "ფასი კომპ.";
            this.colCompRaodFasi.DisplayFormat.FormatString = "0.00#";
            this.colCompRaodFasi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCompRaodFasi.FieldName = "CompRaodFasi";
            this.colCompRaodFasi.Name = "colCompRaodFasi";
            // 
            // colRaodTanxa
            // 
            this.colRaodTanxa.Caption = "თანხა";
            this.colRaodTanxa.FieldName = "RaodTanxa";
            this.colRaodTanxa.Name = "colRaodTanxa";
            this.colRaodTanxa.OptionsColumn.AllowEdit = false;
            // 
            // colProd
            // 
            this.colProd.Caption = "დასახელება პროგრამაში";
            this.colProd.FieldName = "Prod";
            this.colProd.Name = "colProd";
            this.colProd.Visible = true;
            this.colProd.VisibleIndex = 3;
            this.colProd.Width = 179;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtKoef);
            this.panel3.Controls.Add(this.btnNameMatch);
            this.panel3.Controls.Add(this.btnChangeMomcCode);
            this.panel3.Controls.Add(this.chbFasiUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 43);
            this.panel3.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 139;
            this.label7.Text = "კოეფიციენტი";
            // 
            // txtKoef
            // 
            this.txtKoef.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtKoef.Location = new System.Drawing.Point(469, 11);
            this.txtKoef.Name = "txtKoef";
            this.txtKoef.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoef.Properties.Appearance.Options.UseFont = true;
            this.txtKoef.Properties.DisplayFormat.FormatString = "f4";
            this.txtKoef.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKoef.Properties.EditFormat.FormatString = "f4";
            this.txtKoef.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtKoef.Properties.Mask.EditMask = "f4";
            this.txtKoef.Size = new System.Drawing.Size(71, 22);
            this.txtKoef.TabIndex = 138;
            // 
            // btnNameMatch
            // 
            this.btnNameMatch.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNameMatch.Appearance.Options.UseFont = true;
            this.btnNameMatch.AutoSize = true;
            this.btnNameMatch.Location = new System.Drawing.Point(711, 6);
            this.btnNameMatch.Name = "btnNameMatch";
            this.btnNameMatch.Size = new System.Drawing.Size(171, 25);
            this.btnNameMatch.TabIndex = 134;
            this.btnNameMatch.Text = "დასახელებით დამთხვევა";
            this.btnNameMatch.Click += new System.EventHandler(this.btnNameMatch_Click);
            // 
            // chbFasiUpdate
            // 
            this.chbFasiUpdate.Location = new System.Drawing.Point(12, 12);
            this.chbFasiUpdate.Name = "chbFasiUpdate";
            this.chbFasiUpdate.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFasiUpdate.Properties.Appearance.Options.UseFont = true;
            this.chbFasiUpdate.Properties.AutoWidth = true;
            this.chbFasiUpdate.Properties.Caption = "გასაყიდი ფასების შეტანა";
            this.chbFasiUpdate.Size = new System.Drawing.Size(162, 20);
            this.chbFasiUpdate.TabIndex = 8;
            this.chbFasiUpdate.CheckedChanged += new System.EventHandler(this.chbFasiUpdate_CheckedChanged);
            // 
            // colUNIT_TXT
            // 
            this.colUNIT_TXT.Caption = "ერთეული RS-ზე";
            this.colUNIT_TXT.FieldName = "UNIT_TXT";
            this.colUNIT_TXT.Name = "colUNIT_TXT";
            this.colUNIT_TXT.Visible = true;
            this.colUNIT_TXT.VisibleIndex = 4;
            this.colUNIT_TXT.Width = 100;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "ერთეული";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 5;
            this.colUnit.Width = 100;
            // 
            // ImportWayBillToShesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 556);
            this.Controls.Add(this.dgRealRs);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paShes1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImportWayBillToShesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "შესყიდვის ზედდებულის ჩამოტვირთვა";
            this.Load += new System.EventHandler(this.ImportWayBillToShesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paShes1)).EndInit();
            this.paShes1.ResumeLayout(false);
            this.paShes1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKursi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdShesWayBill1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbIncludeDgg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZedd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRealRs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRealRs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKoef.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbFasiUpdate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paShes1;
        private DevExpress.XtraEditors.PanelControl panel1;
        private SimpleButton btnCancel;
        private CheckEdit chbIncludeDgg;
        private DevExpress.XtraEditors.LabelControl label2;
        private System.Windows.Forms.ComboBox cbMomc;
        private DevExpress.XtraEditors.LabelControl laMomc;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.ComboBox cbShesT;
        private System.Windows.Forms.ComboBox cbProek;
        private DevExpress.XtraEditors.LabelControl label6;
        private DateEdit txtData;
        private DevExpress.XtraEditors.LabelControl label1;
        private TextEdit txtShen;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label23;
        private TextEdit txtZedd;
        private SimpleButton btnAdd;
        private TextEdit txtIdShesWayBill1;
        private DevExpress.XtraGrid.GridControl dgRealRs;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRealRs;
        private DevExpress.XtraGrid.Columns.GridColumn colRsID;
        private DevExpress.XtraGrid.Columns.GridColumn colRsBAR_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRsW_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colRsQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colRsPRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colRsAMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colRsIdProd;
        private DevExpress.XtraGrid.Columns.GridColumn colRsDgg;
        private DevExpress.XtraEditors.LabelControl label8;
        private TextEdit txtFactura;
        private System.Windows.Forms.ComboBox cbCalcType;
        private DevExpress.XtraGrid.Columns.GridColumn colRsKoef;
        private SimpleButton btnChangeMomcCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWinaFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colSxvaoba;
        private DevExpress.XtraEditors.PanelControl panel3;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraGrid.Columns.GridColumn colFasi;
        private CheckEdit chbFasiUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompRaodFasi;
        private DevExpress.XtraGrid.Columns.GridColumn colRaodTanxa;
        private SimpleButton btnNameMatch;
        private SpinEdit txtKoef;
        private SpinEdit txtKursi;
        private DevExpress.XtraGrid.Columns.GridColumn colProd;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_TXT;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
    }
}