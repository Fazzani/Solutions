using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Deployment.Application;
using System.IO;
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
    /// <summary>
    /// Provider Univers.Xml
    /// </summary>
    XmlDataProvider _universProvider;

    public MainWindow()
    {
      try
      {
        InitializeComponent();
        _universProvider = FindResource("Univers") as XmlDataProvider;

        this.Closing += MainWindow_Closing;
        Init();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    /// <summary>
    /// Init App
    /// </summary>
    void Init()
    {
      if (!string.IsNullOrEmpty(Properties.Settings.Default[ApplicationStaticValues.LastOpenedFilePath].ToString()))
      {
        var xmlDocument = new XmlDocument();
        string filePath = System.IO.Path.GetFullPath(Properties.Settings.Default[ApplicationStaticValues.LastOpenedFilePath].ToString());
        if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
        {
          xmlDocument.Load(filePath);
          _universProvider.Document = xmlDocument;
          new ViewModelLocator().MainMV.FilePath = filePath;
         
        }
      }
    }

    /// <summary>
    /// On Closing App
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (_universProvider != null && _universProvider.Document != null)
      {
        Properties.Settings.Default[ApplicationStaticValues.LastOpenedFilePath] = new Uri(_universProvider.Document.BaseURI).LocalPath;
        Properties.Settings.Default.Save();
      }
    }

    private void TxtValueGrid_LostFocus(object sender, RoutedEventArgs e)
    {
      var txtbox = sender as TextBox;
      if (txtbox.DataContext is XmlAttribute)
      {
        XmlAttribute xmlAttr = txtbox.DataContext as XmlAttribute;
        if (!xmlAttr.Value.Equals(txtbox.Text))
          xmlAttr.Value = txtbox.Text;
      }
    }
  }
}
