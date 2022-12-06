using System;

namespace E_ticaret_deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Bike = new Product();
            Bike.Name = "Tron";
            Bike.Price = 100;
            Bike.Points = 5;

            Product Computer = new Product();
            Computer.Name = "Asus";
            Computer.Price = 500;
            Computer.Points = 4;

            Product Book = new Product();
            Book.Name = "Zeus";
            Book.Price = 2000;
            Book.Points = 3;

            Product[] products = new Product[] {Bike, Computer, Book };

            for (int i = 0; i < products.Length; i++)
            {
                //Console.WriteLine(products[i].Name +products[i].Name);
                Console.WriteLine(products[i].Name+" " + products[i].Price );
                Console.WriteLine(products[i].Name + " "+ products[i].Points);
            }
            Console.ReadLine();
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Points { get; set; }

        public Product()
        {

        }

    }
}
