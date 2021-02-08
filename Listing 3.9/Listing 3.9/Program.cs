using System;

namespace Listing_3._9
{
    class DoWhileDemo
    {
        static void Main(string[] args)
        {
            //Количесто слагаемых в сумме, индексная переменная и значение суммы
            int n = 10, k = 1, s = 0;
            Console.WriteLine("Сумма 1 + 3 + 5 + ... + {0} = ", 2 * n - 1);
            //Оператор цикла
            do
            {
                s += 2 * k - 1;
                k++;
            } while (k <= n);
            
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
