using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }

        public Pelaaja (string enimi, string snimi, int age, int numb)
        {
            Etunimi = enimi;
            Sukunimi = snimi;
            Ika = age;
            Numero = numb;
        }

        public override string ToString()
        {
            return " -Etunimi: " +Etunimi+" Sukunimi: " +Sukunimi+" Ikä: "+Ika+" Numero :"+Numero;
        }
    }

    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public Dictionary<int, Pelaaja> Pelaajat;

        public Joukkue(string name, string sity)
        {
            Nimi = name;
            Kotikaupunki = sity;
            Pelaajat = new Dictionary<int, Pelaaja>();
        }
        
        public void LisaaPelaajat(Pelaaja pel)
        {
            Pelaajat.Add(pel.Numero, pel);
        }
       

        public override string ToString()
        {
            string s= "Joukkue: " + Nimi + " Kaupunki: " + Kotikaupunki;
            foreach (var pl in Pelaajat)
            {
                
                s += "\n" + pl.ToString();
            }

            return s;

        }
    }
}
