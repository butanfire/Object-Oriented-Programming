namespace TheSlum.Items
{
    public class Axe : Item
    {
        public Axe(string id, int healthEffect, int defenseEffect, int attackEffect) : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.HealthEffect = 0;
            this.DefenseEffect = 0;
            this.AttackEffect = 75;
        }
    }
}
