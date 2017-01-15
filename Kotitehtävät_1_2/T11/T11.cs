using System;
/// <summary>
/// Tehtävä 11
/// Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
/// *
/// **
/// ***
/// ****
/// *****
/// Käyttäjä antaa syötteenä tähtirivien lukumäärän.Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.
/// Esimerkkitoiminta:
///    Anna Luku > 3 [Enter]
///    *
///    **
///    ***
/// </summary>

namespace T11
{
    class T11
    {
        static void Main(string[] args)
        {
            int luku;
            
            System.Console.Write("Anna luku > ");
            luku = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("\n");
            for (int i=0; i<luku ;i++)
            {
                System.Console.Write("*");
                for (int j=0;j<i;j++)
                {
                    System.Console.Write("*");
                }
                System.Console.Write("\n");

            }
        }
    }
}
