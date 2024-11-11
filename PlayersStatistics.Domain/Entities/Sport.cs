using PlayersStatistics.Core.Entities;


namespace PlayersStatistics.Domain.Entities
{
    public abstract class Sport : Entity
    {
        public Sport() { }

        public Sport(int matchesPlayed, string position, int championshipsWon, int championshipsPlayed)
        {
            MatchesPlayed = matchesPlayed;
            Position = position;
            ChampionshipsWon = championshipsWon;
            ChampionshipsPlayed = championshipsPlayed;
        }

        /// <summary>
        /// Number of matches the player played
        /// </summary>
        public int MatchesPlayed { get; private set; }

        /// <summary>
        /// Player preferred position to play
        /// </summary>
        public string Position { get; private set; }

        /// <summary>
        /// Number of championships won
        /// </summary>
        public int ChampionshipsWon { get; private set; }

        /// <summary>
        /// Number of championships played
        /// </summary>
        public int ChampionshipsPlayed { get; private set; }
    }
}
