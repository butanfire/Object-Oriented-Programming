namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;

    public class ShieldReaver : Projectile
    {
        public ShieldReaver(int damage) : base(damage) { }

        public override void Hit(IStarship ship)
        {
            ship.Shields -= (2 * this.Damage);
            ship.Health -= this.Damage;
        }
    }
}
