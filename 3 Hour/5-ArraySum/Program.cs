using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 7, 8 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++) { 
                sum += array[i];
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
