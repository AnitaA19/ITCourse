using System;
using System.IO;

namespace ITCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\balas\source\repos\ITCourse\ITCourse\CarsData.txt";

            string[] lines = File.ReadAllLines(path);

            Car[] cars = new Car[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                cars[i] = new Car(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    decimal.Parse(data[3]),
                    data[4]
                );
            }

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].DisplayInfo();

                Console.WriteLine($"Age: {cars[i].GetCarAge()}");
                Console.WriteLine($"Expensive: {cars[i].IsExpensive()}");
                Console.WriteLine($"Price with 10% discount: ${cars[i].ApplyDiscount(10)}");

                Console.WriteLine("------------------------");
            }
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year + 1)
                {
                    _year = value;
                }
            }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public string Color { get; set; }

        public Car(string brand, string model, int year, decimal price, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            Color = color;
        }

        // Method 1
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Color: {Color}");
        }

        // Method 2
        public int GetCarAge()
        {
            return DateTime.Now.Year - Year;
        }

        // Method 3
        public bool IsExpensive()
        {
            return Price >= 50000;
        }

        // Method 4
        public decimal ApplyDiscount(int percent)
        {
            return Price - (Price * percent / 100);
        }

        // Method 5
        public void ChangePrice(decimal newPrice)
        {
            Price = newPrice;
        }

        // Method 6
        public void ChangeColor(string newColor)
        {
            if (!string.IsNullOrWhiteSpace(newColor))
            {
                Color = newColor;
            }
        }
    }
}