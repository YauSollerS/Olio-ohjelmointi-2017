using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Bike : Tuote
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public Bike (string nimi, string malli, int vuosi, string vari, bool gear, string gearname)
            : base ( nimi, malli, vuosi, vari)
        {
            GearWheels = gear;
            GearName = gearname;
        }

        public override string ToString()
        {
            return base.ToString() + " GearWheels: " + GearWheels + " Gear Name: " + GearName;
        }

    }
}
