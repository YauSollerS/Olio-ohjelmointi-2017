using System;
/// <summary>
/// Tehtävä 17
/// Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen 
/// kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö.
/// Esimerkkitoiminta:
///    Luvut taulukossa 1 : 10,20,30,40,50
///    Luvut taulukossa 2 : 5,15,25,35,45
///    Luvut yhdistetyssä taulukossa : 5,10,15,20,25,30,35,40,45,50
/// </summary>

namespace T17
{
    class T17
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr2 = new int[5] { 5, 15, 25, 35, 45 };

            System.Console.Write("Luvut taulukossa 1 : ");
            for(int i=0; i < arr1.Length;i++)
            {
                System.Console.Write(arr1[i]+", ");
            }
            System.Console.Write("\n");
            System.Console.Write("Luvut taulukossa 2 : ");
            for (int j = 0; j < arr2.Length; j++)
            {
                System.Console.Write(arr2[j] + ", ");
            }
            System.Console.Write("\n");


            int[] arr3 = new int[arr1.Length+arr2.Length];

     
            
            for (int k = 0; k < arr1.Length; k++)
            {
                arr3[k] = arr1[k];
            }
            for (int l = 0; l < arr2.Length; l++)
            {
                arr3[arr1.Length + l] = arr2[l];
            }
            

            Array.Sort(arr3);

            System.Console.Write("Luvut yhdistetyssä taulukossa : ");
            for (int m = 0; m < arr3.Length; m++)                  
                Console.Write(arr3[m] + " , " );

            System.Console.Write("\n");
        }
    }
}
