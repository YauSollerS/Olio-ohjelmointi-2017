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
            TestaaKosti();
        }

        static void TestaaKosti()
        {
            Kosti kos1 = new Kosti();

            kos1.OnkoPaalla = true;

            Console.WriteLine(kos1.AlkuMessage);

            kos1.Kosteus = 75;
            Console.WriteLine("Kosti ottanut vastaan arvon: {0}", kos1.Kosteus);
            Console.WriteLine("Kosti minimi: {0}", kos1.minkosteus );
            Console.WriteLine("Kosti maksimi: {0}", kos1.maxkosteus);

            Console.WriteLine(kos1.ToimiMessage);

            kos1.Kosteus = 80;
            Console.WriteLine("Kosti ottanut vastaan arvon: {0}", kos1.Kosteus);
            Console.WriteLine("Kosti minimi: {0}", kos1.minkosteus);
            Console.WriteLine("Kosti maksimi: {0}", kos1.maxkosteus);

            kos1.Nollattu = true;
            Console.WriteLine("Kosti nollattu");

            Console.WriteLine(kos1.AlkuMessage);

            kos1.Kosteus = 70;
            Console.WriteLine("Kosti ottanut vastaan arvon: {0}", kos1.Kosteus);
            Console.WriteLine("Kosti minimi: {0}", kos1.minkosteus);
            Console.WriteLine("Kosti maksimi: {0}", kos1.maxkosteus);
        }
    }
}
