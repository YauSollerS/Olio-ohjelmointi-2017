using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio player = new Radio();

            player.OnkoPaalla = true;
            player.Volume = 5;
            player.Herz = 15000.0F;
            Console.WriteLine("Radio is working: {0} Volume: {1} Frequency: {2} \n", player.OnkoPaalla, player.Volume, player.Herz);

            player.OnkoPaalla = true;
            player.Volume = 100;
            player.Herz = -20.0F;
            Console.WriteLine("Radio is working: {0} Volume: {1} Frequency: {2} \n", player.OnkoPaalla, player.Volume, player.Herz);

            player.OnkoPaalla = false;
            player.Volume = 3;
            player.Herz = 12000.0F;
            Console.WriteLine("Radio is working: {0} Volume: {1} Frequency: {2} \n", player.OnkoPaalla, player.Volume, player.Herz);
        }
    }
}
