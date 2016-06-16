namespace MassEffect.Engine.Commands
{
    using System;
    using MassEffect.Interfaces;
    using Exceptions;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public virtual IGameEngine GameEngine { get; set; }

        public virtual void Execute(string[] commandArgs)
        {   
        }

        protected void ValidateAlive(IStarship ship)
        {
            if (ship != null)
            {
                if (ship.Health <= 0)
                {
                    throw new ShipException(string.Format(Messages.ShipAlreadyDestroyed));
                }
            }
            else
            {
                throw new ShipException(string.Format(Messages.NoSuchShipInStarSystem));
            }
        }

        public virtual void ProcessStarShipBattle(IStarship attackingShip, IStarship targetShip)
        {
        }
        
    }
}
