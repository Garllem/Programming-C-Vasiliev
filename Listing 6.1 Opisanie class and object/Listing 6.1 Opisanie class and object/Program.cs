using System;

namespace Listing_6._1_Opisanie_class_and_object
{
    class MyClass
    {
        //целочисленное поле
        public int number;
        //Символьное поле
        public char symbol;
        //метод
        public void show()
        {
            //Отображение значения целочисленного поля
            Console.WriteLine("Целочисленное поле: "+number);
            //Отображение символьного поля
            Console.WriteLine("Символьное поле: "+symbol);
        }
    }
    // Класс с главным методом
    class UsingObjsDemo
    {
        //Главный метод
        static void Main()
        {
            //Первый объект
            MyClass A = new MyClass();
            //Объектная переменная
            MyClass B;
            //Второй объект
            B = new MyClass();
            //Присваивание значений полям первого объекта
            A.number = 123;
            A.symbol = 'A';
            //Присваивание значений полям второго объекта
            B.number = 321;
            B.symbol = 'B';
            //Вызов метода
            Console.WriteLine("Первый объект");
            A.show();
            Console.WriteLine("Второй объект");
            B.show();

        }
    }
}
