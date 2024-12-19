namespace Projekt_M320;

public class NumberBet : Bet
{
    public int Number { get; set; }

    public NumberBet(int amount, int number) : base(amount, "Number")
    {
        Number = number;
    }

    public override bool Evaluate(int result)
    {
        return result == Number;
    }
}