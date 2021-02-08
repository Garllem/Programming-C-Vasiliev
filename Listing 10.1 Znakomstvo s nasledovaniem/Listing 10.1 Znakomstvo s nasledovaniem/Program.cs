using System;

namespace Listing_10._1_Znakomstvo_s_nasledovaniem
{
    //Базовый класс
    class Base
    {
        //Открытое целочисленное поле
        public int code;
        //Открытый метод
        public void show()
        {
            //Отображение значения поля
            Console.WriteLine("Поле code: "+code);
        }
    }
    //Производный класс
    class MyClass: Base
    {
        //Открытое символьное поле
        public char symb;
        //Открытый метод
        public void display()
        {
            //Отображение значения символьного поля
            Console.WriteLine("Поле symb: " + symb);
            //Вызов универсального метода
            show();
        }
        //Открытое свойство
        public int number
        {
            //Аксессор для считывания значения
            get
            {
                //Обращение к унаследованному полю
                return code;
            }
            //Аксессор для присваивания значения
            set
            {
                //Обращение к унаследованному полю
                code = value;
            }
        }
    }
    class InheritDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта производного класса
            MyClass obj = new MyClass();
            //Присваивание значений полям
            obj.code = 100;
            obj.symb = 'A';
            //Вызов метода
            obj.display();
            //Использование свойства
            obj.number = 200;
            Console.WriteLine("Свойство number: "+obj.number);
            //Вызов метода
            obj.show();
        }
    }
}
