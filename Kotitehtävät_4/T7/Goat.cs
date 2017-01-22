using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Goat : Herbivorius
    {
        public int CheesePerDay { get; set; }

        public Goat(string type, string name, int ika, double pitka, int massa, int grass, int cheese) : base (type, name, ika, pitka, massa, grass)
        {
            CheesePerDay = cheese;
        }
        public override string ToString()
        {
            return base.ToString() + " Give cheese every day,kg: " + CheesePerDay;
        }
    }
}
