namespace ClassicRPG.GameObjects.Player
{
    using Interfaces;
    using Microsoft.Xna.Framework.Input;

    /// <summary>
    /// Controlling which spell is active.
    /// </summary>
    public static class SpellBook
    {
        private static string[] spellbook = { "Fireball", "IceBolt" };
        public static string SpellSelected = "Fireball";
        public static string SpellSelection()
        {
            if (IMouseController.KeyPressed(Keys.Q))
            {
                SpellSelected = spellbook[0];
            }
            if (IMouseController.KeyPressed(Keys.W))
            {
                SpellSelected = spellbook[1];
            }
            return "";
        }
    }
}
