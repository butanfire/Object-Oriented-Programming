namespace MassEffect.GameObjects.Ships
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Enhancements;
    using Locations;
    using Interfaces;
    using Engine;
    using Exceptions;
    using System.Linq;

    public abstract class StarShip : IStarship
    {
        private string name;
        private int health;
        private int shields;
        private int damage;
        private double fuel;
        private StarSystem location;
        private List<Enhancement> enhancements;

        protected StarShip(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Shields = shields;
            this.Damage = damage;
            this.Health = health;
            this.Name = name;
            this.Location = location;
            this.Fuel = fuel;
            this.enhancements = new List<Enhancement>();
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("StarShip : Damage cannot be negative");
                }

                this.damage = value;
            }
        }

        public IEnumerable<Enhancement> Enhancements => this.enhancements;

        public double Fuel
        {
            get
            {
                return this.fuel;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("StarShip : Fuel cannot be negative");
                }

                this.fuel = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value <= 0)
                {
                    this.health = 0;
                    throw new ShipException(string.Format(Messages.ShipDestroyed, this.Name));
                }

                this.health = value;
            }
        }

        public StarSystem Location
        {
            get
            {
                return this.location;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Location cannot be null");
                }

                this.location = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("StarShip : Name cannot be null");
                }

                this.name = value;
            }
        }

        public int Shields
        {
            get
            {
                return this.shields;
            }

            set
            {
                this.shields = value < 0 ? 0 : value;
            }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            if (enhancement == null)
            {
                throw new ArgumentException("Enhancement cannot be null");
            }

            this.enhancements.Add(enhancement);
            {
                if (enhancement.DamageBonus > 0)
                {
                    this.Damage += enhancement.DamageBonus;
                }

                if (enhancement.FuelBonus > 0)
                {
                    this.Fuel += enhancement.FuelBonus;
                }

                if (enhancement.ShieldBonus > 0)
                {
                    this.Shields += enhancement.ShieldBonus;
                }
            }
        }

        public abstract IProjectile ProduceAttack();

        public virtual void RespondToAttack(IProjectile attack)
        {
            attack.Hit(this);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("--{0} - {1}", this.Name, this.GetType().Name));
            if (this.Health <= 0)
            {
                output.Append("(Destroyed)");
            }
            else
            {
                output.AppendLine(string.Format("-Location: {0}", this.Location.Name));
                output.AppendLine(string.Format("-Health: {0}", this.Health));
                output.AppendLine(string.Format("-Shields: {0}", this.Shields));
                output.AppendLine(string.Format("-Damage: {0}", this.Damage));
                output.AppendLine(string.Format("-Fuel: {0:F1}", this.Fuel));
                output.AppendLine(string.Format("-Enhancements: {0}", this.Enhancements.Any() ? string.Join(", ", this.Enhancements.Select(s => s.Name).ToList()) : "N/A"));
            }

            return output.ToString().TrimEnd();
        }
    }
}
