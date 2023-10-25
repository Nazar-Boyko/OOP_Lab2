using laba2.Accounts;
using laba2.Accounts.States;
using laba2.Games.States;
using laba2.Handlers;

namespace laba2.Games
{
    public class SoloGame : Game
    {
        public SoloGame()
        {
            Type = GameType.Solo;
        }

        public override int GetRating(BaseAccount player)
        {
            var rand = new Random();
            return rand.Next(20,30);
        }

        public override void Play(BaseAccount player1, BaseAccount? player2  = null)
        {
            var rand = new Random();
            int temp = rand.Next(2);

            int PervRating = player1.Rating;

            if (temp == 0)
            {
                player1.WinGame(this);
                Stats.Add(new GameStats(player1.UserName, "Bot",
                                        player1.Type,AccountType.Bot,
                                        Type,GameCount,
                                        PervRating, player1.Rating));
            }
            else
            {
                player1.LoseGame(this);
                Stats.Add(new GameStats("Bot", player1.UserName,
                                        AccountType.Bot,
                                        player1.Type,Type, GameCount,
                                        0, 0, PervRating, player1.Rating));

            }

        }
    }
}
