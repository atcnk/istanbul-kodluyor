using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is atacan";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is kilic";
            var result3 = sentence.EndsWith("n");
            var result4 = sentence.StartsWith("a");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Substring(3, 4);
            var result9 = sentence.Insert(0, "HELLO");
            var result10 = sentence.Replace(" ", "_");
            var result11 = sentence.Remove(2, 6);

            Console.WriteLine(result11);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Istanbul";

            Console.WriteLine(String.Format($"{city} {city2}"));
        }
    }
}
