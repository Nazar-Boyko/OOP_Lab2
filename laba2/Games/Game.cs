using laba2.Accounts;
using laba2.Games.States;
using laba2.Handlers;

namespace laba2.Games
{
    public abstract class Game
    {
        protected int GameCount { get { return Stats.Count + 1; }}
        public GameType Type { get; protected init; }
        public abstract int GetRating(BaseAccount player);
        public virtual void Play(BaseAccount player1, BaseAccount player2)
        {
            Random random = new();
            int temp = random.Next(2);
            int PrevRating_1 = player1.Rating;
            int PrevRating_2 = player2.Rating;

            if (temp == 0)
            {
                player1.WinGame(this);
                player2.LoseGame(this);
                Stats.Add(new GameStats(player1.UserName,player2.UserName,
                                        player1.Type,player2.Type,
                                        Type,GameCount,
                                        PrevRating_1,player1.Rating,
                                        PrevRating_2,player2.Rating));
            }
            else
            {
                player2.WinGame(this);
                player1.LoseGame(this);
                Stats.Add(new GameStats(player2.UserName, player1.UserName,
                                        player2.Type, player1.Type,
                                        Type, GameCount,
                                        PrevRating_2, player2.Rating,
                                        PrevRating_1, player1.Rating));

            }
        }
    }
}
