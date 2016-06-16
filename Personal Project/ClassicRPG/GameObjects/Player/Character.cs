namespace ClassicRPG.GameObjects.Player
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using GameEngine.Animation;
    using Interfaces;
    using Microsoft.Xna.Framework.Input;
    using Spells;

    public abstract class Character : ICharacter
    {
        SpriteFont _spriteFont;
        private int health;
        string status;
        public double SpellCooldown = 0.5;

        protected Character(int health, double mana)
        {
            this.Health = health;
            this.Mana = mana;
            PlayerCurrentAnimation = AnimationController.PlayerMovementByName("WalkDown");
            this.Active = true;
        }
        
        public Animation PlayerCurrentAnimation { get; set; }
        public Texture2D PlayerTexture { get; set; }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (Health < 0)
                {
                    this.Active = false;
                }

                this.health = value;
            }
        }
        public double Mana { get; set; }

        public float PlayerXCoordinates { get; set; }
        public float PlayerYCoordinates { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool SpellSelection { get; set; }
        public bool Active { get; set; }

        public virtual void MovementAnimation(GameTime gameTime) { }

        public Vector2 GetDesiredVelocityFromInput()
        {
            Vector2 desiredVelocity = new Vector2(0, 0);
            var currentMouseState = Mouse.GetState();
            if (currentMouseState.LeftButton == ButtonState.Pressed)
            {
                desiredVelocity.X = currentMouseState.X - PlayerXCoordinates;
                desiredVelocity.Y = currentMouseState.Y - PlayerYCoordinates;
            }
            if (desiredVelocity.X != 0 || desiredVelocity.Y != 0)
            {
                desiredVelocity.Normalize();
                const float desiredSpeed = 100;
                desiredVelocity *= desiredSpeed;
            }
            return desiredVelocity;
        }

        public SpellProjectile CastIceSpell(Vector2 destination)
        {
            var iceBolt = new IceBolt(destination, 0, 0, 0);
            if (this.Mana > iceBolt.ManaCost && SpellCooldown <= 0)
            {
                SpellCooldown = 3;
                this.Mana -= iceBolt.ManaCost;
                iceBolt.PositionX = this.PlayerXCoordinates;
                iceBolt.PositionY = this.PlayerYCoordinates;
                return iceBolt;
            }
            return null;
        }
        public SpellProjectile CastFireSpell(Vector2 destination)
        {
            var fireball = new Fireball(destination, 0, 0, 0);
            if (this.Mana > fireball.ManaCost && SpellCooldown <= 0)
            {
                SpellCooldown = 3;
                this.Mana -= fireball.ManaCost;
                fireball.PositionX = this.PlayerXCoordinates;
                fireball.PositionY = this.PlayerYCoordinates;
                return fireball;
            }
            return null;
        }

        public SpellProjectile CastSpell(string spell)
        {
            switch (spell)
            {
                case "IceBolt":
                    return CastIceSpell(IMouseController.position);
                case "Fireball":
                    return CastFireSpell(IMouseController.position);
                default:
                    return null;
            }
        }

        public virtual void LoadContent(ContentManager Content)
        {
            this._spriteFont = Content.Load<SpriteFont>("PlayerStatus");
        }
        public virtual void Update(GameTime gameTime)
        {
            this.SpellCooldown -= 0.10;
        }
        public virtual void Draw(SpriteBatch sprite, GameTime gameTime)
        {
            this.status = string.Format("HP {0} MP {1:F0}", this.Health, this.Mana);
            sprite.DrawString(this._spriteFont, status.ToString(), new Vector2(this.PlayerXCoordinates - 10, this.PlayerYCoordinates), Color.White);
        }
    }
}
