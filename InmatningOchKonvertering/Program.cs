using System;

namespace InmatningOchKonvertering
{
    class Program
    {
        static void Main(string[] args)
        {   double daysInYear = 365.242199;
            Console.Write("Skriv ditt namn: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}");
            Console.Write("Hur gammal är du? ");
            string userAgeInput = Console.ReadLine();
            double userAge = Convert.ToDouble(userAgeInput);
            var dagarLevdUser = Math.Round(userAge * daysInYear);
            Console.WriteLine($"Du levde i {dagarLevdUser} dagar");
        }
    }
}
