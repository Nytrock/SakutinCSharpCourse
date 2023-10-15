using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LinkedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int[] tempArray = new int[5];

            array = tempArray;

            array[0] = 5;

            Console.WriteLine(tempArray[0]);
            Console.ReadKey();
        }
    }
}
