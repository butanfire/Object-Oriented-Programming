namespace GenericList
{
    using System;

    [Version(10, 11)]
    public class Program : Attribute
    {
        static void Main(string[] args)
        {
            GenList<int> genericList = new GenList<int>(22); //initialize the list

            int someNumber = 0;

            genericList.AddElement(1);
            genericList.AddElement(2); //add element

            Console.WriteLine("Access element by index {1} : {0}", genericList[someNumber], someNumber); //access element by index

            for (int i = 0; i < 32; i++) 
            {
                genericList.AddElement(i);
            }

            Console.WriteLine(genericList.ToString());//print entire list

            genericList[5] = 10;//insert element at given position
            Console.WriteLine(genericList[5]); //access element by index
            genericList.RemoveElementByIndex(5); //remove element by index            
            Console.WriteLine(genericList[5]); //access element by index

            Console.WriteLine(genericList.ToString());//print entire list

            Console.WriteLine("Find element Index, by value : " + genericList.FindIndexByValue(15)); //find element index, by value
            Console.WriteLine("Check if List contains a Value : " + genericList.CheckElement(15));//check if list contains a value
            Console.WriteLine("Max number in the list {0}", genericList.Max());
            Console.WriteLine("Min number in the list is {0}", genericList.Min());

            genericList.ClearList(); //clearing the list
            Console.WriteLine(genericList.ToString());//print the cleared list
            Console.WriteLine(genericList.GetVersion()); //output the version
        }
    }
}
