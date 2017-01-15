using System;
/// <summary>
/// Tehtävä 7
/// Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi.Vuosiluku kysytään käyttäjältä.
/// Algoritmi
/// 4:llä jaolliset on, paitsi täydet vuosisadat.Kuitenkin 400:lla jaolliset vuosisadat ovat
/// Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
/// </summary>


namespace T7
{
    class T7
    {
        static void Main(string[] args)
        {
            int vuosi;
            System.Console.WriteLine("Anna vuosi ");
            vuosi = Convert.ToInt32(Console.ReadLine());

            if (vuosi % 4 == 0 && vuosi%100!=0)
            {
              System.Console.WriteLine("Vuosi on karkausvuosi. ");
            }
     
            if (vuosi % 100 == 0 && vuosi % 400 == 0)
            {
                System.Console.WriteLine("Vuosi on karkausvuosi. ");
            }
            if (vuosi%4==0 && vuosi%100==0 && vuosi%400!=0)
            {
                System.Console.WriteLine("Vuosi ei ole karkausvuosi. ");
            }
            if (vuosi % 4 != 0)
            {
                System.Console.WriteLine("Vuosi ei ole karkausvuosi. ");
            }
        }
    }
}
