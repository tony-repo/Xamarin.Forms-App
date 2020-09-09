using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoApp.Utility
{
    public static class ListExtension
    {
        public static ObservableCollection<T> ConvertToObservableCollection<T>(this List<T> listData)
        {
            return new ObservableCollection<T>(listData);
        }

        public static ObservableCollection<T> ConvertToObservableCollection<T>(this IEnumerable<T> enumerableData)
        {
            return new ObservableCollection<T>(enumerableData);
        }
    }
}
