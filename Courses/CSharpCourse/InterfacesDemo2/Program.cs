using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }

        public void Update()
        {
            
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added.");
        }

        public void Update()
        {
            
        }
    }

    class ProjectManager
    {
        public void Add()
        {
           
        }
    }
}
