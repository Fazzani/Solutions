using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using CssOptimizer;
using Microsoft.Win32;

namespace GuiCssOptimizer
{
  /// <summary>
  /// Logique d'interaction pour MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private SynchronizationContext _current = SynchronizationContext.Current;
    public CssOptimizerModel Model { get; set; }

    public MainWindow()
    {
      InitializeComponent();
      Model = new CssOptimizerModel();
      DataContext = Model;
      CssOptimizer.CssOptimizer.OnTreatmentComplete += CssOptimizer_OnTreamentComplete;
    }

    //private void Button_Click_1(object sender, RoutedEventArgs e)
    //{
    //  Microsoft.Win32.OpenFileDialog sfd = new OpenFileDialog();
    //  sfd.DefaultExt = ".css";
    //  sfd.Filter = "Css documents (.css)|*.css";
    //  // Show save file dialog box
    //  Nullable<bool> result = sfd.ShowDialog();
    //  if (result.HasValue && result.Value)
    //    FileNameTxt.Text = sfd.FileName;
    //}

    private void Button_Click_2(object sender, RoutedEventArgs e)
    {

      if (Model == null)
        Model = new CssOptimizerModel();

      Task.Run(() => CssOptimizer.CssOptimizer.OptimizeSite(Model, _current));
    }

    void CssOptimizer_OnTreamentComplete(object sender, EventArgs e)
    {
      CssOptimizerModel model = (CssOptimizerModel)sender;
      MessageBox.Show(string.Format("Opération réussite avec un ratio de compression de {0}%", model.RatioOfCompression.ToString()), "Fin du traitement", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void btnAddUrl_Click(object sender, RoutedEventArgs e)
    {
      if (Model.ListUrl == null)
        Model.ListUrl = new ObservableCollection<Url>();

      Model.ListUrl.Add(new Url(txtUrl.Text, StringExtension.ConvertUrlToFileNameCss(txtUrl.Text)));

      txtUrl.Text = string.Empty;
    }
  }

}
