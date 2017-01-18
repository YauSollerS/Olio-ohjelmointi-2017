using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Opiskelija
    {
        public string enimi { get; set; }
        public string snimi { get; set; }
        public double arvosanaMath { get; set; }
        public double arvosanaPhys { get; set; }
        public double keskiar { get; set; }

        public void KeskiArvo ()
        {
            keskiar = (arvosanaMath + arvosanaPhys) / 2;
        }


    }
}
