using DevExpress.XtraEditors;

namespace SBS_BarthLogistic.Tools
{
    partial class SetUserPermissionsForm
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
            DevExpress.XtraEditors.LabelControl label2;
            this.dg = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMIPermission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMISub = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanInsert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanExec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.cbMomx2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cbMomx2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbMomx = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cbMomxView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtGascorebaDge = new DevExpress.XtraEditors.SpinEdit();
            this.chbUser2 = new DevExpress.XtraEditors.CheckEdit();
            this.chbSelect = new DevExpress.XtraEditors.CheckEdit();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.chbGascorebaSxva = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            label2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomx2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomx2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGascorebaDge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbUser2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGascorebaSxva.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(680, 16);
            label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(362, 22);
            label2.TabIndex = 6;
            label2.Text = "რამდენი დღის ინფორმაციის შეცვლა შეუძლია";
            // 
            // dg
            // 
            this.dg.AllowDrop = true;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg.Location = new System.Drawing.Point(0, 117);
            this.dg.MainView = this.gridView1;
            this.dg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1312, 512);
            this.dg.TabIndex = 1;
            this.dg.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dg.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgDragDrop);
            this.dg.DragEnter += new System.Windows.Forms.DragEventHandler(this.DgDragEnter);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMIPermission,
            this.colUN,
            this.colMISub,
            this.colMIMain,
            this.colCanSelect,
            this.colCanUpdate,
            this.colCanDelete,
            this.colCanInsert,
            this.colCanExec,
            this.colCanView});
            this.gridView1.FooterPanelHeight = 1;
            this.gridView1.GridControl = this.dg;
            this.gridView1.GroupPanelText = "დაჯგუფება";
            this.gridView1.GroupRowHeight = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdMIPermission
            // 
            this.colIdMIPermission.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colIdMIPermission.AppearanceHeader.Options.UseFont = true;
            this.colIdMIPermission.Caption = "კოდი";
            this.colIdMIPermission.FieldName = "IdMIPermission";
            this.colIdMIPermission.Name = "colIdMIPermission";
            // 
            // colUN
            // 
            this.colUN.AppearanceCell.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.colUN.AppearanceCell.Options.UseFont = true;
            this.colUN.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colUN.AppearanceHeader.Options.UseFont = true;
            this.colUN.Caption = "მომხმარებელი";
            this.colUN.FieldName = "UN";
            this.colUN.Name = "colUN";
            // 
            // colMISub
            // 
            this.colMISub.AppearanceCell.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.colMISub.AppearanceCell.Options.UseFont = true;
            this.colMISub.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colMISub.AppearanceHeader.Options.UseFont = true;
            this.colMISub.Caption = "მენიუს ქვეპუნქტი";
            this.colMISub.FieldName = "MISub";
            this.colMISub.Name = "colMISub";
            this.colMISub.Visible = true;
            this.colMISub.VisibleIndex = 0;
            this.colMISub.Width = 117;
            // 
            // colMIMain
            // 
            this.colMIMain.AppearanceCell.Font = new System.Drawing.Font("Sylfaen", 8.25F);
            this.colMIMain.AppearanceCell.Options.UseFont = true;
            this.colMIMain.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colMIMain.AppearanceHeader.Options.UseFont = true;
            this.colMIMain.Caption = "მენიუს პუნქტი";
            this.colMIMain.FieldName = "MIMain";
            this.colMIMain.Name = "colMIMain";
            this.colMIMain.Visible = true;
            this.colMIMain.VisibleIndex = 1;
            this.colMIMain.Width = 98;
            // 
            // colCanSelect
            // 
            this.colCanSelect.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colCanSelect.AppearanceHeader.Options.UseFont = true;
            this.colCanSelect.Caption = "ნახვა";
            this.colCanSelect.FieldName = "CanSelect";
            this.colCanSelect.Name = "colCanSelect";
            this.colCanSelect.ShowUnboundExpressionMenu = true;
            this.colCanSelect.Visible = true;
            this.colCanSelect.VisibleIndex = 2;
            // 
            // colCanUpdate
            // 
            this.colCanUpdate.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colCanUpdate.AppearanceHeader.Options.UseFont = true;
            this.colCanUpdate.Caption = "რედაქტირება";
            this.colCanUpdate.FieldName = "CanUpdate";
            this.colCanUpdate.Name = "colCanUpdate";
            this.colCanUpdate.Visible = true;
            this.colCanUpdate.VisibleIndex = 3;
            this.colCanUpdate.Width = 119;
            // 
            // colCanDelete
            // 
            this.colCanDelete.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colCanDelete.AppearanceHeader.Options.UseFont = true;
            this.colCanDelete.Caption = "წაშლა";
            this.colCanDelete.FieldName = "CanDelete";
            this.colCanDelete.Name = "colCanDelete";
            this.colCanDelete.Visible = true;
            this.colCanDelete.VisibleIndex = 4;
            // 
            // colCanInsert
            // 
            this.colCanInsert.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colCanInsert.AppearanceHeader.Options.UseFont = true;
            this.colCanInsert.Caption = "ჩამატება";
            this.colCanInsert.FieldName = "CanInsert";
            this.colCanInsert.Name = "colCanInsert";
            this.colCanInsert.Visible = true;
            this.colCanInsert.VisibleIndex = 5;
            this.colCanInsert.Width = 98;
            // 
            // colCanExec
            // 
            this.colCanExec.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colCanExec.AppearanceHeader.Options.UseFont = true;
            this.colCanExec.Caption = "რეპორტის ნახვა";
            this.colCanExec.FieldName = "CanExec";
            this.colCanExec.Name = "colCanExec";
            this.colCanExec.Visible = true;
            this.colCanExec.VisibleIndex = 6;
            this.colCanExec.Width = 121;
            // 
            // colCanView
            // 
            this.colCanView.AppearanceHeader.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.colCanView.AppearanceHeader.Options.UseFont = true;
            this.colCanView.Caption = "მენიუს გამოჩენა";
            this.colCanView.FieldName = "CanView";
            this.colCanView.Name = "colCanView";
            this.colCanView.Visible = true;
            this.colCanView.VisibleIndex = 7;
            this.colCanView.Width = 138;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMomx2);
            this.panel2.Controls.Add(this.cbMomx);
            this.panel2.Controls.Add(this.txtGascorebaDge);
            this.panel2.Controls.Add(this.chbUser2);
            this.panel2.Controls.Add(this.chbSelect);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.chbGascorebaSxva);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 117);
            this.panel2.TabIndex = 0;
            // 
            // cbMomx2
            // 
            this.cbMomx2.Location = new System.Drawing.Point(160, 66);
            this.cbMomx2.Name = "cbMomx2";
            this.cbMomx2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.cbMomx2.Properties.Appearance.Options.UseFont = true;
            this.cbMomx2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMomx2.Properties.ShowClearButton = false;
            this.cbMomx2.Properties.ShowFooter = false;
            this.cbMomx2.Properties.View = this.cbMomx2View;
            this.cbMomx2.Size = new System.Drawing.Size(179, 26);
            this.cbMomx2.TabIndex = 4;
            this.cbMomx2.Visible = false;
            // 
            // cbMomx2View
            // 
            this.cbMomx2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cbMomx2View.Name = "cbMomx2View";
            this.cbMomx2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cbMomx2View.OptionsView.ShowColumnHeaders = false;
            this.cbMomx2View.OptionsView.ShowGroupPanel = false;
            // 
            // cbMomx
            // 
            this.cbMomx.Location = new System.Drawing.Point(160, 14);
            this.cbMomx.Name = "cbMomx";
            this.cbMomx.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.cbMomx.Properties.Appearance.Options.UseFont = true;
            this.cbMomx.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMomx.Properties.ShowClearButton = false;
            this.cbMomx.Properties.ShowFooter = false;
            this.cbMomx.Properties.View = this.cbMomxView;
            this.cbMomx.Size = new System.Drawing.Size(179, 26);
            this.cbMomx.TabIndex = 1;
            // 
            // cbMomxView
            // 
            this.cbMomxView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cbMomxView.Name = "cbMomxView";
            this.cbMomxView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cbMomxView.OptionsView.ShowColumnHeaders = false;
            this.cbMomxView.OptionsView.ShowGroupPanel = false;
            // 
            // txtGascorebaDge
            // 
            this.txtGascorebaDge.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGascorebaDge.Location = new System.Drawing.Point(1046, 16);
            this.txtGascorebaDge.Name = "txtGascorebaDge";
            this.txtGascorebaDge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGascorebaDge.Size = new System.Drawing.Size(100, 22);
            this.txtGascorebaDge.TabIndex = 7;
            // 
            // chbUser2
            // 
            this.chbUser2.Location = new System.Drawing.Point(7, 65);
            this.chbUser2.Name = "chbUser2";
            this.chbUser2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbUser2.Properties.Appearance.Options.UseFont = true;
            this.chbUser2.Properties.AutoWidth = true;
            this.chbUser2.Properties.Caption = "მომხმარებელი 2";
            this.chbUser2.Size = new System.Drawing.Size(150, 26);
            this.chbUser2.TabIndex = 3;
            this.chbUser2.Tag = "";
            this.chbUser2.CheckedChanged += new System.EventHandler(this.chbUser2_CheckedChanged);
            // 
            // chbSelect
            // 
            this.chbSelect.EditValue = true;
            this.chbSelect.Location = new System.Drawing.Point(346, 14);
            this.chbSelect.Name = "chbSelect";
            this.chbSelect.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbSelect.Properties.Appearance.Options.UseFont = true;
            this.chbSelect.Properties.AutoWidth = true;
            this.chbSelect.Properties.Caption = "ყველას მონიშვნა";
            this.chbSelect.Size = new System.Drawing.Size(155, 26);
            this.chbSelect.TabIndex = 2;
            this.chbSelect.Tag = "";
            this.chbSelect.CheckedChanged += new System.EventHandler(this.ChbselectCheckedChanged);
            this.chbSelect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChbselectMouseDown);
            this.chbSelect.MouseHover += new System.EventHandler(this.chbselect_MouseHover);
            this.chbSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chbselect_MouseMove);
            // 
            // btnCopy
            // 
            this.btnCopy.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Appearance.Options.UseFont = true;
            this.btnCopy.Location = new System.Drawing.Point(346, 57);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(317, 44);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "უფლებების კოპირება";
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chbGascorebaSxva
            // 
            this.chbGascorebaSxva.Location = new System.Drawing.Point(680, 65);
            this.chbGascorebaSxva.Name = "chbGascorebaSxva";
            this.chbGascorebaSxva.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbGascorebaSxva.Properties.Appearance.Options.UseFont = true;
            this.chbGascorebaSxva.Properties.AutoWidth = true;
            this.chbGascorebaSxva.Properties.Caption = "სხვისი შეტანილი ინფორმაციის ცვლილების უფლება";
            this.chbGascorebaSxva.Size = new System.Drawing.Size(434, 26);
            this.chbGascorebaSxva.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SBS_BarthLogistic.Properties.Resources.close_32x32;
            this.btnCancel.Location = new System.Drawing.Point(1184, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(1184, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "მომხმარებელი";
            // 
            // SetUserPermissionsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1312, 629);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.panel2);
            this.Name = "SetUserPermissionsForm";
            this.ShowIcon = false;
            this.Text = "მომხმარებლებისათვის უფლებების მინიჭება";
            this.Load += new System.EventHandler(this.SetUserPermissionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomx2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomx2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMomxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGascorebaDge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbUser2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbGascorebaSxva.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dg;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private PanelControl panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMIPermission;
        private DevExpress.XtraGrid.Columns.GridColumn colUN;
        private DevExpress.XtraGrid.Columns.GridColumn colMISub;
        private DevExpress.XtraGrid.Columns.GridColumn colMIMain;
        private DevExpress.XtraGrid.Columns.GridColumn colCanSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colCanUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colCanDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colCanInsert;
        private DevExpress.XtraGrid.Columns.GridColumn colCanExec;
        private DevExpress.XtraGrid.Columns.GridColumn colCanView;
        private LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private SimpleButton btnCancel;
        private DevExpress.XtraEditors.CheckEdit chbGascorebaSxva;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.CheckEdit chbSelect;
        private DevExpress.XtraEditors.CheckEdit chbUser2;
        private SpinEdit txtGascorebaDge;
        private SearchLookUpEdit cbMomx;
        private DevExpress.XtraGrid.Views.Grid.GridView cbMomxView;
        private SearchLookUpEdit cbMomx2;
        private DevExpress.XtraGrid.Views.Grid.GridView cbMomx2View;
    }
}