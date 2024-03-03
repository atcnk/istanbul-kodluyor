using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace TypesAndVariables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int number1 = 2147483647;   // 32 bit
            long number2 = -214783648;   // 64 bit

            Console.WriteLine("Numbers are: {0} and {1}", number1, number2);
            Console.ReadLine();
        }
    }
}
