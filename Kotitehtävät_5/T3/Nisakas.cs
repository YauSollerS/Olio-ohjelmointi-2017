using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public abstract class Nisakas
    {
        public int Ika { get; set; }
        public Nisakas (int age)
        {
            Ika = age;
        }

        public abstract void Liiku();


        public override string ToString()
        {
            return " Ikä: " + Ika;
        }
    }
}
