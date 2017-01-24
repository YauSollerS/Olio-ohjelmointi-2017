using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Rengas
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        public string RengasKoko { get; set; }

        public override string ToString()
        {
            return "-Name: " + Merkki + " Model: " + Tyyppi + " TyreSize: " + RengasKoko;
        }
    }
}
