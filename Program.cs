using System;
using System.Collections.Generic;

namespace PrintDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 4, 7, 8, 4, 6, 1, 3, 3, 2, 8, 4 };
            var dict = new Dictionary<int, int>();

            foreach (var value in numbers)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            //Print out duplicates only
            foreach (var pair in dict)
            {
                if (pair.Value >= 2)
                    Console.WriteLine(pair.Key);
            }
                
            Console.ReadKey();
        }
     }
}
