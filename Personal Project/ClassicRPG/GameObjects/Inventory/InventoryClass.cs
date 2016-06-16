namespace ClassicRPG.GameObjects.Inventory
{
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Interfaces;
    using Player;

    public class InventoryClass
    {
        public bool Active { get; set; }
        private Texture2D _inventorySprite;

        public InventoryClass() { }

        public void Load(ContentManager content)
        {
            this._inventorySprite = content.Load<Texture2D>("Inventory");
        }

        public void Draw(SpriteBatch sprite,Character test)
        {
            if (Active == true)
            {
                sprite.Draw(this._inventorySprite, new Vector2(test.PlayerXCoordinates+150, test.PlayerYCoordinates));
            }
        }

        public void Update(GameTime gameTime)
        {

            if (IMouseController.KeyPressed(Keys.I))
            {
                Active = true;
            }
            if (IMouseController.KeyPressed(Keys.O))
            {
                Active = false;
            }
        }
    }
}
