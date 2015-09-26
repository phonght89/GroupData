using System;
using System.IO;

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
            this.xtraScrollableControl1.Width = 1070;
            this.LoadData();
        }

        private ClientInfoGroupItemViewModel clientInfoVm;
        private RelativeInfoGroupItemViewModel relativeInfoVm;
        private void LoadData(){
            FileInfo olderfile = new FileInfo(Application.StartupPath + "\\" + "old.xml");
            FileInfo newfile = new FileInfo(Application.StartupPath + "\\" + "new.xml");
            contentType modelold = Deserializer<contentType>(olderfile);
            contentType modelnew = Deserializer<contentType>(newfile);
            clientInfoVm = new ClientInfoGroupItemViewModel(modelold.clientInfo,modelnew.clientInfo);
            relativeInfoVm = new RelativeInfoGroupItemViewModel(modelold.clientInfo.Id, modelold.relativeInfos, modelnew.relativeInfos);
            var controlGroup = new GroupDataControl(clientInfoVm);
            controlGroup.Dock = DockStyle.Top;
            this.xtraScrollableControl1.Controls.Add(controlGroup);
            var controlGroupExpandRow = new GroupDataExpandRowControl(clientInfoVm);
            controlGroupExpandRow.Dock = DockStyle.Top;
            this.xtraScrollableControl1.Controls.Add(controlGroupExpandRow);
        }

        public static T Deserializer<T>(FileInfo fi)
        {
            try
            {

                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(T));
                if (fi.Exists)
                {
                    using (System.IO.StreamReader file = new System.IO.StreamReader(fi.FullName))
                    {
                        T overview = (T)reader.Deserialize(file);
                        return (T)Convert.ChangeType(overview, typeof(T)); ;
                    }
                }
                return (T)Convert.ChangeType(null, typeof(T));

            }
            catch (Exception ex)
            {
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }

        private void CreateControlWithData(GroupItemModelBase dataModel)
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
