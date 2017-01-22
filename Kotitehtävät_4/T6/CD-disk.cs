using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class CD_disk : Disk
    {
        public string Singer { get; set; }

        public CD_disk(string type, string name, int year, string content, string laulaja) : base (type, name, year, content )
        {
            Singer = laulaja;
        }

        public override string ToString()
        {
            return base.ToString() + " Singer: " + Singer;
        }
    }
}
