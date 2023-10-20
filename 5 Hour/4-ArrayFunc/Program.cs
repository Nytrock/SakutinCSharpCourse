using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ArrayFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            EditArray(array, 2, 5);
            Console.WriteLine(array[2]);
            Console.ReadKey();
        }

        static void EditArray(int[] array, int index, int value) {
            array[index] = value;
        }
    }
}
