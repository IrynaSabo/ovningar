using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv något: ");
            string inmattadText = Console.ReadLine();
            Console.Write("Du skrev följande text: ");
            Console.Write(inmattadText);
            Console.ReadLine();
        }
    }
}
