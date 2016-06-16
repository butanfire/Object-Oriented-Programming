using System;

using System.Text;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Frigate : StarShip
    {
        private int projectilesFired;

        private readonly int ConstHealth = 60;
        private readonly int ConstShields = 50;
        private readonly int ConstDamage = 30;
        private readonly double ConstFuel = 220;

        public Frigate(string name, int health, int shields, int damage, double fuel, StarSystem location) :base(name,health,shields,damage,fuel, location)
        {
            this.Health = ConstHealth;
            this.Shields = ConstShields;
            this.Damage = ConstDamage;
            this.Fuel = ConstFuel;
            this.Location = location;
        }

        public int ProjectilesFired
        {
            get
            {
                return this.projectilesFired;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Frigate : Projectiles fired cannot be negative");
                }

                this.projectilesFired = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            if (this.Health > 0)
            {
                output.Append(string.Format("\n-Projectiles fired: {0}", this.ProjectilesFired));
            }

            return base.ToString() + output.ToString().TrimEnd();            
        }

        public override IProjectile ProduceAttack()
        {
            this.ProjectilesFired++;
            return new Projectiles.ShieldReaver(this.Damage);
        }
    }
}
