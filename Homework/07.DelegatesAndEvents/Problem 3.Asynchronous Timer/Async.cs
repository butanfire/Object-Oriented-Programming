namespace AsyncTimer
{
    using System;

    public class Async
    {
        private int ticks;
        private int timeInterval;

        public Async(Action<int> someAction, int ticks, int interval)
        {
            this.Ticks = ticks;
            this.TimeInterval = interval;
            this.SomeAction = someAction;
        }

        public Action<int> SomeAction{get; set;}

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ticks cannot be negative");
                }

                this.ticks = value;
            }
        }

        public int TimeInterval
        {
            get
            {
                return this.timeInterval;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Time interval cannot be null");
                }

                this.timeInterval = value;
            }
        }

    }
}
