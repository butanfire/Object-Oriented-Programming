namespace Blobs.Models.Attack
{
    using Interfaces;

    public class Blobplode : Attack
    {
        public Blobplode(int damage) : base(damage)
        {
        }

        public override void Hit(IBlob blob)
        {
            blob.Health -= 2*this.Damage;
        }
    }
}
