namespace ClassicRPG.GameEngine.Animation
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;

    /// <summary>
    /// Used for storing and initializing all the animations - movement/projectile.
    /// </summary>
    public static class AnimationController
    {
        public static Dictionary<string, Animation> PlayerMovement;
        public static Dictionary<Animation, Animation> PlayerStand;
        public static Dictionary<string, Animation> Projectile;

        public static void Initialize()
        {
            InitializePlayerMovement();
            InitializeProjectile();
        }

        private static void InitializeProjectile()
        {
            Projectile = new Dictionary<string, Animation>();
            Animation FireBallAnimation = new Animation("Fireball");
            Animation IceBoltAnimation = new Animation("Icebolt");
            for (int i = 0; i < 4; i++)
            {
                FireBallAnimation.AddFrame(new Rectangle(i * 100, 100, 75, 75), TimeSpan.FromSeconds(0.25));
                IceBoltAnimation.AddFrame(new Rectangle(i * 100, 100, 75, 75), TimeSpan.FromSeconds(0.25));
            }
            Projectile.Add(IceBoltAnimation.Name, IceBoltAnimation);
            Projectile.Add(FireBallAnimation.Name, FireBallAnimation);
        }

        private static void InitializePlayerMovement()
        {
            PlayerStand = new Dictionary<Animation, Animation>();
            PlayerMovement = new Dictionary<string, Animation>();
            Animation PlayerWalkDownAnimation = new Animation("WalkDown");
            PlayerMovement.Add(PlayerWalkDownAnimation.Name, PlayerWalkDownAnimation);
            Animation PlayerWalkUpAnimation = new Animation("WalkUp");
            PlayerMovement.Add(PlayerWalkUpAnimation.Name, PlayerWalkUpAnimation);
            Animation PlayerWalkLeftAnimation = new Animation("WalkLeft");
            PlayerMovement.Add(PlayerWalkLeftAnimation.Name, PlayerWalkLeftAnimation);
            Animation PlayerWalkRightAnimation = new Animation("WalkRight");
            PlayerMovement.Add(PlayerWalkRightAnimation.Name, PlayerWalkRightAnimation);

            int[] frameList = { 0, 140, 260, 380 };

            for (int i = 0; i < 4; i++)
            {
                PlayerMovement["WalkDown"].AddFrame(new Rectangle(frameList[i], 0, 120, 170), TimeSpan.FromSeconds(.25));
                PlayerMovement["WalkUp"].AddFrame(new Rectangle(frameList[i], 760, 120, 170), TimeSpan.FromSeconds(.25));
                PlayerMovement["WalkLeft"].AddFrame(new Rectangle(frameList[i], 380, 120, 170), TimeSpan.FromSeconds(.25));
                PlayerMovement["WalkRight"].AddFrame(new Rectangle(frameList[i], 1150, 120, 170), TimeSpan.FromSeconds(.25));
            }

            //Standing animations only have a single frame of animation
            Animation PlayerStandDown = new Animation("StandDown");
            PlayerMovement.Add(PlayerStandDown.Name, PlayerWalkDownAnimation);
            PlayerStandDown.AddFrame(new Rectangle(380, 0, 120, 180), TimeSpan.FromSeconds(.50));

            Animation PlayerStandUp = new Animation("StandUp");
            PlayerMovement.Add(PlayerStandUp.Name, PlayerWalkDownAnimation);
            PlayerStandUp.AddFrame(new Rectangle(260, 760, 120, 180), TimeSpan.FromSeconds(.50));

            Animation PlayerStandLeft = new Animation("StandLeft");
            PlayerMovement.Add(PlayerStandLeft.Name, PlayerWalkDownAnimation);
            PlayerStandLeft.AddFrame(new Rectangle(500, 380, 120, 180), TimeSpan.FromSeconds(.50));

            Animation PlayerStandRight = new Animation("StandRight");
            PlayerMovement.Add(PlayerStandRight.Name, PlayerWalkDownAnimation);
            PlayerStandRight.AddFrame(new Rectangle(150, 1150, 120, 180), TimeSpan.FromSeconds(.50));

            PlayerStand.Add(PlayerWalkDownAnimation, PlayerStandDown);
            PlayerStand.Add(PlayerWalkUpAnimation, PlayerStandUp);
            PlayerStand.Add(PlayerWalkLeftAnimation, PlayerStandLeft);
            PlayerStand.Add(PlayerWalkRightAnimation, PlayerStandRight);
        }

        public static Animation PlayerMovementByName(string animation)
        {
            return PlayerMovement[animation];
        }

        public static Animation ProjectileByName(string animation)
        {
            return Projectile[animation];
        }
    }
}
