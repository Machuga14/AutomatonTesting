// ---------------------------------------------------------------------
// <copyright file="DFA.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  /// <summary>
  /// Class representing a Deterministic Finite Automaton.
  /// </summary>
  public class DFA : Automaton
  {
    /// <summary>
    /// Gets or sets the abstract state lookup.
    /// </summary>
    public override Dictionary<string, State> StateLookup
    {
      get
      {
        return this.DeterministicStateLookup?
          .Select(t => t)
          .ToDictionary(
            keySel => keySel.Key,
            keySel => (State)keySel.Value);
      }

      set
      {
        if (value == null)
        {
          this.DeterministicStateLookup = null;
        }
        else
        {
          // Note type-cast; this will throw exception if invalid State is provided (IE a state which is not a Deterministic State).
          this.DeterministicStateLookup = value
          .Select(t => t)
          .ToDictionary(
            keySel => keySel.Key,
            keySel => (DeterministicState)keySel.Value);
        }
      }
    }

    /// <summary>
    /// Gets or sets the internal set of <see cref="DeterministicState"/> states in a dictionary keyed by state name.
    /// </summary>
    public Dictionary<string, DeterministicState> DeterministicStateLookup { get; set; } = new Dictionary<string, DeterministicState>();

    /// <summary>
    /// Gets the overridden <see cref="AutomatonType"/>, returning <see cref="AutomataTesting.Engine.AutomatonType.DFA"/>.
    /// </summary>
    public override AutomatonType AutomatonType => AutomatonType.DFA;
  }
}