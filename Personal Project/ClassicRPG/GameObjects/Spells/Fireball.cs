namespace ClassicRPG.GameObjects.Spells
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using GameEngine.Animation;

    /// <summary>
    /// Spell implementation
    /// </summary>
    public class Fireball : SpellProjectile
    {
        private Animation FireBallAnimation;
        private const int FireBalldamage = 50;
        private int FireBallspeed = 10;
        private const int FireBallmanaCost = 30;
        private const int FireballWidth = 75;
        private const int FireballHeight = 75;

        public Fireball(Vector2 coordinates, int damage, int speed, int manaCost) : base(coordinates, damage, speed, manaCost)
        {
            this.Active = true;
            this.DestinationCoordinates = coordinates;
            this.Damage = FireBalldamage;
            this.Speed = FireBallspeed;
            this.ManaCost = FireBallmanaCost;
            this.Height = FireballHeight;
            this.Width = FireballWidth;       
        }

        public override void LoadContent(ContentManager Content)
        {
            this.Texture = Content.Load<Texture2D>("FireBallSmallSpell (1)");
            this.FireBallAnimation = AnimationController.ProjectileByName("Fireball");
            base.LoadContent(Content);
        }

        public void ProjectileAnimation(GameTime gameTime, Vector2 destination)
        {
            var velocity = this.GetDesiredVelocity(destination);
            this.PositionX += velocity.X * (float)gameTime.ElapsedGameTime.TotalSeconds * this.Speed;
            this.PositionY += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds * this.Speed;
            var destionationReached = new Vector2(this.PositionX, this.PositionY);
            if(Vector2.Distance(destination,destionationReached) < 5)
            {
                this.Active = false;
            }
        }

        public override void Update(GameTime gameTime)
        {   
            ProjectileAnimation(gameTime, this.DestinationCoordinates);
            this.FireBallAnimation.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            var newPosition = new Vector2(this.PositionX, this.PositionY);
            var sourceRectangle = this.FireBallAnimation.currentRectangle;
            spriteBatch.Draw(this.Texture, newPosition, sourceRectangle, Color.White);
        }
    }
}
