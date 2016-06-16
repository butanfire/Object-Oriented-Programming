namespace Blobs.Models.Behavior
{
    using Interfaces;

    public class InflatedBehavior : Behavior
    {
        private const int InflatedHPBonus = 50;
        private const string Inflatedname = "Inflated";

        public InflatedBehavior(string name, int damage, int health) : base(name, damage, health)
        {
            this.Name = Inflatedname;
            this.HealthBonus = InflatedHPBonus;
        }

        public override bool Triggered { get; set; }

        public override void ApplyDebuff(IBlob blob)
        {
            blob.Health -= 10;
        }

        public override void ApplyEffect(IBlob blob)
        {
            blob.Health += this.HealthBonus;
            base.ApplyEffect(blob);
        }

    }
}
