using System;
using System.Collections.Generic;
using System.Text;

namespace AutomataTesting
{
  public static class AutomatonEvaluator
  {
    public static bool EvalAutomaton(Automaton aut, string data)
    {
      State currState = aut.StateLookup["E"]; // always start with E.

      foreach (char c in data)
      {
        if (currState.AcceptableStrings.ContainsKey(c.ToString()))
        {
          currState = currState.AcceptableStrings[c.ToString()];
        }
        else
        {
          return false;
        }
      }

      return currState.IsAccepting;
    }
  }
}