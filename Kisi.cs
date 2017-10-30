using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim2
{
    class Kisi
    {
        protected string sgk = "444-55-6666";
        protected string ad = "Tekin Ahmet";

        public virtual void BilgiAl()
        {
            Console.WriteLine("Ad: {0}", ad);
            Console.WriteLine("SGK: {0}", sgk);
        }
    }
}
