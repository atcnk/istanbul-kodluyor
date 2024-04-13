using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {  Id = 1, FirstName = "Engin", LastName = "Demirog", City = "Ankara"};
            Customer customer2 = new Customer(2, "Derin", "Demirog", "Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;
        }
    }

    class Customer
    {
        public Customer()
        {
            
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string City { get; set; }
    }
}
