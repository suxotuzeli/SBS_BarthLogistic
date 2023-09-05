namespace SBS_BarthLogistic.InterfaceForms
{
    partial class GridLayoutOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridLayoutOperations));
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dgLayouts = new DevExpress.XtraGrid.GridControl();
            this.gvLayouts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFromDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.gbNewLayout = new DevExpress.XtraEditors.GroupControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.chbSaveOnServer = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLayouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLayouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNewLayout)).BeginInit();
            this.gbNewLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSaveOnServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "პირობითი დასახელება";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Add_32x32;
            this.btnSave.Location = new System.Drawing.Point(2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 46);
            this.panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Delete_32x32;
            this.btnDelete.Location = new System.Drawing.Point(270, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(97, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 42);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(365, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgLayouts
            // 
            this.dgLayouts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLayouts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLayouts.Location = new System.Drawing.Point(0, 102);
            this.dgLayouts.MainView = this.gvLayouts;
            this.dgLayouts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgLayouts.Name = "dgLayouts";
            this.dgLayouts.Size = new System.Drawing.Size(462, 275);
            this.dgLayouts.TabIndex = 17;
            this.dgLayouts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLayouts});
            this.dgLayouts.DoubleClick += new System.EventHandler(this.btnLoad_Click);
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
            this.gvLayouts.OptionsView.EnableAppearanceOddRow = true;
            this.gvLayouts.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvLayouts.OptionsView.RowAutoHeight = true;
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
            this.label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "ამ ფორმაზე უკვე არსებული სქემები";
            // 
            // gbNewLayout
            // 
            this.gbNewLayout.AppearanceCaption.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewLayout.AppearanceCaption.Options.UseFont = true;
            this.gbNewLayout.Controls.Add(this.txtName);
            this.gbNewLayout.Controls.Add(this.chbSaveOnServer);
            this.gbNewLayout.Controls.Add(this.label1);
            this.gbNewLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNewLayout.Location = new System.Drawing.Point(0, 0);
            this.gbNewLayout.Name = "gbNewLayout";
            this.gbNewLayout.Size = new System.Drawing.Size(462, 80);
            this.gbNewLayout.TabIndex = 19;
            this.gbNewLayout.Text = "ახალი სქემის პარამეტრები";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(2, 49);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(307, 28);
            this.txtName.TabIndex = 6;
            // 
            // chbSaveOnServer
            // 
            this.chbSaveOnServer.Location = new System.Drawing.Point(314, 51);
            this.chbSaveOnServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbSaveOnServer.Name = "chbSaveOnServer";
            this.chbSaveOnServer.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSaveOnServer.Properties.Appearance.Options.UseFont = true;
            this.chbSaveOnServer.Properties.Caption = "საერთო";
            this.chbSaveOnServer.Size = new System.Drawing.Size(82, 24);
            this.chbSaveOnServer.TabIndex = 5;
            // 
            // GridLayoutOperations
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(462, 423);
            this.Controls.Add(this.dgLayouts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbNewLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GridLayoutOperations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ცხრილის სქემის პარამეტრების მართვა";
            this.Load += new System.EventHandler(this.GridLayoutOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLayouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLayouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNewLayout)).EndInit();
            this.gbNewLayout.ResumeLayout(false);
            this.gbNewLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSaveOnServer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl dgLayouts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLayouts;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDB;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.GroupControl gbNewLayout;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.CheckEdit chbSaveOnServer;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}