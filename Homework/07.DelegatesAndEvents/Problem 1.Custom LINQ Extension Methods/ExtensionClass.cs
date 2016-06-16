namespace CustomLINQ
{
    using System;
    using System.Collections.Generic;

    public static class ExtensionClass
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var newList = new List<T>(); //create a new list to store the elements

            foreach (var element in collection)
            {
                if (!predicate(element)) //if the predicate is NOT true, add the element in the new list
                {
                    newList.Add(element);
                }
            }
            return newList; //return the resulting list
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> list, Func<TSource, TSelector> Data) where TSelector : IComparable<TSelector>
        { //add  IComparable in order to be able to compare different types

            var tempArray = new List<TSelector>(); //create an array to store the data from the function Data
            foreach (var element in list)
            {
                tempArray.Add(Data(element)); //add each element which goes through the function ( to get the data from each object)
            }

            TSelector maximum = tempArray[0]; //take the first element from the array

            for (int i = 1; i < tempArray.Count; i++)
            {
                if (maximum.CompareTo(tempArray[i]) < 0) //iterate through all element to find the data
                {
                    maximum = tempArray[i];
                }
            }

            return maximum;
        }

    }
}
