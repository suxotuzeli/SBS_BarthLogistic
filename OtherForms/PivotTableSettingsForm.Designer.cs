using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ComboBox = System.Windows.Forms.ComboBox;

namespace SBS_Market.OtherForms
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSummaryAdd = new DevExpress.XtraEditors.SimpleButton();
            this.chbMin = new DevExpress.XtraEditors.CheckEdit();
            this.chbCount = new DevExpress.XtraEditors.CheckEdit();
            this.chbAverage = new DevExpress.XtraEditors.CheckEdit();
            this.chbMax = new DevExpress.XtraEditors.CheckEdit();
            this.chbSum = new DevExpress.XtraEditors.CheckEdit();
            this.txtFormatText = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.laFieldName = new DevExpress.XtraEditors.LabelControl();
            this.txtFieldName = new DevExpress.XtraEditors.TextEdit();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.laFormatText = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopValues.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatText.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(239, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(137, 423);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chbCompactStyle
            // 
            this.chbCompactStyle.AutoSize = true;
            this.chbCompactStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbCompactStyle.Location = new System.Drawing.Point(12, 38);
            this.chbCompactStyle.Name = "chbCompactStyle";
            this.chbCompactStyle.Size = new System.Drawing.Size(118, 20);
            this.chbCompactStyle.TabIndex = 2;
            this.chbCompactStyle.Text = "კომპაქტური სტილი";
            // 
            // chbSumRowValues
            // 
            this.chbSumRowValues.AutoSize = true;
            this.chbSumRowValues.Checked = true;
            this.chbSumRowValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSumRowValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbSumRowValues.Location = new System.Drawing.Point(223, 12);
            this.chbSumRowValues.Name = "chbSumRowValues";
            this.chbSumRowValues.Size = new System.Drawing.Size(164, 20);
            this.chbSumRowValues.TabIndex = 1;
            this.chbSumRowValues.Text = "გამოჩნდეს სტრიქონების ჯამი";
            // 
            // chbSumColumnValues
            // 
            this.chbSumColumnValues.AutoSize = true;
            this.chbSumColumnValues.Checked = true;
            this.chbSumColumnValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSumColumnValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbSumColumnValues.Location = new System.Drawing.Point(12, 12);
            this.chbSumColumnValues.Name = "chbSumColumnValues";
            this.chbSumColumnValues.Size = new System.Drawing.Size(145, 20);
            this.chbSumColumnValues.TabIndex = 0;
            this.chbSumColumnValues.Text = "გამოჩნდეს სვეტების ჯამი";
            // 
            // btnAddField
            // 
            this.btnAddField.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddField.Appearance.Options.UseFont = true;
            this.btnAddField.Location = new System.Drawing.Point(355, 21);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(102, 30);
            this.btnAddField.TabIndex = 9;
            this.btnAddField.Text = "&ჩამატება";
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnExpression
            // 
            this.btnExpression.Location = new System.Drawing.Point(386, 101);
            this.btnExpression.Name = "btnExpression";
            this.btnExpression.Size = new System.Drawing.Size(26, 23);
            this.btnExpression.TabIndex = 10;
            this.btnExpression.Text = "...";
            this.btnExpression.Click += new System.EventHandler(this.btnExpression_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(121, 100);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExpression.Properties.Appearance.Options.UseFont = true;
            this.txtExpression.Size = new System.Drawing.Size(260, 22);
            this.txtExpression.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 19);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(224, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ფორმულა";
            // 
            // laName
            // 
            this.laName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laName.Location = new System.Drawing.Point(5, 21);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(86, 16);
            this.laName.TabIndex = 0;
            this.laName.Text = "ველის დასახელება";
            // 
            // btnTopValues
            // 
            this.btnTopValues.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopValues.Location = new System.Drawing.Point(363, 23);
            this.btnTopValues.Name = "btnTopValues";
            this.btnTopValues.Size = new System.Drawing.Size(81, 30);
            this.btnTopValues.TabIndex = 4;
            this.btnTopValues.Text = "SET";
            this.btnTopValues.Click += new System.EventHandler(this.btnTopValues_Click);
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Top Values";
            // 
            // chbTopValues
            // 
            this.chbTopValues.AutoSize = true;
            this.chbTopValues.Checked = true;
            this.chbTopValues.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTopValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbTopValues.Location = new System.Drawing.Point(174, 29);
            this.chbTopValues.Name = "chbTopValues";
            this.chbTopValues.Size = new System.Drawing.Size(156, 20);
            this.chbTopValues.TabIndex = 2;
            this.chbTopValues.Text = "გამოჩნდეს დანარჩენის ჯამი";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panel2.Controls.Add(this.txtTopValues);
            this.panel2.Controls.Add(this.chbDescended);
            this.panel2.Controls.Add(this.chbTopValues);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnTopValues);
            this.panel2.Location = new System.Drawing.Point(24, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 89);
            this.panel2.TabIndex = 4;
            // 
            // txtTopValues
            // 
            this.txtTopValues.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTopValues.Location = new System.Drawing.Point(113, 29);
            this.txtTopValues.Name = "txtTopValues";
            this.txtTopValues.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_Market.Properties.Resources.calculatesheet_16x16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtTopValues.Size = new System.Drawing.Size(48, 22);
            this.txtTopValues.TabIndex = 19;
            // 
            // chbDescended
            // 
            this.chbDescended.AutoSize = true;
            this.chbDescended.Checked = true;
            this.chbDescended.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDescended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbDescended.Location = new System.Drawing.Point(174, 55);
            this.chbDescended.Name = "chbDescended";
            this.chbDescended.Size = new System.Drawing.Size(185, 20);
            this.chbDescended.TabIndex = 3;
            this.chbDescended.Text = "დალაგდეს კლებადობის მიხედვით";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSummaryAdd);
            this.groupBox1.Controls.Add(this.chbMin);
            this.groupBox1.Controls.Add(this.chbCount);
            this.groupBox1.Controls.Add(this.chbAverage);
            this.groupBox1.Controls.Add(this.chbMax);
            this.groupBox1.Controls.Add(this.chbSum);
            this.groupBox1.Location = new System.Drawing.Point(24, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnSummaryAdd
            // 
            this.btnSummaryAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummaryAdd.Location = new System.Drawing.Point(151, 64);
            this.btnSummaryAdd.Name = "btnSummaryAdd";
            this.btnSummaryAdd.Size = new System.Drawing.Size(107, 30);
            this.btnSummaryAdd.TabIndex = 5;
            this.btnSummaryAdd.Text = "SET";
            this.btnSummaryAdd.Click += new System.EventHandler(this.btnSummaryAdd_Click);
            // 
            // chbMin
            // 
            this.chbMin.AutoSize = true;
            this.chbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMin.Location = new System.Drawing.Point(85, 28);
            this.chbMin.Name = "chbMin";
            this.chbMin.Size = new System.Drawing.Size(48, 20);
            this.chbMin.TabIndex = 1;
            this.chbMin.Text = "Min";
            // 
            // chbCount
            // 
            this.chbCount.AutoSize = true;
            this.chbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbCount.Location = new System.Drawing.Point(344, 28);
            this.chbCount.Name = "chbCount";
            this.chbCount.Size = new System.Drawing.Size(61, 20);
            this.chbCount.TabIndex = 4;
            this.chbCount.Text = "Count";
            // 
            // chbAverage
            // 
            this.chbAverage.AutoSize = true;
            this.chbAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbAverage.Location = new System.Drawing.Point(244, 28);
            this.chbAverage.Name = "chbAverage";
            this.chbAverage.Size = new System.Drawing.Size(79, 20);
            this.chbAverage.TabIndex = 3;
            this.chbAverage.Text = "Average";
            // 
            // chbMax
            // 
            this.chbMax.AutoSize = true;
            this.chbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMax.Location = new System.Drawing.Point(160, 28);
            this.chbMax.Name = "chbMax";
            this.chbMax.Size = new System.Drawing.Size(52, 20);
            this.chbMax.TabIndex = 2;
            this.chbMax.Text = "Max";
            // 
            // chbSum
            // 
            this.chbSum.AutoSize = true;
            this.chbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbSum.Location = new System.Drawing.Point(6, 28);
            this.chbSum.Name = "chbSum";
            this.chbSum.Size = new System.Drawing.Size(54, 20);
            this.chbSum.TabIndex = 0;
            this.chbSum.Text = "Sum";
            // 
            // txtFormatText
            // 
            this.txtFormatText.Location = new System.Drawing.Point(121, 46);
            this.txtFormatText.Name = "txtFormatText";
            this.txtFormatText.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFormatText.Properties.Appearance.Options.UseFont = true;
            this.txtFormatText.Size = new System.Drawing.Size(104, 22);
            this.txtFormatText.TabIndex = 3;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Font = new System.Drawing.Font("Sylfaen", 8.75F);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ველის ჩამატება ცხრილში";
            // 
            // laFieldName
            // 
            this.laFieldName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laFieldName.Location = new System.Drawing.Point(5, 75);
            this.laFieldName.Name = "laFieldName";
            this.laFieldName.Size = new System.Drawing.Size(65, 16);
            this.laFieldName.TabIndex = 5;
            this.laFieldName.Text = "ველის სახელი";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(121, 73);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFieldName.Properties.Appearance.Options.UseFont = true;
            this.txtFieldName.Size = new System.Drawing.Size(104, 22);
            this.txtFieldName.TabIndex = 6;
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "None",
            "რიცხვი",
            "თარიღი",
            "შერჩევით"});
            this.cbFormat.Location = new System.Drawing.Point(230, 48);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(108, 24);
            this.cbFormat.TabIndex = 4;
            this.cbFormat.Text = "None";
            // 
            // laFormatText
            // 
            this.laFormatText.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laFormatText.Location = new System.Drawing.Point(5, 48);
            this.laFormatText.Name = "laFormatText";
            this.laFormatText.Size = new System.Drawing.Size(43, 16);
            this.laFormatText.TabIndex = 2;
            this.laFormatText.Text = "ფორმატი";
            // 
            // PivotTableSettingsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(485, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chbSumColumnValues);
            this.Controls.Add(this.chbSumRowValues);
            this.Controls.Add(this.chbCompactStyle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "PivotTableSettingsForm";
            this.Text = "კროს ცხრილის პარამეტრები";
            this.Load += new System.EventHandler(this.PivotTableSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopValues.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormatText.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSummaryAdd;
        private DevExpress.XtraEditors.CheckEdit chbMin;
        private DevExpress.XtraEditors.CheckEdit chbCount;
        private DevExpress.XtraEditors.CheckEdit chbAverage;
        private DevExpress.XtraEditors.CheckEdit chbMax;
        private DevExpress.XtraEditors.CheckEdit chbSum;
        private TextEdit txtFormatText;
        private System.Windows.Forms.GroupBox groupBox2;
        private LabelControl laFormatText;
        private ComboBox cbFormat;
        private LabelControl laFieldName;
        private TextEdit txtFieldName;
        private CalcEdit txtTopValues;
    }
}