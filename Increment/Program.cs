using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(i);

            i = 0;
            Console.WriteLine(i++ + ++i);

            Console.ReadKey();
        }
    }
}
