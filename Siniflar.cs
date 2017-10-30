using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;






namespace Siniflar
{

    class Insan
    {
        string ad;
        public double boy, kilo;
        protected int yas;

        public Insan(string isim)
        {
            ad = isim;
            boy = 0.55;
            kilo = 3.5;
            yas = 1;
        }

        public void bilgiYaz()
        {
            Console.WriteLine("Ad : {0}, Kilo :{1} ,  Boy {2}",ad, kilo, boy);
        }

    }

        class Ogrenci: Insan
        {
            public Ogrenci(string isim) : base(isim) { }
        }


    


    class Program
    {
        static void Main(string[] args)
        {
            ArrayList elemanlar = new ArrayList();
            elemanlar.Add("Ahmet");
            elemanlar.Add(1565);
            elemanlar.Add(true);
            elemanlar.Add(122.45);

            foreach(object o in elemanlar)
                Console.WriteLine(o.ToString());

            Console.WriteLine("--------------------");

            elemanlar.Remove(true);

            foreach (object o in elemanlar)
                Console.WriteLine(o.ToString());


            Hashtable ht = new Hashtable(){ {"Ahmet",24 },
                { "Mehmet",30 },
                { "Hasan",40 },{"Aylin",25 } };


            foreach (DictionaryEntry elm in ht)
            {
                Console.WriteLine("Kisi = {0}, Yas = {1}", elm.Key, elm.Value);
            }


            Ogrenci o1 = new Ogrenci("Ahmet Cengiz");
            o1.bilgiYaz();


        }
    }
}
