﻿// ---------------------------------------------------------------------
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

  using AutomataTesting;

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

      StringBuilder result = new StringBuilder();

      foreach (string s in this.rtbxStringsToEval.Lines)
      {
        try
        {
          bool resuly = AutomatonEvaluator.EvalAutomaton(a, s);
          result.AppendLine(resuly.ToString());
        }
        catch (Exception ex)
        {
          result.AppendLine(ex.ToString());
        }
      }

      MessageBox.Show(result.ToString());
    }
  }
}