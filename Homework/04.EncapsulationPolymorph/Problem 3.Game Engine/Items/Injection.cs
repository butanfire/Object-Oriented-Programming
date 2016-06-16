namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        public Injection(string id, int healthEffect, int defenseEffect, int attackEffect) : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.HealthEffect = 200;
            this.Countdown = 3;  
        }
    }
}
