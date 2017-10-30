using System;
using System.Collections;

namespace Koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Kuyruk Oluşturmak 
            Queue ku = new Queue();
            ku.Enqueue("IlkOkul");
            ku.Enqueue("Ortaokul");
            ku.Enqueue("Lise");
            ku.Enqueue("On Lisans");
            ku.Enqueue("Lisans");
            ku.Enqueue("Yuksek Lisans");
            ku.Enqueue("Doktora");

            Console.WriteLine(ku.Dequeue().ToString());
            Console.WriteLine(ku.Dequeue().ToString());
            Console.WriteLine(ku.Dequeue().ToString());

            IEnumerator indeks = ku.GetEnumerator();

            while(indeks.MoveNext())
            {
                Console.WriteLine("O anki seviye " + 
                    indeks.Current.ToString());
            }

            Stack masa = new Stack();

            masa.Push("tabak_1");
            masa.Push("tabak_2");
            masa.Push("tabak_3");
            masa.Push("tabak_4");
            masa.Push("tabak_5");
            masa.Push("tabak_6");

            Console.WriteLine("Pop yapilan deger : "+ masa.Pop().ToString());
            Console.WriteLine("Pop yapilan deger : " + masa.Pop().ToString());
            indeks = masa.GetEnumerator();
            while (indeks.MoveNext())
            {
                Console.WriteLine(indeks.Current.ToString());
            }


            Hashtable openWith = new Hashtable();

            // Add some elements to the hash table. There are no 
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is 
            // already in the hash table.
            try  // Hata Yakalama 
            {
                openWith.Add("txt", "winword.exe");
            }
            catch  // Hata Yakala ve kodları çalıştır
            {
                Console.WriteLine("\"txt\" anahtarı zaten mevcut.");
            }




            ArrayList elemanlar = new ArrayList();
            elemanlar.Add("Ahmet");
            elemanlar.Add(154);
            elemanlar.Add(545.548);
            elemanlar.Add(true);
            foreach (object o in elemanlar)
                Console.Write(o.ToString() + " ");

        }
    }
}
