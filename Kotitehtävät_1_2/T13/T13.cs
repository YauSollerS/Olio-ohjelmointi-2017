using System;
/// <summary>
/// /// Tehtävä 13
/// Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle 
/// hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.
/// Esimerkkitoiminta:
///     Anna pisteet > 18 [Enter]
///     Anna pisteet > 15 [Enter]
///     Anna pisteet > 20 [Enter]
///     Anna pisteet > 19 [Enter]
///     Anna pisteet > 17 [Enter]
///     Kokonaispisteet ovat 54
/// </summary>


namespace T13
{
    class T13
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];
            for (int i = 0; i < luvut.Length; i++)
            {
                System.Console.Write("Anna luku ");
                luvut[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = int.MinValue;
            foreach (int value in luvut)
            {

                if (value > max)
                    max = value;
            }
            
            int min = int.MaxValue;
            foreach (int some in luvut)
            {

                if ( some < min)
                    min = some;
            }
            
            int sum=0;
            foreach (int any in luvut)
            {
                sum += any;
            }

            int piste = sum - max - min;
            Console.WriteLine("Kokonaispisteet ovat " + piste);

        }
    }
}
