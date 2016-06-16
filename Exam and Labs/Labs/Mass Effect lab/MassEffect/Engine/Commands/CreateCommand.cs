namespace MassEffect.Engine.Commands
{
    using GameObjects.Ships;
    using Interfaces;
    using System;
    using System.Linq;
    using GameObjects.Enhancements;
    using Exceptions;
    using Factories;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string type = commandArgs[1];
            string shipName = commandArgs[2];
            string locationName = commandArgs[3];


            bool shipAlreadyExist = this.GameEngine.Starships.Any(s => s.Name == shipName);
            if (shipAlreadyExist)
            {
                throw new ShipException(string.Format(Messages.DuplicateShipName, shipName));
            }

            var location = this.GameEngine.Galaxy.GetStarSystemByName(locationName);
            StarshipType shipType = (StarshipType)Enum.Parse(typeof(StarshipType), type);

            ShipFactory shipBuilder = new ShipFactory();
            GameEngine.Starships.Add(shipBuilder.CreateShip(shipType, shipName, location));

            IStarship ship = GameEngine.Starships.Single(s => s.Name == shipName);
            for (int i = 4; i < commandArgs.Length; i++)
            {
                var enhancementType = (EnhancementType)Enum.Parse(typeof(EnhancementType), commandArgs[i]);

                Enhancement enhancement = EnhancementFactory.Create(enhancementType);
                ship.AddEnhancement(enhancement);
            }

            Console.WriteLine(Messages.CreatedShip, shipType, shipName);
        }
    }
}
