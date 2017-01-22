using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Bear : Predator
    {
        public int  HoneyPerDay { get; set; }

        public Bear(string type, string name, int ika, double pitka, int massa, int meet, int honey) : base (type, name, ika, pitka, massa, meet)
        {
            HoneyPerDay = honey;
        }
        public override string ToString()
        {
            return base.ToString() + " Eat honey every day,kg: " + HoneyPerDay;
        }
    }
}
