//using System;

//namespace ITCourse
//{
//    internal class davaleba3
//    {
//        static void Main(string[] args)
//        {
//            ////davaleba 1
//            //string username = "admin";
//            //string password = "1234";

//            //Console.WriteLine("Enter username:");
//            //string usernameInput = Console.ReadLine();

//            //Console.WriteLine("Enter password:");
//            //string passwordInput = Console.ReadLine();

//            //if (username == usernameInput && password == passwordInput)
//            //{
//            //    Console.WriteLine("Welcome!");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Access Denied");
//            //}

//            //davaleba 2
//            //Console.WriteLine("Enter first number:");

//            //if (!double.TryParse(Console.ReadLine(), out double num1))
//            //{
//            //    Console.WriteLine("Invalid first number");
//            //    return;
//            //}

//            //Console.WriteLine("Enter second number:");

//            //if (!double.TryParse(Console.ReadLine(), out double num2))
//            //{
//            //    Console.WriteLine("Invalid second number");
//            //    return;
//            //}

//            //Console.WriteLine("Choose operation (+, -, *, /):");
//            //string operation = Console.ReadLine();

//            //switch (operation)
//            //{
//            //    case "+":
//            //        Console.WriteLine($"Result: {num1 + num2}");
//            //        break;

//            //    case "-":
//            //        Console.WriteLine($"Result: {num1 - num2}");
//            //        break;

//            //    case "*":
//            //        Console.WriteLine($"Result: {num1 * num2}");
//            //        break;

//            //    case "/":
//            //        if (num2 == 0)
//            //        {
//            //            Console.WriteLine("Cannot divide by zero");
//            //        }
//            //        else
//            //        {
//            //            Console.WriteLine($"Result: {num1 / num2}");
//            //        }
//            //        break;

//            //    default:
//            //        Console.WriteLine("Invalid operation");
//            //        break;
//            //}

//            //davaleba 3
//            Console.WriteLine("Enter age:");

//            if (!int.TryParse(Console.ReadLine(), out int age))
//            {
//                Console.WriteLine("Invalid age");
//                return;
//            }

//            if (age >= 0 && age <= 12)
//            {
//                Console.WriteLine("Child");
//            }
//            else if (age <= 19)
//            {
//                Console.WriteLine("Teenager");
//            }
//            else if (age <= 64)
//            {
//                Console.WriteLine("Adult");
//            }
//            else if (age >= 65)
//            {
//                Console.WriteLine("Senior");
//            }
//            else
//            {
//                Console.WriteLine("Invalid age");
//            }
//        }
//    }
//}c