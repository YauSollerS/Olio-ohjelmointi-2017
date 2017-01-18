using System;
/// <summary>
/// Tehtävä 4
///Tee ohjelma, joka tulostaa käyttäjän antamaa lukua(1, 2 tai 3) vastaavan luvun sanana(yksi, kaksi tai kolme).
/// Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
/// </summary>
using JAMK.IT;

namespace T4
{
    class T4
    {
        static void Main(string[] args)
        {
            Vihecle bicycle = new Vihecle();
            bicycle.Name = "Cube";
            bicycle.Speed = 50;
            bicycle.Tyres = 28;

            bicycle.PrintData();

            Console.WriteLine("String: {0}",bicycle.ToString());


        }
    }
}
