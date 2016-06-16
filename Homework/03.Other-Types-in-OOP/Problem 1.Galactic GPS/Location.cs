namespace GalacticGPS
{
    using System;

    struct Location
    {
        private double latitude;
        private double longtitude;
        private Planets randomPlanet;

        public Location(double latitude, double longtitude, Planets somePlanet) : this()
        {
            this.Latitude = latitude;
            this.LongTitude = longtitude;
            this.randomPlanet = somePlanet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            private set
            {
                if (value > 90 || value < -90)
                {
                    throw new ArgumentException("Latitude is between -90 and 90 degrees");
                }

                this.latitude = value;
            }
        }

        public double LongTitude
        {
            get
            {
                return this.longtitude;
            }

            private set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentException("Longtitude cannot be other than -180 and 180 degrees");
                }

                this.longtitude = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} , {1} - {2}", this.Latitude, this.LongTitude, this.randomPlanet);
        }
    }


}
