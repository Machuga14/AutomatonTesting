// ---------------------------------------------------------------------
// <copyright file="DeterministicState.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;

  /// <summary>
  /// Class representing a <see cref="DeterministicState"/>, composed of a name, whether the state is accepting, as wel as the map of acceptable strings, and the states
  /// that they map to.
  /// </summary>
  public class DeterministicState : State
  {
    /// <summary>
    /// Gets or sets the name of this state.
    /// </summary>
    public override string StateName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is an accepting (or ending) state.
    /// </summary>
    public override bool IsAccepting { get; set; }

    /// <summary>
    /// Gets or sets the collection of acceptable strings by this state, as well as the state the string maps to.
    /// </summary>
    public Dictionary<string, DeterministicState> AcceptableStrings { get; set; } = new Dictionary<string, DeterministicState>();

    /// <summary>
    /// Looks up a singleton <see cref="State"/> that this <see cref="DeterministicState"/> transitions to.
    /// </summary>
    /// <param name="token">The token describing the state to transition to.</param>
    /// <returns>The <see cref="State"/> to transition to.</returns>
    public override State LookupTransition(string token)
    {
      return this?.AcceptableStrings?.ContainsKey(token) == null ? null : this?.AcceptableStrings?[token];
    }

    /// <summary>
    /// Looks up a set of <see cref="State"/> objects transitionable to from this <see cref="State"/>.
    /// If none are available, returns the empty set.
    /// </summary>
    /// <param name="token">The token to look up the transition rule for.</param>
    /// <returns>A List of all transitionable states.</returns>
    public override List<State> LookupTransitions(string token)
    {
      State lookup = this.LookupTransition(token);

      if (lookup == null)
      {
        return new List<State>();
      }
      else
      {
        return new List<State>() { lookup };
      }
    }

    /// <summary>
    /// Overridden ToString() Method.
    /// </summary>
    /// <returns>A string representation of this <see cref="DeterministicState"/> object.</returns>
    public override string ToString()
    {
      return this.StateName;
    }
  }
}