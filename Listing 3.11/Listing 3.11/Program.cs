﻿using System;

namespace Listing_3._9
{
    class DoWhileDemo
    {
        static void Main(string[] args)
        {
            //Количесто слагаемых в сумме, индексная переменная и значение суммы
            int n = 10, k, s;
            Console.WriteLine("Сумма 1 + 3 + 5 + ... + {0} = ", 2 * n - 1);
            //Оператор цикла
            for (k = 1, s = 0; k <= n; s += 2 * k - 1, k++);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}