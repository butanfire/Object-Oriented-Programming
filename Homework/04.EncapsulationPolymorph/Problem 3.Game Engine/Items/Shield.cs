namespace TheSlum.Items
{
    public class Shield : Item
    {
        public Shield(string id, int healthEffect, int defenseEffect, int attackEffect) : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.AttackEffect = 0;
            this.HealthEffect = 0;
            this.DefenseEffect = 50;
        }
    }
}
