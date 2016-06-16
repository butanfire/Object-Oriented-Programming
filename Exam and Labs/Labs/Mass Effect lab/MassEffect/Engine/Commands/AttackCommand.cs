namespace MassEffect.Engine.Commands
{
    using Exceptions;
    using Interfaces;
    using System;
    using System.Linq;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            if (string.IsNullOrEmpty(targetName))
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }
            IStarship attackingShip = null, targetShip = null;
            try
            {
                attackingShip = GameEngine.Starships.SingleOrDefault(s => s.Name == attackerName);
                targetShip = GameEngine.Starships.SingleOrDefault(s => s.Name == targetName);
            }
            catch (ShipException)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }

            this.ProcessStarShipBattle(attackingShip, targetShip);
        }

        public override void ProcessStarShipBattle(IStarship attackingShip, IStarship targetShip)
        {
            base.ValidateAlive(attackingShip);
            base.ValidateAlive(targetShip);

            if (attackingShip == targetShip)
            {
                throw new ShipException(string.Format(Messages.DuplicateShipName));
            }
            if (targetShip.Location != attackingShip.Location)
            {
                throw new ShipException(string.Format(Messages.NoSuchShipInStarSystem));
            }

            IProjectile attack = attackingShip.ProduceAttack();

            Console.WriteLine(Messages.ShipAttacked, attackingShip.Name, targetShip.Name);

            if (targetShip.GetType().Name == "Dreadnought")
            {
                if (attackingShip.Damage >= targetShip.Health + targetShip.Shields + 50)
                {
                    targetShip.Health = 0;
                    throw new ShipException(string.Format(Messages.ShipDestroyed, targetShip.Name));
                }

                targetShip.RespondToAttack(attack);
            }
            else
            {
                if (attackingShip.Damage >= targetShip.Health + targetShip.Shields)
                {
                    targetShip.Health = 0;
                    throw new ShipException(string.Format(Messages.ShipDestroyed, targetShip.Name));
                }

                targetShip.RespondToAttack(attack);
            }
            if (targetShip.Shields < 0)
            {
                targetShip.Shields = 0;
            }

            
        }
    }
}
