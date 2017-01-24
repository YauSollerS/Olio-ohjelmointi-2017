using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Kulkuneuvo
    {
        public List<Rengas> Renkaat { get; set; }
        public string Nimi { get; set; }
        public string Malli { get; set; }

        public Kulkuneuvo (string name, string model)
        {
            Nimi = name;
            Malli = model;
            Renkaat = new List<Rengas>();
        }

        public void LisaaKulkuneuvo()
        {
            Console.WriteLine("Created a new vehichle " + Nimi + " model " + Malli);
        }

        public void LisaaRengas(Rengas one)
        {
            Renkaat.Add(one);
            Console.WriteLine("Type " + one.Merkki + " added to vehicle " + Nimi);

        }

        public override string ToString()
        {
            string lause = "\nVechicle Name: " + Nimi + " Model " + Malli+"\nTyres:";

            foreach (Rengas ren in Renkaat)
            {
                lause += "\n" + ren.ToString();
            }

            return lause;
        }


    }
}
