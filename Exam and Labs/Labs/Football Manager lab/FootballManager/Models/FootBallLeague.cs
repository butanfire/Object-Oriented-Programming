namespace FootballLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class FootBallLeague
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams => teams;

        public static IEnumerable<Match> Matches => matches;

        public static void AddTeam(Team team)
        {
            if (CheckDuplicateTeam(team))
            {
                throw new InvalidOperationException("FootBallLeague : Cannot add duplicate team");

            }

            teams.Add(team);
        }

        public static void AddMatches(Match match)
        {
            if (CheckMatchId(match))
            {
                throw new InvalidOperationException("FootBallLeague : Cannot add duplicate ID" + match.ID);
            }

            matches.Add(match);
        }

        private static bool CheckMatchId(Match match)
        {
            return Matches.Any(p => p.ID == match.ID);
        }

        private static bool CheckDuplicateTeam(Team team)
        {
            return Teams.Any(p => p.Name == team.Name);
        }
    }
}
