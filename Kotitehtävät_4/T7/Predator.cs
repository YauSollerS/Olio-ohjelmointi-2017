using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Predator : Animal
    {
        public int MeetPerDay { get; set; }

        public Predator (string type, string name, int ika, double pitka, int massa, int meet) : base (type, name, ika, pitka, massa)
        {
            MeetPerDay = meet;
        }
        public override string ToString()
        {
            return base.ToString() + " Eat meet every day,kg: " + MeetPerDay;
        }
    }
}
