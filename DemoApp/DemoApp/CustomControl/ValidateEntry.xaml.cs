using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.CustomControl
{
 
    // TODO: NEED TO CONSIDER A BETTER WAY TO refactor it
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValidateEntry : Grid
    {
        //public static BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(ValidateEntry));

        //public string Placeholder
        //{
        //    get => (string)GetValue(PlaceholderProperty);
        //    set => SetValue(PlaceholderProperty, value);
        //}

        //public static BindableProperty TextProperty =
        //    BindableProperty.Create(nameof(Text), typeof(string), typeof(ValidateEntry));

        //public static BindableProperty TextProperty = BindableProperty.Create(
        //    propertyName: nameof(Text),
        //    returnType: typeof(string),
        //    declaringType: typeof(ValidateEntry),
        //    defaultValue: string.Empty,
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: (bindable, oldValue, newValue) =>
        //    {
        //        ValidateEntry targetView;
        //        targetView = (ValidateEntry)bindable;

        //        if (targetView != null && newValue != null)
        //        {
        //            //targetView.entry.Text = newValue.ToString();
                    
        //        }
        //    });

        //public new string Text
        //{
        //    get => (string)GetValue(TextProperty);
        //    set => SetValue(TextProperty, value);
        //}

        public ValidateEntry()
        {
            InitializeComponent();
        }
    }
}