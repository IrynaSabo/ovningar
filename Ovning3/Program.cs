using System;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.String.Empty;
            string text = "och sen då?";
            Console.WriteLine(text);
            
             var n =2;   
             do
             {       
             Console.Write("Om du vill avsluta programmet, skriv: Q ");
            input = Console.ReadLine();   
               for(var i=0; i<n; i++)
                { 
                   Console.WriteLine(text);
                          
                }
               n *= 2;  
             }
             while(input!="Q" && input!="q");
           Console.WriteLine("Press any key to exit.");
           Console.ReadKey();
        }
    }
  }