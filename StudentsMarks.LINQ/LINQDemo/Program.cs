using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>()
            {
                5,4,4,6,3,2,5,6,7,8,9
            };

            var sum = myList.Sum();

           var newList = myList.Where(x => x > 4);
            var newList2 = myList.FindAll(x => x > 4);

            myList.Any();
            myList.Any(x => x > 4);

            var average = myList.Average();

            myList.ToArray();

        }
    }
}
