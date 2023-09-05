namespace SBS_BarthLogistic.InterfaceForms
{
    partial class PanelLayoutOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelLayoutOperations));
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dgLayouts = new DevExpress.XtraGrid.GridControl();
            this.gvLayouts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.laLayouts = new DevExpress.XtraEditors.LabelControl();
            this.gbNewLayout = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLayouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLayouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNewLayout)).BeginInit();
            this.gbNewLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "პირობითი დასახელება";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Location = new System.Drawing.Point(2, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(392, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Add_32x32;
            this.btnSave.Location = new System.Drawing.Point(2, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 33);
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
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 37);
            this.panel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Delete_32x32;
            this.btnDelete.Location = new System.Drawing.Point(232, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(83, 2);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(81, 33);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.AED_Close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(313, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgLayouts
            // 
            this.dgLayouts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLayouts.Location = new System.Drawing.Point(0, 81);
            this.dgLayouts.MainView = this.gvLayouts;
            this.dgLayouts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgLayouts.Name = "dgLayouts";
            this.dgLayouts.Size = new System.Drawing.Size(396, 226);
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
            this.colName});
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
            // laLayouts
            // 
            this.laLayouts.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.laLayouts.Dock = System.Windows.Forms.DockStyle.Top;
            this.laLayouts.Location = new System.Drawing.Point(0, 65);
            this.laLayouts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laLayouts.Name = "laLayouts";
            this.laLayouts.Size = new System.Drawing.Size(203, 16);
            this.laLayouts.TabIndex = 18;
            this.laLayouts.Text = "ამ ფორმაზე უკვე არსებული სქემები";
            // 
            // gbNewLayout
            // 
            this.gbNewLayout.AppearanceCaption.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewLayout.AppearanceCaption.Options.UseFont = true;
            this.gbNewLayout.Controls.Add(this.txtName);
            this.gbNewLayout.Controls.Add(this.label1);
            this.gbNewLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNewLayout.Location = new System.Drawing.Point(0, 0);
            this.gbNewLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNewLayout.Name = "gbNewLayout";
            this.gbNewLayout.Size = new System.Drawing.Size(396, 65);
            this.gbNewLayout.TabIndex = 19;
            this.gbNewLayout.Text = "ახალი სქემის პარამეტრები";
            // 
            // PanelLayoutOperations
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 344);
            this.Controls.Add(this.dgLayouts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.laLayouts);
            this.Controls.Add(this.gbNewLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelLayoutOperations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ფილტრის პარამეტრების მართვა";
            this.Load += new System.EventHandler(this.PanelLayoutOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
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

        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl dgLayouts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLayouts;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.LabelControl laLayouts;
        private DevExpress.XtraEditors.GroupControl gbNewLayout;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}