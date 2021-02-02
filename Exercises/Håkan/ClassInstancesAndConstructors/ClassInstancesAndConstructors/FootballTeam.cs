using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInstancesAndConstructors
{
    class FootballTeam
    {
        public string TeamName { get; set; }
        public string CoachName { get; set; }
        public int SquadSize { get; set; }
        
        //public FootballTeam() // Parameterless constructor.
        //{

        //}

        public FootballTeam(string teamName, string coachName, int squadSize) // Parametersatt constructor.
        {
            TeamName = teamName;
            CoachName = coachName;
            SquadSize = squadSize;
        }

        public FootballTeam() : this("N/A", "N/A", 0)
        {

        }

    }
}
