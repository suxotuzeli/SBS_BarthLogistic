namespace SBS_BarthLogistic.AddForms
{
    partial class AddMISubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMISubForm));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.laControlList = new DevExpress.XtraEditors.LabelControl();
            this.txtControlList = new DevExpress.XtraEditors.TextEdit();
            this.txtIdMISub = new DevExpress.XtraEditors.TextEdit();
            this.laIdMISub = new DevExpress.XtraEditors.LabelControl();
            this.txtMISub = new DevExpress.XtraEditors.TextEdit();
            this.laMISub = new DevExpress.XtraEditors.LabelControl();
            this.txtTableList = new DevExpress.XtraEditors.TextEdit();
            this.laTableList = new DevExpress.XtraEditors.LabelControl();
            this.txtProcList = new DevExpress.XtraEditors.TextEdit();
            this.laProcList = new DevExpress.XtraEditors.LabelControl();
            this.txtViewList = new DevExpress.XtraEditors.TextEdit();
            this.laViewList = new DevExpress.XtraEditors.LabelControl();
            this.cbMIMain = new System.Windows.Forms.ComboBox();
            this.laMIMain = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnCancel.Location = new System.Drawing.Point(693, 9);
            this.btnCancel.Name = "btnCancel"; this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnOK.Location = new System.Drawing.Point(584, 9);
            this.btnOK.Name = "btnOK"; 
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnAdd.Location = new System.Drawing.Point(24, 9);
            this.btnAdd.Name = "btnAdd";this.btnAdd.Size = new System.Drawing.Size(87, 37);
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
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
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 44);
            this.panel1.TabIndex = 8;
            // 
            // laControlList
            // 
            this.laControlList.AutoSize = true;
            this.laControlList.Location = new System.Drawing.Point(708, 329);
            this.laControlList.Name = "laControlList";
            this.laControlList.Size = new System.Drawing.Size(78, 22);
            this.laControlList.TabIndex = 7;
            this.laControlList.Text = "ControlList";
            // 
            // txtControlList
            // 
            this.txtControlList.Location = new System.Drawing.Point(24, 329);
            this.txtControlList.Name = "txtControlList";
            this.txtControlList.Size = new System.Drawing.Size(678, 75);
            this.txtControlList.TabIndex = 7;
            this.txtControlList.Enter += new System.EventHandler(this.txtTableList_Enter);
            this.txtControlList.Leave += new System.EventHandler(this.txtTableList_Leave);
            // 
            // txtIdMISub
            // 
            this.txtIdMISub.Location = new System.Drawing.Point(24, 39);
            this.txtIdMISub.Name = "txtIdMISub";
            this.txtIdMISub.Size = new System.Drawing.Size(100, 29);
            this.txtIdMISub.TabIndex = 0;
            // 
            // laIdMISub
            // 
            this.laIdMISub.AutoSize = true;
            this.laIdMISub.Location = new System.Drawing.Point(24, 13);
            this.laIdMISub.Name = "laIdMISub";
            this.laIdMISub.Size = new System.Drawing.Size(63, 22);
            this.laIdMISub.TabIndex = 7;
            this.laIdMISub.Text = "IdMISub";
            // 
            // txtMISub
            // 
            this.txtMISub.Location = new System.Drawing.Point(137, 39);
            this.txtMISub.Name = "txtMISub";
            this.txtMISub.Size = new System.Drawing.Size(299, 29);
            this.txtMISub.TabIndex = 1;
            // 
            // laMISub
            // 
            this.laMISub.AutoSize = true;
            this.laMISub.Location = new System.Drawing.Point(137, 13);
            this.laMISub.Name = "laMISub";
            this.laMISub.Size = new System.Drawing.Size(50, 22);
            this.laMISub.TabIndex = 7;
            this.laMISub.Text = "MISub";
            // 
            // txtTableList
            // 
            this.txtTableList.Location = new System.Drawing.Point(24, 104);
            this.txtTableList.Name = "txtTableList";
            this.txtTableList.Size = new System.Drawing.Size(678, 75);
            this.txtTableList.TabIndex = 4;
            this.txtTableList.Enter += new System.EventHandler(this.txtTableList_Enter);
            this.txtTableList.Leave += new System.EventHandler(this.txtTableList_Leave);
            // 
            // laTableList
            // 
            this.laTableList.AutoSize = true;
            this.laTableList.Location = new System.Drawing.Point(711, 104);
            this.laTableList.Name = "laTableList";
            this.laTableList.Size = new System.Drawing.Size(66, 22);
            this.laTableList.TabIndex = 7;
            this.laTableList.Text = "TableList";
            // 
            // txtProcList
            // 
            this.txtProcList.Location = new System.Drawing.Point(24, 179);
            this.txtProcList.Name = "txtProcList";
            this.txtProcList.Size = new System.Drawing.Size(678, 75);
            this.txtProcList.TabIndex = 5;
            this.txtProcList.Enter += new System.EventHandler(this.txtTableList_Enter);
            this.txtProcList.Leave += new System.EventHandler(this.txtTableList_Leave);
            // 
            // laProcList
            // 
            this.laProcList.AutoSize = true;
            this.laProcList.Location = new System.Drawing.Point(708, 179);
            this.laProcList.Name = "laProcList";
            this.laProcList.Size = new System.Drawing.Size(61, 22);
            this.laProcList.TabIndex = 7;
            this.laProcList.Text = "ProcList";
            // 
            // txtViewList
            // 
            this.txtViewList.Location = new System.Drawing.Point(24, 254);
            this.txtViewList.Name = "txtViewList";
            this.txtViewList.Size = new System.Drawing.Size(678, 75);
            this.txtViewList.TabIndex = 6;
            this.txtViewList.Enter += new System.EventHandler(this.txtTableList_Enter);
            this.txtViewList.Leave += new System.EventHandler(this.txtTableList_Leave);
            // 
            // laViewList
            // 
            this.laViewList.AutoSize = true;
            this.laViewList.Location = new System.Drawing.Point(708, 254);
            this.laViewList.Name = "laViewList";
            this.laViewList.Size = new System.Drawing.Size(65, 22);
            this.laViewList.TabIndex = 7;
            this.laViewList.Text = "ViewList";
            // 
            // cbMIMain
            // 
            this.cbMIMain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMIMain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMIMain.FormattingEnabled = true;
            this.cbMIMain.Location = new System.Drawing.Point(442, 39);
            this.cbMIMain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cbMIMain.Name = "cbMIMain";
            this.cbMIMain.Size = new System.Drawing.Size(260, 30);
            this.cbMIMain.TabIndex = 2;
            // 
            // laMIMain
            // 
            this.laMIMain.AutoSize = true;
            this.laMIMain.Location = new System.Drawing.Point(442, 13);
            this.laMIMain.Name = "laMIMain";
            this.laMIMain.Size = new System.Drawing.Size(58, 22);
            this.laMIMain.TabIndex = 8;
            this.laMIMain.Text = "MIMain";
            // 
            // AddMISubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(818, 479);
            this.Controls.Add(this.cbMIMain);
            this.Controls.Add(this.laMIMain);
            this.Controls.Add(this.laTableList);
            this.Controls.Add(this.laMISub);
            this.Controls.Add(this.laIdMISub);
            this.Controls.Add(this.laViewList);
            this.Controls.Add(this.laProcList);
            this.Controls.Add(this.laControlList);
            this.Controls.Add(this.txtTableList);
            this.Controls.Add(this.txtMISub);
            this.Controls.Add(this.txtIdMISub);
            this.Controls.Add(this.txtViewList);
            this.Controls.Add(this.txtProcList);
            this.Controls.Add(this.txtControlList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "AddMISubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddMISubForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.LabelControl laControlList;
        private DevExpress.XtraEditors.TextEdit txtControlList;
        private DevExpress.XtraEditors.TextEdit txtIdMISub;
        private DevExpress.XtraEditors.LabelControl laIdMISub;
        private DevExpress.XtraEditors.TextEdit txtMISub;
        private DevExpress.XtraEditors.LabelControl laMISub;
        private DevExpress.XtraEditors.TextEdit txtTableList;
        private DevExpress.XtraEditors.LabelControl laTableList;
        private DevExpress.XtraEditors.TextEdit txtProcList;
        private DevExpress.XtraEditors.LabelControl laProcList;
        private DevExpress.XtraEditors.TextEdit txtViewList;
        private DevExpress.XtraEditors.LabelControl laViewList;
        private System.Windows.Forms.ComboBox cbMIMain;
        private DevExpress.XtraEditors.LabelControl laMIMain;
    }
}