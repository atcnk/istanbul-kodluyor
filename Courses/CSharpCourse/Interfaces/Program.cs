﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Engin",
            //    LastName = "Demirog"
            //};
            //personManager.Add(customer);

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get;  set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
