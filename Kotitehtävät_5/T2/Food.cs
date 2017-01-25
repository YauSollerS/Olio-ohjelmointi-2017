using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    abstract class Food
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string BestBefore { get; set; }

        public Food (string name, string type, string best)
        {
            Name = name;
            Type = type;
            BestBefore = best;
        }

        public override string ToString()
        {
            return "Food: " + Name + " Model: " + Type + " TyreSize: " + BestBefore;
        }
    }
}
