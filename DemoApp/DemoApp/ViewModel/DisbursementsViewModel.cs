using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using DemoApp.Model;
using Xamarin.Forms;
using DemoApp.Utility;

namespace DemoApp.ViewModel
{
    public class DisbursementsViewModel : BaseViewModel
    {
        public ICommand DisbursementsCommand { get; private set; }

        private List<DisbursementInfo> _disbursementInfosSource;
        private ObservableCollection<DisbursementInfo> _disbursementInfos;

        public ObservableCollection<DisbursementInfo> DisbursementInfos
        {
            get => _disbursementInfos;
            private set
            {
                _disbursementInfos = value;
                OnPropertyChanged();
            }
        }

        public DisbursementsViewModel()
        {
            _disbursementInfosSource = new List<DisbursementInfo>();
            _disbursementInfos = new ObservableCollection<DisbursementInfo>();

            DisbursementsCommand = new Command((searchTest) =>
            {
                var searchString = searchTest?.ToString();

                if (!string.IsNullOrEmpty(searchString))
                {
                    DisbursementInfos = _disbursementInfosSource.Where(ds => ds.Name.Contains(searchString)).ConvertToObservableCollection();
                }
                else
                {
                    DisbursementInfos = _disbursementInfosSource.ConvertToObservableCollection();
                }
            });

            GetDisbursementInfos();
        }

        public void GetDisbursementInfos()
        {
            var info1 = new DisbursementInfo
            {
                Name = "Maya Jones",
                Id = "XXX-XX-0149",
                Date = "08-04-2019",
                Amount = "72.38"
            };
            var info2 = new DisbursementInfo
            {
                Name = "Greg Jones",
                Id = "XXX-XX-0149",
                Date = "08-04-2019",
                Amount = "72"
            };
            var info3 = new DisbursementInfo
            {
                Name = "Tony An",
                Id = "XXX-XX-0149",
                Date = "08-04-2019",
                Amount = "75.38"
            };
            var info4 = new DisbursementInfo
            {
                Name = "Tony Wang",
                Id = "XXX-XX-0149",
                Date = "08-04-2019",
                Amount = "77.38"
            };
            var info5 = new DisbursementInfo
            {
                Name = "Tony Wei",
                Id = "XXX-XX-0149",
                Date = "08-04-2019",
                Amount = "90.38"
            };

            _disbursementInfosSource.Add(info1);
            _disbursementInfosSource.Add(info2);
            _disbursementInfosSource.Add(info3);
            _disbursementInfosSource.Add(info4);
            _disbursementInfosSource.Add(info5);

            _disbursementInfos = _disbursementInfosSource.ConvertToObservableCollection();
        }
    }
}
