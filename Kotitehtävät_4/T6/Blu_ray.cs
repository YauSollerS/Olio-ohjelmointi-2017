using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Blu_ray : Disk
    {
        public string Director { get; set; }

        public Blu_ray(string type, string name, int year, string content, string dir) : base (type, name, year, content )
        {
            Director = dir;
        }

        public override string ToString()
        {
            return base.ToString() + " Director: " + Director;
        }
    }
}
