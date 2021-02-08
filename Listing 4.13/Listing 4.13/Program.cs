using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_4._13
{
    class Program
    {
        //Главный метод с аргументом - массивом

        static void Main(string[] args)
        {
            //Определение количества переданных параметров 
            Console.WriteLine("Передано {0} параметров", args.Length);
            //Отображение значений параметров
            for(int k=0;k<args.Length;k++)
            {
                //Отображение значений параметра
                Console.WriteLine("{0}-й параметр: {1}", (k + 1), args[k]);
            }
            Console.WriteLine("Выполнение програмы завершено");
            Console.ReadKey();

        }
    }
}
