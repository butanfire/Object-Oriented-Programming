namespace ClassicRPG.GameObjects.Spells
{
    using Projectile;
    using Microsoft.Xna.Framework;

    public abstract class SpellProjectile : Projectiles
    {
        protected SpellProjectile(Vector2 coordinates, int damage, int speed, int manaCost) : base(damage, speed) { }

        public int ManaCost
        {
            get;protected set;
        }
    }
}
