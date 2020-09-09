using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Model;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp.CustomControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkiaPaint : Grid
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(SkiaPaint));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(string), typeof(SkiaPaint));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly BindableProperty ItemSourceProperty = BindableProperty.Create(nameof(ItemSource), typeof(IEnumerable), typeof(SkiaPaint));

        public IEnumerable ItemSource
        {
            get => (IEnumerable)GetValue(ItemSourceProperty);
            set => SetValue(ItemSourceProperty, value);
        }

        public static readonly BindableProperty ContentColorProperty = BindableProperty.Create("ContentColor", typeof(Color), typeof(SkiaPaint), Color.White);

        public Color ContentColor
        {
            get => (Color)GetValue(ContentColorProperty);
            set => SetValue(ContentColorProperty, value);
        }

        public SkiaPaint()
        {
            InitializeComponent();
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            int totalValues = 0;

            foreach (ChartEntry item in ItemSource)
            {
                totalValues += item.Value;
            }

            SKPoint center = new SKPoint(info.Width / 2, info.Height / 2);
            float explodeOffset = 0;
            float radius = Math.Min(info.Width / 2, info.Height / 2) - 2 * explodeOffset;
            SKRect rect = new SKRect(center.X - radius, center.Y - radius,
                                     center.X + radius, center.Y + radius);

            float startAngle = 0;

            foreach (ChartEntry item in ItemSource)
            {
                float sweepAngle = 360f * item.Value / totalValues;

                using (SKPath path = new SKPath())
                using (SKPaint fillPaint = new SKPaint())
                using (SKPaint outlinePaint = new SKPaint())
                {
                    path.MoveTo(center);
                    path.ArcTo(rect, startAngle, sweepAngle, false);
                    path.Close();

                    fillPaint.Style = SKPaintStyle.Fill;
                    fillPaint.Color = item.Color;

                    outlinePaint.Style = SKPaintStyle.Stroke;
                    outlinePaint.StrokeWidth = 5;
                    outlinePaint.Color = SKColors.Black;

                    canvas.Save();

                    // Fill and stroke the path
                    canvas.DrawPath(path, fillPaint);
                    canvas.Restore();

                    SKPaint circlePaint = new SKPaint
                    {
                        Style = SKPaintStyle.Stroke,
                        Color = Color.Red.ToSKColor(),
                        StrokeWidth = 25
                    };
                    circlePaint.Style = SKPaintStyle.Fill;
                    circlePaint.Color = ContentColor.ToSKColor();
                    canvas.DrawCircle(center.X, center.Y, radius - 40, circlePaint);

                    if (!string.IsNullOrEmpty(Value))
                    {
                        // Create an SKPaint object to display the text
                        SKPaint textPaint = new SKPaint
                        {
                            Color = Color.White.ToSKColor()
                        };

                        // Adjust TextSize property so text is 90% of screen width
                        float textWidth = textPaint.MeasureText(Value);
                        textPaint.TextSize = 0.3f * info.Width * textPaint.TextSize / textWidth;

                        // Find the text bounds
                        SKRect textBounds = new SKRect();
                        textPaint.MeasureText(Value, ref textBounds);

                        // Calculate offsets to center the text on the screen
                        float xText = info.Width / 2 - textBounds.MidX;
                        float yText = info.Height / 2 - textBounds.MidY;

                        // And draw the text
                        canvas.DrawText(Value, xText, yText - 40, textPaint);
                    }

                    if (!string.IsNullOrEmpty(Title))
                    {
                        // Create an SKPaint object to display the text
                        SKPaint nameTaxPaint = new SKPaint
                        {
                            Color = Color.White.ToSKColor()
                        };

                        // Adjust TextSize property so text is 90% of screen width
                        float nameWidth = nameTaxPaint.MeasureText(Title);
                        nameTaxPaint.TextSize = 0.6f * info.Width * nameTaxPaint.TextSize / nameWidth;

                        // Find the text bounds
                        SKRect nameBounds = new SKRect();
                        nameTaxPaint.MeasureText(Title, ref nameBounds);

                        // Calculate offsets to center the text on the screen
                        float nameX = info.Width / 2 - nameBounds.MidX;
                        float nameY = info.Height / 2 - nameBounds.MidY;

                        // And draw the text
                        canvas.DrawText(Title, nameX, nameY + 50, nameTaxPaint);
                    }
                }

                startAngle += sweepAngle;
            }
        }
    }
}