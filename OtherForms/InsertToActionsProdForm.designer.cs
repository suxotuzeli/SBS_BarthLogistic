using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.OtherForms
{
    partial class InsertToActionsProdForm
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.fmgProdG = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdS = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            this.fmgProdT = new SBS_BarthLogistic.Controls.FMGComboFilterControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(302, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 39);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fmgProdG);
            this.panel1.Controls.Add(this.fmgProdS);
            this.panel1.Controls.Add(this.fmgProdT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 203);
            this.panel1.TabIndex = 127;
            // 
            // fmgProdG
            // 
            this.fmgProdG.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdG.Appearance.Options.UseFont = true;
            this.fmgProdG.FieldName = "ProdG";
            this.fmgProdG.Location = new System.Drawing.Point(48, 124);
            this.fmgProdG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdG.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgProdG.Name = "fmgProdG";
            this.fmgProdG.ParameterName = null;
            this.fmgProdG.Size = new System.Drawing.Size(666, 30);
            this.fmgProdG.TabIndex = 8;
            this.fmgProdG.Text = "პროდ.ჯგუფი";
            // 
            // fmgProdS
            // 
            this.fmgProdS.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdS.Appearance.Options.UseFont = true;
            this.fmgProdS.FieldName = "ProdS";
            this.fmgProdS.Location = new System.Drawing.Point(48, 84);
            this.fmgProdS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdS.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgProdS.Name = "fmgProdS";
            this.fmgProdS.ParameterName = null;
            this.fmgProdS.Size = new System.Drawing.Size(666, 30);
            this.fmgProdS.TabIndex = 7;
            this.fmgProdS.Text = "პროდ.სახეობა";
            // 
            // fmgProdT
            // 
            this.fmgProdT.Appearance.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmgProdT.Appearance.Options.UseFont = true;
            this.fmgProdT.FieldName = "ProdT";
            this.fmgProdT.Location = new System.Drawing.Point(50, 44);
            this.fmgProdT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fmgProdT.MinimumSize = new System.Drawing.Size(449, 30);
            this.fmgProdT.Name = "fmgProdT";
            this.fmgProdT.ParameterName = null;
            this.fmgProdT.Size = new System.Drawing.Size(666, 30);
            this.fmgProdT.TabIndex = 6;
            this.fmgProdT.Text = "პროდ.ტიპი";
            // 
            // InsertToActionsProdForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(797, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "InsertToActionsProdForm";
            this.Text = "პროდუქციის ჩამატება";
            this.Load += new System.EventHandler(this.InsertToActionsProdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private Controls.FMGComboFilterControl fmgProdT;
        private Controls.FMGComboFilterControl fmgProdS;
        private PanelControl panel1;
        private Controls.FMGComboFilterControl fmgProdG;
    }
}