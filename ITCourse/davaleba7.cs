//using System;

//namespace ITCourse
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Product car = new Product(
//                id: 1,
//                name: "BMW M5 Competition",
//                description: "Luxury sport sedan",
//                price: 120000m,
//                quantity: 2,
//                brand: "BMW",
//                category: "Cars",
//                rating: 4.85,
//                isAvailable: true,
//                discountPercentage: 10
//            );

//            Console.WriteLine("Product Information\n");

//            car.DisplayInfo();

//            Console.WriteLine("\nStock Status");
//            Console.WriteLine(car.IsInStock()
//                ? "Product is in stock"
//                : "Product is out of stock");

//            Console.WriteLine("\nPrice Details");
//            Console.WriteLine($"Original Price: {car.Price:C}");
//            Console.WriteLine($"Discounted Price: {car.GetDiscountedPrice():C}");
//            Console.WriteLine($"You Save: {car.GetSavingsAmount():C}");
//            Console.WriteLine($"Total Price ({car.Quantity} items): {car.GetTotalPrice():C}");

//            Console.WriteLine("\nProduct Updating\n");

//            car.Restock(5);
//            car.ChangeDiscount(20);

//            car.DisplayInfo();
//        }
//    }

//    public class Product
//    {
//        public int Id { get; private set; }
//        public string Name { get; private set; }
//        public string Description { get; private set; }
//        public decimal Price { get; private set; }
//        public int Quantity { get; private set; }
//        public string Brand { get; private set; }
//        public string Category { get; private set; }
//        public double Rating { get; private set; }
//        public bool IsAvailable { get; private set; }
//        public int DiscountPercentage { get; private set; }

//        public Product(
//            int id,
//            string name,
//            string description,
//            decimal price,
//            int quantity,
//            string brand,
//            string category,
//            double rating,
//            bool isAvailable,
//            int discountPercentage)
//        {
//            Id = id;
//            Name = name;
//            Description = description;
//            Price = price;
//            Quantity = quantity;
//            Brand = brand;
//            Category = category;
//            Rating = rating;
//            IsAvailable = isAvailable;
//            DiscountPercentage = discountPercentage;
//        }

//        public decimal GetDiscountedPrice()
//        {
//            return Price - (Price * DiscountPercentage / 100);
//        }

//        public decimal GetTotalPrice()
//        {
//            return GetDiscountedPrice() * Quantity;
//        }

//        public decimal GetSavingsAmount()
//        {
//            return Price - GetDiscountedPrice();
//        }

//        public bool IsInStock()
//        {
//            return IsAvailable && Quantity > 0;
//        }

//        public void Restock(int amount)
//        {
//            if (amount > 0)
//            {
//                Quantity += amount;
//                Console.WriteLine($"{amount} items added to stock.");
//            }
//        }

//        public void SellProduct(int amount)
//        {
//            if (amount <= 0)
//            {
//                Console.WriteLine("Invalid quantity.");
//                return;
//            }

//            if (amount > Quantity)
//            {
//                Console.WriteLine("Not enough stock.");
//                return;
//            }

//            Quantity -= amount;

//            Console.WriteLine($"{amount} item(s) sold.");

//            if (Quantity == 0)
//            {
//                IsAvailable = false;
//            }
//        }

//        public void ChangeDiscount(int newDiscount)
//        {
//            if (newDiscount >= 0 && newDiscount <= 90)
//            {
//                DiscountPercentage = newDiscount;
//                Console.WriteLine($"Discount updated to {newDiscount}%.");
//            }
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine($"ID: {Id}");
//            Console.WriteLine($"Name: {Name}");
//            Console.WriteLine($"Description: {Description}");
//            Console.WriteLine($"Brand: {Brand}");
//            Console.WriteLine($"Category: {Category}");
//            Console.WriteLine($"Rating: {Rating}/5");
//            Console.WriteLine($"Price: {Price:C}");
//            Console.WriteLine($"Discount: {DiscountPercentage}%");
//            Console.WriteLine($"Discounted Price: {GetDiscountedPrice():C}");
//            Console.WriteLine($"Quantity: {Quantity}");
//            Console.WriteLine($"Availability: {(IsInStock() ? "In Stock" : "Out of Stock")}");
//            Console.WriteLine($"Total Value: {GetTotalPrice():C}");
//        }
//    }
//}