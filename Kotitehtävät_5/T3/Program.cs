using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Tehtävä 3
/// Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.
///
/// Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta(abstrakti metodi).
///
/// Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia(paino, pituus, nimi). Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella.Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa
///
/// Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat.Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto(String). Lisää vauvalle ominaisuus vaippa(String).
///
/// Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja.Tulostele olioiden tietoja konsolille.
/// </summary>

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {

            Ihminen ihm1 = new Ihminen("Pekka", 18, 92, 186);
            Aikuinen aik1 = new Aikuinen("Mikko", 23, 84, 182, "Volvo");
            Vauva vau1 = new Vauva("Pikku", 1, 10, 78, "Pampers");
            Console.WriteLine(ihm1.ToString());
            ihm1.Liiku();
            ihm1.Kasva();
            

            Console.WriteLine(aik1.ToString());
            aik1.Liiku();
            aik1.Kasva();
            aik1.Kasva();
           

            Console.WriteLine(vau1.ToString());
            vau1.Liiku();
            vau1.Kasva();
            vau1.Kasva();
            vau1.Kasva();
            vau1.Kasva();
            
        }
    }
}
