
namespace MassEffect.Engine.Commands
{
    using System.Collections.Generic;
    using System.Text;
    using MassEffect.Interfaces;
    using System.Linq;
    using System;
    using Exceptions;

    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine) : base(gameEngine) { }

        public override void Execute(string[] commandArgs)
        {
            StringBuilder output = new StringBuilder();
            string locationName = commandArgs[1];
            try {
                IEnumerable<IStarship> intactShips = GameEngine.Starships
                    .Where(s => s.Location.Name == commandArgs[1])
                    .Where(s => s.Health > 0)
                    .OrderByDescending(s => s.Health)
                    .OrderByDescending(s => s.Shields);

                output.AppendLine("Intact ships:");
                output.AppendLine(intactShips.Any() ? string.Join("\n", intactShips) : "N/A");

                IEnumerable<IStarship> destroyedShips = GameEngine.Starships
                    .Where(s => s.Health == 0 && s.Location.Name == commandArgs[1])
                    .OrderBy(s => s.Name);

                output.AppendLine("Destroyed ships:");
                output.AppendLine(destroyedShips.Any() ? string.Join("\n", destroyedShips) : "N/A");
            }
            catch (ShipException)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
