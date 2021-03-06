﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Xml;

namespace XMLManipulator.Outils
{
  public class DemoAttachedProps
  {
    public static DependencyProperty SelectedItemProperty = DependencyProperty.RegisterAttached("SelectedItem", typeof(object), typeof(DemoAttachedProps), new PropertyMetadata(new object(), OnSelectedItemChanged));
    static object _newValue;

    public static object GetSelectedItem(TreeView treeView)
    {
      return treeView.GetValue(SelectedItemProperty);
    }

    public static void SetSelectedItem(TreeView treeView, object value)
    {
      treeView.SetValue(SelectedItemProperty, value);
    }

    private static void OnSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
    {
      var treeView = d as TreeView;
      if (treeView == null)
        return;
      _newValue = args.NewValue;
      treeView.Loaded += treeView_Loaded;
    }

    static void treeView_Loaded(object sender, RoutedEventArgs e)
    {
        
        var treeView = sender as TreeView;

        treeView.SelectedItemChanged -= TreeViewItemChanged;
        var treeViewItem = SelectTreeViewItemForBinding(_newValue, treeView);
        if (treeViewItem != null)
            treeViewItem.IsSelected = true;

        treeView.SelectedItemChanged += TreeViewItemChanged;
    }

    private static void TreeViewItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
      ((TreeView)sender).SetValue(SelectedItemProperty, e.NewValue);
    }

    private static TreeViewItem SelectTreeViewItemForBinding(object dataItem, ItemsControl ic)
    {
      if (ic == null || dataItem == null)
        return null;

      IItemContainerGenerator generator = ic.ItemContainerGenerator;
      using (generator.StartAt(generator.GeneratorPositionFromIndex(-1), GeneratorDirection.Forward))
      {
        foreach (var t in ic.Items)
        {
          bool isNewlyRealized;
          var tvi = generator.GenerateNext(out isNewlyRealized);
          if (isNewlyRealized)
            generator.PrepareItemContainer(tvi);

          if (t == dataItem)
            return tvi as TreeViewItem;

          var tmp = SelectTreeViewItemForBinding(dataItem, tvi as ItemsControl);
          if (tmp != null)
            return tmp;
        }
      }
      return null;
    }

  }
}

