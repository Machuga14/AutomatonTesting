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
  public class DeterministicState
  {
    /// <summary>
    /// Gets or sets the name of this state.
    /// </summary>
    public string StateName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is an accepting (or ending) state.
    /// </summary>
    public bool IsAccepting { get; set; }

    /// <summary>
    /// Gets or sets the collection of acceptable strings by this state, as well as the state the string maps to.
    /// </summary>
    public Dictionary<string, DeterministicState> AcceptableStrings { get; set; } = new Dictionary<string, DeterministicState>();

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