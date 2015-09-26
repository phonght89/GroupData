namespace Demo.GroupData.Models
{
    using System.ComponentModel;

    public class GroupItemModelBase
    {
        public GroupItemModelBase(string id, bool expandRow = false)
        {
            this.id = id;
            this.expandRow = expandRow;
            this.isChange = false;
            this.Items = new BindingList<dynamic>();
        }

        public BindingList<dynamic> Items { get; set; }

        public bool IsChange
        {
            get { return this.isChange; }
            set
            {
                this.isChange = value;
            }
        }

        private bool isChange;

        public bool ExpandRow
        {
            get { return this.expandRow; }
            set
            {
                this.expandRow = value;
            }
        }

        private bool expandRow;

        public string Id
        {
            get { return this.id; }
        }
        private readonly string id;
    }
}
