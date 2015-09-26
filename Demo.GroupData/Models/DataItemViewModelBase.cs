namespace Demo.GroupData.Models
{
    public class DataItemViewModelBase
    {
        public DataItemViewModelBase(string id, string name, bool show = false)
        {
            this.id = id;
            this.name = name;
            this.Show = show;
        }
        public DataItemViewModelBase(string id, string name, string dataOlder, string dataNew, bool? useFirst, bool show = false)
            : this(id, name, show)
        {
            this.dataNew = dataNew;
            this.dataOlder = dataOlder;
            this.useFirst = useFirst;
            this.useOlder = useFirst ?? false;
            this.useNew = useFirst != null && !useOlder;
            var dataRowOlder = dataOlder.Split(new char[] { '\n' }).Length;
            var dataRowNew = dataNew.Split(new char[] { '\n' }).Length;
            this.Height = dataRowOlder >= dataRowNew ? dataRowOlder : dataRowNew;
        }
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
                if (value)
                {
                    this.useNew = false;
                }
                else
                {
                    this.useNew = !string.IsNullOrWhiteSpace(dataNew);
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
                if (value)
                {
                    this.useOlder = false;
                }
                else
                {
                    this.useOlder = !string.IsNullOrWhiteSpace(dataOlder);
                }
            }
        }
        private bool useNew;

        public int Height { get; set; }
        public bool Show { get; set; }
    }
}
