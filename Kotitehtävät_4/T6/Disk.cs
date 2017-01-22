using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Disk : Thing
    {
        public string Content { get; set; }

        public Disk(string type, string name, int year, string content) : base (type, name, year)
        {
            Content = content;
        }

        public override string ToString()
        {
            return base.ToString() + " Content: " + Content;
        }
    }
}
