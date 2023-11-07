using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] transport = { new Car(), new Train() };
        }
    }

    abstract class Vehicle
    {
        protected float Speed;

        public abstract void Move();

        public float GetCurrentSpeed()
        {
            return Speed;
        }
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Машина едет по асфальту.");
        }
    }

    class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Поезд едет по рельсам.");
        }
    }
}