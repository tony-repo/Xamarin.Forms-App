using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using DemoApp.Model;
using DemoApp.Utility;

namespace DemoApp.ViewModel
{
    public class CustomEditModelGroup : List<CustomEditModel>
    {
        
        public string Name { get; private set; }

        public CustomEditModelGroup(string name, List<CustomEditModel> animals) : base(animals)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class MyProfileViewModel : BaseViewModel
    {
        public ObservableCollection<CustomEditModel> ContactInfoDataSource { get; set; }
        public ObservableCollection<CustomEditModel> ShippingSettingsDataSource { get; set; }
        public ObservableCollection<CustomEditModel> BankAccountInfoDataSource { get; set; }

        public List<CustomEditModelGroup> CustomEditModelGroup { get; private set; } = new List<CustomEditModelGroup>();


        private string _dataTitle;
        public string DataTitle
        {
            get => _dataTitle;
            set
            {
                _dataTitle = value;
                OnPropertyChanged();
            }
        }

        public MyProfileViewModel()
        {
            CreateGroupData();

            ContactInfoDataSource = new ObservableCollection<CustomEditModel>();
            ShippingSettingsDataSource = new ObservableCollection<CustomEditModel>();
            BankAccountInfoDataSource = new ObservableCollection<CustomEditModel>();
        }

        private void CreateGroupData()
        {
            var contactdata = new CustomEditModel
            {
                Name = "Office Phone",
                Value = "555-555-5555"
            };
            var contactdata1 = new CustomEditModel
            {
                Name = "Mobile Phone",
                Value = "555-555-5555"
            };

            var contactdata2 = new CustomEditModel
            {
                Name = "Email",
                Value = "testuser@greendotcorp.com"
            };

            var data = new List<CustomEditModel>();

            data.Add(contactdata);
            data.Add(contactdata1);
            data.Add(contactdata2);

            CustomEditModelGroup.Add(new CustomEditModelGroup("Contact Info", data));
            CustomEditModelGroup.Add(new CustomEditModelGroup("ShippingSettings", data));
            CustomEditModelGroup.Add(new CustomEditModelGroup("BankAccount", data));
        }
    }
}
