using AutomataTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  // For the most part, most functionality was written in about 30 minutes or so.
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.rtbxAutomaton.Text = @"
E={a|O,b|O},true
O={a|E,b|E},false".Trim();

      this.rtbxStringsToEval.Text = @"
abbabaababbaabba
a
abb
abbb".Trim();
    }

    private void btnParse_Click(object sender, EventArgs e)
    {
      Automaton a = AutomatonParser.ParseAutomaton(this.rtbxAutomaton.Text);
    }

    private void btnEval_Click(object sender, EventArgs e)
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
