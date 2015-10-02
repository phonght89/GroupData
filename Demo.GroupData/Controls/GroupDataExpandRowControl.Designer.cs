using System.Windows.Forms;

namespace Demo.GroupData.Controls
{
    partial class GroupDataExpandRowControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupDataExpandRowControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel_dataNew = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel_checkNew = new System.Windows.Forms.Panel();
            this.check_all_new_group = new DevExpress.XtraEditors.CheckEdit();
            this.panel_checkOlder = new System.Windows.Forms.Panel();
            this.check_all_older_group = new DevExpress.XtraEditors.CheckEdit();
            this.panelExpand = new System.Windows.Forms.Panel();
            this.btExpand = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.panel_dataOlder = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExpand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataOlder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtItemGrid = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.colUseOlder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkItemGrid = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colUseNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExpandRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnShrinkRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelHeader.SuspendLayout();
            this.panel_dataNew.SuspendLayout();
            this.panel_checkNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_all_new_group.Properties)).BeginInit();
            this.panel_checkOlder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_all_older_group.Properties)).BeginInit();
            this.panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.panel_dataOlder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShrinkRow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.panel_dataNew);
            this.panelHeader.Controls.Add(this.panel_checkNew);
            this.panelHeader.Controls.Add(this.panel_checkOlder);
            this.panelHeader.Controls.Add(this.panelExpand);
            this.panelHeader.Controls.Add(this.panel_dataOlder);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.MaximumSize = new System.Drawing.Size(1070, 47);
            this.panelHeader.MinimumSize = new System.Drawing.Size(1070, 47);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1070, 47);
            this.panelHeader.TabIndex = 0;
            // 
            // panel_dataNew
            // 
            this.panel_dataNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_dataNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_dataNew.Controls.Add(this.labelControl2);
            this.panel_dataNew.Location = new System.Drawing.Point(699, -1);
            this.panel_dataNew.MaximumSize = new System.Drawing.Size(370, 49);
            this.panel_dataNew.MinimumSize = new System.Drawing.Size(370, 49);
            this.panel_dataNew.Name = "panel_dataNew";
            this.panel_dataNew.Size = new System.Drawing.Size(370, 49);
            this.panel_dataNew.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(167, 14);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Klient-/n";
            // 
            // panel_checkNew
            // 
            this.panel_checkNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_checkNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_checkNew.Controls.Add(this.check_all_new_group);
            this.panel_checkNew.Location = new System.Drawing.Point(599, -1);
            this.panel_checkNew.MaximumSize = new System.Drawing.Size(101, 49);
            this.panel_checkNew.MinimumSize = new System.Drawing.Size(101, 49);
            this.panel_checkNew.Name = "panel_checkNew";
            this.panel_checkNew.Size = new System.Drawing.Size(101, 49);
            this.panel_checkNew.TabIndex = 8;
            // 
            // check_all_new_group
            // 
            this.check_all_new_group.Location = new System.Drawing.Point(27, 12);
            this.check_all_new_group.Margin = new System.Windows.Forms.Padding(4);
            this.check_all_new_group.Name = "check_all_new_group";
            this.check_all_new_group.Properties.Caption = "Alle";
            this.check_all_new_group.Size = new System.Drawing.Size(55, 19);
            this.check_all_new_group.TabIndex = 1;
            this.check_all_new_group.CheckStateChanged += new System.EventHandler(this.check_all_new_group1_CheckStateChanged);
            // 
            // panel_checkOlder
            // 
            this.panel_checkOlder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_checkOlder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_checkOlder.Controls.Add(this.check_all_older_group);
            this.panel_checkOlder.Location = new System.Drawing.Point(499, -1);
            this.panel_checkOlder.MaximumSize = new System.Drawing.Size(101, 49);
            this.panel_checkOlder.MinimumSize = new System.Drawing.Size(101, 49);
            this.panel_checkOlder.Name = "panel_checkOlder";
            this.panel_checkOlder.Size = new System.Drawing.Size(101, 49);
            this.panel_checkOlder.TabIndex = 7;
            // 
            // check_all_older_group
            // 
            this.check_all_older_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.check_all_older_group.Location = new System.Drawing.Point(24, 12);
            this.check_all_older_group.Margin = new System.Windows.Forms.Padding(4);
            this.check_all_older_group.Name = "check_all_older_group";
            this.check_all_older_group.Properties.Caption = "Alle";
            this.check_all_older_group.Size = new System.Drawing.Size(52, 19);
            this.check_all_older_group.TabIndex = 0;
            this.check_all_older_group.CheckedChanged += new System.EventHandler(this.check_all_older_group1_CheckedChanged);
            // 
            // panelExpand
            // 
            this.panelExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelExpand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpand.Controls.Add(this.btExpand);
            this.panelExpand.Location = new System.Drawing.Point(-1, -1);
            this.panelExpand.MaximumSize = new System.Drawing.Size(131, 49);
            this.panelExpand.MinimumSize = new System.Drawing.Size(131, 49);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(131, 49);
            this.panelExpand.TabIndex = 2;
            // 
            // btExpand
            // 
            this.btExpand.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btExpand.Appearance.ForeColor = System.Drawing.Color.White;
            this.btExpand.Appearance.Options.UseBackColor = true;
            this.btExpand.Appearance.Options.UseForeColor = true;
            this.btExpand.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btExpand.ImageIndex = 0;
            this.btExpand.ImageList = this.imageCollection1;
            this.btExpand.Location = new System.Drawing.Point(4, 7);
            this.btExpand.Margin = new System.Windows.Forms.Padding(4);
            this.btExpand.Name = "btExpand";
            this.btExpand.Size = new System.Drawing.Size(32, 30);
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
            this.panel_dataOlder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_dataOlder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_dataOlder.Controls.Add(this.labelControl1);
            this.panel_dataOlder.Location = new System.Drawing.Point(129, -1);
            this.panel_dataOlder.MaximumSize = new System.Drawing.Size(371, 49);
            this.panel_dataOlder.MinimumSize = new System.Drawing.Size(371, 49);
            this.panel_dataOlder.Name = "panel_dataOlder";
            this.panel_dataOlder.Size = new System.Drawing.Size(371, 49);
            this.panel_dataOlder.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(163, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Klient-/n";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkItemGrid,
            this.rtItemGrid,
            this.btnExpandRow,
            this.btnShrinkRow});
            this.gridControl1.Size = new System.Drawing.Size(1070, 258);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExpand,
            this.colName,
            this.colDataOlder,
            this.colUseOlder,
            this.colUseNew,
            this.colDataNew});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.DataSourceChanged += new System.EventHandler(this.gridView1_DataSourceChanged);
            // 
            // colExpand
            // 
            this.colExpand.Caption = "colExpand1";
            this.colExpand.MaxWidth = 30;
            this.colExpand.MinWidth = 30;
            this.colExpand.Name = "colExpand";
            this.colExpand.Visible = true;
            this.colExpand.VisibleIndex = 0;
            this.colExpand.Width = 30;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "NameColumn";
            this.colName.MaxWidth = 100;
            this.colName.MinWidth = 100;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 100;
            // 
            // colDataOlder
            // 
            this.colDataOlder.Caption = "DataOlder";
            this.colDataOlder.ColumnEdit = this.rtItemGrid;
            this.colDataOlder.FieldName = "DataColumnOlder";
            this.colDataOlder.MaxWidth = 370;
            this.colDataOlder.MinWidth = 370;
            this.colDataOlder.Name = "colDataOlder";
            this.colDataOlder.OptionsColumn.AllowEdit = false;
            this.colDataOlder.Visible = true;
            this.colDataOlder.VisibleIndex = 2;
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
            this.colUseOlder.VisibleIndex = 3;
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
            this.colUseNew.VisibleIndex = 4;
            this.colUseNew.Width = 100;
            // 
            // colDataNew
            // 
            this.colDataNew.Caption = "DataNew";
            this.colDataNew.ColumnEdit = this.rtItemGrid;
            this.colDataNew.FieldName = "DataColumnNew";
            this.colDataNew.MaxWidth = 368;
            this.colDataNew.MinWidth = 368;
            this.colDataNew.Name = "colDataNew";
            this.colDataNew.OptionsColumn.AllowEdit = false;
            this.colDataNew.Visible = true;
            this.colDataNew.VisibleIndex = 5;
            this.colDataNew.Width = 368;
            // 
            // btnExpandRow
            // 
            this.btnExpandRow.AutoHeight = false;
            this.btnExpandRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Demo.GroupData.Properties.Resources.down16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnExpandRow.Name = "btnExpandRow";
            this.btnExpandRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnExpandRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnExpandRow_ButtonClick);
            // 
            // btnShrinkRow
            // 
            this.btnShrinkRow.AutoHeight = false;
            this.btnShrinkRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Demo.GroupData.Properties.Resources.up16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnShrinkRow.Name = "btnShrinkRow";
            this.btnShrinkRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnShrinkRow.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnShrinkRow_ButtonClick);
            // 
            // GroupDataExpandRowControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(0, 47);
            this.Name = "GroupDataExpandRowControl";
            this.Size = new System.Drawing.Size(1070, 304);
            this.panelHeader.ResumeLayout(false);
            this.panel_dataNew.ResumeLayout(false);
            this.panel_dataNew.PerformLayout();
            this.panel_checkNew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_all_new_group.Properties)).EndInit();
            this.panel_checkOlder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.check_all_older_group.Properties)).EndInit();
            this.panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.panel_dataOlder.ResumeLayout(false);
            this.panel_dataOlder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShrinkRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDataOlder;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit rtItemGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colUseOlder;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkItemGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colUseNew;
        private DevExpress.XtraGrid.Columns.GridColumn colDataNew;
        private DevExpress.XtraEditors.CheckEdit check_all_new_group;
        private DevExpress.XtraEditors.CheckEdit check_all_older_group;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btExpand;
        private System.Windows.Forms.Panel panelHeader;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.Panel panel_dataOlder;
        private System.Windows.Forms.Panel panelExpand;
        private System.Windows.Forms.Panel panel_checkOlder;
        private System.Windows.Forms.Panel panel_dataNew;
        private System.Windows.Forms.Panel panel_checkNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnExpandRow;
        private DevExpress.XtraGrid.Columns.GridColumn colExpand;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnShrinkRow;
    }
}
