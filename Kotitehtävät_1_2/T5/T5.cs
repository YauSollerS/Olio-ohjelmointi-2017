using System;
/// <summary>
/// Tehtävä 5
///Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina.Aikamääre sekuntteina 
///kysytään käyttäjältä.
///Esimerkkitoiminta:
///    Anna sekunnit > 3661 [Enter]
///    Antamasi sekunttiaika voidaan ilmaista muodossa: 1 tunti 1 minuutti 1 sekuntti
/// </summary>

namespace T5
{
    class T5
    {
        static void Main(string[] args)
        {
            int sek;
            System.Console.Write("Anna sekunnit > ");
            sek = Convert.ToInt32(Console.ReadLine());
            int tunti = sek / 3600;
            int minutti = (sek - (tunti*3600)) / 60;
            int sekuntti = sek - (tunti*3600) - (minutti*60);
            System.Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunti+ " tunti "+ minutti+" minuutti "+sekuntti+" sekuntii ");
        }
    }
}
