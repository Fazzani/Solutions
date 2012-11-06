using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;

namespace XMLManipulator.Outils
{
    public class DTXmlElementSelector : DataTemplateSelector
    {
        public DataTemplate TextTemplate { get; set; }
        public DataTemplate XmlNodesTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            ContentPresenter presenter = container as ContentPresenter;
            DataGridCell cell = presenter.Parent as DataGridCell;

            if (cell.DataContext is XmlElement)
            {
                XmlElement elem = cell.DataContext as XmlElement;
                if(App.Current.MainWindow.Resources.Contains(elem.Name.ToUpperInvariant()))
                    return App.Current.MainWindow.Resources[elem.Name] as DataTemplate;
                return string.IsNullOrEmpty(elem.InnerText) && elem.InnerText.Equals(elem.InnerXml) && elem.HasAttributes ? XmlNodesTemplate : TextTemplate;
            }
            return TextTemplate;
        }
    }
}
