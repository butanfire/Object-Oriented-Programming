namespace GenericList
{
    using System;

    public static class GenericMethods
    {
        public static TGen Min<TGen>(this GenList<TGen> list) where TGen : IComparable
        {
            var element = list[0];
            for (int i = 1; i < list.ListLength(); i++)
            {
                if (list[i].CompareTo(element) < 0)
                {
                    element = list[i];
                }
            }

            return element;
        }

        public static TGen Max<TGen>(this GenList<TGen> list) where TGen : IComparable
        {
            var element = list[0];
            for (int i = 1; i < list.ListLength(); i++)
            {
                if (list[i].CompareTo(element) > 0)
                {
                    element = list[i];
                }
            }

            return element;
        }
    }
}
