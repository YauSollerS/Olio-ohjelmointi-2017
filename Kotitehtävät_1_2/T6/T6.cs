using System;
/// <summary>
/// Tehtävä 6
///Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
///Tee ohjelma, joka tulostaa ajetulla matkalla(kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan 
///menevän rahan määrän.
///Esimerkkitoiminta:
///    Anna matka > 250 [Enter]
 ///   Bensaa kuluu 17,55 litraa, kustannus 27,99 euroa
/// </summary>

namespace T6
{
    class T6
    {
        static void Main(string[] args)
        {
            int matka;
            System.Console.WriteLine("Anna matka > ");
            matka = Convert.ToInt32(Console.ReadLine());
            double bensa = matka * 7.02 / 100;
            double euro = bensa * 1.595;
            euro = Math.Round(euro, 2);

            System.Console.WriteLine("Bensaa kuluu " + bensa+" litraa, kustannus " + euro +" euroa");

        }
    }
}
