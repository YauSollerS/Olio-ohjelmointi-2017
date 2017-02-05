using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Tehtävä 2
/// Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta riittää käsitellä nimi ja hinta. 
/// Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota. 
/// Tulosta lopuksi kokoelman sisältö.
/// </summary>

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart ostot = new Cart();

            Product pro1 = new Product("Milk", 1.4M);
            Product pro2 = new Product("Beer", 2.2M);
            Product pro3 = new Product("Butter", 3.2M);
            Product pro4 = new Product("Cheese", 4.2M);


            ostot.AddProduct(pro1);
            ostot.AddProduct(pro2);
            ostot.AddProduct(pro3);
            ostot.AddProduct(pro4);

            Console.WriteLine("All products in collection:");

            foreach (Product p in ostot.Productlist)
            {
                Console.WriteLine("-product : {0}", p.ToString());
            }
        }
    }
}
