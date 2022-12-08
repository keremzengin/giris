// See https://aka.ms/new-console-template for more information
using OOP1;

Product product1= new Product();
product1.Id= 1;
product1.CatagoryId= 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock= 10;

Product product2 = new Product { Id=2,CatagoryId= 3,ProductName="Kalem", UnitsInStock=34 };

ProductManager  productManager= new ProductManager();
productManager.Add(product1);



