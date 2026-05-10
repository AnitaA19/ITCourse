using System.Diagnostics.CodeAnalysis;

namespace ITCourse
{
    internal class davaleba2
    {
        static void Main(string[] args)
        {
            //davaleba 1 
            // int userAge;
            // Console.WriteLine("Sheiyvanet tqveni asaki:");
            // userAge = int.Parse(Console.ReadLine());

            //if(userAge >= 18)
            // {
            //     Console.WriteLine("გილოცავ! ხმის მიცემის უფლება გაქვთ.");
            // }
            //else
            // {
            //     Console.WriteLine("სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ");
            // }

            // davaleba 2
            //double number1, number2, number3;

            //Console.WriteLine("Sheiyvanet 1 ricxvi:");
            //number1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Sheiyvanet 2 ricxvi:");
            //number2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Sheiyvanet 3 ricxvi:");
            //number3 = double.Parse(Console.ReadLine());

            //if (number1 >= number2 && number1 >= number3)
            //{
            //    Console.WriteLine("Ricxvi 1 yvelaze didia");
            //}
            //else if (number2 >= number1 && number2 >= number3)
            //{
            //    Console.WriteLine("Ricxvi 2 yvelaze didia");
            //}
            //else
            //{
            //    Console.WriteLine("Ricxvi 3 yvelaze didia");
            //}

            // davaleba 3
            double number1, number2;

            Console.WriteLine("Sheiyvanet 1 ricxvi:");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Sheiyvanet 2 ricxvi:");
            number2 = double.Parse(Console.ReadLine());

            double result = 0;

            if (number1 == number2)
            {
                result = (number1 + number2) * 3;
            }
            else
            {
                result = number1 + number2;
            }

            Console.WriteLine("Shedegi: " + result);
        }
    }
}
