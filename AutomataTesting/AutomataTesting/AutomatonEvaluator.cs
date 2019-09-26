// -------------------------------------------------------
// <copyright file="AutomatonEvaluator.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// -------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  /// <summary>
  /// <see langword="static"/> class to evaluate a <see cref="string"/> with a provided <see cref="Automaton"/> representing a logical Regular Grammar,
  /// in order to determine if the specified string is legal.
  /// </summary>
  public static class AutomatonEvaluator
  {
    /// <summary>
    /// Method to evaluate a string against a specified <see cref="Automaton"/> to determine legality.
    /// </summary>
    /// <param name="aut">The <see cref="Automaton"/> to evaluate.</param>
    /// <param name="data">The string to evaluate efficacy of.</param>
    /// <returns><see langword="true"/> if the string is legal, else, <see langword="false"/>.</returns>
    public static ParseStringResults EvalAutomaton(Automaton aut, string data)
    {
      ParseStringResults retVal = new ParseStringResults
      {
        Input = data,
        CorrespondingAutomaton = aut,
      };

      DeterministicState currState = null;
      int digitsForLengthOfChars = CalculateDigits(data.Length);

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
        retVal.ErrorMessage = "Please ensure your automaton has a starting edge named, in order, one of (E,q_0,Q_0,q0,Q0). The first edge by a matching name in the aforementioned tuple is assumed to be the starting edge.";
      }

      int idx = 0;
      foreach (char c in data)
      {
        if (currState.AcceptableStrings.ContainsKey(c.ToString()))
        {
          DeterministicState nextState = currState.AcceptableStrings[c.ToString()];
          retVal.EvalStatements.Add(string.Format(
            "[{0}]: {1}[{2}] -> {3}",
            idx.ToString().PadLeft(digitsForLengthOfChars, '0'),
            currState.StateName,
            c,
            nextState.StateName));

          currState = nextState;
        }
        else
        {
          retVal.ErrorMessage = string.Format("Illegal character at index {0}", idx);
          retVal.IllegalCharIndex = idx;
          retVal.Validated = false;
          return retVal;
        }

        idx++;
      }

      if (currState.IsAccepting)
      {
        retVal.Validated = true;
      }
      else
      {
        retVal.Validated = false;
        retVal.ErrorMessage = string.Format(
          "The Automaton did not end in an accepting state. The final state was {0}.",
          currState.StateName);
        retVal.IllegalCharIndex = retVal.Input.Length - 1;
      }

      return retVal;
    }

    /// <summary>
    /// Messy helper-method to calculate the number of digits a value has.
    /// (written because I was too lazy to figure out a smarter method).
    /// </summary>
    /// <param name="n">The value to calculate # of digits of.</param>
    /// <returns>the number of digits the provided value has.</returns>
    private static int CalculateDigits(int n)
    {
      int digits = 1;

      while (n > 0)
      {
        digits++;
        n /= 10;
      }

      return digits - 1;
    }
  }
}