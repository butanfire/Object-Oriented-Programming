namespace ClassicRPG.GameObjects.Projectile
{
    using System.Collections.Generic;
    using Interfaces;
    using Microsoft.Xna.Framework;
    using GameEngine.Animation;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Content;

    /// <summary>
    /// Projectile class, for collision and movement
    /// </summary>
    public abstract class Projectiles : IProjectile
    {
        private Animation projectileAnimation;

        public int Width { get; set; }

        public int Height { get; set; }

        public int Damage { get; set; }

        public int Speed { get; set; }

        public float PositionX { get; set; }

        public float PositionY { get; set; }

        public bool Active { get; set; }

        public Vector2 DestinationCoordinates { get; set; }

        public Texture2D Texture { get; set; }

        protected Projectiles(int damage, int speed)
        {
            this.Damage = damage;
            this.Speed = speed;
        }

        public static void ProjectileCollision(List<IEnemy> enemies, IProjectile projectile)
        {
            // Use the Rectangle’s built-in intersect function to

            // determine if two objects are overlapping

            Rectangle rectangle1;
            Rectangle rectangle2;

            // Only create the rectangle once for the player

            rectangle1 = new Rectangle((int)projectile.PositionX,

                (int)projectile.PositionY,

                projectile.Width,

                projectile.Height);

            // Do the collision between the player and the enemies

            for (int i = 0; i < enemies.Count; i++)
            {
                rectangle2 = new Rectangle((int)enemies[i].PositionX, (int)enemies[i].PositionY, enemies[i].Width, enemies[i].Height);

                if (rectangle1.Intersects(rectangle2)) // Determine if the two objects collided with each other
                {
                    enemies[i].Health -= projectile.Damage;  // Subtract the health from the enemy based on the projectile damage

                    if (enemies[i].Health <= 0)
                    {
                        enemies[i].Active = false; //If the enemy health is less than zero it dies
                    }
                }
            }
        }

        public Vector2 GetDesiredVelocity(Vector2 destination)
        {
            var desiredVelocity = new Vector2(0, 0);
            desiredVelocity.X = destination.X - this.PositionX;
            desiredVelocity.Y = destination.Y - this.PositionY;

            if (desiredVelocity.X != 0 || desiredVelocity.Y != 0)
            {
                desiredVelocity.Normalize();
                const float desiredSpeed = 30;
                desiredVelocity *= desiredSpeed;
            }
            return desiredVelocity;
        }

        public virtual void LoadContent(ContentManager Content){ }

        public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(SpriteBatch spriteBatch) { }

    }
}

