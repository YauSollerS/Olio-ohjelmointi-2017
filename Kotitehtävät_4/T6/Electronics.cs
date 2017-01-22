using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Electronics : Thing
    {
        public string Manufacturer { get; set; }
        public string OS { get; set; }



        public Electronics(string type, string name, int year, string valmistaja, string osi) : base (type, name, year)
        {
            Manufacturer = valmistaja;
            
            OS = osi;
        }

        public override string ToString()
        {
            return base.ToString() + " Manufacturer: " + Manufacturer+" OS : " + OS;
        }
    }
}
