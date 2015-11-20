using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using November_2015_Lab___Football_League.Models;

namespace November_2015_Lab___Football_League
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("*--->  " + e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("*--->  " + e.Message);
                }
            }
        }
    }
}
/*
AddTeam ViharLoznica VihrLz 1992/02/03 
AddTeam Chelsea London 1949/02/03 
AddTeam Chelsea London 1956/02/03 
AddTeam ManchesterCity ManCity 1950/02/03 
AddTeam ManchesterUnited RedDevils 1951/06/06 
AddTeam Arsenal TheGunners  1961/11/04 
AddMatch ViharLoznica Chelsea 123 3 0
AddMatch Chelsea ManchesterUnited 124 1 7
AddMatch ManchesterUnited ManchesterCity 125 3 2
AddMatch ManchesterUnited ViharLoznica 125 3 3
AddPlayerToTeam Petko Petkov 3000 1979/04/11 Chelsea
AddPlayerToTeam Petko Petkov 3000 1980/04/11 Chelsea
AddPlayerToTeam Petko Petkov 3000 1980/04/11 Chelsea
AddPlayerToTeam Tosho Trin4ev 3300 1988/04/11 ManchesterUnited
AddPlayerToTeam Joro Vratar4eto 70 1993/01/15 ViharLoznica
AddPlayerToTeam Je4ko Je4kov 20 1991/02/18 ViharLoznica

 */
