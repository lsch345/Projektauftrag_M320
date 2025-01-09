namespace ProjektM320;

public abstract class Bet
{
    public int Amount { get; set; }
    public string Type { get; set; }

    protected Bet(int amount, string type)
    {
        Amount = amount;
        Type = type;
    }

    public abstract bool Evaluate(int result);
}