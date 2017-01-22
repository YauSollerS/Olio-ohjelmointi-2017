using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Tablet : Electronics
    {
        public bool SimCard { get; set; }
        public string Processor { get; set; }

        public Tablet(string type, string name, int year, string valmistaja, string osi, bool sim, string proc) : base (type, name, year, valmistaja, osi)
        {
            SimCard = sim;
            Processor = proc;
        }

        public override string ToString()
        {
            return base.ToString() + " Processor: " + Processor + " SimCard: " + SimCard;
        }
    }
}
