namespace Blobs.Models.Behavior
{
    using Interfaces;

    public abstract class Behavior : IBehavior
    {
        public Behavior(string name, int damage, int health)
        {
            this.DamageBonus = damage;
            this.HealthBonus = health;
            this.Name = name;
        }

        public string Name { get;  set; }
        public int DamageBonus { get;  set; }
        public int HealthBonus { get;  set; }
                
        public abstract bool Triggered { get; set; }

        public virtual void ApplyEffect(IBlob blob)
        {
            this.Triggered = true;            
        }

        public abstract void ApplyDebuff(IBlob blob);
    }
}
