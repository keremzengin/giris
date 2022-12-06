// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;
using System.ComponentModel;
using System.Text;

Customer customer1 = new Customer();
customer1.FirstName = "Ayse";
customer1.LastName = "Ugural";
customer1.Id = 1;
customer1.CreditNote = 1462;

Customer customer2= new Customer();
customer2.FirstName = "Kerem";
customer2.LastName = "Zengin";
customer2.Id = 2;
customer2.CreditNote = 1321;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

Customer[] customers = new Customer[] {customer1, customer2};

foreach (Customer customer in customers)
{
    Console.WriteLine(customer.FirstName +" " + customer.LastName +  customerManager.Add());
    Console.WriteLine($"kredi notunuz:{customer.CreditNote} seklindedir");
    
    Console.WriteLine("*********************");
}



