using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Cow : Herbivorius
    {
        public int MilkPerDay { get; set; }

        public Cow(string type, string name, int ika, double pitka, int massa, int grass, int milk) : base (type, name, ika, pitka, massa, grass)
        {
            MilkPerDay = milk;
        }
        public override string ToString()
        {
            return base.ToString() + " Give milk every day,kg: " + MilkPerDay;
        }
    }
}
