using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metotlar
{
    class Program
    {
        static bool benNerdeYnlisYaptim = false;
        static int sayac = 0;
        static void Kontrol(string kadi,string sfr)
        {

            while (sayac < 3 && benNerdeYnlisYaptim == false)
            {




                if (kadi == "ADMIN" || kadi == "Admin"
                    || kadi == "admin")
                {
                    if (sfr == "123Try")
                    {
                        Console.WriteLine("Giriş Başarılı");
                    }
                    else
                    {
                        Console.WriteLine("Şifre Hatalı");
                        sayac++;
                        Console.WriteLine("Hata Yaptınız : {0}", sayac);
                    }

                }
                else
                {
                    Console.WriteLine("Kullanıcı Adı Hatalı");
                    sayac++;
                    Console.WriteLine("Hata Yaptınız : {0}", sayac);
                }


                if (sayac >= 3)
                {
                    Console.WriteLine("Şifre veya Kullanıcı Adı 3 Kez Hatalı Girilmiştir Hesabınız bloke oldu :(");
                    benNerdeYnlisYaptim = true;

                }
                else if (benNerdeYnlisYaptim == true)
                {
                    Console.WriteLine("Hesabınız Bloke Edildi");
                }
                else
                {
                    Console.WriteLine("Kullanıcı Adınızı Giriniz : ");
                    kadi = Console.ReadLine();
                    Console.WriteLine("Şifrenizi Girin : ");
                    sfr = Console.ReadLine();
                }
            }
            
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Kullanıcı Adınızı Giriniz : ");
            string k = Console.ReadLine();
            Console.WriteLine("Şifrenizi Girin : ");
            string s = Console.ReadLine();

            Kontrol(k, s);


        }
    }
}
