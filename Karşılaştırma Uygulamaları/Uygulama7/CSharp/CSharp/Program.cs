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
            int vize = 80;
            int final = 70;
            int ortalama = (vize * 40 / 100) + (final * 60 / 100);
            if (ortalama < 40)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else if (ortalama > 40 && ortalama < 55)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else if (ortalama > 55 && ortalama < 59)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else if (ortalama > 59 && ortalama < 69)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else if (ortalama > 69 && ortalama < 75)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else if (ortalama > 75 && ortalama < 84)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else if (ortalama > 84 && ortalama < 90)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else if (ortalama > 90 && ortalama < 101)
            {
                Console.WriteLine("FF - Kaldı\n Ortalama: " + ortalama);
            }
            else
            {
                Console.WriteLine("Geçerli bir not değeri bulunamadı...");
            }
            Console.Read();
        }
    }
}
