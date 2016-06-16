namespace Blobs.Models
{
    using Attack;
    using Interfaces;
    using System;

    public class Blob : IBlob
    {
        private int health;

        public Blob(string name, int health, int damage, IBehavior behavior, AttackType attacktype)
        {
            this.Name = name;
            this.Health = health;
            this.InitialHealth = health;
            this.Damage = damage;
            this.InitialDamage = damage;
            this.BehaviorType = behavior;
            this.AttackType = attacktype;
        }

        public AttackType AttackType { get; set; }

        public IBehavior BehaviorType { get; set; }

        public bool Alive => this.Health > 0;

        public int Damage { get; set; }

        public int Health
        {
            get { return this.health; }

            set
            {
                this.health = value < 0 ? 0 : value;

                if (this.Health <= this.InitialHealth / 2 && !this.BehaviorType.Triggered)
                {
                    this.BehaviorType.ApplyEffect(this);
                    this.OnToggleBehavior?.Invoke(this, EventArgs.Empty);
                }

                if (!this.Alive)
                {
                    this.OnBlobDeath?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public int InitialDamage { get; set; }

        public int InitialHealth { get; set; }

        public string Name { get; set; }

        public void RespondToAttack(IAttack attack)
        {
            attack.Hit(this);
        }

        public IAttack ProduceAttack()
        {
            if (this.AttackType == AttackType.PutridFart)
            {
                return new PutridFart(this.Damage);
            }
            if (this.AttackType == AttackType.Blobplode)
            {
                if (this.Health / 2 > 1)
                {
                    this.Health -= this.Health / 2;
                    return new Blobplode(this.Damage);
                }
            }

            return null;
        }

        public void UpdateBlob()
        {
            switch (this.BehaviorType.Name)
            {
                case "Aggressive":
                    if (this.Damage > this.InitialDamage)
                    {
                        if (this.BehaviorType.Triggered && this.Alive)
                        {
                            this.BehaviorType.ApplyDebuff(this);
                        }
                    }
                    else
                    {
                        this.Damage = this.InitialDamage;
                    }
                    break;
                case "Inflated":
                    if (this.BehaviorType.Triggered && this.Alive)
                    {
                        this.BehaviorType.ApplyDebuff(this);
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return $"Blob {this.Name}: {this.Health} HP, {this.Damage} Damage";
        }

        public event EventHandlers.OnToggleBehaviorEventHandler OnToggleBehavior;

        public event EventHandlers.OnBlobDeathEventHandler OnBlobDeath;
    }
}
