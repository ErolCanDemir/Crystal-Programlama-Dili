using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int[] dizi = { 1, 2, 4, 3, 5 };
            Console.WriteLine("İlk Hali");
            Console.WriteLine("-----------------------------------");
            while (i < 5)
            {
                Console.Write(dizi[i] + "\t");
                i++;
            }
            int gecici = dizi[2];
            dizi[2] = dizi[3];
            dizi[3] = gecici;
            Console.WriteLine("");
            Console.WriteLine("Sıralanmış Hali");
            Console.WriteLine("-----------------------------------");
            while (j < 5)
            {
                Console.Write(dizi[j] + "\t");
                j++;
            }
            Console.Read();
        }
    }
}
