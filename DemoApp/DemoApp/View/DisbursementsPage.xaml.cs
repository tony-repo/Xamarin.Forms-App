using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisbursementsPage : ContentPage
    {

        private DisbursementsViewModel viewModel = new DisbursementsViewModel();
        public DisbursementsPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue != e.OldTextValue)
            {
                this.searchBar.SearchCommand.Execute(e.NewTextValue);
            }
        }
    }
}