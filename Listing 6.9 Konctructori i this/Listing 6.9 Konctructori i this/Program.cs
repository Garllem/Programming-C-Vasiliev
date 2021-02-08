using System;

namespace Listing_6._9_Konctructori_i_this
{
    //Класс с перегрузкой конструкторов
    class MyClass
    {
        //Целочисленный поля
        public int alpha;
        public int bravo;
        //Конструктор с одним аргументом
        public MyClass(int a)
        {
            //Сообщение в консольном окне
            Console.WriteLine("Конструктор с одним аргументом");
            //Значение полей
            alpha = a;
            bravo = alpha;
            //Отображение значений
            Console.WriteLine("Оба поля равны "+alpha);
        }
        //Конструктор с двумя аргументами
        public MyClass(int a, int b): this(a)
        {
            //Сообщение в консольном окне
            Console.WriteLine("Конструктор с двумя аргументами");
            //Значение второго поля
            bravo = b;
            //Отображение значений
            Console.WriteLine("Поля " +alpha+" и " +bravo);
        }
        //Конструктор без аргументов
        public MyClass(): this(400,500)
        {
            //Сообщение в консольном окне
            Console.WriteLine("Конструктор без аргументов");
            //Отображение значений
            Console.WriteLine("Поля " + alpha + " и " + bravo);
        }
    }
    //Класс с главным методом
    class ConstrAndThisDemo
    {
        static void Main(string[] args)
        {
            //Вызов конструктора с одним аргументом
            MyClass A = new MyClass(100);
            Console.WriteLine();
            //Вызов Конструктора с двумя аргументами
            MyClass B = new MyClass(200, 300);
            Console.WriteLine();
            //Вызов конструктора с без аргументов
            MyClass C = new MyClass();
        }
    }
}
