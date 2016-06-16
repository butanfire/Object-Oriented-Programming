namespace MassEffect.Interfaces
{    
    using System.Collections.Generic;
    using Engine.Commands.Factories;
    using GameObjects;

    public interface IGameEngine
    {
        ShipFactory ShipFactory { get; }        

        IList<IStarship> Starships { get; }

        Galaxy Galaxy { get; }

        ICommandManager CommandManager { get; }

        bool IsRunning { get; set; }

        void Run();
    }
}
