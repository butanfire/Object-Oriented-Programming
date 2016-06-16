namespace Blobs.Interfaces
{
    public interface IAttack
    {
        int Damage { get; set; }

        void Hit(IBlob blob);
    }
}
