﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfChartSample
{
    public class ChartConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (System.Convert.ToDouble(value) >= 35)
            {
                return "warmselected.png";
            }
            else if (System.Convert.ToDouble(value) < 35 && System.Convert.ToDouble(value) > 25)
            {
                return "Cloudy.png";
            }
            else
            {
                return "Rainy1.png";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
