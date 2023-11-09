using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student("Jim", 5);
            Mentor mentor = new Mentor("Tom", 8);
            Student student;

            student = (Student)person;
            Console.WriteLine(student.AverageScore);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine("Я - " + Name);
        }
    }

    class Mentor : Person
    {
        public int NumberOfStudents { get; private set; }

        public Mentor(string name, int numberOfStudents) : base(name)
        {
            NumberOfStudents = numberOfStudents;
        }
    }

    class Student : Person
    {
        public int AverageScore { get; private set; }

        public Student(string name, int averageScore) : base(name)
        {
            AverageScore = averageScore;
        }
    }
}
