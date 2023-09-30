using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPlay;

            Console.WriteLine($"Добро пожаловать в пекарню! Сегодня еда по {foodUnitPrice} монет.");
            Console.Write("Сколько у вас золота?");
            money = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько еды вам нужно?");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPlay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPlay);
            money -= food * foodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} единиц еды, и {money} монет.");

            Console.ReadKey();
        }
    }
}
