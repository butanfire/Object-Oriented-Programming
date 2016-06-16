namespace ClassicRPG.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// Used to define the projectiles and related data.
    /// </summary>
    public interface IProjectile
    {
        int Width { get; set; }
        int Height { get; set; }
        int Damage { get; set; }
        int Speed { get; set; }
        float PositionX { get; set; }
        float PositionY { get; set; }
        bool Active { get; set; }

        void Draw(SpriteBatch sprite);
        void LoadContent(ContentManager Content);
        void Update(GameTime gameTime);
    }
}
