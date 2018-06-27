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
            int sayi = 5;
            if(sayi % 2 == 0)
            {
                Console.Write("Sayi çifttir.");
            }
            else
            {
                Console.Write("Sayı tektir.");
            }
            Console.Read();
        }
    }
}
