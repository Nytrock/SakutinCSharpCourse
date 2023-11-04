using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TaskSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performer worker1 = new Performer("Вениамин");
            Performer worker2 = new Performer("Роман");

            Task[] tasks = { new Task(worker1, "Выкопать яму."), new Task(worker2, "Вывезти грунт.")};

            Board board = new Board(tasks);
            board.ShowAllTasks();

            Console.ReadKey();
        }
    }

    class Performer
    {
        public string Name;

        public Performer(string name)
        {
            Name = name;
        }
    }

    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            foreach (Task task in Tasks)
                task.ShowInfo();
        }
    }

    class Task 
    { 
        public Performer Worker;
        public string Description;

        public Task(Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}\n");
        }
    }
}
