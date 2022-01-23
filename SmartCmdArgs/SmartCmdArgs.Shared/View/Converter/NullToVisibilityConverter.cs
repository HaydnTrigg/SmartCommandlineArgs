﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCmdArgs.View.Converter
{
    class NullToVisibilityConverter : ConverterBase
    {
        public NullToVisibilityConverter()
        { }

        public bool Inverted { get; set; }

        public System.Windows.Visibility HideVisibility { get; set; } = System.Windows.Visibility.Hidden;

        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (Inverted)
                return value != null ? HideVisibility : System.Windows.Visibility.Visible;
            else
                return value == null ? HideVisibility : System.Windows.Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
