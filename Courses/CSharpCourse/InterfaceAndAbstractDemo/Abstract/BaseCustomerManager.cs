using InterfaceAndAbstractDemo.Entities;
using System;

namespace InterfaceAndAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : " + customer.FirstName);
        }
    }
}
