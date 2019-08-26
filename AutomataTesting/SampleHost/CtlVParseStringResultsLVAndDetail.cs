// ---------------------------------------------------------------------
// <copyright file="CtlVParseStringResultsLVAndDetail.cs" company="Matthew K. Crandall - N/A">
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
  /// Control for viewing parse string results in hybrid listview (for set) and singleton view.
  /// </summary>
  public partial class CtlVParseStringResultsLVAndDetail : UserControl
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CtlVParseStringResultsLVAndDetail"/> class.
    /// <para>Default Constructor.</para>
    /// </summary>
    public CtlVParseStringResultsLVAndDetail()
    {
      this.InitializeComponent();
    }

    /// <summary>
    /// Gets or sets the <see cref="ParseStringResults"/> embedded on screen.
    /// </summary>
    public List<ParseStringResults> ParseStringResultsOnControls
    {
      get
      {
        return this.ctlVParseStringResultsInLV1.ResultsInLV;
      }

      set
      {
        if (value != this.ctlVParseStringResultsInLV1.ResultsInLV)
        {
          this.ctlVParseStringResultsInLV1.ResultsInLV = value;

          if (value != null && value.Count > 0)
          {
            this.ctlVParseStringResults1.ResultsOnScreen = value[0];
          }
          else
          {
            this.ctlVParseStringResults1.ResultsOnScreen = null;
          }
        }
      }
    }

    /// <summary>
    /// ParseStringResultsSelectedHandler for internal controls.
    /// </summary>
    /// <param name="sender">The sender for the event.</param>
    /// <param name="e">The <see cref="ParseStringResultsEventArgs"/> for the event.</param>
    private void CtlVParseStringResultsInLV1_ParseStringResultsSelectedHandler(object sender, ParseStringResultsEventArgs e)
    {
      this.ctlVParseStringResults1.ResultsOnScreen = e.Argument;
    }
  }
}