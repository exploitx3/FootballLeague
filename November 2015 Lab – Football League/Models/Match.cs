using System;

namespace November_2015_Lab___Football_League.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        public int Id { get; set; }
        public Score Score { get; set; }
        public Team HomeTeam
        {
            get { return homeTeam; }
            set
            {
                if (value.Equals(this.awayTeam))
                {
                    throw new ArgumentException("Home team cannot be the same as the Away team.");
                }
                else
                {
                    this.homeTeam = value;
                }
            }
        }

        public Team AwayTeam
        {
            get { return awayTeam; }
            set
            {
                if (value.Equals(this.homeTeam))
                {
                    throw new ArgumentException("Away team cannot be the same as the Home team.");
                }
                else
                {
                    this.awayTeam = value;
                }
            }
        }

        private bool isDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }
        public Team GetWinner()
        {
            if (isDraw())
            {
                return null;
            }
            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        public Match(Team homeTeam, Team awayTeam, int id, Score score)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Id = id;
            Score = score;
        }

        public override string ToString()
        {
            return this.homeTeam.Name + " " + this.Score.HomeTeamGoals + " : " + this.Score.AwayTeamGoals + " " +
                   this.awayTeam.Name;
        }
    }
}