using System;
/// <summary>
/// Tehtävä 16
/// Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. Tämän jälkeen 
/// ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje arvauksen jälkeen 
/// onko arvottu luku pienemäi vai suurempi. Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa 
/// oikean luvun. Tulosta lopuksi arvausten määrä näytölle. PS Satunnaislukujen arpomisesta tietokoneella 
/// löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number
/// generators.
/// Esimerkkitoiminta:
///    Arvaa luku > 50 [Enter]
/// Luku on suurempi
/// Arvaa luku > 75 [Enter]
/// Luku on pienempi
/// Arvaa luku > 66 [Enter]
/// Hienoa, arvasit luvun 3 kerralla.
/// </summary>

namespace T16
{
    class T16
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
         
            int luku;
            int count = 0;
            do
            {
                System.Console.Write("Anna luku > ");
                luku = Convert.ToInt32(Console.ReadLine());
                if (luku>number)
                    System.Console.WriteLine("Luku on suurempi ");
                if (luku<number)
                    System.Console.WriteLine("Luku on pienempi ");
                count++;
            } while (number != luku);
            System.Console.WriteLine("Hienoa, arvasit luvun " +count +" keralla.");
        }
    }
}
