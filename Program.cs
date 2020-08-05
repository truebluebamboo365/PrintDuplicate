using System;
using System.Collections.Generic;

namespace PrintDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var duplicates = new List<int>();
            var numbers = new List<int>() { 4, 7, 8, 4, 6, 1, 3, 3, 2, 8, 4 };
            
            foreach (int num in numbers)
            {
                if (DuplicateCount(numbers, num) > 1)
                {
                    if (DuplicateCount(duplicates, num) == 0)
                    {
                        duplicates.Add(num);
                    }
                }
            }

            //printing out the duplicates only
            foreach (int num in duplicates)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
        static int DuplicateCount(List<int> NumbList, int Num)
        {
            int count = 0;
            foreach (int n in NumbList)
            {
                if (n == Num)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
