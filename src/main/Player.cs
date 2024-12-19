namespace Projekt_M320;

public class Player : Person
{
    public int Balance { get; set; }
    public List<Bet> Bets { get; set; } = new List<Bet>();

    public Player(string name, int balance) : base(name)
    {
        Balance = balance;
    }

    public void PlaceBet(Bet bet)
    {
        if (bet.Amount > Balance)
        {
            Console.WriteLine("Not enough balance to place this bet.");
            return;
        }

        Bets.Add(bet);
        Balance -= bet.Amount;
    }
}