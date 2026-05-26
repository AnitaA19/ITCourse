//using System;

//namespace ITCourse
//{
//    internal class davaleba5
//    {
//        static void Main(string[] args)
//        {
//            // =================== დავალება 1 ===================
//            Console.Write("შეიყვანეთ პირველი მასივის ზომა: ");
//            int size1 = 0;
//            int.TryParse(Console.ReadLine(), out size1);

//            int[] array1 = new int[size1];
//            for (int i = 0; i < size1; i++)
//            {
//                Console.Write($"array1[{i}] = ");
//                int.TryParse(Console.ReadLine(), out array1[i]);
//            }

//            Console.Write("შეიყვანეთ მეორე მასივის ზომა: ");
//            int size2 = 0;
//            int.TryParse(Console.ReadLine(), out size2);

//            int[] array2 = new int[size2];
//            for (int i = 0; i < size2; i++)
//            {
//                Console.Write($"array2[{i}] = ");
//                int.TryParse(Console.ReadLine(), out array2[i]);
//            }

//            int[] resultArray1 = new int[size1 + size2];

//            for (int i = 0; i < size1; i++)
//                resultArray1[i] = array1[i];

//            for (int i = 0; i < size2; i++)
//                resultArray1[size1 + i] = array2[i];

//            Console.Write("resultArray = [");
//            for (int i = 0; i < resultArray1.Length; i++)
//            {
//                Console.Write(resultArray1[i]);
//                if (i < resultArray1.Length - 1)
//                    Console.Write(", ");
//            }
//            Console.WriteLine("]");

//            // =================== დავალება 2 ===================
//            Console.WriteLine();
//            int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };

//            Console.Write("შეიყვანეთ targetSum: ");
//            int targetSum = 0;
//            int.TryParse(Console.ReadLine(), out targetSum);

//            int[][] pairs = new int[array.Length * array.Length][];
//            int count = 0;

//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = i + 1; j < array.Length; j++)
//                {
//                    if (array[i] + array[j] == targetSum)
//                    {
//                        pairs[count] = new int[] { array[i], array[j] };
//                        count++;
//                    }
//                }
//            }

//            Console.Write("resultArray = [");
//            for (int i = 0; i < count; i++)
//            {
//                Console.Write($"[{pairs[i][0]}, {pairs[i][1]}]");
//                if (i < count - 1)
//                    Console.Write(", ");
//            }
//            Console.WriteLine("]");
//        }
//    }
//}