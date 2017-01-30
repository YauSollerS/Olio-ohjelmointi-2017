using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata SM-Liiga-joukkueen JYP pelaajia. Luo Pelaaja-luokka jolla on 
/// ominaisuudet Etunimi, Sukunimi, Ikä ja Numero. Löydät täältä JYP pelaajat kaudella 2016-17. Luo myös Joukkue-luokka. 
/// Luokalla on ominnaisuudet Nimi, Kotikaupunki ja Pelaajat. Ominaisuus Pelaajat on siis lista Pelaaja-olioita. Tee 
/// Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), jota konstruktori kutsuu. HaePelaajat metodi luo 
/// Pelaajat-listaan oikeat pelaajat.
/// Bonustehtävä: missä ja miten pitäisi pelaajatietoja silloin tallessa kun ohjelma ei ole käynnissä? Listaa erilaiset 
/// vaihtoehdot.Toteuta niistä tekstitiedosto-pohjainen ratkaisu.
/// </summary>
/// 

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue jou1 = new Joukkue("JYP", "Jyväskylä");

            Pelaaja player1 = new Pelaaja("Juho", "Olkinuora", 26, 45);
            Pelaaja player2 = new Pelaaja("Markus", "Ruusu", 19, 97);
            Pelaaja player3 = new Pelaaja("Pekka", "Tuokkola", 33, 83);
            Pelaaja player4 = new Pelaaja("Olli", "Aitola", 24, 60);
            Pelaaja player5 = new Pelaaja("Joona", "Erving", 22, 53);

            jou1.LisaaPelaajat(player1);
            jou1.LisaaPelaajat(player2);
            jou1.LisaaPelaajat(player3);
            jou1.LisaaPelaajat(player4);
            jou1.LisaaPelaajat(player5);

            Console.WriteLine(jou1.ToString());
                                
            jou1.Pelaajat.Remove(45);

            Console.WriteLine("\nUusi joukkue: \n");

            Console.WriteLine(jou1.ToString());

          
        }
    }
}
