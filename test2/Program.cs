using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Product Bisiklet = new Product("Bisiklet",2344,5);
            Product Bilgisayar = new Product("Asus", 15000, 5);


            ArrayList products=new ArrayList();
            products.Add(Bilgisayar);
            products.Add(Bisiklet);

            foreach (Product product in products)
            {
                Console.WriteLine(product.Isim);
            }
            Console.ReadLine();

        }
    }
    
   public class Product 
    {
        


        public string Isim { get; set; }
        public decimal Fiyat { get; set; }
        public int Yildiz { get; set; }
        public int? Siralama { get; set; }

        public Product(string isim, decimal Fiyat, int Yildiz)
        {
            this.Isim = isim;
            this.Fiyat = Fiyat;
            this.Yildiz= Yildiz;
        }
        public Product()
        {

        }
    }
}
