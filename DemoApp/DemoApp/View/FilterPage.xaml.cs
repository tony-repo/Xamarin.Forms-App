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
    public partial class FilterPage : ContentPage
    {
        public FilterPage()
        {
            InitializeComponent();
            BindingContext = new FilterViewModel();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var source = e.SelectedItem as FilterSource;

            if (source != null)
            {
                 source.SelectedCommand.Execute(null);
            }
        }
    }
}