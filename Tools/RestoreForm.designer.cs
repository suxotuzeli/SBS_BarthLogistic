using DevExpress.XtraEditors;

namespace SBS_Market.Tools
{
    partial class RestoreForm
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
            this.btnCancel = new SimpleButton();
            this.btnOK = new SimpleButton();
            this.folderBrowser1 = new Syncfusion.Windows.Forms.FolderBrowser(this.components);
            this.label1 = new LabelControl();
            this.label2 = new LabelControl();
            this.label3 = new LabelControl();
            this.label4 = new LabelControl();
            this.laBaza = new LabelControl();
            this.laPeriodi = new LabelControl();
            this.laProeqti = new LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(204, 255);
            this.btnCancel.Name = "btnCancel"; this.btnCancel.Image = global::SBS_Market.Properties.Resources.close_32x32;
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "&Cancel";
            
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(108, 195);
            this.btnOK.Name = "btnOK"; this.btnOK.Image = global::SBS_Market.Properties.Resources.edit_32x32;
            this.btnOK.Size = new System.Drawing.Size(286, 39);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "&მონაცემების მიღება";
            
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // folderBrowser1
            // 
            this.folderBrowser1.StartLocation = Syncfusion.Windows.Forms.FolderBrowserFolder.Desktop;
            this.folderBrowser1.Style = Syncfusion.Windows.Forms.FolderBrowserStyles.RestrictToFilesystem;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 116;
            this.label1.Text = "მონაცემების მიღება";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 117;
            this.label2.Text = "ბაზის სახელი";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 118;
            this.label3.Text = "პერიოდი";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 119;
            this.label4.Text = "პროექტი";
            // 
            // laBaza
            // 
            this.laBaza.AutoSize = true;
            this.laBaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laBaza.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.laBaza.Location = new System.Drawing.Point(146, 47);
            this.laBaza.Name = "laBaza";
            this.laBaza.Size = new System.Drawing.Size(0, 16);
            this.laBaza.TabIndex = 120;
            // 
            // laPeriodi
            // 
            this.laPeriodi.AutoSize = true;
            this.laPeriodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPeriodi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.laPeriodi.Location = new System.Drawing.Point(146, 81);
            this.laPeriodi.Name = "laPeriodi";
            this.laPeriodi.Size = new System.Drawing.Size(0, 16);
            this.laPeriodi.TabIndex = 121;
            // 
            // laProeqti
            // 
            this.laProeqti.AutoSize = true;
            this.laProeqti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProeqti.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.laProeqti.Location = new System.Drawing.Point(146, 113);
            this.laProeqti.Name = "laProeqti";
            this.laProeqti.Size = new System.Drawing.Size(0, 16);
            this.laProeqti.TabIndex = 122;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 34);
            this.button1.TabIndex = 123;
            this.button1.Text = "&საწყისი პარამეტრების მიღება";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RestoreForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(471, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.laProeqti);
            this.Controls.Add(this.laPeriodi);
            this.Controls.Add(this.laBaza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "RestoreForm";
            this.Text = "RestoreForm";
            this.Load += new System.EventHandler(this.RestoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private Syncfusion.Windows.Forms.FolderBrowser folderBrowser1;
        private LabelControl label1;
        private LabelControl label2;
        private LabelControl label3;
        private LabelControl label4;
        private LabelControl laBaza;
        private LabelControl laPeriodi;
        private LabelControl laProeqti;
        private System.Windows.Forms.Button button1;
    }
}