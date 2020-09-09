using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DemoApp.Model;
using SkiaSharp;
using Microcharts;

namespace DemoApp.ViewModel
{
    public class DashboardViewModel : BaseViewModel
    {
        private DonutChart _fundedPrepFeesChart;
        public DonutChart FundedPrepFeesChart
        {
            get => _fundedPrepFeesChart;
            private set
            {
                _fundedPrepFeesChart = value;
                OnPropertyChanged(nameof(FundedPrepFeesChart));
            }
        }

        private LineChart _monthlyPerformanceChart;
        public LineChart MonthlyPerformanceChart
        {
            get => _monthlyPerformanceChart;
            private set
            {
                _monthlyPerformanceChart = value;
                OnPropertyChanged(nameof(MonthlyPerformanceChart));
            }
        }

        public List<ChartEntry> ChartEntries { get; set; }


        public DashboardViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            var source = new List<Entry>();
            var entry = new Entry(200)
            {
                Label = "Funded prep fees",
                Color = SKColor.Parse("#00CED1"),
                ValueLabel = "$12k"
            };

            var entry2 = new Entry(400)
            {
                Label = "Funded prep fees",
                Color = SKColor.Parse("#68B9C0"),
                ValueLabel = "$12k"
            };

            var entry3 = new Entry(400)
            {
                Label = "UNFunded prep fees",
                Color = SKColor.Parse("#00FF40"),
                ValueLabel = "$12k"
            };

            source.Add(entry);
            source.Add(entry2);
            source.Add(entry3);
            FundedPrepFeesChart = new Microcharts.DonutChart() { Entries = source };


            var source1 = new List<Entry>();
            var entry4 = new Entry(200)
            {
                Label = "Funded prep fees",
                Color = SKColor.Parse("#00CED1"),
                
            };

            var entry5 = new Entry(400)
            {
                Label = "Funded prep fees",
                Color = SKColor.Parse("#68B9C0"),
                
            };

            var entry6 = new Entry(400)
            {
                Label = "UNFunded prep fees",
                Color = SKColor.Parse("#00FF40"),
                
            };

            var entry7 = new Entry(100)
            {
                Label = "UNFunded prep fees",
                Color = SKColor.Parse("#00FF40"),
                ValueLabel = "$12k"
            };

            source1.Add(entry4);
            source1.Add(entry5);
            source1.Add(entry6);
            source1.Add(entry7);
            MonthlyPerformanceChart = new LineChart{ Entries = source1 };

            ChartEntries = new List<ChartEntry>();
            ChartEntries.Add(new ChartEntry(45, SKColors.Red));
            ChartEntries.Add(new ChartEntry(13, SKColors.Green));
            ChartEntries.Add(new ChartEntry(27, SKColors.Blue));
            ChartEntries.Add(new ChartEntry(19, SKColors.Magenta));
            ChartEntries.Add(new ChartEntry(40, SKColors.Cyan));
            ChartEntries.Add(new ChartEntry(22, SKColors.Brown));
            ChartEntries.Add(new ChartEntry(29, SKColors.Gray));

        }
    }
}
