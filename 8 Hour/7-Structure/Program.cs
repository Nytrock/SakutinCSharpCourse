using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2 position = new Vector2(10);

            Console.WriteLine(position.X);
            Console.WriteLine(position.Y);
            Console.WriteLine(new String('-', 20));

            Vector2 targetPosition = new Vector2(10, 10);
            Vector2 playerPosition = targetPosition;

            playerPosition.X += 15;

            Console.WriteLine(targetPosition.X);
            Console.WriteLine(new String('-', 20));


            GameObject bullet = new GameObject();
            Vector2 newPosition = bullet.Position;
            newPosition.X += 50;
            bullet.Position = newPosition;
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    class GameObject
    {
        public Vector2 Position { get; set; }
    }

    struct Vector2
    {
        public int X, Y;

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector2(int x) : this()
        {
            X = x;
        }
    }
}
