using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robots()
            };
            foreach (var workers in worker)
            {
                workers.Work();
            }
            
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats) 
            {
                eat.Eat();
            }
            
            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var salary in salaries)
            {
                salary.Salary();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }
    class Manager : IWorker, ISalary, IEat
    { 
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, ISalary, IEat

    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robots : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
