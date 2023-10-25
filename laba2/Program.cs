using laba2.Accounts;
using laba2.Games.States;
using laba2.Handlers;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var players = new List<BaseAccount>
            {
                new BaseAccount("Sam",100),
                new BaseAccount("Cody", 150),
                new BonusAccount("Denial",100),
                new BonusAccount("Emily",150),
                new PremiumAccount("Sara",200),
                new PremiumAccount("Stacy",200)
            };

            GameFactory factory = new();
            var rand = new Random();
            for (int i = 0; i < 25; i++)
            {
                var player1 = players[rand.Next(players.Count)];
                var player2 = players.Where(x => x != player1)
                    .ToList()[rand.Next(players.Count - 1)];

                var RandomGame = (GameType)rand.Next(Enum.GetValues(typeof(GameType)).Length);
                var game = factory.CreateGame(RandomGame);

                game.Play(player1,player2);


            }

            Console.WriteLine("\t\t\t\t\tAll game history");
            Console.WriteLine(Stats.GetStats());

            var player = players[rand.Next(players.Count)];
            Console.WriteLine(Stats.GetStatsForPlayers(player.UserName));

            
        }
    }
}