using System;
using System.Collections.Generic;

namespace AutomataTesting
{
  /// <summary>
  /// Class representing a <see cref="State"/>, composed of a name, whether the state is accepting, as wel as the map of acceptable strings, and the states
  /// that they map to.
  /// </summary>
  public class State
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
    public Dictionary<string, State> AcceptableStrings { get; set; } = new Dictionary<string, State>();

    /// <summary>
    /// Overridden ToString() Method.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return this.StateName;
    }
  }
}