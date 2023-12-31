using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.AddForms
{
    partial class AddZeddAutoForm
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
            DevExpress.XtraEditors.LabelControl laNum;
            DevExpress.XtraEditors.LabelControl laSufics;
            DevExpress.XtraEditors.LabelControl laPrefics;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSufics = new DevExpress.XtraEditors.TextEdit();
            this.txtPrefics = new DevExpress.XtraEditors.TextEdit();
            this.chbActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtNum = new DevExpress.XtraEditors.CalcEdit();
            laNum = new DevExpress.XtraEditors.LabelControl();
            laSufics = new DevExpress.XtraEditors.LabelControl();
            laPrefics = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSufics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laNum
            // 
            laNum.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            laNum.Location = new System.Drawing.Point(261, 13);
            laNum.Name = "laNum";
            laNum.Size = new System.Drawing.Size(34, 16);
            laNum.TabIndex = 20;
            laNum.Text = "ნომერი";
            // 
            // laSufics
            // 
            laSufics.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            laSufics.Location = new System.Drawing.Point(140, 13);
            laSufics.Name = "laSufics";
            laSufics.Size = new System.Drawing.Size(40, 16);
            laSufics.TabIndex = 19;
            laSufics.Text = "სუფიქსი";
            // 
            // laPrefics
            // 
            laPrefics.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            laPrefics.Location = new System.Drawing.Point(15, 13);
            laPrefics.Name = "laPrefics";
            laPrefics.Size = new System.Drawing.Size(45, 16);
            laPrefics.TabIndex = 18;
            laPrefics.Text = "პრეფიქსი";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(311, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            
            this.btnOK.Location = new System.Drawing.Point(223, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            
            this.btnAdd.Location = new System.Drawing.Point(18, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 43);
            this.panel1.TabIndex = 4;
            // 
            // txtSufics
            // 
            this.txtSufics.Location = new System.Drawing.Point(143, 32);
            this.txtSufics.Name = "txtSufics";
            this.txtSufics.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSufics.Properties.Appearance.Options.UseFont = true;
            this.txtSufics.Size = new System.Drawing.Size(102, 22);
            this.txtSufics.TabIndex = 1;
            // 
            // txtPrefics
            // 
            this.txtPrefics.Location = new System.Drawing.Point(18, 32);
            this.txtPrefics.Name = "txtPrefics";
            this.txtPrefics.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPrefics.Properties.Appearance.Options.UseFont = true;
            this.txtPrefics.Size = new System.Drawing.Size(102, 22);
            this.txtPrefics.TabIndex = 0;
            // 
            // chbActive
            // 
            this.chbActive.EditValue = true;
            this.chbActive.Location = new System.Drawing.Point(15, 73);
            this.chbActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbActive.Name = "chbActive";
            this.chbActive.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbActive.Properties.Appearance.Options.UseFont = true;
            this.chbActive.Properties.Caption = "აქტიურია?";
            this.chbActive.Size = new System.Drawing.Size(102, 21);
            this.chbActive.TabIndex = 3;
            // 
            // txtNum
            // 
            this.txtNum.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNum.Location = new System.Drawing.Point(261, 32);
            this.txtNum.Name = "txtNum";
            this.txtNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::SBS_BarthLogistic.Properties.Resources.AED_txtCalcEdit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtNum.Size = new System.Drawing.Size(116, 22);
            this.txtNum.TabIndex = 2;
            // 
            // AddZeddAutoForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 151);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(laNum);
            this.Controls.Add(laSufics);
            this.Controls.Add(this.txtSufics);
            this.Controls.Add(laPrefics);
            this.Controls.Add(this.txtPrefics);
            this.Controls.Add(this.panel1);
            this.Name = "AddZeddAutoForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddZeddAutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSufics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrefics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SimpleButton btnCancel;
        private SimpleButton btnOK;
        private SimpleButton btnAdd;
        private PanelControl panel1;
        private TextEdit txtSufics;
        private TextEdit txtPrefics;
        private CheckEdit chbActive;
        private CalcEdit txtNum;
    }
}