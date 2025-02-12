﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace Listing_8._5_Peregruzka_neskolkih_oeratorov_srsvneniya
{
    class MyClass
    {
        public int code;
        public MyClass (int n)
        {
            code = n;
        }
        //Перегрузка оператора меньше или равно
        public static MyClass operator<=(MyClass a, MyClass b)
        {
            if (a.code <= b.code) return a;
            else return b;
        }
        //Перегрузка оператора больше или равно
        public static MyClass operator >=(MyClass a, MyClass b)
        {
            if (a.code >= b.code) return a;
            else return b;
        }
        //Перегрузка оператора меньше или равно
        public static bool operator<=(MyClass a, int x)
        {
            if (a.code <= x - 1) return true;
            else return false;
        }
        //Перегрузка оператора больше или равно
        public static bool operator >=(MyClass a, int x)
        {
            if (a.code >= x + 1) return true;
            else return false;
        }

        //Перегрузка опреатора меньше
        public static bool operator<(MyClass a, MyClass b)
        {
            return a.code < b.code;
        }
        //Перегрузка оператора больше
        public static bool operator >(MyClass a, MyClass b)
        {
            return a.code > b.code;
        }
        //Перегрузка оператора меньше
        public static int operator<(MyClass a, int x)
        {
            return x - a.code;
        }
        //Перегрузка оператора больше
        public static int operator>(MyClass a, int x)
        {
            return a.code - x;
        }

    }
    class MoreOverloadingCompsDemo
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            Console.WriteLine("Объект А: {0}", A.code);
            Console.WriteLine("Объект B: {0}", B.code);
            //Использоване операторов меньше и больше
            Console.WriteLine("A<B даёт {0}", A<B);
            Console.WriteLine("A>B даёт {0}", A > B);
            //Объектная переменная
            MyClass C;
            //Использование оператора больше или равно
            C = A >= B;
            //Новое значение поля
            C.code = 300;
            Console.WriteLine("Объект В: {0}", B.code);
            //Использование опреатора меньше или равно
            C = A <= B;
            //Новое значение поля
            C.code = 150;
            Console.WriteLine("Объект A: {0}", A.code);
            (B <= A).code = 500;
            Console.WriteLine("Объект A: {0}", A.code);
            //Целочисленные переменные
            int x = 400, y = 500, z = 600;
            //Использование операторов меньше или равно и больше или равно
            Console.WriteLine("A<={0} даёт {1}", x, A<=x);
            Console.WriteLine("A>={0} даёт {1}", x, A >= x);
            Console.WriteLine("A<={0} даёт {1}", y, A <= y);
            Console.WriteLine("A>={0} даёт {1}", y, A >= x);
            Console.WriteLine("A<={0} даёт {1}", z, A <= z);
            Console.WriteLine("A>={0} даёт {1}", z, A >= z);
            //Использование операторов меньше и больше
            Console.WriteLine("A<{0} даёт {1}", z, A < z);
            Console.WriteLine("A<{0} даёт {1}", x, A > x);


        }
    }
}
