using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string name;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();

            // alt + enter for error
            Console.WriteLine($"Ваше имя: {name}");

            Console.ReadKey();
        }
    }
}
