using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player> { 
                new Player("Джон", 110),
                new Player("Билл", 220),
                new Player("Дерек", 260),
                new Player("Klark", 241)
            };

            List<Player> players2 = new List<Player> {
                new Player("Майкл", 100),
                new Player("Джордан", 212)
            };

            var unionPlayers = players.Union(players2);

            var skippedPlayers = players.Skip(1);
            var takedPlayers = players.Take(1);
            var skippedPlayers2 = players.SkipWhile(player => player.Login.StartsWith("Д"));

            var newPlayers = from Player player in players select new { Name = player.Login, dateOfBirth = DateTime.Now };
            var newPlayers2 = players.Select(player => new { Name = player.Login, dateOfBirth = DateTime.Now });

            List<int> numbers = new List<int>() { 1, 5, 100, 0, 2, 1, 3, 4, 85, 8, 6, 4, 7 };
            int maxNumber = numbers.Max();
            var maxLevelPlayer = players.Max(p => p.Level);

            var filteredPlayers = from Player player in players where player.Level > 200 select player;
            var filteredPlayers2 = players.Where(player => player.Level > 200).Select(player => player.Login);
            var filteredPlayers3 = players.Where(player => player.Login.ToUpper().StartsWith("K"));
            var filteredPlayers4 = players.Where(player => player.Login.ToUpper().StartsWith("K")).ToArray();

            var orderedPlayerByLevel = players.OrderBy(player => player.Level);

            foreach (var player in takedPlayers)
                Console.WriteLine(player.Login);

            Console.ReadKey();
        }
    }

    class Player
    {
        public string Login { get; private set; }
        public int Level { get; private set; }

        public Player(string login, int level) 
        { 
            Login = login;
            Level = level;
        }
    }
}
