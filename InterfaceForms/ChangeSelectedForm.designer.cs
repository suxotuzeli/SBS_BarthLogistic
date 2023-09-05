namespace SBS_BarthLogistic.InterfaceForms
{
    partial class ChangeSelectedForm
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
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.paBottom = new DevExpress.XtraEditors.PanelControl();
            this.paMain = new DevExpress.XtraEditors.PanelControl();
            this.paGridView = new DevExpress.XtraEditors.PanelControl();
            this.dg = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.laInfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paMain)).BeginInit();
            this.paMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paGridView)).BeginInit();
            this.paGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(17, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 32);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "შეცვლა";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(522, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "გაუქმება";
            // 
            // paBottom
            // 
            this.paBottom.Controls.Add(this.btnOk);
            this.paBottom.Controls.Add(this.btnCancel);
            this.paBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom.Location = new System.Drawing.Point(0, 396);
            this.paBottom.Name = "paBottom";
            this.paBottom.Size = new System.Drawing.Size(634, 40);
            this.paBottom.TabIndex = 4;
            // 
            // paMain
            // 
            this.paMain.Controls.Add(this.laInfo);
            this.paMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.paMain.Location = new System.Drawing.Point(0, 0);
            this.paMain.Name = "paMain";
            this.paMain.Size = new System.Drawing.Size(634, 120);
            this.paMain.TabIndex = 5;
            // 
            // paGridView
            // 
            this.paGridView.Controls.Add(this.dg);
            this.paGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paGridView.Location = new System.Drawing.Point(0, 120);
            this.paGridView.Name = "paGridView";
            this.paGridView.Size = new System.Drawing.Size(634, 276);
            this.paGridView.TabIndex = 5;
            // 
            // dg
            // 
            this.dg.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dg.Location = new System.Drawing.Point(2, 2);
            this.dg.MainView = this.gridView;
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(630, 272);
            this.dg.TabIndex = 8;
            this.dg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.FooterPanelHeight = 1;
            this.gridView.GridControl = this.dg;
            this.gridView.GroupPanelText = "დაჯგუფება";
            this.gridView.GroupRowHeight = 1;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsDetail.AllowZoomDetail = false;
            this.gridView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.EnableAppearanceOddRow = true;
            this.gridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowDetailButtons = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // laInfo
            // 
            this.laInfo.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laInfo.Location = new System.Drawing.Point(17, 12);
            this.laInfo.Name = "laInfo";
            this.laInfo.Size = new System.Drawing.Size(67, 16);
            this.laInfo.TabIndex = 4;
            this.laInfo.Text = "labelControl1";
            // 
            // ChangeSelectedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 436);
            this.Controls.Add(this.paGridView);
            this.Controls.Add(this.paMain);
            this.Controls.Add(this.paBottom);
            this.Name = "ChangeSelectedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ChangeSelectedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            this.paBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paMain)).EndInit();
            this.paMain.ResumeLayout(false);
            this.paMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paGridView)).EndInit();
            this.paGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl paBottom;
        private DevExpress.XtraEditors.PanelControl paMain;
        private DevExpress.XtraEditors.PanelControl paGridView;
        private DevExpress.XtraGrid.GridControl dg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.LabelControl laInfo;
    }
}