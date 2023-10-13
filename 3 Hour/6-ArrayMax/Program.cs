using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ArrayMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 8, 12, 2, 25 };
            int maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++) {
                if (maxElement < array[i]) {
                    maxElement = array[i];
                }
            }

            Console.WriteLine(maxElement);
            Console.ReadKey();
        }
    }
}
