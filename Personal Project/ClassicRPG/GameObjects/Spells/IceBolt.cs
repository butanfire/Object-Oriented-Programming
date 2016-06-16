namespace ClassicRPG.GameObjects.Spells
{
    using GameEngine.Animation;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class IceBolt : SpellProjectile
    {
        private Animation IceBoltAnimation;
        private const int Iceboltdamage = 30;
        private int Iceboltspeed = 10;
        private const int IceboltmanaCost = 15;
        private const int IceboltWidth = 75;
        private const int IceboltHeight = 75;

        public IceBolt(Vector2 coordinates, int damage, int speed, int manaCost) : base(coordinates, damage, speed, manaCost)
        {
            this.Active = true;
            this.DestinationCoordinates = coordinates;
            this.Damage = Iceboltdamage;
            this.Speed = Iceboltspeed;
            this.ManaCost = IceboltmanaCost;
            this.Height = IceboltHeight;
            this.Width = IceboltWidth;
            
        }
        
        public void ProjectileAnimation(GameTime gameTime, Vector2 destination)
        {
            var velocity = this.GetDesiredVelocity(destination);
            this.PositionX += velocity.X * (float)gameTime.ElapsedGameTime.TotalSeconds * this.Speed;
            this.PositionY += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds * this.Speed;
            var destionationReached = new Vector2(this.PositionX, this.PositionY);
            if (Vector2.Distance(destination, destionationReached) < 5)
            {
                this.Active = false;
            }
        }

        public override void LoadContent(ContentManager Content)
        {
            this.Texture = Content.Load<Texture2D>("IceSmallSpell");
            this.IceBoltAnimation = AnimationController.ProjectileByName("Icebolt");
            base.LoadContent(Content);
        }
        
        public override void Update(GameTime gameTime)
        {
            ProjectileAnimation(gameTime, this.DestinationCoordinates);
            this.IceBoltAnimation.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            var newPosition = new Vector2(this.PositionX, this.PositionY);
            var sourceRectangle = this.IceBoltAnimation.currentRectangle;
            spriteBatch.Draw(this.Texture, newPosition, sourceRectangle, Color.White);
        }
    }

}

