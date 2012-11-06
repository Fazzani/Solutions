using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using XMLManipulator.Outils;

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
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if (e.Args.Count() > 0 && File.Exists(e.Args[0]))
                ApplicationStaticValues.FileNameArgs = e.Args[0];
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
