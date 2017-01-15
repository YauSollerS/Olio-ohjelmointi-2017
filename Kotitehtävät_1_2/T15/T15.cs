using System;
/// <summary>
/// Tehtävä 15
/// Tee ohjelma, joka tulostaa seuraavanlaisen kuvion.Kysy käyttäjältä puunkorkeus käytä juurena kaksi
/// korkeuden yksikkö.
///   Anna Luku > 7 [Enter]
///        *
///       ***
///      *****
///     *******
///    *********
///        *
///        *
/// </summary>

namespace T15
{
    class T15
    {
        static void Main(string[] args)
        {
            int luku;
            int ram = 1;
            System.Console.Write("Anna luku > ");
            luku = Convert.ToInt32(Console.ReadLine());

            int body = luku - 2;

            for (int i = 0; i < body; i++)
            {
                for (int j = 0; j < (body-i); j++)
                {
                    System.Console.Write(" ");
                }


                
                for (int k = 0; k < ram; k++)
                {
                    System.Console.Write("*");
                }
                ram = ram + 2;
                
                System.Console.Write("\n");
            }
            for (int j = 0; j < body; j++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write("*");
            System.Console.Write("\n");
            for (int j = 0; j < body ; j++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write("*");
            System.Console.Write("\n");
        }
    }
}
