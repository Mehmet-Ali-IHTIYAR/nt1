using System;

namespace Asal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir Sayi Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool asalmi = true;
            int sayac = 0;

            for(int i=2; i < sayi; i++)
            {
                for(int j=2; j<i;j++)
                {
                    if (i % j == 0)
                    {
                        asalmi = false;
                        break;
                    }
                   
                }
                 // Asal ise sayacı bir artır
                if(asalmi != false) {
                    sayac++;
                    if (sayac % 5 != 0)
                        Console.Write(i + " ");
                    else
                        Console.WriteLine(i);
                }
                   
                asalmi = true;
            }


        }
    }
}
