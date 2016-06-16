namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        public Pill(string id, int healthEffect, int defenseEffect, int attackEffect) : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.AttackEffect = 100;
            this.Countdown = 1;
        }
    }
}
