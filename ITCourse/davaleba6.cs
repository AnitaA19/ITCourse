//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ITCourse
//{
//    internal class davaleba6
//    {
//        static void Main(string[] args)
//        {
//            //1
//            int[][] studentGrades = new int[4][];
//            studentGrades[0] = new int[] { 85, 90, 78 };
//            studentGrades[1] = new int[] { 92, 88, 95, 70 };
//            studentGrades[2] = new int[] { 60, 75 };
//            studentGrades[3] = new int[] { 100, 95, 80, 85, 90 };

//            for (int i = 0; i < studentGrades.Length; i++)
//            {
//                int sum = 0;
//                for (int j = 0; j < studentGrades[i].Length; j++)
//                    sum += studentGrades[i][j];

//                double average = (double)sum / studentGrades[i].Length;
//                Console.WriteLine("Student " + (i + 1) + " average: " + average);
//            }

//            //2
//            Random rand = new Random();
//            int[] passcodes = new int[10];

//            for (int i = 0; i < passcodes.Length; i++)
//                passcodes[i] = rand.Next(1000, 10000);

//            Console.WriteLine("Passcodes (demo):");
//            for (int i = 0; i < passcodes.Length; i++)
//                Console.Write(passcodes[i] + " ");
//            Console.WriteLine();

//            Console.Write("Enter 4-digit code: ");
//            string input = Console.ReadLine();
//            bool found = false;

//            if (int.TryParse(input, out int enteredCode))
//            {
//                for (int i = 0; i < passcodes.Length; i++)
//                {
//                    if (passcodes[i] == enteredCode)
//                    {
//                        found = true;
//                        break;
//                    }
//                }
//            }

//            Console.WriteLine(found ? "Correct" : "Wrong");

//            //3
//            int[] numbers = { 5, -3, 12, -8, 0, 47, -21, 33, 7, -1 };

//            int min = numbers[0];
//            int max = numbers[0];

//            for (int i = 1; i < numbers.Length; i++)
//            {
//                if (numbers[i] < min) min = numbers[i];
//                if (numbers[i] > max) max = numbers[i];
//            }

//            Console.Write("Array: ");
//            for (int i = 0; i < numbers.Length; i++)
//                Console.Write(numbers[i] + " ");
//            Console.WriteLine();
//            Console.WriteLine("Min: " + min);
//            Console.WriteLine("Max: " + max);

//            //4
//            string[] words = { "Hello", "World", "CSharp" };

//            for (int i = 0; i < words.Length; i++)
//            {
//                Console.Write(words[i] + ": ");
//                for (int j = 0; j < words[i].Length; j++)
//                    Console.Write(words[i][j] + " ");
//                Console.WriteLine();
//            }

//            //5
//            string[] emails = { "user@gmail.com", "invalidemail", "hello@world.org", "noatsign.com", "test@test.com" };

//            for (int i = 0; i < emails.Length; i++)
//            {
//                bool hasAt = false;
//                for (int j = 0; j < emails[i].Length; j++)
//                {
//                    if (emails[i][j] == '@')
//                    {
//                        hasAt = true;
//                        break;
//                    }
//                }
//                Console.WriteLine(emails[i] + " => " + (hasAt ? "Contains @" : "Does not contain @"));
//            }
//        }
//    }
//}