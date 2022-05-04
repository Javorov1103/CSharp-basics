using System;
using System.Collections.Generic;

namespace ListDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaration
            //List<int> myList = new List<int>();

            //Element Adding
            //myList.Add(8);

            //Indexing
            //int someNumber = myList[2];

            //Count of elements in the list
            //int listCount = myList.Count;

            //Removes element at index
            //myList.RemoveAt(2);

            //Remove first occurance of a specific element
            //myList.Remove(4);

            //myList.Clear();
            //myList.RemoveAll(element => element == 4);
            //myList.Exists(element => element == 4);
            //myList.Contains(4);

            //Declaration
            List<int> myList = new List<int>()
            {
                5,4,4,6,3,2,5,6,7,8,9
            };


            var newList = myList.FindAll(x => x > 4);

            myList.ForEach((x) =>
            {
                Console.WriteLine(x*2); ;
            });

            //foreach (int item in myList)
            //{
            //    item = item * 2;
            //}

            myList.AddRange(new List<int> { 4, 5, 6, 7 });
            //myList.Find();
            //myList.FindIndex();
            


            Console.WriteLine();




        }
    }
}
