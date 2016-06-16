namespace Blobs.Models.Behavior
{
    using Interfaces;

    public class AggressiveBehavior : Behavior
    {
        private const string AggroBehavior = "Aggressive";

        public AggressiveBehavior(string name = AggroBehavior, int damage = 0, int health = 0) : base(name, damage, health)
        {
            this.Name = AggroBehavior;
        }

        public override bool Triggered { get; set; }

        public override void ApplyDebuff(IBlob blob)
        {
            blob.Damage -= 5;
        }

        public override void ApplyEffect(IBlob blob)
        {
            blob.Damage *= 2;
            base.ApplyEffect(blob);
        }
    }
}
