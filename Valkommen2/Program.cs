using System;

namespace Valkommen2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ditt namn: ");
            string userName = Console.ReadLine();
            Console.Write("Skriv ditt efternamn: ");
            string userSurname = Console.ReadLine();
            Console.WriteLine($"God dag {userName} {userSurname} !");
            Console.ReadLine();
        }
    }
}
