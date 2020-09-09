using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace DemoApp.CustomControl
{
    public class MyValidateEntry : Entry
    {
        public static BindableProperty TextDataProperty = BindableProperty.Create(
            propertyName: nameof(TextData),
            returnType: typeof(string),
            declaringType: typeof(MyValidateEntry),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                MyValidateEntry targetView;
                targetView = bindable as MyValidateEntry;

                if (targetView != null && newValue != null)
                {
                    //targetView.entry.Text = newValue.ToString();
                    targetView.Text = newValue.ToString();
                }
            });

        public string TextData
        {
            get => (string)GetValue(TextDataProperty);
            set => SetValue(TextDataProperty, value);
        }
    }
}
