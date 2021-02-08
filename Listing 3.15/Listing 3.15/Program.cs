using System;

namespace Listing_3._9
{
    class ForDemo
    {
        static void Main(string[] args)
        {
            //Количесто слагаемых в сумме, индексная переменная и значение суммы
            int n = 10, k = 1, s = 0;
            Console.WriteLine("Сумма 1 + 3 + 5 + ... + {0} = ", 2 * n - 1);
            //Использование метки
            mylabel:
            //Добавляем слагаемое в сумму
            s += 2 * k - 1;
            //Изменение значения индексной переменной
            k++;
            //Использование инструкции togo
            if (k <= n) goto mylabel;
          
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}