using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Tehtävä 1
/// Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. 
/// Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi 
/// Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina esim. 
/// taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen (kokoelmaluokat käsitellään tarkemmin seuraavissa 
/// demoissa). Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. Tietoja ei 
/// tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.
/// </summary>

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo porshe = new Kulkuneuvo("Porshe", "911");
            porshe.LisaaKulkuneuvo();
            Rengas nokia = new Rengas { Merkki = "Nokia", Tyyppi = "Hakkapeliitta", RengasKoko = "205R16" };
            porshe.LisaaRengas(nokia);
            porshe.LisaaRengas(nokia);
            porshe.LisaaRengas(nokia);
            porshe.LisaaRengas(nokia);
            Console.WriteLine(porshe+"\n");

            Kulkuneuvo ducati = new Kulkuneuvo("Ducati", "Diavel");
            ducati.LisaaKulkuneuvo();
            Rengas mic1 = new Rengas { Merkki = "MIC", Tyyppi = "Pilot", RengasKoko = "160R17" };
            Rengas mic2 = new Rengas { Merkki = "MIC", Tyyppi = "Pilot", RengasKoko = "140R16" };
            ducati.LisaaRengas(mic1);
            ducati.LisaaRengas(mic2);
            Console.WriteLine(ducati);
        }
    }
}
