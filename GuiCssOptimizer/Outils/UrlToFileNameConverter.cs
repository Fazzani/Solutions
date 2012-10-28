using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace GuiCssOptimizer.Outils
{
  public class UrlToFileNameConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
    return  StringExtension.ConvertUrlToFileNameCss(value.ToString());
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      return null;
    }

   
  }

  public class UrlToFileNameConverterMulti : IMultiValueConverter
  {
    #region IMultiValueConverter Membres

    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
      if (values != null)
        return string.Concat(values).RemoveDiacriticsAndWhiteSpace() + ".css";
      return string.Empty;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
  //   return Enumerable.Repeat(value, 1).ToArray();
      return null;
    }
    
    #endregion

    
  }
}
