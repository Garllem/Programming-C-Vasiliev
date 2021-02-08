using System;

namespace Listing_9._11_Indexator_s_nechislovim_indexom
{
    //Класс и индексатором
    class MyClass
    {
        //Целочисленное поле
        public int code;
        //Конструктор с одним аргументом
        public MyClass(int n)
        {
            code = n;
        }
        //Целочисленный индексатор с индексом , который является объектом класса MyClass
        public int this[MyClass obj]
        {
            //Считывание
            get
            {
                //Результат
                return code - obj.code;
            }
            //Метод вызывается при присваивании значения
            set
            {
                //Присваивание значение полю
                code = obj.code + value;
            }
        }
    }
    class NonIndexDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass A = new MyClass(100);
            //проверка значения
            Console.WriteLine("Объект А: {0}",A.code);
            //Создание объекта
            MyClass B = new MyClass(150);
            //проверка значения
            Console.WriteLine("Объект B: {0}", B.code);
            //Использование индексатора
            int num = A[B];
            Console.WriteLine("Выражение A[B]={0}",num);
            Console.WriteLine("Выражение B[A]={0}", B[A]);
            A[B] = 200;
            //Проверка значения поля объекта
            Console.WriteLine("Объект А: {0}", A.code);
        }
    }
}
