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
    public sealed class XmlElementToTabIndexConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is XmlElement)
            {
                XmlElement elem = value as XmlElement;
                if (elem.HasAttributes)
                    return 1;
                return elem.HasChildNodes && !(elem.ChildNodes.Count == 1 && elem.ChildNodes[0].NodeType != XmlNodeType.Element) ? 0 : 2;
            }
            return 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Equals(value, Visibility.Visible);
        }
    }
}
