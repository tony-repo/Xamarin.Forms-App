using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.CustomControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditControl : Grid
    {

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(EditControl));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        //public static BindableProperty EditSourceProperty = BindableProperty.Create(
        //    propertyName: "EditSource",
        //    returnType: typeof(IEnumerable),
        //    declaringType: typeof(EditControl),
        //    defaultValue: null,
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: (bindable, oldValue, newValue) =>
        //    {
        //        EditControl targetView;

        //        targetView = (EditControl)bindable;
        //        if (targetView != null)
        //            targetView.dataListView.ItemsSource = (IEnumerable)newValue;
        //    });
        public static readonly BindableProperty EditSourceProperty = BindableProperty.Create(nameof(EditSource), typeof(IEnumerable), typeof(EditControl));
        public IEnumerable EditSource
        {
            get => (IEnumerable)GetValue(EditSourceProperty);
            set => SetValue(EditSourceProperty, value);
        }
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }

        public EditControl()
        {
            InitializeComponent();
        }
    }
}