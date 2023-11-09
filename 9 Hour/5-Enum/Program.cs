using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();

            games.Add(new Game("First", Genre.Strategy));
            games.Add(new Game("Second", Genre.RPG));
            games.Add(new Game("Third", Genre.Action));
            games.Add(new Game("Fourth", Genre.Strategy));

            foreach (Game game in games) {
                game.ShowInfo();
            }

            Console.WriteLine((Genre)1);

            Console.ReadKey();
        }
    }

    enum Genre
    {
        Strategy,
        RPG,
        Action
    }

    class Game
    {
        private string _title;
        private Genre _genre;

        public Game(string title, Genre genre)
        {
            _title = title;
            _genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Это игра: {_title}, её жанр: {_genre}");
        }
    }
}
