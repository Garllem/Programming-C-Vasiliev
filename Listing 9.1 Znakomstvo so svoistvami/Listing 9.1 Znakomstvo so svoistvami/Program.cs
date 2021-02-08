﻿using System;

namespace Listing_9._1_Znakomstvo_so_svoistvami
{
    //Класс со свойствами
    class MyClass
    {
        //Закрытые целочисленные поля
        private int num;
        private int min;
        private int max;
        //Конструктор с двумя аргументами
        public MyClass(int a,int b)
        {
            //Присваивание значения полям
            min = a;
            max = b;
            //Присваивание значения свайству
            code = (max + min) / 2;
        }
        //Описание целочисленного свойства
        public int code
        {
            //Метод вызывается при считывании значения свайства
            get
            {
                //Значение свойства
                return num;
            }
            //Метод вызывается при присваивании значения свойству
            set
            {
                //Если присваиваемое значение меньше максимально допустимого
                if (value < min) num = min;
                //Если присваиваемое значение боьше максимально допустимого
                else if (value > max) num = max;
                //Если присваиваемое значение попадает в допустимый диапазон
                else num = value;
            }
        }
    }
    class UsingPropsDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass(1, 9);
            //Проверка значения свойства
            Console.WriteLine("Свойство code: "+obj.code);
            //Присваивание значения свойству
            obj.code = 7;
            //Проверка значения свойства
            Console.WriteLine("Свойство code: " + obj.code);
            //Присваивание значения свойству
            obj.code = 20;
            //Проверка значения свойства
            Console.WriteLine("Свойство code: " + obj.code);
            //Присваивание значения свойству
            obj.code = -10;
            //Проверка значения свойства
            Console.WriteLine("Свойство code: " + obj.code);
        }
    }
}
