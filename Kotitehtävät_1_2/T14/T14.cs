using System;
/// <summary>
/// /// Tehtävä 14
/// Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta 
/// (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:
/// Arvosanajakauma: 
/// 0:
/// 1:****
/// 2:**
/// 3:******
/// 4:*****
/// 5:**
/// Esimerkkitoiminta:
///    Anna arvosana > 5 [Enter]
///     Anna arvosana > 5 [Enter]
///     Anna arvosana > 4 [Enter]
///     Anna arvosana > 3 [Enter]
///     Anna arvosana > 2 [Enter]
///     Anna arvosana > 1 [Enter]
///     Anna arvosana > 0 [Enter]
///     Anna arvosana > 0 [Enter]
///     Arvosanat:
///         0:**
///         1:*
///         2:*
///         3:*
///         4:*
///         5:**
/// </summary>

namespace T14
{
    class T14
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("Anna opiskelijan lukumäärä ");
            int max= Convert.ToInt32(Console.ReadLine());

            int[] arvo = new int[max];
            int nolla = 0;
            int yksi = 0;
            int kaksi = 0;
            int kolme = 0;
            int nelja = 0;
            int viisi = 0;

            for (int i = 0; i < max; i++)
            {
                System.Console.Write("Anna arvosana > ");
                arvo[i] = Convert.ToInt32(Console.ReadLine());
                if (arvo[i] == 0)
                    nolla++;
                if (arvo[i] == 1)
                    yksi++;
                if (arvo[i] == 2)
                    kaksi++;
                if (arvo[i] == 3)
                    kolme++;
                if (arvo[i] == 4)
                    nelja++;
                if (arvo[i] == 5)
                    viisi++;

            }
            System.Console.WriteLine("Arvosanat:");
            System.Console.Write("0:");
            for (int j = 0; j < nolla; j++)
            {
                System.Console.Write("*");
            }

            System.Console.Write("\n1:");
            for (int j = 0; j < yksi; j++)
            {
                System.Console.Write("*");
            }
            System.Console.Write("\n2:");
            for (int j = 0; j < kaksi; j++)
            {
                System.Console.Write("*");
            }
            System.Console.Write("\n3:");
            for (int j = 0; j < kolme; j++)
            {
                System.Console.Write("*");
            }
            System.Console.Write("\n4:");
            for (int j = 0; j < nelja; j++)
            {
                System.Console.Write("*");
            }
            System.Console.Write("\n5:");
            for (int j = 0; j < viisi; j++)
            {
                System.Console.Write("*");
            }
            System.Console.Write("\n");
        }
    }
}
