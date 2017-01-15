using System;
/// <summary>
/// Tehtävä 3
/// Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
/// </summary>
namespace T3
{
    class T3
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
           
          
            System.Console.WriteLine("Anna luku1: ");
            luku1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Anna luku2: ");
            luku2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Anna luku3: ");
            luku3 = Convert.ToInt32(Console.ReadLine());

            
            
            Console.WriteLine("Summa on " + (luku1 + luku2 + luku3));
            System.Console.WriteLine("Keskiarvo on: "+ (luku1 + luku2 + luku3)/3);

        }
    }
}
