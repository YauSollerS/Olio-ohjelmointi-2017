using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Fruit : Food
    {
        public string From { get; set; }

        public Fruit (string name, string type, string best, string from) : base (name, type, best)
        {
            From = from;
        }

        public override string ToString()
        {
            return base.ToString() + " Produced: " + From;
        }

    }
}
