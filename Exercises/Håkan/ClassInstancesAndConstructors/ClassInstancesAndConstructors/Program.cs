using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassInstancesAndConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //FootballTeam team = new FootballTeam();

            //FootballTeam[] myTeams = new FootballTeam[3]
            //{
            //    new FootballTeam { TeamName = "Arsenal", SquadSize=22, CoachName = "Karin Kula" },
            //    new FootballTeam { TeamName = "MFF", SquadSize=25, CoachName = "Kalle ANka" },
            //    new FootballTeam { TeamName = "AIK", SquadSize=24, CoachName = "Bosse Bildoktor" }
            //};

            double moms = MomsBelopp(100);
            Console.WriteLine(moms);

            var phoneNumbers = new List<string>();
            
        }

        static double MomsBelopp(double belopp, double momsSats = 0.25) //Varför genera som private...?
        {
            return belopp * momsSats;
        }
    }
}
