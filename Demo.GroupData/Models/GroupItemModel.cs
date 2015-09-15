namespace Demo.GroupData.Models
{
    using System.ComponentModel;

    public class GroupItemModel
    {
        public GroupItemModel(string id)
        {
            this.id = id;
            this.isChange = false;
            this.Items = new BindingList<DataItemModel>();
        }

        public BindingList<DataItemModel> Items { get; set; }

        public bool IsChange
        {
            get { return this.isChange; }
            set
            {
                this.isChange = value;
            }
        }

        private bool isChange;


        public string Id
        {
            get { return this.id; }
        }
        private readonly string id;
    }
}
