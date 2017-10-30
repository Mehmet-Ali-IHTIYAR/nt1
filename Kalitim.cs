using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
class Program
    {
        static void Main(string[] args)
        {

            Ogrenci o1 = new Ogrenci("Mehmet Yilmaz");
            o1.Yas = 149;
            o1.Ad = "Ömer";
            o1.BilgiYaz();
            o1.Oku();

            Insan i = new Insan("Bende İnsanım");
            i.BilgiYaz();
            



        }
    }
}
