using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Convertation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trigger = 0, reconvert;
            bool triggerInBoolean = Convert.ToBoolean(trigger);
            Console.WriteLine(triggerInBoolean);

            reconvert = Convert.ToInt32(trigger);
            Console.WriteLine(reconvert);

            Console.ReadKey();
        }
    }
}
