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
            this.measureLawsGroupByCategory = new List<MeasureLawGroupByCategory>();
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

        public List<MeasureLawGroupByCategory> MeasureLawsGroupByCategory
        {
            get
            {
                return this.measureLawsGroupByCategory;
            }
            set
            {
                this.measureLawsGroupByCategory = value;
            }
        }
        private List<MeasureLawGroupByCategory> measureLawsGroupByCategory;

        private void InitData()
        {
            foreach (var measureLawItemOlder in this.measureLawsOlder)
            {
                var measureLawGroupByCategory = this.measureLawsGroupByCategory.FirstOrDefault(k => string.Equals(k.AgeCategory, measureLawItemOlder.ageCategory, StringComparison.CurrentCultureIgnoreCase));
                if (measureLawGroupByCategory != null)
                {
                    measureLawGroupByCategory.MeasureLawsOlder.Add(measureLawItemOlder);
                }
                else
                {
                    measureLawGroupByCategory = new MeasureLawGroupByCategory(measureLawItemOlder.ageCategory);
                    measureLawGroupByCategory.MeasureLawsOlder.Add(measureLawItemOlder);
                    this.measureLawsGroupByCategory.Add(measureLawGroupByCategory);
                }
            }

            foreach (var measureLawItemNew in this.measureLawsNew)
            {
                var measureLawGroupByCategory = this.measureLawsGroupByCategory.FirstOrDefault(k => string.Equals(k.AgeCategory, measureLawItemNew.ageCategory, StringComparison.CurrentCultureIgnoreCase));
                if (measureLawGroupByCategory != null)
                {
                    measureLawGroupByCategory.MeasureLawsNew.Add(measureLawItemNew);
                }
                else
                {
                    measureLawGroupByCategory = new MeasureLawGroupByCategory(measureLawItemNew.ageCategory);
                    measureLawGroupByCategory.MeasureLawsNew.Add(measureLawItemNew);
                    this.measureLawsGroupByCategory.Add(measureLawGroupByCategory);
                }
            }

            int numericalorder = 0;
            foreach (var measureLawItem in this.measureLawsGroupByCategory)
            {
                numericalorder++;
                var dataOlder = measureLawItem.GetStringDataOlder();
                var dataNew = measureLawItem.GetStringDataOlder();

                var itemViewModel = new DataItemViewModelBase(measureLawItem.GetIds(), numericalorder.ToString(), dataOlder, dataNew, true, measureLawItem.MeasureLawsOlder, measureLawItem.MeasureLawsNew, numericalorder == 1);
                this.Items.Add(itemViewModel);
            }
        }
    }

    public class MeasureLawGroupByCategory
    {
        public MeasureLawGroupByCategory(string ageCategory)
        {
            this.ageCategory = ageCategory;
            this.measureLawsOlder = new List<measureLawType>();
            this.measureLawsNew = new List<measureLawType>();
        }

        public string AgeCategory
        {
            get { return this.ageCategory; }
            set { this.ageCategory = value; }
        }
        private string ageCategory;
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

        public List<string> GetIds()
        {
            return this.measureLawsOlder.Where(k => !string.IsNullOrEmpty(k.Id)).Select(k => k.Id).ToList();
        }

        public string GetStringDataOlder()
        {
            if (this.measureLawsOlder.Count <= 0) return string.Empty;
            var result = this.ageCategory;
            foreach (var measureLaw in this.measureLawsOlder)
            {
                result += "\n" + measureLaw.ToString();
            }
            return result;
        }

        public string GetStringDataNew()
        {
            if (this.measureLawsNew.Count <= 0) return string.Empty;
            var result = this.ageCategory;
            foreach (var measureLaw in this.measureLawsNew)
            {
                result += "\n" + measureLaw.ToString();
            }
            return result;
        }
    }
}
