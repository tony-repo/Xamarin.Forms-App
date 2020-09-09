using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            masterPage.listView.ItemSelected += OnItemSelected;
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                var page = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                page.BarBackgroundColor = Color.FromHex("#093057");
                page.BarTextColor = Color.White;
                Detail = page;
                masterPage.listView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}