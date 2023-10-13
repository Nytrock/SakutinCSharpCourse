using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(5, 10);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Clear(); // сотрёт старый цвет фона

            Console.WindowHeight = 10;
            Console.WindowWidth = 50;

            Console.WriteLine("У строки удалится [\b\b символ.");

            Console.ReadKey();
        }
    }
}
