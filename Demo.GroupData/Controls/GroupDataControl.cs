using System;
using System.Linq;

namespace Demo.GroupData.Controls
{
    using System.Drawing;
    using System.Windows.Forms;

    using Demo.GroupData.Models;

    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid.Views.Grid.ViewInfo;
    using DevExpress.XtraLayout.Customization;

    public partial class GroupDataControl : UserControl
    {
        public GroupDataControl()
        {
            this.InitializeComponent();
            //this.gridView1.row
        }
        public GroupDataControl(GroupItemModelBase data)
        {
            this.InitializeComponent();
            this.dataItem = data;
            this.LoadData();
        }

        private void LoadData()
        {
            this.gridControl1.DataSource = this.dataItem.Items;
            this.gridControl1.Refresh();
        }

        private void gridView1_DataSourceChanged(object sender, EventArgs e)
        {
            this.ReSizeGridByData();
        }

        private void ReSizeGridByData()
        {
            this.gridControl1.Height = this.GetInvisibleRowsHeight();
            this.height = this.gridControl1.Height + 46;
            this.Height = this.height;
        }

        private int GetInvisibleRowsHeight()
        {
            GridViewInfo viewInfo = (GridViewInfo)this.gridView1.GetViewInfo();
            int gridHeight = viewInfo.CalcRealViewHeight(new Rectangle(0, 0, int.MaxValue, int.MaxValue));
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

        private int height;
        private bool showGroup = true;

        private void btExpand_Click(object sender, EventArgs e)
        {
            this.showGroup = !this.showGroup;
            if (this.showGroup)
            {
                this.Height = this.height;
                this.btExpand.ImageIndex = 0;
            }
            else
            {
                this.Height = 47;
                this.btExpand.ImageIndex = 1;
            }
        }

        private void check_all_older_group1_CheckedChanged(object sender, EventArgs e)
        {
            this.check_all_new_group.Checked = !this.check_all_older_group.Checked;
            this.ReloadDataGrid(this.check_all_older_group.Checked);
        }
        private void check_all_new_group1_CheckStateChanged(object sender, EventArgs e)
        {
            this.check_all_older_group.Checked = !this.check_all_new_group.Checked;
            this.ReloadDataGrid(this.check_all_older_group.Checked);
        }

        private void ReloadDataGrid(bool useOlder)
        {
            foreach (var item in this.DataItem.Items.Cast<DataItemViewModelBase>())
            {
                if (useOlder)
                {
                    if (!string.IsNullOrWhiteSpace(item.DataOlder))
                        item.UseOlder = true;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(item.DataNew))
                        item.UseNew = true;
                }
            }
            this.gridView1.RefreshData();
        }

        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (this.gridView1.GetRow(e.RowHandle) != null)
            {
                var item = (DataItemViewModelBase)this.gridView1.GetRow(e.RowHandle);
                if (e.Column == this.gridView1.Columns["UseOlder"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;
                    if (value != null)
                    {
                        item.UseOlder = value.Value;
                        this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseNew"], !value.Value);
                        //this.gridView1.SelectRow(e.RowHandle);
                        //if (value.Value)
                        //{
                        //    this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseNew"], false);
                        //}
                        //else
                        //{
                        //    this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseNew"],
                        //        !string.IsNullOrWhiteSpace(item.DataNew));
                        //}
                    }
                }
                if (e.Column == this.gridView1.Columns["UseNew"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;

                    if (value != null)
                    {
                        item.UseNew = value.Value;
                        this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseOlder"], !value.Value);
                        //this.gridView1.SelectRow(e.RowHandle);
                        //if (value.Value)
                        //{
                        //    this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseOlder"], false);
                        //}
                        //else
                        //{
                        //    this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["UseOlder"],
                        //        !string.IsNullOrWhiteSpace(item.DataOlder));
                        //}
                    }
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
                    e.Cancel = string.IsNullOrEmpty(dataViewModel.DataOlder);
                }
                if (this.gridView1.FocusedColumn.FieldName == "UseNew")
                {
                    e.Cancel = string.IsNullOrEmpty(dataViewModel.DataNew);
                }
            }
        }
    }
}
