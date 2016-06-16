namespace FootballLeague.Models
{
    using System;
    using System.Linq;

    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    FootBallLeague.AddTeam(new Team(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3])));
                    Console.WriteLine("Team added");
                    break;
                case "AddMatch":
                    if (FootBallLeague.Teams.All(p => p.Name != inputArgs[2]) || FootBallLeague.Teams.All(p => p.Name != inputArgs[3]))
                    {
                        throw new InvalidOperationException("Add Match : Team does not exist");
                    }

                    FootBallLeague.AddMatches(new Match(int.Parse(inputArgs[1]),
                        FootBallLeague.Teams.First(p => p.Name == inputArgs[2]),
                        FootBallLeague.Teams.First(p => p.Name == inputArgs[3]),
                        new Score(int.Parse(inputArgs[4]), int.Parse(inputArgs[5]))));
                    Console.WriteLine("Match added");
                    break;
                case "AddPlayerToTeam":
                    if (FootBallLeague.Teams.All(p => p.Name != inputArgs[5]))
                    {
                        throw new InvalidOperationException("AddPlayer To Team : Team does not exist");
                    }

                    FootBallLeague.Teams.First(p => p.Name == inputArgs[5]).
                        AddPlayer(new Player(inputArgs[1],
                        inputArgs[2],
                        DateTime.Parse(inputArgs[3]),
                        Decimal.Parse(inputArgs[4]),
                        FootBallLeague.Teams.First(p => p.Name == inputArgs[5])));
                    Console.WriteLine("Player added");
                    break;
                case "ListTeams":
                    foreach (Team s in FootBallLeague.Teams)
                    {
                        Console.WriteLine(s.ToString());
                    }

                    break;
                case "ListMatches":
                    foreach (Match s in FootBallLeague.Matches)
                    {
                        Console.WriteLine(s.ToString());
                    }

                    break;
            }
        }
    }
}
