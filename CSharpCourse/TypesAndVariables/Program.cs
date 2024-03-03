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
            byte numberByte = 255;  // 8-bit
            short numberShort = 32767;  // 16-bit
            int numberInt = 2147483647;   // 32-bit
            long numberLong = -214783648;   // 64-bit

            bool condition = false;
            char character = 'C';

            Console.WriteLine("Numbers are: {0} | {1} | {2} | {3}", numberByte, numberShort, numberInt, numberLong);
            Console.WriteLine("Char is: {0} and its ASCII number is: {1}", character, (int)character);
            Console.ReadLine();
        }
    }
}
