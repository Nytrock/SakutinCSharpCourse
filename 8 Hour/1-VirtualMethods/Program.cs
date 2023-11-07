using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonePlayerCharacter[] characters =
            {
                new NonePlayerCharacter(),
                new Farmer(),
                new Knight(),
                new Child()
            };

            foreach (var character in characters) {
                character.ShowDescription();
                Console.WriteLine(new String('-', 40));
            }

            Console.ReadKey();
        }
    }

    class NonePlayerCharacter
    {
        public virtual void ShowDescription()
        {
            Console.WriteLine("Я простой NPC, умею только гулять.");
        }
    }

    class Farmer : NonePlayerCharacter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("А ещё я фермер и умею работать на поле.");
        }
    }

    class Knight : NonePlayerCharacter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я рыцарь, моё дело только сражения!");
        }
    }

    class Child : NonePlayerCharacter
    {

    }
}
