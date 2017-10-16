using System;

namespace BisikletUygulama
{

    class Bisiklet
    {
         int hiz, vites, vitesSayisi, tekerCapi; // Default private
        public Bisiklet()  // Kurucu metod
        {
            vitesSayisi = 6;
        }
        public Bisiklet(int v) // kurucu metod aşırı yükleme 
        {
            vitesSayisi = v;
        }
        public void Hizlan(int artis) {
            hiz += artis;
        }
        public void FrenYap(int azalis) {
            hiz -= azalis;
        }
        public void VistesDegistir(int yeniDeger) {
            vites = yeniDeger;
        }
        public void BilgileriYaz() {
            Console.WriteLine("Şu anki hiziniz : {0}", hiz);
            Console.WriteLine("Şu anki vitesiniz : {0}", vites);
            Console.WriteLine("En yuksek vites  {0}:", vitesSayisi);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bisiklet b1 = new Bisiklet();
           
            b1.Hizlan(10);
            b1.VistesDegistir(3);
            b1.BilgileriYaz();
            b1.FrenYap(5);
            b1.VistesDegistir(2);
            b1.BilgileriYaz();
           
        }
    }
}
