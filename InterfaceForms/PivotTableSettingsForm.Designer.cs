using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace SBS_BarthLogistic.InterfaceForms
{
    partial class PivotTableSettingsForm
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.chbCompactStyle = new DevExpress.XtraEditors.CheckEdit();
            this.chbSumRowValues = new DevExpress.XtraEditors.CheckEdit();
            this.chbSumColumnValues = new DevExpress.XtraEditors.CheckEdit();
            this.btnAddField = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpression = new DevExpress.XtraEditors.SimpleButton();
            this.txtExpression = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.laName = new DevExpress.XtraEditors.LabelControl();
            this.btnTopValues = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.chbTopValues = new DevExpress.XtraEditors.CheckEdit();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.txtTopValues = new DevExpress.XtraEditors.CalcEdit();
            this.chbDescended = new DevExpress.XtraEditors.CheckEdit();
            this.paSummary = new DevExpress.XtraEditors.PanelControl();
            this.btnSummaryAdd = new DevExpress.XtraEditors.SimpleButton();
            this.chbMin = new DevExpress.XtraEditors.CheckEdit();
            this.chbCount = new DevExpress.XtraEditors.CheckEdit();
            this.chbAverage = new DevExpress.XtraEditors.CheckEdit();
            this.chbMax = new DevExpress.XtraEditors.CheckEdit();
            this.chbSum = new DevExpress.XtraEditors.CheckEdit();
            this.txtFormatText = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.laFieldName = new DevExpress.XtraEditors.LabelControl();
            this.txtFieldName = new DevExpress.XtraEditors.TextEdit();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.laFormatText = new DevExpress.XtraEditors.LabelControl();
            this.paTop = new DevExpress.XtraEditors.PanelControl();
            this.paBottom = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chbCompactStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSumRowValues.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSumColumnValues.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTopValues.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopValues.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDescended.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSummary)).BeginInit();
            this.paSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAverage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(390, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(288, 4);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chbCompactStyle
            // 
            this.chbCompactStyle.Location = new System.Drawing.Point(13, 39);
            this.chbCompactStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbCompactStyle.Name = "chbCompactStyle";
            this.chbCompactStyle.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbCompactStyle.Properties.Appearance.Options.UseFont = true;
            this.chbCompactStyle.Properties.AutoWidth = true;
            this.chbCompactStyle.Properties.Caption = "კომპაქტური სტილი";
            this.chbCompactStyle.Size = new System.Drawing.Size(135, 20);
            this.chbCompactStyle.TabIndex = 2;
            // 
            // chbSumRowValues
            // 
            this.chbSumRowValues.EditValue = true;
            this.chbSumRowValues.Location = new System.Drawing.Point(224, 13);
            this.chbSumRowValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSumRowValues.Name = "chbSumRowValues";
            this.chbSumRowValues.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbSumRowValues.Properties.Appearance.Options.UseFont = true;
            this.chbSumRowValues.Properties.AutoWidth = true;
            this.chbSumRowValues.Properties.Caption = "გამოჩნდეს სტრიქონების ჯამი";
            this.chbSumRowValues.Size = new System.Drawing.Size(191, 20);
            this.chbSumRowValues.TabIndex = 1;
            // 
            // chbSumColumnValues
            // 
            this.chbSumColumnValues.EditValue = true;
            this.chbSumColumnValues.Location = new System.Drawing.Point(13, 13);
            this.chbSumColumnValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSumColumnValues.Name = "chbSumColumnValues";
            this.chbSumColumnValues.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbSumColumnValues.Properties.Appearance.Options.UseFont = true;
            this.chbSumColumnValues.Properties.AutoWidth = true;
            this.chbSumColumnValues.Properties.Caption = "გამოჩნდეს სვეტების ჯამი";
            this.chbSumColumnValues.Size = new System.Drawing.Size(167, 20);
            this.chbSumColumnValues.TabIndex = 0;
            // 
            // btnAddField
            // 
            this.btnAddField.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnAddField.Appearance.Options.UseFont = true;
            this.btnAddField.Location = new System.Drawing.Point(368, 19);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(102, 30);
            this.btnAddField.TabIndex = 9;
            this.btnAddField.Text = "&ჩამატება";
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnExpression
            // 
            this.btnExpression.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnExpression.Appearance.Options.UseFont = true;
            this.btnExpression.Location = new System.Drawing.Point(408, 99);
            this.btnExpression.Name = "btnExpression";
            this.btnExpression.Size = new System.Drawing.Size(26, 23);
            this.btnExpression.TabIndex = 10;
            this.btnExpression.Text = "...";
            this.btnExpression.Click += new System.EventHandler(this.btnExpression_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(143, 100);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtExpression.Properties.Appearance.Options.UseFont = true;
            this.txtExpression.Size = new System.Drawing.Size(260, 22);
            this.txtExpression.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 19);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(224, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ფორმულა";
            // 
            // laName
            // 
            this.laName.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laName.Location = new System.Drawing.Point(16, 24);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(105, 16);
            this.laName.TabIndex = 0;
            this.laName.Text = "ველის დასახელება";
            // 
            // btnTopValues
            // 
            this.btnTopValues.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnTopValues.Appearance.Options.UseFont = true;
            this.btnTopValues.Location = new System.Drawing.Point(368, 15);
            this.btnTopValues.Name = "btnTopValues";
            this.btnTopValues.Size = new System.Drawing.Size(102, 30);
            this.btnTopValues.TabIndex = 4;
            this.btnTopValues.Text = "SET";
            this.btnTopValues.Click += new System.EventHandler(this.btnTopValues_Click);
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Top Values";
            // 
            // chbTopValues
            // 
            this.chbTopValues.EditValue = true;
            this.chbTopValues.Location = new System.Drawing.Point(155, 20);
            this.chbTopValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbTopValues.Name = "chbTopValues";
            this.chbTopValues.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbTopValues.Properties.Appearance.Options.UseFont = true;
            this.chbTopValues.Properties.AutoWidth = true;
            this.chbTopValues.Properties.Caption = "გამოჩნდეს დანარჩენის ჯამი";
            this.chbTopValues.Size = new System.Drawing.Size(181, 20);
            this.chbTopValues.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panel2.Controls.Add(this.txtTopValues);
            this.panel2.Controls.Add(this.chbDescended);
            this.panel2.Controls.Add(this.chbTopValues);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnTopValues);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 89);
            this.panel2.TabIndex = 4;
            // 
            // txtTopValues
            // 
            this.txtTopValues.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTopValues.Location = new System.Drawing.Point(77, 20);
            this.txtTopValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTopValues.Name = "txtTopValues";
            this.txtTopValues.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtTopValues.Properties.Appearance.Options.UseFont = true;
            this.txtTopValues.Properties.Mask.EditMask = "d";
            this.txtTopValues.Size = new System.Drawing.Size(65, 22);
            this.txtTopValues.TabIndex = 19;
            // 
            // chbDescended
            // 
            this.chbDescended.EditValue = true;
            this.chbDescended.Location = new System.Drawing.Point(155, 46);
            this.chbDescended.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDescended.Name = "chbDescended";
            this.chbDescended.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbDescended.Properties.Appearance.Options.UseFont = true;
            this.chbDescended.Properties.AutoWidth = true;
            this.chbDescended.Properties.Caption = "დალაგდეს კლებადობის მიხედვით";
            this.chbDescended.Size = new System.Drawing.Size(216, 20);
            this.chbDescended.TabIndex = 3;
            // 
            // paSummary
            // 
            this.paSummary.Controls.Add(this.btnSummaryAdd);
            this.paSummary.Controls.Add(this.chbMin);
            this.paSummary.Controls.Add(this.chbCount);
            this.paSummary.Controls.Add(this.chbAverage);
            this.paSummary.Controls.Add(this.chbMax);
            this.paSummary.Controls.Add(this.chbSum);
            this.paSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paSummary.Location = new System.Drawing.Point(0, 287);
            this.paSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paSummary.Name = "paSummary";
            this.paSummary.Size = new System.Drawing.Size(485, 94);
            this.paSummary.TabIndex = 5;
            // 
            // btnSummaryAdd
            // 
            this.btnSummaryAdd.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnSummaryAdd.Appearance.Options.UseFont = true;
            this.btnSummaryAdd.Location = new System.Drawing.Point(191, 49);
            this.btnSummaryAdd.Name = "btnSummaryAdd";
            this.btnSummaryAdd.Size = new System.Drawing.Size(107, 30);
            this.btnSummaryAdd.TabIndex = 5;
            this.btnSummaryAdd.Text = "SET";
            this.btnSummaryAdd.Click += new System.EventHandler(this.btnSummaryAdd_Click);
            // 
            // chbMin
            // 
            this.chbMin.Location = new System.Drawing.Point(125, 12);
            this.chbMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMin.Name = "chbMin";
            this.chbMin.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbMin.Properties.Appearance.Options.UseFont = true;
            this.chbMin.Properties.AutoWidth = true;
            this.chbMin.Properties.Caption = "Min";
            this.chbMin.Size = new System.Drawing.Size(42, 20);
            this.chbMin.TabIndex = 1;
            // 
            // chbCount
            // 
            this.chbCount.Location = new System.Drawing.Point(384, 12);
            this.chbCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbCount.Name = "chbCount";
            this.chbCount.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbCount.Properties.Appearance.Options.UseFont = true;
            this.chbCount.Properties.AutoWidth = true;
            this.chbCount.Properties.Caption = "Count";
            this.chbCount.Size = new System.Drawing.Size(52, 20);
            this.chbCount.TabIndex = 4;
            // 
            // chbAverage
            // 
            this.chbAverage.Location = new System.Drawing.Point(285, 12);
            this.chbAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbAverage.Name = "chbAverage";
            this.chbAverage.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbAverage.Properties.Appearance.Options.UseFont = true;
            this.chbAverage.Properties.AutoWidth = true;
            this.chbAverage.Properties.Caption = "Average";
            this.chbAverage.Size = new System.Drawing.Size(65, 20);
            this.chbAverage.TabIndex = 3;
            // 
            // chbMax
            // 
            this.chbMax.Location = new System.Drawing.Point(201, 12);
            this.chbMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMax.Name = "chbMax";
            this.chbMax.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbMax.Properties.Appearance.Options.UseFont = true;
            this.chbMax.Properties.AutoWidth = true;
            this.chbMax.Properties.Caption = "Max";
            this.chbMax.Size = new System.Drawing.Size(44, 20);
            this.chbMax.TabIndex = 2;
            // 
            // chbSum
            // 
            this.chbSum.Location = new System.Drawing.Point(46, 12);
            this.chbSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSum.Name = "chbSum";
            this.chbSum.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.chbSum.Properties.Appearance.Options.UseFont = true;
            this.chbSum.Properties.AutoWidth = true;
            this.chbSum.Properties.Caption = "Sum";
            this.chbSum.Size = new System.Drawing.Size(43, 20);
            this.chbSum.TabIndex = 0;
            // 
            // txtFormatText
            // 
            this.txtFormatText.Location = new System.Drawing.Point(143, 46);
            this.txtFormatText.Name = "txtFormatText";
            this.txtFormatText.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtFormatText.Properties.Appearance.Options.UseFont = true;
            this.txtFormatText.Size = new System.Drawing.Size(104, 22);
            this.txtFormatText.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.AppearanceCaption.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.AppearanceCaption.Options.UseFont = true;
            this.groupBox2.Controls.Add(this.laFieldName);
            this.groupBox2.Controls.Add(this.txtFieldName);
            this.groupBox2.Controls.Add(this.cbFormat);
            this.groupBox2.Controls.Add(this.laFormatText);
            this.groupBox2.Controls.Add(this.btnAddField);
            this.groupBox2.Controls.Add(this.laName);
            this.groupBox2.Controls.Add(this.txtFormatText);
            this.groupBox2.Controls.Add(this.btnExpression);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtExpression);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.Text = "ველის ჩამატება ცხრილში";
            // 
            // laFieldName
            // 
            this.laFieldName.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laFieldName.Location = new System.Drawing.Point(16, 79);
            this.laFieldName.Name = "laFieldName";
            this.laFieldName.Size = new System.Drawing.Size(80, 16);
            this.laFieldName.TabIndex = 5;
            this.laFieldName.Text = "ველის სახელი";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(143, 73);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtFieldName.Properties.Appearance.Options.UseFont = true;
            this.txtFieldName.Size = new System.Drawing.Size(104, 22);
            this.txtFieldName.TabIndex = 6;
            // 
            // cbFormat
            // 
            this.cbFormat.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "None",
            "რიცხვი",
            "თარიღი",
            "შერჩევით"});
            this.cbFormat.Location = new System.Drawing.Point(252, 46);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(108, 24);
            this.cbFormat.TabIndex = 4;
            this.cbFormat.Text = "None";
            // 
            // laFormatText
            // 
            this.laFormatText.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laFormatText.Location = new System.Drawing.Point(16, 52);
            this.laFormatText.Name = "laFormatText";
            this.laFormatText.Size = new System.Drawing.Size(54, 16);
            this.laFormatText.TabIndex = 2;
            this.laFormatText.Text = "ფორმატი";
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.chbSumColumnValues);
            this.paTop.Controls.Add(this.chbCompactStyle);
            this.paTop.Controls.Add(this.chbSumRowValues);
            this.paTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTop.Location = new System.Drawing.Point(0, 0);
            this.paTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paTop.Name = "paTop";
            this.paTop.Size = new System.Drawing.Size(485, 70);
            this.paTop.TabIndex = 8;
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btnOK);
            this.paBottom.Controls.Add(this.btnCancel);
            this.paBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom.Location = new System.Drawing.Point(0, 381);
            this.paBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paBottom.Name = "paBottom";
            this.paBottom.Size = new System.Drawing.Size(485, 40);
            this.paBottom.TabIndex = 9;
            // 
            // PivotTableSettingsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(485, 421);
            this.Controls.Add(this.paSummary);
            this.Controls.Add(this.paBottom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.paTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PivotTableSettingsForm";
            this.ShowIcon = false;
            this.Text = "კროს ცხრილის პარამეტრები";
            this.Load += new System.EventHandler(this.PivotTableSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chbCompactStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSumRowValues.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSumColumnValues.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbTopValues.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopValues.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDescended.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paSummary)).EndInit();
            this.paSummary.ResumeLayout(false);
            this.paSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAverage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckEdit chbCompactStyle;
        private DevExpress.XtraEditors.CheckEdit chbSumRowValues;
        private DevExpress.XtraEditors.CheckEdit chbSumColumnValues;
        private LabelControl label2;
        private LabelControl laName;
        private DevExpress.XtraEditors.SimpleButton btnExpression;
        private TextEdit txtExpression;
        private TextEdit txtName;
        private SimpleButton btnAddField;
        private DevExpress.XtraEditors.SimpleButton btnTopValues;
        private LabelControl label4;
        private DevExpress.XtraEditors.CheckEdit chbTopValues;
        private PanelControl panel2;
        private DevExpress.XtraEditors.CheckEdit chbDescended;
        private DevExpress.XtraEditors.PanelControl paSummary;
        private DevExpress.XtraEditors.SimpleButton btnSummaryAdd;
        private DevExpress.XtraEditors.CheckEdit chbMin;
        private DevExpress.XtraEditors.CheckEdit chbCount;
        private DevExpress.XtraEditors.CheckEdit chbAverage;
        private DevExpress.XtraEditors.CheckEdit chbMax;
        private DevExpress.XtraEditors.CheckEdit chbSum;
        private TextEdit txtFormatText;
        private DevExpress.XtraEditors.GroupControl groupBox2;
        private LabelControl laFormatText;
        private ComboBox cbFormat;
        private LabelControl laFieldName;
        private TextEdit txtFieldName;
        private CalcEdit txtTopValues;
        private PanelControl paTop;
        private PanelControl paBottom;
    }
}