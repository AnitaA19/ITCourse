//using System;
//using System.Text;

//namespace ITCourse
//{
//    internal class davaleba2
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;

//            // davaleba 1
//            int userAge;

//            Console.WriteLine("Sheiyvanet tqveni asaki:");

//            if (!int.TryParse(Console.ReadLine(), out userAge))
//            {
//                Console.WriteLine("araswori sheyvana");
//                return;
//            }

//            if (userAge >= 18)
//            {
//                Console.WriteLine("გილოცავ! ხმის მიცემის უფლება გაქვთ.");
//            }
//            else
//            {
//                Console.WriteLine("სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ");
//            }


//            // davaleba 2
//            double number1, number2, number3;

//            Console.WriteLine("Sheiyvanet 1 ricxvi:");
//            if (!double.TryParse(Console.ReadLine(), out number1))
//            {
//                Console.WriteLine("araswori sheyvana");
//                return;
//            }

//            Console.WriteLine("Sheiyvanet 2 ricxvi:");
//            if (!double.TryParse(Console.ReadLine(), out number2))
//            {
//                Console.WriteLine("araswori sheyvana");
//                return;
//            }

//            Console.WriteLine("Sheiyvanet 3 ricxvi:");
//            if (!double.TryParse(Console.ReadLine(), out number3))
//            {
//                Console.WriteLine("araswori sheyvana");
//                return;
//            }

//            if (number1 >= number2 && number1 >= number3)
//            {
//                Console.WriteLine("Ricxvi 1 yvelaze didia");
//            }
//            else if (number2 >= number1 && number2 >= number3)
//            {
//                Console.WriteLine("Ricxvi 2 yvelaze didia");
//            }
//            else
//            {
//                Console.WriteLine("Ricxvi 3 yvelaze didia");
//            }


//            // davaleba 3
//            double num1, num2;

//            Console.WriteLine("Sheiyvanet 1 ricxvi:");
//            if (!double.TryParse(Console.ReadLine(), out num1))
//            {
//                Console.WriteLine("araswori sheyvana");
//                return;
//            }

//            Console.WriteLine("Sheiyvanet 2 ricxvi:");
//            if (!double.TryParse(Console.ReadLine(), out num2))
//            {
//                Console.WriteLine("araswori sheyvana");
//                return;
//            }

//            double result;

//            if (num1 == num2)
//            {
//                result = (num1 + num2) * 3;
//            }
//            else
//            {
//                result = num1 + num2;
//            }

//            Console.WriteLine("Shedegi: " + result);
//        }
//    }
//}