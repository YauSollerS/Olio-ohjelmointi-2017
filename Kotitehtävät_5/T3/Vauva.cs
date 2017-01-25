using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva( string name, int age, int weight, int height, string vaippa) : base( name, age, weight, height)
        {
            Vaippa = vaippa;
        }

        public override void Liiku()
        {
            Console.WriteLine(Nimi + " konttaa");
        }

        public override string ToString()
        {
            return base.ToString() + " Vaippa: " + Vaippa;
        }
    }
}
