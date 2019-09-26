// ---------------------------------------------------------------------
// <copyright file="DFA.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  /// <summary>
  /// Class representing a Deterministic Finite Automaton.
  /// </summary>
  public class DFA : Automaton
  {
    /// <summary>
    /// Gets the overridden <see cref="AutomatonType"/>, returning <see cref="AutomataTesting.Engine.AutomatonType.DFA"/>.
    /// </summary>
    public override AutomatonType AutomatonType => AutomatonType.DFA;
  }
}