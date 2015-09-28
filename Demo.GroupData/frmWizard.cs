using Demo.GroupData.Controls;
using Demo.GroupData.Models;
using DevExpress.XtraWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.GroupData
{
    public partial class frmWizard : Form
    {
        public frmWizard()
        {
            InitializeComponent();
            this.xtraScrollableControl1.Width = 1070;
            this.LoadData();
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Finish!");
            PFinish.AllowBack = false;
            PFinish.AllowNext = false;
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page.Name == "PChoosePath")
            {
                //if (txtPassZip.Text.Trim() == "")
                //{
                //    MessageBox.Show("Chọn path");
                //    e.Handled = true;
                //}
                //else
                //{
                //    MessageBox.Show("oke");
                //    e.Handled = false;
                //}

            }
            else if (e.Page.Name == "PChooseClient")
            {
                if(checkEdit1.Checked == true)
                {
                    wizardControl1.SelectedPage = PFinish;
                }
               // MessageBox.Show("Chọn client");
            }
        }

        private void wizardControl1_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            if (e.Page == PFinish)
            {
                PFinish.AllowNext = false;
                PFinish.AllowBack = false;
                PFinish.AllowCancel = false;
            }
        }
        private ClientInfoGroupItemViewModel clientInfoVm;
        private RelativeInfoGroupItemViewModel relativeInfoVm;
        private DocumentDataGroupItemViewModel documentDataVm;
        private MeasureLawGroupItemViewModel measureLawVm;
        private void LoadData()
        {
            FileInfo olderfile = new FileInfo(Application.StartupPath + "\\" + "old.xml"); FileInfo newfile = new FileInfo(Application.StartupPath + "\\" + "new.xml");
            contentType modelold = Deserializer<contentType>(olderfile);
            contentType modelnew = Deserializer<contentType>(newfile);
            clientInfoVm = new ClientInfoGroupItemViewModel(modelold.clientInfo, modelnew.clientInfo);
            relativeInfoVm = new RelativeInfoGroupItemViewModel(modelold.clientInfo.Id, modelold.relativeInfos, modelnew.relativeInfos);
            documentDataVm = new DocumentDataGroupItemViewModel(modelold.clientInfo.Id, modelold.documentDatas, modelnew.documentDatas);
            measureLawVm = new MeasureLawGroupItemViewModel(modelold.clientInfo.Id, modelold.measureLaws, modelnew.measureLaws);

            var measureLawGroup = new GroupDataExpandRowControl(measureLawVm, "Massnahmen");
            measureLawGroup.Dock = DockStyle.Top;
            this.xtraScrollableControl1.Controls.Add(measureLawGroup);

            var documentDataGroup = new GroupDataExpandRowControl(documentDataVm, "Dokumente");
            documentDataGroup.Dock = DockStyle.Top;
            this.xtraScrollableControl1.Controls.Add(documentDataGroup);

            var relativeInfoGroup = new GroupDataExpandRowControl(relativeInfoVm, "Angehörige");
            relativeInfoGroup.Dock = DockStyle.Top;
            this.xtraScrollableControl1.Controls.Add(relativeInfoGroup);

            var clientInfoGroup = new GroupDataControl(clientInfoVm);
            clientInfoGroup.Dock = DockStyle.Top;
            this.xtraScrollableControl1.Controls.Add(clientInfoGroup);

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

        private void CreateControlWithData(GroupItemModelBase dataModel, string headerText)
        {
            if (dataModel.ExpandRow)
            {
                var controlGroup = new GroupDataExpandRowControl(dataModel, headerText);
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
