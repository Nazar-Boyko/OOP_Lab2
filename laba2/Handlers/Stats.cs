using laba2.Games.States;

namespace laba2.Handlers
{
    public static class Stats
    {
        private static List<GameStats> History = new();

        public static int Count { get { return History.Count; } }
        public static void Add(GameStats game)
        {
            History.Add(game);
        }

        public static string GetStats()
        {
            string result = "*------------------------------------------------------------------------------------------------*\n" +
                            "| ID  |  GameType  | Winner   <->     Type |    Rating    | Loser    <->     Type |    Rating    |\n" +
                            "*------------------------------------------------------------------------------------------------*\n";
            foreach (var game in History)
            {
                result +=
                $"| {game.GameID,-3} | {game.Type,-11}" +
                $"| {game.WinnerName,-10} {game.WinnerAccType,10} " +
                $"| {game.PrevWinnerRating,-4} -> {game.WinnerRating,4} " +
                $"| {game.LoserName,-10} {game.LoserAccType,10} " +
                $"| {game.PrevLoserRating,-4} -> {game.LoserRating,4} |\n";
            }
            result += "*------------------------------------------------------------------------------------------------*\n";
            return result;
        }

        public static string GetStatsForPlayers(string Username)
        {

            string result = $"\t\t\t\t     Game History for {Username}\n";

            result +=  "*------------------------------------------------------------------------------------------------*\n"
                     + "| ID  |  GameType  | Winner   <->     Type |    Rating    | Loser    <->     Type |    Rating    |\n"
                     + "*------------------------------------------------------------------------------------------------*\n";

            foreach (var game in History)
            {
                if (game.WinnerName == Username || game.LoserName == Username)
                {
                    result +=
                    $"| {game.GameID,-3} | {game.Type,-11}" +
                    $"| {game.WinnerName,-10} {game.WinnerAccType,10} " +
                    $"| {game.PrevWinnerRating,-4} -> {game.WinnerRating,4} " +
                    $"| {game.LoserName,-10} {game.LoserAccType,10} " +
                    $"| {game.PrevLoserRating,-4} -> {game.LoserRating,4} |\n";
                }
            }
            result += "*------------------------------------------------------------------------------------------------*\n";
            return result;
        }
    }

}
