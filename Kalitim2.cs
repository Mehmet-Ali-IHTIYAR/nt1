using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi();
            k.BilgiAl();

            Calisan c1 = new Calisan();
            c1.BilgiAl();

            Kisi k1 = c1; // calisan Kisi den türediği için ana sınıf nesnesi içerisine atanabilir UpCasting

            k.BilgiAl();

            c1 = (Calisan)k;

            c1.BilgiAl();

        }
    }
}
