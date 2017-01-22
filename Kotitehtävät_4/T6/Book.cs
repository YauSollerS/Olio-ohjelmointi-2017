using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Book : PaperThing
    {
        public string Author { get; set; }

        public Book (string type, string name, int year, int sivut, string avtor) : base (type, name, year, sivut)
        {
            Author = avtor;
        }

        public override string ToString()
        {
            return base.ToString() + " Author: " + Author;
        }
    }
}
