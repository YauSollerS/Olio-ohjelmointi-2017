using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vihecle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Vehiclen ominaisuudet : ");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Speed : " + Speed);
            Console.WriteLine("- Tyres : " + Tyres);
        }

        public override string ToString()
        {
            return Name+" "+Speed+" "+Tyres;
        }

    }
}
