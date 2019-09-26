// -------------------------------------------------------
// <copyright file="Automaton.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// -------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  /// <summary>
  /// <see cref="Automaton"/> class representing a state lookup for <see cref="DeterministicState"/> objects, for traversal of a grammar.
  /// This is <see langword="abstract"/>; it is expected to use an underlying <see cref="DFA"/> or NFA.
  /// </summary>
  public abstract class Automaton
  {
    /// <summary>
    /// Gets or sets the state lookup for this <see cref="Automaton"/> object.
    /// </summary>
    public virtual Dictionary<string, DeterministicState> StateLookup { get; set; } = new Dictionary<string, DeterministicState>();

    /// <summary>
    /// Gets the <see cref="AutomatonType"/> describing what type of <see cref="Automaton"/> this is.
    /// (without reflection / is).
    /// </summary>
    public virtual AutomatonType AutomatonType { get; }
  }
}