using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Xml;

namespace XMLManipulator.Converter
{
  [ValueConversion(typeof(bool), typeof(Visibility))]
  public sealed class XmlElementToVisibiltyConverter : IValueConverter
  {
    readonly Visibility _trueValue = Visibility.Visible;
    readonly Visibility _falseValue = Visibility.Collapsed;

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      if (value is XmlElement)
      {
        XmlElement elem = value as XmlElement;
        return !string.IsNullOrEmpty(elem.InnerText) && elem.InnerText.Equals(elem.InnerXml) ? _trueValue : _falseValue;
      }
      return _falseValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      return null;
    }

  }
}
