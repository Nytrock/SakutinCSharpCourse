﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_GladiatorsFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight warrior1 = new Knight(100, 10);
            Barbarian warrior2 = new Barbarian(100, 1, 7, 2);

            warrior1.TakeDamage(500);
            warrior2.TakeDamage(250);

            Console.Write("Рыцарь: ");
            warrior1.ShowInfo();

            Console.Write("Варвар: ");
            warrior2.ShowInfo();

            Console.ReadKey();
        }
    }

    class Warrior 
    {
        protected int Health;
        protected int Armor;
        protected int Damage;

        public Warrior(int health, int armor, int damage)
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Health);
        }
    }

    class Knight : Warrior
    {
        public Knight(int health, int damage) : base(health, 5, damage) { }

        public void Pray()
        {
            Armor += 2;
        }
    }

    class Barbarian : Warrior
    {
        public int AttackSpeed;

        public Barbarian(int health, int armor, int damage, int attackSpeed) : base(health, armor, damage * attackSpeed) { }

        public void Shout()
        {
            Armor -= 2;
            Health += 10;
        }
    }
}
