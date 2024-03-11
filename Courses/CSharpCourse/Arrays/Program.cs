using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "Engin", "Derin", "Salih" };

            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"istanbul", "izmit", "balikesir" },
                {"ankara", "konya", "kirikkale" },
                {"antalya", "adana", "mersin"},
                {"rize", "trabzon", "samsun" },
                {"izmir", "mugla", "manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }

                Console.WriteLine("********");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
