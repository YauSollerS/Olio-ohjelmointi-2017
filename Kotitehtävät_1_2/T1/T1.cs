using System;
/// <summary>
/// Tehtävä 1
///Tee ohjelma, joka tulostaa käyttäjän antamaa lukua(1, 2 tai 3) vastaavan luvun sanana(yksi, kaksi tai kolme).
/// Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
/// </summary>


namespace T1
{
    class T1
    {
        static void Main(string[] args)
        {

            int luku;
            System.Console.Write("Anna luku > ");

            luku = Convert.ToInt32(Console.ReadLine());

            if (luku == 1 || luku == 2 || luku == 3)
            {
                if (luku == 1)
                    System.Console.WriteLine("Annoit luvun on yksi ");
                if (luku == 2)
                    System.Console.WriteLine("Annoit luvun on kaksi ");
                if (luku == 3)
                    System.Console.WriteLine("Annoit luvun on kolme ");
            }
            else
                System.Console.WriteLine("joku muu luku ");
        }
    }
}
