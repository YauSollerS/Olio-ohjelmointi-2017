using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
    class BlackJack
    {
        static void Main()
        {

            int theirNumber;
            string jatko;
            int luku = 0;

            System.Console.WriteLine("*** BlackJack! ***");

            do
            {
                Random rnd = new Random();
                int myNumber = rnd.Next(10, 22);
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 

                theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                //comparing that given umber is valid

                if (theirNumber < 1 || theirNumber > 21)
                {
                    Console.WriteLine("The given number is out of limits, try again.");
                }
                else
                {
                    //comparing
                    if (theirNumber >= myNumber && theirNumber <= 21)
                    {
                        System.Console.WriteLine("You win.");
                    }
                    else
                    {
                        System.Console.WriteLine("You lose.");
                    }
                }

                System.Console.Write("Computer Score is  ");
                System.Console.WriteLine(myNumber);

                System.Console.Write("If you want EXIT than write X tai EXIT: ");
                jatko = Console.ReadLine();
                if (jatko == "X" || jatko == "EXIT")
                {
                    luku = 1;
                }
                else
                    luku = 0;

            } while (luku == 0);
        }
    }
}
