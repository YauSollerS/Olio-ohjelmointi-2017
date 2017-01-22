using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Tuote
    {
        public string  Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public Tuote (string nimi, string malli , int vuosi, string vari)
        {
            Name = nimi;
            Model = malli;
            ModelYear = vuosi;
            Color = vari;
        }

        public override string ToString()
        {
            return " -Name: " + Name + " Model: " + Model + " ModelYear: " + ModelYear + " Color: " + Color;
        }
    }
}
