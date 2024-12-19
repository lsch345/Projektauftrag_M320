namespace Projekt_M320;

public class ColorBet : Bet
{
    public string Color { get; set; } // "Red" or "Black"

    public ColorBet(int amount, string color) : base(amount, "Color")
    {
        Color = color;
    }

    public override bool Evaluate(int result)
    {
        // Simplified for demo purposes: even = black, odd = red
        return (result % 2 == 0 && Color == "Black") || (result % 2 != 0 && Color == "Red");
    }
}
