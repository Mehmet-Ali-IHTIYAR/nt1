using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitkiAlemi
{
    class Bitki
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public double Boy { get; set; }
        public string Rengi { get; set; }
        public string Mevsim { get; set; }
        public int Yas { get; set; }
        public virtual void Buyu()
        {
            Boy += 0.5;
            Console.WriteLine("Yasasin buyudum boyum " + Boy);
        }
        public virtual void FotoSentez()
        {
            Console.WriteLine("O2 yi gönderdim hayirli olsun");
        }
    }
}
