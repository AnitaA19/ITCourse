using ITCourse.MyLinq;
using System;
using System.Collections.Generic;

namespace CustomLinqAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                5, 2, 8, 2, 10, 5, 12
            };

            Console.WriteLine("Original collection:");
            PrintCollection(numbers);

            Console.WriteLine("\nWhere (even numbers):");
            var evenNumbers = MyLinq.Where(numbers, x => x % 2 == 0);
            PrintCollection(evenNumbers);

            Console.WriteLine("\nOrderBy:");
            var sortedNumbers = MyLinq.OrderBy(numbers);
            PrintCollection(sortedNumbers);

            Console.WriteLine("\nFirst number greater than 5:");
            int first = MyLinq.First(numbers, x => x > 5);
            Console.WriteLine(first);

            Console.WriteLine("\nFirstOrDefault number greater than 100:");
            int firstOrDefault =
                MyLinq.FirstOrDefault(numbers, x => x > 100);
            Console.WriteLine(firstOrDefault);

            Console.WriteLine("\nSingle number equal to 8:");
            int single = MyLinq.Single(numbers, x => x == 8);
            Console.WriteLine(single);

            Console.WriteLine("\nSingleOrDefault number equal to 100:");
            int singleOrDefault =
                MyLinq.SingleOrDefault(numbers, x => x == 100);
            Console.WriteLine(singleOrDefault);

            Console.WriteLine("\nAny number greater than 10:");
            bool any = MyLinq.Any(numbers, x => x > 10);
            Console.WriteLine(any);

            Console.WriteLine("\nAll numbers greater than 0:");
            bool all = MyLinq.All(numbers, x => x > 0);
            Console.WriteLine(all);

            Console.WriteLine("\nCount of even numbers:");
            int evenCount =
                MyLinq.Count(numbers, x => x % 2 == 0);
            Console.WriteLine(evenCount);

            Console.WriteLine("\nTotal count:");
            int totalCount = MyLinq.Count(numbers);
            Console.WriteLine(totalCount);

            Console.WriteLine("\nDistinct:");
            var uniqueNumbers = MyLinq.Distinct(numbers);
            PrintCollection(uniqueNumbers);

            Console.ReadKey();
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}