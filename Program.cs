using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OzYineli
{
    class Program
    {

        static int Topla(int n)
        {
            if (n == 0) return 0;
            else
                return n + Topla(n - 1);
        }

        static long Faktoriyel (int n)
        {
            if (n == 1) return 1;
            else
                return n * Faktoriyel(n - 1); 
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Toplamını bulmak istediğiniz sayıyı girin : ");
            int sayi = Convert.ToInt16(Console.ReadLine());

            int sonuc=  Topla(sayi);
            long sonucFak = Faktoriyel(sayi);

            Console.WriteLine("Toplam : {0} Faktoriyel : {1}",sonuc,sonucFak);


        }
    }
}
