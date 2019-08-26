// ---------------------------------------------------------------------
// <copyright file="CtlVParseStringResults.cs" company="Matthew K. Crandall - N/A">
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
  /// Class to display a <see cref="ParseStringResults"/>.
  /// </summary>
  public partial class CtlVParseStringResults : UserControl
  {
    /// <summary>
    /// Internally stores the cached <see cref="ParseStringResults"/>.
    /// </summary>
    private ParseStringResults cachedResults = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="CtlVParseStringResults"/> class.
    /// <para>Default Constructor.</para>
    /// </summary>
    public CtlVParseStringResults()
    {
      this.InitializeComponent();
    }

    /// <summary>
    /// Gets or sets the <see cref="ParseStringResults"/> embedded in this <see cref="CtlVParseStringResults"/> controls.
    /// </summary>
    public ParseStringResults ResultsOnScreen
    {
      get
      {
        return this.cachedResults;
      }

      set
      {
        if (value != this.cachedResults)
        {
          this.cachedResults = value;
          this.RefreshScreenForResults();
        }
      }
    }

    /// <summary>
    /// Helper-method to refresh the controls on this <see cref="CtlVParseStringResults"/> for the cached <see cref="ParseStringResults"/>.
    /// </summary>
    private void RefreshScreenForResults()
    {
      if (this.cachedResults == null)
      {
        // handle null
        this.rtbxInputString.Text = string.Empty;
        this.rtbxErrorMessage.Text = string.Empty;
        this.rtbxEvalStatements.Text = string.Empty;
        this.cbxError.Checked = false;
        this.cbxValidated.Checked = false;
        this.tbxOffendingCharacter.Text = string.Empty;
        this.tbxOffendingIndex.Text = string.Empty;
      }
      else
      {
        // handle non-null
        this.rtbxInputString.Text = this.cachedResults.Input;
        this.rtbxErrorMessage.Text = this.cachedResults.ErrorMessage;
        this.rtbxEvalStatements.Text = string.Join(Environment.NewLine, this.cachedResults.EvalStatements);
        this.cbxError.Checked = this.cachedResults.HadError;
        this.cbxValidated.Checked = this.cachedResults.Validated;
        this.tbxOffendingCharacter.Text = this.cachedResults.IllegalChar.ToString();
        this.tbxOffendingIndex.Text = this.cachedResults.IllegalCharIndex.ToString();
      }
    }
  }
}