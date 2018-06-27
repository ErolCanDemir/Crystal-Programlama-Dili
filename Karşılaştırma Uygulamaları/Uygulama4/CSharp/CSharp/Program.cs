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
            int i = 1;
            int j = 1;
            int karesi;
            while(i<20)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.Write("\n");
            Console.WriteLine("--------------Kareleri----------------");
            while (j < 20)
            {
                karesi = j * j;
                Console.WriteLine(karesi);
                j++;
            }
            Console.Read();
        }
    }
}
