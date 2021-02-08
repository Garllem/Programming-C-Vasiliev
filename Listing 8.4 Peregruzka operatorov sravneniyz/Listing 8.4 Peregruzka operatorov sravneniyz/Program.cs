using System;

namespace Listing_8._4_Peregruzka_operatorov_sravneniyz
{
    //Класс с перегрузкой операторов сравнения
    class MyClass
    {
        //Символьное поле
        public char symb;
        //Конструктор с одним аргументом
        public MyClass (char s)
        {
            //Присваивание значения полю
            symb = s;
        }
        //Перегрузка оператора меньше или равно
        public static bool operator <=(MyClass a, MyClass b)
        {
            if (a.symb <= b.symb) return true;
            else return false;
        }
        //Перегрузка оператора больше или равно
        public static bool operator >=(MyClass a, MyClass b)
        {
            if (a.symb >= b.symb) return true;
            else return false;
        }
    }
    //Класс с главным методом
    class OverloadingCompOperatorsDemo
    {
        //Главный метод
        static void Main(string[] args)
        {
            //Создание объектов
            MyClass A = new MyClass('A');
            MyClass B = new MyClass('B');
            MyClass C = new MyClass('A');
            //Использование опрераторов сравнения
            Console.WriteLine("A<=B даёт {0}", A<=B);
            Console.WriteLine("A>=B даёт {0}", A >= B);
            Console.WriteLine("A<=C даёт {0}", A <= C);
            Console.WriteLine("A>=C даёт {0}", A >= C);
        }
    }
}
