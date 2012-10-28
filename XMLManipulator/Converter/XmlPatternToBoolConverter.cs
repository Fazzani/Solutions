using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        return null;
      if (value != null && value is XmlElement)
      {
        XmlElement element = value as XmlElement;
        XmlNode node = _xmlDocument.SelectSingleNode("//" + element.Name);
        if (node == null || node.Attributes["display"] == null)
          return "Hidden";

        return node.Attributes["display"].Value.Equals("1") ? "Visible" : "Hidden";
      }
      return "Hidden";
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
