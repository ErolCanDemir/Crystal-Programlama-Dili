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
            int[] dizi = { 1, 4, 20, 10, 50 };
            int i = 1;
            int j = 1;
            int max = 0, min = 0;
            while (i<5)
            {
                max = dizi[0];
                if(dizi[i]>max)
                {
                    max = dizi[i];
                }
                i++;
            }
            Console.WriteLine("Dizinin maksimum değeri = " + max);
            Console.WriteLine("---------------------------------");
            while (j < 5)
            {
                min = dizi[0];
                if (dizi[j] < min)
                {
                    min = dizi[j];
                }
                j++;
            }
            Console.WriteLine("Dizinin minimum değeri = " + min);
            Console.Read();
        }
    }
}
