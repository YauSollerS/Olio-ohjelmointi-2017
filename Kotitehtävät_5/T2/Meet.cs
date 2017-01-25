using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace T2
{
    class Meet : Food
    {
        public bool Sauce { get; set; }

        public Meet(string name, string type, string best, bool kastike) : base (name, type, best)
        {
            Sauce = kastike;
        }

        public override string ToString()
        {
            return base.ToString() + " With Sauce: " + Sauce;
        }
    }
}
