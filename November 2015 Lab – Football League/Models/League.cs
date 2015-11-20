using System;
using System.Collections.Generic;
using System.Linq;

namespace November_2015_Lab___Football_League.Models
{
    public static class League
    {
         private static List<Team> teams = new List<Team>(); 
         private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(Team team)
        {
            if (teams.Any(p=> p.Name == team.Name))
            {
                throw new InvalidOperationException("The " + team.Name + " is already added to the list of Teams");
            }
            else
            {
                teams.Add(team);
            }
        }

        public static void AddMatch(Match match)
        {
            if (matches.Any(p => p.Id == match.Id))
            {
                throw new InvalidOperationException("The match " + match.HomeTeam + " vs. " + match.AwayTeam + " with ID: " + match.Id + 
                                                    " already exists in the list of Matches");
            }
            else
            {
                matches.Add(match);
            }
        }

    }
}