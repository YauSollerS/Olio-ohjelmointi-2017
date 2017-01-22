using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Boat : Tuote
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat (string nimi, string malli, int vuosi, string vari, int paikkat, string venentyppi)
            : base (nimi, malli, vuosi, vari)
        {
            SeatCount = paikkat;
            BoatType = venentyppi;
        }

        public override string ToString()
        {
            return base.ToString() + " SeatCount: " + SeatCount + " BoatType: " + BoatType;
        }
    }
}
