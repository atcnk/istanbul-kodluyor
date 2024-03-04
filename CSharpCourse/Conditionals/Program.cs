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

            //if (number == 0)
            //{
            //    Console.WriteLine("Number is 0");
            //}
            //else if (number == 1)
            //{
            //    Console.WriteLine("Number is 1");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 0 or 1");
            //}

            //switch (number)
            //{
            //    case 0:
            //        Console.WriteLine("Number is 0");
            //        break;
            //    case 1:
            //        Console.WriteLine("Number is 1");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 0 or 1");
            //        break;
            //}

            //Console.WriteLine(number == 0 ? "Number is 0" : "Number is not 0");

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
