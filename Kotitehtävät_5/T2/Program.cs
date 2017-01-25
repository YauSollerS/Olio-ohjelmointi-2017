using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Tehtävä 2
/// Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy.Tee pienimuotoinen toteutus, 
/// joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.
/// </summary>

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {

            Fridge jaakaappi1 = new Fridge("Bosch", "KSV36CI30");

            Fruit apple = new Fruit("Apple", "Fruit", "20.4.2017", "Spain");

            Meet chiken = new Meet("Chiken", "Meet", "10.2.2017", true);

            Fruit lemon = new Fruit("Lemon", "Fruit", "25.7.2017", "Israel");

            jaakaappi1.AddRuoat(apple);
            jaakaappi1.AddRuoat(apple);
            jaakaappi1.AddRuoat(apple);
            jaakaappi1.AddRuoat(apple);
           
            jaakaappi1.AddRuoat(lemon);
            jaakaappi1.AddRuoat(lemon);
            
            jaakaappi1.AddRuoat(chiken);
            jaakaappi1.AddRuoat(chiken);
            jaakaappi1.AddRuoat(chiken);

            Console.WriteLine(jaakaappi1);



        }
    }
}
