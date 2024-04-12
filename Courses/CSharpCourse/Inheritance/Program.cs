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
            //Person[] persons = new Person[3]
            //{
                
            //}
            
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }
}
