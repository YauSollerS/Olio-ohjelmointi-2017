using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Newspaper : PaperThing
    {
        public string Town { get; set; }

        public Newspaper(string type, string name, int year, int sivut, string city) : base (type, name, year, sivut)
        {
            Town = city;
        }

        public override string ToString()
        {
            return base.ToString() + " Town: " + Town;
        }
    }
}
