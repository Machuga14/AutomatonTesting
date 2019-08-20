using System;
using System.Collections.Generic;
using System.Text;

namespace AutomataTesting
{
  public class Automaton
  {
    /// <summary>
    /// gets or sets the state lookup for this <see cref="Automaton"/> object.
    /// </summary>
    public Dictionary<string, State> StateLookup { get; set; } = new Dictionary<string, State>();
  }
}