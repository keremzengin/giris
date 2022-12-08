// See https://aka.ms/new-console-template for more information
using GenericsProject;

MyDictionary<string, int> cars = new MyDictionary<string, int>();
cars.Add("Mustang", 1979);
cars.Add("BMW", 1987);
for (int i = 0; i < cars.Cars.Length; i++)
{
    Console.Write(cars.Cars[i].Key);
    Console.WriteLine(cars.Cars[i].Value);
}