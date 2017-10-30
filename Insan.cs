using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    class Insan
    {
        public Insan(string isim)
        {
            Ad = isim; Boy = 1.5; Kilo = 55; _yas = 12;
        }
        public string Ad { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        private int _yas;
        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value > 150 || value < 0)
                    _yas = 0;
                else
                    _yas = value;
            }
        }

        public void BilgiYaz()
        {
            Console.WriteLine(Ad + " " + Yas + " " + Boy + " " + Kilo);
        }
    }
}


