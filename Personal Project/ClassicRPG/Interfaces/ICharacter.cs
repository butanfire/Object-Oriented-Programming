namespace ClassicRPG.Interfaces
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// Character parameters/stats and data.
    /// </summary>
    public interface ICharacter
    {
        int Health { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        bool Active { get; set; }
        void LoadContent(ContentManager Content);
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}
