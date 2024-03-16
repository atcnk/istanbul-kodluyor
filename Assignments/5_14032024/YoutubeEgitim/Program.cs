using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeEgitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine(sayi1);

            //int[] sayilar1 = new[] { 1, 2, 3 };
            //int[] sayilar2 = new[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine(sayilar1[0]);

            //var creditManager = new CreditManager();
            //creditManager.Calculate();
            //creditManager.Save();

            //var customer = new Customer();  // ornegini olusturmak, instance creation
            //customer.Id = 1;
            ////customer.FirstName = "Engin";
            ////customer.LastName = "Demirog";
            ////customer.NationalIdentity = "123456";
            //customer.City = "Ankara";

            //var customerManager = new CustomerManager(customer);
            //customerManager.Save(customer);
            //customerManager.Delete(customer);

            //Company company = new Company();
            //company.TaxNumber = "10000";
            //company.CompanyName = "Arcelik";
            //company.Id = 100;

            //CustomerManager customerManager2 = new CustomerManager(new Person());

            //Person person = new Person();
            //person.FirstName = "";
            //person.NationalIdentity = "";

            //Customer c1 = new Customer();
            //Customer c2 = new Person();
            //Customer c3 = new Company();


            CustomerManager customerManager = new CustomerManager(new Customer(), new CarCreditManager());
            customerManager.GiveCredit();

           
            Console.ReadLine();
        }
    }

    class CreditManager
    {
        public void Calculate(int creditType)
        {
            Console.WriteLine("Hesaplandi");
        }

        public void Save()
        {
            Console.WriteLine("Kredi verildi.");
        }
    }

    interface ICreditManager
    {
        void Calculate();
        void Save();
    }

    abstract class BaseCreditManager: ICreditManager
    {
        public abstract void Calculate();

        public virtual void Save()
        {
            Console.WriteLine("kaydedilid.");
        }
    }

    class TeacherCreditManager : BaseCreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Ogretmen kredisi hesaplandi");
        }
    }

    class MilitaryCreditManager : BaseCreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker kredisi hesaplandi");
        }
    }

    class CarCreditManager : BaseCreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Araba kredisi hesaplandi");
        }
    }

    // SOLID

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Musteri nesnesi baslatildi.");
        }
        public int Id { get; set; }
        
        public string City { get; set; }
    }

    class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
    }

    class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }

    class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManager;

        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }

        public void Save(Customer customer)
        {
            Console.WriteLine("Musteri kaydedildi. : ");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri silindi. : ");
        }

        public void GiveCredit()
        {
            _creditManager.Calculate();
        }
    }
}

