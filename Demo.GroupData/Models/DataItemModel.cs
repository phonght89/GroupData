namespace Demo.GroupData.Models
{
    public class DataItemModel
    {
        public DataItemModel(string name, string dataOlder, string dataNew, bool userOlder, bool show = false)
        {
            this.name = name;
            this.dataNew = dataNew;
            this.dataOlder = dataOlder;
            this.useFirst = userOlder;
            this.useOlder = userOlder;
            this.useNew = !userOlder;
            this.Height = dataOlder.Split(new char[] { '\n' }).Length;
            this.Show = show;
        }

        public bool IsChange
        {
            get
            {
                return this.useFirst != this.UseOlder;
            }
        }
        private bool useFirst;

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

        public string DataNew
        {
            get { return this.dataNew; }
        }
        private readonly string dataNew;

        public bool UseOlder
        {
            get { return this.useOlder; }
            set
            {
                this.useOlder = value;
                this.useNew = !value;
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
            }
        }
        private bool useNew;

        public int Height { get; set; }
        public bool Show { get; set; }
    }
}
