using System;
/// <summary>
/// Tehtävä 18
/// Tee ohjelma, joka kysyy käyttäjältä merkkijonon(lause). Sovelluksen tulee ilmoittaa käyttäjälle oliko 
/// annettu merkkijono palidromi.
/// </summary>
namespace T18
{
    class T18
    {
        static void Main(string[] args)
        {
            string lause;
            System.Console.Write("Anna lause: ");
            lause = System.Console.ReadLine();

            char[] text = lause.ToCharArray();

            Array.Reverse(text);

            string rev = new string(text);

            if(lause==rev)
            {
                System.Console.Write("Lause on palindromi\n");
            }

            if (lause != rev)
            {
                System.Console.Write("Lause ei ole palindromi\n");
            }

        }
    }
}
