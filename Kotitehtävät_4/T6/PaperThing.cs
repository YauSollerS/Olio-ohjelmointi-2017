using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class PaperThing : Thing
    {
        public int PageCount { get; set; }

        public PaperThing (string type, string name, int year, int sivut) : base (type, name, year)
        {
            PageCount = sivut;
        }

        public override string ToString()
        {
            return base.ToString()+ " Amount of pages: " + PageCount;
        }
    }
}
