using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon
/// kuin reaaliluvut. Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö
/// jollain tekstieditorilla.
/// </summary>

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile1 = null;
            System.IO.StreamWriter outputFile2 = null;

            try
            {
                outputFile1 = new System.IO.StreamWriter(@"D:\kokonaisluvut.txt");
                outputFile2 = new System.IO.StreamWriter(@"D:\reaaliluvut.txt");

                int kokonaisluk;
                float reaaliluk;

                do
                {
                    Console.Write("Give a number (enter or not a number ends) : ");
                    string line = Console.ReadLine();
                    if (!(int.TryParse(line, out kokonaisluk)) && !(float.TryParse(line, out reaaliluk)))
                    {
                        break;
                    }
                    else
                    {
                        if (int.TryParse(line, out kokonaisluk))
                        {
                            outputFile1.WriteLine(line);
                        }
                        else if (float.TryParse(line, out reaaliluk))
                        {
                            
                            outputFile2.WriteLine(line);
                        }
                    }
                    
                } while (true);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Opened stream is not writable (ArgumentException)");
            }
            
            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
            finally
            {
                
                if (outputFile1 != null)
                {
                    outputFile1.Close();
                }
                if (outputFile2 != null)
                {
                    outputFile2.Close();
                }
            }
            string text1 = System.IO.File.ReadAllText(@"D:\kokonaisluvut.txt");

            System.Console.WriteLine("\nContents of kokonaisluvut.txt :\n{0}", text1);

            string text2 = System.IO.File.ReadAllText(@"D:\reaaliluvut.txt");

            System.Console.WriteLine("\nContents of reaaliluvut.txt :\n{0}", text2);
        }
    }
}
