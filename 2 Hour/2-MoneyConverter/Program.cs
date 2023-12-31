﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_MoneyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInWallet;
            float dollarsInWallet;

            int rubToUsd = 64, usdToRub = 66;

            float exchangeCurrencyCount;

            string desireOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию");
            Console.WriteLine("1 - обменять рубли на доллары.");
            Console.WriteLine("2 - обменять доллары на рубли.");
            Console.Write("Ваш выбор: ");
            desireOperation = Console.ReadLine();

            switch (desireOperation) {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары.");
                    Console.Write("Сколько вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= exchangeCurrencyCount) {
                        rublesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    } else {
                        Console.WriteLine("Недопустимое количество рублей.");
                    }
                    break; 
                case "2":
                    Console.WriteLine("Обмен долларов на рубли.");
                    Console.Write("Сколько вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount) {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * usdToRub;
                    } else {
                        Console.WriteLine("Недопустимое количество долларов.");
                    }
                    break;
                default: 
                    Console.WriteLine("Выбрана неверная операция.");
                    break;
            }

            Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей, {dollarsInWallet} долларов.");

            Console.ReadKey();
        }
    }
}
