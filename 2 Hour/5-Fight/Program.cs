using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 1000;
            int playerDamage = 5;
            int enemyHealth = 1500;
            int enemyDamage = 3;

            while (playerHealth > 0 && enemyHealth > 0) {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " игрок.");
                Console.WriteLine(enemyHealth + " враг.");
            }

            if (playerHealth <= 0 && enemyHealth <= 0) {
                Console.WriteLine("Ничья.");
            } else if (enemyHealth <= 0) {
                Console.WriteLine("Победа игрока.");
            } else if (playerHealth <= 0) {
                Console.WriteLine("Победа врага.");
            }

            Console.ReadKey();
        }
    }
}
