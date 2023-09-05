using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class GenerateSascoriFormNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateSascoriFormNew));
            this.btn_CreateFile = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PAth = new System.Windows.Forms.Button();
            this.cb_sascori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFG = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtFG)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreateFile
            // 
            this.btn_CreateFile.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateFile.Location = new System.Drawing.Point(19, 117);
            this.btn_CreateFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CreateFile.Name = "btn_CreateFile";
            this.btn_CreateFile.Size = new System.Drawing.Size(569, 28);
            this.btn_CreateFile.TabIndex = 5;
            this.btn_CreateFile.Text = "ფაილის შექმნა ";
            this.btn_CreateFile.UseVisualStyleBackColor = true;
            this.btn_CreateFile.Click += new System.EventHandler(this.btn_CreateFile_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Path.Location = new System.Drawing.Point(167, 63);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(347, 26);
            this.txt_Path.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "ფაილის მისამართი";
            // 
            // btn_PAth
            // 
            this.btn_PAth.Location = new System.Drawing.Point(523, 60);
            this.btn_PAth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PAth.Name = "btn_PAth";
            this.btn_PAth.Size = new System.Drawing.Size(44, 28);
            this.btn_PAth.TabIndex = 7;
            this.btn_PAth.Text = "...";
            this.btn_PAth.UseVisualStyleBackColor = true;
            this.btn_PAth.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // cb_sascori
            // 
            this.cb_sascori.FormattingEnabled = true;
            this.cb_sascori.Items.AddRange(new object[] {
            "DIGI",
            "Bizerba",
            "Shtrih-M",
            "CAS - ES",
            "CAS - NET",
            "LP Admin"});
            this.cb_sascori.Location = new System.Drawing.Point(96, 27);
            this.cb_sascori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_sascori.Name = "cb_sascori";
            this.cb_sascori.Size = new System.Drawing.Size(296, 24);
            this.cb_sascori.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "სასწორი";
            // 
            // txtFG
            // 
            this.txtFG.Location = new System.Drawing.Point(539, 31);
            this.txtFG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFG.Name = "txtFG";
            this.txtFG.Size = new System.Drawing.Size(44, 22);
            this.txtFG.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "ფასთა ჯგუფი";
            // 
            // GenerateSascoriFormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 199);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_sascori);
            this.Controls.Add(this.btn_PAth);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CreateFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateSascoriFormNew";
            this.Text = "Upload Form";
            this.Load += new System.EventHandler(this.GenerateSascoriFormNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateFile;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PAth;
        private System.Windows.Forms.ComboBox cb_sascori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtFG;
        private System.Windows.Forms.Label label7;
    }
}

