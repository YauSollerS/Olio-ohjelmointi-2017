using System;
/// <summary>
/// Tehtävä 4
///Tee ohjelma, jossa kysytään käyttäjältä tämän ikä.Jos ikä on alle 18 vuotta, tulosta "alaikäinen",
///jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
/// </summary>
namespace T4
{
    class T4
    {
        static void Main(string[] args)
        {
            int ika;
            System.Console.Write("Anna ikäni: ");
            ika = Convert.ToInt32(Console.ReadLine());
            if (ika < 18)

                System.Console.WriteLine("Olet alaikäinen");
            else
            {
                if (ika > 18 && ika < 65)
                    System.Console.WriteLine("Olet aikuinen");
                else
                System.Console.WriteLine("Olet seniori");
            }




        }
    }
}
