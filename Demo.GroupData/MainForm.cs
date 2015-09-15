namespace Demo.GroupData
{
    using System.ComponentModel;

    using Demo.GroupData.Models;
    using System.Windows.Forms;

    using Demo.GroupData.Controls;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
            this.listGroupData = new BindingList<GroupItemModel>();
            this.xtraScrollableControl1.Width = 1070;
            this.LoadData();
        }

        private readonly BindingList<GroupItemModel> listGroupData;
        private void LoadData()
        {
            this.listGroupData.Clear();
            var groupItem1 = new GroupItemModel("1");
            // create data Group 1
            groupItem1.Items.Add(new DataItemModel("Name", "Mustermann", "Mustermau", true));
            groupItem1.Items.Add(new DataItemModel("Vorname", "Max", "Maxt", true));
            groupItem1.Items.Add(new DataItemModel("Strasse", "Bei Bahnhof", "Bei Aldi", false));
            groupItem1.Items.Add(new DataItemModel("Ptz", "5000", "5100", false));
            groupItem1.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            this.listGroupData.Add(groupItem1);

            var groupItem2 = new GroupItemModel("2");
            // create data Group 1
            groupItem2.Items.Add(new DataItemModel("Name", "Mustermann", "Mustermau", true));
            groupItem2.Items.Add(new DataItemModel("Vorname", "Max", "Maxt", true));
            groupItem2.Items.Add(new DataItemModel("Strasse", "Bei Bahnhof", "Bei Aldi", false));
            groupItem2.Items.Add(new DataItemModel("Ptz", "5000", "5100", false));
            groupItem2.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem2.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            this.listGroupData.Add(groupItem2);

            var groupItem3 = new GroupItemModel("3");
            // create data Group 1
            groupItem3.Items.Add(new DataItemModel("Name", "Mustermann", "Mustermau", true));
            groupItem3.Items.Add(new DataItemModel("Vorname", "Max", "Maxt", true));
            groupItem3.Items.Add(new DataItemModel("Strasse", "Bei Bahnhof", "Bei Aldi", false));
            groupItem3.Items.Add(new DataItemModel("Ptz", "5000", "5100", false));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            groupItem3.Items.Add(new DataItemModel("Ort", "Aurau", "Aurau", true));
            this.listGroupData.Add(groupItem3);

            var groupItem4 = new GroupItemModel("4", true);
            groupItem4.Items.Add(new DataItemModel("1", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5100 Aarau\n +AHV", false, true));
            groupItem4.Items.Add(new DataItemModel("2", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));
            groupItem4.Items.Add(new DataItemModel("3", "Bmeise", "Bmeise", true));
            groupItem4.Items.Add(new DataItemModel("4", "Cmeise", string.Empty, true));
            groupItem4.Items.Add(new DataItemModel("5", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));
            groupItem4.Items.Add(new DataItemModel("6", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));
            groupItem4.Items.Add(new DataItemModel("7", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5000 Aarau\n +AHV", "Aneliese Ameise\n +Name: Aneliese Ameise \n +Adresse: Hauptstransse\n 5200 Aarau\n +AHV", true));
            this.listGroupData.Add(groupItem4);

            foreach (var groupItem in listGroupData)
            {
                this.CreateControlWithData(groupItem);
            }
        }

        private void CreateControlWithData(GroupItemModel dataModel)
        {
            if (dataModel.ExpandRow)
            {
                var controlGroup = new GroupDataExpandRowControl(dataModel);
                controlGroup.Dock = DockStyle.Top;
                this.xtraScrollableControl1.Controls.Add(controlGroup);
            }
            else
            {
                var controlGroup = new GroupDataControl(dataModel);
                controlGroup.Dock = DockStyle.Top;
                this.xtraScrollableControl1.Controls.Add(controlGroup);
            }
        }

    }
}
