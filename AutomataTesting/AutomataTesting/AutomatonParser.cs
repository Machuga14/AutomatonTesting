// -------------------------------------------------------
// <copyright file="AutomatonParser.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// -------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  /// <summary>
  /// Static Class capable of parsing <see cref="Automaton"/> objects.
  /// </summary>
  public static class AutomatonParser
  {
    /// <summary>
    /// Parses an <see cref="Automaton"/> based upon the description defined within the provided string.
    /// </summary>
    /// <param name="s">The string defining the <see cref="Automaton"/> to construct.</param>
    /// <returns>An <see cref="Automaton"/> representing the string defined.</returns>
    public static Automaton ParseAutomaton(string s)
    {
      string[] splitLines = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

      List<State> statesBeingParsed = new List<State>();
      Dictionary<string, Tuple<State, List<Tuple<string, string>>>> workSpace = new Dictionary<string, Tuple<State, List<Tuple<string, string>>>>();

      // Stage 1: grab initial data
      foreach (string currLine in splitLines)
      {
        Tuple<State, List<Tuple<string, string>>> v = ParseStateLine(currLine);
        workSpace.Add(v.Item1.StateName, v);
      }

      // Stage 2: populate mapped states.
      foreach (KeyValuePair<string, Tuple<State, List<Tuple<string, string>>>> currProtoState in workSpace)
      {
        foreach (Tuple<string, string> stateMapper in currProtoState.Value.Item2)
        {
          // map each state mapper entry
          currProtoState.Value.Item1.AcceptableStrings.Add(
            stateMapper.Item1,
            workSpace[stateMapper.Item2].Item1);
        }
      }

      // Stage 3: extract distinct states from dictionary lookup.
      statesBeingParsed = workSpace.Select(t => t.Value.Item1).ToList();

      Automaton parsed = new Automaton()
      {
        StateLookup = statesBeingParsed.ToDictionary(
        t => t.StateName,
        t => t),
      };

      return parsed;
    }

    /// <summary>
    /// Expects a string similar to:
    /// E={a|O,b|O},true
    /// Indicating that two strings are legal in state E:
    /// a, which maps to O, and b, which maps to O, as well as e being an accepting state.
    ///
    /// Doesn't fully populate the State Object, and instead, returns a partially populated state object, with a list(tuple(string, statename) indicating the mapping states.
    /// </summary>
    /// <param name="s">the string to parse.</param>
    /// <returns>A Tuple representing a <see cref="State"/>, and list of tuple(string,string) describing the legal characters and state transformations of the <see cref="State"/>, for secondary parsing.</returns>
    private static Tuple<State, List<Tuple<string, string>>> ParseStateLine(string s)
    {
      if (!s.Contains("="))
      {
        throw new Exception("Missing a '=' symbol on line '" + s + "'");
      }

      string stateName = s.Trim().Substring(0, s.Trim().IndexOf("="));
      string map = s.Substring(s.IndexOf('{') + 1, s.IndexOf('}') - s.IndexOf('{') - 1);
      string isAcceptingUnparsed = s.Substring(s.IndexOf(",", s.IndexOf('}')) + 1).Trim();

      State retState = new State
      {
        StateName = stateName,
        IsAccepting = bool.Parse(isAcceptingUnparsed),
      };

      List<Tuple<string, string>> mapDef = new List<Tuple<string, string>>();
      string[] splitMapDefsZero = map.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

      foreach (string splitMapDef in splitMapDefsZero)
      {
        int pipeIndex = splitMapDef.Trim().IndexOf('|');
        string val = splitMapDef.Substring(0, pipeIndex).Trim();
        string mappedState = splitMapDef.Substring(pipeIndex + 1).Trim();

        mapDef.Add(new Tuple<string, string>(val, mappedState));
      }

      return new Tuple<State, List<Tuple<string, string>>>(retState, mapDef);
    }
  }
}