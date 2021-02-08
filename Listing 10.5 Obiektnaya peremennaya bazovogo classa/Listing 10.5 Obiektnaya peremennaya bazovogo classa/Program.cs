using System;

namespace Listing_10._5_Obiektnaya_peremennaya_bazovogo_classa
{
    //Базовый класс
    class Base
    {
        //Целочисленное поле 
        public int code;
        //Открытый метод
        public void show()
        {
            Console.WriteLine("Поле code: "+code);
        }
        //Конструктор с целочисленным аргументом
        public Base(int n)
        {
            code = n;
        }
        //Конструктор создания копии           
        public Base(Base obj)
        {
            code = obj.code;
        }
    }
    //Производный класс
    class MyClass: Base
    {
        //Символьное поле:
        public char symb;
        //Открытый метод
        public void display()
        {
            Console.WriteLine("Поле symb: "+symb);
        }
        //Конструктор с двумя аргументами
        public MyClass(int n, char s):base(n)
        {
            symb = s;
        }
        //Конструктор создания копии
        public MyClass(MyClass obj): base(obj)
        {
            symb = obj.symb;
        }
    }
    class BaseObjVarDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта производного класса 
            MyClass A = new MyClass(100, 'A');
            //Объектная переменная базового класса
            Base obj;
            //Объектной переменной базового класса присваивается ссылка на объект производного класса
            obj = A;
            Console.WriteLine("Используем переменную obj:");
            //Вызов метода через объектную переменную базового класса
            obj.show();
            //Использовано явное приведение типа
            ((MyClass)obj).display();
            //Обращение к полю через объектную переменную базового класса
            obj.code = 200;
            //Использовано явное приведение типа
            ((MyClass)obj).symb = 'B';
            Console.WriteLine("Используем переменную A:");
            //Вызов методов через объектную переменную производного класса
            A.show();
            A.display();
            //Создание копии объекта
            MyClass B = new MyClass(A);
            //Изменение значений полей исходного объекта
            A.code = 0;
            A.symb = 'O';
            Console.WriteLine("Используем переменную B:");
            //Проверка значений полей объекта-копии
            B.show();
            B.display();

        }
    }
}
