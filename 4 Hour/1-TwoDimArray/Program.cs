using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TwoDimArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array;
            int[,] array2 = new int[2, 3];

            int[,] array3 = new int[4, 4];
            Random rand = new Random();

            int[,] array4 = new int[2, 3] {
                { 9, 8, 7 },
                { 6, 5, 4 }
            };

            //Console.WriteLine(array2[2, 2]);

            for (int i = 0; i < array3.GetLength(0); i++) {
                for (int j = 0; j < array3.GetLength(1); j++) {
                    array3[i, j] = rand.Next(0, 10);
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
