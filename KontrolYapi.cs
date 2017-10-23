using System;

namespace KonrolYapi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Girdiğiniz Sayıya Kadar Olan Asal Sayıları Yazar : ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            bool asalmi = true;
            int sayac = 0;
            for (int i = 2; i <= sayi; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        asalmi = false;
                        break;
                    }
                }
                if (asalmi == true)
                {
                    Console.Write(i + " ");
                    sayac++; 
                    if(sayac % 5 == 0)
                        Console.WriteLine();
                }
                asalmi = true;
            }

            Console.WriteLine("-----Yıldızları Yazdır---------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 5 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");
            int yildizsayisi =0;
            for(int a=0;a<10;a++)
            {
                
                for (int b=10 ; b >0; b--)
                {
                   if(a < b/2 - a)
                        Console.Write(" ");
                   else if(a > (b/2 - a) && a < (b/2 + a))
                        Console.Write("*");
                   else
                        Console.Write(" ");
                    
                }
                Console.WriteLine();
                yildizsayisi++;
            } 

        }




    }
}
