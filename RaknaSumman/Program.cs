using System;

namespace RaknaSumman
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Write("Ange ett tal: ");
            string input1 = Console.ReadLine();
            var tal1 = Convert.ToInt32(input1);
            Console.Write("Ange ett annat tal: ");
            string input2 = Console.ReadLine();
            var tal2 = Convert.ToUInt32(input2);
            var summa = tal1 + tal2;
            Console.WriteLine($"Dina tal är: {tal1} och {tal2}. Summan av dem två tall är: {summa}");
        }
    }
}
