using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
        }
    }

    interface IMovable
    {
        void Move();
        void ShowMoveSpeed();
    }

    interface IBurnable
    {

    }

    class Car : Vehicle, IMovable, IBurnable
    {
        public void Move()
        {

        }

        public void ShowMoveSpeed()
        {

        }
    }

    class Vehicle
    {

    }

    class Human : IMovable
    {
        public void Move() { }
        public void ShowMoveSpeed() { }
    }
}
