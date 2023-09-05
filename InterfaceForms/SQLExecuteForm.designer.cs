namespace SBS_BarthLogistic.InterfaceForms
{
    partial class SQLExecute
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
            this.components = new System.ComponentModel.Container();
            this.txtScript = new DevExpress.XtraRichEdit.RichEditControl();
            this.txtResult = new DevExpress.XtraRichEdit.RichEditControl();
            this.fpa1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadStruct = new DevExpress.XtraEditors.SimpleButton();
            this.btnExecute = new DevExpress.XtraEditors.SimpleButton();
            this.chbSyntax = new DevExpress.XtraEditors.CheckEdit();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSetText = new System.Windows.Forms.Button();
            this.lbSugg = new System.Windows.Forms.ListBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabMessage = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.propertyGrid = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.fpa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSyntax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtScript.Appearance.Text.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScript.Appearance.Text.Options.UseFont = true;
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScript.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Twip;
            this.txtScript.Location = new System.Drawing.Point(0, 34);
            this.txtScript.Name = "txtScript";
            this.txtScript.Options.AutoCorrect.DetectUrls = false;
            this.txtScript.Options.Behavior.Copy = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.Cut = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.Drag = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.Drop = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.OvertypeAllowed = false;
            this.txtScript.Options.Behavior.Paste = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.Save = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.SaveAs = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.Touch = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.Behavior.Zooming = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.txtScript.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.Comments = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.EndNotes = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.FloatingObjects = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.FootNotes = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.Hyperlinks = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.InlinePictures = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.ParagraphFormatting = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.ParagraphFrames = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.Tables = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.DocumentCapabilities.TableStyle = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.txtScript.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtScript.Options.SpellChecker.AutoDetectDocumentCulture = false;
            this.txtScript.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtScript.Size = new System.Drawing.Size(919, 401);
            this.txtScript.TabIndex = 0;
            this.txtScript.TextChanged += new System.EventHandler(this.txtScript_TextChanged);
            this.txtScript.Paint += new System.Windows.Forms.PaintEventHandler(this.txtScript_Paint);
            this.txtScript.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScript_KeyDown);
            // 
            // txtResult
            // 
            this.txtResult.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtResult.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtResult.Size = new System.Drawing.Size(912, 177);
            this.txtResult.TabIndex = 0;
            // 
            // fpa1
            // 
            this.fpa1.Controls.Add(this.btnLoadStruct);
            this.fpa1.Controls.Add(this.btnExecute);
            this.fpa1.Controls.Add(this.chbSyntax);
            this.fpa1.Controls.Add(this.txtText);
            this.fpa1.Controls.Add(this.btnSetText);
            this.fpa1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpa1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpa1.Location = new System.Drawing.Point(0, 0);
            this.fpa1.Name = "fpa1";
            this.fpa1.Size = new System.Drawing.Size(919, 34);
            this.fpa1.TabIndex = 1;
            // 
            // btnLoadStruct
            // 
            this.btnLoadStruct.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnLoadStruct.Appearance.Options.UseFont = true;
            this.btnLoadStruct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadStruct.Image = global::SBS_BarthLogistic.Properties.Resources.Arrow_split_down_32;
            this.btnLoadStruct.Location = new System.Drawing.Point(3, 3);
            this.btnLoadStruct.Name = "btnLoadStruct";
            this.btnLoadStruct.Size = new System.Drawing.Size(152, 28);
            this.btnLoadStruct.TabIndex = 2;
            this.btnLoadStruct.Text = "Load Content";
            this.btnLoadStruct.ToolTip = "Load Content";
            this.btnLoadStruct.Click += new System.EventHandler(this.btnLoadStruct_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnExecute.Appearance.Options.UseFont = true;
            this.btnExecute.AutoSize = true;
            this.btnExecute.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExecute.Location = new System.Drawing.Point(161, 3);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(62, 28);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.ToolTip = "Execute";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // chbSyntax
            // 
            this.chbSyntax.Location = new System.Drawing.Point(229, 3);
            this.chbSyntax.Name = "chbSyntax";
            this.chbSyntax.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSyntax.Properties.Appearance.Options.UseFont = true;
            this.chbSyntax.Properties.AutoWidth = true;
            this.chbSyntax.Properties.Caption = "სინტაქსი";
            this.chbSyntax.Size = new System.Drawing.Size(86, 23);
            this.chbSyntax.TabIndex = 3;
            this.chbSyntax.CheckedChanged += new System.EventHandler(this.chbSyntax_CheckedChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(321, 3);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 27);
            this.txtText.TabIndex = 4;
            // 
            // btnSetText
            // 
            this.btnSetText.Location = new System.Drawing.Point(427, 3);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(143, 23);
            this.btnSetText.TabIndex = 5;
            this.btnSetText.Text = "<- ტექსტი ფორმაზე";
            this.btnSetText.UseVisualStyleBackColor = true;
            this.btnSetText.Click += new System.EventHandler(this.btnSetText_Click);
            // 
            // lbSugg
            // 
            this.lbSugg.Font = new System.Drawing.Font("Sylfaen", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSugg.FormattingEnabled = true;
            this.lbSugg.ItemHeight = 18;
            this.lbSugg.Location = new System.Drawing.Point(748, 40);
            this.lbSugg.Name = "lbSugg";
            this.lbSugg.Size = new System.Drawing.Size(140, 130);
            this.lbSugg.TabIndex = 3;
            this.lbSugg.Visible = false;
            this.lbSugg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSugg_KeyDown);
            this.lbSugg.Leave += new System.EventHandler(this.lbSugg_Leave);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabMessage;
            this.xtraTabControl1.Size = new System.Drawing.Size(919, 212);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabMiddleClickFiringMode = DevExpress.XtraTab.TabMiddleClickFiringMode.MouseUp;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabMessage});
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            // 
            // tabMessage
            // 
            this.tabMessage.Controls.Add(this.txtResult);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Size = new System.Drawing.Size(912, 177);
            this.tabMessage.Text = "მესიჯები";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lbSugg);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtScript);
            this.splitContainerControl1.Panel1.Controls.Add(this.fpa1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(919, 653);
            this.splitContainerControl1.SplitterPosition = 435;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.treeView);
            this.splitContainerControl2.Panel1.Controls.Add(this.propertyGrid);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1233, 653);
            this.splitContainerControl2.SplitterPosition = 308;
            this.splitContainerControl2.TabIndex = 6;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(308, 495);
            this.treeView.TabIndex = 4;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGrid.Location = new System.Drawing.Point(0, 495);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(308, 158);
            this.propertyGrid.TabIndex = 4;
            // 
            // SQLExecute
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 653);
            this.Controls.Add(this.splitContainerControl2);
            this.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SQLExecute";
            this.Text = "FMG Management";
            this.Load += new System.EventHandler(this.SQLExecute_Load);
            this.fpa1.ResumeLayout(false);
            this.fpa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbSyntax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl txtScript;
        private DevExpress.XtraRichEdit.RichEditControl txtResult;
        private System.Windows.Forms.FlowLayoutPanel fpa1;
        private DevExpress.XtraEditors.SimpleButton btnExecute;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabMessage;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadStruct;
        private System.Windows.Forms.ListBox lbSugg;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGrid;
        private DevExpress.XtraEditors.CheckEdit chbSyntax;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnSetText;
    }
}