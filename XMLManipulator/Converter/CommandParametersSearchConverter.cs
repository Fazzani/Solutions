using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml;
using XMLManipulator.ViewModel;

namespace XMLManipulator.Converter
{
  public class CommandParametersSearchConverter : IMultiValueConverter
  {

    #region IMultiValueConverter Membres

    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      if (values != null && values.Count() >= 2)
        return new CommandParametersSearch { Text = values[0].ToString(), TreeView = values[1] as TreeView };
      return null;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
