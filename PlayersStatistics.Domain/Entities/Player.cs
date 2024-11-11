using PlayersStatistics.Core.Enums;
using PlayersStatistics.Domain.Entities;

namespace PlayersStatistics.Core.Entities
{
    public class Player : Entity
    {
        public Player()
        {
        }

        public Player(string name, int age, float height, float weight, string? position, EHandedness handedness, string team, Sport sport)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Position = position;
            Handedness = handedness;
            Team = team;
            Sport = sport;
        }

        /// <summary>
        /// Name of the player
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The team that the player is current playing
        /// </summary>
        public string Team { get; private set; }

        /// <summary>
        /// Player age
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Player Height
        /// </summary>
        public float Height { get; private set; }

        /// <summary>
        /// Player Weight
        /// </summary>
        public float Weight { get; private set; }

        /// <summary>
        /// The position that he plays
        /// </summary>
        public string? Position { get; private set; }

        /// <summary>
        /// The player dominant hand
        /// </summary>
        public EHandedness Handedness { get; private set; }

        /// <summary>
        /// The sport played in his carreer
        /// </summary>
        public Sport Sport { get; private set; }

        public void Update(string name, int age, float height, float weight, string? position, EHandedness handedness, Sport sport)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Position = position;
            Handedness = handedness;
            Sport = sport;

            UpdateModifiedOn();
        }

    }
}
