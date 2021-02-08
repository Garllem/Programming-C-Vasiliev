using System;

namespace Listing_8._11_Operaacii_prisvaivaniya_i_peregruzki_operatorov
{
    //Класс с перегрузкой опреаторов
    class MyClass
    {
        //Целочисденное поле
        public int code;
        //Конструктор с оодним аргументом
        public MyClass(int n)
        {
            code = n;
        }
        //Опреаторный метод для сложения объектов
        public static MyClass operator+(MyClass a, MyClass b)
        {
            return new MyClass(a.code + b.code);
        }
        //Операторный метод для умножения объектов
        public static int operator*(MyClass a, MyClass b)
        {
            return a.code * b.code;
        }
        //Операторный метод для неявного приведения типа (из типа int к типу MyClass)
        public static implicit operator MyClass(int n)
        {
            return new MyClass(n);
        }
    }
    class OverloadingAndAssigningDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass A = new MyClass(7);
            //Проверка результата
            Console.WriteLine("Объект А: {0}", A.code);
            //Создание объекта
            MyClass B = new MyClass(8);
            //Проверка результата
            Console.WriteLine("Объект B: {0}", B.code);
            //Вычисление сумму объектов с использованием сокращенной формы оператора присвоения
            A += B;
            //Проверка результата
            Console.WriteLine("Объект А: {0}", A.code);
            //Вычисление произведения объектов с использованием сокращённой формы оператора присвоения 
            A *= B;
            //Проверка результата
            Console.WriteLine("Объект А: {0}", A.code);
        }
    }
}
