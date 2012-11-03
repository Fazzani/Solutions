using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Xml;

namespace XMLManipulator.Converter
{
  public class XmlPatternToBoolConverter : IValueConverter
  {
    XmlDocument _xmlDocument;

     #region IValueConverter Membres

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      _xmlDocument = new XmlDocument();
      _xmlDocument.Load(ConfigurationManager.AppSettings["FileNamePattern"]);
      if (value == null)
          return Visibility.Collapsed;
      if (value != null && value is XmlElement)
      {
        XmlElement element = value as XmlElement;
        XmlNode node = _xmlDocument.SelectSingleNode("//" + element.Name);
        if (node == null || node.Attributes["display"] == null)
            return Visibility.Collapsed;

        return node.Attributes["display"].Value.Equals("1") ? Visibility.Visible : Visibility.Collapsed;
      }
      return Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
