using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.GroupData.Models
{
    public class RelativeInfoGroupItemViewModel : GroupItemModelBase
    {
        public RelativeInfoGroupItemViewModel(string id, List<relativeInfoType> relativeInfosOlder, List<relativeInfoType> relativeInfosNew, bool expandRow = false)
            : base(id, expandRow)
        {
            this.relativeInfosOlder = relativeInfosOlder;
            this.relativeInfosNew = relativeInfosNew;
            this.InitData();
        }

        public List<relativeInfoType> RelativeInfosOlder
        {
            get
            {
                return this.relativeInfosOlder;
            }
            set
            {
                this.relativeInfosOlder = value;
            }
        }
        private List<relativeInfoType> relativeInfosOlder;

        public List<relativeInfoType> RelativeInfosNew
        {
            get
            {
                return this.relativeInfosNew;
            }
            set
            {
                this.relativeInfosNew = value;
            }
        }
        private List<relativeInfoType> relativeInfosNew;

        private void InitData()
        {
            int numericalorder = 0;
            var listData = new List<DataItemViewModelBase>();
            foreach (var relativeInfoItemOlder in relativeInfosOlder)
            {
                var dataOlder = relativeInfoItemOlder.ToString();
                var relativeInfoItemNew = this.relativeInfosNew.FirstOrDefault(k => k.title == relativeInfoItemOlder.title
                        && string.Equals(k.firstName, relativeInfoItemOlder.firstName, StringComparison.CurrentCultureIgnoreCase)
                        && string.Equals(k.lastName, relativeInfoItemOlder.lastName, StringComparison.CurrentCultureIgnoreCase));
                var dataNew = relativeInfoItemNew != null ? relativeInfoItemNew.ToString() : string.Empty;

                var itemViewModel = new DataItemViewModelBase(relativeInfoItemOlder.Id, string.Empty, dataOlder, dataNew, true, relativeInfoItemOlder, relativeInfoItemNew, false);
                listData.Add(itemViewModel);
            }

            foreach (var relativeInfoItemNew in relativeInfosNew)
            {
                if (!relativeInfosOlder.Any(k => k.title == relativeInfoItemNew.title
                    && string.Equals(k.firstName, relativeInfoItemNew.firstName, StringComparison.CurrentCultureIgnoreCase)
                        && string.Equals(k.lastName, relativeInfoItemNew.lastName, StringComparison.CurrentCultureIgnoreCase)))
                {
                    var dataNew = relativeInfoItemNew.ToString();
                    var itemViewModel = new DataItemViewModelBase(string.Empty, string.Empty, string.Empty, dataNew, false, null, relativeInfoItemNew, false);
                    listData.Add(itemViewModel);
                }
            }

            // sort
            foreach (var item in listData.OrderBy(k => k.Sort).ThenBy(k => k.SortName).ToList())
            {
                numericalorder++;
                item.NameColumn = numericalorder.ToString();
                item.Show = numericalorder == 1;
                this.Items.Add(item);
            }
        }
    }
}
