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
            int k = 0;
            int l = 0;
            int[] no = { 1, 2, 3, 4, 5 };
            string[] ad = { "Erol", "Can", "Mert", "Esad", "Tolga" };
            string[] soyad = { "Demir", "Alan", "Çetin", "Topkara", "Taş" };
            string[] sehir = { "Ankara", "İstanbul", "İzmir", "Konya", "Ankara" };
            string[] semt = { "Sincan", "Pendik", "Karşıyaka", "Selçuklu", "Keçiören" };
            Console.WriteLine("Tüm Personellerin Listesi");
            Console.WriteLine("-----------------------------------------");
            while (i < 5)
            {
                Console.Write(no[i] + "\t" + ad[i] + "\t" + soyad[i] + "\t" + sehir[i] + "\t" + semt[i] + "\n");
                Console.WriteLine("-----------------------------------------");
                i++;
            }
            Console.WriteLine("Numarası 4 olan Personel Listesi");
            Console.WriteLine("-----------------------------------------");
            while(j<5)
            {
                if(no[j] == 4)
                {
                    Console.Write(no[j] + "\t" + ad[j] + "\t" + soyad[j] + "\t" + sehir[j] + "\t" + semt[j] + "\n");
                    Console.WriteLine("-----------------------------------------");
                }
                j++;
            }
            Console.WriteLine("Adı Esad olan Personel Listesi");
            Console.WriteLine("-----------------------------------------");
            while (k < 5)
            {
                if (ad[k] == "Esad")
                {
                    Console.Write(no[k] + "\t" + ad[k] + "\t" + soyad[k] + "\t" + sehir[k] + "\t" + semt[k] + "\n");
                    Console.WriteLine("-----------------------------------------");
                }
                k++;
            }
            Console.WriteLine("Ankara'da Oturan Personel Listesi");
            Console.WriteLine("-----------------------------------------");
            while (l < 5)
            {
                if (sehir[l] == "Ankara")
                {
                    Console.Write(no[l] + "\t" + ad[l] + "\t" + soyad[l] + "\t" + sehir[l] + "\t" + semt[l] + "\n");
                    Console.WriteLine("-----------------------------------------");
                }
                l++;
            }
            Console.Read();
        }
    }
}
