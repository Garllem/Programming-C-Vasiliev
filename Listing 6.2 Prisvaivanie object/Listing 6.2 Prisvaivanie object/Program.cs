using System;

namespace Listing_6._2_Prisvaivanie_object
{
    //Описание класса
    class MyClass
    {
        //Целочисленное поле
        public int number;
        //метод для отображения значения поля
        public void show()
        {
            Console.WriteLine("Значение поля: "+number);
        }
    }
    //Класс с главным методом
    class AnotherObjDemo
    {
        //Главный метод
        static void Main(string[] args)
        {
            //Объектные переменные
            MyClass A, B;
            //Создание объекта
            A = new MyClass();
            //Присваивание объектных переменных
            B = A;
            //Присваивание значения полю через первую объектную переменную
            A.number = 123;
            //Вызов метода через вторую объектную переменную
            B.show();
            //Присваивание значения полю через вторую объектную переменную
            B.number = 321;
            //Вызов метода через первую объектную переменную
            A.show();
        }
    }
}
