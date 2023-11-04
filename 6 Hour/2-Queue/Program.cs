using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> patiens = new Queue<string>();

            patiens.Enqueue("Василий");
            patiens.Enqueue("Алексей");
            patiens.Enqueue("Роман");
            patiens.Enqueue("Владимир");

            Console.WriteLine("Сейчас на приём идёт: " + patiens.Dequeue());
            Console.WriteLine("Следующий в очереди: " + patiens.Peek());

            foreach (var item in patiens) {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
