using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(55, 10);
            renderer.Draw(player.X, player.Y);
        }
    }

    class Renderer
    {
        public void Draw(int x, int y, char character = '@')
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(y, x);
            Console.Write(character);
            Console.ReadKey(true);
        }
    }

    class Player
    {
        private int _x;

        public int X {
            get { return _x; }
            private set {  _x = value; }
        }

        public int Y { get; private set; }

        public Player(int y, int x)
        {
            _x = x;
            Y = y;
        }
    }
}
