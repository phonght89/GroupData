using System;
using System.Linq;
using Demo.GroupData.Properties;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace Demo.GroupData.Controls
{
    using System.Drawing;
    using System.Windows.Forms;

    using Demo.GroupData.Models;

    using DevExpress.XtraGrid.Views.Grid.ViewInfo;
    using DevExpress.XtraLayout.Customization;

    public partial class GroupDataExpandRowControl : UserControl
    {
        public GroupDataExpandRowControl()
        {
            this.InitializeComponent();
        }
        public GroupDataExpandRowControl(GroupItemModelBase data, string headerText)
        {
            this.InitializeComponent();
            this.dataItem = data;
            this.headerText = headerText;
            this.LoadData();
        }
        private void LoadData()
        {
            labelControl1.Text = headerText;
            labelControl2.Text = headerText;
            this.gridControl1.DataSource = this.dataItem.Items.OfType<DataItemViewModelBase>().OrderBy(k => k.Sort).ThenBy(k => k.SortName);
            this.gridControl1.Refresh();
        }

        private void gridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.ReSizeGridByData();
        }

        private void ReSizeGridByData()
        {
            this.gridControl1.Height = this.GetInvisibleRowsHeight();
            this.gridView1.LayoutChanged();
            this.height = this.gridControl1.Height + 46;this.Height = this.height;
        }

        private int GetInvisibleRowsHeight()
        {
            GridViewInfo viewInfo = (GridViewInfo)this.gridView1.GetViewInfo();
            int gridHeight = viewInfo.CalcRealViewHeight(new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Width));
            return gridHeight;
        }

        private GroupItemModelBase DataItem
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
        private GroupItemModelBase dataItem;
        private string headerText;

        private int height;
        private bool showGroup = true;

        private void btExpand_Click(object sender, System.EventArgs e)
        {
            this.showGroup = !this.showGroup;
            if (this.showGroup)
            {
                //ReSizeGridByData();
                this.Height = this.height;
                this.btExpand.ImageIndex = 0;
            }
            else
            {
                this.Height = 47;
                this.btExpand.ImageIndex = 1;
            }
        }

        private void check_all_older_group1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.check_all_older_group.Checked)
            {
                this.check_all_new_group.Checked = !this.check_all_older_group.Checked;
                this.ReloadDataGrid(this.check_all_older_group.Checked);
            }
        }
        private void check_all_new_group1_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (this.check_all_new_group.Checked)
            {
                this.check_all_older_group.Checked = !this.check_all_new_group.Checked;
                this.ReloadDataGrid(this.check_all_older_group.Checked);
            }
        }

        private void ReloadDataGrid(bool useOlder)
        {
            foreach (var item in this.DataItem.Items.Cast<DataItemViewModelBase>())
            {
                //if (item.UseOlder != useOlder)
                item.UseOlder = useOlder;
            }
            this.gridView1.RefreshData();
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var dataRow = this.gridView1.GetRow(e.RowHandle);
            if (dataRow != null)
            {
                var item = (DataItemViewModelBase)dataRow;
                if (e.Column == this.gridView1.Columns["UseOlder"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;
                    if (value != null)
                    {
                        item.UseOlder = value.Value;
                        this.gridView1.RefreshRow(e.RowHandle);
                        this.UpdateCheckAll();
                    }
                }
                if (e.Column == this.gridView1.Columns["UseNew"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;
                    if (value != null)
                    {
                        item.UseNew = value.Value;
                        this.gridView1.RefreshRow(e.RowHandle);
                        this.UpdateCheckAll();
                    }
                }
            }
        }

        private void btnExpandRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = this.gridView1.GetFocusedRow();
            if (row != null)
            {
                var item = (DataItemViewModelBase)row;
                item.Show = true;
                this.gridView1.RefreshData();
                this.gridView1.LayoutChanged();
                ReSizeGridByData();
            }
        }

        private void btnShrinkRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = this.gridView1.GetFocusedRow();
            if (row != null)
            {
                var item = (DataItemViewModelBase)row;
                item.Show = false;
                this.gridView1.RefreshData();
                this.gridView1.LayoutChanged();
                ReSizeGridByData();
            }
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.Name == "colExpand" && e.RowHandle >= 0)
            {
                GridView gv = sender as GridView;
                var item = (DataItemViewModelBase)gv.GetRow(e.RowHandle);
                if (item.Show)
                {
                    e.RepositoryItem = this.btnShrinkRow;
                }
                else
                {
                    e.RepositoryItem = this.btnExpandRow;
                }
            }
        }
        private void gridView1_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var gr = sender as GridView;
            if (gr.FocusedRowHandle != (int.MinValue + 1))
            {
                var dataViewModel = (DataItemViewModelBase)gridView1.GetRow(gridView1.FocusedRowHandle);
                if (this.gridView1.FocusedColumn.FieldName == "UseOlder")
                {
                    e.Cancel = string.IsNullOrEmpty(dataViewModel.DataNew);
                }
                if (this.gridView1.FocusedColumn.FieldName == "UseNew")
                {
                    e.Cancel = string.IsNullOrEmpty(dataViewModel.DataNew);
                }
            }
        }

        private void UpdateCheckAll()
        {
            if (this.check_all_older_group.Checked)
            {
                if (this.dataItem.Items.Cast<DataItemViewModelBase>().Any(k => k.UseNew))
                    this.check_all_older_group.CheckState = CheckState.Unchecked;
            }
            else
            {
                if (this.dataItem.Items.Cast<DataItemViewModelBase>().All(k => k.UseOlder))
                    this.check_all_older_group.CheckState = CheckState.Checked;
            }

            if (this.check_all_new_group.Checked)
            {
                if (this.dataItem.Items.Cast<DataItemViewModelBase>().Where(k => !string.IsNullOrWhiteSpace(k.DataNew)).Any(k => k.UseOlder))
                    this.check_all_new_group.CheckState = CheckState.Unchecked;
            }
            else
            {
                if (this.dataItem.Items.Cast<DataItemViewModelBase>().Where(k => !string.IsNullOrWhiteSpace(k.DataNew)).All(k => k.UseNew))
                    this.check_all_new_group.CheckState = CheckState.Checked;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var row = this.gridView1.GetFocusedRow();
            if (row != null)
            {
                var item = (DataItemViewModelBase)row;
                var listDataOlder = item.ListModelOlder;
                var listDataNew = item.ListModelNew;
            }
        }
    }
}

