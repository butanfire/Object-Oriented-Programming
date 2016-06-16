using System;

namespace FootballLeague.Models
{
    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTeamGoal, int awayTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoal;
        }

        public int HomeTeamGoals
        {
            get { return this.homeTeamGoals; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");

                }
                this.homeTeamGoals = value;
            }
        }
        public int AwayTeamGoals
        {
            get { return this.awayTeamGoals; }
            set {
                if(value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");
                }
                this.awayTeamGoals = value;
            }
        }
    }
}
