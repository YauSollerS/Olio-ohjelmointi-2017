using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen( string name, int age, int weight, int height, string car) : base( name, age, weight, height)
        {
            Auto = car;
        }

        public override void Liiku()
        {
            Console.WriteLine(Nimi+" kävelee ");
        }

        public override string ToString()
        {
            return base.ToString() + " Auto: " + Auto;
        }
    }
}
