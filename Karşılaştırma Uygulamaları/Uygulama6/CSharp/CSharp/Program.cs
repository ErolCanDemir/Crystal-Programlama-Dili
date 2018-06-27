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
            int sayi1 = 50;
            int sayi2 = 10;
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam = " + toplam);
            Console.WriteLine("-----------------------------");
            int fark = sayi1 - sayi2;
            Console.WriteLine("Fark = " + fark);
            Console.WriteLine("-----------------------------");
            int carpim = sayi1 * sayi2;
            Console.WriteLine("Çarpım = " + carpim);
            Console.WriteLine("-----------------------------");
            int bolum = sayi1 / sayi2;
            Console.WriteLine("Bölüm= " + bolum);
            Console.Read();
        }
    }
}
