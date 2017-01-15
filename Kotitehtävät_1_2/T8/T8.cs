using System;
/// <summary>
/// Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
///Esimerkkitoiminta:
///    Anna Luku > 5 [Enter]
///    Anna Luku > 15 [Enter]
///    Anna Luku > 7 [Enter]
///    Suurin luku on 15
/// </summary>

namespace T8
{
    class T8
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];

            for (int i=0; i<3; i++)
            {
                System.Console.WriteLine("Anna luku ");
                luvut[i] = Convert.ToInt32(Console.ReadLine());

            }
            int max = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                if (luvut[i] > max)
                {
                    
                    max = luvut[i];
                }
            }
            System.Console.WriteLine("Suurin luku on " +max);
        }
    }
}
