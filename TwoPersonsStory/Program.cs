using System;

namespace TwoPersonsStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett namn: ");
            string namn1 = Console.ReadLine();
            Console.Write("Skriv ett efternamn: ");
            string efternamn1 = Console.ReadLine();
            Console.Write("Skriv ett annat namn: ");
            string namn2 = Console.ReadLine();
            Console.Write("Skriv ett annat efternamn: ");
            string efternamn2 = Console.ReadLine();
            Console.WriteLine($"När {namn1}{efternamn1} och {namn2}{efternamn2} \n träffades första gången kännde dem båda två att dem kommer att vara bästa vänner.");
        }
    }
}
