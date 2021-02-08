using System;

namespace Listing_8._1_Znakomstvo_s_peregruzkoi_operatorov
{
    //Класс с перегрузкой оператора сложения
    class myClass
    {
        //Целочисленное поле
        public int number;
        //Конструктор с целочисленным аргументом
        public myClass(int n)
        {
            //Присваиваивание значения полю
            number = n;
        }
        //Операторный метод для перегрузки оператора сложения
        public static int operator+ (myClass a, myClass b)
        {
            //Локальная целочисленная переменная
            int m = a.number + b.number;
            //Результат метода
            return m;
        }
    }
    //Класс с главным методом
    class OverloadingOperatorPlusDemo
    {
        //Главный метод
        static void Main(string[] args)
        {
            myClass A = new myClass(100);
            myClass B = new myClass(200);
            //Целочисленная переменная
            int num;
            //Вычисление суммы объектов
            num = A + B;
            //Отображение результата вычисления суммы объекта
            Console.WriteLine("A+B="+num);
        }
    }
}
