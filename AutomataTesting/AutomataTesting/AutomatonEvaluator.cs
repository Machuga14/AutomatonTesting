using System;
using System.Collections.Generic;
using System.Text;

namespace AutomataTesting
{
  public static class AutomatonEvaluator
  {
    public static bool EvalAutomaton(Automaton aut, string data)
    {
      State currState = null;

      if (aut.StateLookup.ContainsKey("E"))
      {
        currState = aut.StateLookup["E"]; // always start with E.
      }
      else if (aut.StateLookup.ContainsKey("q_0"))
      {
        currState = aut.StateLookup["q_0"]; // else, start with q_0.
      }
      else if (aut.StateLookup.ContainsKey("Q_0"))
      {
        currState = aut.StateLookup["Q_0"]; // else, start with Q_0.
      }
      else if (aut.StateLookup.ContainsKey("q0"))
      {
        currState = aut.StateLookup["q0"]; // else, start with q0.
      }
      else if (aut.StateLookup.ContainsKey("Q0"))
      {
        currState = aut.StateLookup["Q0"]; // else, start with Q0.
      }
      else
      {
        throw new Exception("Please ensure your automaton has a starting edge named, in order, one of (E,q_0,Q_0,q0,Q0). The first edge by a matching name in the aforementioned tuple is assumed to be the starting edge.");
      }

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