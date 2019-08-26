// ---------------------------------------------------------------------
// <copyright file="ParseStringResultsEventArgs.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace SampleHost
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  using AutomataTesting.Engine;

  /// <summary>
  /// <see cref="ParseStringResultsEventArgs "/> storing data about an event pertaining to <see cref="ParseStringResults"/> objects.
  /// </summary>
  public class ParseStringResultsEventArgs : EventArgs
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ParseStringResultsEventArgs"/> class.
    /// <para>Parameterized Constructor.</para>
    /// </summary>
    /// <param name="arg">The <see cref="ParseStringResults"/> corresponding to this <see cref="ParseStringResultsEventArgs"/>.</param>
    public ParseStringResultsEventArgs(ParseStringResults arg)
      : base()
    {
      this.Argument = arg;
    }

    /// <summary>
    /// Gets the <see cref="ParseStringResults"/> pertaining to the Event Args.
    /// </summary>
    public ParseStringResults Argument { get; private set; }
  }
}