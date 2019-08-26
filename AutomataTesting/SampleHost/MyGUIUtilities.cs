// ---------------------------------------------------------------------
// <copyright file="MyGUIUtilities.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace SampleHost
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Forms;

  /// <summary>
  /// <see langword="static"/> class with utilities for GUI libraries.
  /// </summary>
  public static class MyGUIUtilities
  {
    /// <summary>
    /// Rebuilds a ListView with a delegate provided.
    /// </summary>
    /// <typeparam name="T">type of object to rebuild.</typeparam>
    /// <param name="lv">The ListView to rebuild.</param>
    /// <param name="items">The List of Items to represent in a ListView.</param>
    /// <param name="refreshItem">Action on how to refresh a ListViewItem.</param>
    public static void RebuildListViewWithDelegate<T>(this ListView lv, IEnumerable<T> items, Action<T, ListViewItem> refreshItem)
    {
      lv.BeginUpdate();
      lv.Items.Clear();

      if (items != null)
      {
        foreach (T t in items)
        {
          lv.Items.Add(ConstructListViewItemOffItem(t, refreshItem));
        }
      }

      lv.EndUpdate();
    }

    /// <summary>
    /// Refreshes the ListView provided.
    /// </summary>
    /// <typeparam name="T">The tpye of object to refresh.</typeparam>
    /// <param name="lv">ListView to refresh.</param>
    /// <param name="actionForUpdatingTextOnListViewItem">Action for updating text on a <see cref="ListViewItem"/>.</param>
    public static void RefreshListView<T>(this ListView lv, Action<T, ListViewItem> actionForUpdatingTextOnListViewItem)
    {
      lv.BeginUpdate();
      lv.Items.Clear();

      foreach (ListViewItem itm in lv.Items)
      {
        actionForUpdatingTextOnListViewItem((T)itm.Tag, itm);
      }

      lv.EndUpdate();
    }

    /// <summary>
    /// Constructs a <see cref="ListViewItem"/> to represent the provided T.
    /// </summary>
    /// <typeparam name="T">The type object to construct a <see cref="ListViewItem"/> for.</typeparam>
    /// <param name="t">The object to construct a <see cref="ListViewItem"/> for.</param>
    /// <param name="refreshItem">Action for refreshing the list view item.</param>
    /// <returns>a <see cref="ListViewItem"/> representing the provided T.</returns>
    public static ListViewItem ConstructListViewItemOffItem<T>(T t, Action<T, ListViewItem> refreshItem)
    {
      ListViewItem itm = new ListViewItem();
      itm.Tag = t;
      refreshItem(t, itm);
      return itm;
    }

    /// <summary>
    /// Refreshes a <see cref="ListViewItem"/> for the provided Item's tag.
    /// </summary>
    /// <typeparam name="T">The Type of object to cast the tag to.</typeparam>
    /// <param name="itm">The <see cref="ListViewItem"/> to refresh.</param>
    /// <param name="refreshItem">Action for refreshing the list view item.</param>
    public static void RefreshItemForTag<T>(this ListViewItem itm, Action<T, ListViewItem> refreshItem)
    {
      refreshItem((T)itm.Tag, itm);
    }

    /// <summary>
    /// Ensures a <see cref="ListViewItem"/> has N items.
    /// </summary>
    /// <param name="itm">The <see cref="ListViewItem"/> to ensure has N items.</param>
    /// <param name="n">the # of items to ensure the <see cref="ListViewItem"/> has.</param>
    public static void EnsureListViewItemHasNItems(this ListViewItem itm, int n)
    {
      for (int i = itm.SubItems.Count; i < n; i++)
      {
        itm.SubItems.Add(string.Empty);
      }
    }

    /// <summary>
    /// Displays the provided <see cref="UserControl"/> in a form, anchored and centered.
    /// </summary>
    /// <param name="ctl">The <see cref="UserControl"/> to display within a Form.</param>
    /// <param name="formText">The text for the form.</param>
    /// <param name="modal">True if the dialog is displayed modal, False if the dialog is displayed non-modal (returns the form).</param>
    /// <returns>The reference to the form which was generated to display the <see cref="UserControl"/>. Will be disposed if modal is true.</returns>
    public static Form DisplayUserControlInForm(this UserControl ctl, string formText, bool modal)
    {
      if (ctl == null)
      {
        throw new ArgumentNullException(string.Format("The provided UserControl was null."));
      }

      Form renderedForm = new Form
      {
        Text = formText,
        ClientSize = ctl.Size,
        StartPosition = FormStartPosition.CenterScreen,
      };

      ctl.Location = new System.Drawing.Point(0, 0);
      ctl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      renderedForm.Controls.Add(ctl);

      if (modal)
      {
        renderedForm.ShowDialog();
      }
      else
      {
        renderedForm.Show();
      }

      return renderedForm;
    }
  }
}