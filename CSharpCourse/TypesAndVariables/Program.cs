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

            bool condition = false; // 8-bit
            char character = 'C';   // 8-bit
            float numberFloat = 10.3F;  // 32-bit
            double numberDouble = 10.4D;    // 64-bit
            decimal numberDecimal = 10.412312412323M;   // 128-bit

            Console.WriteLine("Numbers are: {0} | {1} | {2} | {3}", numberByte, numberShort, numberInt, numberLong);
            Console.WriteLine("Char is: {0} and its ASCII number is: {1}", character, (int)character);
            Console.WriteLine("Fractional numbers are: {0} | {1} | {2}", numberFloat, numberDouble, numberDecimal);
            Console.ReadLine();
        }
    }
}
