//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ITCourse
//{
//    internal class davaleba4
//    {
//        static void Main(string[] args)
//        {
//            // ── Task 1 — Multiplication table ──────────────────────

//            Console.Write("Enter a number: ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"{n} * {i} = {n * i}");
//            }


//            // ── Task 2 — Snowflake pyramid ─────────────────────────

//            Console.Write("Enter pyramid height: ");
//            int height = int.Parse(Console.ReadLine());

//            for (int row = 1; row <= height; row++)
//            {
//                Console.Write(new string(' ', height - row));

//                for (int col = 1; col <= 2 * row - 1; col++)
//                {
//                    Console.Write(col % 2 != 0 ? "*" : " ");
//                }

//                Console.WriteLine();
//            }


//            // ── Task 3 — Sum of even numbers ───────────────────────

//            Console.Write("Enter a number: ");
//            int limit = int.Parse(Console.ReadLine());

//            int sum = 0;

//            for (int i = 2; i <= limit; i += 2)
//            {
//                sum += i;
//            }

//            Console.WriteLine($"Sum of even numbers up to {limit} = {sum}");


//            // ── Task 4 — Number guessing game ──────────────────────

//            Random rng = new Random();
//            int secret = rng.Next(1, 101);
//            int guess;
//            int attempts = 0;

//            Console.WriteLine("I picked a number between 1 and 100. Try to guess it!");

//            do
//            {
//                Console.Write("Your guess: ");
//                guess = int.Parse(Console.ReadLine());
//                attempts++;

//                if (guess < secret)
//                    Console.WriteLine("Too low! Try higher.");
//                else if (guess > secret)
//                    Console.WriteLine("Too high! Try lower.");

//            } while (guess != secret);

//            Console.WriteLine($"Correct! You guessed it in {attempts} attempt(s).");
//        }
//    }
//}