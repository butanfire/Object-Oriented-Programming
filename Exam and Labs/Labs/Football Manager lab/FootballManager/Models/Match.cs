namespace FootballLeague.Models
{
    using System;

    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;

        public Match(int id,Team homeTeam,Team awayTeam,Score score)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.Score = score;
            this.ID = id;
        }

        public int ID { get; set; }

        public Score Score
        {
            get
            {
                return this.score;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid Match score");
                }

                this.score = value;
            }
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.score.HomeTeamGoals > this.score.AwayTeamGoals ? this.homeTeam : this.awayTeam;
        }

        private bool IsDraw()
        {
            return this.score.AwayTeamGoals == this.score.HomeTeamGoals;
        }

        public override string ToString()
        {
            return string.Format("{0} / {1} : {3} {2}", this.homeTeam.Name, this.awayTeam.Name, this.Score.AwayTeamGoals, this.Score.HomeTeamGoals);
        }
    }
}
