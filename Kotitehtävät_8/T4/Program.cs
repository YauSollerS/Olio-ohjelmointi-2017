using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Tehtävä 4
/// Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota (esim. Circle ja Rectangle). Laadi erillinen abstrakti
/// Shape-luokka, josta muut kuviot peryityvät. Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit
/// Area- ja Circumference-metodit (pinta-ala ja ympärysmitta). Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta 
/// Area- ja Circumference-metodit. Luo Shapes-luokka ja sen sisälle List-tietorakenne, jonne voit aina lisätä kuvioita. 
/// Toteuta pääohjelma, jossa käytät Shapes-luokkaa, luo muutamia eri kuviota ja lisää ne Shapes-luokassa olevaan
/// List-tietorakenteeseen. Käy pääohjelmassa lopuksi läpi Shapes-luokan List-tietorakenne ja tulosta kaikki sen sisältämät
/// kuviot.
/// </summary>
namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes muodot = new Shapes();

            Circle cir1 = new Circle("Circle", 1);
            Circle cir2 = new Circle("Circle", 2);
            Circle cir3 = new Circle("Circle", 3);

            Rectangle rec1 = new Rectangle("Rectangle", 10, 20);
            Rectangle rec2 = new Rectangle("Rectangle", 20, 30);
            Rectangle rec3 = new Rectangle("Rectangle", 40, 50);

            muodot.LisaaKuvio(cir1);
            muodot.LisaaKuvio(cir2);
            muodot.LisaaKuvio(cir3);

            muodot.LisaaKuvio(rec1);
            muodot.LisaaKuvio(rec2);
            muodot.LisaaKuvio(rec3);

            foreach (var item in muodot.Kuviot)
            {
                Console.WriteLine(item.ToString() + " Area:" + item.Area() + " Circumference:" + item.Circumference());
            }
        }
    }
}
