using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitkiAlemi
{
    class Agac : Bitki
    {
        public Agac(string ad)
        {
            Ad = ad;
        }

        public override void Buyu()
        {
            base.Buyu();
            Boy += 2.5;
           
        }
    }
}
