using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ConsoleColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Ты здесь?");
            WriteError("Нет соединения с Интернетом.");
            Console.WriteLine("Странно...");
            WriteError("Интернет не оплачен.", symbol: '@');

            Console.ReadKey();
        }

        static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!')
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            Console.WriteLine(symbol + text);
            Console.ForegroundColor = defaultColor;
        }
    }
}
