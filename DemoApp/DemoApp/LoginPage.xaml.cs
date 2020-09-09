using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.ViewModel;
using Xamarin.Forms;

namespace DemoApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel viewModel = new LoginViewModel();

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
            viewModel.ErrorsChanged += ViewModel_ErrorsChanged;
        }
        void ViewModel_ErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        {
            //var propHasErrors = (viewModel.GetErrors(e.PropertyName) as List<string>)?.Any() == true;

            //switch (e.PropertyName)
            //{
            //    case nameof(viewModel.UserName):
            //        this.UserNameEntry.TextColor = propHasErrors ? Color.Red : Color.Black;
            //        break;
            //}
        }

        //private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var source = e.SelectedItem as FilterSource;

        //    if (source != null)
        //    {
        //        source.SelectedCommand.Execute(null);
        //    }
        //}
    }
}
