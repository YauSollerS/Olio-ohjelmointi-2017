using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Thing
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int ProductionYear { get; set; }

        public Thing (string type, string name, int year)
        {
            Type = type;
            Name = name;
            ProductionYear = year;
        }

        public override string ToString()
        {
            return " -What is it: " + Type + " Name: " + Name + " Production Year: " + ProductionYear; 
        }
    }
}
