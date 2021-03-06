﻿namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;

    public class Laser : Projectile
    {
        public Laser(int damage) : base(damage) { }

        public override void Hit(IStarship ship)
        {

            int massiveDmg = ship.Shields - this.Damage;
            if (massiveDmg < 0)
            {
                ship.Shields = 0;
                ship.Health += massiveDmg;
            }
            else
            {
                ship.Shields = ship.Shields - this.Damage;
            }
        }
    }
}
