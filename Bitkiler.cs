using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitkiAlemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Agac kayin = new Agac("Kayin");
            Console.WriteLine("Benim Adım : " + kayin.Ad);
            kayin.FotoSentez();
            for(int i=0; i<10;i++)
            kayin.Buyu();
        }
    }
}
