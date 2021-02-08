using System;

namespace Listing_10._6_Zameshenie_chlenov_pri_nasledovanii
{
    //Базовый класс
    class Base
    {
        //Целочисленное поле
        public int code;
        //Метод для отображения значения поля
        public void show()
        {
            Console.WriteLine("Класс Base: "+code);
        }
        //Конструктор с одним аргументом
        public Base(int n)
        {
            code = n;
        }
    }
    //Производный класс
    class MyClass: Base
    {
        //Новое поле замещает одноименное поле
        //унаследованное из базового класса
        new public int code;
        //Новый метод замещает одноимённый метод унаследованный из бзового класса
        new public void show()
        {
            //Вызов версии метода из базового класса
            base.show();
            //Обращение к полю производного класса
            Console.WriteLine("Класс MyClass: "+code);
        }
        //Метод для присваивания значения полю унаследованному из базового класса и замещенному в производном классе
        public void set(int n)
        {
            //Обращение к полю унаследованному из базового класса и замещенному в производном классе
            base.code = n;
        }
        //Конструктор с двумя аргументами
        public MyClass(int m,int n): base(m)
        {
            //Присваивание значения полю производного класса
            code = n;
        }
    }
    class InheritAndHidingDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта класса
            MyClass obj = new MyClass(100, 200);
            //Отображение значений полей объекта
            obj.show();
            Console.WriteLine();
            //Присваивание значения замещаемому полю
            obj.set(300);
            //Присваивание значения замещаемому полю
            obj.code = 400;
            //Отображение значений полей объекта
            obj.show();
        }
    }
}
