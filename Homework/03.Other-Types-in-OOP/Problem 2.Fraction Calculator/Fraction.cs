namespace FractionCalculator
{
    using System;

    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;            
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                if (value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentException("Denominator must be in range of -9223372036854775808  and 9223372036854775807 and != 0");
                }

                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                if  (value == 0 || value > long.MaxValue || value < long.MinValue)
                {
                    throw new ArgumentException("Denominator must be in range of -9223372036854775808  and 9223372036854775807 and != 0");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction((a.Numerator * b.Denominator) + (b.Numerator * a.Denominator), (a.Denominator * b.Denominator));
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction((a.Numerator * b.Denominator) - (b.Numerator * a.Denominator), (a.Denominator * b.Denominator));
        }

        public override string ToString()
        {
            return string.Format("{0}", Convert.ToDecimal(this.Numerator) / Convert.ToDecimal(this.Denominator));
        }
    }
}
