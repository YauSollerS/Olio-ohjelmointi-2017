using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04.T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Hissi Elevator = new Hissi();
            
            

            int lenght = 1;
            for (int i = 0; i < lenght; i++)
            {

                Console.Write("Give a new floor number(1-5) > ");
                string line = Console.ReadLine();
                int number;
                bool result = int.TryParse(line, out number);
                Elevator.Floor = number;
                Console.WriteLine( );
                lenght++;
                
            }
            
        }
    }
}
