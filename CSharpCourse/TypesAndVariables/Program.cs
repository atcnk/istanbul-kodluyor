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
            byte numberByte = 255;
            short numberShort = 32767;  // 16 bit
            int numberInt = 2147483647;   // 32 bit
            long numberLong = -214783648;   // 64 bit

            Console.WriteLine("Numbers are: {0} | {1} | {2} | {3}", numberByte, numberShort, numberInt, numberLong);
            Console.ReadLine();
        }
    }
}
