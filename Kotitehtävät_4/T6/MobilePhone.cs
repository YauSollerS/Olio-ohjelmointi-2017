using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class MobilePhone : Electronics
    {
        public bool Smartphone { get; set; }
        public bool NFC { get; set; }

        public MobilePhone (string type, string name, int year, string valmistaja, string osi, bool smart, bool nfc) : base (type, name, year, valmistaja, osi)
        {
            Smartphone = smart;
            NFC = nfc;
        }

        public override string ToString()
        {
            return base.ToString() + " Smartphone: " + Smartphone +" NFC: "+NFC;
        }
    }
}
