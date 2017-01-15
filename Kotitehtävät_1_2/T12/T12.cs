using System;
/// <summary>
/// Tehtävä 12
/// Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. 
/// Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
/// Esimerkkitoiminta:
///     Anna Luku > 1 [Enter]
///     Anna Luku > 2 [Enter]
///     Anna Luku > 3 [Enter]
///     Anna Luku > 4 [Enter]
///     Anna Luku > 5 [Enter]
//      Luvut ovat 5,4,3,2,1
/// </summary>

namespace T12
{
    class T12
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];
            for (int i=0;i<luvut.Length; i++)
            {
                System.Console.Write("Anna luku ");
                luvut[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(luvut);
            foreach (int rev in luvut)
                Console.Write(rev + " ");
            
        }
    }
}
