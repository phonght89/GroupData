namespace Demo.GroupData.Controls
{
    partial class GroupDataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupDataControl));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelHeader = new DevExpress.XtraEditors.PanelControl();
            this.panel_checkNew = new DevExpress.XtraEditors.PanelControl();
            this.check_all_new_group = new DevExpress.XtraEditors.CheckEdit();
            this.panel_checkOlder = new DevExpress.XtraEditors.PanelControl();
            this.check_all_older_group = new DevExpress.XtraEditors.CheckEdit();
            this.panel_dataNew = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelExpand = new DevExpress.XtraEditors.PanelControl();
            this.btExpand = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.panel_dataOlder = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataOlder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtItemGrid = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.colUseOlder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkItemGrid = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colUseNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lci_Main = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_Grid = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciHeader = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_checkNew)).BeginInit();
            this.panel_checkNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_all_new_group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_checkOlder)).BeginInit();
            this.panel_checkOlder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_all_older_group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dataNew)).BeginInit();
            this.panel_dataNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelExpand)).BeginInit();
            this.panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dataOlder)).BeginInit();
            this.panel_dataOlder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.SystemColors.Control;
            this.layoutControl1.Controls.Add(this.panelHeader);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(465, 21, 250, 350);
            this.layoutControl1.Root = this.lci_Main;
            this.layoutControl1.Size = new System.Drawing.Size(1068, 248);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panel_checkNew);
            this.panelHeader.Controls.Add(this.panel_checkOlder);
            this.panelHeader.Controls.Add(this.panel_dataNew);
            this.panelHeader.Controls.Add(this.panelExpand);
            this.panelHeader.Controls.Add(this.panel_dataOlder);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1068, 36);
            this.panelHeader.TabIndex = 1;
            // 
            // panel_checkNew
            // 
            this.panel_checkNew.Controls.Add(this.check_all_new_group);
            this.panel_checkNew.Location = new System.Drawing.Point(600, -2);
            this.panel_checkNew.Name = "panel_checkNew";
            this.panel_checkNew.Size = new System.Drawing.Size(100, 40);
            this.panel_checkNew.TabIndex = 2;
            // 
            // check_all_new_group
            // 
            this.check_all_new_group.Location = new System.Drawing.Point(31, 9);
            this.check_all_new_group.Name = "check_all_new_group";
            this.check_all_new_group.Properties.Caption = "Alle";
            this.check_all_new_group.Size = new System.Drawing.Size(41, 19);
            this.check_all_new_group.TabIndex = 1;
            this.check_all_new_group.CheckStateChanged += new System.EventHandler(this.check_all_new_group1_CheckStateChanged);
            // 
            // panel_checkOlder
            // 
            this.panel_checkOlder.Controls.Add(this.check_all_older_group);
            this.panel_checkOlder.Location = new System.Drawing.Point(500, -2);
            this.panel_checkOlder.Name = "panel_checkOlder";
            this.panel_checkOlder.Size = new System.Drawing.Size(100, 40);
            this.panel_checkOlder.TabIndex = 3;
            // 
            // check_all_older_group
            // 
            this.check_all_older_group.Location = new System.Drawing.Point(30, 9);
            this.check_all_older_group.Name = "check_all_older_group";
            this.check_all_older_group.Properties.Caption = "Alle";
            this.check_all_older_group.Size = new System.Drawing.Size(51, 19);
            this.check_all_older_group.TabIndex = 0;
            this.check_all_older_group.CheckedChanged += new System.EventHandler(this.check_all_older_group1_CheckedChanged);
            // 
            // panel_dataNew
            // 
            this.panel_dataNew.Controls.Add(this.labelControl2);
            this.panel_dataNew.Location = new System.Drawing.Point(700, -2);
            this.panel_dataNew.Name = "panel_dataNew";
            this.panel_dataNew.Size = new System.Drawing.Size(370, 40);
            this.panel_dataNew.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(155, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Klient-/n";
            // 
            // panelExpand
            // 
            this.panelExpand.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.panelExpand.Appearance.Options.UseBackColor = true;
            this.panelExpand.Controls.Add(this.btExpand);
            this.panelExpand.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelExpand.Location = new System.Drawing.Point(0, -2);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(130, 40);
            this.panelExpand.TabIndex = 0;
            // 
            // btExpand
            // 
            this.btExpand.Appearance.ForeColor = System.Drawing.Color.White;
            this.btExpand.Appearance.Options.UseForeColor = true;
            this.btExpand.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btExpand.ImageIndex = 0;
            this.btExpand.ImageList = this.imageCollection1;
            this.btExpand.Location = new System.Drawing.Point(5, 9);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(24, 24);
            this.btExpand.TabIndex = 0;
            this.btExpand.Click += new System.EventHandler(this.btExpand_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertImage(global::Demo.GroupData.Properties.Resources.up, "up", typeof(global::Demo.GroupData.Properties.Resources), 0);
            this.imageCollection1.Images.SetKeyName(0, "up");
            this.imageCollection1.InsertImage(global::Demo.GroupData.Properties.Resources.down, "down", typeof(global::Demo.GroupData.Properties.Resources), 1);
            this.imageCollection1.Images.SetKeyName(1, "down");
            this.imageCollection1.InsertImage(global::Demo.GroupData.Properties.Resources.down16, "down16", typeof(global::Demo.GroupData.Properties.Resources), 2);
            this.imageCollection1.Images.SetKeyName(2, "down16");
            this.imageCollection1.InsertImage(global::Demo.GroupData.Properties.Resources.up16, "up16", typeof(global::Demo.GroupData.Properties.Resources), 3);
            this.imageCollection1.Images.SetKeyName(3, "up16");
            // 
            // panel_dataOlder
            // 
            this.panel_dataOlder.Controls.Add(this.labelControl1);
            this.panel_dataOlder.Location = new System.Drawing.Point(130, -2);
            this.panel_dataOlder.Name = "panel_dataOlder";
            this.panel_dataOlder.Size = new System.Drawing.Size(370, 40);
            this.panel_dataOlder.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(147, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Klient-/n";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkItemGrid,
            this.rtItemGrid});
            this.gridControl1.Size = new System.Drawing.Size(1068, 212);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDataOlder,
            this.colUseOlder,
            this.colUseNew,
            this.colDataNew});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "NameColumn";
            this.colName.MaxWidth = 130;
            this.colName.MinWidth = 130;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 130;
            // 
            // colDataOlder
            // 
            this.colDataOlder.Caption = "DataOlder";
            this.colDataOlder.ColumnEdit = this.rtItemGrid;
            this.colDataOlder.FieldName = "DataOlder";
            this.colDataOlder.MaxWidth = 370;
            this.colDataOlder.MinWidth = 370;
            this.colDataOlder.Name = "colDataOlder";
            this.colDataOlder.OptionsColumn.AllowEdit = false;
            this.colDataOlder.Visible = true;
            this.colDataOlder.VisibleIndex = 1;
            this.colDataOlder.Width = 370;
            // 
            // rtItemGrid
            // 
            this.rtItemGrid.Name = "rtItemGrid";
            this.rtItemGrid.ShowCaretInReadOnly = false;
            // 
            // colUseOlder
            // 
            this.colUseOlder.Caption = "UseOlder";
            this.colUseOlder.ColumnEdit = this.checkItemGrid;
            this.colUseOlder.FieldName = "UseOlder";
            this.colUseOlder.MaxWidth = 100;
            this.colUseOlder.MinWidth = 100;
            this.colUseOlder.Name = "colUseOlder";
            this.colUseOlder.Visible = true;
            this.colUseOlder.VisibleIndex = 2;
            this.colUseOlder.Width = 100;
            // 
            // checkItemGrid
            // 
            this.checkItemGrid.AutoHeight = false;
            this.checkItemGrid.Caption = "Check";
            this.checkItemGrid.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkItemGrid.Name = "checkItemGrid";
            // 
            // colUseNew
            // 
            this.colUseNew.Caption = "UseNew";
            this.colUseNew.ColumnEdit = this.checkItemGrid;
            this.colUseNew.FieldName = "UseNew";
            this.colUseNew.MaxWidth = 100;
            this.colUseNew.MinWidth = 100;
            this.colUseNew.Name = "colUseNew";
            this.colUseNew.Visible = true;
            this.colUseNew.VisibleIndex = 3;
            this.colUseNew.Width = 100;
            // 
            // colDataNew
            // 
            this.colDataNew.Caption = "DataNew";
            this.colDataNew.ColumnEdit = this.rtItemGrid;
            this.colDataNew.FieldName = "DataNew";
            this.colDataNew.MinWidth = 300;
            this.colDataNew.Name = "colDataNew";
            this.colDataNew.OptionsColumn.AllowEdit = false;
            this.colDataNew.Visible = true;
            this.colDataNew.VisibleIndex = 4;
            this.colDataNew.Width = 370;
            // 
            // lci_Main
            // 
            this.lci_Main.CustomizationFormText = "lci_Main";
            this.lci_Main.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lci_Main.GroupBordersVisible = false;
            this.lci_Main.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_Grid,
            this.lciHeader});
            this.lci_Main.Location = new System.Drawing.Point(0, 0);
            this.lci_Main.Name = "lci_Main";
            this.lci_Main.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lci_Main.Size = new System.Drawing.Size(1068, 248);
            this.lci_Main.Text = "lci_Main";
            this.lci_Main.TextVisible = false;
            // 
            // lci_Grid
            // 
            this.lci_Grid.Control = this.gridControl1;
            this.lci_Grid.CustomizationFormText = "lci_Grid";
            this.lci_Grid.Location = new System.Drawing.Point(0, 36);
            this.lci_Grid.Name = "lci_Grid";
            this.lci_Grid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lci_Grid.Size = new System.Drawing.Size(1068, 212);
            this.lci_Grid.Text = "lci_Grid";
            this.lci_Grid.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Grid.TextToControlDistance = 0;
            this.lci_Grid.TextVisible = false;
            // 
            // lciHeader
            // 
            this.lciHeader.Control = this.panelHeader;
            this.lciHeader.CustomizationFormText = "lciHeader";
            this.lciHeader.Location = new System.Drawing.Point(0, 0);
            this.lciHeader.Name = "lciHeader";
            this.lciHeader.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciHeader.Size = new System.Drawing.Size(1068, 36);
            this.lciHeader.Text = "lciHeader";
            this.lciHeader.TextSize = new System.Drawing.Size(0, 0);
            this.lciHeader.TextToControlDistance = 0;
            this.lciHeader.TextVisible = false;
            // 
            // GroupDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.layoutControl1);
            this.Name = "GroupDataControl";
            this.Size = new System.Drawing.Size(1068, 248);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_checkNew)).EndInit();
            this.panel_checkNew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_all_new_group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_checkOlder)).EndInit();
            this.panel_checkOlder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_all_older_group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dataNew)).EndInit();
            this.panel_dataNew.ResumeLayout(false);
            this.panel_dataNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelExpand)).EndInit();
            this.panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_dataOlder)).EndInit();
            this.panel_dataOlder.ResumeLayout(false);
            this.panel_dataOlder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup lci_Main;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDataOlder;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit rtItemGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colUseOlder;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkItemGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colUseNew;
        private DevExpress.XtraGrid.Columns.GridColumn colDataNew;
        private DevExpress.XtraLayout.LayoutControlItem lci_Grid;
        private DevExpress.XtraEditors.PanelControl panel_checkNew;
        private DevExpress.XtraEditors.CheckEdit check_all_new_group;
        private DevExpress.XtraEditors.PanelControl panel_checkOlder;
        private DevExpress.XtraEditors.CheckEdit check_all_older_group;
        private DevExpress.XtraEditors.PanelControl panel_dataNew;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panel_dataOlder;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelExpand;
        private DevExpress.XtraEditors.SimpleButton btExpand;
        private DevExpress.XtraEditors.PanelControl panelHeader;
        private DevExpress.XtraLayout.LayoutControlItem lciHeader;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}
