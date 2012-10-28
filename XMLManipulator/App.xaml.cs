using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace XMLManipulator
{
  /// <summary>
  /// Logique d'interaction pour App.xaml
  /// </summary>
  public partial class App : Application
  {
    public App()
    {
      AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
    }

    void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      Exception exception = e.ExceptionObject as Exception;
      MessageBox.Show(exception.Message, "ERROR",
                      MessageBoxButton.OK, MessageBoxImage.Error);
    }
    protected override void OnExit(ExitEventArgs e)
    {
      base.OnExit(e);
    }

   
  }
}
