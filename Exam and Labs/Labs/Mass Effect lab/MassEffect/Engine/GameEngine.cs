namespace MassEffect.Engine
{
    using System;
    using System.Collections.Generic;
    using Exceptions;
    using GameObjects;
    using Interfaces;
    using Commands.Factories;

    public sealed class GameEngine : IGameEngine
    {
        public GameEngine(ICommandManager commandManager, Galaxy galaxy)
        {
            this.CommandManager = commandManager;
            this.Galaxy = galaxy;
            this.ShipFactory = new ShipFactory();
            this.Starships = new List<IStarship>();
        }

        public ShipFactory ShipFactory { get; }

        public IList<IStarship> Starships { get; }

        public Galaxy Galaxy { get; }

        public ICommandManager CommandManager { get; set; }

        public bool IsRunning { get; set; }

        public void Run()
        {
            this.IsRunning = true;
            this.CommandManager.Engine = this;
            this.CommandManager.SeedCommands();

            do
            {
                string command = Console.ReadLine();

                try
                {
                    this.CommandManager.ProcessCommand(command);
                }
                catch (ShipException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
            while (this.IsRunning);
        }
    }
}
