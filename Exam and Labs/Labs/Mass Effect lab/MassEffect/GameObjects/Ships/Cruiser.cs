namespace MassEffect.GameObjects.Ships
{
    using Locations;
    using Interfaces;

    public class Cruiser : StarShip
    {
        private readonly int ConstHealth = 100;
        private readonly int ConstShields = 100;
        private readonly int ConstDamage = 50;
        private readonly double ConstFuel = 300;

        public Cruiser(string name, int health, int shields, int damage, double fuel, StarSystem location) : base(name, health, shields, damage, fuel, location)
        {
            this.Health = ConstHealth;
            this.Shields = ConstShields;
            this.Damage = ConstDamage;
            this.Fuel = ConstFuel;
            this.Location = location;
        }
        public override IProjectile ProduceAttack()
        {
            return new Projectiles.PenetrationShell(this.Damage);
        }
    }
}
