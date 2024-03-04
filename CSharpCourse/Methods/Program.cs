using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(20, 30);
            Console.WriteLine("result: {0}", result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
