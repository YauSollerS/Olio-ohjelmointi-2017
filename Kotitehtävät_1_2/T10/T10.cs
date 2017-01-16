using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10
{
    class T10
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[9] { 1,2,33,44,55,68,77,96,100};

            for (int i=0; i<arr1.Length;i++)
            {
                int jak = arr1[i] % 2;
                if (jak == 0)
                    System.Console.Write(arr1[i] + " HEP! \n");
                else
                    System.Console.Write(arr1[i] + "\n");
            }

        }
    }
}
