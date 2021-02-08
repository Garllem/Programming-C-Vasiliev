using System;

namespace Listing_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] znak = new string[] {"-","+"};
            int i;
            


            for (int k=0;k<10;k++)
            {
                int s = rnd.Next(1, 99);
                int p = rnd.Next(1, s);
                             
                i = rnd.Next(0, znak.Length);
                int f;
                if (i == 0)
                {
                    f = s - p;
                }
                else { 
                     f = s + p;
                     }

                Console.WriteLine("{0} {1} {2} = {3}", s, znak[i], p, f);


            }
            
            Console.ReadKey();
        }
    }
}
