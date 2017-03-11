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

            Lompakko lom1 = new Lompakko();
            lom1.Alustettu();
            Console.WriteLine(lom1.ToString());

            lom1.LisaaRaha(200);

            Card card1 = new Card("S-Etukortti", "1234 5678 9012", "Kirsi Kernel");
            Card card2 = new Card("Greencard", "fi-64-244456", "Matti Meikäläinen");
            Console.WriteLine("Lompakkoon lisätty kortti : S-Etukortti 1234 5678 9012 Kirsi Kernel" );
            Console.WriteLine("Lompakkoon lisätty kortti : Greencard fi-64-244456 Matti Meikäläinen");
            lom1.LisaaKortti(card1);
            lom1.LisaaKortti(card2);

            Console.WriteLine(lom1.ToString());

           
            lom1.OttaaRaha(100);

            Console.WriteLine(lom1.ToString());

            lom1.OttaaRaha(150);

                      

            Console.WriteLine("Lompakkoon poistettu kortti : S-Etukortti 1234 5678 9012 Kirsi Kernel");
            lom1.PoistaKortti(card1);

            Console.WriteLine(lom1.ToString());
            lom1.Alustettu();
            Console.WriteLine(lom1.ToString());

        }
    }
}
