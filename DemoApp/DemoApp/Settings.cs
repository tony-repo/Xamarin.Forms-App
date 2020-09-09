using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace DemoApp
{
    public static class Settings
    {
        private static ISettings _settings;
        public static ISettings AppSettings
        {
            get
            {
                if (CrossSettings.IsSupported && _settings == null)
                    _settings = CrossSettings.Current;

                return _settings;
            }
        }
    }
}
