using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Book", "War and Peace", 1869, 1225, "Tolstoy");
            Newspaper newspaper1 = new Newspaper("Newspaper", "Helsingin Sanomat", 2017, 36, "Helsinki");
            CD_disk cd1 = new CD_disk("CD disk", "Mutter", 2001, "Music", "Rammstein");
            Blu_ray blu1 = new Blu_ray("Blu-Ray Disk", "Gladiator", 2000, "Movie", "Ridley Scott");
            MobilePhone mob1 = new MobilePhone("MobilePhone", "Galaxy S7", 2016, "Samsung", "Android", true, true);
            Tablet tab1 = new Tablet("Tablet", "Ipad Air 2", 2014, "Apple", "iOS", true, "ARMv8");

            Console.WriteLine("Esineet kirjahyllystä \n" + book1 + "\n" + newspaper1 + "\n" + cd1 + "\n" + blu1 + "\n" + mob1 + "\n" + tab1 + "\n");

        }
    }
}
