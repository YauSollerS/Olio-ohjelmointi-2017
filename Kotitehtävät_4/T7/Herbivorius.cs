using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Herbivorius : Animal
    {
        public int GrassPerDay { get; set; }

        public Herbivorius(string type, string name, int ika, double pitka, int massa, int grass) : base (type, name, ika, pitka, massa)
        {
            GrassPerDay = grass;
        }
        public override string ToString()
        {
            return base.ToString() + " Eat grass every day,kg: " + GrassPerDay;
        }
    }
}
