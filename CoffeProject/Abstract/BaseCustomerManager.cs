using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeProject.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine($"Saved to db :{ customer.FirstName}-{customer.LastName}-{customer.Id}-{customer.NationalityId}");
        }

       
    }
}
