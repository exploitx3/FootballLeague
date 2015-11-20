using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace November_2015_Lab___Football_League.Models
{
    public static class LeagueManager
    {
        private static void AddTeam(Team newTeam)
        {
            League.AddTeam(newTeam);
            Console.WriteLine("The " + newTeam.Name +" team has been added succesfully");
        }
        private static void AddMatch(string homeTeamName, string awayTeamName, string idString, string homeTeamGoalsStr, string awayTeamGoalsStr)
        {
            if (League.Teams.All(t => t.Name != homeTeamName))
            {
                throw new InvalidOperationException("There is no team with the name " + homeTeamName + " in the league.");
            }

            if (League.Teams.All(t => t.Name != awayTeamName))
            {
                throw new InvalidOperationException("There is no team with the name " + awayTeamName + " in the league.");
            }


            League.AddMatch(new Match(League.Teams.First(t => t.Name == homeTeamName),
                        League.Teams.First(t => t.Name == awayTeamName), int.Parse(idString),
                        new Score(int.Parse(homeTeamGoalsStr), int.Parse(awayTeamGoalsStr))));
            Console.WriteLine("Match with ID: " + idString + " has been added succesfully");
        }

        private static void AddPlayerToTeam(string firstName, string lastName, string salary, string dateOfBirth, string teamName)
        {
            if (League.Teams.All(t => t.Name != teamName))
            {
                throw new InvalidOperationException("There is no team with the name " + teamName + " in the league.");
            }
            League.Teams.First(t => t.Name == teamName)
                .AddPlayer(new Player(firstName, lastName, decimal.Parse(salary), DateTime.ParseExact(dateOfBirth,"yyyy/MM/dd",CultureInfo.InvariantCulture),
                    League.Teams.First(t => t.Name == teamName)));
        }

     

        private static void ListTeams()
        {
            foreach (Team team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void ListMatches()
        {
            foreach (Match match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }
        public static void HandleInput(string input)
        {
            var args = input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            switch (args[0])
            {
                case "AddTeam":
                    AddTeam(new Team(args[1], args[2], DateTime.ParseExact(args[3],"yyyy/MM/dd",CultureInfo.InvariantCulture)));
                    break;
                case "AddMatch":
                    AddMatch(args[1], args[2], args[3], args[4], args[5]);
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(args[1], args[2], args[3], args[4], args[5]);
                    break;
                case "ListTeams":
                  ListTeams();
                    break;
                case "ListMatches":
                   ListMatches();
                    break;
            }
        } 
    }
}