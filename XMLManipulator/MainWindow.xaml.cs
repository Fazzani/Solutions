using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using XMLManipulator.Outils;
using XMLManipulator.ViewModel;

namespace XMLManipulator
{

  /// <summary>
  /// Logique d'interaction pour MainWindow.xaml
  /// </summary>
  public partial class MainWindow
  {
    XmlDataProvider _universProvider;

    public MainWindow()
    {
      try
      {
        InitializeComponent();
        _universProvider = FindResource("Univers") as XmlDataProvider;
        var xmlDocument = new XmlDocument();

        if (Application.Current.Properties.Contains(ApplicationStaticValues.LastOpenedFilePath))
        { //Application.Current.Properties.Add(ApplicationStaticValues.LastOpenedFilePath, ConfigurationManager.AppSettings["FileName"]);

          xmlDocument.Load(Application.Current.Properties[ApplicationStaticValues.LastOpenedFilePath].ToString());
          _universProvider.Document = xmlDocument;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    
    }

  }
}
