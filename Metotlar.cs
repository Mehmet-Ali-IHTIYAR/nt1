using System;

namespace MetotlarGece
{
    class Program
    {
        static int f;  // Global kapsam
        static int alan(int a, int b)
        {
            
            int d = 0;  // Lokal kapsam metod içinde geçerli
            return a * b; 
        }

        
        
        static void Yaz()
        {
            Console.WriteLine("************ALAN HESAPLA**********");
            
        }
        static int alan(int yaricap)
        {
            return Convert.ToInt16(Math.PI * yaricap * yaricap);
        }

        static int alan(int k1,int k2, int k3)
        {
            float s = (k1 + k2 + k3) / 2;
            return Convert.ToInt16(Math.Sqrt(s * (s - k1) * (s - k2) * (s - k3)));
        }

        static void Main(string[] args)
        {
            Yaz();

            

            Console.WriteLine("Bir sekil secmek icin Rakam Giriniz " +
                ": 1. Daire 2. Dortgen 3. Ucgen");
            int secenek = Convert.ToInt16(Console.ReadLine());
            int sonuc = 0;

            switch (secenek)
            {
                case 1:
                    Console.WriteLine("Yaricap degerini Giriniz");
                    int yc = Convert.ToInt16(Console.ReadLine());
                    sonuc = alan(yc);
                    break;
                case 2:
                    Console.WriteLine("Ilk kenar : ");
                    int a = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Diger Kenar");
                    int b = Convert.ToInt16(Console.ReadLine());
                    sonuc = alan(a,b);
                    break;
                case 3:
                    Console.WriteLine("Ilk kenar : ");
                    int x = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Ikinci Kenar");
                    int y = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Diger Kenar");
                    int z = Convert.ToInt16(Console.ReadLine());
                    sonuc = alan(x,y,z);
                    break;
                default:
                    sonuc = 0;
                    break;


               }
            Console.WriteLine("Sectiginiz Sekil Icin Hesaplanan Alan : " + sonuc);

        }
    }
}
