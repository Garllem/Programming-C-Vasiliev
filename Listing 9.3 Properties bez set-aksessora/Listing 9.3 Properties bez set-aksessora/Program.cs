using System;

namespace Listing_9._3_Properties_bez_set_aksessora
{
    //Класс со свойствами
    class MyClass
    {
        //Открытые целочисленные поля
        public int first;
        public int last;
        //Конструктор с двумя аргументами
        public MyClass(int a, int b)
        {
            first = a;
            last = b;
        }
        //Целочисленное свойство (доступно только для чтения)
        public int sum
        {
            //Метод вызываемый при считывании
            get
            {
                //Значение свойства
                return first + last;
            }
        }
    }
    class WithoutSetDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass(1, 9);
            //Проверка значения свойства
            Console.WriteLine("Сумма полей: "+obj.sum);
            //Присваивание значения полю
            obj.first = 6;
            //Проверка значения свойства
            Console.WriteLine("Сумма полей: " + obj.sum);
            //Присваивание значения полю
            obj.last = 2;
            //Проверка значения свойства
            Console.WriteLine("Сумма полей: " + obj.sum);
        }
    }
}
