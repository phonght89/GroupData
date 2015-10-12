using System;
using System.Collections.Generic;

namespace Demo.GroupData.Models
{
    public class DataItemViewModelBase
    {
        public dynamic ModelOlder { get; set; }
        public dynamic ModelNew { get; set; }
        public List<measureLawType> ListModelOlder { get; set; }
        public List<measureLawType> ListModelNew { get; set; }

        public DataItemViewModelBase(string id, string name, string dataOlder, string dataNew, bool? useFirst, dynamic modelOlder = null, dynamic modelNew = null, bool show = false)
        {
            this.id = id;
            this.name = name;
            this.Show = show;
            this.ModelOlder = modelOlder;
            this.ModelNew = modelNew;
            this.dataNew = dataNew;
            this.dataShortNew = GetDataShort(dataNew);
            this.dataOlder = dataOlder;
            this.dataShortOlder = GetDataShort(dataOlder);
            this.useFirst = useFirst;
            this.useOlder = useFirst ?? false;
            this.useNew = useFirst != null && !useOlder;
            if (!string.IsNullOrEmpty(dataNew) && !string.Equals(this.dataNew, this.dataOlder, StringComparison.InvariantCultureIgnoreCase))
            {
                this.useFirst = false;
                this.useOlder = false;
                this.useNew = true;
            }
            else
            {
                this.useFirst = true;
                this.useOlder = true;
                this.useNew = false;
            }
        }

        public DataItemViewModelBase(List<string> ids, string name, string dataOlder, string dataNew, bool? useFirst, List<measureLawType> listmodelOlder, List<measureLawType> listmodelNew, bool show = false)
        {
            this.ids = ids;
            this.name = name;
            this.Show = show;
            this.ListModelOlder = listmodelOlder;
            this.ListModelNew = listmodelNew;
            this.dataNew = dataNew;
            this.dataShortNew = GetDataShort(dataNew);
            this.dataOlder = dataOlder;
            this.dataShortOlder = GetDataShort(dataOlder);
            this.useFirst = useFirst;
            this.useOlder = useFirst ?? false;
            this.useNew = useFirst != null && !useOlder;
            if (!string.IsNullOrEmpty(dataNew) && !string.Equals(this.dataNew, this.dataOlder, StringComparison.InvariantCultureIgnoreCase))
            {
                this.useFirst = false;
                this.useOlder = false;
                this.useNew = true;
            }
            else
            {
                this.useFirst = true;
                this.useOlder = true;
                this.useNew = false;
            }
        }
        public List<string> Ids
        {
            get { return this.ids; }
        }
        private readonly List<string> ids;
        public string Id
        {
            get { return this.id; }
        }
        private readonly string id;

        public bool IsChange
        {
            get
            {
                return this.useFirst != null && this.useFirst != this.useOlder;
            }
        }
        private bool? useFirst;

        public string NameColumn
        {
            get { return this.name; }
        }
        private readonly string name;

        public string DataOlder
        {
            get { return this.dataOlder; }
        }
        private readonly string dataOlder;

        public string DataColumnOlder
        {
            get { return this.Show ? this.dataOlder : this.dataShortOlder; }
        }
        private string dataShortOlder;

        public string DataNew
        {
            get { return this.dataNew; }
        }
        private readonly string dataNew;

        public string DataColumnNew
        {
            get { return this.Show ? this.dataNew : this.dataShortNew; }
        }
        private string dataShortNew;

        public bool UseOlder
        {
            get { return this.useOlder; }
            set
            {
                //this.useNew = !value;
                if (value)
                {
                    this.useOlder = true;
                    this.useNew = false;
                }
                else
                {
                    this.useOlder = string.IsNullOrWhiteSpace(dataNew);this.useNew = !string.IsNullOrWhiteSpace(dataNew);
                }
            }
        }
        private bool useOlder;

        public bool UseNew
        {
            get { return this.useNew; }
            set
            {
                this.useNew = value;
                this.useOlder = !value;
                //if (value)
                //{
                //    this.useOlder = false;
                //}
                //else
                //{
                //    this.useOlder = !string.IsNullOrWhiteSpace(dataOlder);
                //}
            }
        }
        private bool useNew;

        public bool Show { get; set; }
        public string GetDataShort(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return data;
            int lenghtRow1 = data.IndexOf('\n');
            if (lenghtRow1 > 0)
                return data.Substring(0, lenghtRow1);
            return data;
        }
    }
}
