// <auto-generated /> // this comment to disable StyleCop.
namespace UnitTestAutomata
{
  using Microsoft.VisualStudio.TestTools.UnitTesting;
  using AutomataTesting.Engine;

  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestParsing1()
    {
      Automaton a = AutomatonParser.ParseAutomaton(@"
E={a|O,b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));
    }

    [TestMethod]
    public void TestParsing2()
    {
      //this test set tests parsing with spaces at odd locations.
      // I'm alternating the location of spaces only on the e-line, in every categorical distinct location
      Automaton a = AutomatonParser.ParseAutomaton(@"
E ={a|O,b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E= {a|O,b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={ a|O,b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={a |O,b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={a| O,b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={a|O ,b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={a|O, b|O},true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={a|O,b|O },true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={a|O,b|O} ,true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E= {a|O,b|O}, true
O={a|E,b|E},false".Trim());

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));

      a = AutomatonParser.ParseAutomaton(@"
E={a|O,b|O},true 
O={a|E,b|E},false".Trim()); // There is a space after the end of true on the first line.

      Assert.IsTrue(GenerateExpectedAutomaton1().ValueEquals(a));
    }

    /// <summary>
    /// Generates the expected <see cref="Automaton"/> to be parsed by the various test methods in this unit testing class.
    /// </summary>
    /// <returns>An <see cref="Automaton"/> representing the expected value.</returns>
    private DFA GenerateExpectedAutomaton1()
    {
      DFA a = new DFA();
      DeterministicState e = new DeterministicState();
      e.StateName = "E";
      e.IsAccepting = true;

      DeterministicState o = new DeterministicState();
      o.StateName = "O";
      o.IsAccepting = false;

      // set up acceptable strings
      e.AcceptableStrings.Add("a", o);
      e.AcceptableStrings.Add("b", o);
      o.AcceptableStrings.Add("a", e);
      o.AcceptableStrings.Add("b", e);

      a.DeterministicStateLookup.Add(e.StateName, e);
      a.DeterministicStateLookup.Add(o.StateName, o);

      return a;
    }
  }
}