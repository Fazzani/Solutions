using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Xml;
using XMLManipulator.Outils;

namespace XMLManipulator.Converter
{
    public class XmlPatternToBoolConverter : IValueConverter
    {

        #region IValueConverter Membres

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                if (ApplicationStaticValues.XmlDocumentPattern == null)
                {
                    ApplicationStaticValues.XmlDocumentPattern = new XmlDocument();
                    ApplicationStaticValues.XmlDocumentPattern.Load(ApplicationStaticValues.XmlPattern);
                }
                if (value == null)
                    return Visibility.Collapsed;
                if (value != null && value is XmlElement)
                {
                    XmlElement element = value as XmlElement;
                    XmlNode node = ApplicationStaticValues.XmlDocumentPattern.SelectSingleNode("//" + element.Name);
                    if (node == null || node.Attributes["display"] == null)
                        return Visibility.Collapsed;

                    return node.Attributes["display"].Value.Equals("1") ? Visibility.Visible : Visibility.Collapsed;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "  " + Path.Combine(Environment.CurrentDirectory, ConfigurationManager.AppSettings["FileNamePattern"]));
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
