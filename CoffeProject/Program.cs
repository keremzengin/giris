
// See https://aka.ms/new-console-template for more information

using CoffeProject;
using CoffeProject.Abstract;
using CoffeProject.Adapters;
using CoffeProject.Concrete;
using MernisServiceReference;

BaseCustomerManager customerManager = new StarBucksCustomerManager( new MernisServiceAdapter());
customerManager.Save(new Customer { FirstName = "Kerem", LastName = "Zengin", Id = 11, DateOfBirth = new DateTime(1999, 02, 01), NationalityId = "17881229222" });

