using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.Write("Give a text line (enter ends). P : ");
                    string line = Console.ReadLine();
                    if (line == "0")
                    {
                        break;
                    }
                    outputFile.WriteLine(line);
                    
                } while (true);
            }
            catch (Exception)
            {

                Console.WriteLine("You don't gave a number!");
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
