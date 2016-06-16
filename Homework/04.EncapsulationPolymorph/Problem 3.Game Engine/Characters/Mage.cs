namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Mage : Character, IAttack
    {
        private int attackPoints;

        public Mage(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range) : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealthPoints = 150;
            this.DefensePoints = 50;
            this.AttackPoints = 300;
            this.Range = 5;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Attack points cannot be negative");
                }

                this.attackPoints = value;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
            if (!(item is Bonus))
            {
                this.AttackPoints += item.AttackEffect;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(s => s.IsAlive).LastOrDefault(s=>s.Team != this.Team);
        }

        public override void RemoveFromInventory(Item item)
        {
            if (item is Bonus)
            {
                this.RemoveItemEffects(item);
            }

            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            return base.ToString() + " Attack: " + this.AttackPoints;
        }
    }
}
