using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using DemoApp.CustomControl;
using DemoApp.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(MyValidateEntry), typeof(ValidateEntryRenderer))]
namespace DemoApp.Droid.CustomRenderer
{
    public class ValidateEntryRenderer : EntryRenderer
    {
        public ValidateEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}