using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result;

            int x, y;

            x = 5;
            y = 2;

            result = Convert.ToSingle(x) / y;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
