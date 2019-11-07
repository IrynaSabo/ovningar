using System;
using System.Collections.Generic;


namespace Ryggsacken2
{
    class Program
    {
        static void Main(string[] args)
        {
            string foremal = System.String.Empty;
            List<string> ryggsacken = new List<string>(6);
            bool menyRun = true;

           while(menyRun)
           {
               Console.WriteLine("\t Välkommen till ryggsäcken!");
               Console.WriteLine("\t ========Meny========");
               Console.WriteLine("\t [1] Lägg till ett föremål");
               Console.WriteLine("\t [2] Skriv ut innehållet");
               Console.WriteLine("\t [3] Rensa innehållet");
               Console.WriteLine("\t [4] Avsluta");
               Console.WriteLine("\t =====================");
               Console.Write("\n\t Välj : ");

               int menyVal = Convert.ToInt32(Console.ReadLine());

               switch(menyVal)
               {
                   case 1:
                   Console.Write("\t Vad vill du lägga till?\n");
                   foremal = Console.ReadLine();
                   if(ryggsacken.Count<6)
                   {
                       ryggsacken.Add(foremal);
                   }
                   else
                   {
                   Console.WriteLine("Din ryggsäck är full. Du måste ta bort ett föremål från ryggsäcken för \n att kunna lägga till något.");
                   }
                   break;

                   case 2:
                   Console.WriteLine("\n\t I ryggsäcken finns: ");
                   for(var i = 0; i < ryggsacken.Count; i++)
                   {
                      Console.WriteLine((i+1) + " : " + ryggsacken[i]);
                   }
                   break;

                   case 3:
                   ryggsacken.RemoveAt((ryggsacken.Count-1));
                   Console.WriteLine($"Din ryggsäck innehåller {ryggsacken.Count} föremål:");
                   foreach(var stuff in ryggsacken)
                   {
                   Console.WriteLine( $"{stuff}");
                   }
                   break;
                    
                   case 4:
                   menyRun = false;
                   Console.WriteLine("Du valde att avsluta programmet. Hej då!");
                   break;
                   
               }
               Console.ReadLine();
           }
        }
    }
}
    

