using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin Player = new Vahvistin();

            int lenght = 1;
            for (int i = 0; i < lenght; i++)
            {
                
                Console.Write("Give a new volume value (0-100) > " );
                string line = Console.ReadLine();
                int number;
                
                bool result = int.TryParse(line, out number);

                Player.Volume = number;
                                
                Console.WriteLine(Player.VolumeMessage);
                lenght++;

            }
        }
    }
}
