namespace ProjektM320;

 public class RouletteTable
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public Wheel Wheel { get; set; } = new Wheel();

        public void SpinWheel()
        {
            int result = Wheel.Spin();
            Console.WriteLine($"The wheel spun and landed on: {result}");

            foreach (var player in Players)
            {
                foreach (var bet in player.Bets)
                {
                    if (bet.Evaluate(result))
                    {
                        int winnings = bet.Amount * 2; // Simplified payout
                        player.Balance += winnings;
                        Console.WriteLine($"{player.Name} won {winnings}!");
                    }
                    else
                    {
                        Console.WriteLine($"{player.Name} lost the bet of {bet.Amount}.");
                    }
                }

                player.Bets.Clear();
            }
        }

        public void GetPlayerBets(Player player)
        {
            Console.WriteLine($"{player.Name}, you have {player.Balance} balance.");
            Console.Write("Enter your bet amount: ");
            int amount = int.Parse(Console.ReadLine() ?? "0");

            if (amount > player.Balance)
            {
                Console.WriteLine("You don’t have enough balance to place this bet.");
                return;
            }

            Console.Write("Enter bet type (Number/Color): ");
            string type = Console.ReadLine()?.Trim();

            if (type == "Number")
            {
                Console.Write("Enter the number you want to bet on (0-36): ");
                int number = int.Parse(Console.ReadLine() ?? "0");
                player.PlaceBet(new NumberBet(amount, number));
            }
            else if (type == "Color")
            {
                Console.Write("Enter the color you want to bet on (Red/Black): ");
                string color = Console.ReadLine()?.Trim();
                player.PlaceBet(new ColorBet(amount, color));
            }
            else
            {
                Console.WriteLine("Invalid bet type.");
            }
        }
    }