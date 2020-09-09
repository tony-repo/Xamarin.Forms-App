using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    public class FilterSource
    {
        public string Text { get; set; }

        public ICommand SelectedCommand { get; set; }
    }

    public class FilterViewModel : BaseViewModel
    {

        public ObservableCollection<FilterSource> Sources { get; set; }


        public ICommand ItemSelectedCommand { get; set; }
        public FilterViewModel()
        {
           
        }

    }
}
