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
            if (!string.IsNullOrEmpty(ApplicationStaticValues.FileNameArgs))
                LoadXmlFile(ApplicationStaticValues.FileNameArgs);
            else
                if (!string.IsNullOrEmpty(Properties.Settings.Default[ApplicationStaticValues.LastOpenedFilePath].ToString()))
                {
                    string filePath = System.IO.Path.GetFullPath(Properties.Settings.Default[ApplicationStaticValues.LastOpenedFilePath].ToString());
                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                        LoadXmlFile(filePath);
                }
        }

        private void LoadXmlFile(string filePath)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            _universProvider.Document = xmlDocument;
            new ViewModelLocator().MainMV.FilePath = filePath;
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

        #region Drag And Drop
        private Point startPoint;

        private void Tree_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void Tree_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var mousePos = e.GetPosition(null);
                var diff = startPoint - mousePos;

                if (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance
                    || Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    var treeView = sender as TreeView;
                    var treeViewItem =
                        FindAnchestor<TreeViewItem>((DependencyObject)e.OriginalSource);

                    if (treeView == null || treeViewItem == null)
                        return;

                    var xmlElem = treeView.SelectedItem as XmlElement;
                    if (xmlElem == null)
                        return;

                    var dragData = new DataObject(xmlElem);
                    DragDrop.DoDragDrop(treeViewItem, dragData, DragDropEffects.Move);
                }
            }
        }

        private void DropTree_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(XmlElement)))
                e.Effects = DragDropEffects.None;
        }

        private void DropTree_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(XmlElement)))
            {
                var xmlElemOrigin = e.Data.GetData(typeof(XmlElement)) as XmlElement;
                var treeViewItem = FindAnchestor<TreeViewItem>((DependencyObject)e.OriginalSource);

                var dropTarget = treeViewItem.Header as XmlElement;

                if (dropTarget == null || xmlElemOrigin == null || !xmlElemOrigin.Name.Equals(dropTarget.Name))
                    return;
                dropTarget.AppendChild(xmlElemOrigin);
                treeViewItem.IsExpanded = true;
                treeViewItem.IsSelected = true;
            }
        }

        private static T FindAnchestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                    return (T)current;
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        #endregion
    }
}
