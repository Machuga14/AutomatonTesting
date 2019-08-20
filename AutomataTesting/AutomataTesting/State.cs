using System;
using System.Collections.Generic;

namespace AutomataTesting
{
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

    public override string ToString()
    {
      return this.StateName;
    }
  }
}