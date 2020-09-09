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
    public partial class MyProfilePage : ContentPage
    {
        public MyProfilePage()
        {
            InitializeComponent();
            BindingContext = new MyProfileViewModel();
        }
    }
}