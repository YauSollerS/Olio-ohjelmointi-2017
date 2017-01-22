using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi Elevator = new Hissi();

            int lenght = 1;
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Elevator is now in floor: " + Elevator.Floor);
                Console.Write("Give a new floor number(1-5) > ");
                string line = Console.ReadLine();
                int number;

           

                bool result = int.TryParse(line, out number);
                
                Elevator.Floor = number;

                if (number>5)
                    Console.WriteLine("Floor is too big! ");
                if (number < 1)
                    Console.WriteLine("Floor is too small! ");
                lenght++;

            }
        }
    }
}
