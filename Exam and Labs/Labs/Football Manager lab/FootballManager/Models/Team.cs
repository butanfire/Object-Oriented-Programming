namespace FootballLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private const int YearAllowed = 1850;
        private string name;
        private string nickname;
        private DateTime foundDate;
        private List<Player> players;

        public Team() { }
        public Team(string name, string nickname, DateTime foundDate)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.FoundDate = foundDate;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 5 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Team cannot be less than 5 characters" + value);
                }

                this.name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return this.nickname;
            }

            set
            {
                if (value.Length < 5 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nickname cannot be less than 5 characters" + value);
                }

                this.nickname = value;
            }
        }

        public DateTime FoundDate
        {
            get
            {
                return this.foundDate;
            }

            set
            {
                if (value.Year < YearAllowed)
                {
                    throw new ArgumentException("Team : Year cannot be earlier than " + YearAllowed);

                }

                this.foundDate = value;
            }
        }

        public IEnumerable<Player> Players => this.players;

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player " + player.FirstName + "already exists for the team");
            }

            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}-{3}-{4} ", this.Name, this.Nickname, this.FoundDate.Year, this.FoundDate.Month, this.FoundDate.Day);
        }
    }
}
