using NUnit.Framework;

namespace Projekt_M320.test;


[TestFixture]
public class BetTests
{
    [Test]
    public void NumberBet_Evaluate_ShouldReturnTrue_WhenNumberMatches()
    {
        var bet = new NumberBet(100, 5);
        var result = bet.Evaluate(5);
        Assert.IsTrue(result);
    }

    [Test]
    public void NumberBet_Evaluate_ShouldReturnFalse_WhenNumberDoesNotMatch()
    {
        var bet = new NumberBet(100, 5);
        var result = bet.Evaluate(3);
        Assert.IsFalse(result);
    }

    [Test]
    public void ColorBet_Evaluate_ShouldReturnTrue_WhenColorMatches()
    {
        var bet = new ColorBet(100, "Red");
        var result = bet.Evaluate(3); // 3 is odd, so Red
        Assert.IsTrue(result);
    }

    [Test]
    public void ColorBet_Evaluate_ShouldReturnFalse_WhenColorDoesNotMatch()
    {
        var bet = new ColorBet(100, "Black");
        var result = bet.Evaluate(3); // 3 is odd, so Red
        Assert.IsFalse(result);
    }
}