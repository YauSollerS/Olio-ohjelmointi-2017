using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Tiger : Predator
    {
        public int SleepPerDay { get; set; }

        public Tiger(string type, string name, int ika, double pitka, int massa, int meet, int sleep) : base (type, name, ika, pitka, massa, meet)
        {
            SleepPerDay = sleep;
        }
        public override string ToString()
        {
            return base.ToString() + " Sleep every day,hours: " + SleepPerDay;
        }
    }
}
