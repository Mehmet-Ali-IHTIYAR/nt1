using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
   class Ogrenci : Insan
    {
        public Ogrenci(string ad) : base(ad) { }  // Kurucu metodunu temel alıyor
        public void BilgiYaz()
        {
            base.BilgiYaz(); // Insan clasının BilgiYaz Metodu
        }
        public void Oku()
        {
            Console.WriteLine("Okuyorum abi...");
        }
         
      

    }
}
