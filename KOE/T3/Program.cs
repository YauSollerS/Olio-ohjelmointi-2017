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

            Lompakko lom1 = new Lompakko(200);

            Console.WriteLine("Lompakkoon lisätty rahaa: {0}", lom1.Raha);

            Card card1 = new Card("S-Etukortti", "1234 5678 9012", "Kirsi Kernel");
            lom1.LisaaKortti(card1);

            foreach (Card k in lom1.Cardlista)
            {
                Console.WriteLine("\n{0}", k.ToString());
            }

        }
    }
}
