using System;
using System.Threading;
/// <summary>
/// A simple example of Lotto game
/// </summary>


namespace Lotto
{
    class Lotto
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Arvotaan viikon oikeat lottorivit");
            System.Console.Write("Anna rivinmäärä: ");
            int rivi = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < rivi; j++)
            {
                System.Console.Write("Rivi " +(j+1)+": ");
                for (int i = 0; i < 7; i++)
                {

                    Random rnd = new Random();
                    int number = rnd.Next(0, 40);
                    System.Console.Write(number + ", ");
                    Thread.Sleep(200);
                }
                System.Console.Write("\n");
            }

        }
    }
}
