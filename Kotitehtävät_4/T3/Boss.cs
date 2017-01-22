using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss (string nimi, string ammatti, int palkka, string auto, int lisaraha )
            : base (nimi, ammatti, palkka)
        {
            Car = auto;
            Bonus = lisaraha;
        }

        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus ;
        }
    }
}
