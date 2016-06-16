namespace Problem_6.BitArray
{
    using System;
    using System.Numerics;

    public class BitArray
    {
        private int[] bitArray;

        public BitArray(int bits)
        {
            if (bits < 1 || bits > 100000)
            {
                throw new ArgumentException("Cannot be less than 1 and 100 000");
            }

            this.bitArray = new int[bits];
        }

        public int this[int index]
        {
            set
            {
                if (index < 0 || index >= this.bitArray.Length)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid value");
                }

                this.SetBitAtPos(index, value);
            }
        }

        private void SetBitAtPos(int pos, int bit)
        {
            this.bitArray[pos] = bit;
        }

        private string BinaryToDecimal()
        {
            BigInteger output = 0;
            for (int i = 0; i < this.bitArray.Length; i++)
            {
                output += int.Parse(this.bitArray[i].ToString()) * (BigInteger) Math.Pow(2, i);
            }

            return output.ToString();
        }

        public override string ToString()
        {
            return this.BinaryToDecimal();
        }
    }
}
