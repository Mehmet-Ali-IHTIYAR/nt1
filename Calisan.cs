using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim2
{
    class Calisan : Kisi
    {
        public string id = "ABC567EFG";
        public override void BilgiAl()  // Ana sınıftaki BilgiAl sanal metodu
           // değiştirilerek yeni bilgiler ekleniyor
        {
            // Calling the base class GetInfo method:
            base.BilgiAl();
            Console.WriteLine("Calısan ID: {0}", id);
        }
    }
}
