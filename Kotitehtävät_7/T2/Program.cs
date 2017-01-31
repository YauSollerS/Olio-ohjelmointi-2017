using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja kertoo montako nimeä löytyy ja 
/// montako kertaa kukin nimi esiintyy. Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi 
/// tarkistamaan onko em.hakemistossa tiedostoa.Käytä File.Exist-metodia.	Huomioi myös muut mahdolliset poikkeukset, 
/// joita tiedoston käsittely voi aiheuttaa.
/// </summary>
/// 

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;
            try
            {

                List<string> lines = System.IO.File.ReadLines(@"D:\nimet.txt").ToList();

               
                var items = lines
                 .GroupBy(g => g)
                .Select(t => new { count = t.Count(), key = t.Key });



                Console.WriteLine("Löytyi {0} riviä, ja {1} nimeä.", lines.Count, items.Count());

                foreach (var group in items)
                {
                    
                    Console.WriteLine("Nimi {0} esiintyy {1} kertaa", group.key, group.count);
                }
            }
            

            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
            finally
            {

                if (outputFile != null)
                {
                    outputFile.Close();
                }
                
            }
        }
    }
}
