namespace Blobs.Interfaces
{
    using Models.Attack;

    public interface IBlob
    {
        int InitialHealth { get; set; }

        int InitialDamage { get; set; }

        string Name { get; set; }

        int Health { get; set; }

        int Damage { get; set; }

        bool Alive { get; }

        void UpdateBlob();

        IAttack ProduceAttack();

        void RespondToAttack(IAttack attack);

        AttackType AttackType { get; set; }

        IBehavior BehaviorType { get; set; }
    }
}
