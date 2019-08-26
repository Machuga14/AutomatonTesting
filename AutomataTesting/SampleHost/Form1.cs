// ---------------------------------------------------------------------
// <copyright file="Form1.cs" company="Matthew K. Crandall - N/A">
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
  /// Form class hosting the AutomataTesting.Engine.
  /// For the most part, most functionality for phase 1 of this prototype solution was written in about 30 minutes or so.
  /// </summary>
  public partial class Form1 : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// <para>Default Constructor.</para>
    /// </summary>
    public Form1()
    {
      this.InitializeComponent();
      this.rtbxAutomaton.Text = @"
E={a|O,b|O},true
O={a|E,b|E},false".Trim();

      this.rtbxStringsToEval.Text = @"
abbabaababbaabba
a
abb
abbb".Trim();
    }

    /// <summary>
    /// ButtonClickEvent to parse the <see cref="Automaton"/>.
    /// </summary>
    /// <param name="sender">The sender for the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> for the event.</param>
    private void BtnParse_Click(object sender, EventArgs e)
    {
      Automaton a = AutomatonParser.ParseAutomaton(this.rtbxAutomaton.Text);
      MessageBox.Show("Automaton parsed successfully.");
    }

    /// <summary>
    /// ButtonClickEvent to evaluate the set of sentences with the <see cref="Automaton"/> defined.
    /// </summary>
    /// <param name="sender">The sender for the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> for the event.</param>
    private void BtnEval_Click(object sender, EventArgs e)
    {
      Automaton a = AutomatonParser.ParseAutomaton(this.rtbxAutomaton.Text);
      List<ParseStringResults> allResults = new List<ParseStringResults>();

      foreach (string s in this.rtbxStringsToEval.Lines)
      {
        try
        {
          ParseStringResults currResults = AutomatonEvaluator.EvalAutomaton(a, s);
          allResults.Add(currResults);
        }
        catch (Exception)
        {
          // MATTHEWC: TODO: Maybe report errors separately?
          // Maybe dummy up a ParseStringResults with error data?
        }
      }

      CtlVParseStringResultsLVAndDetail disp = new CtlVParseStringResultsLVAndDetail();
      disp.ParseStringResultsOnControls = allResults;
      MyGUIUtilities.DisplayUserControlInForm(disp, "Evaluated Strings via Automata", true);
    }
  }
}