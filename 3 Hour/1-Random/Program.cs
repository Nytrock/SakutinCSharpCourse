using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            while (true) {
                int value = rand.Next(0, 10); // without 10
                Console.WriteLine(value);
                Console.ReadKey();
            }
        }
    }
}
