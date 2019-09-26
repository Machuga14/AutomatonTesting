// ---------------------------------------------------------------------
// <copyright file="State.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  /// <summary>
  /// <see langword="abstract"/> <see cref="State"/> for an <see cref="Automaton"/>.
  /// </summary>
  public abstract class State
  {
    /// <summary>
    /// Gets or sets a string representing the name of this <see cref="State"/>.
    /// </summary>
    public abstract string StateName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="State"/> is accepting.
    /// </summary>
    public abstract bool IsAccepting { get; set; }

    /// <summary>
    /// Looks up a singleton <see cref="State"/> that this <see cref="State"/> transitions to.
    /// If more than 1 <see cref="State"/> maps, throws an exception.
    /// </summary>
    /// <param name="token">The token describing the state to transition to.</param>
    /// <returns>The <see cref="State"/> to transition to.</returns>
    public abstract State LookupTransition(string token);

    /// <summary>
    /// Looks up a set of <see cref="State"/> objects transitionable to from this <see cref="State"/>.
    /// If none are available, returns the empty set.
    /// </summary>
    /// <param name="token">The token to look up the transition rule for.</param>
    /// <returns>A List of all transitionable states.</returns>
    public abstract List<State> LookupTransitions(string token);
  }
}