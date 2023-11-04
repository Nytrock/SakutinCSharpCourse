using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car();

            ferrari.ShowTechnicalPassport();

            Console.ReadKey();
        }
    }

    class Car 
    {
        public string Name;
        public int HorsePower;
        public int Age;
        public float MaxSpeed;

        public Car(string name, int horsePower, int age, float maxSpeed)
        {
            if (horsePower < 0)
                HorsePower = 0;
            else
                HorsePower = horsePower;

            Name = name;
            Age = age;
            MaxSpeed = maxSpeed;
        }

        public Car()
        {
            Name = "Ford";
            HorsePower = 500;
            Age = 1;
            MaxSpeed = 300;
        }

        public void ShowTechnicalPassport() {
            Console.WriteLine($"Название авто: {Name}\nКол-во лошадиных сил: {HorsePower}\n" +
                $"Возраст авто: {Age}\nМаксимальныя скорость: {MaxSpeed} км/ч");
        }

        public void BecomeOlder(int years, int runAwayHorses)
        {
            Age += years;
            HorsePower -= runAwayHorses;
        }
    }
}
