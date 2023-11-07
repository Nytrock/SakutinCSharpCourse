using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_StaticConstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет мир!");
            MyClass instance = new MyClass();
            Console.WriteLine(MyClass.StaticField);
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public static float StaticField;

        static MyClass() 
        {
            StaticField = 10;
            Console.WriteLine("Статический конструктор.");
        }

        public MyClass()
        {
            StaticField = 10;
            Console.WriteLine("Обычный конструктор.");
        }
    }
}
