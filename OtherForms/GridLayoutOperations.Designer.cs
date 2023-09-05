using DevExpress.XtraEditors;

namespace SBS_Market.OtherForms
{
    partial class SaveLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveLayout));
            this.label1 = new LabelControl();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new PanelControl();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.chbSaveOnServer = new System.Windows.Forms.CheckBox();
            this.dgLayouts = new DevExpress.XtraGrid.GridControl();
            this.gvLayouts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new LabelControl();
            this.gbNewLayout = new DevExpress.XtraEditors.GroupControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLayouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLayouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNewLayout)).BeginInit();
            this.gbNewLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "პირობითი დასახელება";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(5, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 37);
            this.panel1.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(133, 0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 37);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(290, 0);
            this.btnCancel.Name = "btnCancel"; this.btnCancel.Image = global::SBS_Market.Properties.Resources.close_32x32;
            this.btnCancel.Size = new System.Drawing.Size(106, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbSaveOnServer
            // 
            this.chbSaveOnServer.AutoSize = true;
            this.chbSaveOnServer.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSaveOnServer.Location = new System.Drawing.Point(290, 49);
            this.chbSaveOnServer.Name = "chbSaveOnServer";
            this.chbSaveOnServer.Size = new System.Drawing.Size(70, 18);
            this.chbSaveOnServer.TabIndex = 4;
            this.chbSaveOnServer.Text = "საერთო";
            this.chbSaveOnServer.UseVisualStyleBackColor = true;
            // 
            // dgLayouts
            // 
            this.dgLayouts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgLayouts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgLayouts.Location = new System.Drawing.Point(0, 95);
            this.dgLayouts.MainView = this.gvLayouts;
            this.dgLayouts.Name = "dgLayouts";
            this.dgLayouts.Size = new System.Drawing.Size(396, 209);
            this.dgLayouts.TabIndex = 17;
            this.dgLayouts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLayouts});
            this.dgLayouts.DoubleClick += new System.EventHandler(this.dgLayouts_DoubleClick);
            // 
            // gvLayouts
            // 
            this.gvLayouts.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.gvLayouts.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLayouts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colFromDB});
            this.gvLayouts.FooterPanelHeight = 1;
            this.gvLayouts.GridControl = this.dgLayouts;
            this.gvLayouts.GroupPanelText = "დაჯგუფება";
            this.gvLayouts.GroupRowHeight = 1;
            this.gvLayouts.Name = "gvLayouts";
            this.gvLayouts.OptionsBehavior.Editable = false;
            this.gvLayouts.OptionsDetail.AllowZoomDetail = false;
            this.gvLayouts.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail;
            this.gvLayouts.OptionsSelection.MultiSelect = true;
            this.gvLayouts.OptionsView.ColumnAutoWidth = false;
            this.gvLayouts.OptionsView.EnableAppearanceOddRow = true;
            this.gvLayouts.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvLayouts.OptionsView.RowAutoHeight = true;
            this.gvLayouts.OptionsView.ShowAutoFilterRow = true;
            this.gvLayouts.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvLayouts.OptionsView.ShowDetailButtons = false;
            this.gvLayouts.OptionsView.ShowFooter = true;
            this.gvLayouts.OptionsView.ShowGroupedColumns = true;
            this.gvLayouts.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "დასახელება";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 255;
            // 
            // colFromDB
            // 
            this.colFromDB.Caption = "საერთო";
            this.colFromDB.FieldName = "FromDB";
            this.colFromDB.Name = "colFromDB";
            this.colFromDB.OptionsColumn.AllowEdit = false;
            this.colFromDB.Visible = true;
            this.colFromDB.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "ამ ფორმაზე უკვე არსებული სქემები";
            // 
            // gbNewLayout
            // 
            this.gbNewLayout.AppearanceCaption.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewLayout.AppearanceCaption.Options.UseFont = true;
            this.gbNewLayout.Controls.Add(this.txtName);
            this.gbNewLayout.Controls.Add(this.label1);
            this.gbNewLayout.Controls.Add(this.chbSaveOnServer);
            this.gbNewLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNewLayout.Location = new System.Drawing.Point(0, 0);
            this.gbNewLayout.Name = "gbNewLayout";
            this.gbNewLayout.Size = new System.Drawing.Size(396, 81);
            this.gbNewLayout.TabIndex = 19;
            this.gbNewLayout.Text = "ახალი სქემის პარამეტრები";
            // 
            // SaveLayout
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 344);
            this.Controls.Add(this.dgLayouts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbNewLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ცხრილის სქემის პარამეტრების მართვა";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLayouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLayouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNewLayout)).EndInit();
            this.gbNewLayout.ResumeLayout(false);
            this.gbNewLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl label1;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.CheckBox chbSaveOnServer;
        private DevExpress.XtraGrid.GridControl dgLayouts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLayouts;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDB;
        private LabelControl label2;
        private DevExpress.XtraEditors.GroupControl gbNewLayout;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
    }
}