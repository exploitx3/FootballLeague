using System;

namespace November_2015_Lab___Football_League.Models
{
    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public int HomeTeamGoals
        {
            get { return homeTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot have negative goals");
                }
                else
                {
                    this.homeTeamGoals = value;
                }
            }
        }
        public int AwayTeamGoals
        {
            get { return awayTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot have negative goals");
                }
                else
                {
                    this.awayTeamGoals = value;
                }
            }
        }

        public Score(int awayTeamGoals, int homeTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoals;
        }
    }
}