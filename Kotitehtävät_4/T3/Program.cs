using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Employee("Mikko", "Datanomi", 2000);
            Employee worker2 = new Employee("Rikka", "Merkonomi", 1800);
            Boss head = new Boss("Heikki", "Toimitusjohtaja", 3500, "Volvo", 1500);

            Console.WriteLine("Employee:\n"+worker1+"\n");
            Console.WriteLine("Boss:\n" + head + "\n");
            Console.WriteLine("Employee:\n" + worker2 + "\n");
            



        }
    }
}
