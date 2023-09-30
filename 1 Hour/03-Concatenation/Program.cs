using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Concatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 5;

            Console.WriteLine("Привет, завтра тебе исполнится: " + age + 1);
            Console.WriteLine("Привет, завтра тебе исполнится: " + (age + 1));
            Console.WriteLine(5 + 5 + "Привет, завтра тебе исполнится: " + (age + 1));
            Console.WriteLine(5 + (5 + "Привет, завтра тебе исполнится: ") + (age + 1));

            Console.ReadKey();
        }
    }
}
