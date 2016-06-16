namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;
    using MassEffect.Interfaces;
    using GameObjects.Locations;
    using GameObjects;
    using Exceptions;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            string destinationName = commandArgs[2];

            IStarship ship = null;
            try {
                ship = GameEngine.Starships.SingleOrDefault(s => s.Name == commandArgs[1]);
            }
            catch (ShipException)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
            this.ValidateAlive(ship);

            var previousLocation = ship.Location;
            

            StarSystem destination = this.GameEngine.Galaxy.GetStarSystemByName(commandArgs[2]);

            if (previousLocation.Name == destinationName)
            {
                throw new ShipException(string.Format(Messages.ShipAlreadyInStarSystem, destinationName));
            }

            this.GameEngine.Galaxy.TravelTo(ship, destination);

            Console.WriteLine(Messages.ShipTraveled, shipName, previousLocation.Name, destinationName);
        }
    }
}
