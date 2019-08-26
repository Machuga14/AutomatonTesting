// ---------------------------------------------------------------------
// <copyright file="CtlVParseStringResultsInLV.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace SampleHost
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Data;
  using System.Drawing;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Forms;

  using AutomataTesting.Engine;

  /// <summary>
  /// <see cref="CtlVParseStringResultsInLV"/> for viewing <see cref="ParseStringResults"/> in a <see cref="ListView"/> control.
  /// </summary>
  public partial class CtlVParseStringResultsInLV : UserControl
  {
    /// <summary>
    /// Private storage for the results.
    /// </summary>
    private List<ParseStringResults> cachedResultsList = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="CtlVParseStringResultsInLV"/> class.
    /// </summary>
    public CtlVParseStringResultsInLV()
    {
      this.InitializeComponent();
    }

    /// <summary>
    /// Event to be fired relating to a <see cref="ParseStringResultsEventArgs"/>.
    /// </summary>
    public event ParseStringResultsDelegate ParseStringResultsSelectedHandler;

    /// <summary>
    /// Gets or sets the <see cref="ParseStringResults"/> embedded in this screen's controls.
    /// </summary>
    public List<ParseStringResults> ResultsInLV
    {
      get
      {
        return this.cachedResultsList;
      }

      set
      {
        if (value != this.cachedResultsList)
        {
          this.cachedResultsList = value;
          this.lvParseStringResults.RebuildListViewWithDelegate(this.cachedResultsList, this.MapParseStringResultsToLV);
        }
      }
    }

    /// <summary>
    /// Helper mapper function to translate a <see cref="ParseStringResults"/> onto a visual display of a <see cref="ListViewItem"/>.
    /// </summary>
    /// <param name="p">The <see cref="ParseStringResults"/> to display on a <see cref="ListViewItem"/>.</param>
    /// <param name="l">The <see cref="ListViewItem"/> to render the corresponding <see cref="ParseStringResults"/> on.</param>
    private void MapParseStringResultsToLV(ParseStringResults p, ListViewItem l)
    {
      l.EnsureListViewItemHasNItems(1);
      l.SubItems[0].Text = p.Input;
    }

    /// <summary>
    /// SelectedIndexChangedEventHandler for the <see cref="ListView"/> to display <see cref="ParseStringResults"/>.
    /// </summary>
    /// <param name="sender">The sender for the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> for the event.</param>
    private void LvParseStringResults_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.lvParseStringResults.SelectedItems.Count > 0)
      {
        this.ParseStringResultsSelectedHandler?.Invoke(sender, new ParseStringResultsEventArgs(this.lvParseStringResults.SelectedItems[0].Tag as ParseStringResults));
      }
      else
      {
        // null fire means deselect.
        this.ParseStringResultsSelectedHandler?.Invoke(sender, new ParseStringResultsEventArgs(null));
      }
    }
  }
}