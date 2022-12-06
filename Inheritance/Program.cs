using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
             new Customer{FirstName= "Kerem"}, new Student{FirstName="Tansu"}, new Student{FirstName="Ayse"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }
            Console.ReadLine(); 
                
        }
    }

    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    { 
     public string  City { get; set; }
    }

    class Student :Person
    { public string Departmant { get; set; }
        }

}
