namespace Demo.GroupData
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.Versioning;
    using System.Windows.Forms;

    using Demo.GroupData.Models;

    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraLayout.Customization;

    public partial class GroupDataForm : Form
    {
        public GroupDataForm()
        {
            this.InitializeComponent();
            this.listOfGroup1 = new BindingList<DataItemModel>();
            this.listOfGroup2 = new BindingList<DataItemModel>();
            this.LoadData();
            this.sizeGroupControl1 = this.lciGroup1.Size;
            this.sizeGroupControl2 = this.lciGroup2.Size;
        }

        private readonly BindingList<DataItemModel> listOfGroup1;
        private readonly BindingList<DataItemModel> listOfGroup2;
        private readonly Size sizeGroupControl1;
        private readonly Size sizeGroupControl2;
        private void LoadData()
        {
            this.listOfGroup1.Clear();
            this.listOfGroup2.Clear();
            // create data Group 1
            this.listOfGroup1.Add(new DataItemModel("Name", "Mustermann", "Mustermau", true));
            this.listOfGroup1.Add(new DataItemModel("Vorname", "Max", "Maxt", true));
            this.listOfGroup1.Add(new DataItemModel("Strasse", "Bei Bahnhof", "Bei Aldi", false));
            this.listOfGroup1.Add(new DataItemModel("Ptz", "5000", "5100", false));
            this.listOfGroup1.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));

            // create data Group 2
            this.listOfGroup2.Add(new DataItemModel("1", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5100 Aarau\n +AHV", false, true));
            this.listOfGroup2.Add(new DataItemModel("2", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));
            this.listOfGroup2.Add(new DataItemModel("3", "Bmeise", "Bmeise", true));
            this.listOfGroup2.Add(new DataItemModel("4", "Cmeise", string.Empty, true));
            this.listOfGroup2.Add(new DataItemModel("5", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));
            this.listOfGroup2.Add(new DataItemModel("6", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));
            this.listOfGroup2.Add(new DataItemModel("7", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));

            // binding data to GridContrl
            this.gridControl1.DataSource = this.listOfGroup1;
            this.gridControl1.Refresh();
            this.gridControl2.DataSource = this.listOfGroup2;
            this.gridControl2.Refresh();
        }

        #region Event Group 1
        private void check_all_older_group1_CheckStateChanged(object sender, EventArgs e)
        {
            this.check_all_new_group1.Checked = !this.check_all_older_group1.Checked;
            this.ReloadDataGroup1(this.check_all_older_group1.Checked);
        }

        private void check_all_new_group1_CheckStateChanged(object sender, EventArgs e)
        {
            this.check_all_older_group1.Checked = !this.check_all_new_group1.Checked;
            this.ReloadDataGroup1(this.check_all_older_group1.Checked);
        }

        private void ReloadDataGroup1(bool useOlder)
        {
            foreach (var item in this.listOfGroup1)
            {
                item.UseOlder = useOlder;
            }
            this.gridView1.RefreshData();
        }

        private void gridView1_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            var dataRow = this.gridView1.GetRow(e.RowHandle);
            if (dataRow != null){
                var item = (DataItemModel)this.gridView1.GetRow(e.RowHandle);
                if (item.Show)
                    e.RowHeight = 15 * item.Height;
                else e.RowHeight = 15;
            }
            else e.RowHeight = 15;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.showGroup1 = !this.showGroup1;
            if (this.showGroup1)
            {
                var dragControlGroup1 = new LayoutItemDragController(
                    this.lciGroup1,
                    this.lciHeader1,
                    DevExpress.XtraLayout.Utils.InsertLocation.After,
                     DevExpress.XtraLayout.Utils.LayoutType.Vertical);
                this.lciGroup1.RestoreFromCustomization(dragControlGroup1);
                this.lciGroup1.Size = this.sizeGroupControl1;
                this.simpleButton1.ImageIndex = 0;
            }
            else
            {
                this.lciGroup1.HideToCustomization();
                this.simpleButton1.ImageIndex = 1;
            }
        }

        private bool showGroup1 = true;

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
        #endregion
        private void btn_Save_Click(object sender, EventArgs e)
        {
            var log = "Data changed : \n";
            foreach (var item in this.listOfGroup1.Where(k => k.IsChange))
            {
                log += string.Format("{0} : {1} \n", item.NameColumn, item.UseOlder ? item.DataOlder : item.DataNew);
            }
            foreach (var item in this.listOfGroup2.Where(k => k.IsChange))
            {
                log += string.Format("{0} : {1} \n", item.NameColumn, item.UseOlder ? item.DataOlder : item.DataNew);
            }
            MessageBox.Show(log, string.Empty, MessageBoxButtons.OK);
        }

        #region Event Group 2
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.showGroup2 = !this.showGroup2;
            if (this.showGroup2)
            {
                var dragControlGroup2 = new LayoutItemDragController(
                    this.lciGroup2,
                    this.lciHeader2,
                    DevExpress.XtraLayout.Utils.InsertLocation.After,
                     DevExpress.XtraLayout.Utils.LayoutType.Vertical);
                this.lciGroup2.RestoreFromCustomization(dragControlGroup2);
                this.lciGroup1.Size = this.sizeGroupControl2;
                this.simpleButton2.ImageIndex = 0;
            }
            else
            {
                this.lciGroup2.HideToCustomization();
                this.simpleButton2.ImageIndex = 1;
            }
        }
        private bool showGroup2 = true;

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (this.gridView2.GetRow(e.RowHandle) != null)
            {
                var item = (DataItemModel)this.gridView2.GetRow(e.RowHandle);
                if (e.Column == this.gridView2.Columns["UseOlder"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;
                    if (value != null)
                    {
                        item.UseOlder = value.Value;
                        this.gridView2.SetRowCellValue(e.RowHandle, this.gridView2.Columns["UseNew"], !value.Value);
                    }
                }
                if (e.Column == this.gridView2.Columns["UseNew"])
                {
                    var value = e.Value is bool ? (bool?)e.Value : null;
                    if (value != null)
                    {
                        item.UseNew = value.Value;
                        this.gridView2.SetRowCellValue(e.RowHandle, this.gridView2.Columns["UseOlder"], !value.Value);
                    }
                }
            }
        }
        private void gridView2_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            var dataRow = gridView2.GetRow(e.RowHandle);
            if (dataRow != null)
            {
                var item = (DataItemModel)this.gridView2.GetRow(e.RowHandle);
                if (item.Show)
                {
                    e.RowHeight = 15 * item.Height;
                }
                else
                {
                    e.RowHeight = 15;
                }
            }
            else e.RowHeight = 15;
        }

        private void check_all_new_group2_CheckStateChanged(object sender, EventArgs e)
        {
            this.check_all_older_group2.Checked = !this.check_all_new_group2.Checked;
            this.ReloadDataGroup2(this.check_all_older_group2.Checked);
        }

        private void check_all_older_group2_CheckStateChanged(object sender, EventArgs e)
        {
            this.check_all_new_group2.Checked = !this.check_all_older_group2.Checked;
            this.ReloadDataGroup2(this.check_all_older_group2.Checked);
        }
        private void ReloadDataGroup2(bool useOlder)
        {
            foreach (var item in this.listOfGroup2)
            {
                item.UseOlder = useOlder;
            }
            this.gridView2.RefreshData();
        }
        #endregion

        private void buttonExpanRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = this.gridView2.GetFocusedRow();
            if (row != null)
            {
                var item = (DataItemModel)row;
                item.Show = !item.Show;
                this.gridView2.RefreshData();
                //if (item.Show)
                //    e.Button.Image = new Bitmap(Resources.up16);
                //else
                //    e.Button.Image = new Bitmap(Resources.down16);
            }
        }
    }
}
