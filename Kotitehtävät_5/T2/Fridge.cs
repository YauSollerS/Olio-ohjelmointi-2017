using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Fridge
    {

        public List<Food> Ruoat { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public Fridge(string name, string model)
        {
            Name = name;
            Model = model;
            Ruoat = new List<Food>();
        }

        public void AddRuoat(Food eda)
        {
            Ruoat.Add(eda);
        }

        public override string ToString()
        {

            string lause = "\nThis fridge brand: " + Name + " Model " + Model + " contains: ";

            foreach (Food foo in Ruoat)
            {
                lause += "\n" + foo.ToString();
            }

            return lause;
        }
    }
}
