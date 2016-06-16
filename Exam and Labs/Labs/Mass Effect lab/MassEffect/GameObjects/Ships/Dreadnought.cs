

namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Locations;
    using MassEffect.Interfaces;

    class Dreadnought : StarShip
    {
        private readonly int ConstHealth = 200;
        private readonly int ConstShields = 300;
        private readonly int ConstDamage = 150;
        private readonly double ConstFuel = 700;

        public Dreadnought(string name, int health, int shields, int damage, double fuel, StarSystem location): base(name, health, shields, damage, fuel, location)
        {
            this.Health = ConstHealth;
            this.Shields = ConstShields;
            this.Damage = ConstDamage;
            this.Fuel = ConstFuel;
            this.Location = location;
        }

        public override IProjectile ProduceAttack()
        {
            var projectile = new Projectiles.Laser((this.Shields > 0 ? this.Shields / 2 : 0) + this.Damage);
            return projectile;
        }

        public override void RespondToAttack(IProjectile attack)
        {            
            this.Shields += 50;
            base.RespondToAttack(attack);
            this.Shields = this.Shields - 50 > 0 ? this.Shields - 50 : 0;
        }
    }
}
