namespace SBS_Market.OtherForms
{
    partial class ReportCustomizerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.laExcel = new System.Windows.Forms.Label();
            this.laStimul = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstExcel = new System.Windows.Forms.ListBox();
            this.lstStimul = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExcelEdit = new System.Windows.Forms.Button();
            this.btnStimulEdit = new System.Windows.Forms.Button();
            this.btnExcelRefresh = new System.Windows.Forms.Button();
            this.btnStimulRefresh = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcelDelete = new System.Windows.Forms.Button();
            this.btnExcelCopy = new System.Windows.Forms.Button();
            this.btnExcelDesign = new System.Windows.Forms.Button();
            this.btnStimulDelete = new System.Windows.Forms.Button();
            this.btnStimulCopy = new System.Windows.Forms.Button();
            this.btnStimulDesign = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laExcel);
            this.panel1.Controls.Add(this.laStimul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 46);
            this.panel1.TabIndex = 1;
            // 
            // laExcel
            // 
            this.laExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laExcel.ForeColor = System.Drawing.Color.Maroon;
            this.laExcel.Location = new System.Drawing.Point(457, 3);
            this.laExcel.Name = "laExcel";
            this.laExcel.Size = new System.Drawing.Size(402, 38);
            this.laExcel.TabIndex = 8;
            this.laExcel.Text = "სტანდარტული რეპორტები";
            // 
            // laStimul
            // 
            this.laStimul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laStimul.ForeColor = System.Drawing.Color.Maroon;
            this.laStimul.Location = new System.Drawing.Point(3, 3);
            this.laStimul.Name = "laStimul";
            this.laStimul.Size = new System.Drawing.Size(441, 43);
            this.laStimul.TabIndex = 7;
            this.laStimul.Text = "სტანდარტული რეპორტები";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstExcel);
            this.panel2.Controls.Add(this.lstStimul);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 478);
            this.panel2.TabIndex = 2;
            // 
            // lstExcel
            // 
            this.lstExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstExcel.FormattingEnabled = true;
            this.lstExcel.Location = new System.Drawing.Point(447, 0);
            this.lstExcel.Name = "lstExcel";
            this.lstExcel.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstExcel.Size = new System.Drawing.Size(424, 472);
            this.lstExcel.TabIndex = 3;
            this.lstExcel.SelectedIndexChanged += new System.EventHandler(this.lstExcel_SelectedIndexChanged);
            this.lstExcel.DoubleClick += new System.EventHandler(this.btnExcelDesign_Click);
            // 
            // lstStimul
            // 
            this.lstStimul.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstStimul.FormattingEnabled = true;
            this.lstStimul.Location = new System.Drawing.Point(0, 0);
            this.lstStimul.Name = "lstStimul";
            this.lstStimul.Size = new System.Drawing.Size(447, 472);
            this.lstStimul.TabIndex = 0;
            this.lstStimul.SelectedIndexChanged += new System.EventHandler(this.lstStimul_SelectedIndexChanged);
            this.lstStimul.DoubleClick += new System.EventHandler(this.btnStimulDesign_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExcelEdit);
            this.panel3.Controls.Add(this.btnStimulEdit);
            this.panel3.Controls.Add(this.btnExcelRefresh);
            this.panel3.Controls.Add(this.btnStimulRefresh);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnExcelDelete);
            this.panel3.Controls.Add(this.btnExcelCopy);
            this.panel3.Controls.Add(this.btnExcelDesign);
            this.panel3.Controls.Add(this.btnStimulDelete);
            this.panel3.Controls.Add(this.btnStimulCopy);
            this.panel3.Controls.Add(this.btnStimulDesign);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 68);
            this.panel3.TabIndex = 3;
            // 
            // btnExcelEdit
            // 
            this.btnExcelEdit.Location = new System.Drawing.Point(542, 39);
            this.btnExcelEdit.Name = "btnExcelEdit";
            this.btnExcelEdit.Size = new System.Drawing.Size(75, 23);
            this.btnExcelEdit.TabIndex = 11;
            this.btnExcelEdit.Text = "Edit";
            this.btnExcelEdit.UseVisualStyleBackColor = true;
            this.btnExcelEdit.Click += new System.EventHandler(this.btnExcelEdit_Click);
            // 
            // btnStimulEdit
            // 
            this.btnStimulEdit.Location = new System.Drawing.Point(91, 42);
            this.btnStimulEdit.Name = "btnStimulEdit";
            this.btnStimulEdit.Size = new System.Drawing.Size(75, 23);
            this.btnStimulEdit.TabIndex = 10;
            this.btnStimulEdit.Text = "Edit";
            this.btnStimulEdit.UseVisualStyleBackColor = true;
            this.btnStimulEdit.Click += new System.EventHandler(this.btnStimulEdit_Click);
            // 
            // btnExcelRefresh
            // 
            this.btnExcelRefresh.Location = new System.Drawing.Point(785, 39);
            this.btnExcelRefresh.Name = "btnExcelRefresh";
            this.btnExcelRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnExcelRefresh.TabIndex = 9;
            this.btnExcelRefresh.Text = "Refresh";
            this.btnExcelRefresh.UseVisualStyleBackColor = true;
            this.btnExcelRefresh.Click += new System.EventHandler(this.btnExcelRefresh_Click);
            // 
            // btnStimulRefresh
            // 
            this.btnStimulRefresh.Location = new System.Drawing.Point(335, 42);
            this.btnStimulRefresh.Name = "btnStimulRefresh";
            this.btnStimulRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnStimulRefresh.TabIndex = 8;
            this.btnStimulRefresh.Text = "Refresh";
            this.btnStimulRefresh.UseVisualStyleBackColor = true;
            this.btnStimulRefresh.Click += new System.EventHandler(this.btnStimulRefresh_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(784, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Excel-ის შაბლონები";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "სტანდარტული რეპორტები";
            // 
            // btnExcelDelete
            // 
            this.btnExcelDelete.Location = new System.Drawing.Point(704, 39);
            this.btnExcelDelete.Name = "btnExcelDelete";
            this.btnExcelDelete.Size = new System.Drawing.Size(75, 23);
            this.btnExcelDelete.TabIndex = 5;
            this.btnExcelDelete.Text = "Delete";
            this.btnExcelDelete.UseVisualStyleBackColor = true;
            this.btnExcelDelete.Click += new System.EventHandler(this.btnExcelDelete_Click);
            // 
            // btnExcelCopy
            // 
            this.btnExcelCopy.Location = new System.Drawing.Point(623, 39);
            this.btnExcelCopy.Name = "btnExcelCopy";
            this.btnExcelCopy.Size = new System.Drawing.Size(75, 23);
            this.btnExcelCopy.TabIndex = 4;
            this.btnExcelCopy.Text = "Copy";
            this.btnExcelCopy.UseVisualStyleBackColor = true;
            this.btnExcelCopy.Click += new System.EventHandler(this.btnExcelCopy_Click);
            // 
            // btnExcelDesign
            // 
            this.btnExcelDesign.Location = new System.Drawing.Point(461, 39);
            this.btnExcelDesign.Name = "btnExcelDesign";
            this.btnExcelDesign.Size = new System.Drawing.Size(75, 23);
            this.btnExcelDesign.TabIndex = 3;
            this.btnExcelDesign.Text = "Design";
            this.btnExcelDesign.UseVisualStyleBackColor = true;
            this.btnExcelDesign.Click += new System.EventHandler(this.btnExcelDesign_Click);
            // 
            // btnStimulDelete
            // 
            this.btnStimulDelete.Location = new System.Drawing.Point(254, 42);
            this.btnStimulDelete.Name = "btnStimulDelete";
            this.btnStimulDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStimulDelete.TabIndex = 2;
            this.btnStimulDelete.Text = "Delete";
            this.btnStimulDelete.UseVisualStyleBackColor = true;
            this.btnStimulDelete.Click += new System.EventHandler(this.btnStimulDelete_Click);
            // 
            // btnStimulCopy
            // 
            this.btnStimulCopy.Location = new System.Drawing.Point(173, 42);
            this.btnStimulCopy.Name = "btnStimulCopy";
            this.btnStimulCopy.Size = new System.Drawing.Size(75, 23);
            this.btnStimulCopy.TabIndex = 1;
            this.btnStimulCopy.Text = "Copy";
            this.btnStimulCopy.UseVisualStyleBackColor = true;
            this.btnStimulCopy.Click += new System.EventHandler(this.btnStimulCopy_Click);
            // 
            // btnStimulDesign
            // 
            this.btnStimulDesign.Location = new System.Drawing.Point(10, 42);
            this.btnStimulDesign.Name = "btnStimulDesign";
            this.btnStimulDesign.Size = new System.Drawing.Size(75, 23);
            this.btnStimulDesign.TabIndex = 0;
            this.btnStimulDesign.Text = "Design";
            this.btnStimulDesign.UseVisualStyleBackColor = true;
            this.btnStimulDesign.Click += new System.EventHandler(this.btnStimulDesign_Click);
            // 
            // ReportCustomizerForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ReportCustomizerForm";
            this.Text = "რეპორტების კასტომიზაცია";
            this.Load += new System.EventHandler(this.ReportCustomizerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstExcel;
        private System.Windows.Forms.ListBox lstStimul;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcelDelete;
        private System.Windows.Forms.Button btnExcelCopy;
        private System.Windows.Forms.Button btnExcelDesign;
        private System.Windows.Forms.Button btnStimulDelete;
        private System.Windows.Forms.Button btnStimulCopy;
        private System.Windows.Forms.Button btnStimulDesign;
        private System.Windows.Forms.Button btnExcelRefresh;
        private System.Windows.Forms.Button btnStimulRefresh;
        private System.Windows.Forms.Label laExcel;
        private System.Windows.Forms.Label laStimul;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExcelEdit;
        private System.Windows.Forms.Button btnStimulEdit;
    }
}