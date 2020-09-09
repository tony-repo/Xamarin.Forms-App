using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DemoApp.View;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    public class CarouselViewViewModel : BaseViewModel
    {
        public ICommand NextCommand { get; private set; }

        public ICommand SkipCommand { get; private set; }

        public ICommand CarouselItemChangedCommand { get; private set; }

        private int _carouseViewPosition;
        public int CarouseViewPosition
        {
            get => _carouseViewPosition;
            set
            {
                _carouseViewPosition = value;
                OnPropertyChanged(nameof(CarouseViewPosition));
            }
        }

        private int _indicatorPosition;
        public int IndicatorPosition
        {
            get => _indicatorPosition;
            set
            {
                _indicatorPosition = value;
                OnPropertyChanged(nameof(IndicatorPosition));
            }
        }

        public CarouselViewViewModel()
        {
            NextCommand = new Command(() =>
            {
                if (CarouseViewPosition == 2)
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    CarouseViewPosition++;
                }
            });

            SkipCommand = new Command(() =>
            {
                Application.Current.MainPage = new MainPage();
            });

            CarouselItemChangedCommand = new Command(() =>
            {
                IndicatorPosition = CarouseViewPosition;
            });

        }

    }
}
