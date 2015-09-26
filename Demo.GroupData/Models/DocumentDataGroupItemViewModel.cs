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
            foreach (var documentDataItemOlder in documentDatasOlder)
            {
                numericalorder++;
                var dataOlder = documentDataItemOlder.ToString();
                var documentDataItemNew = this.documentDatasNew.FirstOrDefault(k => string.Equals(k.keyword, documentDataItemOlder.keyword, StringComparison.CurrentCultureIgnoreCase));
                var dataNew = documentDataItemNew != null ? documentDataItemNew.ToString() : string.Empty;

                var itemViewModel = new DataItemViewModelBase(documentDataItemOlder.Id, numericalorder.ToString(), dataOlder, dataNew, true, numericalorder == 1);
                this.Items.Add(itemViewModel);
            }

            foreach (var documentDataItemNew in documentDatasNew)
            {
                if (!documentDatasOlder.Any(k => string.Equals(k.keyword, documentDataItemNew.keyword, StringComparison.CurrentCultureIgnoreCase)))
                {
                    numericalorder++;
                    var dataNew = documentDataItemNew.ToString();
                    var itemViewModel = new DataItemViewModelBase(string.Empty, numericalorder.ToString(), string.Empty, dataNew, false);
                    this.Items.Add(itemViewModel);
                }
            }
        }
    }
}
