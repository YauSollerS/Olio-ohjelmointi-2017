using System;
/// <summary>
/// Tehtävä 2
///Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
///pisteraja numero
/// 0-1	0
/// 2-3	1
/// 4-5	2
/// 6-7	3
/// 8-9	4
/// 10-12	5
/// </summary>

namespace T2
{
    class T2
    {
        static void Main(string[] args)
        {
            int luku;
            System.Console.Write("Anna pistemäärä ");

            luku = Convert.ToInt32(Console.ReadLine());
            if (luku == 1 || luku==0)
                System.Console.WriteLine("Sinun numero on 0 ");
            if (luku == 2 || luku==3)
                System.Console.WriteLine("Sinun numero on 1 ");
            if (luku == 4 || luku==5)
                System.Console.WriteLine("Sinun numero on 2 ");
            if (luku == 6 || luku ==7)
                System.Console.WriteLine("Sinun numero on 3 ");
            if (luku == 8 || luku==9)
                System.Console.WriteLine("Sinun numero on 4 ");
            if (luku == 10 || luku==11 || luku==12)
                System.Console.WriteLine("Sinun numero on 5 ");
        }
    }
}
