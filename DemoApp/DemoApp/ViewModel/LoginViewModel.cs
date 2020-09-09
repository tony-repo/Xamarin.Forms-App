using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using DemoApp.View;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    public class LoginViewModel : BaseValidationViewModel
    {
        public ICommand LoginCommand { get; private set; }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                //Validate(() => !string.IsNullOrWhiteSpace(_userName), "UserName must be provided.");
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private bool isChecked = false;

        public bool IsChecked
        {
            get => isChecked;
            set
            {
                isChecked = value;
                OnPropertyChanged(nameof(IsChecked));
            }
        }

        readonly Dictionary<string, bool> _errors = new Dictionary<string, bool>();

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
        }

        private void Login()
        {
            Application.Current.MainPage = new CarouselViewPage();

           // var ss = Settings.AppSettings.AddOrUpdateValue("token", "123123123123", "settings");
            var data = Settings.AppSettings.GetValueOrDefault("token", string.Empty, "settings");

            //if (string.Equals(UserName, "111") && string.Equals(Password, "111"))
            //{
            //    //navigate to DashBoard page.
            //    Application.Current.MainPage = new MainPage();
            //}
        }
    }
}
