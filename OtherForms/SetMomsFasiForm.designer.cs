namespace SBS_Market.OtherForms
{
    partial class SetMomsFasiForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbMomsS = new System.Windows.Forms.ComboBox();
            this.cbMomsT = new System.Windows.Forms.ComboBox();
            this.chbMomsT = new System.Windows.Forms.CheckBox();
            this.chbMomsS = new System.Windows.Forms.CheckBox();
            this.txtDabrgvalebaCifri = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.chbDamrgvaleba = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFasi2 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.txtTanxa = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtPercent = new Syncfusion.Windows.Forms.Tools.PercentTextBox();
            this.txtFasi1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDabrgvalebaCifri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(258, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(177, 117);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbMomsS
            // 
            this.cbMomsS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMomsS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMomsS.FormattingEnabled = true;
            this.cbMomsS.Location = new System.Drawing.Point(147, 77);
            this.cbMomsS.Name = "cbMomsS";
            this.cbMomsS.Size = new System.Drawing.Size(326, 21);
            this.cbMomsS.TabIndex = 9;
            this.cbMomsS.Visible = false;
            // 
            // cbMomsT
            // 
            this.cbMomsT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMomsT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMomsT.FormattingEnabled = true;
            this.cbMomsT.Location = new System.Drawing.Point(147, 50);
            this.cbMomsT.Name = "cbMomsT";
            this.cbMomsT.Size = new System.Drawing.Size(326, 21);
            this.cbMomsT.TabIndex = 7;
            this.cbMomsT.Visible = false;
            // 
            // chbMomsT
            // 
            this.chbMomsT.AutoSize = true;
            this.chbMomsT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMomsT.Location = new System.Drawing.Point(15, 51);
            this.chbMomsT.Name = "chbMomsT";
            this.chbMomsT.Size = new System.Drawing.Size(90, 20);
            this.chbMomsT.TabIndex = 6;
            this.chbMomsT.Text = "პროდ. ტიპი";
            this.chbMomsT.UseVisualStyleBackColor = true;
            this.chbMomsT.CheckedChanged += new System.EventHandler(this.chbMomsT_CheckedChanged);
            // 
            // chbMomsS
            // 
            this.chbMomsS.AutoSize = true;
            this.chbMomsS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMomsS.Location = new System.Drawing.Point(15, 78);
            this.chbMomsS.Name = "chbMomsS";
            this.chbMomsS.Size = new System.Drawing.Size(105, 20);
            this.chbMomsS.TabIndex = 8;
            this.chbMomsS.Text = "პროდ.სახეობა";
            this.chbMomsS.UseVisualStyleBackColor = true;
            this.chbMomsS.CheckedChanged += new System.EventHandler(this.chbMomsT_CheckedChanged);
            // 
            // txtDabrgvalebaCifri
            // 
            this.txtDabrgvalebaCifri.IntegerValue = ((long)(0));
            this.txtDabrgvalebaCifri.Location = new System.Drawing.Point(454, 11);
            this.txtDabrgvalebaCifri.MaxValue = ((long)(3));
            this.txtDabrgvalebaCifri.MinValue = ((long)(-3));
            this.txtDabrgvalebaCifri.Name = "txtDabrgvalebaCifri";
            this.txtDabrgvalebaCifri.NegativeInputPendingOnSelectAll = false;
            this.txtDabrgvalebaCifri.NullString = "0";
            this.txtDabrgvalebaCifri.OverflowIndicatorToolTipText = null;
            this.txtDabrgvalebaCifri.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.txtDabrgvalebaCifri.Size = new System.Drawing.Size(21, 20);
            this.txtDabrgvalebaCifri.TabIndex = 5;
            this.txtDabrgvalebaCifri.Visible = false;
            // 
            // chbDamrgvaleba
            // 
            this.chbDamrgvaleba.AutoSize = true;
            this.chbDamrgvaleba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDamrgvaleba.Location = new System.Drawing.Point(350, 12);
            this.chbDamrgvaleba.Name = "chbDamrgvaleba";
            this.chbDamrgvaleba.Size = new System.Drawing.Size(102, 21);
            this.chbDamrgvaleba.TabIndex = 4;
            this.chbDamrgvaleba.Text = "დამრგვალება";
            this.chbDamrgvaleba.UseVisualStyleBackColor = true;
            this.chbDamrgvaleba.CheckedChanged += new System.EventHandler(this.chbDamrgvaleba_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = ") *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "+";
            // 
            // txtFasi2
            // 
            this.txtFasi2.IntegerValue = ((long)(1));
            this.txtFasi2.Location = new System.Drawing.Point(131, 12);
            this.txtFasi2.MaxValue = ((long)(10));
            this.txtFasi2.MinValue = ((long)(1));
            this.txtFasi2.Name = "txtFasi2";
            this.txtFasi2.NegativeInputPendingOnSelectAll = false;
            this.txtFasi2.NullString = "0";
            this.txtFasi2.OverflowIndicatorToolTipText = null;
            this.txtFasi2.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.txtFasi2.Size = new System.Drawing.Size(21, 20);
            this.txtFasi2.TabIndex = 1;
            // 
            // txtTanxa
            // 
            this.txtTanxa.DoubleValue = 0;
            this.txtTanxa.Location = new System.Drawing.Point(179, 12);
            this.txtTanxa.Name = "txtTanxa";
            this.txtTanxa.NegativeInputPendingOnSelectAll = false;
            this.txtTanxa.NullString = "0.0";
            this.txtTanxa.OverflowIndicatorToolTipText = null;
            this.txtTanxa.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.txtTanxa.Size = new System.Drawing.Size(73, 20);
            this.txtTanxa.TabIndex = 2;
            this.txtTanxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPercent
            // 
            this.txtPercent.DoubleValue = 1;
            this.txtPercent.Location = new System.Drawing.Point(283, 12);
            this.txtPercent.MaxValue = 10;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.NegativeInputPendingOnSelectAll = false;
            this.txtPercent.NullString = "0.00 %";
            this.txtPercent.OverflowIndicatorToolTipText = null;
            this.txtPercent.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.txtPercent.Size = new System.Drawing.Size(61, 20);
            this.txtPercent.TabIndex = 3;
            this.txtPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFasi1
            // 
            this.txtFasi1.IntegerValue = ((long)(2));
            this.txtFasi1.Location = new System.Drawing.Point(47, 12);
            this.txtFasi1.MaxValue = ((long)(10));
            this.txtFasi1.MinValue = ((long)(2));
            this.txtFasi1.Name = "txtFasi1";
            this.txtFasi1.NegativeInputPendingOnSelectAll = false;
            this.txtFasi1.NullString = "0";
            this.txtFasi1.OverflowIndicatorToolTipText = null;
            this.txtFasi1.ReadOnlyBackColor = System.Drawing.SystemColors.Control;
            this.txtFasi1.Size = new System.Drawing.Size(21, 20);
            this.txtFasi1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = " = ( ფასი";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "ფასი";
            // 
            // SetMomsFasiForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(508, 151);
            this.Controls.Add(this.txtDabrgvalebaCifri);
            this.Controls.Add(this.chbDamrgvaleba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFasi2);
            this.Controls.Add(this.txtTanxa);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.txtFasi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMomsS);
            this.Controls.Add(this.cbMomsT);
            this.Controls.Add(this.chbMomsT);
            this.Controls.Add(this.chbMomsS);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "SetMomsFasiForm";
            this.Text = "ფასების ავტომატური ფორმირება";
            this.Load += new System.EventHandler(this.SetMomsFasiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDabrgvalebaCifri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFasi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbMomsS;
        private System.Windows.Forms.ComboBox cbMomsT;
        private System.Windows.Forms.CheckBox chbMomsT;
        private System.Windows.Forms.CheckBox chbMomsS;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtDabrgvalebaCifri;
        private System.Windows.Forms.CheckBox chbDamrgvaleba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtFasi2;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtTanxa;
        private Syncfusion.Windows.Forms.Tools.PercentTextBox txtPercent;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtFasi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}