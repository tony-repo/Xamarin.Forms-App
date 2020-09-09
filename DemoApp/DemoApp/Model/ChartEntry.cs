using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;

namespace DemoApp.Model
{
    public class ChartEntry
    {
        public ChartEntry(int value, SKColor color)
        {
            Value = value;
            Color = color;
        }

        public int Value { private set; get; }

        public SKColor Color { private set; get; }
    }
}
