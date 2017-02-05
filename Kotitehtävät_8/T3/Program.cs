using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Tehtävä 3
///Toteuta sovellus, jossa voit hallita kalastukseen liittyviä tietoja.Ohjelman pitää pystyä käsittelemään: saadun kalan 
///perustiedot(laji, pituus ja paino), kalastajan perustiedot(nimi, puhelinnumero) sekä saadun kalapaikan perustiedot
///(nimi ja paikka). Pohdi tarvittava luokkarakenne UML-kaaviona.Toteuta pääohjelmassa kalastaja ja muutamia kaloja.Tulosta
///lopuksi kalarekisterin sisältö.
/// </summary>

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {

            Kalastaja fisher1 = new Kalastaja("Kirsi Kernel", "020-12345678");

            Console.WriteLine("A new fisherman added to register:\n{0}", fisher1.ToString());

            Kala fish1 = new Kala("The Lake of Jyväskylä", "Jyväskylä", "pike", 120, 4.5M);

            Console.WriteLine("\nFisher: {0} got a new fish \n{1}", fisher1.Nimi, fish1.ToString());

            Kala fish2 = new Kala("River Teno", "The Northern edge of Finland", "salmon", 190, 13.2M);
            Console.WriteLine("\nFisher: {0} got a new fish \n{1}", fisher1.Nimi, fish2.ToString());

            fisher1.LisaaKala(fish1);
            fisher1.LisaaKala(fish2);

            Console.WriteLine("\nAll fishes in register: \nFisherman: {0} has got following fishes:", fisher1.Nimi);

            foreach (Kala k in fisher1.Kalalista)
            {
                Console.WriteLine("\n{0}", k.ToString());
            }


        }
    }
}
