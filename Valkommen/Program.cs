using System;

namespace Valkommen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ditt namn: ");
            string anvandarensNamn = Console.ReadLine();
            Console.WriteLine("Hey {0} hoppas du ska ha en underbar dag!",anvandarensNamn);
            Console.ReadLine();
        }
    }
}
