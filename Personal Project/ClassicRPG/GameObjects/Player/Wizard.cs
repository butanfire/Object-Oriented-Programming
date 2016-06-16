namespace ClassicRPG.GameObjects.Player
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework;
    using System;
    using GameEngine.Animation;
    using System.Linq;

    /// <summary>
    /// Specific class implementation
    /// </summary>
    public class Wizard : Character
    {
        private const int WizardWidth = 120;
        private const int WizardHeight = 170;
        private const int WizardHealth = 200;
        private const double WizardMana = 300f;

        public Wizard(int health, double mana) : base(health, mana)
        {
            this.Health = WizardHealth;
            this.Mana = WizardMana;
            this.Width = WizardWidth;
            this.Height = WizardHeight;
        }

        private void ManaRegen()
        {
            if (this.Mana < WizardMana)
            {
                this.Mana += 0.1;
            }
        }
        
        public override void MovementAnimation(GameTime gameTime)
        {
            var velocity = GetDesiredVelocityFromInput();
            this.PlayerXCoordinates += velocity.X * (float)gameTime.ElapsedGameTime.TotalSeconds;
            this.PlayerYCoordinates += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (velocity != Vector2.Zero)
            {
                bool movingHorizontally = Math.Abs(velocity.X) > Math.Abs(velocity.Y);
                if (movingHorizontally)
                {
                    if (velocity.X > 0)
                    {
                        PlayerCurrentAnimation = AnimationController.PlayerMovementByName("WalkRight");
                    }
                    else
                    {
                        PlayerCurrentAnimation = AnimationController.PlayerMovementByName("WalkLeft"); ;
                    }
                }
                else
                {
                    if (velocity.Y > 0)
                    {
                        PlayerCurrentAnimation = AnimationController.PlayerMovementByName("WalkDown"); ;
                    }
                    else
                    {
                        PlayerCurrentAnimation = AnimationController.PlayerMovementByName("WalkUp"); ;
                    }
                }
            }
            else
            {
                // If the character was walking, we can set the standing animation according to the walking animation
                Animation standing = AnimationController.PlayerStand.FirstOrDefault(s => s.Key.Name == PlayerCurrentAnimation.Name).Value;
                if (standing == null) { } //to avoid situations where the current animation is already set to Stand
                else
                {
                    PlayerCurrentAnimation = standing;
                }
            }
            PlayerCurrentAnimation.Update(gameTime);
        }

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            PlayerTexture = Content.Load<Texture2D>("WizardWalkRight");
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            MovementAnimation(gameTime);
            ManaRegen();

        }

        public override void Draw(SpriteBatch sprite, GameTime gameTime)
        {
            Vector2 playerPosition = new Vector2(this.PlayerXCoordinates, this.PlayerYCoordinates);
            var sourceRectangle = this.PlayerCurrentAnimation.currentRectangle;
            sprite.Draw(PlayerTexture, playerPosition, sourceRectangle, Color.White);
            base.Draw(sprite, gameTime);
        }

    }
}
