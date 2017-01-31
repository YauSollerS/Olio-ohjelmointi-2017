using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto.
/// Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. Huomioi 
/// mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.
/// </summary>
/// 

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(@"D:\test.txt");
                
                do
                {
                    Console.Write("Give a text line (enter ends). Enter #stop# to STOP  : ");
                    string line = Console.ReadLine();
                    if (line == "#stop#")
                    {
                        break;
                    }
                    outputFile.WriteLine(line);
                    
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

                if (outputFile != null)
                {
                    outputFile.Close();
                }

            }

            string text = System.IO.File.ReadAllText(@"D:\test.txt");

            System.Console.WriteLine("\nContents of text.txt :\n{0}", text);
        }
    }
}
