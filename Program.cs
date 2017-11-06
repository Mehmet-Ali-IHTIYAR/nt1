using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int elemanSayisi = sayilar.Length;
            string[] isimler = new string[5]; 
            Console.WriteLine("Eleman Sayısı : " + elemanSayisi);

            sayilar[5] = 100;
            sayilar[9] = 12457;

            Random r = new Random();

            for(int i = 0; i<sayilar.Length; i++)
            {
                sayilar[i] = r.Next(100);
                Console.WriteLine(sayilar[i]);
            }

            isimler[3] = "Ahmet";

            foreach(string isim in isimler)
                Console.WriteLine(isim);

            // Array.Clear(sayilar, 0, 10);

            //Array.Reverse(sayilar);

            Array.Sort(sayilar);
            Array.Reverse(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }



            string[] sehirler = new string[6] { "Ankara", "Samsun", "Tokat", "Amasya", "İstanbul", "İzmir" };
            Console.WriteLine("Hangi Şaardensin Gardaş Kime Baktın ?? : ");
            string aranan = Console.ReadLine();
           int sirasi = Array.IndexOf(sehirler, aranan);

            Console.WriteLine("Aradığın şaare {0}. sırada ulaşıldı {1}",sirasi + 1,aranan);
        }
    }
}
