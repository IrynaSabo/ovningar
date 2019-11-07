using System;

namespace IfSatserOchInmatning
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.Write("Är det fint väder idag?\n\t J/N : ");
            string usersAnswer = Console.ReadLine();
            if(usersAnswer.ToLower()=="ja" || usersAnswer.ToLower() =="j"|| usersAnswer.ToLower()=="jepp")
              {    
                 Console.WriteLine("Gå på picknick!");
              }
            else if(usersAnswer.ToLower()=="nej" || usersAnswer.ToLower()=="n" || usersAnswer.ToLower()=="nepp")
            {
                 Console.WriteLine("Du borde stanna hemma och läsa boken om programmering!");
            }
            else
            {
                Console.WriteLine("Jag förstår inte riktigt!");
            }
        }
    }
}
