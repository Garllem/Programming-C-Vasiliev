using System;

namespace Listing_6._7_Using_static_poley_i_method
{
    //Класс со статическими методами и полями
    class MyMath
    {
        //Константное поле (число пи)
        public const double Pi = 3.141592;
        //Закрытое статическое поле (граница суммы)
        private static int N = 100;
        //Статический метод для вычисления экспоненты
        public static double exp(double x)
        {
            //Сумма и добавка к сумме
            double s = 0, q = 1;
            //Вычисление суммы
            for(int k=0; k<=N; k++)
            {
                s += q; //Прибавление добавки к сумме
                q *= x / (k + 1); //Добавка для следующей итерации
            }
            //Результат
            return s;
        }
        //Статический метод для вычисления синуса
        public static double sin(double x)
        {
            //Сумма и добавка к сумме
            double s = 0, q = x;
            //Вычисление суммы
            for (int k = 0; k <= N; k++)
            {
                s += q; //Прибавление добавки к сумме
                q *= (-1)*x*x/(2*k+2)/(2*k+3); //Добавка для следующей итерации
            }
            return s;
        }
    }
    //Главный класс
    class StaticDemo
    {
        //Главный метод
        static void Main(string[] args)
        {
            //Аргумент для статических методов
            double z = 1;
            //Вычисление экспоненты
            Console.WriteLine("exp({0})={1}", z, MyMath.exp(z));
            //Контрольное значение
            Console.WriteLine("Контрольное значение: {0}", MyMath.exp(z));
            //Новое значение аргумента
            z = MyMath.Pi / 4;
            //Вычисление Синуса
            Console.WriteLine("sin({0})={1}", z, MyMath.sin(z));
            //Контрольное значение
            Console.WriteLine("Контрольное значение: {0}", MyMath.sin(z));
        }
    }
}
