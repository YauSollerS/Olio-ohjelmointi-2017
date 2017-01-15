using System;
/// <summary>
/// Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0.
/// Ohjelman tulee tulostaa syötettyjen lukujen summa.
///Esimerkkitoiminta:
///   Anna Luku > 10 [Enter]
///   Anna Luku > 20 [Enter]
///   Anna Luku > 30 [Enter]
///   Anna Luku > 0 [Enter]
///   Lukujen summa on 60
/// </summary>

namespace T9
{
    class T9
    {
        static void Main(string[] args)
        {
            int MAX=1;
            int sum = 0;
           for (int i=0; i<MAX;i++)
             {
                    int[] luvut = new int[MAX];
                    System.Console.WriteLine("Anna luku ");
                    luvut[i] = Convert.ToInt32(Console.ReadLine());
                    MAX++;
                

                foreach (int value in luvut)
                {
                sum += value;
                }
                if (luvut[i] == 0)
                {
                    System.Console.WriteLine("Lukujen summa on " + sum);
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
