using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int years;
            int percent;

            Console.WriteLine("Введите количество денег, внесенных на вклад: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("На сколько лет открыт вклад? ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Под какой процент? ");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int  i = 0; i < years; i++) {
                money += money / 100 * percent;
                Console.WriteLine("В этом году у вас " + money);
                Console.ReadKey();
            }

            Console.WriteLine("Вклад закрылся.");
            Console.ReadKey();
        }
    }
}
