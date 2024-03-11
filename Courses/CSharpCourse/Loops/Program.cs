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
            for (int i = 100; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");

            Console.ReadLine();
        }
    }
}
