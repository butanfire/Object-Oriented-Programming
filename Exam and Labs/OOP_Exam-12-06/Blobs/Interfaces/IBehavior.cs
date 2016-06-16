namespace Blobs.Interfaces
{
    public interface IBehavior
    {
        string Name { get; set; }

        int DamageBonus { get; set; }

        int HealthBonus { get; set; }

        bool Triggered { get; set; }

        void ApplyEffect(IBlob blob);

        void ApplyDebuff(IBlob blob);
    }
}
