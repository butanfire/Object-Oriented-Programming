namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;
    using System;
    using GameObjects.Ships;
    using System.Linq;
    using Exceptions;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            IStarship ship = null;
            try
            {
                ship = GameEngine.Starships.Single(s => s.Name == shipName);
            }
            catch (ShipException)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
            Console.WriteLine(ship.ToString());
        }
    }
}
