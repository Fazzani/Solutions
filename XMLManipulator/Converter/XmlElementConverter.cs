using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml;

namespace XMLManipulator.Converter
{
  public class XmlElementConverter : IValueConverter
  {
    #region IValueConverter Membres

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      if (value == null)
        return null;
      return (value  as XmlElement).InnerXml.Replace("<", Environment.NewLine + "<").Trim();
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
