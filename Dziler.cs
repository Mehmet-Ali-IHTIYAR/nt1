using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] tckimlik = new long[3];
            tckimlik[0] = 12345678912;
            tckimlik[1] = 12366786772;
            tckimlik[2] = 45433678912;

            for(int i=0; i< tckimlik.Length;i++)
               Console.WriteLine(tckimlik[i]);

            string[] adlar = 
                new string[] { "Ahmet", "Ayşe", "Fatma", "Veli" };

            foreach (string ad in adlar)
                Console.Write(ad + " ");

            int[] sayilar = new int[]{ 12,55,32,64,84,22,44};
            int[] kopya = new int[sayilar.Length];

            Console.WriteLine();

            for (int i = 0; i < sayilar.Length; i++)
                kopya[i] = sayilar[i];

            foreach (int i in kopya)
                Console.Write(i + " ");



        }
    }
}
