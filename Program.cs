using System;

namespace DonguKiran
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(char k ='A'; k <= 'Z'; k++)
            {
                if (k == 'R')
                    break;
                Console.Write(k + " ");
            }

            int x =0, y=0;
            while(x < 10)
            {
              Console.WriteLine("x {0} iken y {1}",x,y);
                x++;
                continue;
                y++;
            }

            int a = 10, b = 20;
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
            goto son;

            Console.WriteLine("{0}* {1} = {2}",a,b,a*b);

            son: Console.WriteLine("Program Bitti");
        }
    }
}
