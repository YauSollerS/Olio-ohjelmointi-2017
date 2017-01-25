using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public Ihminen( string name, int age, int weight, int height) : base(age)
        {
            Nimi = name;
            Paino = weight;
            Pituus = height;
        }

        public override void Liiku()
        {
            Console.WriteLine(Nimi +" liikun ");
        }

        public void Kasva()
        {
            Ika++;
            Console.WriteLine(Nimi+" kasvoi. Uusi ikä: "+Ika); ;
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + base.ToString() + " Paino: " + Paino + " Pituus: " + Pituus ;
        }
    }
}
