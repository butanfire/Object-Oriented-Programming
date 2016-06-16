namespace ClassicRPG.GameEngine.Animation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Xna.Framework;

    public class Animation
    {
        public List<AnimationFrame> frames = new List<AnimationFrame>();
        public TimeSpan timeIntoAnimation;

        public Animation(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public TimeSpan Duration
        {
            get
            {
                double totalSeconds = 0;
                foreach (var frame in frames)
                {
                    totalSeconds += frame.Duration.TotalSeconds;
                }

                return TimeSpan.FromSeconds(totalSeconds);
            }
        }
        public Rectangle currentRectangle
        {
            get
            {
                AnimationFrame currentFrame = null;
                TimeSpan accumulatedTime = new TimeSpan();
                foreach(var frame in frames)
                {
                    if(accumulatedTime + frame.Duration >= timeIntoAnimation)
                    {
                        currentFrame = frame;
                        break;
                    }

                }

                if(currentFrame == null)
                {
                    currentFrame = frames.LastOrDefault();
                }
                return currentFrame != null ? currentFrame.SourceRectangle : Rectangle.Empty;
            }
        }

        public void AddFrame(Rectangle rectangle, TimeSpan duration)
        {
            AnimationFrame newFrame = new AnimationFrame() { SourceRectangle = rectangle, Duration = duration };
            frames.Add(newFrame);
        }
        public void Update(GameTime gameTime)
        {
            double secondsIntoAnimation = timeIntoAnimation.TotalSeconds + gameTime.ElapsedGameTime.TotalSeconds;
            double remainder = secondsIntoAnimation % Duration.TotalSeconds;
            timeIntoAnimation = TimeSpan.FromSeconds(remainder);
        }
    }
    }
