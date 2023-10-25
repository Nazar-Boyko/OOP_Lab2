using laba2.Accounts;
using laba2.Accounts.States;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2.Games.States
{
    public class GameStats
    {
        public string WinnerName { get; }
        public string LoserName { get;}
        public AccountType WinnerAccType { get; }
        public AccountType LoserAccType { get; }

        public int WinnerRating { get; }
        public int LoserRating { get; }
        public int PrevWinnerRating { get; }
        public int PrevLoserRating { get; }
        public int GameID { get; }
        public GameType Type { get; }
        public GameStats(string WinnerName, string LoserName,
                        AccountType WinnerAccType, AccountType LoserAccType,
                        GameType Type, int GameID,
                        int PrevWinnerRating, int WinnerRating,
                        int PrevLoserRating = 0, int LoserRating = 0)
        {
            this.WinnerName = WinnerName;
            this.WinnerAccType = WinnerAccType;
            this.LoserAccType = LoserAccType;
            this.LoserName = LoserName;
            this.Type = Type;
            this.GameID = GameID;
            this.PrevWinnerRating = PrevWinnerRating;
            this.WinnerRating = WinnerRating;
            this.PrevLoserRating = PrevLoserRating;
            this.LoserRating = LoserRating;
        }

    }
}
