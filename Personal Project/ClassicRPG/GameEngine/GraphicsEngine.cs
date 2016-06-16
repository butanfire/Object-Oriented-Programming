namespace ClassicRPG.GameEngine
{
    using System.Collections.Generic;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using GameObjects.Enemies;
    using GameObjects.Inventory;
    using GameObjects.Player;
    using Microsoft.Xna.Framework.Input;

    public class GraphicsEngine : GameComponent, IGraphicsEngine
    {
        // private DataEngine data;

        private List<Enemy> enemies;
        private ICharacter player1 = new Wizard(0, 0);
        private List<IProjectile> projectileList;
        private InventoryClass TestInvent;
        private ContentManager Content;

        public GraphicsEngine(Game game, ContentManager content) : base(game)
        {
            this.Content = content;
            this.projectileList = new List<IProjectile>();
            this.enemies = new List<Enemy>();
            this.TestInvent = new InventoryClass();
        }

        public void CharacterCastProjectileSpells(GameTime gameTime)
        {
            var projectile = ((Wizard)player1).CastSpell(SpellBook.SpellSelected);
            if (projectile != null)
            {
                projectile.LoadContent(Content);
                this.projectileList.Add(projectile);
            }
        }

        public void RemoveEntities(GameTime gameTime)
        {
            for (var i = 0; i < projectileList.Count; i++)
            {
                projectileList[i].Update(gameTime);
                if (projectileList[i].Active == false)
                {
                    projectileList.Remove(projectileList[i]);
                }
            }
        }

        public void LoadContent(ContentManager Content)
        {
            ((Wizard)player1).LoadContent(Content);
            TestInvent.Load(Content);

            #region input
            IMouseController.currentMouseState = Mouse.GetState();
            IMouseController.previousMouseState = IMouseController.currentMouseState;

            IMouseController.currentKeyboardState = Keyboard.GetState();
            IMouseController.previousKeyboardState = IMouseController.currentKeyboardState;
            #endregion
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            if (player1.Active != false)
            {
                player1.Draw(spriteBatch, gameTime); //draw player
            }
            if (this.projectileList.Count > 0)
            {
                foreach (var projectile in this.projectileList)
                {

                    projectile.Draw(spriteBatch);
                    if (projectile.Active == false)
                    {
                        projectileList.Remove(projectile);
                    }
                }
            }
            TestInvent.Draw(spriteBatch, (Character)this.player1); //draw Inventory
        }

        public override void Update(GameTime gameTime)
        {
            #region input
            IMouseController.previousKeyboardState = IMouseController.currentKeyboardState;
            IMouseController.currentKeyboardState = Keyboard.GetState();

            IMouseController.previousMouseState = IMouseController.currentMouseState;
            IMouseController.currentMouseState = Mouse.GetState();
            #endregion

            TestInvent.Update(gameTime);
            ((Wizard)player1).Update(gameTime);

            SpellBook.SpellSelection();
            if (IMouseController.MouseRightButtonClicked())
            {
                CharacterCastProjectileSpells(gameTime);
            }

            RemoveEntities(gameTime);
            base.Update(gameTime);
        }
    }
}




