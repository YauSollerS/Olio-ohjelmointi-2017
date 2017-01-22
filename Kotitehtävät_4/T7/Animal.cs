using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Animal
    {
        public string AnymalType { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Growth { get; set; }
        public int Weight { get; set; }

        public Animal(string type, string name, int ika, double pitka, int massa)
        {
            AnymalType = type;
            Name = name;
            Age = ika;
            Growth = pitka;
            Weight = massa;
        }

        public override string ToString()
        {
            return " - Name: " + Name + " Anymal Type: " + AnymalType + " Age: " + Age +" Growth: " + Growth +" Weight: " + Weight;
        }
    }
}
