namespace ClassicRPG.GameObjects.Enemies
{
    using Interfaces;

    public abstract class Enemy : IEnemy
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int Damage { get; set; }

        public float PositionX { get; set; }

        public float PositionY { get; set; }

        public bool Active { get; set; }

        public int Health { get; set; }
    }
}
