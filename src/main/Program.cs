namespace Projekt_M320;

public class Program
{
    public static void Main(string[] args)
    {
        var table = new RouletteTable();

        var player1 = new Player("Noah", 1000);
        //var player2 = new Player("Bob", 100);

        table.Players.Add(player1);
        //table.Players.Add(player2);

        bool playAgain;

        do
        {
            foreach (var player in table.Players)
            {
                table.GetPlayerBets(player);
            }

            table.SpinWheel();

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine()?.Trim().ToLower();
            playAgain = response == "yes";

        } while (playAgain);

        Console.WriteLine("Thank you for playing Roulette!");
    }
}

