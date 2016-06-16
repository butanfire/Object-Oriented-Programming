namespace Blobs.Models.Attack
{
    using Interfaces;

    public class PutridFart : Attack
    {
        public PutridFart(int damage) : base(damage)
        {
        }

        public override void Hit(IBlob blob)
        {
            blob.Health -= this.Damage;
        }
    }
}
