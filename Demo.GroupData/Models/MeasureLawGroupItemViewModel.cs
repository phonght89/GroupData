using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.GroupData.Models
{
    public class MeasureLawGroupItemViewModel : GroupItemModelBase
    {
        public MeasureLawGroupItemViewModel(string id, List<measureLawType> measureLawsOlder, List<measureLawType> measureLawsNew, bool expandRow = false)
            : base(id, expandRow)
        {
            this.measureLawsOlder = measureLawsOlder;
            this.measureLawsNew = measureLawsNew;
            this.InitData();
        }

        public List<measureLawType> MeasureLawsOlder
        {
            get
            {
                return this.measureLawsOlder;
            }
            set
            {
                this.measureLawsOlder = value;
            }
        }
        private List<measureLawType> measureLawsOlder;

        public List<measureLawType> MeasureLawsNew
        {
            get
            {
                return this.measureLawsNew;
            }
            set
            {
                this.measureLawsNew = value;
            }
        }
        private List<measureLawType> measureLawsNew;

        private void InitData()
        {
            int numericalorder = 0;
            foreach (var measureLawItemOlder in measureLawsOlder)
            {
                numericalorder++;
                var dataOlder = measureLawItemOlder.ToString();
                var measureLawItemNew = this.measureLawsNew.FirstOrDefault(k => string.Equals(k.ageCategory, measureLawItemOlder.ageCategory, StringComparison.CurrentCultureIgnoreCase));
                var dataNew = measureLawItemNew != null ? measureLawItemNew.ToString() : string.Empty;

                var itemViewModel = new DataItemViewModelBase(measureLawItemOlder.Id, numericalorder.ToString(), dataOlder, dataNew, true, measureLawItemOlder, measureLawItemNew, numericalorder == 1);
                this.Items.Add(itemViewModel);
            }

            foreach (var measureLawItemNew in measureLawsNew)
            {
                if (!measureLawsOlder.Any(k => string.Equals(k.ageCategory, measureLawItemNew.ageCategory, StringComparison.CurrentCultureIgnoreCase)))
                {
                    numericalorder++;
                    var dataNew = measureLawItemNew.ToString();
                    var itemViewModel = new DataItemViewModelBase(string.Empty, numericalorder.ToString(), string.Empty, dataNew, false, null, measureLawItemNew, numericalorder == 1);
                    this.Items.Add(itemViewModel);
                }
            }
        }
    }
}
