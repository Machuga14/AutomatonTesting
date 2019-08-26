// ---------------------------------------------------------------------
// <copyright file="Program.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace SampleHost
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;
  using System.Windows.Forms;

  /// <summary>
  /// Static <see cref="Program"/> class holding the main entry point for the program.
  /// </summary>
  public static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}