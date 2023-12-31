using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.Tools {
    partial class AboutForm {
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
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.laVersia = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.linkLabel1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtInfo = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.laUN = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.laBuild = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(314, 238);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(237, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "FMG BarthLogistics";
            // 
            // laVersia
            // 
            this.laVersia.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.laVersia.Appearance.Options.UseFont = true;
            this.laVersia.Location = new System.Drawing.Point(223, 73);
            this.laVersia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laVersia.Name = "laVersia";
            this.laVersia.Size = new System.Drawing.Size(12, 22);
            this.laVersia.TabIndex = 34;
            this.laVersia.Text = "**";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(223, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "ბაზის ვერსია:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Appearance.Options.UseFont = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(240, 210);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 16);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.fmgsoft.ge";
            this.linkLabel1.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtInfo
            // 
            this.txtInfo.EditValue = "შპს \"ეფემჯი სოფტ\", ს/კ 404857455\r\nთბილისი, ბალანჩივაძის ქ. #2\r\nსაქართველო, 0171\r\n" +
    "e-mail: info@fmgsoft.ge\r\nTEL: (+99532) 2 47 06 00";
            this.txtInfo.Location = new System.Drawing.Point(1, 162);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Properties.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtInfo.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Properties.Appearance.Options.UseBackColor = true;
            this.txtInfo.Properties.Appearance.Options.UseFont = true;
            this.txtInfo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtInfo.Properties.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(219, 100);
            this.txtInfo.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Appearance.Options.UseFont = true;
            this.label5.Location = new System.Drawing.Point(223, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "მომხმარებელი:";
            // 
            // laUN
            // 
            this.laUN.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.laUN.Appearance.Options.UseFont = true;
            this.laUN.Location = new System.Drawing.Point(223, 180);
            this.laUN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laUN.Name = "laUN";
            this.laUN.Size = new System.Drawing.Size(21, 22);
            this.laUN.TabIndex = 42;
            this.laUN.Text = " sa";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(223, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "პროგრამის  ვერსია: ";
            // 
            // laBuild
            // 
            this.laBuild.Appearance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold);
            this.laBuild.Appearance.Options.UseFont = true;
            this.laBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laBuild.Location = new System.Drawing.Point(223, 128);
            this.laBuild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laBuild.Name = "laBuild";
            this.laBuild.Size = new System.Drawing.Size(12, 22);
            this.laBuild.TabIndex = 47;
            this.laBuild.Text = "**";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SBS_BarthLogistic.Properties.Resources.FMG_Soft;
            this.pictureBox2.Location = new System.Drawing.Point(22, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SBS_BarthLogistic.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 274);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laBuild);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.laUN);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.laVersia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtInfo);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "პროგრამის შესახებ";
            this.Activated += new System.EventHandler(this.AboutForm_Activated);
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.Click += new System.EventHandler(this.btnOK_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl laVersia;
        private DevExpress.XtraEditors.LabelControl label3;
        private HyperlinkLabelControl linkLabel1;
        private DevExpress.XtraEditors.MemoEdit txtInfo;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl laUN;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl laBuild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}