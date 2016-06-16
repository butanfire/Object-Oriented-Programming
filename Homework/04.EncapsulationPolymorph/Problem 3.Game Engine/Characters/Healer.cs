namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Healer : Character, IHeal
    {
        private int healingPoints;

        public Healer(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range) : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealthPoints = 75;
            this.DefensePoints = 50;
            this.HealingPoints = 60;
            this.Range = 6;
        }

        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Healing cannot be negative");
                }

                this.healingPoints = value;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(s => s.IsAlive && s.Id != this.Id).Where(s=>s.Team == this.Team).OrderBy(s => s.HealthPoints).FirstOrDefault();                        
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            if (item is Bonus)
            {
                this.RemoveItemEffects(item);
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Healing :" + this.HealingPoints;
        }
    }
}
