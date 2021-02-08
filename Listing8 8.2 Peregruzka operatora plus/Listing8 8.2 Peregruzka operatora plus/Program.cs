using System;

namespace Listing8_8._2_Peregruzka_operatora_plus
{
    //Класс с перегрузкой опреатора "плюс"
    class MyClass
    {
        //Целочисленные поле
        public int number;
        //Конструктор с одним аргументом
        public MyClass(int n)
        {
            //Присваивание значения полю
            number = n;
        }
        //Переопределение метода ToString()
        public override string ToString()
        {
            //Результат метода
            return "Поле number: " + number;
        }
        //Операторный метод для вычисления суммы двух объектов
        public static MyClass operator+(MyClass a, MyClass b)
        {
            //Целочисленная локальная переменная
            int m = a.number + b.number;
            //Создание объекта класса
            MyClass t = new MyClass(m);
            //Результат метода
            return t;
        }
        //Операторный метод для вычисления суммы объекта и целого числа
        public static MyClass operator+(MyClass a, int x)
        {
            //Целочисленная локальная переменная
            int m = a.number + x;
            //Результат метода
            return new MyClass(m);
        }
        //Операторный метод для вычисления суммы целого числа и объекта
        public static MyClass operator+(int x, MyClass a)
        {
            //Результат метода
            return a + x;
        }
        //Операторный метод для унарного оператора плюс
        public static int operator+(MyClass a)
        {
            //Результат метода
            return a.number;
        }
    }
    //Класс с главным методом
    class MoreOverloadingPlusDemo
    {
        //Главный метод
        static void Main(string[] args)
        {
            //Создание объектов
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            //Вычисление суммы объектов
            MyClass C = A + B;
            //Проверка результата
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            //Вычисление суммы объекта и целого числа
            C = A+1;
            //Проверка результата
            Console.WriteLine(C);
            //Вычисление суммы целого числа и объекта
            C = 10 + A;
            //Проверка результата
            Console.WriteLine(C);
            Console.Write("Унарный оператор: ");
            //Используется унарный плюс
            Console.WriteLine(+C);
            int num = (+A) + (+B);
            //Проверка результата
            Console.WriteLine("Сумма чисел: "+num);
        }
    }
}
