using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT; //helpottaan meidän luokkien löytämästi

namespace Vikko3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();

        }

        static void TestaaKiuas()
        {
            //luodaan kiuas olio
            Kiuas kiuas = new JAMK.IT.Kiuas();
            //pistetään kiuas lämpenemään ja setetaan lämpöä&kosteutta
            kiuas.OnkoPäällä = true;
            kiuas.Lämpötila = 90;
            kiuas.Kosteus = 50;
            //näytetään konsolilla
            Console.WriteLine("Kiuas on pällä {0}", kiuas.OnkoPäällä);
            Console.WriteLine("Kiukaan lämpötila on {0}", kiuas.Lämpötila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);

            //mitä tapahtuu jos kosteus yli rajojen
            kiuas.Kosteus = 101;
            Console.WriteLine("Kiukaan kosteus on {0}", kiuas.Kosteus);
        }
    }
}
