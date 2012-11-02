using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Xml;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Tools;
using Xceed.Wpf.Toolkit;
using XMLManipulator.Outils;

namespace XMLManipulator.ViewModel
{
    /// <summary>
    /// MainModelView
    /// </summary>
    public class MainModelView : ViewModelBase
    {

        public MainModelView()
        {
            CreateSaveCommand();
            CreateSaveAsCommand();
            CreateSearchCommand();
            CreateDeleteCommand();
            CreateAddCommand();
            CreateOpenCommand();
        }

        #region Save Command

        public ICommand SaveCommand
        {
            get;
            internal set;
        }

        private void CreateSaveCommand()
        {
            SaveCommand = new RelayCommand<XmlDataProvider>(SaveExecute, CanExecuteSaveCommand);
        }

        private bool CanExecuteSaveCommand(XmlDataProvider xml)
        {
            return xml != null && xml.Document != null;
        }

        public void SaveExecute(XmlDataProvider xml)
        {
            if (Xceed.Wpf.Toolkit.MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                xml.Document.Save(xml.Document.BaseURI.Replace(@"file:///", string.Empty));
        }
        #endregion

        #region SaveAs Command

        public ICommand SaveAsCommand
        {
            get;
            internal set;
        }

        private void CreateSaveAsCommand()
        {
            SaveAsCommand = new RelayCommand<XmlDataProvider>(SaveAsExecute, CanExecuteSaveAsCommand);
        }

        private bool CanExecuteSaveAsCommand(XmlDataProvider xml)
        {
            return xml != null && xml.Document != null;
        }

        public void SaveAsExecute(XmlDataProvider xml)
        {
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();

            if ((bool)sfd.ShowDialog())
                xml.Document.Save(sfd.FileName);
        }
        #endregion

        #region Open Command

        public ICommand OpenCommand
        {
            get;
            internal set;
        }

        private void CreateOpenCommand()
        {
            OpenCommand = new RelayCommand<XmlDataProvider>(OpenExecute, CanExecuteOpenCommand);
        }

        private bool CanExecuteOpenCommand(XmlDataProvider xml)
        {
            return xml != null;
        }

        public void OpenExecute(XmlDataProvider xml)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog openDialog = new Microsoft.Win32.OpenFileDialog();

                if ((bool)openDialog.ShowDialog())
                {
                    if (xml.Document == null)
                        xml.Document = new XmlDocument();
                    xml.Document.Load(openDialog.FileName);
                    xml.Refresh();
                    if (!Application.Current.Properties.Contains(ApplicationStaticValues.LastOpenedFilePath))
                        Application.Current.Properties.Add(ApplicationStaticValues.LastOpenedFilePath, openDialog.FileName);
                    else
                        Application.Current.Properties[ApplicationStaticValues.LastOpenedFilePath] = openDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(ex.Message, "Exception");
            }
        }
        #endregion

        #region Search Command

        public ICommand SearchCommand
        {
            get;
            internal set;
        }

        private bool CanExecuteSearchCommand(CommandParametersSearch parameters)
        {
            return parameters != null && parameters.TreeView != null && !string.IsNullOrEmpty(parameters.Text);
        }

        private void CreateSearchCommand()
        {
            SearchCommand = new RelayCommand<CommandParametersSearch>(SearchExecute, CanExecuteSearchCommand);
        }

        public void SearchExecute(CommandParametersSearch parameters)
        {
            (parameters.TreeView.Items as ItemCollection).Filter = x =>
            {
                if (x != null && x is XmlElement)
                {
                    XmlElement element = x as XmlElement;
                    if (element != null)
                        return element.Name.ToLowerInvariant().Contains(parameters.Text.ToLowerInvariant()) || (element.HasChildNodes && element.InnerText.ToLowerInvariant().Contains(parameters.Text.ToLowerInvariant()));
                }
                return true;
            };
        }

        #endregion

        #region Delete Command

        public ICommand DeleteCommand
        {
            get;
            internal set;
        }

        private bool CanExecuteDeleteCommand(TreeView treeView)
        {
            return treeView != null && treeView.SelectedItem != null;
        }

        private void CreateDeleteCommand()
        {
            DeleteCommand = new RelayCommand<TreeView>(DeleteExecute, CanExecuteDeleteCommand);
        }

        public void DeleteExecute(TreeView treeView)
        {
            XmlNode item = treeView.SelectedItem as XmlNode;
            item.ParentNode.RemoveChild(item);
        }
        #endregion

        #region Add Command

        public ICommand AddCommand
        {
            get;
            internal set;
        }

        private bool CanExecuteAddCommand(TreeView treeView)
        {
            return treeView != null && treeView.SelectedItem != null;
        }

        private void CreateAddCommand()
        {
            AddCommand = new RelayCommand<TreeView>(AddExecute, CanExecuteAddCommand);
        }

        public void AddExecute(TreeView treeView)
        {
            XmlNode item = treeView.SelectedItem as XmlNode;
            item.ParentNode.AppendChild(item.OwnerDocument.CreateNode(XmlNodeType.Element, "DIMENSION_NODE", null));
        }
        #endregion

    }

    /// <summary>
    /// CommandParametersSearch
    /// </summary>
    public class CommandParametersSearch
    {
        public TreeView TreeView
        {
            set;
            get;
        }
        public string Text
        {
            set;
            get;
        }

    }
}
