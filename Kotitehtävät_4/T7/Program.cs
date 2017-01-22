using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  ZOO program
/// </summary>
namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tig1 = new Tiger("Predator", "Tiger", 5, 3, 300, 20, 18);
            Bear bear1 = new Bear("Predator", "Bear", 3, 3.5, 200, 10, 5);
            Cow cow1 = new Cow("Herbivorius", "Cow", 4, 3, 180, 30, 10);
            Goat goat1 = new Goat("Herbivorius", "Goat", 3, 1.5, 70, 10, 3);

            Console.WriteLine("Animals: \n" + tig1 + "\n" + bear1 + "\n" + cow1 + "\n" + goat1 + "\n" );
        }
    }
}
