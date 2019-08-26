// ---------------------------------------------------------------------
// <copyright file="ParseStringResults.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  /// <summary>
  /// Class storing the results of parsing a string with a defined <see cref="Automaton"/>.
  /// </summary>
  public class ParseStringResults
  {
    /// <summary>
    /// Gets or sets the input string for the parsing via an <see cref="Automaton"/>.
    /// </summary>
    public string Input { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the corresponding <see cref="Automaton"/> that was used to validate the <see cref="Input"/>.
    /// </summary>
    public Automaton CorrespondingAutomaton { get; set; } = null;

    /// <summary>
    /// Gets or sets the collection of evaluation statements (or steps) used to determine whether this <see cref="ParseStringResults"/> represents a success or failure.
    /// </summary>
    public List<string> EvalStatements { get; set; } = new List<string>();

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="ParseStringResults"/> represents a validated string.
    /// </summary>
    public bool Validated { get; set; } = false;

    /// <summary>
    /// Gets or sets an error message associated with this <see cref="ParseStringResults"/>. Should be <see cref="string.Empty"/> if no error occurred.
    /// </summary>
    public string ErrorMessage { get; set; } = string.Empty;

    /// <summary>
    /// Gets a value indicating whether an error occurred when constructing this <see cref="ParseStringResults"/> and validating it against an <see cref="Automaton"/>.
    /// </summary>
    public bool HadError
    {
      get
      {
        return !string.IsNullOrEmpty(this.ErrorMessage);
      }
    }

    /// <summary>
    /// Gets or sets the index within the string that had the error.
    /// </summary>
    public int IllegalCharIndex { get; set; } = -1;

    /// <summary>
    /// Gets the offending character that invalidated the <see cref="Input"/> <see cref="string"/>.
    /// returns \0 (null-terminating character) if the index is out of range of the current <see cref="Input"/> length.
    /// </summary>
    public char IllegalChar
    {
      get
      {
        if (this.IllegalCharIndex >= 0 && this.IllegalCharIndex < this.Input.Length)
        {
          return this.Input[this.IllegalCharIndex];
        }
        else
        {
          return '\0';
        }
      }
    }
  }
}