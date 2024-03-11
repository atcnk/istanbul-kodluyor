using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            int number = 100;

            while(number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine($"Now number is {number}");
            Console.ReadLine();
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
        }
    }
}
