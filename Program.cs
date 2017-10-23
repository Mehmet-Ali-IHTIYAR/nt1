using System;

namespace Yildiz
{
    class Program
    {
        static void Main(string[] args)
        {

            while (false) {

                string yildiz = "";
                Console.WriteLine("0-255 arasında rakam girin : ");
                byte ySayi = Convert.ToByte(Console.ReadLine());
                for (int i = 1; i <= ySayi; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        yildiz += "*";
                    }
                    Console.WriteLine(yildiz);
                    yildiz = "";
                }

            }

            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";


            for (int i = 0; i < gunler.Length; i++)
            {
                gunler[i] = gunler[i] + " Gunu";
                Console.WriteLine("Bugun {0} ", gunler[i]);
            }

            foreach(string gun in gunler)
            {
               // gun = gun + " Gunu";
                Console.WriteLine("Bugun Gunlerden {0}", gun);
            }


            //Console.WriteLine("Gün 1-7 arasında değer girin :");
            //gun = Convert.ToByte(Console.ReadLine());

            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Günlerden : {0}", gunler[gun - 1]);
            //        break;
            //    case 2:
            //        Console.WriteLine("Günlerden : {0}", gunler[gun - 1]);
            //        break;
            //    case 3:
            //        Console.WriteLine("Günlerden : {0}", gunler[gun - 1]);
            //        break;
            //    case 4:
            //        Console.WriteLine("Günlerden : {0}", gunler[gun - 1]);
            //        break;
            //    case 5:
            //        Console.WriteLine("Günlerden : {0}", gunler[gun - 1]);
            //        break;
            //    case 6:
            //        Console.WriteLine("Günlerden : {0}", gunler[gun - 1]);
            //        break;
            //    case 7:
            //        Console.WriteLine("Günlerden : {0}", gunler[gun - 1]);
            //        break;
            //    default:
            //        Console.WriteLine("Böyle Bir gün yok");
            //        break;

            //}


            Console.WriteLine("--------ÇARPIM TABLOSU ------------");
            Console.WriteLine();
            Console.WriteLine();



        

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                   Console.Write("{0}*{1}= {0,3}\t",i,j, i * j);
                Console.WriteLine();
            }
              


        }





    }
}
