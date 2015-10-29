using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.GroupData.Models
{
    public class DocumentDataGroupItemViewModel : GroupItemModelBase
    {
        public DocumentDataGroupItemViewModel(string id, List<documentDataType> documentDatasOlder, List<documentDataType> documentDatasNew, bool expandRow = false)
            : base(id, expandRow)
        {
            this.documentDatasOlder = documentDatasOlder;
            this.documentDatasNew = documentDatasNew;
            this.InitData();
        }

        public List<documentDataType> DocumentDatasOlder
        {
            get
            {
                return this.documentDatasOlder;
            }
            set
            {
                this.documentDatasOlder = value;
            }
        }
        private List<documentDataType> documentDatasOlder;

        public List<documentDataType> DocumentDatasNew
        {
            get
            {
                return this.documentDatasNew;
            }
            set
            {
                this.documentDatasNew = value;
            }
        }
        private List<documentDataType> documentDatasNew;

        private void InitData()
        {
            int numericalorder = 0;
            var listData = new List<DataItemViewModelBase>();
            foreach (var documentDataItemOlder in documentDatasOlder)
            {
                var dataOlder = documentDataItemOlder.ToString();
                var documentDataItemNew = this.documentDatasNew.FirstOrDefault(k => string.Equals(k.keyword, documentDataItemOlder.keyword, StringComparison.CurrentCultureIgnoreCase));
                
                var dataNew = documentDataItemNew != null ? documentDataItemNew.ToString() : string.Empty;

                var itemViewModel = new DataItemViewModelBase(documentDataItemOlder.Id, string.Empty, dataOlder, dataNew, true, documentDataItemOlder, documentDataItemNew, false, documentDataItemOlder.date.ToString());
                listData.Add(itemViewModel);
            }

            foreach (var documentDataItemNew in documentDatasNew)
            {
                if (!documentDatasOlder.Any(k => string.Equals(k.keyword, documentDataItemNew.keyword, StringComparison.CurrentCultureIgnoreCase)))
                {
                    var dataNew = documentDataItemNew.ToString();
                    var itemViewModel = new DataItemViewModelBase(string.Empty, string.Empty, string.Empty, dataNew, false, null, documentDataItemNew, false, documentDataItemNew.date.ToString());
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
