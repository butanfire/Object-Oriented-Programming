namespace ClassicRPG.GameEngine
{
    using System.Collections.Generic;

    using Interfaces;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using GameObjects.Inventory;

    public class DataEngine : IData
    {
        public Texture2D Player1;
        public InventoryClass TestInvent;
        public Texture2D Enemy;
        private ContentManager Content;

        public DataEngine(ContentManager Content)
        {
            this.Content = Content;
        }
        
        public List<IItem> ItemDB { get; }

        public void AddItems(IItem item)
        {
            this.ItemDB.Add(item);
        }
    }

}

