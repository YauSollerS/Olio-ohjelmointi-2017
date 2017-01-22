     using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike("Jopo", "Street", 2016, "Blue", false, " ");
            Bike bike2 = new Bike("Tunturi", "StreetPower", 2010, "Black", true, "Shimano");
            Boat boat1 = new Boat("Suvi", "S900", 1990, "White", 3, "Rowboat");
            Boat boat2 = new Boat("Yamaha", "Model 1000", 2010, "Yellow", 5, "Motorboat");

            Console.WriteLine("Bike info \n" + bike1 + "\n");
            Console.WriteLine("Bike2 info \n" + bike2 + "\n");
            Console.WriteLine("Boat info \n" + boat1 + "\n");
            Console.WriteLine("Boat2 info \n" + boat2 + "\n");
        }
    }
}
