using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Toteutetaan opettajan kanssa yhdessä konsolipohjainen ohjelma, jolla voidaan hallita henkilöitä eli henkilörekisteri.
/// </summary>
/// 

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }

        static void TestaaHenkiloRekisteri()
        {
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "311270-123A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Kirsi", Sukunimi = "Kernell", Hetu = "121270-234B" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Mat", Sukunimi = "Mickelson", Hetu = "011280-456C" };

            //lisätään henkilöt poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            //tulostetaan poppoo näytelle

            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("{0}", h.ToString());
            }

            //TODO kysy käyttäjältä hetu ja haetaan sitä vastaava henkilö näytölle
        }
    }
}
