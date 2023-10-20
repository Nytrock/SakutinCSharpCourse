using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum, x = 1, y = 5;
            Add(out sum, x, y);

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static void Add(out int sum, int x, int y)
        {
            sum = x + y;
        }
    }
}
