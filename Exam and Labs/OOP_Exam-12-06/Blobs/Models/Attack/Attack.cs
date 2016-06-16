namespace Blobs.Models.Attack
{
    using Interfaces;

    public abstract class Attack : IAttack
    {
        public Attack(int damage)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }

        public abstract void Hit(IBlob blob);
    }
}
