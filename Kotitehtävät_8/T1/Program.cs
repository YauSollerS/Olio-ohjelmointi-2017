using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Tehtävä 1
/// Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla.
/// Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. Toteuta tämän jälkeen
/// ohjelma siten, että kysyt käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen lukujen keskiarvo.
/// </summary>


namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            List<int> trows = new List<int>();
            Random rnd = new Random();
            do
            {
                Console.Write("How many times you want to throw a dice( 0 for end) : ");
                string line = Console.ReadLine();
                if (int.TryParse(line, out luku))
                {
                    if (line == "0")
                    {
                        break;
                    }
                    else
                    {
                        for (int i =0; i<luku;i++)
                        {
                            trows.Add(rnd.Next(1, 7));
                        }

                        var items = trows
                        .GroupBy(g => g)
                        .Select(t => new { count = t.Count(), key = t.Key });

                        Console.WriteLine("Dice is now thrown {0} times, average is : {1} ", luku, trows.Average());

                        foreach (var heita in items)
                        {
                            Console.WriteLine("- {0} count is {1}", heita.key, heita.count);
                        }


                    }
                }
                else
                {
                    Console.WriteLine("Just numbers is allowed");
                }
            } while (true);
        }
    }
}
