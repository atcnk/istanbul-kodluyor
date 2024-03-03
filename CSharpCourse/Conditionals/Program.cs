using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var number = 1;

            if (number == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else
            {
                Console.WriteLine("Number is not 0");
            }

            Console.ReadLine();
        }
    }
}
