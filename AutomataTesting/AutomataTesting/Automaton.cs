// -------------------------------------------------------
// <copyright file="Automaton.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// -------------------------------------------------------

namespace AutomataTesting
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  /// <summary>
  /// <see cref="Automaton"/> class representing a state lookup for <see cref="State"/> objects, for traversal of a grammar.
  /// </summary>
  public class Automaton
  {
    /// <summary>
    /// Gets or sets the state lookup for this <see cref="Automaton"/> object.
    /// </summary>
    public Dictionary<string, State> StateLookup { get; set; } = new Dictionary<string, State>();
  }
}