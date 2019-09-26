// ---------------------------------------------------------------------
// <copyright file="EqualityComparators.cs" company="Matthew K. Crandall - N/A">
// Copyright (c) Matthew K. Crandall. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------

namespace AutomataTesting.Engine
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  /// <summary>
  /// Public static class used to help with value equality comparisons.
  /// </summary>
  public static class EqualityComparators
  {
    /// <summary>
    /// Evaluates whether two provided <see cref="Automaton"/>s are equal by value.
    /// </summary>
    /// <param name="left">The left <see cref="Automaton"/> to compare.</param>
    /// <param name="right">The right <see cref="Automaton"/> to compare.</param>
    /// <returns><see langword="true"/> if <paramref name="left"/> equals <paramref name="right"/>, else, <see langword="false"/>.</returns>
    public static bool ValueEquals(this Automaton left, Automaton right)
    {
      if (left.AreValueInequalByNullDisparity(right))
      {
        return false;
      }

      if (object.ReferenceEquals(left, right))
      {
        return true;
      }

      if (left.StateLookup.AreValueInequalByNullDisparity(right.StateLookup) ||
        left.StateLookup?.Count != right.StateLookup?.Count ||
        left.AutomatonType != right.AutomatonType)
      {
        return false;
      }

      foreach (var keyPair in left.StateLookup)
      {
        if (!right.StateLookup.ContainsKey(keyPair.Key) ||
          !keyPair.Value.ValueEquals(right.StateLookup[keyPair.Key]))
        {
          return false;
        }
      }

      return true;
    }

    /// <summary>
    /// Evaluates whether two provided <see cref="DeterministicState"/>s are equal by value.
    /// <para>Note: If every <see cref="DeterministicState"/> S in <paramref name="left"/> has a corresponding <see cref="DeterministicState"/> with an identical NAME in <paramref name="right"/>,
    /// they are assumed to be equal, even if the states mapped are not actually the same by ref, or have differing definitions.</para>
    /// </summary>
    /// <param name="left">The left <see cref="DeterministicState"/> to compare.</param>
    /// <param name="right">The right <see cref="DeterministicState"/> to compare.</param>
    /// <returns><see langword="true"/> if <paramref name="left"/> equals <paramref name="right"/>, else, <see langword="false"/>.</returns>
    public static bool ValueEquals(this DeterministicState left, DeterministicState right)
    {
      if (left.AreValueInequalByNullDisparity(right))
      {
        return false;
      }

      if (object.ReferenceEquals(left, right))
      {
        return true;
      }

      if (left.StateName != right.StateName ||
        left.IsAccepting != right.IsAccepting ||
        left.AcceptableStrings.AreValueInequalByNullDisparity(right.AcceptableStrings) ||
        left.AcceptableStrings?.Count != right.AcceptableStrings?.Count)
      {
        return false;
      }

      foreach (var keyPair in left.AcceptableStrings)
      {
        if (!right.AcceptableStrings.ContainsKey(keyPair.Key))
        {
          return false;
        }
      }

      return true;
    }

    /// <summary>
    /// Helper-method to determin if two provided objects are inequal by a null disparity.
    /// </summary>
    /// <param name="left">The left object to compare via null disparity.</param>
    /// <param name="right">The right object to compare via null disparity.</param>
    /// <returns>True if the objects are inequal by null disparity, else false.</returns>
    public static bool AreValueInequalByNullDisparity(this object left, object right)
    {
      if ((left == null && right != null) ||
        (left != null && right == null))
      {
        return true;
      }

      return false;
    }
  }
}