using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Kalapaika
    {
        public string Nimi { get; set; }
        public string Paikka { get; set; }
        
        public Kalapaika ( string name, string place)
        {
            Nimi = name;
            Paikka = place;
        }
        public override string ToString()
        {
            return "\n - place: " + Nimi + "\n - location: " + Paikka;
        }

    }

    class Kala : Kalapaika
    {
        public string Laji { get; set; }
        public int Pituus { get; set; }
        public decimal Paino { get; set; }

        public Kala (string name, string place, string laj, int pit, decimal pai) : base (name, place)
        {
            Laji = laj;
            Pituus = pit;
            Paino = pai;
        }

        public override string ToString()
        {
            return " - specie: "+Laji+" "+Pituus+" cm " + Paino +"kg"+ base.ToString();
        }
    }

    class Kalastaja
    {
        public string Nimi { get; set; }
        public string Puhelin { get; set; }

        private List<Kala> kalat;

        public List<Kala> Kalalista
        {
            get { return kalat; }
        }
        public Kalastaja(string name, string puh)
        {
            Nimi = name;
            Puhelin = puh;
            kalat = new List<Kala>();
        }

        public void LisaaKala(Kala fish)
        {
            kalat.Add(fish);
        }

        
        public override string ToString()
        {
            return " - Fisherman: " + Nimi + "Phone: " + Puhelin;
        }

    }


}
