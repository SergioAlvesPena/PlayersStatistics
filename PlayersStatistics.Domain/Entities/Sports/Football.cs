using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersStatistics.Domain.Entities.Sports
{
    public class Football : Sport
    {
        public Football() { }

        public Football(int goals, int assists, int interceptions, int shots, int shotsOnTarget, int foulsCommited, int yellowCards, int redCards)
        {
            Goals = goals;
            Assists = assists;
            Interceptions = interceptions;
            Shots = shots;
            ShotsOnTarget = shotsOnTarget;
            FoulsCommited = foulsCommited;
            YellowCards = yellowCards;
            RedCards = redCards;
        }

        public int Goals { get; private set; }
        public int Assists { get; set; }
        public int Interceptions { get; private set; }
        public int Shots { get; private set; }
        public int ShotsOnTarget { get; private set; }
        public int FoulsCommited { get; private set; }
        public int YellowCards { get; private set; }
        public int RedCards { get; private set; }
    }
}
