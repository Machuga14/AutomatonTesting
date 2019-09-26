// ---------------------------------------------------------------------
// <copyright file="AutomatonType.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Text;

  /// <summary>
  /// Enum describing recognized <see cref="Automaton"/> types.
  /// </summary>
  public enum AutomatonType
  {
    /// <summary>
    /// Unknown <see cref="Automaton"/> type.
    /// </summary>
    [Description("Unknown Automaton type.")]
    Unknown = 0,

    /// <summary>
    /// Deterministic Finite Automaton type.
    /// </summary>
    [Description("Deterministic Finite Automaton type.")]
    DFA = 1,

    /// <summary>
    /// Nondeterministic Finite Automaton type.
    /// </summary>
    [Description("Nondeterministic Finite Automaton type.")]
    NFA = 2,
  }
}