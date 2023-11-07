using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User.Identifications = 10;
            User user1 = new User();
            User user2 = new User();
            user1.ShowInfo();
            user2.ShowInfo();
            Console.ReadKey();
        }
    }

    class User
    {
        public static int Identifications;
        public int Identification;
        public static int MenHourPrice;

        public User()
        {
            Identification = ++Identifications;
        }

        public void ShowInfo()
        {
            Console.WriteLine(Identification);
        }

        public static int GetSalaryPerDay(int workedHours)
        {
            return MenHourPrice * workedHours;
        }

        public static int GetSalaryPerMonth(int workedDays)
        {
            return GetSalaryPerDay(8) * workedDays;
        }
    }
}
