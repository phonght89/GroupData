namespace Demo.GroupData.Controls
{
    using System.Drawing;
    using System.Windows.Forms;

    using Demo.GroupData.Models;

    using DevExpress.XtraLayout.Customization;

    public partial class GroupDataControl : UserControl
    {
        public GroupDataControl(){
            this.InitializeComponent();
        }
        public GroupDataControl(GroupItemModel data)
        {
            this.InitializeComponent();
            this.sizeGrid = this.Size;
            this.dataItem = data;
            this.LoadData();
        }

        private void LoadData()
        {
            this.gridControl1.DataSource = this.dataItem.Items;
            this.gridControl1.Refresh();
        }

        private GroupItemModel DataItem
        {
            get
            {
                return this.dataItem;
            }
            set
            {
                this.dataItem = value;
            }
        }
        private GroupItemModel dataItem;

        private readonly Size sizeGrid;
        private bool showGroup = true;

        private void btExpand_Click(object sender, System.EventArgs e)
        {
            this.showGroup = !this.showGroup;
            if (this.showGroup)
            {
                //var dragControlGroup1 = new LayoutItemDragController(
                //    this.lciGrid,
                //    this.lciHeader,
                //    DevExpress.XtraLayout.Utils.InsertLocation.After,
                //     DevExpress.XtraLayout.Utils.LayoutType.Vertical);
                //this.lciGrid.RestoreFromCustomization(dragControlGroup1);
                //this.lciGrid.Size = this.sizeGrid;
                this.Height = this.sizeGrid.Height;
                this.btExpand.ImageIndex = 0;
            }
            else
            {
                this.Height = 47;
                //this.lciGrid.HideToCustomization();
                this.btExpand.ImageIndex = 1;
            }
        }

        private void check_all_older_group1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.check_all_new_group.Checked = !this.check_all_older_group.Checked;
            this.ReloadDataGrid(this.check_all_older_group.Checked);
        }
        private void check_all_new_group1_CheckStateChanged(object sender, System.EventArgs e)
        {
            this.check_all_older_group.Checked = !this.check_all_new_group.Checked;
            this.ReloadDataGrid(this.check_all_older_group.Checked);
        }

        private void ReloadDataGrid(bool useOlder)
        {
            foreach (var item in this.DataItem.Items)
            {
                item.UseOlder = useOlder;
            }
            this.gridView1.RefreshData();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.gridView1.GetRow(e.RowHandle) != null)
            {
                var item = (DataItemModel)this.gridView1.GetRow(e.RowHandle);
                if (e.Column == this.gridView1.Columns["UseOlder"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;
                    if (value != null)
                    {
                        item.UseOlder = value.Value;
                        this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseNew"], !value.Value);
                    }
                }
                if (e.Column == this.gridView1.Columns["UseNew"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;
                    if (value != null)
                    {
                        item.UseNew = value.Value;
                        this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseOlder"], !value.Value);
                    }
                }
            }
        }
    }
}
