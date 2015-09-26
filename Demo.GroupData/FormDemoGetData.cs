using Demo.GroupData.Models;
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
    public partial class FormDemoGetData : Form
    {
        public FormDemoGetData()
        {
            InitializeComponent();
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

        private void FormDemoGetData_Load(object sender, EventArgs e)
        {
            FileInfo olderfile = new FileInfo(Application.StartupPath + "\\" + "old.xml");
            FileInfo newfile = new FileInfo(Application.StartupPath + "\\" + "new.xml");
            contentType modelold = Deserializer<contentType>(olderfile);
            contentType modelnew = Deserializer<contentType>(newfile);
        }
    }
}
